﻿using System;
using System.Collections.Generic;

namespace SystemData.Models
{
    public partial class CustomerJobs
    {
        public CustomerJobs()
        {
            Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
