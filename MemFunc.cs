using System;
using System.Collections.Generic;

namespace T2FSv1
{
    public interface MemFunc
    {
        public double upperMemFunction(double x);
        public double lowerMemFunction(double x);
        public List<Double> getElements(int n);
        public string getUncertainVal();
        public double getUncertainValDiff();
        public double getCl();
        public double getCr();
    }
}