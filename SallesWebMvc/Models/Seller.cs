﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SallesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SallesRecord> Salles { get; set; } = new List<SallesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSalles(SallesRecord sr)
        {
            Salles.Add(sr);
        }

        public void RemoveSalles(SallesRecord sr)
        {
            Salles.Remove(sr);
        }

        public double TotalSalles(DateTime initial, DateTime final)
        {
            return Salles.Where(sr => sr.Date >= initial && sr.Date <= final)
                                .Sum(sr => sr.Amount);
        }
    }
}
