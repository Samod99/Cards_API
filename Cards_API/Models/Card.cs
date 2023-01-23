﻿using System.ComponentModel.DataAnnotations;

namespace Cards_API.Models
{
    public class Card
    {
        [Key]
        public Guid Id { get; set; }
        public string? CardholderName { get; set; }
        public string? CardNumber { get; set; }
        public int CVC { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
    }
}
