using System;
using System.Collections.Generic;
using System.Text;

namespace Winform
{
    internal class Users
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public int Id { get; set; }
        public Users(string name, string gender, string country, int id)
        {
            Name = name;
            Gender = gender;
            Country = country;
            Id = id;
        }
    }
}
