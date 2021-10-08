using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Uniwear.core.Helpers
{
    public static class QueryStringHelper
    {
        public static int getIntFromQueryString(HttpRequestBase request, string key, int fallBackValue = 0)
        {
            var stringValue = request.QueryString[key];

            if (stringValue != null && !string.IsNullOrWhiteSpace(stringValue) && int.TryParse(stringValue, out var numericValue))
            {
                return numericValue;
            }
            return fallBackValue;
        }
    }
}
