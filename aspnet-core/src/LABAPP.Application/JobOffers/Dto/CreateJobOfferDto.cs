using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAPP.JobOffers.Dto
{
    [AutoMapTo(typeof(JobOffer))]
    public class CreateJobOfferDto
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
        public long CreatedByID { get; set; }
        public bool IsPublished { get; set; }
    }
}
