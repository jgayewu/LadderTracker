using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderTracker
{
    public class Session
    {
        public int Id { get; set; }
        public int IDSeason { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TankWin { get; set; }
        public int TankLoss { get; set; }
        public int DamageWin { get; set; }
        public int DamageLoss { get; set; }
        public int SupportWin { get; set; }
        public int SupportLoss { get; set; }
    }
}
