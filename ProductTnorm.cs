namespace T2FSv1
{
    public class ProductTnorm : Operator
    {
        private double mulx { get; set; }
        private double muly { get; set; }
        private double muux { get; set; }
        private double muuy { get; set; }

        private double firingIntervalU { get; set; }
        private double firingIntervalL { get; set; }

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
    }
}
