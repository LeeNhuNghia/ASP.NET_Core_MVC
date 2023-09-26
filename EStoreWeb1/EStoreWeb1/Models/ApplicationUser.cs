﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
    public DateTime Birthday { get; set; }
}