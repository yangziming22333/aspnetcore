﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Security.Cryptography;
using System.Xml.Linq;
using Microsoft.Framework.Internal;

namespace Microsoft.AspNet.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
    /// <summary>
    /// A class that can deserialize an <see cref="XElement"/> that represents the serialized version
    /// of an <see cref="ManagedAuthenticatedEncryptorDescriptor"/>.
    /// </summary>
    public sealed class ManagedAuthenticatedEncryptorDescriptorDeserializer : IAuthenticatedEncryptorDescriptorDeserializer
    {
        /// <summary>
        /// Imports the <see cref="ManagedAuthenticatedEncryptorDescriptor"/> from serialized XML.
        /// </summary>
        public IAuthenticatedEncryptorDescriptor ImportFromXml([NotNull] XElement element)
        {
            // <descriptor>
            //   <!-- managed implementations -->
            //   <encryption algorithm="..." keyLength="..." />
            //   <validation algorithm="..." />
            //   <masterKey>...</masterKey>
            // </descriptor>

            var options = new ManagedAuthenticatedEncryptionOptions();

            var encryptionElement = element.Element("encryption");
            options.EncryptionAlgorithmType = FriendlyNameToType((string)encryptionElement.Attribute("algorithm"));
            options.EncryptionAlgorithmKeySize = (int)encryptionElement.Attribute("keyLength");

            var validationElement = element.Element("validation");
            options.ValidationAlgorithmType = FriendlyNameToType((string)validationElement.Attribute("algorithm"));

            Secret masterKey = ((string)element.Element("masterKey")).ToSecret();

            return new ManagedAuthenticatedEncryptorDescriptor(options, masterKey);
        }

        // Any changes to this method should also be be reflected
        // in ManagedAuthenticatedEncryptorDescriptor.TypeToFriendlyName.
        private static Type FriendlyNameToType(string typeName)
        {
            if (typeName == nameof(Aes))
            {
                return typeof(Aes);
            }
            else if (typeName == nameof(HMACSHA1))
            {
                return typeof(HMACSHA1);
            }
            else if (typeName == nameof(HMACSHA256))
            {
                return typeof(HMACSHA256);
            }
            else if (typeName == nameof(HMACSHA384))
            {
                return typeof(HMACSHA384);
            }
            else if (typeName == nameof(HMACSHA512))
            {
                return typeof(HMACSHA512);
            }
            else
            {
                return Type.GetType(typeName, throwOnError: true);
            }
        }
    }
}
