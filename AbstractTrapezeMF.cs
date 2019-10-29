using System.Collections.Generic;

namespace T2FSv1
{
    public abstract class AbstractTrapezeMF : IMemFunc
    {
        public string name { get; set; }
        public abstract double getCl();
        public abstract double getCr();
        public abstract List<double> getElements(int n);

        public string getUncertainVal()
    {
        return null;
    }

    public double getUncertainValDiff()
    {
        return 0;
    }

        public abstract double lowerMemFunction(double x);
        public abstract double upperMemFunction(double x);
    }
}