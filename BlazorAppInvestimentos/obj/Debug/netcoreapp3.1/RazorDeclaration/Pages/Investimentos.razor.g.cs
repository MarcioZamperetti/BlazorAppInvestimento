#pragma checksum "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\Pages\Investimentos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e3c3ff77d309137a4a31bdb801f11fca7cc8fab"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppInvestimentos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using BlazorAppInvestimentos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\_Imports.razor"
using BlazorAppInvestimentos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\Pages\Investimentos.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\Pages\Investimentos.razor"
using BlazorAppInvestimentos.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/investimentos")]
    public partial class Investimentos : calculosJurosCompostos
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "D:\Aplicacoes\BlazorAppInvestimentos\BlazorAppInvestimentos\Pages\Investimentos.razor"
       

    calculosJurosCompostos Data = new calculosJurosCompostos();

    private void OnInput(ChangeEventArgs e, Action<double> setProperty)
    {
        try
        {
            setProperty(Math.Round(Double.Parse(e.Value.ToString()), 2));
        }
        catch (Exception ex)
        {
            setProperty(0);
        }
        UpdateAll();
    }

    private void OnFocusIn(double propValue, string stringValue, Action<string> setString)
    {
        if (!string.IsNullOrEmpty(stringValue))
            setString(String.Format("{0:0.##}", propValue));
    }

    private void OnFocusOut(Format format, double propValue, Action<string> setString)
    {
        switch (format)
        {
            case (Format.Currency):
                setString(String.Format("{0:N0}", propValue));
                break;
            case (Format.Percent):
                setString(String.Format("{0:N2}", propValue));
                break;
            case (Format.None):
                setString(propValue.ToString());
                break;
        }
    }

    private void UpdateAll()
    {
        Data.CalculaMontante();
        SetStrings();

    }

    private void SetStrings()
    {
        if (!double.IsNaN(Data.montante))
        {
            Data.montanteTotal = String.Format("{0:N2}", Data.montante);
            Data.aportesTotais = String.Format("{0:N2}", Data.investimentoTotal);
            Data.jurosTotais = String.Format("{0:N2}", Data.jurosTotal);
        }
    }

    private void ResetAll()
    {
        Data = new calculosJurosCompostos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
