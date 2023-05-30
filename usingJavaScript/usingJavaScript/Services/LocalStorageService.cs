using Microsoft.JSInterop;
using System.Text.Json;

namespace usingJavaScript.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private IJSRuntime js;

        public LocalStorageService(IJSRuntime js)
        {
            this.js = js;
        }

        public async ValueTask<T?> GetItemAsync<T>(string key)
        {
            var json = await js.InvokeAsync<string>("interopObject.getLocalStorage", key);
            return JsonSerializer.Deserialize<T>(json);
        }

        public async ValueTask SetItemAsync<T>(string key, T value)
        {
            await js.InvokeVoidAsync("interopObject.setLocalStorage", key, JsonSerializer.Serialize(value));
        }
    }
}
