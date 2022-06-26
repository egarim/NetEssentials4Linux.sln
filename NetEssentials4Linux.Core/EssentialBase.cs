
using CommandLine;

namespace NetEssentials4Linux.Core
{
    public class EssentialBase
    {
        public virtual void Execute(string[] args)
        {


            if (OperatingSystem.IsLinux())
            {
                throw new Exception("this Os is not linux base");
            }
             CommandLine.Parser.Default.ParseArguments<OptionsBase>(args)
                           .WithParsed(RunOptions)
                           .WithNotParsed(HandleParseError);
        }
        protected virtual void RunOptions(OptionsBase opts)
        {
            throw new NotImplementedException();
        }
        protected virtual void HandleParseError(IEnumerable<Error> errs)
        {
            throw new NotImplementedException();
        }
    }
}