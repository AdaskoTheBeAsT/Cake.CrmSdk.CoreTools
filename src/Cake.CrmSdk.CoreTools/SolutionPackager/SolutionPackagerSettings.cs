using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.CrmSdk.CoreTools.SolutionPackager
{
    /// <summary>
    /// Contains settings used by <see cref="SolutionPackagerTool{TSettings}" />.
    /// </summary>
    public class SolutionPackagerSettings
        : ToolSettings
    {
        /// <summary>
        /// Gets or sets a value that enables logging and specifies log file name
        /// This represents the <c>/LogFile</c> option.
        /// </summary>
        public FilePath LogFile { get; set; }
    }
}
