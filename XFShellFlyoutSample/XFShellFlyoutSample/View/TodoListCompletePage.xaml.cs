using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFShellFlyoutSample.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TodoListCompletePage : ContentPage
	{
		public TodoListCompletePage ()
		{
			InitializeComponent ();
		}
	}
}