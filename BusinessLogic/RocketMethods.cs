using Oddity;
using Spacedb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.BusinessLogic
{
    public class RocketMethods : OddityBase
    {
        public static async Task<List<RocketModel>> GetAllRockets()
        {
            try
            {
                Console.WriteLine("EnterMethod: GetAllRockets");
                var allRockets = await oddity.RocketsEndpoint.GetAll().ExecuteAsync();
                List<RocketModel> rockets = new List<RocketModel>();
                foreach (var r in allRockets)
                {
                    RocketModel rocket = new RocketModel
                    {
                        Id = r.Id,
                        Name = r.Name,
                        Height = r.Height.ToString(),
                        Diameter = r.Diameter.ToString(),
                        MassKgs = r.Mass.Kilograms,
                        MassLbs = r.Mass.Pounds,
                        RocketImageUrls = r.FlickrImages
                    };
                    rockets.Add(rocket);
                }
                return rockets;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured while trying to get all rockets: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("ExitMethod: GetAllRockets");
            }
        }
        public static async Task<RocketModel> GetRocket(string id)
        {
            try
            {
                Console.WriteLine("EnterMethod: GetRocket");
                var queriedRocket = await oddity.RocketsEndpoint.Get(id).ExecuteAsync();
                RocketModel rocket = new RocketModel
                {
                    Name = queriedRocket.Name,
                    Height = queriedRocket.Height.ToString(),
                    Diameter = queriedRocket.Diameter.ToString(),
                    MassKgs = queriedRocket.Mass.Kilograms,
                    MassLbs = queriedRocket.Mass.Pounds,
                    RocketImageUrls = queriedRocket.FlickrImages,
                    FirstStageSeaLevelThrustLbs = queriedRocket.FirstStage.ThrustSeaLevel.PoundForce,
                    FirstStageVacuumThrustLbs = queriedRocket.FirstStage.ThrustVacuum.PoundForce,
                    SecondStageVacuumThrustLbs = queriedRocket.SecondStage.Thrust.PoundForce,
                    FirstStageReusability = queriedRocket.FirstStage.Reusable,
                    SecondStageReusability = queriedRocket.SecondStage.Reusable,
                    NumberOfLandingLegs = queriedRocket.LandingLegs.Number,
                    EngineName = queriedRocket.Engines.Type,
                    EngineVersion = queriedRocket.Engines.Version,
                    FirstStageNumOfEngines = queriedRocket.FirstStage.Engines,
                    SecondStageNumOfEngines = queriedRocket.SecondStage.Engines,
                    SpecificImpulseSeaLevel = queriedRocket.Engines.Isp.SeaLevel,
                    SpecificImpulseVacuum = queriedRocket.Engines.Isp.Vacuum,
                    FirstPropellant = queriedRocket.Engines.FirstPropellant,
                    SecondPropellant = queriedRocket.Engines.SecondPropellant
                };
                return rocket;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured while trying to get selected rocket: {0}", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("ExitMethod: GetRocket");
            }
        }
    }
}
