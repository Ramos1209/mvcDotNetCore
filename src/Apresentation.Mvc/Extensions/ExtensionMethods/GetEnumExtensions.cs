using System;
using System.Linq;
using System.Reflection;

namespace Apresentation.Mvc.Extensions.ExtensionMethods
{
    public static class GetEnumExtensions
    {
        public static string GetDescription(this Enum _enum)
        {
            Type genericEnum = _enum.GetType();
            MemberInfo[] memberInfos = genericEnum.GetMember(_enum.ToString());
            if ((memberInfos.Length <= 0)) return _enum.ToString();

            var attr = memberInfos[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

            return attr.Any() ? ((System.ComponentModel.DescriptionAttribute)attr.ElementAt(0)).Description : _enum.ToString();

         
        }
    }
}
