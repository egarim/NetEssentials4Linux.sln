using CommandLine;
using NetEssentials4Linux.Core;

namespace NetEssentials4Linux.AppMonitor
{
    public class InstallOptions : OptionsBase
    {


        // Omitting long name, defaults to name of property, ie "--verbose"
        [Option('s',
          Default = false,
          HelpText = "True if the app is compiled as self contained")]
        public bool SelfContained { get; set; }

        [Option('r', "restart",
          Default = 10,
          HelpText = "Restart time")]
        public int RestartTime { get; set; }

        [Option('l', "logidentifier", HelpText = "Syslog Identifier")]
        public string SyslogIdentifier { get; set; }

        // /usr/share/dotnet/dotnet --version


        [Option('n', "netruntime",
          Default = "/usr/share/dotnet/dotnet",
          HelpText = "Path of the net framework runtime")]
        public string NetRuntime { get; set; }


        [Option('w', "workdirectory",
          Default = "",
          HelpText = "The working directory of the app")]
        public string WorkDirectory { get; set; }


        [Option('e', "executable",
        HelpText = "Name of the executable")]
        public string Executable { get; set; }

        //[Value(0, MetaName = "offset", HelpText = "File offset.")]
        //public long? Offset { get; set; }
    }
}