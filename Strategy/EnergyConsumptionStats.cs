using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EnergyConsumptionStats
    {
        public float energyConsumptionHour { get; set; }
        public float energyConsumptionDay { get; set; }
        public float energyConsumptionYear { get; set; }

        public EnergyConsumptionStats (float energyConsumptionHour,float energyConsumptionDay, float energyConsumptionYear)
        {
            this.energyConsumptionHour = energyConsumptionHour;
            this.energyConsumptionDay = energyConsumptionDay;
            this.energyConsumptionYear = energyConsumptionYear;
        }
    }
}
