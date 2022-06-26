using CommandLine;
using NetEssentials4Linux.Core;

namespace NetEssentials4Linux.AppMonitor
{
    public class InstallOptions:OptionsBase
    {


        // Omitting long name, defaults to name of property, ie "--verbose"
        [Option('s',
          Default = false,
          HelpText = "True if the app is compiled as self contained")]
        public bool SelfContained { get; set; }

        [Option('w', "workdirectory",
          Default = "",
          HelpText = "The working directory of the app")]
        public string WorkDirectory { get; set; }

        //[Value(0, MetaName = "offset", HelpText = "File offset.")]
        //public long? Offset { get; set; }
    }
}