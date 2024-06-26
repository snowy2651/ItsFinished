﻿namespace PinewoodUI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int Accountno { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
