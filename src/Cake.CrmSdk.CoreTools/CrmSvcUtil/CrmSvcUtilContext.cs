using Cake.Core;
using Cake.Core.Configuration;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.CrmSdk.CoreTools.CrmSvcUtil
{
    internal sealed class CrmSvcUtilContext
        : ICakeContext
    {
        private readonly ICakeContext _context;
        private readonly CrmSvcUtilProcessRunner _runner;

        public CrmSvcUtilContext(ICakeContext cakeContext)
        {
            _context = cakeContext;
            _runner = new CrmSvcUtilProcessRunner();
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
