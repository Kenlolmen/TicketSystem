using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.ValueObjects
{
    public sealed record JobTitle
    {
        public string Value { get; }

        public JobTitle(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exceptions.EmptyJobStatusException();
            }

            Value = value;


        }
    public static readonly JobTitle Admin = new("Admin");
    public static readonly JobTitle TeamLeader = new("Team Leader");
    public static readonly JobTitle BackendDeveloper = new("Backend Developer");
    public static readonly JobTitle FrontendDeveloper = new("Frontend Developer");
    public static readonly JobTitle DevOpsEngineer = new("DevOps Engineer");
    public static readonly JobTitle ProjectManager = new("Project Manager");
    public static readonly JobTitle BusinessAnalyst = new("Business Analyst");
    public static readonly JobTitle QaEngineer = new("QA Engineer");
    public static readonly JobTitle UiUxDesigner = new("UI/UX Designer");
    public static readonly JobTitle ItSupport = new("IT Support");
    public static readonly JobTitle HrDepartment = new("HR Department");
    public static readonly JobTitle SalesSpecialist = new("Sales Specialist");
    public static readonly JobTitle MarketingSpecialist = new("Marketing Specialist");
    public static readonly JobTitle Accountant = new("Accountant");
    public static readonly JobTitle CustomerServiceSpecialist = new("Customer Service Specialist");
    public static readonly JobTitle EcommerceSpecialist = new("Ecommerce Specialist");
    public static readonly JobTitle ContentCreator = new("Content Creator");
    }

}