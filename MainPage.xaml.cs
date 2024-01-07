using minterm_Project_main.ViewModels;

namespace minterm_Project_main;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel(Navigation);
        
    }

    
}