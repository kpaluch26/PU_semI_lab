using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nest;
using ProgramowanieUzytkoweIP12.ElasticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramowanieUzytkoweIP12.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EcommerceController : ControllerBase
    {
        public EcommerceController(IElasticClient elasticClient)
        {
            ElasticClient = elasticClient;
        }

        public IElasticClient ElasticClient { get; }

        [HttpGet]
        public IEnumerable<ElasticModel> Get([FromQuery] string query)
        {
            return ElasticClient.Search<ElasticModel>(x =>
                x.Query(q => q
                .Match(q => q
                .Field(f => f.Customer_first_name)
                .Query(query)))).Documents;
        }
    }
}
