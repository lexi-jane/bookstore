// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/alexisjane/BYU/IS Core/IS 413/bookstore-mission10/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexisjane/BYU/IS Core/IS 413/bookstore-mission10/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alexisjane/BYU/IS Core/IS 413/bookstore-mission10/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alexisjane/BYU/IS Core/IS 413/bookstore-mission10/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alexisjane/BYU/IS Core/IS 413/bookstore-mission10/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/alexisjane/BYU/IS Core/IS 413/bookstore-mission10/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Users/alexisjane/BYU/IS Core/IS 413/bookstore-mission10/Pages/Admin/Details.razor"
       
    [Inject]
    public IBookstoreRepository repo { get; set; }

    [Parameter]
    public long id { get; set; }
    public Models.Book b { get; set; }
    protected override void OnParametersSet()
    {
        b = repo.Books.FirstOrDefault(x => x.BookId == id);
    }

    public string EditUrl => $"/admin/books/edit/{b.BookId}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
