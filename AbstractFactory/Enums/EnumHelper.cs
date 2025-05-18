using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AbstractFactory.Enums;

public static class EnumHelper
{
    public static string GetDisplayName(this Enum enumValue)
    {
        return enumValue.GetType()?
            .GetMember(enumValue.ToString())?
            .FirstOrDefault()?
            .GetCustomAttribute<DisplayAttribute>()?
            .GetName() ?? enumValue.ToString();
    }
}