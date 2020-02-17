using System.Collections.Generic;
using System.Linq;
using Cake.Core.IO;

namespace Cake.CrmSdk.CoreTools.SolutionPackager
{
    internal sealed class SolutionPackagerProcessRunner
        : IProcessRunner
    {
        public FilePath FilePath { get; set; }

        public ProcessSettings ProcessSettings { get; set; }

        public IProcess Start(
            FilePath filePath,
            ProcessSettings settings)
        {
            FilePath = filePath;
            ProcessSettings = settings;
            return new InterceptedProcess();
        }

        private sealed class InterceptedProcess : IProcess
        {
            public void Dispose()
            {
                // no op
            }

            public void WaitForExit()
            {
                // no op
            }

            public bool WaitForExit(int milliseconds)
            {
                return true;
            }

            public int GetExitCode()
            {
                return 0;
            }

            public IEnumerable<string> GetStandardError()
            {
                return Enumerable.Empty<string>();
            }

            public IEnumerable<string> GetStandardOutput()
            {
                return Enumerable.Empty<string>();
            }

            public void Kill()
            {
                // no op
            }
        }
    }
}
