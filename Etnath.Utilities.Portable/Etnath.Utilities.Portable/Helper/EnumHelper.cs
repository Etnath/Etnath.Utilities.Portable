using Etnath.Utilities.Portable.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Etnath.Utilities.Portable.Helper
{
    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            return GetDescriptionString(value);
        }

        public static string GetDescriptionString(Enum value)
        {
            Type type = value.GetType();
            string enumName = Enum.GetName(type, value);
            if (enumName != null)
            {
                FieldInfo field = type.GetRuntimeFields().First(f => f.Name == enumName);
                field.GetCustomAttribute<DescriptionAttribute>();
                DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                if (attribute != null)
                {
                    return attribute.Description;
                }
                else
                {
                    //TODO throw a more meaningful exception
                    throw new Exception();
                }
            }
            else
            {
                //TODO throw a more meaningful exception
                throw new Exception();
            }
        }
    }
}
