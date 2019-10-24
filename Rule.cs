﻿using System;
using System.Collections.Generic;

namespace T2FSv1
{
    public class Rule
    {
        private List<IMemFunc> antc = new List<IMemFunc>();
        private List<IMemFunc> cons = new List<IMemFunc>();

        public Operator firingInterval { get; private set; }

        public Rule(List<IMemFunc> antc, List<IMemFunc> cons, Operator firingInterval)
        {
            this.antc.AddRange(antc);
            this.cons.AddRange(cons);
            this.firingInterval = firingInterval;
        }

        internal void calculateFiringInterval(double x, double y)
        {
            IMemFunc memFunc = antc[0];
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
            foreach (IMemFunc memFunc in cons)
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
            foreach (IMemFunc memFunc in cons)
            {
                avg = avg + memFunc.getCl();
                n++;
            }

            return avg / n;
        }
    }
}