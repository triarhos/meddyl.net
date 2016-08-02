using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GTSoft.Meddyl.API
{
	[DataContract]
	public class Base_Customer_Deal_Log
	{
		[DataMember(EmitDefaultValue=false)]
		public int log_id { get; set; }

		[DataMember(EmitDefaultValue=false)]
		public int customer_id { get; set; }

		[DataMember(EmitDefaultValue=false)]
		public int deal_id { get; set; }

		[DataMember(EmitDefaultValue=false)]
		public int search_location_type_id { get; set; }

		[DataMember(EmitDefaultValue=false)]
		public double longitude { get; set; }

		[DataMember(EmitDefaultValue=false)]
		public double latitude { get; set; }

		[DataMember(EmitDefaultValue=false)]
		public string zip_code { get; set; }

		[DataMember(EmitDefaultValue=false)]
		public DateTime entry_date_utc_stamp { get; set; }

	}
}

