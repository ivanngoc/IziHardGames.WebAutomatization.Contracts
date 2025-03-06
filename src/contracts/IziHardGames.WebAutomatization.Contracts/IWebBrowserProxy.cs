using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace IziHardGames.WebAutomatization.Contracts
{
    public interface IWebBrowserProxy<THtmlElement> where THtmlElement : class
    {
        Task<bool> MoveToPageAsync(string uri, TimeSpan timeout, CancellationToken ct = default);

        THtmlElement? FindElement(string cssSelector, CancellationToken ct = default);

        IEnumerable<THtmlElement> FindElements(string cssSelector, CancellationToken ct = default);

        Task<THtmlElement> WhenElementAsync(string cssSelector, TimeSpan timeout, CancellationToken ct = default);

        Task<THtmlElement> WhenElementBecomeVisibleAsync(string cssSelector, TimeSpan timeout, CancellationToken ct = default);

        Task<bool> ReloadPageAsync(CancellationToken ct = default);

        Task<bool> ClickAtAsync(string cssSelector, CancellationToken ct = default);

        Task<string?> FromElementGetInnerHtml(string cssSelector, CancellationToken ct = default);

        Task<string?> FromElementGetOuterHtml(string cssSelector, CancellationToken ct = default);

        Task<string?> FromElementGetAttributes(string cssSelector, CancellationToken ct = default);

        Task<string?> FromElementGetClasses(string cssSelector, CancellationToken ct = default);

        Task<bool> IsElementVisible(string cssSelector, CancellationToken ct = default);

        Task<bool> IsElementInDom(string cssSelector, CancellationToken ct = default);

        Task<bool> AtElementScroll(string cssSelector, double value01, CancellationToken ct = default);

        IElementDescriptor GetDescriptor(THtmlElement element);

        void SetLogger(ILogger logger);
    }
}
