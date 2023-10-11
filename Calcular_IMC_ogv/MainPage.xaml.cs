using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calcular_IMC_ogv
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Peso.Text) && !string.IsNullOrEmpty(Altura.Text))
            {
                float _peso = float.Parse(Peso.Text);
                float _altura = float.Parse(Altura.Text);
                float _IMC = _peso / (_altura * _altura);
                IMC.Text = _IMC.ToString();

                string Rango = "";
                if (_IMC < 18)
                {
                    Rango = "Tienes bajo peso";
                }
                else if (_IMC >= 18 && _IMC <= 24.9)
                {
                    Rango = "Peso Normal";
                }
                else if (_IMC > 24.9 && _IMC <= 29.9)
                {
                    Rango = "Tienes sobrepeso";
                }
                else
                {
                    Rango = "tienes obesidad";
                }

                DisplayAlert("Rango de peso", Rango, "Cancelar");

            }
            else
            {
                DisplayAlert("Campos vacios", "Ingresa los datos", "Quitar");
            }
        }
    }
}
