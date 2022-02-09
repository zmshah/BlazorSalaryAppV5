// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSalaryAppV5.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using BlazorSalaryAppV5.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using BlazorSalaryAppV5.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\_Imports.razor"
using BlazorSalaryAppV5.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\Pages\SalaryTable.razor"
using BlazorSalaryAppV5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\Pages\SalaryTable.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/salaryTable")]
    public partial class SalaryTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 205 "D:\Computer Science\ComputerScience\Projects\BlazorSalaryAppV5\Client\Pages\SalaryTable.razor"
       
    //Intitializing a list of salaries 
    public List<SalaryData> Salaries { get; set; }

    public float MedianPayYearly;
    List<float> salaryList;

    [Inject]
    public ISalaryService SalaryService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Salaries = (await SalaryService.GetSalaries()).ToList();
    }

    public string GetMedianPayYearly()
    {
        //Salaries = (await SalaryService.GetSalaries()).ToList();
        //List<float> salaryList = Salaries.Select(x => x.PayYearly).ToList();
        salaryList = Salaries.Select(x => x.PayYearly).ToList();
        salaryList.Sort();
        int size = salaryList.Count();
        int mid = size / 2;
        MedianPayYearly = (size % 2 != 0) ? (float)salaryList[mid] : ((float)salaryList[mid] + (float)salaryList[mid - 1]) / 2;
        return "$" + MedianPayYearly.ToString();
    }
    public string GetMedianPayYTD()
    {
        //Salaries = (await SalaryService.GetSalaries()).ToList();
        //List<float> salaryList = Salaries.Select(x => x.PayYearly).ToList();
        salaryList = Salaries.Select(x => x.PayYTD).ToList();
        salaryList.Sort();
        int size = salaryList.Count();
        int mid = size / 2;
        MedianPayYearly = (size % 2 != 0) ? (float)salaryList[mid] : ((float)salaryList[mid] + (float)salaryList[mid - 1]) / 2;
        return "$" + MedianPayYearly.ToString();
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
