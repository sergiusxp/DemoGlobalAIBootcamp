using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServicesDemo.Models
{
    public class SpeechViewModel
    {
        public string Text { get; set; } = null;
        public string Result { get; set; } = null;
        public string Status { get; set; } = null;
        public string Language { get; set; } = "en-US";
        public string LanguageFrom { get; set; } = null;
        public string LanguageTo { get; set; } = null;
        public string Translation { get; set; } = null;
    }
}
