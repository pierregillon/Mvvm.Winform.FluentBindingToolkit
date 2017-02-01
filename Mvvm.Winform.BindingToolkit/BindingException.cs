using System;

namespace Mvvm.Winform.BindingToolkit
{
    public class BindingException : Exception
    {
        // On passe innerMessage car si on passe une innerException, le catcher global n'affiche que l'inner et pas cette exception.
        public BindingException(string viewModelPropertyName, string controlPropertyName, string controlName, string innerMessage):base(BuildMessage(viewModelPropertyName, controlPropertyName, controlName, innerMessage))
        {
        }

        private static string BuildMessage(string viewModelPropertyName, string controlPropertyName, string controlName, string innerMessage)
        {
            return $"Erreur de binding sur le contr�le '{controlName}' sur la propri�t� '{controlPropertyName}', bind� � '{viewModelPropertyName}' du viewModel. {innerMessage}";
        }
    }
}