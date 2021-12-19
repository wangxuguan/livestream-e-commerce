using Microsoft.AspNetCore.Mvc;
using month12.Commodity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Month12.Service
{
    public class TextRequest:Volo.Abp.Application.Services.ApplicationService
    {
        //这个url是你要爬的地址
        public static string HttpGet(string url)
        {
            //cookie是在要爬网页F12看到的cookie都复制粘贴到这里就可以
            string cookieStr = "__jdu=1621318054300581941125; shshshfpa=777212a6-91ab-454e-1cda-46b8e7bef488-1626773423; shshshfpb=iGv%20ObeGgyR2W%20WLwyFICrQ%3D%3D; areaId=2; PCSYCityID=CN_310000_310100_0; user-key=355f2184-2c0c-4835-a266-f2447fa957a5; shshshfp=7b41f3223e0aa493b8328ab125369182; unpl=V2_ZzNtbUMCFhUiAERcLx1YVWICRggSB0UUcAtFVHxKDgVvAhNeclRCFnUURldnGVgUZwEZX0RcQxxFCEdkeB5fA2AFEFlBZxpFK0oYEDlNDEY1WnxfSlRGEXUOQ1J7H2w1ZAMiXUNnQxJ2CERUchhYAGUCE1lLV0sQdQhFUEspWzVXMxRbS1dHFkUJdlVLWwhZZAIVXURWDhVyC0ZWexBdAWIBE1xGXkMdcAhGV38pXTVk; CCC_SE=ADC_RsyaTJyhFn%2fBJjjWPEgwEdb9jSSy64al0iQypEviGyoQkmTlaGSgSzYMlIsvVk2CkSSy7ybnpvT%2beOdTL9roFwd%2fvpK%2fAx3407gWEG5T1CdI9ERDkBIcEF66GCHKWhIzM3004GO8k%2f9ig6svh85%2ff0TDTgip5%2fgSFMflgGNePvNhGIO0QsuNjbC%2fgBP%2fCnJj%2fbLkkYV%2bQpQAftvgzR7muF1oeilHXCNcQDqq9DfF%2b2b6Bqk1m2TNd%2fviVBxoL4fjznOV2T9co9LP%2bXya03R%2fb8O5vwroLDQ%2fNnyWD%2b9bP28%2bpefSZT9MxDHwiaBsNujQLlT6Y1t6dUYVULTnK%2fS7VpxQuzY%2fhQw%2bwXw7NWvvR12XtC2%2b7%2fnLFKL4%2bOYwkw6t74ikjKIeAeA5VC%2fNClt1Lyqv%2b4atDCMqRn7xqdlrBvJd%2bWOADqk0voCrc8PvddvGhI22FhZh23uf%2bm%2bx6B2CJ4j7PlGaHql%2bqLBH7CK6xXMN5nkRvISxWuX3ptZ9vna34NKVAk%2bovFAREkYpW9aDn7SJ%2bRL5BWrYpmwLBQCjtUjA5jfnmCxxpmvnkEjeNKyp; __jdv=76161171|haosou-search|t_262767352_haosousearch|cpc|39245174717_0_0dd1f939e55a40edaa7042216bc19002|1639546643923; __jdc=122270672; token=e078bb8bfed36dd8718131bd9cb8fffe,2,910861; __tk=e5092b0b778bb0252ae2a911dc8d8603,2,910861; __jdb=122270672.1.1621318054300581941125|5.1639549835; __jda=122270672.1621318054300581941125.1621318054.1639546644.1639549835.5; shshshsID=7847ce0e1bf1ba443884dd2aa7ef580c_1_1639549835529; ip_cityCode=1611; ipLoc-djd=2-2817-51973-0; 3AB9D23F7A4B3C9B=AHGBEQCUZGF7CF2CHRGCUL6F4P6LOMXMNOFUEDETMP7PANLGGLTBBXGRZ34RH57NCEMJVOMZ3LVGQYNV3OHWS2R7SY";

            //创建请求
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            //请求方式
            httpWebRequest.Method = "GET";
            //设置请求超时时间
            httpWebRequest.Timeout = 20000;

            //设置cookie
            httpWebRequest.Headers.Add("Cookie", cookieStr);
            //发送请求
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //利用Stream流读取返回数据
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
            //获得最终数据，一般是json
            string responseContent = streamReader.ReadToEnd();

            streamReader.Close();
            httpWebResponse.Close();

            //结果 返回给你的一般都是json格式的字符串
            return responseContent;
        }

        public void JsonToObject(string resultJson)
        {

            JObject obj = JObject.Parse(resultJson);
            //data是你需要的那组数据 可以看上面响应数据那张图data是我想要的数据
            var data = obj["data"];
            //会返回一个数组，也就是你自己创建的，Preview这里需要改成你创建的那个类
            var array = data.ToObject<IList<GoodsModel>>();
            //foreach (var item in array)
            //{
            //    var iv = item.Iv;
            //}
        }

        [HttpGet]
        public string Reptile()
        {
            var list = TextRequest.HttpGet("https://item.jd.com/100021333290.html");
            return list;
        }

    }
}
