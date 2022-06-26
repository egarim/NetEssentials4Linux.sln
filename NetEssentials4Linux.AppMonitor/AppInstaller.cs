using NetEssentials4Linux.Core;

namespace NetEssentials4Linux.AppMonitor
{
    public class AppInstaller : EssentialBase
    {
        protected override void RunOptions(OptionsBase opts)
        {
            var CurrentOptions = opts as InstallOptions;


            var File = NetEssentials4Linux.Core.Extensions.ReadResourceFile("NetEssentials4Linux.AppMonitor.Templates.UbuntuServiceTemplate.txt").Replace("$WorkingDirectory", CurrentOptions.WorkDirectory); ;
            Console.WriteLine(File);
            //Console.WriteLine(WorkingDirectory);


            // var CurrentInstallOptions=opts as InstallOptions;
            // string WorkingDirectory = System.IO.Directory.GetCurrentDirectory();
            // if (OperatingSystem.IsLinux())
            // {


            //     Console.WriteLine("We're on Linux!");
            //     var File = "";//ReadResourceFile("JocheOjeda.AppAsService.Templates.UbuntuServiceTemplate.txt").Replace("$WorkingDirectory", WorkingDirectory); ;
            //     Console.WriteLine(File);
            //     Console.WriteLine(WorkingDirectory);
            // }
            // CommandLine.Parser.Default.ParseArguments<InstallOptions>(args)
            //                .WithParsed(RunOptions)
            //                .WithNotParsed(HandleParseError);

        }
    }
}