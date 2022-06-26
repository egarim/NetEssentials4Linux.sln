using NetEssentials4Linux.Core;

namespace NetEssentials4Linux.AppMonitor
{
    public class AppInstaller : EssentialBase
    {
        protected override void RunOptions(OptionsBase opts)
        {

               
                var File = NetEssentials4Linux.Core.Exentesions.ReadResourceFile("JocheOjeda.AppAsService.Templates.UbuntuServiceTemplate.txt").Replace("$WorkingDirectory", WorkingDirectory); ;
                Console.WriteLine(File);
                Console.WriteLine(WorkingDirectory);


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