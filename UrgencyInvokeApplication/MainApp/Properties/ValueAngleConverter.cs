namespace MainApplication.Properties
{
    public static class ValueAngleConverter
    {
        public static double ConvertToAngle(this double value, double total)
        {
            return value / total * 360;
        }

        public static double ConvertToValue(this double angle, double total)
        {
            return total / 360 * angle;
        }
    }
}