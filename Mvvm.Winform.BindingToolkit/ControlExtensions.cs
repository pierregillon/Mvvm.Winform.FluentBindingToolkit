using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Mvvm.Winform.BindingToolkit
{
    public static class ControlExtensions
    {
        public static ControlBinding<TControlValue> Bind<TControl, TControlValue>(this TControl control, Expression<Func<TControl, TControlValue>> expression) where TControl : Control
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
                throw new Exception($"Unable to create binding from expression that does not represent a Member : {expression}");
            return new ControlBinding<TControlValue>(control, memberExpression.Member.Name);
        }
    }
}