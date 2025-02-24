// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Options for controlling the validation of TLS endpoints. </summary>
    public partial class TlsValidationOptions
    {
        /// <summary> Initializes a new instance of TlsValidationOptions. </summary>
        public TlsValidationOptions()
        {
        }

        /// <summary> Initializes a new instance of TlsValidationOptions. </summary>
        /// <param name="ignoreHostname"> When set to 'true' causes the certificate subject name validation to be skipped. Default is 'false'. </param>
        /// <param name="ignoreSignature"> When set to 'true' causes the certificate chain trust validation to be skipped. Default is 'false'. </param>
        internal TlsValidationOptions(string ignoreHostname, string ignoreSignature)
        {
            IgnoreHostname = ignoreHostname;
            IgnoreSignature = ignoreSignature;
        }

        /// <summary> When set to 'true' causes the certificate subject name validation to be skipped. Default is 'false'. </summary>
        public string IgnoreHostname { get; set; }
        /// <summary> When set to 'true' causes the certificate chain trust validation to be skipped. Default is 'false'. </summary>
        public string IgnoreSignature { get; set; }
    }
}
