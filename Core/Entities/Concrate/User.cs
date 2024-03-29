﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrate
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public string Number{ get; set; }
        public string Address { get; set; }
        public int Gender{ get; set; }
        public DateTime DateOfBirth{ get; set; }

    }
}
