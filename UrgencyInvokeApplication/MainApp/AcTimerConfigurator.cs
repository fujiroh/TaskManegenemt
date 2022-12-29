namespace MainApp
{
    public class AcTimerConfigurator
    {
        public AcTimerResult Configure()
        {
            var dialog = new AcTimerDialog();
            dialog.ShowDialog();
            return dialog.CreateResult();
        }
    }
}