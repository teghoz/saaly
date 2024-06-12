using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace Saaly.Shared.Helpers.Forms;

public static class ContactFormHelper
{
    public static T RetrieveObjectFormElements<T>(this IFormCollection form, T model)
    {
        if (model is null)
        {
            model = Activator.CreateInstance<T>();
        }
        foreach (var propertyInfo in model.GetType().GetProperties())
        {
            SetPropertyValue(model, propertyInfo.Name, form[propertyInfo.Name]);
        }

        return model;
    }
    
    private static void SetPropertyValue<T>(T destinationObject, string propertyName, object? value)
    {
        PropertyInfo prop = destinationObject.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
        if (prop != null && prop.CanWrite)
        {
            if (value is StringValues)
            {
                value = value.ToString();
                value = Convert.ChangeType(value, prop.PropertyType);
            }
            
            prop.SetValue(destinationObject, value, null);
        }
    }
}