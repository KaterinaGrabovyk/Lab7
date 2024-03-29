using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.DB
{
    public class Plants
    {//вид, умови зростання, період цвітіння, потреби у воді та добривах.
        public int Id { get; set; }
        public string PlantKind { get; set; }
        public string UmoviZrost { get; set; }
        public string PeriodCvit { get; set; }
        public string WaterNeeds { get; set; }
        public string DobrivaNeeds { get; set; }

    }
}
