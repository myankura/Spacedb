using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.Models
{
    public class LaunchModel
    {
        public LaunchModel() { }

        public string Id { get; set; }
        public int FlightNumber { get; set; }
        public string MissionName { get; set; }
        public DateTime Date { get; set; }
        public string Rocket { get; set; }
        public bool? LaunchOutcome { get; set; }
        public string Launchpad { get; set; }
        public string Details { get; set; }
        public List<string> Crew { get; set; }
        public string SmallPatchUrl { get; set; }
        public string LargePatchUrl { get; set; }
        public string WebcastUrl { get; set; }
        public string ArticleUrl { get; set; }
        public string WikipediaUrl { get; set; }
        public double? PayloadWeight { get; set; }
    }
}
