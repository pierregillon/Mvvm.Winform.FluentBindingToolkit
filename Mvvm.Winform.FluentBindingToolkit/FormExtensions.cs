using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Mvvm.Winform.FluentBindingToolkit
{
    public static class FormExtensions
    {
        public static void BindPopupVisibility<T>(this Form form, T viewModel, Expression<Func<T, bool>> property) where T : INotifyPropertyChanged
        {
            var memberExpression = (MemberExpression) property.Body;
            var propertyInfo = (PropertyInfo) memberExpression.Member;
            viewModel.PropertyChanged += (sender, args) => {
                if (args.PropertyName == memberExpression.Member.Name) {
                    var isVisible = (bool) propertyInfo.GetValue(viewModel);
                    if (isVisible) {
                        form.ShowDialog();

                        // End of the execution of the ui pool ShowDialog(), 
                        // The window is closed, we put property to false.
                        propertyInfo.SetValue(viewModel, false);
                    }
                    else {
                        if (form.Visible) {
                            form.Visible = false;
                        }
                    }
                }
            };
        }
    }
}