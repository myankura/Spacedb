using Oddity;
using Spacedb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.BusinessLogic
{
    public class LaunchMethods : OddityBase
    {
        public static async Task<List<LaunchModel>> GetAllLaunches()
        {
            try
            {
                Console.WriteLine("EnterMethod: GetAllLaunches");
                var allLaunches = await oddity.LaunchesEndpoint.GetAll().ExecuteAsync();
                List<LaunchModel> launches = new List<LaunchModel>();
                foreach (var a in allLaunches)
                {
                    LaunchModel launch = new LaunchModel
                    {
                        Id = a.Id,
                        MissionName = a.Name,
                        Date = a.DateUtc.Value.ToLocalTime(),
                        Rocket = a.Rocket.Value.ToString(),
                        LaunchOutcome = a.Success,
                        SmallPatchUrl = a.Links.Patch.Small,
                        PayloadWeight = a.Payloads[0].Value.MassKilograms == null ? 0 : a.Payloads[0].Value.MassKilograms,
                        Launchpad = a.Launchpad.Value.ToString()
                    };
                    launches.Add(launch);
                }
                launches.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
                return launches;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured trying to get all launches: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("ExitMethod: GetAllLaunches");
            }
        }
        public static async Task<LaunchModel> GetUpcomingLaunch()
        {
            try
            {
                Console.WriteLine("EnterMethod: GetUpcomingLaunch");
                var nextLaunch = await oddity.LaunchesEndpoint.GetNext().ExecuteAsync();
                //Console.WriteLine("Datetime: {0}, Mission Name: {1}, Rocket: {2}, Payload(kg): {3}, Launchpad: {4}, Small patchURL: {5}", nextLaunch.DateUtc.Value.ToLocalTime(), nextLaunch.Name, nextLaunch.Rocket.Value.ToString(), nextLaunch.Payloads[0].Value.MassKilograms, nextLaunch.Launchpad.Value.ToString(), nextLaunch.Links.Patch.Small);
                LaunchModel next = new LaunchModel
                {
                    Id = nextLaunch.Id,
                    MissionName = nextLaunch.Name,
                    Date = nextLaunch.DateUtc.Value.ToLocalTime(),
                    Rocket = nextLaunch.Rocket.Value.ToString(),
                    SmallPatchUrl = nextLaunch.Links.Patch.Small,
                    PayloadWeight = nextLaunch.Payloads[0].Value.MassKilograms == null ? 0 : nextLaunch.Payloads[0].Value.MassKilograms,
                    Launchpad = nextLaunch.Launchpad.Value.ToString()
                };
                return next;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured trying to get upcoming launch: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("ExitMethod: GetUpcomingLaunch");
            }
        }
        public static async Task<LaunchModel> GetLaunchDetails(string id)
        {
            try
            {
                Console.WriteLine("EnterMethod: GetLaunchDetails");
                var queriedLaunch = await oddity.LaunchesEndpoint.Get(id).ExecuteAsync();
                LaunchModel launch = new LaunchModel
                {
                    MissionName = queriedLaunch.Name,
                    Date = queriedLaunch.DateUtc.Value.ToLocalTime(),
                    Rocket = queriedLaunch.Rocket.Value.ToString(),
                    SmallPatchUrl = queriedLaunch.Links.Patch.Small,
                    PayloadWeight = queriedLaunch.Payloads[0].Value.MassKilograms == null ? 0 : queriedLaunch.Payloads[0].Value.MassKilograms,
                    Launchpad = queriedLaunch.Launchpad.Value.ToString()
                };
                return launch;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured trying to get launch: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("ExitMethod; GetLaunchDetails");
            }
        }
        public static async Task<List<LaunchModel>> GetPastLaunches()
        {
            try
            {
                Console.WriteLine("EnterMethod: GetPastLaunches");
                var pastLaunches = await oddity.LaunchesEndpoint.GetPast().ExecuteAsync();
                List<LaunchModel> launches = new List<LaunchModel>();
                foreach (var p in pastLaunches)
                {
                    LaunchModel launch = new LaunchModel
                    {
                        Id = p.Id,
                        MissionName = p.Name,
                        Date = p.DateUtc.Value.ToLocalTime(),
                        Rocket = p.Rocket.Value.ToString(),
                        LaunchOutcome = p.Success,
                        SmallPatchUrl = p.Links.Patch.Small,
                        PayloadWeight = p.Payloads[0].Value.MassKilograms == null ? 0 : p.Payloads[0].Value.MassKilograms,
                        Launchpad = p.Launchpad.Value.ToString()
                    };
                    launches.Add(launch);
                }
                launches.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
                return launches;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured trying to get past launches: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("ExitMethod: GetPastLaunches");
            }
        }
        public static async Task<List<LaunchModel>> GetUpcomingLaunches()
        {
            try
            {
                Console.WriteLine("EnterMethod: GetUpcomingLaunches");
                var upcomingLaunches = await oddity.LaunchesEndpoint.GetUpcoming().ExecuteAsync();
                List<LaunchModel> launches = new List<LaunchModel>();
                foreach (var u in upcomingLaunches)
                {
                    LaunchModel launch = new LaunchModel
                    {
                        Id = u.Id,
                        MissionName = u.Name,
                        Date = u.DateUtc.Value.ToLocalTime(),
                        Rocket = u.Rocket.Value.ToString(),
                        LaunchOutcome = u.Success,
                        SmallPatchUrl = u.Links.Patch.Small,
                        PayloadWeight = u.Payloads[0].Value.MassKilograms == null ? 0 : u.Payloads[0].Value.MassKilograms,
                        Launchpad = u.Launchpad.Value.ToString()
                    };
                    launches.Add(launch);
                }
                launches.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
                return launches;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured trying to get upcoming launches: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("ExitMethod: GetUpcomingLaunches");
            }
        }
    }
}
