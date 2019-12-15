using System.Threading.Tasks;
using CognitiveServicesDemo.Models;
using CognitiveServicesDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Extensions.Configuration;
using System.Web;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using CognitiveServicesDemo.Helpers;

namespace CognitiveServicesDemo.Controllers
{
    public class SpeechController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private string _subscriptionKey;
        private string _endpoint;
        private string _region;
        private SpeechConfig _speechConfiguration;

        public SpeechController(
            IConfiguration config,
            IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _subscriptionKey = _config.GetValue<string>("speech:subscriptionKey");
            _endpoint = _config.GetValue<string>("speech:endpoint");
            _region = _config.GetValue<string>("speech:region");
            _httpContextAccessor = httpContextAccessor;
            _speechConfiguration = SpeechConfig.FromSubscription(_subscriptionKey, "westeurope");
        }

        public IActionResult Index()
        {
            ViewData["Languages"] = GetLanguages().ToItemList();
            return View();
        }
        
        public async Task<ViewResult> TextToSpeech(SpeechViewModel vm)
        {
            SpeechViewModel speechResult = null;

            if (vm != null && vm.Text != null && vm.Text.Trim() != "")
            {
                _speechConfiguration.SpeechSynthesisLanguage = vm.Language ?? "en-US";
                speechResult = await Speech.SynthesisToSpeakerAsync(vm.Text, _speechConfiguration);
                speechResult.Text = vm.Text;
            }
            ViewData["Languages"] = GetLanguages().ToItemList();
            return View("Index", speechResult);
        }

        public List<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>();
            languages.Add(new Language() { Value = "ar-EG", Lang = "Arabic (Egypt)" });
            languages.Add(new Language() { Value = "ar-SA", Lang = "Arabic (Saudi Arabia)" });
            languages.Add(new Language() { Value = "ar-AE", Lang = "Arabic (UAE)" });
            languages.Add(new Language() { Value = "ar-KW", Lang = "Arabic (Kuwait)" });
            languages.Add(new Language() { Value = "ar-QA", Lang = "Arabic (Qatar)" });
            languages.Add(new Language() { Value = "ca-ES", Lang = "Catalan" });
            languages.Add(new Language() { Value = "da-DK", Lang = "Danish (Denmark)" });
            languages.Add(new Language() { Value = "de-DE", Lang = "German (Germany)" });
            languages.Add(new Language() { Value = "en-AU", Lang = "English (Australia)" });
            languages.Add(new Language() { Value = "en-CA", Lang = "English (Canada)" });
            languages.Add(new Language() { Value = "en-GB", Lang = "English (United Kingdom)" });
            languages.Add(new Language() { Value = "en-IN", Lang = "English (India)" });
            languages.Add(new Language() { Value = "en-NZ", Lang = "English (New Zealand)" });
            languages.Add(new Language() { Value = "en-US", Lang = "English (United States)" });
            languages.Add(new Language() { Value = "es-ES", Lang = "Spanish (Spain)" });
            languages.Add(new Language() { Value = "es-MX", Lang = "Spanish (Mexico)" });
            languages.Add(new Language() { Value = "fi-FI", Lang = "Finnish (Finland)" });
            languages.Add(new Language() { Value = "fr-CA", Lang = "French (Canada)" });
            languages.Add(new Language() { Value = "fr-FR", Lang = "French (France)" });
            languages.Add(new Language() { Value = "gu-IN", Lang = "Gujarati (Indian)" });
            languages.Add(new Language() { Value = "hi-IN", Lang = "Hindi (India)" });
            languages.Add(new Language() { Value = "it-IT", Lang = "Italian (Italy)" });
            languages.Add(new Language() { Value = "ja-JP", Lang = "Japanese (Japan)" });
            languages.Add(new Language() { Value = "ko-KR", Lang = "Korean (Korea)" });
            languages.Add(new Language() { Value = "mr-IN", Lang = "Marathi (India)" });
            languages.Add(new Language() { Value = "nb-NO", Lang = "Norwegian (Bokmål) (Norway)" });
            languages.Add(new Language() { Value = "nl-NL", Lang = "Dutch (Netherlands)" });
            languages.Add(new Language() { Value = "pl-PL", Lang = "Polish (Poland)" });
            languages.Add(new Language() { Value = "pt-BR", Lang = "Portuguese (Brazil)" });
            languages.Add(new Language() { Value = "pt-PT", Lang = "Portuguese (Portugal)" });
            languages.Add(new Language() { Value = "ru-RU", Lang = "Russian (Russia)" });
            languages.Add(new Language() { Value = "sv-SE", Lang = "Swedish (Sweden)" });
            languages.Add(new Language() { Value = "ta-IN", Lang = "Tamil (India)" });
            languages.Add(new Language() { Value = "te-IN", Lang = "Telugu (India)" });
            languages.Add(new Language() { Value = "zh-CN", Lang = "Chinese (Mandarin, simplified)" });
            languages.Add(new Language() { Value = "zh-HK", Lang = "Chinese (Cantonese, Traditional)" });
            languages.Add(new Language() { Value = "zh-TW", Lang = "Chinese (Taiwanese Mandarin)" });
            languages.Add(new Language() { Value = "th-TH", Lang = "Thai (Thailand)" });
            languages.Add(new Language() { Value = "tr-TR", Lang = "Turkey" });

            return languages;
        }
    }
}
