#pragma checksum "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "482aaa308714163985c2010b8be83340b541e3a3"
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
#line 3 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
using RepositoryPattern;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
using Model.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books")]
    public partial class BooksTableView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 1 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
     currentHeading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
 if (books == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, @"<thead><tr><th>Title</th>
                <th>ReleaseDate</th>
                <th>AvarageRate</th>
                <th>RateCount</th>
                <th>Authors</th>
                <th>Rate book</th>
                <th>Add author</th>
                <th>Edit book</th>
                <th>Delete book</th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 29 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
             foreach (var _book in books)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                              ()=> OnRowClicked(_book)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 32 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                         _book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 33 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                         _book.ReleaseDate.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 34 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                          GetAuthors(_book)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, ";");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 35 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                         _book.AvarageRate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 36 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                         _book.RatesCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 38 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                         for (int i = 1; i <= 5; i++)
                        {
                            int x = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                                              () => OnAddBookRates(_book,x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "<span class=\"oi oi-star\"></span>");
            __builder.CloseElement();
#nullable restore
#line 42 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                                                        () =>OnAddAuthorToBook(_book)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "oi oi-plus");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                                                        () =>OnEditBook(_book)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "oi oi-cog");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                                          ()=>OnBookDelete(_book)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
                      () => OnAddBook()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "class", "btn btn-primary");
            __builder.AddContent(50, "Add Book");
            __builder.CloseElement();
#nullable restore
#line 52 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\studia_II_stopien\PU\LAB\LAB_1\ProgramowanieUzytkoweIP12\GUI\Pages\BooksTableView.razor"
       
    private string currentHeading = "All available books";
    private List<BookDTO> books;

    protected override void OnInitialized()
    {
        books = booksRepository.GetBooks(new PaginationDTO(0, 100));
    }

    private string GetAuthors(BookDTO _bookDTO)
    {
        var _authorList = _bookDTO.Authors.Select(a => a.FirstName + " " + a.SecondName);
        return string.Join(", ", _authorList);
    }

    private void OnAddBookRates(BookDTO _bookDTO, int _rate)
    {
        bool _result = booksRepository.AddRateToBook(_bookDTO.ID, _rate);

        if (_result)
        {
            books = booksRepository.GetBooks(new PaginationDTO(0, 100));
            InvokeAsync(() => { this.StateHasChanged(); });
        }
    }

    private void OnBookDelete(BookDTO _bookDTO)
    {
        bool _result = booksRepository.RemoveBook(_bookDTO.ID);

        if (_result)
        {
            books.Remove(_bookDTO);
            InvokeAsync(() => { this.StateHasChanged(); });
        }
    }

    private void OnRowClicked(BookDTO _bookDTO)
    {
        currentHeading = "Selected book: " + _bookDTO.Title.Trim();
        Console.WriteLine(currentHeading);
    }

    private void OnAddAuthorToBook(BookDTO _bookDTO)
    {
        navigationManager.NavigateTo($"/books/edit/{_bookDTO.ID}");
    }

    private void OnEditBook(BookDTO _bookDTO)
    {
        navigationManager.NavigateTo($"/books/edit/{_bookDTO.ID}");
    }

    private void OnAddBook()
    {
        navigationManager.NavigateTo($"/books/add");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BooksRepository booksRepository { get; set; }
    }
}
#pragma warning restore 1591
