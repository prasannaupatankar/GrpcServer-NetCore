using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class CompanyService : Company.CompanyBase
    {
        private readonly ILogger<CompanyService> _logger;
        public CompanyService(ILogger<CompanyService> logger)
        {
            _logger = logger;
        }

        public override Task<Response> PostCompanyWithEmployees(CompanyModel request, ServerCallContext context)
        {
            try
            {
                //Call a post API to insert the Company details
                //After successful post call return Status as 1 else 0
                return Task.FromResult(new Response
                {
                    Status = 1
                });
            }
            catch
            {
                return Task.FromResult(new Response
                {
                    Status = 0
                });
            }            
        }
    }
}
