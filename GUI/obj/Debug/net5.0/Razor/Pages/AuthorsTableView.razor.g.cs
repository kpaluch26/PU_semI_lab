#pragma checksum "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7752eed9aa9fd32ca56e550224fc0d7cb1f27038"
// <auto-generated/>
#pragma warning disable 1591
namespace GUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using GUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\_Imports.razor"
using GUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
using RepositoryPattern;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
using Model.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class AuthorsTableView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 1 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
     currentHeading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
 if (authors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, @"<thead><tr><th>FirstName</th>
                <th>SecondName</th>
                <th>Books</th>
                <th>AvarageRate</th>
                <th>RatesCount</th>
                <th>Rate author</th>
                <th>Add book</th>
                <th>Edit author</th>
                <th>Delete author</th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 29 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
             foreach (var _author in authors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                          ()=> OnRowClicked(_author)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 32 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                     _author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 33 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                     _author.SecondName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 34 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                     GetBooks(_author)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 35 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                     _author.AvarageRate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 36 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                     _author.RatesCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 38 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                     for (int i = 1; i <= 5; i++)
                    {
                        int x = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                                          () => OnAddAuthorRates(_author,x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<span class=\"oi oi-star\"></span>");
            __builder.CloseElement();
#nullable restore
#line 42 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                                                    () =>OnAddBookToAuthor(_author)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "class", "oi oi-plus");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                                                    () =>OnEditAuthor(_author)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "oi oi-cog");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                                      ()=>OnAuthorDelete(_author)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
                      () => OnAddAuthor()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "class", "btn btn-primary");
            __builder.AddContent(49, "Add Author");
            __builder.CloseElement();
#nullable restore
#line 52 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\AuthorsTableView.razor"
       
    private string currentHeading = "All available authors";
    private List<AuthorDTO> authors;

    protected override void OnInitialized()
    {
        authors = authorRepository.GetAuthors(new PaginationDTO(0, 100));
    }

    private void OnAddAuthorRates(AuthorDTO _authorDTO, int _rate)
    {
        bool _result = authorRepository.AddRateToAuthor(_authorDTO.Id, _rate);

        if (_result)
        {
            authors = authorRepository.GetAuthors(new PaginationDTO(0, 100));
            InvokeAsync(() => { this.StateHasChanged(); });
        }
    }

    private string GetBooks(AuthorDTO _authorDTO)
    {
        var _bookList = _authorDTO.Books.Select(b => b.Title);
        return string.Join(", ", _bookList);
    }

    private void OnAuthorDelete(AuthorDTO _authorDTO)
    {
        bool _result = authorRepository.DeleteAuthor(_authorDTO.Id);

        if (_result)
        {
            authors.Remove(_authorDTO);
            InvokeAsync(() => { this.StateHasChanged(); });
        }
    }

    private void OnRowClicked(AuthorDTO _authorDTO)
    {
        currentHeading = "Selected author: " + _authorDTO.FirstName.Trim() + " " + _authorDTO.SecondName.Trim();
        Console.WriteLine(currentHeading);
    }

    private void OnEditAuthor(AuthorDTO _authorDTO)
    {
        string _index = _authorDTO.Id.ToString();
        navigationManager.NavigateTo($"/authors/edit/{_index}");
    }

    private void OnAddBookToAuthor(AuthorDTO _authorDTO)
    {
        string _index = _authorDTO.Id.ToString();
        navigationManager.NavigateTo($"/authors/edit/{_index}");
    }

    private void OnAddAuthor()
    {
        navigationManager.NavigateTo($"/authors/add");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthorRepository authorRepository { get; set; }
    }
}
#pragma warning restore 1591