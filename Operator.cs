namespace T2FSv1
{
    public interface Operator
    {
        public double getFiringIntervalU();
        public double getFiringIntervalL();
        public void calculateFiringInterval(double mulx, double muly, double muux, double muuy);
        public void setFiringInterval(double x, double y);
    }
}