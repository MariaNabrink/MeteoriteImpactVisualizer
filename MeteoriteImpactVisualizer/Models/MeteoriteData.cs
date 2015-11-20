using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoriteImpactVisualizer.Models
{
    public class MeteoriteData
    {
        public int Mass { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public GeographicalLocation Location { get; set; }
    }
}