namespace Main.Extension
{
    public static class ValueAngleConverter
    {
        public static double Convert(this double value, double total)
        {
            return value / total * 360;
        }
    }
}