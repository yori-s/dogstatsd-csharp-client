using System;

namespace StatsdClient
{
    /// <summary>send a single command at a time</summary>
    public interface IStatsd
    {
        void Send<TCommandType, T>(string name, T value, double sampleRate, params string[] tags) where TCommandType : StatsdClient.Statsd.Metric;
        void Send(string title, string text, string alertType, string aggregationKey, string sourceType, int? dateHappened, string priority, string hostname, string[] tags);
        void Send(string command);
        void Send(Action actionToTime, string statName, double sampleRate, params string[] tags);
    }
}