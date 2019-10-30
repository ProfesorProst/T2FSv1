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

        public T2FS()
        {
        }

        public string Calculete()
        {
            double center = findTip(ruleList, input);
            Console.WriteLine(center);

            return Defuzyyficator(center).name;
        }

        private double findTip(List<Rule> ruleList, double[] inputs)
        {
            foreach (Rule rule in ruleList)
                rule.calculateFiringInterval(inputs);

            TypeReduce reducer = new TypeReduce(ruleList);
            return (reducer.yl() + reducer.yr()) / 2;
        }

        private IMemFunc Defuzyyficator(double center)
        {
            IMemFunc memFunc = new TrapezeMF(); 
            return memFunc;
        }

        public void AddRule(IMemFunc[] antc, IMemFunc rezult, ref List<Rule> rulelist)
        {
            List<IMemFunc> mems = new List<IMemFunc>();
            mems.AddRange(antc);
            List<IMemFunc> rezults = new List<IMemFunc>();
            rezults.Add(rezult);
            rulelist.Add(new Rule(mems, rezults, new ProductTnorm()));
        }

    }
}
