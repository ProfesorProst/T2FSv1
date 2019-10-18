namespace T2FSv1
{
    public class ProductTnorm : Operator
    {
        private double mulx { get; set; }
        private double muly { get; set; }
        private double muux { get; set; }
        private double muuy { get; set; }

        public double firingIntervalU { get; private set; }
        public double firingIntervalL { get; private set; }

        public void setFiringInterval(double firingIntervalx, double firingIntervaly)
        {
            this.firingIntervalU = firingIntervalx;
            this.firingIntervalL = firingIntervaly;
        }

        public void calculateFiringInterval(double mulx, double muly, double muux, double muuy)
        {
            this.mulx = mulx;
            this.muly = muly;
            this.muux = muux;
            this.muuy = muuy;
            this.firingIntervalU = mulx * muly;
            this.firingIntervalL = muux * muuy;
        }

        public double getFiringIntervalU()
        {
            return firingIntervalU;
        }

        public double getFiringIntervalL()
        {
            return firingIntervalL;
        }
    }
}
