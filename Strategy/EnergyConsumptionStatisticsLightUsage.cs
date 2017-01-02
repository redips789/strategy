using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class EnergyConsumptionStatisticsLightUsage : IEnergyConsumptionStatistics
    {
        public float energyConsumptionOverHour(Part part)
        {
            return part.energyConsumption;
        }
        public float energyConsumptionOverDay(Part part)
        {
            return part.energyConsumption ;
        }
        public float energyConsumptionOverYear(Part part)
        {
            return part.energyConsumption  * 365;
        }

    }
}
