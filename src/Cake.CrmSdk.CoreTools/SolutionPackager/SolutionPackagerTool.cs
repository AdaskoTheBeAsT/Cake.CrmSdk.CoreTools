using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Cake.CrmSdk.CoreTools.CrmSvcUtil;

namespace Cake.CrmSdk.CoreTools.SolutionPackager
{
    public class SolutionPackagerTool<TSettings>
        : Tool<TSettings>
        where TSettings : CrmSvcUtilSettings
    {
        private readonly ICakeEnvironment _environment;

        /// <summary>
        /// Initializes a new instance of the <see cref="CrmSvcUtilTool{TSettings}" /> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        protected SolutionPackagerTool(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools)
        {
            _environment = environment;
        }

        /// <summary>
        /// Get arguments from global settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The process arguments.</returns>
        protected ProcessArgumentBuilder GetArguments(SolutionPackagerSettings settings)
        {
            if (settings is null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            var builder = new ProcessArgumentBuilder();

            // LogFile
            if (settings.LogFile != null)
            {
                var logFilePath = settings.LogFile.MakeAbsolute(_environment);
                builder.AppendSwitch("/LogFile", "=", logFilePath.FullPath.Quote());
            }

            return builder;
        }

        protected override string GetToolName() => "SolutionPackager";

        protected override IEnumerable<string> GetToolExecutableNames() => new[] { "SolutionPackager.exe" };
    }
}
