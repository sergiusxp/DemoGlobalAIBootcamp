using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CognitiveServicesDemo.Services
{
    public class ComputerVision
    {
        public static async Task<string> AnalyzeImageUrl(ComputerVisionClient client, string imageUrl)
        {
            string processed = "";
            string nl = "";

            processed += nl + ("<p>----------------------------------------------------------</p>");
            processed += nl + ("<p>ANALYZE IMAGE - URL</p>");
            processed += nl;
            
            List<VisualFeatureTypes> features = new List<VisualFeatureTypes>()
            {
                VisualFeatureTypes.Categories, VisualFeatureTypes.Description,
                VisualFeatureTypes.Faces, VisualFeatureTypes.ImageType,
                VisualFeatureTypes.Tags, VisualFeatureTypes.Adult,
                VisualFeatureTypes.Color, VisualFeatureTypes.Brands,
                VisualFeatureTypes.Objects
            };

            processed += nl + ($"<p>Analyzing the image <b>{Path.GetFileName(imageUrl)}</b>...</p>");
            processed += nl;

            try
            {
                // Analyze the URL image 
                ImageAnalysis results = await client.AnalyzeImageAsync(imageUrl, features);

                // Sunmarizes the image content.
                processed += nl + ("<p>Summary:</p><ul>");
                foreach (var caption in results.Description.Captions)
                {
                    processed += nl + ($"<li>{caption.Text} with confidence {caption.Confidence}</li>");
                }
                processed += nl;

                // Display categories the image is divided into.
                processed += nl + ("</ul><p>Categories:</p><ul>");
                foreach (var category in results.Categories)
                {
                    processed += nl + ($"<li>{category.Name} with confidence {category.Score}</li>");
                }
                processed += nl;

                // Image tags and their confidence score
                processed += nl + ("</ul><p>Tags:</p><ul>");
                foreach (var tag in results.Tags)
                {
                    processed += nl + ($"<li>{tag.Name} {tag.Confidence}</li>");
                }
                processed += nl;

                // Objects
                processed += nl + ("</ul><p>Objects:</p><ul>");
                foreach (var obj in results.Objects)
                {
                    processed += nl + ($"<li>{obj.ObjectProperty} with confidence {obj.Confidence} at location {obj.Rectangle.X}, " +
                      $"{obj.Rectangle.X + obj.Rectangle.W}, {obj.Rectangle.Y}, {obj.Rectangle.Y + obj.Rectangle.H}</li>");
                }
                processed += nl;

                // Well-known (or custom, if set) brands.
                processed += nl + ("</ul><p>Brands:</p><ul>");
                foreach (var brand in results.Brands)
                {
                    processed += nl + ($"<li>Logo of {brand.Name} with confidence {brand.Confidence} at location {brand.Rectangle.X}, " +
                      $"{brand.Rectangle.X + brand.Rectangle.W}, {brand.Rectangle.Y}, {brand.Rectangle.Y + brand.Rectangle.H}</li>");
                }
                processed += nl;

                // Faces
                processed += nl + ("</ul><p>Faces:</p><ul>");
                foreach (var face in results.Faces)
                {
                    processed += nl + ($"<li>A {face.Gender} of age {face.Age} at location {face.FaceRectangle.Left}, " +
                      $"{face.FaceRectangle.Left}, {face.FaceRectangle.Top + face.FaceRectangle.Width}, " +
                      $"{face.FaceRectangle.Top + face.FaceRectangle.Height}</li>");
                }
                processed += nl;

                // Adult or racy content, if any.
                processed += nl + ("</ul><p>Adult:</p>");
                processed += nl + ($"<p>Has <b>adult content</b>: {results.Adult.IsAdultContent} with confidence {results.Adult.AdultScore}</p>");
                processed += nl + ($"<p>Has <b>racy content</b>: {results.Adult.IsRacyContent} with confidence {results.Adult.RacyScore}</p>");
                processed += nl;

                // Identifies the color scheme.
                processed += nl + ("<p>Color Scheme:</p><ul>");
                processed += nl + ("<li><b>Is black and white?</b>: " + results.Color.IsBWImg + "</li>");
                processed += nl + ("<li><b>Accent color</b>: " + results.Color.AccentColor + "</li>");
                processed += nl + ("<li><b>Dominant background color</b>: " + results.Color.DominantColorBackground + "</li>");
                processed += nl + ("<li><b>Dominant foreground color</b>: " + results.Color.DominantColorForeground + "</li>");
                processed += nl + ("<li><b>Dominant colors</b>: " + string.Join(",", results.Color.DominantColors) + "</li>" + "</ul>");
                processed += nl;

                // Celebrities in image, if any.
                processed += nl + ("<p>Celebrities:</p><ul>");
                foreach (var category in results.Categories)
                {
                    if (category.Detail?.Celebrities != null)
                    {
                        foreach (var celeb in category.Detail.Celebrities)
                        {
                            processed += nl + ($"<li>{celeb.Name} with confidence {celeb.Confidence} at location {celeb.FaceRectangle.Left}, " +
                              $"{celeb.FaceRectangle.Top}, {celeb.FaceRectangle.Height}, {celeb.FaceRectangle.Width}</li>");
                        }
                    }
                }
                processed += nl;

                // Popular landmarks in image, if any.
                processed += nl + ("</ul><p>Landmarks:</p><ul>");
                foreach (var category in results.Categories)
                {
                    if (category.Detail?.Landmarks != null)
                    {
                        foreach (var landmark in category.Detail.Landmarks)
                        {
                            processed += nl + ($"<li>{landmark.Name} with confidence {landmark.Confidence}</li>");
                        }
                    }
                }
                processed += nl;

                // Detects the image types.
                processed += nl + ("</ul><p>Image Type:</p>");
                processed += nl + ("<ul><li>Clip Art Type: " + results.ImageType.ClipArtType + "</li>");
                processed += nl + ("<li>Line Drawing Type: " + results.ImageType.LineDrawingType + "</li></ul>");
                processed += nl;

                return processed;
            }
            catch (Exception e)
            {
                return String.Format("Error retrieving data: <i>{0}</i><p>Image: <i>{1}</i></p>", e.Message, imageUrl);
            }
        }

        public static async Task<string> AnalyzeOCR(string imageUrl, string subscriptionKey, string endpoint)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add(
                    "Ocp-Apim-Subscription-Key", subscriptionKey);
                
                string requestParameters = "language=en&detectOrientation=true";
                
                string uri = endpoint + "vision/v2.1/ocr" + "?" + requestParameters;

                HttpResponseMessage response;
                
                byte[] byteData = GetImageAsByteArray(imageUrl);
                
                using (ByteArrayContent content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType =
                        new MediaTypeHeaderValue("application/octet-stream");
                    
                    response = await client.PostAsync(uri, content);
                }
                
                string contentString = await response.Content.ReadAsStringAsync();
                var msg = JToken.Parse(contentString).ToString();

                return msg;
            }
            catch (Exception e)
            {
                return String.Format("Error retrieving data: <i>{0}</i><p>Image: <i>{1}</i></p>", e.Message, imageUrl);
            }
        }
        
        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }
    }
}
