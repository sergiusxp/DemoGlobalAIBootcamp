using CognitiveServicesDemo.Models;
using CognitiveServicesDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServicesDemo.Controllers
{
    public class TextController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private string _subscriptionKey;
        private string _endpoint;
        private Text _textService;

        public TextController(
            IConfiguration config,
            IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _subscriptionKey = _config.GetValue<string>("text:subscriptionKey");
            _endpoint = _config.GetValue<string>("text:endpoint");
            _httpContextAccessor = httpContextAccessor;
            _textService = new Text(_subscriptionKey, _endpoint);
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ViewResult> SentimentAnalysis(TextViewModel vm)
        {
            if (vm != null && !string.IsNullOrEmpty(vm.Text))
            {
                string result = "";
                _textService.setText(vm.Text);
                result += _textService.sentimentAnalysis();
                //result += _textService.languageDetection();
                result += _textService.entityRecognition();
                result += _textService.keyPhraseExtraction();
                vm.Result = result;
            }

            return View("SentimentAnalysis", vm);
        }
    }
}