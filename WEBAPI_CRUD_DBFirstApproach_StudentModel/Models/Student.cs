using System;
using System.Collections.Generic;

namespace WEBAPI_CRUD_DBFirstApproach_StudentModel.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Department { get; set; }

    public int? Marks { get; set; }
}
