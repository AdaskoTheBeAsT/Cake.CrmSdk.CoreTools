using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.CrmSdk.CoreTools.CrmSvcUtil
{
    /// <summary>
    /// Contains settings used by <see cref="CrmSvcUtilTool{TSettings}" />.
    /// </summary>
    public class CrmSvcUtilSettings
        : ToolSettings
    {
        public CrmSvcUtilSettings()
        {
            Language = Language.CS;
        }

        /// <summary>
        /// /nologo.
        /// Suppresses the banner.
        /// </summary>
        public bool NoLogo { get; set; }

        /// <summary>
        /// /language:&lt;language&gt;
        /// The language to use for the generated proxy code.
        /// This can be either 'CS' or 'VB'.
        /// The default language is 'CS'.
        /// Short form is '/l:'.
        /// </summary>
        public Language Language { get; set; }

#pragma warning disable CA1056 // Uri properties should not be strings
        /// <summary>
        /// /url:&lt;url&gt;
        /// A url or path to the SDK endpoint to contact for metadata.
        /// </summary>
        public string MetadataEndpointUrlOrPath { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings

        /// <summary>
        /// /out:&lt;filename&gt;
        /// The filename for the generated proxy code.
        /// Short form is '/o:'.
        /// </summary>
        public string GeneratedProxyFilename { get; set; }

        /// <summary>
        /// /namespace:&lt;namespace&gt;
        /// The namespace for the generated proxy code.The default namespace is the global namespace.
        /// Short form is '/n:'.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// /connectionstring:
        /// Connection String to use when connecting to CRM.If provided, all other connect info is ignored.
        /// Short form is '/connstr:'.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// /username:&lt;username&gt;
        /// Username to use when connecting to the server for authentication.
        /// Short form is '/u:'.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// /password:&lt;password&gt;
        /// Password to use when connecting to the server for authentication.
        /// Short form is '/p:'.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// /domain:&lt;domain&gt;
        /// Domain to authenticate against when connecting to the server.
        /// Short form is '/d:'.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// /serviceContextName:&lt;service context name&gt;
        /// The name for the generated service context. If a value is passed in, it will be used for the Service Context.
        /// If not, no Service Context will be generated.
        /// </summary>
        public string ServiceContextName { get; set; }

        /// <summary>
        /// /generateActions
        /// Generate wrapper classes for custom actions.
        /// Short form is '/a'.
        /// </summary>
        public bool GenerateActions { get; set; }

        /// <summary>
        /// /deviceid:&lt;deviceid&gt;
        /// Device ID to use when connecting to the online server for authentication.
        /// Short form is '/di:'.
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// /devicepassword:&lt;devicepassword&gt;
        /// Device Password to use when connecting to the online server for authentication.
        /// Short form is '/dp:'.
        /// </summary>
        public string DevicePassword { get; set; }

        /// <summary>
        /// Gets or sets a value that enables logging and specifies log file name
        /// This represents the <c>/LogFile</c> option.
        /// </summary>
        public FilePath LogFile { get; set; }
    }
}
