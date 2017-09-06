using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalheView : ContentPage
	{
        public Veiculo Veiculo { get; set; }

        private const int VALOR_FREIO_ABS = 800;
        private const int VALOR_AR_CONDICIONADO = 1000;
        private const int VALOR_MP3_Player = 500;

        public string TextoFreioABS
        public DetalheView ()
		{
			InitializeComponent ();
		}
	}
}