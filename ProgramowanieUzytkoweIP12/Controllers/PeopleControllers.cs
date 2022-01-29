using Elasticsearch.Net;
using Microsoft.AspNetCore.Mvc;
using Nest;
using ProgramowanieUzytkoweIP12.ElasticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProgramowanieUzytkoweIP12.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IElasticClient _elasticClient;

        public PeopleController(IElasticClient elasticClient)
        {
            this._elasticClient = elasticClient;
        }

        [HttpPut("{id}")]
        public ElasticPerson Put(int id, [FromBody] ElasticPerson person)
        {
            person.Id = id;
            var res = _elasticClient.IndexDocument<ElasticPerson>(person);
            return _elasticClient.Get<ElasticPerson>(res.Id).Source;
        }

        [HttpGet("{id}")]
        public ElasticPerson GetOne(int id)
        {
            return _elasticClient.Get<ElasticPerson>(id).Source;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _elasticClient.Delete<ElasticPerson>(id).Result == Result.Deleted;
        }

        [HttpGet]
        public IEnumerable<ElasticPerson> Get([FromQuery] Pagination pagination, [FromQuery] string filter)
        {
            return _elasticClient.Search<ElasticPerson>(x => x.Size(pagination.Count).Skip(pagination.Count * pagination.Page)
            .Query(q => q
            .QueryString(qs => qs
            .Fields(f => f
            .Field(x => x.Name)
            .Field(x => x.Surname))
            .Query("*" + filter + "*")))).Documents;
        }

        [HttpGet("lowLevel")]
        public IEnumerable<ElasticPerson> GetLowLevel([FromQuery] Pagination pagination, [FromQuery] string filter)
        {
            string[] fields = { "name", "surname" };
            var x = new
            {
                size = pagination.Count,
                from = pagination.Page * pagination.Count,
                query = new
                {
                    query_string = new
                    {
                        fields = fields,
                        query = "*" + filter + "*"
                    }
                }
            };

            return _elasticClient.LowLevel.DoRequest<StringResponse>(HttpMethod.GET, "_search", PostData.Serializable(x)).ToData<ElasticPerson>();
        }
    }
}
