using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.BusinessLogic
{
    public class Formatters
    {
        public enum Unit
        {
            Lbs,
            Kgs
        }

        public static string LaunchWindowFormatter(DateTime date)
        {
            return date.ToString("M/d/yyyy h:mm tt");
        }

        public static string PayloadFormatter(double payload)
        {
            return string.Format("{0:n}", payload);
        }

        public static string LaunchpadFormatter(string launchpad)
        {
            Dictionary<string, string> launchPads = new Dictionary<string, string>()
            {
                { "VAFB SLC 3W", "Vandenberg Space Force Base Launchpad 3W" },
                { "STLS", "Boca Chica Village" },
                { "Kwajalein Atoll", "Kwajalein Atoll Omelek Island"},
                { "VAFB SLC 4E", "Vandenberg Space Force Base Launchpad 4E" },
                { "KSC LC 39A", "Cape Canaveral Launchpad 39A" },
                { "CCSFS SLC 40", "Cape Canaveral Launchpad 40"}
            };

            return launchPads[launchpad];
        }

        public static string LaunchOutcomeFormatter(bool? outcome)
        {
            if (outcome == true)
                return "Success!";
            else if (outcome == false)
                return "RUD";//Rapid Unscheduled Disassembly

            return "TBD";
        }

        public static string VehicleMassFormatter(double mass, Enum unit) 
        {
            if (unit is Unit.Kgs)
                return string.Format("{0:n0} kgs", mass);
            else if (unit is Unit.Lbs)
                return string.Format("({0:n0} lbs)", mass);
            else
                //throw new Exception("Error: Unit is not recognized.");
                return string.Empty;
        }

        public static string ThrustLbsFormatter(double thrust)
        {
            return string.Format("{0:n0} lbs", thrust);
        }

        public static string StageReusabilityFormatter(bool? reuse)
        {
            if (reuse == true)
                return "Reusable";
            else
                return "Non-Reusable";
        }

        public static string EngineFormatter(string engine, string version)
        {
            if (string.IsNullOrWhiteSpace(engine) || engine.Length < 2)
                return string.Empty;

            //Capitalize first char of engine name and then concatenate the engine version
            string formattedName = engine[0].ToString().ToUpper() + engine.Substring(1).ToLower();
            return $"{formattedName} {version}";
        }
    }
}
