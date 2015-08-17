using System;
using System.Collections.Generic;

namespace StatsdClient
{
    /// <summary>batch and send multiple commands</summary>
    public interface IStatsdBatch
    {
        List<string> Commands { get; }
        void Add<TCommandType, T>(string name, T value, double sampleRate, params string[] tags) where TCommandType : StatsdClient.Statsd.Metric;
        void Add(string title, string text, string alertType, string aggregationKey, string sourceType, int? dateHappened, string priority, string hostname, string[] tags);
        void Add(Action actionToTime, string statName, double sampleRate, params string[] tags);
        void SendAll();
    }
}
