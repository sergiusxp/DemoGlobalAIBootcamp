using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CognitiveServicesDemo.Services
{
    class ApiKeyServiceClientCredentials : ServiceClientCredentials
    {
        private static string _apiKey;
        private static string _endpoint;
        private static ServiceClientCredentials _credentials;

        public ApiKeyServiceClientCredentials(
            string apiKey,
            string endpoint)
        {
            _apiKey = apiKey;
            _endpoint = endpoint;
        }

        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }
            request.Headers.Add("Ocp-Apim-Subscription-Key", _apiKey);
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }

    public class Text
    {
        private static string _apiKey;
        private static string _endpoint;
        private static string _text;
        private static TextAnalyticsClient _client;

        public Text( 
            string apiKey,
            string endpoint)
        {
            _apiKey = apiKey;
            _endpoint = endpoint;
            _client = authenticateClient();
        }

        private static TextAnalyticsClient authenticateClient()
        {
            ApiKeyServiceClientCredentials credentials = new ApiKeyServiceClientCredentials(
                _apiKey,
                _endpoint);
            var client = new TextAnalyticsClient(credentials)
            {
                Endpoint = _endpoint
            };
            return client;
        }

        public void setText(string text)
        {
            _text = text;
        }

        public string sentimentAnalysis()
        {
            var result = _client.Sentiment(_text, "en");
            return ($"<p><b>Sentiment Score</b>: {result.Score:0.00}</p>");
        }

        public string languageDetection()
        {
            var result = _client.DetectLanguage(_text, "EN");
            return ($"<p><b>Language</b>: {result.DetectedLanguages[0].Name}</p>");
        }

        public string entityRecognition()
        {
            string sa = "";
            var result = _client.Entities(_text);
            sa += ("<p><b>Entities</b>:</p>");
            foreach (var entity in result.Entities)
            {
                sa += ($"<br>\t<b>Name</b>: {entity.Name}<br>\t<b>Type</b>: {entity.Type ?? "N/A"}<br>\t<b>Sub-Type</b>: {entity.SubType ?? "N/A"}");
                foreach (var match in entity.Matches)
                {
                    sa += ($"\t\tOffset: {match.Offset},\tLength: {match.Length},\tScore: {match.EntityTypeScore:F3}");
                }
            }

            return sa;
        }

        public string keyPhraseExtraction()
        {
            var result = _client.KeyPhrases(_text);

            string sa = "<p><b>Key phrases</b>:</p><ul>";

            foreach (string keyphrase in result.KeyPhrases)
            {
                sa += ($"\t<li>{keyphrase}</li>");
            }

            sa += "</ul>";

            return sa;
        }
    }
}
