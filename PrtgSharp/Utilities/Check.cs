// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;

namespace PrtgSharp.Utilities
{
    internal static class Check
    {
        [ContractAnnotation("value:null => halt")]
        public static T NotNull<T>([NoEnumeration] T value, [InvokerParameterName, NotNull] string parameterName)
        {
            if (ReferenceEquals(value, null))
            {
                NotEmpty(parameterName, nameof(parameterName));

                throw new ArgumentNullException(parameterName);
            }

            return value;
        }

        public static string NullButNotEmpty(string value, [InvokerParameterName, NotNull] string parameterName)
        {
            if (!ReferenceEquals(value, null) && (value.Length == 0))
            {
                NotEmpty(parameterName, nameof(parameterName));

                throw new ArgumentException($"The string argument '{parameterName}' cannot be empty.");
            }

            return value;
        }

        [ContractAnnotation("value:null => halt")]
        public static string NotEmpty(string value, [InvokerParameterName, NotNull] string parameterName)
        {
            Exception e = null;
            if (ReferenceEquals(value, null))
            {
                e = new ArgumentNullException(parameterName);
            }
            else if (value.Trim().Length == 0)
            {
                e = new ArgumentException($"The string argument '{parameterName}' cannot be empty.");
            }

            if (e != null)
            {
                NotEmpty(parameterName, nameof(parameterName));

                throw e;
            }

            return value;
        }
    }
}
