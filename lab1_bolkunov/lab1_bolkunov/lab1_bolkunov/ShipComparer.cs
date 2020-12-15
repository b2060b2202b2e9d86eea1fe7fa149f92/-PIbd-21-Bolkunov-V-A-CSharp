using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_bolkunov
{
    class ShipComparer:IComparer<Vehicle>
    {
        public int Compare(Vehicle a, Vehicle b)
        {
            if ((a is Ship || a is MotorShip) && (b is Ship || b is MotorShip))
            {
                if (a is MotorShip motorShipA && b is MotorShip motorShipB)
                {
                    return CompareMotorShips(motorShipA, motorShipB);
                }

                if (!(a is MotorShip) && b is MotorShip)
                {
                    return 1;
                }

                if (a is MotorShip && !(b is MotorShip))
                {
                    return -1;
                }

                if (a is Ship shipA && b is Ship shipB)
                {
                    return CompareShips(shipA, shipB);
                }
                        
            }
            return 1;
        }

        private int CompareShips(Ship a, Ship b)
        {
            if (a.MaxSpeed != b.MaxSpeed)
            {
                return a.MaxSpeed.CompareTo(b.MaxSpeed);
            }
            if (a.Weight != b.Weight)
            {
                return a.Weight.CompareTo(b.Weight);
            }
            if (a.MainColor != b.MainColor)
            {
                return a.MainColor.Name.CompareTo(b.MainColor.Name);
            }
            return 0;
        }

        private int CompareMotorShips(MotorShip a, MotorShip b)
        {
            int res = CompareShips(a, b);
            if (res != 0)
            {
                return res;
            }
            if (a.AdditionalColor != b.AdditionalColor)
            {
                return a.AdditionalColor.Name.CompareTo(b.AdditionalColor.Name);
            }
            if (a.AdditionalBoat != b.AdditionalBoat)
            {
                return a.AdditionalBoat.CompareTo(b.AdditionalBoat);
            }
            if (a.Fire != b.Fire)
            {
                return a.Fire.CompareTo(b.Fire);
            }
            if (a.Smoke != b.Smoke)
            {
                return a.Smoke.CompareTo(b.Smoke);
            }
            if (a.HelicopterPad != b.HelicopterPad)
            {
                return a.HelicopterPad.CompareTo(b.HelicopterPad);
            }
            return 0;
        }
    }
}
