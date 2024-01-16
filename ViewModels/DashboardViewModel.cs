using System.Collections.ObjectModel;
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

    async Task GetEmployesAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            
        }
    }
    
}