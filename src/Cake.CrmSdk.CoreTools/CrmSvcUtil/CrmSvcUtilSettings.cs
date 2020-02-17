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
        /// <summary>
        /// Gets or sets a value that enables logging and specifies log file name
        /// This represents the <c>/LogFile</c> option.
        /// </summary>
        public FilePath LogFile { get; set; }
    }
}
