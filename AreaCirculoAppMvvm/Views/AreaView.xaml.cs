
using AreaCirculoAppMvvm.ViewModels;

namespace AreaCirculoAppMvvm.Views;

public partial class AreaView : ContentPage
{
    AreaViewModel viewModel;
    public AreaView()
	{
		InitializeComponent();
        viewModel = new AreaViewModel();
        this.BindingContext = viewModel;
    }
}