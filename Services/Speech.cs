using CognitiveServicesDemo.Models;
using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServicesDemo.Services
{
    public class Speech
    {
        public static async Task<SpeechViewModel> SynthesisToSpeakerAsync(string text, SpeechConfig config)
        {
            SpeechViewModel vm = new SpeechViewModel();
            vm.Status = "error";

            // Creates a speech synthesizer using the default speaker as audio output.
            using (var synthesizer = new SpeechSynthesizer(config))
            {
                using (var speechResult = await synthesizer.SpeakTextAsync(text))
                {
                    if (speechResult.Reason == ResultReason.SynthesizingAudioCompleted)
                    {
                        vm.Result = $"<b>Speech synthesized to speaker</b> for text <i>[{text}]</i>.";
                        vm.Status = "success";
                    }
                    else if (speechResult.Reason == ResultReason.Canceled)
                    {
                        var cancellation = SpeechSynthesisCancellationDetails.FromResult(speechResult);
                        vm.Result = $"<b>CANCELED</b>: Reason={cancellation.Reason}";
                        vm.Status = "warning";

                        if (cancellation.Reason == CancellationReason.Error)
                        {
                            vm.Result = $"<b>CANCELED</b>: ErrorCode={cancellation.ErrorCode}<br>";
                            vm.Result += $"<b>CANCELED</b>: ErrorDetails=[{cancellation.ErrorDetails}]<br>";
                            vm.Result += $"<b>CANCELED</b>: Did you update the subscription info?";
                        }
                    }
                }
            }

            return vm;
        }
    }
}
