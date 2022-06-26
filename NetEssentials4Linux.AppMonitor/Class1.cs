using System.Reflection;

namespace NetEssentials4Linux.AppMonitor
{
    public partial class Class1
    {
        static string ReadResourceFile(string filename)
        {
            var thisAssembly = Assembly.GetExecutingAssembly();
            using (var stream = thisAssembly.GetManifestResourceStream(filename))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}