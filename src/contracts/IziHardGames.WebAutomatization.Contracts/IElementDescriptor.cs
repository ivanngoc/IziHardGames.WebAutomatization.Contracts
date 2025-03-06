using System;
using System.Collections.Generic;

namespace IziHardGames.WebAutomatization.Contracts
{
    public interface IElementDescriptor : IDisposable
    {
        string InnerText { get; }
        string OuterText { get; }
        IEnumerable<KeyValuePair<string, string>> Attributes { get; }
        string? this[string attributeName] { get; }
        int InnerAsInt();
        double InnerAsDouble();
        TimeSpan InnerAsSpan();
    }
}
