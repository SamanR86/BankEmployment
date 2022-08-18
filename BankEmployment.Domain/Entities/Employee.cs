using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using BankEmployment.Domain.BaseEntities;

namespace BankEmployment.Domain.Entities
{
    public class Employee:IBase
    {
        public string? EmployeeNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? FathersName { get; set; }
        public string? NationalIdNo { get; set; }
        public string? IdentityCertificateNo { get; set; }
        public string? BirthDate { get; set; }
        public string? IdentityCertificatePlace { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? MilitaryStatus { get; set; }
        public string? HomeAddress { get; set; }
        public string? HomePostalCode { get; set; }
        public string? MobileNo { get; set; }
        public string? TelephoneNo { get; set; }
        public string? EmploymentDate { get; set; }
        public string? EmploymentConfirmationDate { get; set; }
        public string? EmploymentLawGroup { get; set; }
        public string? ContractType { get; set; }
        public string? OriginBank { get; set; }
        public string? BankAccountNo { get; set; }
        public string? CasualtyStatus { get; set; } // employee or his family who was killed or injured in the war.
        public int RegistrarUserId { get; set; }
        public string? RegisterDate { get; set; }
        public string? Description { get; set; }

        public City? BirthCity { get; set; }
        public City? ResidenceCity { get; set; }
    }
}
