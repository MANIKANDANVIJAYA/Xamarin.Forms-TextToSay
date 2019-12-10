using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrsimSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SpeakPage : ContentView
	{
		public SpeakPage ()
		{
			InitializeComponent ();
		}
	}
}