namespace MainApp.Evm
{
    public class OrthogonalGraphModel<T> where T : new()
    {
        private readonly T[] _list;

        public OrthogonalGraphModel(int horizonMax)
        {
            _list = new T[horizonMax];
            Initialize(horizonMax);
        }

        public bool IsInRange(int horizon, int vertical)
        {
            return 0 <= vertical && vertical < _list.GetLength(0) && 0 <= horizon && horizon < _list.GetLength(1);
        }

        private void Initialize(int horizonMax)
        {
            for (var idx = 0; idx < horizonMax; idx++)
            {
                _list[idx] = new T();
            }
        }
    }
}