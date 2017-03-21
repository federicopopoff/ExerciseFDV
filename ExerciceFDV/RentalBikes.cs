using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFDV
{
    public interface IRental
    {
        string Description { get; }
        double UnitCost { get; set; }
        int cantRent { get; set; }

        double CalcCost();
    }

    public abstract class SingleRental : IRental
    {
        public abstract int cantRent { get; set; }
        public abstract string Description { get; }
        public abstract double UnitCost { get; set; }

        public double CalcCost()
        {
            return (cantRent * UnitCost);
        }
    }
    
    public class RentalHour : SingleRental
    { 
        public override string Description
        {
            get
            {
                return "Por Hora";
            }          
        }

        private double _unitCost;

        public override double UnitCost
        {
            get
            {
                return 5.00;
            }
            set
            {
                this._unitCost = value;
            }
        }


        private int _cantRent;
        public override int cantRent
        {
            get
            {
                return _cantRent;
            }
            set
            {
                this._cantRent = value;
            }
        }

    }

    public class RentalDay : SingleRental
    {
        public override string Description
        {
            get
            {
                return "Por Dia";
            }
        }

        private double _unitCost;

        public override double UnitCost
        {
            get
            {
                return 20.00;
            }
            set
            {
                this._unitCost = value;
            }
        }


        private int _cantRent;
        public override int cantRent
        {
            get
            {
                return _cantRent;
            }
            set
            {
                this._cantRent = value;
            }
        }
       
    }

    public class RentalWeek : SingleRental
    {
        public override string Description
        {
            get
            {
                return "Por Semana";
            }
        }

        private double _unitCost;

        public override double UnitCost
        {
            get
            {
                return 60.00;
            }
            set
            {
                this._unitCost = value;
            }
        }


        private int _cantRent;
        public override int cantRent
        {
            get
            {
                return _cantRent;
            }
            set
            {
                this._cantRent = value;
            }
        }

    }

    public class FamilyRental : IRental
    {
        public string Description
        {
            get
            {
                return "Promocion";
            }
        }

        private int _cantRent;
        public int cantRent
        {
            get
            {
                return _cantRent;
            }
            set
            {
                this._cantRent = value;
            }
        }

        private double _unitCost;
        public double UnitCost
        {
            get
            {
                return _unitCost;
            }
            set
            {
                this._unitCost = value;
            }
        }

        private List<IRental> Rentals;

        public FamilyRental(List<IRental> rentals)
        {
            Rentals = rentals;
        }
        
        public double CalcCost()
        {
            if(Rentals.Count == 0)
                throw new Exception("Without rents");

            if (Rentals.Count >= 3 && Rentals.Count <= 5)
            {
                double SummatoryCost = 0.00;

                foreach (var item in Rentals)
                {
                    SummatoryCost += item.CalcCost();
                }

                UnitCost = SummatoryCost;

                return Discount(UnitCost);
            }
            else
                throw new Exception("Without promocion");

        }

        private double Discount(double cost)
        {
            return cost - cost * 0.3;
        }

    }

   





}
