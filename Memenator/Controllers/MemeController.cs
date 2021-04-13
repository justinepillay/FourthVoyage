using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Memenator.Models;
using System.Net.Http;
using System.Text.Json;
namespace Memenator.Controllers
{
    public class MemeController : Controller
    {
      public MemeController()
      {

      }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
            );
            
            var msg = await client.GetStringAsync("https://api.imgflip.com/get_memes");


            Root myClass = JsonSerializer.Deserialize<Root>(msg);

            MemeHolder.memes = myClass.data.memes;

            return View(myClass.data);
        }


        [HttpGet]
        public IActionResult Generate(String id)
        {
            ViewBag.Meme = id;

            Meme generateMeme = MemeHolder.memes.Where(m => m.id.Equals(id)).First();
               

            return View(generateMeme);
        }



        [HttpPost]
       public async Task<IActionResult> Generate(String caption1, String caption2, String id)
        {

            //sending the url with parameters
           HttpClient client = new HttpClient();

                HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Method= HttpMethod.Post;

                httpRequestMessage.RequestUri =  new Uri("https://api.imgflip.com/caption_image?template_id="+id+"&username=justinepillay&password=Just0401&text0="+caption1+"&text1="+caption2);


                HttpResponseMessage resp = await client.SendAsync(httpRequestMessage);

                String result = resp.Content.ReadAsStringAsync().Result;
                GeneratedRoot rootObj = JsonSerializer.Deserialize<GeneratedRoot>(result);
                Console.WriteLine(result);
                Meme generateMeme = MemeHolder.memes.Where(m => m.id.Equals(id)).First();

                System.Console.WriteLine(rootObj.data.url);
                return RedirectToAction(nameof(Test) ,  new {@url=rootObj.data.url});
        }

        
        [HttpGet]
        public IActionResult Test(String url)
        {
            ViewBag.Url = url;

            return View();
        }


      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
