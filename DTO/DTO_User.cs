using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_User
    {
        private string user_id;
        private string username, password, role, avatar_path;
        private DateTime created_at;

        public string UserID { get => user_id; set => user_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string AvatarPath { get => avatar_path; set => avatar_path = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }

        public DTO_User() { }
        public DTO_User(string id, string username, string pass, string role, string avatar, DateTime created)
        {
            this.user_id = id;
            this.username = username;
            this.password = pass;
            this.role = role;
            this.avatar_path = avatar;
            this.created_at = created;
        }
    }
}
