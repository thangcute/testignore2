using System.IO;
using System.Reflection;

namespace Humax.ESS.Localization.Internal
{
    public static class PathHelpers
    {
        public static string GetApplicationRoot()
            => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}