using System;
using Android.Content;

namespace Chance.MvvmCross.Plugins.UserInteraction.Droid
{
    internal class DismissListener<TResult> : Java.Lang.Object, IDialogInterfaceOnCancelListener, IDialogInterfaceOnDismissListener
    {
        private readonly Action<TResult> action;
        private readonly TResult defaultValue;

        public DismissListener(Action<TResult> action, TResult defaultValue)
        {
            this.action = action;
            this.defaultValue = defaultValue;
        }

        public void OnDismiss(IDialogInterface dialog)
        {
            this.ExecuteAction();
        }

        public void OnCancel(IDialogInterface dialog)
        {
            this.ExecuteAction();
        }

        private void ExecuteAction()
        {
            if (action != null)
            {
                action(defaultValue);
            }
        }
    }
}
