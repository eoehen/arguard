using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using Xunit.Sdk;

// Reference: https://raw.githubusercontent.com/xunit/samples.xunit/main/UseCulture/UseCultureAttribute.cs

namespace oehen.arguard
{
    /// <summary>
    /// Apply this attribute to your test method to replace the
    /// <see cref="Thread.CurrentThread" /> <see cref="CultureInfo.CurrentCulture" /> and
    /// <see cref="CultureInfo.CurrentUICulture" /> with another culture.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    internal class UseCultureAttribute : BeforeAfterTestAttribute
    {
        private readonly Lazy<CultureInfo> culture;
        private readonly Lazy<CultureInfo> uiCulture;

        private CultureInfo originalCulture;
        private CultureInfo originalUiCulture;

        /// <summary>
        /// Replaces the culture and UI culture of the current thread with
        /// <paramref name="culture" />
        /// </summary>
        /// <param name="culture">The name of the culture.</param>
        /// <remarks>
        /// <para>
        /// This constructor overload uses <paramref name="culture" /> for both
        /// <see cref="Culture" /> and <see cref="UiCulture" />.
        /// </para>
        /// </remarks>
        public UseCultureAttribute(string culture)
            : this(culture, culture) { }

        /// <summary>
        /// Replaces the culture and UI culture of the current thread with
        /// <paramref name="culture" /> and <paramref name="uiCulture" />
        /// </summary>
        /// <param name="culture">The name of the culture.</param>
        /// <param name="uiCulture">The name of the UI culture.</param>
        private UseCultureAttribute(string culture, string uiCulture)
        {
            this.culture = new Lazy<CultureInfo>(() => new CultureInfo(culture, false));
            this.uiCulture = new Lazy<CultureInfo>(() => new CultureInfo(uiCulture, false));
        }

        /// <summary>
        /// Gets the culture.
        /// </summary>
        private CultureInfo Culture => culture.Value;

        /// <summary>
        /// Gets the UI culture.
        /// </summary>
        private CultureInfo UiCulture => uiCulture.Value;

        /// <summary>
        /// Stores the current <see cref="Thread.CurrentPrincipal" />
        /// <see cref="CultureInfo.CurrentCulture" /> and <see cref="CultureInfo.CurrentUICulture" />
        /// and replaces them with the new cultures defined in the constructor.
        /// </summary>
        /// <param name="methodUnderTest">The method under test</param>
        public override void Before(MethodInfo methodUnderTest)
        {
            originalCulture = Thread.CurrentThread.CurrentCulture;
            originalUiCulture = Thread.CurrentThread.CurrentUICulture;

            Thread.CurrentThread.CurrentCulture = Culture;
            Thread.CurrentThread.CurrentUICulture = UiCulture;

            CultureInfo.CurrentCulture.ClearCachedData();
            CultureInfo.CurrentUICulture.ClearCachedData();
        }

        /// <summary>
        /// Restores the original <see cref="CultureInfo.CurrentCulture" /> and
        /// <see cref="CultureInfo.CurrentUICulture" /> to <see cref="Thread.CurrentPrincipal" />
        /// </summary>
        /// <param name="methodUnderTest">The method under test</param>
        public override void After(MethodInfo methodUnderTest)
        {
            Thread.CurrentThread.CurrentCulture = originalCulture;
            Thread.CurrentThread.CurrentUICulture = originalUiCulture;

            CultureInfo.CurrentCulture.ClearCachedData();
            CultureInfo.CurrentUICulture.ClearCachedData();
        }
    }
}