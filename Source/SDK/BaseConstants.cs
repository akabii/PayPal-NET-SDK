using System.Text;
using PayPal.Util;

namespace PayPal.Api
{
    /// <summary>
    /// Constants that are used by the PayPal SDK.
    /// </summary>
    public static class BaseConstants
    {
        /// <summary>
        /// Request Method in HTTP Connection
        /// </summary>
        public const string RequestMethod = "POST";

        /// <summary>
        /// Log file
        /// </summary>
        public const string PayPalLogFile = "PAYPALLOGFILE";

        /// <summary>
        /// Encoding Format
        /// </summary>
        public static readonly Encoding ENCODING_FORMAT = Encoding.UTF8;
        
        /// <summary>
        /// Account Prefix
        /// </summary>
        public const string AccountPrefix = "acct";

        /// <summary>
        /// Sandbox Default Email Address
        /// </summary>
        public const string PayPalSandboxEmailAddressDefault = "pp.devtools@gmail.com";
        
        /// <summary>
        /// SOAP Format
        /// </summary>
        public const string SOAP = "SOAP";
        
        /// <summary>
        /// NVP Format
        /// </summary>
        public const string NVP = "NV";
        
        /// <summary>
        /// PayPal Security UserId Header
        /// </summary>
        public const string PayPalSecurityUserIdHeader = "X-PAYPAL-SECURITY-USERID";

        /// <summary>
        /// PayPal Security Password Header
        /// </summary>
        public const string PayPalSecurityPasswordHeader = "X-PAYPAL-SECURITY-PASSWORD";

        /// <summary>
        /// PayPal Security Signature Header
        /// </summary>
        public const string PayPalSecuritySignatureHeader = "X-PAYPAL-SECURITY-SIGNATURE";

        /// <summary>
        /// PayPal Platform Authorization Header
        /// </summary>
        public const string PayPalAuthorizationPlatformHeader = "X-PAYPAL-AUTHORIZATION";

        /// <summary>
        /// PayPal Merchant Authorization Header
        /// </summary>
        public const string PayPalAuthorizationMerchantHeader = "X-PP-AUTHORIZATION";

        /// <summary>
        /// PayPal Application Id Header
        /// </summary>
        public const string PayPalApplicationIdHeader = "X-PAYPAL-APPLICATION-ID";

        /// <summary>
        /// PayPal Request Data Header
        /// </summary>
        public const string PayPalRequestDataFormatHeader = "X-PAYPAL-REQUEST-DATA-FORMAT";

        /// <summary>
        /// PayPal Request Data Header
        /// </summary>
        public const string PayPalResponseDataFormatHeader = "X-PAYPAL-RESPONSE-DATA-FORMAT";

        /// <summary>
        /// PayPal Request Source Header
        /// </summary>
        public const string PayPalRequestSourceHeader = "X-PAYPAL-REQUEST-SOURCE";
        
        /// <summary>
        /// PayPal Sandbox Email Address Header
        /// </summary>
        public const string PayPalSandboxDeviceIPAddress = "X-PAYPAL-DEVICE-IPADDRESS";

        /// <summary>
        /// PayPal Sandbox Email Address Header
        /// </summary>
        public const string PayPalSandboxEmailAddressHeader = "X-PAYPAL-SANDBOX-EMAIL-ADDRESS";

        /// <summary>
        /// Allowed application mode - live
        /// </summary>
        public const string LiveMode = "live";

        /// <summary>
        /// Allowed application mode - sandbox
        /// </summary>
        public const string SandboxMode = "sandbox";

        /// <summary>
        /// Sandbox REST API endpoint
        /// </summary>
        public const string RESTSandboxEndpoint = "https://api.sandbox.paypal.com/";

        /// <summary>
        /// Live REST API endpoint
        /// </summary>
        public const string RESTLiveEndpoint = "https://api.paypal.com/";

        /// <summary>
        /// Configuration key for application mode
        /// </summary>
        public const string ApplicationModeConfig = "mode";

        /// <summary>
        /// Configuration key for End point
        /// </summary>
        public const string EndpointConfig = "endpoint";

        /// <summary>
        /// Configuration key for IPAddress
        /// </summary>
        public const string ClientIPAddressConfig = "IPAddress";

        /// <summary>
        /// Configuration key for HTTP Proxy Address
        /// </summary>
        public const string HttpProxyAddressConfig = "proxyAddress";

        /// <summary>
        /// Configuration key for HTTP Proxy Credential
        /// </summary>
        public const string HttpProxyCredentialConfig = "proxyCredentials";

        /// <summary>
        /// Configuration key for HTTP Connection Timeout
        /// </summary>
        public const string HttpConnectionTimeoutConfig = "connectionTimeout";

        /// <summary>
        /// Configuration key for HTTP Connection Retry
        /// </summary>
        public const string HttpConnectionRetryConfig = "requestRetries";

        /// <summary>
        /// Configuration key suffix for Client Id
        /// </summary>
        public const string ClientId = "clientId";

        /// <summary>
        /// Configuration key suffix for Client Secret
        /// </summary>
        public const string ClientSecret = "clientSecret";

        /// <summary>
        /// OAuth endpoint config key
        /// </summary>
        public const string OAuthEndpoint = "oauth.EndPoint";

        /// <summary>
        /// User Agent HTTP Header
        /// </summary>
        public const string UserAgentHeader = "User-Agent";

        /// <summary>
        /// Content Type HTTP Header
        /// </summary>
        public const string ContentTypeHeader = "Content-Type";

        /// <summary>
        /// Application - Json Content Type
        /// </summary>
        public const string ContentTypeHeaderJson = "application/json";

        /// <summary>
        /// Authorization HTTP Header
        /// </summary>
        public const string AuthorizationHeader = "Authorization";

        /// <summary>
        /// PayPal Request Id HTTP Header
        /// </summary>
        public const string PayPalRequestIdHeader = "PayPal-Request-Id";

        /// <summary>
        /// The version of this SDK.
        /// </summary>
        public static string SdkVersion { get { return SDKUtil.GetAssemblyVersionForType(typeof(BaseConstants)); } }

        /// <summary>
        /// The name of this SDK.
        /// </summary>
        public const string SdkName = "PayPal-NET-SDK";

        /// <summary>
        /// Defines string constants for HATEOAS link relations.
        /// </summary>
        public static class HateoasLinkRelations
        {
            /// <summary>
            /// HATEOAS link relation used to get the details of the current resource.
            /// </summary>
            public const string Self = "self";

            /// <summary>
            /// HATEOAS link relation used to get the details of the parent payment of a payment resource.
            /// </summary>
            public const string ParentPayment = "parent_payment";

            /// <summary>
            /// HATEOAS link relation used to update the current resource.
            /// </summary>
            public const string Update = "update";

            /// <summary>
            /// HATEOAS link relation used to delete the current resource.
            /// </summary>
            public const string Delete = "delete";

            /// <summary>
            /// HATEOAS link relation used to patch the current resource.
            /// </summary>
            public const string Patch = "patch";

            /// <summary>
            /// HATEOAS link relation used to redirect a buyer to PayPal to provide approval for the payment associated with the current resource.
            /// </summary>
            public const string ApprovalUrl = "approval_url";

            /// <summary>
            /// HATEOAS link relation used to execute the payment associated with the current resource.
            /// </summary>
            public const string Execute = "execute";

            /// <summary>
            /// HATEOAS link relation used to capture the payment associated with the current resource.
            /// </summary>
            public const string Capture = "capture";

            /// <summary>
            /// HATEOAS link relation used to provide authorization for the payment associated with the current resource.
            /// </summary>
            public const string Authorization = "authorization";

            /// <summary>
            /// HATEOAS link relation used to get the order resource associated with the current resource.
            /// </summary>
            public const string Order = "order";

            /// <summary>
            /// HATEOAS link relation used to issue a refund for the current resource.
            /// </summary>
            public const string Refund = "refund";

            /// <summary>
            /// HATEOAS link relation used to void the current resource.
            /// </summary>
            public const string Void = "void";

            /// <summary>
            /// HATEOAS link relation used to reauthorize a payment authorization resource.
            /// </summary>
            public const string ReAuthorize = "reauthorize";

            /// <summary>
            /// HATEOAS link relation used for searches and provides results for the next set of search results.
            /// </summary>
            public const string NextPage = "next_page";

            /// <summary>
            /// HATEOAS link relation used for searches and provides results for the previous set of search results.
            /// </summary>
            public const string PreviousPage = "previous_page";

            /// <summary>
            /// HATEOAS link relation used for searches and provides results for the first set of search results.
            /// </summary>
            public const string Start = "start";

            /// <summary>
            /// HATEOAS link relation used for searches and provides results for the last set of search results.
            /// </summary>
            public const string Last = "last";

            /// <summary>
            /// HATEOAS link relation used to suspend a billing agreement.
            /// </summary>
            public const string Suspend = "suspend";

            /// <summary>
            /// HATEOAS link relation used to reactivate a billing agreement.
            /// </summary>
            public const string ReActivate = "re_activate";

            /// <summary>
            /// HATEOAS link relation used to cancel a billing agreement.
            /// </summary>
            public const string Cancel = "cancel";

            /// <summary>
            /// HATEOAS link relation used to get the payout batch associated with the current payout item resource.
            /// </summary>
            public const string Batch = "batch";

            /// <summary>
            /// HATEOAS link relation used to get a specific payout item resource associated with current payout batch.
            /// </summary>
            public const string Item = "item";

            /// <summary>
            /// HATEOAS link relation used to resend a webhook event.
            /// </summary>
            public const string Resend = "resend";

            /// <summary>
            /// HATEOAS link relation used for webhook searches and provides results for the next set of search results.
            /// </summary>
            public const string Next = "next";

            /// <summary>
            /// HATEOAS link relation used for webhook searches and provides results for the previous set of search results.
            /// </summary>
            public const string Previous = "previous";
        }
    }
}
