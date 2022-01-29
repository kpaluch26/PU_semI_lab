using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramowanieUzytkoweIP12.ElasticModels
{
    public class ElasticLowLevelResponse<T>
    {
        public int took { get; set; }
        public bool timed_out { get; set; }

        public ElasticLowLevelResponseHits<T> hits { get; set; }
    }

    public class ElasticLowLevelResponseHits<T>
    {
        public IEnumerable<ElasticLowLevelResponseHitsNested<T>> hits { get; set; }
    }

    public class ElasticLowLevelResponseHitsNested<T>
    {
        public T _source { get; set; }
    }
}
