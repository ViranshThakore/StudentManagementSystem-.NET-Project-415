using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string RollNo { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.Now; 
    }
}