using Microsoft.Maui.Controls;



namespace minterm_Project_main;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }
}