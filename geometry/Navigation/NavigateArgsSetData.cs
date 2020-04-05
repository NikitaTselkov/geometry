using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry.Navigation
{
    public class NavigateArgsSetData
    {
        public NavigateArgsSetData()
        {

        }

        public NavigateArgsSetData(string url)
        {
            Url = url;
        }

        public string Url { get; set; }
    }
}
