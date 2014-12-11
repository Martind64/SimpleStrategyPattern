using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStrategyPattern
{
    interface ICarWashStrategy
    {
        void CarWash(Car car);
    }
}
