using System;
using System.Collections.Generic;
using System.Text;

namespace T2FSv1
{
    class T2FS
    {
        List<Rule> ruleList;
        double[] input;

        public T2FS(List<Rule> ruleList, double[] input)
        {
            this.ruleList = ruleList;
            this.input = input;
        }

        public string Calculete()
        {
            double center = findTip(ruleList, input[0], input[1]);
            
            return Defuzyyficator(center).name;
        }

        private double findTip(List<Rule> ruleList, double x, double y)
        {
            foreach (Rule rule in ruleList)
                rule.calculateFiringInterval(x, y);

            TypeReduce reducer = new TypeReduce(ruleList);
            return (reducer.yl() + reducer.yr()) / 2;
        }

        private IMemFunc Defuzyyficator(double center)
        {
            IMemFunc memFunc = new TrapezeMF(); 
            return memFunc;
        }

    }
}
