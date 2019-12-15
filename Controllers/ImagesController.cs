using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CognitiveServicesDemo.Models;
using CognitiveServicesDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Extensions.Configuration;
using System.Web;
using Microsoft.AspNetCore.Http.Extensions;
using CognitiveServicesDemo.Helpers;

namespace CognitiveServicesDemo.Controllers
{
    public class ImagesController : Controller
    {
        private List<ImageViewModel> _images;
        private ComputerVisionClient _client;
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ImagesController(
            IConfiguration config,
            IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            string subscriptionKey = _config.GetValue<string>("computerVision:subscriptionKey");
            string endpoint = _config.GetValue<string>("computerVision:endpoint");
            _httpContextAccessor = httpContextAccessor;

            var credentials = new Microsoft.Azure.CognitiveServices.Vision.ComputerVision.ApiKeyServiceClientCredentials(subscriptionKey);
            _client = new ComputerVisionClient(credentials) { Endpoint = endpoint };
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FileUpload(string name)
        {
            _images = new List<ImageViewModel>();
            var newFileName = string.Empty;

            if (HttpContext.Request.Form.Files != null)
            {
                var fileName = string.Empty;

                var files = HttpContext.Request.Form.Files;

                foreach (var file in files)
                {
                    if (file.Length > 0) 
                    {
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        var FileExtension = Path.GetExtension(fileName);

                        newFileName = myUniqueFileName + FileExtension;
                        fileName = Path.Combine("wwwroot\\uploads") + $@"\{newFileName}";

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }

                        _images.Add(new ImageViewModel() { ImageName = newFileName, Result = "" });
                    }
                }
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult DeleteImage(ImageViewModel ivm)
        {
            string name = Path.Combine("wwwroot\\uploads") + $@"\{ivm.ImageName}";
            if (!System.IO.File.Exists(name))
            {
                return View("Error");
            }
            else
            {
                System.IO.File.Delete(name);
            }

            return View("Index");
        }

        public async Task<PartialViewResult> GetSomeData([FromQuery] string path)
        {

            string testUrl = String.Format("{0}/{1}/{2}", UrlHelper.HostWithNoSlash(
                new Uri(_httpContextAccessor.HttpContext?.Request?.GetDisplayUrl())), "uploads", path);

            string imgProcessed = await ComputerVision.AnalyzeImageUrl(_client, testUrl);

            ViewBag.Message = imgProcessed;
            return PartialView("InfoPartial");
        }
    }
}