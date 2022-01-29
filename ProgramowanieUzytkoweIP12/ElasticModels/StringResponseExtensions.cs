using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProgramowanieUzytkoweIP12.ElasticModels
{
    public static class StringResponseExtensions
    {
        public static IEnumerable<T> ToData<T>(this StringResponse source)
        {
            ElasticLowLevelResponse<T> response = (ElasticLowLevelResponse<T>)JsonSerializer.Deserialize(source.Body, typeof(ElasticLowLevelResponse<ElasticPerson>));
            return response.hits.hits.Select(h => h._source);
        }
    }
}
