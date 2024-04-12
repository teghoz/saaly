using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Saaly.Shared.Extensions;

public static class ListExtensions
{
    public static SelectList MorphToDropdownOptions<T, TValue, TText>(this IEnumerable<T>? collection,
        Expression<Func<T, TValue>> valueExpression,
        Expression<Func<T, TText>> textExpression)
    {
        if (collection is null)
        {
            return new SelectList(default, "Value", "Text");
        }
        var valueFunc = valueExpression.Compile();
        var textFunc = textExpression.Compile();
        
        var items = collection.Select(c => new SelectListItem
        {
            Value = valueFunc(c)?.ToString(),
            Text = textFunc(c)?.ToString()
        });

        return new SelectList(items, "Value", "Text");
    }
}