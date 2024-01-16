using System.Net.Http.Json;
using minterm_Project_main.Modal;

namespace minterm_Project_main.Services;

public class EmployeService
{
    private HttpClient httpClient;

    public EmployeService()
    {
        httpClient = new HttpClient();
    }
    private List<Employe> employesList = new ();
    
    
    
    public async Task<List<Employe>> GetEmployes()
    {
        if (employesList?. Count > 0)
        {
            return employesList;
        }

        var url = "https://hub.dummyapis.com/employee?noofRecords=10&idStarts=1001";
        var response = await httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            employesList = await response.Content.ReadFromJsonAsync<List<Employe>>();
        }
        
        return employesList;
    }
}