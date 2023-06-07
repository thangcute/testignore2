using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Localization
{
    public interface IModelAttribute
    {
        string Name { get; }
    }

    public class OOSDisplayName : System.ComponentModel.DisplayNameAttribute, IModelAttribute
    {
        private string _resourceValue = string.Empty;

        public OOSDisplayName(string resourceKey)
            : base(resourceKey)
        {
            ResourceKey = resourceKey;
        }

        public string ResourceKey { get; set; }

        public string Name
        {
            get { return "OOSDisplayName"; }
        }
    }
}
