

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class AreaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double r;

        [ObservableProperty]
        private double a;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void calcular()
        {
            try
            {
                if (R <= 0)
                {
                    Alerta("Error", "El radio debe ser mayor a 0");
                    return;
                }
                else
                {
                    A = Math.PI * Math.Pow(R, 2);
                }
            }
            catch (Exception ex)
            {
                Alerta("Error", ex.Message);
            }
        }

        [RelayCommand]
        private void limpiar()
        {
            R = 0;
            A = 0;
        }
    }
}
