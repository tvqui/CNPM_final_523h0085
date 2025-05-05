namespace DTO
{
    public class DTO_Customer
    {
        //private int customer_id;
        //private string first_name, last_name, customer_username, customer_password, phone, email, avatar_path;

        private string customer_id;
        private string first_name;
        private string last_name;
        private string customer_username;
        private string customer_password;
        private string phone;
        private string email;
        private string avatar_path;

        public string CustomerID { get => customer_id; set => customer_id = value; }
        public string FirstName { get => first_name; set => first_name = value; }
        public string LastName { get => last_name; set => last_name = value; }
        public string CustomerUsername { get => customer_username; set => customer_username = value; }
        public string CustomerPassword { get => customer_password; set => customer_password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string AvatarPath { get => avatar_path; set => avatar_path = value; }

        // Constructor chuẩn hóa
        public DTO_Customer(string id, string fname, string lname, string uname, string pass, string phone, string email, string avatar)
        {
            this.customer_id = id;
            this.first_name = fname;
            this.last_name = lname;
            this.customer_username = uname;
            this.customer_password = pass;
            this.phone = phone;
            this.email = email;
            this.avatar_path = avatar;
        }
    }
}
