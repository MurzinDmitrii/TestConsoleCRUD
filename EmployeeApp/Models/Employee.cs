﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public decimal? Salary { get; set; }
}
