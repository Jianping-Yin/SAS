﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvAnalysisWinform.Models
{
	public class CsvFormat1
	{
		public DateTime Date { get; set; }
		public DateTime Time { get; set; }
		public decimal EngineSpeed { get; set; }
		public decimal EngineOilPre { get; set; }
		public decimal FuelPre { get; set; }
		public decimal EngineOilTem { get; set; }
		public decimal FuelTem { get; set; }
		public decimal CoolantTem { get; set; }
		public int LockUp { get; set; }
		public int Gear { get; set; }
		public decimal TranseOilPre { get; set; }
		public decimal TransOilTem { get; set; }
		public decimal DischargePre { get; set; }
		public decimal TripPre { get; set; }
		public decimal Horsepower { get; set; }
		public decimal LubeOilpre { get; set; }
		public decimal LubeOilTem { get; set; }
		public decimal SuctionPre { get; set; }
		public decimal PumpSpeed { get; set; }
		public decimal PumpRate { get; set; }
		public decimal PumpTotal { get; set; }
		public decimal SelectedPumpTotal { get; set; }
		public decimal SelectedPumpRate { get; set; }
		public decimal SelectedPumpHhp { get; set; }
		public string Alarms { get; set; }
		public int Tripped { get; set; }
		public int Selected { get; set; }
		public decimal LastTripPre { get; set; }
		public decimal Density1 { get; set; }
		public decimal Density2 { get; set; }
	}
}
