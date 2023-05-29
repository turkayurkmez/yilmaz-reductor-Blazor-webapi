using Microsoft.AspNetCore.Components;

namespace firstBlazorApp.Components
{
    public partial class Hello
    {
        [Parameter]
        [EditorRequired]
        public string Meeting { get; set; } = "İyi günler";
    }
}
