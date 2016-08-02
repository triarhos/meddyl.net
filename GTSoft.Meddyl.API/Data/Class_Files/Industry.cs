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
	public class Industry : GTSoft.Meddyl.API.Base_Industry
	{

        [DataMember(EmitDefaultValue = false)]
        public int active { get; set; }

	}
}

