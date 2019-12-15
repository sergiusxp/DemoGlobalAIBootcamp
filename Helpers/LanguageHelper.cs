using CognitiveServicesDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServicesDemo.Helpers
{
    public static class LanguageHelper
    {
        public static IEnumerable<SelectListItem> ToItemList(this List<Language> langs)
        {
            List<SelectListItem> li = new List<SelectListItem>();
            foreach (Language l in langs)
            {
                li.Add(new SelectListItem(l.Lang, l.Value, l.Value == "en-US"));
            }

            return li.AsEnumerable();
        }
    }
}
