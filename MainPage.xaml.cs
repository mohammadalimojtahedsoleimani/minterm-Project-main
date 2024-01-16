using minterm_Project_main.ViewModels;

namespace minterm_Project_main;

public partial class MainPage : ContentPage
{

    public MainPage(DashboardViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = new LoginViewModel(Navigation);
        BindingContext = viewModel;

    }

    
}