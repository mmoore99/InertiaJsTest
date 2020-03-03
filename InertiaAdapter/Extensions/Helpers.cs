﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics.CodeAnalysis;

namespace InertiaAdapter.Extensions
{
    internal static class Helpers
    {
        internal static T NotNull<T>([NotNull] this T? value) where T : class =>
            value ?? throw new ArgumentNullException(nameof(value));

        internal static object Value([NotNull] this object? obj, string propertyName) =>
            obj?.GetType().GetProperty(propertyName)?.GetValue(obj, null) ??
            throw new NullReferenceException();

        internal static bool IsInertiaRequest(this HttpContext? hc) =>
            bool.TryParse(hc.NotNull().Request.Headers["X-Inertia"], out _);

        internal static bool IsInertiaRequest(this ActionContext? ac) =>
            bool.TryParse(ac.NotNull().HttpContext.Request.Headers["X-Inertia"], out _);
    }
}