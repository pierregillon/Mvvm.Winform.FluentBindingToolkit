using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Mvvm.Winform.FluentBindingToolkit
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

        public static void BindVisibility<T>(this Control control, T viewModel, Expression<Func<T, bool>> property, bool reverse = false) where T : INotifyPropertyChanged
        {
            var memberExpression = (MemberExpression) property.Body;
            var propertyInfo = (PropertyInfo) memberExpression.Member;
            viewModel.PropertyChanged += (sender, args) => {
                if (args.PropertyName == memberExpression.Member.Name) {
                    var isVisible = (bool) propertyInfo.GetValue(viewModel);
                    if (isVisible) {
                        control.Visible = !reverse;
                    }
                    else {
                        control.Visible = reverse;
                    }
                }
            };
        }
    }
}