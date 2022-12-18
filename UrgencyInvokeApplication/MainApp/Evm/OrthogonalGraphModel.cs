namespace MainApp.Evm
{
    public class OrthogonalGraphModel<T> where T : new()
    {
        private readonly T[,] _list;

        public OrthogonalGraphModel(int horizonMax, int verticalMax)
        {
            _list = new T[horizonMax, verticalMax];
            Initialize(horizonMax, verticalMax);
        }

        public bool IsInRange(int horizon, int vertical)
        {
            return 0 <= vertical && vertical < _list.GetLength(0) && 0 <= horizon && horizon < _list.GetLength(1);
        }

        private void Initialize(int horizonMax, int verticalMax)
        {
            for (var i = 0; i < verticalMax; i++)
            {
                for (var j = 0; j < horizonMax; j++)
                {
                    _list[i, j] = new T();
                }
            }
        }
    }
}