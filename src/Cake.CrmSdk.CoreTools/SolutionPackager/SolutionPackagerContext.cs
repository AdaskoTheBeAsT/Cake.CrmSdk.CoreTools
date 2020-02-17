using Cake.Core;
using Cake.Core.Configuration;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.CrmSdk.CoreTools.SolutionPackager
{
    internal sealed class SolutionPackagerContext
        : ICakeContext
    {
        private readonly ICakeContext _context;
        private readonly SolutionPackagerProcessRunner _runner;

        public SolutionPackagerContext(ICakeContext cakeContext)
        {
            _context = cakeContext;
            _runner = new SolutionPackagerProcessRunner();
            Log = new NullLog();
        }

        public IFileSystem FileSystem => _context.FileSystem;

        public ICakeEnvironment Environment => _context.Environment;

        public IGlobber Globber => _context.Globber;

        public ICakeLog Log { get; }

        public ICakeArguments Arguments => _context.Arguments;

        public IProcessRunner ProcessRunner => _runner;

        public IRegistry Registry => _context.Registry;

        public IToolLocator Tools => _context.Tools;

        public ICakeDataResolver Data => _context.Data;

        public FilePath FilePath => _runner.FilePath;

        public ProcessSettings Settings => _runner.ProcessSettings;

        public ICakeConfiguration Configuration => _context.Configuration;
    }
}
