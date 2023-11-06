﻿namespace CompanyApi
{
    public class Company
    {
        public Company(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
