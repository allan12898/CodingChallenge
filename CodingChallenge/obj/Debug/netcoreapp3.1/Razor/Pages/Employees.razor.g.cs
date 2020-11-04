#pragma checksum "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0866e3b11aa6091e970db38a7e3aeaff527bbb2"
// <auto-generated/>
#pragma warning disable 1591
namespace CodingChallenge.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using CodingChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using CodingChallenge.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using CodingChallenge.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\_Imports.razor"
using CodingChallenge.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
using CodingChallenge.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
using CodingChallenge.Domain.Models.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Students</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates managing Employees data.</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
 if (employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-hover");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>School</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
             foreach (var item in employees)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
                         item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
                         item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
                         item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
                         item.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 34 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 37 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\pc4\source\repos\CodingChallenge\CodingChallenge\Pages\Employees.razor"
            
    Employee[] employees;

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        employees = await employeeService.GetEmployeesAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
