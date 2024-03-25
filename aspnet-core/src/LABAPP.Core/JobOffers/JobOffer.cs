using Abp.Domain.Entities;
using LABAPP.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAPP.JobOffers
{
    [Table("JOBOFFER")]
    public class JobOffer : Entity<long>
    {
        public string Position { get; set; }
        public string Body { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
        public string Localization { get; set; }
        public string CompanyName { get; set; }
        public int Salary { get; set; }
        public string ShortDescription { get; set; }
        public string ContractType { get; set; }

        [ForeignKey(nameof(CreatedByID))]
        public User User { get; set; }
        public long CreatedByID { get; set; }
        public bool IsPublished { get; set; }
    }
}
