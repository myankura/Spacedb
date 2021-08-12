using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.Models
{
    public class RocketModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Height { get; set; }
        public string Diameter { get; set; }
        public string Mass { get; set; }
        public object[] FirstStage { get; set; }
        //second_stage
        public object[] SecondStage { get; set; }
        //landing_legs
        public int LandingLegs { get; set; }
        //payload_weights
        public object[] PayloadWeights { get; set; }// = new object[3];
        //engines/type
        public string EngineName { get; set; }
        //engines/version
        public string Version { get; set; }
        //engines/number
        public int NumberOfEngines { get; set; }
        public int MyProperty { get; set; }
    }
}
