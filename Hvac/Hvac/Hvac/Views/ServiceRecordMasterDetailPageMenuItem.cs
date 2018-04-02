﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hvac.Views
{

    public class ServiceRecordMasterDetailPageMenuItem
    {
        public ServiceRecordMasterDetailPageMenuItem()
        {
            //TargetType = typeof(ServiceRecordMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType
        {
            get
            {
                if (Title == "Service Locations")
                    return typeof(ServiceLocationsPage);
                if (Title == "Service Records")
                    return typeof(ServiceRecordsPage);
                return null;
            }
        }
    }
}