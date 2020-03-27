using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsDemo
{
    public class Person
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public double Credits { get; set; }
        public string Phone { get; set; }
        public Person()
        {
         
        }
        public Person(int studentID,
                        string name,
                        double credits,                        
                        string phone)
        {
            StudentID = studentID;
            Name = name;
            Credits = credits;
            Phone = phone;
        }
    }
}