using CodeYouCapstone;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.HttpOverrides;
using System.Runtime.CompilerServices;

namespace CapstoneBlazor.Components.Pages
    
{
    public partial class ChartDisplay
    {
        [SupplyParameterFromForm]
        public Chart Chart { get; set; }

        protected override void OnInitialized()
        {
           Chart ??= new();

        }
        
    }
}
