using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using minterm_Project_main.Modal;
using minterm_Project_main.Services;

namespace minterm_Project_main.ViewModels;

public partial class  DashboardViewModel : BaseViewModel
{
    EmployeService employeService;
    public ObservableCollection<Employe> Employes { get; } = new ();
    
    public DashboardViewModel(EmployeService employeService)
    {
        Title = "List of Employees";
        this.employeService = employeService;
        
        
    }
    [RelayCommand]
    async Task GetEmployesAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            var employes = await employeService.GetEmployes();
            if (Employes.Count != 0)
                Employes.Clear();
            foreach (var employe in Employes)
                Employes.Add(employe);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            await Shell.Current.DisplayAlert("Error!", $"unable to get employees list: {e.Message}", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
    
}