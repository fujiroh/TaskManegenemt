using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace MainApp.Evm.Content
{
    public class EvmValueList : IEnumerable<EvmValue>
    {
        private readonly List<EvmValue> _evmValues;
        private readonly Subject<Unit> _subject = new Subject<Unit>();

        public virtual Color LegendColor { get; set; } = Color.Black;
        public IObservable<Unit> ContentChangedObservable => _subject.AsObservable();

        public EvmValue this[int idx]
        {
            get => _evmValues[idx];
            set
            {
                _evmValues[idx] = value;
                _subject.OnNext(Unit.Default);
            }
        }

        public EvmValue GetAggregateValue(int idx)
        {
            EvmValue sum = EvmValue.Zero;
            for (var i = 0; i <= idx; i++)
            {
                sum += _evmValues[i];
            }
            return sum;
        }

        public EvmValueList()
        {
            _evmValues = new List<EvmValue> {EvmValue.Zero};
        }

        public EvmValueList(IEnumerable<EvmValue> evmValues)
        {
            _evmValues = evmValues.ToList();
        }

        public EvmValue GetAggregate()
        {
            if (_evmValues.Count == 0)
            {
                return EvmValue.Zero;
            }
            return _evmValues.Aggregate((sum, v) => sum + v);
        }

        public void Add(EvmValue evmValue)
        {
            _evmValues.Add(evmValue);
            _subject.OnNext(Unit.Default);
        }

        public void Add(IEnumerable<EvmValue> evmValues)
        {
            _evmValues.AddRange(evmValues);
            _subject.OnNext(Unit.Default);
        }

        public void ClearAll()
        {
            _evmValues.Clear();
            _subject.OnNext(Unit.Default);
        }

        public void Clear(int idx)
        {
            if (IsIndexInRange(idx))
            {
                throw new IndexOutOfRangeException("削除する際のインデックス指定が不正です");
            }

            _evmValues.RemoveAt(idx);
            _subject.OnNext(Unit.Default);
        }

        private bool IsIndexInRange(int idx)
        {
            return 0 <= idx && idx <= _evmValues.Count;
        }

        public IEnumerator<EvmValue> GetEnumerator()
        {
            return _evmValues.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}