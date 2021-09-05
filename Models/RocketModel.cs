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
        public double? MassKgs { get; set; }
        public double? MassLbs { get; set; }
        public List<string> RocketImageUrls { get; set; }
        public double? FirstStageSeaLevelThrustLbs { get; set; }
        public double? FirstStageVacuumThrustLbs { get; set; }
        public double? SecondStageVacuumThrustLbs { get; set; }
        public bool? FirstStageReusability { get; set; }
        public bool? SecondStageReusability { get; set; }
        public uint? NumberOfLandingLegs { get; set; }
        public object[] PayloadWeights { get; set; }
        public string EngineName { get; set; }
        public string EngineVersion { get; set; }
        public uint? FirstStageNumOfEngines { get; internal set; }
        public uint? SecondStageNumOfEngines { get; internal set; }
        public uint? SpecificImpulseSeaLevel { get; set; }
        public uint? SpecificImpulseVacuum { get; set; }
        public string FirstPropellant { get; set; }
        public string SecondPropellant { get; set; }
    }
}
