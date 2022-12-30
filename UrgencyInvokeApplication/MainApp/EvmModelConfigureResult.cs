using System;
using System.Collections.Generic;
using MainApp.Evm.Content;

namespace MainApp
{
    public class EvmModelConfigureResult
    {
        // タイトル
        public string Title { get; }

        // 開始日
        public DateTime Start { get; }

        // 期限
        public DateTime End { get; }

        // Pvのリスト
        public PvPointList PvValueList { get; }

        internal static EvmModelConfigureResult Create(
            string title,
            DateTime start,
            DateTime end,
            IDictionary<DayOfWeek, double> pvValueMap)
        {
            // 開始日を含めるので期間に1足す
            var dayCount = (end - start).Days + 1;
            var startDayOfWeek = start.DayOfWeek;
            var pvPointList = new PvPointList();
            for (var i = 0; i < dayCount; i++)
            {
                var dayOfWeek = (DayOfWeek) (((int) startDayOfWeek + i) % pvValueMap.Count);
                pvPointList.Add(EvmValue.CreateFromHour(pvValueMap[dayOfWeek]));
            }

            return new EvmModelConfigureResult(title, start, end, pvPointList);
        }

        public static EvmModelConfigureResult Default => new EvmModelConfigureResult(
                "", 
                DateTime.Today, 
                DateTime.Today.Add(TimeSpan.FromDays(1)),
                new PvPointList());

        private EvmModelConfigureResult(string title, DateTime start, DateTime end, PvPointList pvValueList)
        {
            Title = title;
            Start = start;
            End = end;
            PvValueList = pvValueList;
        }
    }
}