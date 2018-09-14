using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class JsonHelper
    {
        public static string SerializeObjectToString(object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
    }
}
