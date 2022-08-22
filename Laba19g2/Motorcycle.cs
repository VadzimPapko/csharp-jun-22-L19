using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba19g2
{
    public class Motorcycle
    {
        public Guid Id { get; private set; }
        public string Model { get; set; }
        public int Odometer { get; set; }
        public string MadeIn { get; set; }

        
        public Motorcycle FirstOrDefault(Motorcycle[] motorcycles, Func<Motorcycle, bool> predicate)
        {
            foreach (var moto in motorcycles)
            {
                if (predicate(moto))
                {
                    return moto;
                }
            }
            return motorcycles[default];
        }        
    }
}
