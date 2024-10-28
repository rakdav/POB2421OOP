using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson17
{
    internal class UserRegistration
    {
        public List<User> Users { get; set; } = new();
        public void RegisterUser(User newUser)=>Users.Add(newUser);
        public void SerializeUsersToJson(List<User> users, string fileName)
        {
            string json=JsonSerializer.Serialize(users);
            using (StreamWriter writer = new StreamWriter("usersjson.json", false))
            {
                writer.WriteLineAsync(json);
            }
        }
    }
}
