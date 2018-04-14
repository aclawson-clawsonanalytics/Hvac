using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hvac.Views
{

    public class ReferenceDocumentMasterDetailPageMenuItem
    {
        public ReferenceDocumentMasterDetailPageMenuItem()
        {
            TargetType = typeof(ReferenceDocumentMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}