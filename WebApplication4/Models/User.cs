using System;

namespace WebApplication4.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string Phone { get; set; }

    }
}