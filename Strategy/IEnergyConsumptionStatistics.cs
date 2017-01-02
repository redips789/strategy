using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IEnergyConsumptionStatistics
    {
        float energyConsumptionOverHour(Part part);
        float energyConsumptionOverDay(Part part);
        float energyConsumptionOverYear(Part part);
    }
}
