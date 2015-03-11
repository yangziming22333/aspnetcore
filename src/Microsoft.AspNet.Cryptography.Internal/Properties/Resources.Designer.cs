// <auto-generated />
namespace Microsoft.AspNet.Cryptography.Internal
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Cryptography.Internal.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// A provider could not be found for algorithm '{0}'.
        /// </summary>
        internal static string BCryptAlgorithmHandle_ProviderNotFound
        {
            get { return GetString("BCryptAlgorithmHandle_ProviderNotFound"); }
        }

        /// <summary>
        /// A provider could not be found for algorithm '{0}'.
        /// </summary>
        internal static string FormatBCryptAlgorithmHandle_ProviderNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("BCryptAlgorithmHandle_ProviderNotFound"), p0);
        }

        /// <summary>
        /// The key length {0} is invalid. Valid key lengths are {1} to {2} bits (step size {3}).
        /// </summary>
        internal static string BCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength
        {
            get { return GetString("BCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength"); }
        }

        /// <summary>
        /// The key length {0} is invalid. Valid key lengths are {1} to {2} bits (step size {3}).
        /// </summary>
        internal static string FormatBCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("BCRYPT_KEY_LENGTHS_STRUCT_InvalidKeyLength"), p0, p1, p2, p3);
        }

        /// <summary>
        /// This operation requires Windows 7 / Windows Server 2008 R2 or later.
        /// </summary>
        internal static string Platform_Windows7Required
        {
            get { return GetString("Platform_Windows7Required"); }
        }

        /// <summary>
        /// This operation requires Windows 7 / Windows Server 2008 R2 or later.
        /// </summary>
        internal static string FormatPlatform_Windows7Required()
        {
            return GetString("Platform_Windows7Required");
        }

        /// <summary>
        /// This operation requires Windows 8 / Windows Server 2012 or later.
        /// </summary>
        internal static string Platform_Windows8Required
        {
            get { return GetString("Platform_Windows8Required"); }
        }

        /// <summary>
        /// This operation requires Windows 8 / Windows Server 2012 or later.
        /// </summary>
        internal static string FormatPlatform_Windows8Required()
        {
            return GetString("Platform_Windows8Required");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
