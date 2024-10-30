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
        public List<User> Users { get; set; } = new();
        public void RegisterUser(User newUser)
        {
            string path = "users.json";
            if (!File.Exists(path)) File.Create(path);
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                if (text != "")
                {
                    Users = JsonSerializer.Deserialize<List<User>>(text)!;
                }
                if (Users.Find(p => p.Username != newUser.Username || p.Email != newUser.Email) == null)
                    Users.Add(newUser);
            }
        }
        public void SerializeUsersToJson(List<User> users, string fileName)
        {
            string json=JsonSerializer.Serialize(users);
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                writer.WriteLineAsync(json);
            }
        }
        public bool ExistUser(string username)
        {
            string path = "users.json";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                if (text != "")
                {
                    List<User> listDes = JsonSerializer.Deserialize<List<User>>(text)!;
                    if (listDes.Find(p => p.Username == username) != null)
                        return true;
                }
            }
            return false;
        }
        public List<User> getUsers()
        {
            string path = "users.json";
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                if (text != "")
                {
                    Users = JsonSerializer.Deserialize<List<User>>(text)!;
                }
            }
            return Users;
        }
    }
}
