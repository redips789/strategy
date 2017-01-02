using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class EnergyConsumptionStatisticsHeavyUsage :IEnergyConsumptionStatistics
    {
        public float energyConsumptionOverHour(Part part)
        {
            return part.energyConsumption;
        }
        public float energyConsumptionOverDay(Part part)
        {
            return part.energyConsumption * 10;
        }
        public float energyConsumptionOverYear(Part part)
        {
            return part.energyConsumption * 10 * 365;
        }
    }
}
