using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvAnalysisWinform.Models
{
    public class CsvFormat2
    {
        public DateTime Date { get; set; }
        public string PumpId { get; set; }
        public decimal EngineSpeed { get; set; }
        public decimal EngineLoad { get; set; }
        public decimal CoolantTem { get; set; }
        public decimal FuelTem { get; set; }
        public decimal FuelPre { get; set; }
        public decimal EngineOilTem { get; set; }
        public decimal EngineOilPre { get; set; }
        public int Gear { get; set; }
        public decimal TranseOilPre { get; set; }
        public decimal TransOilTem { get; set; }
        public decimal DischargePre { get; set; }
        public decimal Horsepower { get; set; }
        public decimal LubeOilPre { get; set; }
        public decimal LubeOilTem { get; set; }
        public decimal PumpRpm { get; set; }
        public decimal DischargeRate { get; set; }
        public decimal DischargeTotal { get; set; }
        public decimal ChargePre { get; set; }
    }
}
