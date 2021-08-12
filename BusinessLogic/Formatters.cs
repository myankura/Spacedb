using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.BusinessLogic
{
    public class Formatters
    {
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
                return "RUD";//Rapid Unscheduled Disassembly/shit blew up

            return "TBD";
        }
    }
}
