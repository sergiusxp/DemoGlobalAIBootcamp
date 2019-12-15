using CognitiveServicesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServicesDemo.Helpers
{
    public static class ImageHelper
    {
        public static List<ImageViewModel> ToImageList(this IEnumerable<string> images)
        {
            List<ImageViewModel> _temp = new List<ImageViewModel>();
            foreach (string img in images)
            {
                _temp.Add(new ImageViewModel() { ImageName = img, Result = "" });
            }

            return _temp;
        }
    }
}
