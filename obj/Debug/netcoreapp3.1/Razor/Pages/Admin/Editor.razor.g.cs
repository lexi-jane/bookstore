#pragma checksum "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "478c49f9cf68a9b3bc15f9102d156bc912434743"
// <auto-generated/>
#pragma warning disable 1591
namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/create")]
    public partial class Editor : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    div.validatino-message {\n        color: rgb(220,53,69);\n        font-weight: 500\n    }\n</style>\n\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 12 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                 b

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                   SaveBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\n\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.AddMarkupContent(14, "<label>Book Id:</label>\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "disabled", true);
                __builder2.AddAttribute(18, "value", 
#nullable restore
#line 20 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                         b.BookId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "\n            ");
                __builder2.AddMarkupContent(24, "<label>Title:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 25 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                      () => b.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                         b.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Title = __value, b.Title))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.AddMarkupContent(38, "<label>Author:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 31 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                      () => b.Author

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                         b.Author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Author = __value, b.Author))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Author));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n\n\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\n            ");
                __builder2.AddMarkupContent(52, "<label>Publisher:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 38 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                      () => b.Publisher

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                         b.Publisher

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Publisher = __value, b.Publisher))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Publisher));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n\n        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\n            ");
                __builder2.AddMarkupContent(66, "<label>Isbn:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 67, 68, 
#nullable restore
#line 44 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                      () => b.Isbn

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "class", "form-control");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                         b.Isbn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Isbn = __value, b.Isbn))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Isbn));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "\n            ");
                __builder2.AddMarkupContent(80, "<label>Classification:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_4(__builder2, 81, 82, 
#nullable restore
#line 50 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                      () => b.Classification

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(83, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                         b.Classification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Classification = __value, b.Classification))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Classification));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\n\n        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group");
                __builder2.AddMarkupContent(93, "\n            ");
                __builder2.AddMarkupContent(94, "<label>Category:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_5(__builder2, 95, 96, 
#nullable restore
#line 56 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                      () => b.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(97, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                __builder2.AddAttribute(99, "class", "form-control");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                         b.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Category = __value, b.Category))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\n\n        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group");
                __builder2.AddMarkupContent(107, "\n            ");
                __builder2.AddMarkupContent(108, "<label>PageCount:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_6(__builder2, 109, 110, 
#nullable restore
#line 62 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                      () => b.PageCount

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(111, "\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateInputNumber_7(__builder2, 112, 113, "form-control", 114, 
#nullable restore
#line 63 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                           b.PageCount

#line default
#line hidden
#nullable disable
                , 115, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.PageCount = __value, b.PageCount)), 116, () => b.PageCount);
                __builder2.AddMarkupContent(117, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\n\n        ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "form-group");
                __builder2.AddMarkupContent(121, "\n            ");
                __builder2.AddMarkupContent(122, "<label>Price:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_8(__builder2, 123, 124, 
#nullable restore
#line 68 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                      () => b.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(125, "\n            ");
                __Blazor.Bookstore.Pages.Admin.Editor.TypeInference.CreateInputNumber_9(__builder2, 126, 127, "form-control", 128, 
#nullable restore
#line 69 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                                           b.Price

#line default
#line hidden
#nullable disable
                , 129, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Price = __value, b.Price)), 130, () => b.Price);
                __builder2.AddMarkupContent(131, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\n\n        ");
                __builder2.OpenElement(133, "button");
                __builder2.AddAttribute(134, "type", "submit");
                __builder2.AddAttribute(135, "class", "btn" + " btn-" + (
#nullable restore
#line 72 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
                                              ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(136, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(138);
                __builder2.AddAttribute(139, "class", "btn btn-secondary");
                __builder2.AddAttribute(140, "href", "/admin/books");
                __builder2.AddAttribute(141, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(142, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(143, "\n    \n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "/Users/alexisjane/BYU/IS Core/IS 413/mission8/Bookstore/Pages/Admin/Editor.razor"
       

    [Parameter]
    public long Id { get; set; } = 0;
    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

    public Book b { get; set; } = new Book();

    public IBookstoreRepository repo => Service;

    protected override void OnParametersSet()
    {
        if (Id != 0) // existing project
        {
            b = repo.Books.FirstOrDefault(x => x.BookId == Id);
        }
    }

    public void SaveBook()
    {
        if (Id == 0) //New Project
        {
            repo.CreateBook(b);
        }
        else
        {
            repo.SaveBook(b);
        }

        NavManager.NavigateTo("/admin/books");
    }

    [Inject]
    public NavigationManager NavManager { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Bookstore.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
