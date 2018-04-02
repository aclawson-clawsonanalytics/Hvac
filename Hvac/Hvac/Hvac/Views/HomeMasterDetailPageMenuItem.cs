using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hvac.Views
{

    public class HomeMasterDetailPageMenuItem
    {
        public HomeMasterDetailPageMenuItem()
        {
            //TargetType = typeof(HomeMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType
        {
            get
            {
                if (Title == "Service Records")
                    return typeof(ServiceRecordMasterDetailPageDetail);
                return typeof(HomeMasterDetailPageDetail);
            }
        }
    }
}