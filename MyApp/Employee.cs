﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public struct Employee
    {
        private int _id;
        private string _name;
        public string Role;
      
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public Employee(int Id, string Name, string Role)
        {
            this._id = Id;
            this._name = Name;
            this.Role = Role;  
        }

        public void ShowEmployeeData()
        {
            Console.WriteLine("\t");
            Console.WriteLine("EMPLOYEE DETAILS: ");
            Console.WriteLine("\t");
            Console.WriteLine("ID: " + this._id);
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Role: " + this.Role);
        }
    }
}
