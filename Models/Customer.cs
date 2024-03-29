﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyTutorial.Models
{
    public class Customer
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set;}
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}