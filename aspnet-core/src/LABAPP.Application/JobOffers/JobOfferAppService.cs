using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Dependency;
using Abp.Domain.Repositories;
using LABAPP.JobOffers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAPP.JobOffers
{
    [AbpAuthorize]
    public class JobOfferAppService : AsyncCrudAppService<JobOffer, JobOfferDto, long, PagedResultRequestDto, CreateJobOfferDto, JobOfferDto>, IJobOfferAppService, ITransientDependency
    {
        public JobOfferAppService(
    IRepository<JobOffer, long> repository)
    : base(repository)
        {
        }

    }
}
