using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServicesDemo.Models
{
    public class Language
    {
        [BindProperty]
        public string Lang { get; set; }
        public string Value { get; set; }
    }
}
