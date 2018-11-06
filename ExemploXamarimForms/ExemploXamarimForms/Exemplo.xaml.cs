using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExemploXamarimForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exemplo : ContentPage
	{
		public Exemplo ()
		{
			InitializeComponent ();
		}

	    private void BtnEnviar_OnClicked(object sender, EventArgs e)
	    {
	        int n = Convert.ToInt32(tbxTeste.Text);
	        if (n % 2 == 0)
	        {
	           lblResult.Text += " par";

	        }
	        else
	        {
	           lblResult.Text += " ímpar";
            }
	    }
	}
}