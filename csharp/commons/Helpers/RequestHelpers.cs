using System;
using System.Linq;

namespace commons
{
    public static class RequestHelpers
    {
        public static string FormatResponse(string _input)
        {
            return _input;
        }

        //public static string FormatExcludeString(Exclude[] input)
        //{
        //    return string.Join(",", input.Select(i => Enum.GetName(typeof(Exclude), i)));
        //}

        //public static string FormatExtendString(Extend[] input)
        //{
        //    return string.Join(",", input.Select(i => Enum.GetName(typeof(Extend), i)));
        //}
    }
}
