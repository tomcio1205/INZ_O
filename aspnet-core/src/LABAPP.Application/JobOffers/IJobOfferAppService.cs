using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LABAPP.JobOffers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAPP.JobOffers
{
    public interface IJobOfferAppService : IAsyncCrudAppService<JobOfferDto, long, PagedResultRequestDto, CreateJobOfferDto, JobOfferDto>
    {

    }

}
