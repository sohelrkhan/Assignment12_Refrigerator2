using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrigeretor
    {
        private double maxWeight;
        public double currentWeight = 0;
        private List<double> itemNo = new List<double>();
        private List<double> unitWeight = new List<double>();

        public double MaxWeight { set; get; }
        public double ItemNo { set; get; }
        public double UnitWeight { set; get; }

        public void AddWeight(double maxWeight)
        {
            this.maxWeight = maxWeight;
        }
        public void AddItemUnit(double itemNo, double unitWeight)
        {
            this.itemNo.Add(itemNo);
            this.unitWeight.Add(unitWeight);
            this.currentWeight += itemNo * unitWeight;
        }
        public double CurrentWeight()
        {
            //double currentWeight = this.currentWeight;
            return currentWeight;
        }
        public double RemainingWeight()
        {
            double remainingtWeight = this.maxWeight - this.currentWeight;
            return remainingtWeight;
        }
        public bool Validation()
        {
            bool validity = true;
            if (CurrentWeight() > maxWeight)
            {
                validity = false;
            }
            return validity;
        }
        public double totalaitem()
        {
            double res = itemNo.Sum();
            return res;
        }
        public double totalunitWeight()
        {
            double res1 = unitWeight.Sum();
            return res1;
        }
    }
}
