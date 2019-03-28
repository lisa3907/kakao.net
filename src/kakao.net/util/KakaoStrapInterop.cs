using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Kakao.Net.util
{
    public class KakaoStrapInterop
    {
        private IJSRuntime JSRuntime { get; set; }

        public KakaoStrapInterop(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }

        public Task<bool> DrawMap(float latitude, float longitude)
            => JSRuntime.InvokeAsync<bool>("kakaoMapInterop.drawMap", latitude, longitude);

        public Task<bool> DrawTraffic(float latitude, float longitude)
            => JSRuntime.InvokeAsync<bool>("kakaoMapInterop.drawTraffic", latitude, longitude);
    }
}
