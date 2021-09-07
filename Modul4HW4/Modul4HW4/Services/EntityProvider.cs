using System;
using System.Collections.Generic;
using Modul4HW4.Entities;

namespace Modul4HW4.Services
{
    public class EntityProvider
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Vlad",
                    LastName = "Vladov",
                    DateOfBirth = new DateTime(1999, 10, 13),
                    HiredDate = new DateTime(2020, 1, 3),
                    OfficeId = 1,
                    TitleId = 1
                },

                new Employee
                {
                    Id = 2,
                    FirstName = "Ivan",
                    LastName = "Stepanov",
                    DateOfBirth = new DateTime(1990, 5, 4),
                    HiredDate = new DateTime(2020, 1, 30),
                    OfficeId = 1,
                    TitleId = 1
                },

                new Employee
                {
                    Id = 3,
                    FirstName = "Mark",
                    LastName = "Fedorov",
                    DateOfBirth = new DateTime(1954, 7, 18),
                    HiredDate = new DateTime(2000, 6, 6),
                    OfficeId = 2,
                    TitleId = 2
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Tom",
                    LastName = "Black",
                    DateOfBirth = new DateTime(1968, 11, 15),
                    HiredDate = new DateTime(2010, 6, 6),
                    OfficeId = 2,
                    TitleId = 2
                },
            };
        }

        public List<EmployeeProject> GetEmployeeProject()
        {
            return new List<EmployeeProject>
            {
                new EmployeeProject
                {
                    Id = 1,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 1,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    Id = 2,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 2,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    Id = 3,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 3,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    Id = 4,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 4,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    Id = 5,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 4,
                    EmployeeId = 1,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    Id = 6,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 5,
                    EmployeeId = 3,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    Id = 7,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 3,
                    EmployeeId = 4,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    Id = 8,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 2,
                    EmployeeId = 3,
                    Rate = 100,
                }
            };
        }

        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Id = 1,
                    StartedDate = new DateTime(2021, 1, 1),
                    Budget = 1000,
                    Name = "HomeWork1",
                    ClientId = 1
                },
                new Project
                {
                    Id = 2,
                    StartedDate = new DateTime(2021, 1, 1),
                    Budget = 1000,
                    Name = "HomeWork2",
                    ClientId = 2
                },
                new Project
                {
                    Id = 3,
                    StartedDate = new DateTime(2021, 1, 1),
                    Budget = 1000,
                    Name = "HomeWork3",
                    ClientId = 3
                },
                new Project
                {
                    Id = 4,
                    StartedDate = new DateTime(2021, 1, 1),
                    Budget = 1000,
                    Name = "HomeWork4",
                    ClientId = 4
                },
                new Project
                {
                    Id = 5,
                    StartedDate = new DateTime(2021, 1, 1),
                    Budget = 1000,
                    Name = "HomeWork5",
                    ClientId = 5
                }
            };
        }

        public List<Office> GetOffices()
        {
            return new List<Office>
            {
                new Office
                {
                    Id = 1,
                    Location = "Ukraine, Kharkiv",
                    Title = "Zavod"
                },

                new Office
                {
                    Id = 2,
                    Location = "USA, NewYork",
                    Title = "IT Office"
                }
            };
        }

        public List<Title> GetTitles()
        {
            return new List<Title>
            {
                new Title
                {
                    Id = 1,
                    Name = "Programmer"
                },
                new Title
                {
                    Id = 2,
                    Name = "Worker"
                }
            };
        }

        public List<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    Id = 1,
                    FirstName = "X",
                    LastName = "X",
                    DateOfBirth = new DateTime(2021, 1, 10),
                    Revenue = 1000
                },

                new Client
                {
                    Id = 2,
                    FirstName = "X",
                    LastName = "X",
                    DateOfBirth = new DateTime(2021, 1, 10),
                    Revenue = 1000
                },
                new Client
                {
                    Id = 3,
                    FirstName = "X",
                    LastName = "X",
                    DateOfBirth = new DateTime(2021, 1, 10),
                    Revenue = 1000
                },
                new Client
                {
                    Id = 4,
                    FirstName = "X",
                    LastName = "X",
                    DateOfBirth = new DateTime(2021, 1, 10),
                    Revenue = 1000
                },
                new Client
                {
                    Id = 5,
                    FirstName = "X",
                    LastName = "X",
                    DateOfBirth = new DateTime(2021, 1, 10),
                    Revenue = 1000
                }
            };
        }
    }
}
