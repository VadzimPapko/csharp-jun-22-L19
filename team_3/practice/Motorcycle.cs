using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Motorcycle
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Model { get; set; }
        public int Odometer { get; set; }
        public string? MadeIn { get; set; }

        public override string ToString()
        {
            return $"Id{Id} model {Model} Odometer {Odometer} Made in {MadeIn}";
        }
    }

    
}
