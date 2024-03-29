﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyTutorial.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}