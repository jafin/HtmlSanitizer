using AngleSharp.Css.Dom;
using System;
using System.Collections.Generic;

namespace Ganss.Xss;

/// <summary>
/// Provides options to be used with <see cref="HtmlSanitizer"/>.
/// </summary>
/// <remarks>
/// Every collection here is <see langword="null"/> unless you set it, and a collection left
/// <see langword="null"/> falls back to its <see cref="HtmlSanitizerDefaults"/> counterpart. Setting
/// one replaces the default outright rather than adding to it; set it to an empty collection to
/// deliberately allow nothing.
/// </remarks>
public class HtmlSanitizerOptions
{
    /// <summary>
    /// Gets or sets the allowed tag names such as "a" and "div".
    /// Defaults to <see cref="HtmlSanitizerDefaults.AllowedTags"/> when not set.
    /// </summary>
    public ISet<string>? AllowedTags { get; set; }

    /// <summary>
    /// Gets or sets the allowed HTML attributes such as "href" and "alt".
    /// Defaults to <see cref="HtmlSanitizerDefaults.AllowedAttributes"/> when not set.
    /// </summary>
    public ISet<string>? AllowedAttributes { get; set; }

    /// <summary>
    /// Gets or sets the allowed CSS classes. An empty set means all classes are allowed.
    /// Defaults to <see cref="HtmlSanitizerDefaults.AllowedClasses"/> when not set.
    /// </summary>
    public ISet<string>? AllowedCssClasses { get; set; }

    /// <summary>
    /// Gets or sets the allowed CSS properties such as "font" and "margin".
    /// Defaults to <see cref="HtmlSanitizerDefaults.AllowedCssProperties"/> when not set.
    /// </summary>
    public ISet<string>? AllowedCssProperties { get; set; }

    /// <summary>
    /// Gets or sets the allowed CSS at-rules such as "@media" and "@font-face".
    /// Defaults to <see cref="HtmlSanitizerDefaults.AllowedAtRules"/> when not set.
    /// </summary>
    public ISet<CssRuleType>? AllowedAtRules { get; set; }

    /// <summary>
    /// Gets or sets the allowed URI schemes such as "http" and "https".
    /// Defaults to <see cref="HtmlSanitizerDefaults.AllowedSchemes"/> when not set.
    /// </summary>
    public ISet<string>? AllowedSchemes { get; set; }

    /// <summary>
    /// Gets or sets the HTML attributes that can contain a URI such as "href".
    /// Defaults to <see cref="HtmlSanitizerDefaults.UriAttributes"/> when not set.
    /// </summary>
    /// <remarks>
    /// This is a screening list rather than an allow list: an attribute that is not listed here
    /// keeps its value verbatim instead of being checked against <see cref="AllowedSchemes"/>.
    /// Setting it to an empty set therefore screens nothing at all, which lets
    /// <c>href="javascript:..."</c> through.
    /// </remarks>
    public ISet<string>? UriAttributes { get; set; }

    /// <summary>
    /// Gets or sets the allowed URI list attributes, whose value is a list of URLs rather than a
    /// single one. See <see cref="HtmlSanitizerDefaults.UriListAttributes"/>.
    /// Defaults to <see cref="HtmlSanitizerDefaults.UriListAttributes"/> when not set.
    /// </summary>
    public ISet<string>? UriListAttributes { get; set; }

    /// <summary>
    /// Allow all custom CSS properties (variables) prefixed with <c>--</c>.
    /// </summary>
    /// <example>
    /// <code>
    /// var options = new HtmlSanitizerOptions { AllowCssCustomProperties = true };
    /// </code>
    /// </example>
    public bool AllowCssCustomProperties { get; set; }

    /// <summary>
    /// Allow all HTML5 data attributes; the attributes prefixed with <c>data-</c>.
    /// </summary>
    /// <example>
    /// <code>
    /// var options = new HtmlSanitizerOptions { AllowDataAttributes = true };
    /// </code>
    /// </example>
    public bool AllowDataAttributes { get; set; }
}
