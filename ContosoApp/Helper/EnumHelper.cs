
using System.ComponentModel;

namespace ContosoApp.Helper
{
    public static class EnumHelper
    {
        public static string GetDescription<T>(this T value) where T:struct
        {

            var field = value.GetType().GetField(value.ToString());
            var atttributes = field.GetCustomAttributes(false);
            var description = string.Empty;
            if (atttributes.Length >0)
            {
                description = ((DescriptionAttribute)atttributes[0]).Description;
            }
            return description;
        }
    }
}
