using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace LadderTracker
{
    //https://www.litedb.org/
    public static class DBManager
    {
        private static LiteDatabase db;
        public static ILiteCollection<Season> seasons;
        public static ILiteCollection<Session> sessions;

        public static void Init()
        {
            db = new LiteDatabase(@".\LadderTrackerDB.db");
            seasons = db.GetCollection<Season>("seasons");
            sessions = db.GetCollection<Session>("sessions");
        }

        public static void AddNewSeason()
        {
            Season season = new Season
            {
                SeasonName = "seasonName",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };

            seasons.Insert(season);
        }
        public static void AddNewSession()
        {
            //grab most recent season id
            Season s = new Season();
            foreach (Season season in seasons.FindAll())
            {
                if (season.Id > s.Id)
                    s = season;
            }

            Session session = new Session
            {
                IDSeason = s.Id,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                TankWin = 0,
                TankLoss = 0,
                DamageWin = 0,
                DamageLoss = 0,
                SupportWin = 0,
                SupportLoss = 0
            };

            sessions.Insert(session);
        }
        public static void DeleteSeason(int id)
        {
            seasons.Delete(id);
        }
        public static void DeleteSession(int id)
        {
            sessions.Delete(id);
        }
        
    }
}
