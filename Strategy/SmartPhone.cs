using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SmartPhone
    {
        private int pricePayingInstantly = 0;
        private int pricePayingOver12Months = 0;
        private int pricePayingOver24Months = 0;
        public IEnergyConsumptionStatistics energyConsumptionStatistics;
        public List<Part> parts = null;
        public SmartPhone(List<Part> parts, IEnergyConsumptionStatistics energyConsumptionStatistics)
        {
            this.parts = parts;
            this.energyConsumptionStatistics = energyConsumptionStatistics;
        }

        public EnergyConsumptionStats CalculateEnergyConsumptionStats()
        {
            float energyYear = 0;
            float energyHour = 0;
            float energyDay = 0;
            foreach (var item in parts)
            {
                energyHour = energyConsumptionStatistics.energyConsumptionOverHour(item);
                energyDay = energyConsumptionStatistics.energyConsumptionOverDay(item);
                energyYear = energyConsumptionStatistics.energyConsumptionOverYear(item);
            }
            return new EnergyConsumptionStats(energyHour, energyDay, energyYear);
        }
    }
}
