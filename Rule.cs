using System;
using System.Collections.Generic;

namespace T2FSv1
{
    public class Rule
    {
        private List<MemFunc> antc = new List<MemFunc>();
        private List<MemFunc> cons = new List<MemFunc>();
        public Operator firingInterval { get; private set; }

        public Rule(List<MemFunc> antc, List<MemFunc> cons, Operator firingInterval)
        {
            this.antc.AddRange(antc);
            this.cons.AddRange(cons);
            this.firingInterval = firingInterval;
        }

        internal void calculateFiringInterval(double x, double y)
        {
            MemFunc memFunc = antc[0];
            double muux = memFunc.upperMemFunction(x);
            double mulx = memFunc.lowerMemFunction(x);

            memFunc = antc[1];
            double muuy = memFunc.upperMemFunction(y);
            double muly = memFunc.lowerMemFunction(y);


            firingInterval.calculateFiringInterval(mulx, muly, muux, muuy);
        }

        public double getClAvgy()
        {
            double avg = 0.0;
            int n = 0;
            foreach (MemFunc memFunc in cons)
            {
                avg = avg + memFunc.getCr();
                n++;
            }

            return avg / n;
        }

        public double getClAvgx()
        {
            double avg = 0.0;
            int n = 0;
            foreach (MemFunc memFunc in cons)
            {
                avg = avg + memFunc.getCl();
                n++;
            }

            return avg / n;
        }
    }
}