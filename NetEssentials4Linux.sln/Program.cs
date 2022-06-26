using CommandLine;
using NetEssentials4Linux.AppMonitor;

namespace NetEssentials4Linux.sln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ExecuteableName = args[0];
            //string WorkingDirectory = args[0];

            string WorkingDirectory = System.IO.Directory.GetCurrentDirectory();
            if (OperatingSystem.IsLinux())
            {


                Console.WriteLine("We're on Linux!");
                var File = ReadResourceFile("JocheOjeda.AppAsService.Templates.UbuntuServiceTemplate.txt").Replace("$WorkingDirectory", WorkingDirectory); ;
                Console.WriteLine(File);
                Console.WriteLine(WorkingDirectory);
            }
            CommandLine.Parser.Default.ParseArguments<InstallOptions>(args)
                           .WithParsed(RunOptions)
                           .WithNotParsed(HandleParseError);
            Console.ReadLine();
        }
        static void RunOptions(InstallOptions opts)
        {
            //handle options
        }
        static void HandleParseError(IEnumerable<Error> errs)
        {
            //handle errors
        }
    }
}