using System;
using Nest;

namespace ProgramowanieUzytkoweIP12.ElasticModels
{
	public class ElasticConnection : ConnectionSettings
	{
		public ElasticConnection(Uri uri = null) : base(uri)
        {
			this.DefaultMappingFor<ElasticModel>(x => x.IndexName("kibana_sample_data_ecommerce"));
			this.DefaultMappingFor<ElasticPerson>(x => x.IndexName("person_index"));
        }
	}
}
