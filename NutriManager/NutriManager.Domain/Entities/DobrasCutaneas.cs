using NutriManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Domain.Entities
{
    public class DobrasCutaneas : BaseEntity<int>
    {
        public DobrasCutaneas() { }
        public DobrasCutaneas(int id, float dobraTricipital, float dobraSubescapular, float dobraSuprailiaca, float dobraAbdominal, float dobraCoxa)
        {
            Id = id;
            DobraTricipital = dobraTricipital;
            DobraSubescapular = dobraSubescapular;
            DobraSuprailiaca = dobraSuprailiaca;
            DobraAbdominal = dobraAbdominal;
            DobraCoxa = dobraCoxa;
        }

        public float DobraTricipital { get; set; }
        public float DobraSubescapular { get; set; }
        public float DobraSuprailiaca { get; set; }
        public float DobraAbdominal { get; set; }
        public float DobraCoxa { get; set; }
    }
}
