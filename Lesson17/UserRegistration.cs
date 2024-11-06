using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lesson17
{
    internal class UserRegistration
    {
        private string path = "users.json";
        public List<User> Users { get; set; } = new();
        public UserRegistration()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            getUsers();
        }
        public void RegisterUser(User newUser)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                if (Users.Find(p => p.Username == newUser.Username || p.Email == newUser.Email) == null)
                    Users.Add(newUser);
            }
        }
        public void SerializeUsersToJson(List<User> users)
        {
            string json=JsonSerializer.Serialize(users);
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLineAsync(json);
            }
        }
        public bool ExistUser(string username)
        {
            if (Users.Find(p => p.Username == username) != null)
                return true;
            return false;
        }
        public void getUsers()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                if (text != "")
                {
                    Users = JsonSerializer.Deserialize<List<User>>(text)!;
                }
            }
        }
        public string Hash(string text)
        {
            string res = "";
            for(int i = 0; i < text.Length; i++)
            {
                res += (int)(text[i]<<10);
            }
            return res;
        }
    }
}
