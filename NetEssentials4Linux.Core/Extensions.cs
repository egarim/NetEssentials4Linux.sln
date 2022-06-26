using System.Reflection;

namespace NetEssentials4Linux.Core
{
    public class Extensions
    {
                public static string ReadResourceFile(string filename)
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