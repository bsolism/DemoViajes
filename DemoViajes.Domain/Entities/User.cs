﻿namespace DemoViajes.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public string Sal { get; set; }

    }
}
