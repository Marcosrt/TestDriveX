using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    public class Veiculo
    {
        public string nome { get; set; }

        public decimal preco { get; set; }

        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", preco);
            }
        }

        public FormattedString VeiculoLabel
        {
            get
            {
                return new FormattedString
                {
                    Spans =
                    {
                        new Span { Text = nome },
                        new Span { Text = " - " },
                        new Span { Text = PrecoFormatado, FontAttributes = FontAttributes.Bold }
                    }

                };
            }

            set { }
        }
    }
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListagemView : ContentPage
	{
        public List<Veiculo> Veiculos { get; set; }
		public ListagemView ()
		{
			InitializeComponent ();

            this.Veiculos = new List<Veiculo>()
            {
                new Views.Veiculo { nome = "Azera V6", preco = 85000 },
                new Views.Veiculo { nome = "Onix 1.6", preco = 35000 },
                new Views.Veiculo { nome = "Fiesta 2.0", preco = 52000 },
                new Views.Veiculo { nome = "C3 1.0", preco = 22000 },
                new Views.Veiculo { nome = "Uno Fire", preco = 11000 },
                new Views.Veiculo { nome = "Sentra 2.0", preco = 53000 },
                new Views.Veiculo { nome = "Astra Sedan", preco = 39000 },
                new Views.Veiculo { nome = "Vectra 2.0 Turbo", preco = 37000 },
                new Views.Veiculo { nome = "Hilux 4x4", preco = 90000 },
                new Views.Veiculo { nome = "Montana Cabine dupla", preco = 57000 },
                new Views.Veiculo { nome = "Outlander 2.4", preco = 99000 },
                new Views.Veiculo { nome = "Brasilia Amarela", preco = 9500 },
                new Views.Veiculo { nome = "Omega Hatch", preco = 8000 }
            };

            this.BindingContext = this;
		}

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new DetalheView(veiculo));
        }
	}
}