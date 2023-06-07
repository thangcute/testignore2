using System.Collections.Generic;
using System.Globalization;

namespace Humax.ESS.Localization.Internal
{
    public interface IResourceStringProvider
    {
        IList<string> GetAllResourceStrings(CultureInfo culture, bool throwOnMissing);
    }
}
