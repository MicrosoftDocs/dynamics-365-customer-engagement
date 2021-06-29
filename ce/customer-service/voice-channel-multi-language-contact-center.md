---
title: "Set Up a Multi-Language Contact Center in the Voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Set Up a Multi-Language Contact Center


## Prerequisites
> [!Note]
>

>[!TIP] 
> 



## Step 1:

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## sample code

        // Copyright (c) Microsoft Corporation. All rights reserved.
        // Licensed under the MIT License.
        using System.Collections.Generic;
        using System.Threading;
        using System.Threading.Tasks;
        using Microsoft.Bot.Builder;
        using Microsoft.Bot.Schema;

        namespace Microsoft.BotBuilderSamples.Bots
                {
                    public class EchoBot : ActivityHandler
                    {
                        // Method executed when input from a participant is received (such as someone speaking or pressing a number on their keypad)
                        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
                        {
                            if (turnContext.Activity.Text.Contains("agent") || turnContext.Activity.Text.Contains("Agent") || turnContext.Activity.Text.Contains("0"))
                            {
                                await turnContext.SendActivityAsync("Transferring to an agent who can help you with this.");

                                Dictionary<string, object> handOffContext = new Dictionary<string, object>()
                                {
                                    { "va_AgentMessage", "Customer wants to speak with an agent." }
                                };

                                var handoffevent = EventFactory.CreateHandoffInitiation(turnContext, handOffContext);

                                await turnContext.SendActivityAsync(handoffevent);
                            } else if (turnContext.Activity.Text.Contains("2"))
                            {
                                await turnContext.SendActivityAsync(MessageFactory.Text(spanishSelected, spanishSelectedSSML), cancellationToken);

                                Dictionary<string, object> handOffContext = new Dictionary<string, object>()
                                {
                                    { "va_CustomerLocale", "es-ES" }
                                };

                                var handoffevent = EventFactory.CreateHandoffInitiation(turnContext, handOffContext);

                            } else {
                                var english = "I didn't catch that. To speak with an agent, say agent at any time or press zero.";
                                var englishSSML = "<speak xmlns=\"http://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"http://www.w3.org/2001/mstts\" xmlns:emo=\"http://www.w3.org/2009/10/emotionml\" version=\"1.0\" xml:lang=\"en-US\"><voice name=\"en-US-JennyNeural\"><prosody rate=\"0%\" pitch=\"0%\">I didn&apos;t catch that. To speak with an agent, say agent at any time or press zero.</prosody></voice></speak>";

                                var spanishGreeting = "Para Español, oprema dos."; // For Spanish press 2
                                var spanishGreetingSSML = "<speak xmlns=\"http://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"http://www.w3.org/2001/mstts\" xmlns:emo=\"http://www.w3.org/2009/10/emotionml\" version=\"1.0\" xml:lang=\"es-ES\"><voice name=\"es-MX-DaliaNeural\"><prosody rate=\"0%\" pitch=\"0%\">Para Espa\u00F1ol, oprema dos.</prosody></voice></speak>";

                                await turnContext.SendActivityAsync(MessageFactory.Text(english, englishSSML), cancellationToken);
                                await turnContext.SendActivityAsync(MessageFactory.Text(spanishGreeting, spanishGreetingSSML), cancellationToken);
                            }
                        }

                        // Method executed when a participant is added. The is the inital greeting.
                        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
                        {
                            var welcomeText = "Hello and welcome! To speak with an agent, say agent at any time or press zero.";
                            var welcomeSSML = "<speak xmlns=\"http://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"http://www.w3.org/2001/mstts\" xmlns:emo=\"http://www.w3.org/2009/10/emotionml\" version=\"1.0\" xml:lang=\"en-US\"><voice name=\"en-US-JennyNeural\"><prosody rate=\"0%\" pitch=\"0%\">Hello and welcome! To speak with an agent, say agent at any time or press zero.</prosody></voice></speak>";

                            var spanishGreeting = "Para Español, oprema dos."; // For Spanish press 2
                            var spanishGreetingSSML = "<speak xmlns=\"http://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"http://www.w3.org/2001/mstts\" xmlns:emo=\"http://www.w3.org/2009/10/emotionml\" version=\"1.0\" xml:lang=\"es-ES\"><voice name=\"es-MX-DaliaNeural\"><prosody rate=\"0%\" pitch=\"0%\">Para Espa\u00F1ol, oprema dos.</prosody></voice></speak>";

                            await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeSSML), cancellationToken);
                            await turnContext.SendActivityAsync(MessageFactory.Text(spanishGreeting, spanishGreetingSSML), cancellationToken);
                        }
                    }
                }


## Supported locations and locale codes

| Language Name |	Locale Code |
| ---- | ---- |
| Arabic - Saudi Arabia	| ar-SA  |
| Basque - Spain | 	eu-ES
| Bulgarian - Bulgaria | 	bg-BG
| Catalan - Spain	| ca-ES
| Chinese - China	| zh-CN
| Chinese - Hong Kong | 	zh-HK
| Chinese - Taiwan	| zh-TW
| Croatian - Croatia | 	hr-HR
| Czech - Czech Republic	| cs-CZ
| Danish - Denmark	| da-DK
| Dutch - Netherlands | 	nl-NL
| English - United States | 	en-US
| Estonian - Estonia	| et-EE
| Finnish - Finland	| fi-FI
| French - France	| fr-FR
| Galician - Spain	| gl-ES
| German - Germany	| de-DE
| Greek - Greece	| el-GR
| Hebrew - Israel	| he-IL
| Hindi - India	| hi-IN
| Hungarian - Hungary	| hu-HU
| Indonesian - Indonesia	| id-ID
| Italian - Italy	| it-IT
| Japanese - Japan	| ja-JP
| Kazakh - Kazakhstan	| kk-KZ
| Korean - Korea	| ko-KR
| Latvian - Latvia	| lv-LV
| Lithuanian - Lithuania	| lt-LT
| Malay - Malaysia	| ms-MY
| Norwegian Bokmal - Norway	| nb-NO
| Polish - Poland	| pl-PL
| Portuguese - Brazil	| pt-BR
| Portuguese - Portugal	| pt-PT
| Romanian - Romania	| ro-RO
| Russian - Russia	| ru-RU
| Serbian (Cyrillic) - Serbia	| sr-Cyrl-CS
| Serbian (Latin) - Serbia	| sr-Latn-CS
| Slovak - Slovakia	| sk-SK
| Slovenian - Slovenia	| sl-SI
| Spanish - Spain	| es-ES
| Swedish - Sweden	| sv-SE
| Thai - Thailand	| th-TH
| Turkish - Turkey	| tr-TR
| Ukrainian - Ukraine	| uk-UA
| Vietnamese - Vietnam	| vi-VN | 

## Configuration considerations
## Additional Notes

### See also

[Azure cognitive services - speech to text](https://azure.microsoft.com/en-us/services/cognitive-services/text-to-speech/#features)