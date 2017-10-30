﻿using System;
using System.Collections.Generic;

namespace CMS.Models.ResponseModels
{
    public partial class ResponseCustomers
    {
        public ResponseCustomers()
        {
            Products = new HashSet<ResponseProducts>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public ICollection<ResponseProducts> Products { get; set; }
    }
}
