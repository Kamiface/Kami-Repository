﻿using System;
using System.Collections.Generic;
using System.Linq;
using MVCProject.Models;

namespace MVCProject.ViewModels
{
    public class QuoteVm
    {

        public int Id { get; set; }
        public int Total { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}