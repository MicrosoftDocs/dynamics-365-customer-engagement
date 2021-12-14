---
title: "Regional availability of the voice channel | MicrosoftDocs"
description: "Learn about the region availability and supported languages for the voice channel in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 12/15/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Regional availability and supported languages for the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Supported regions

The following table lists the upcoming availability of the voice channel in Omnichannel for Customer Service:

|Geographic location | Availability | Availability in Customer Service trial|
|----------|---------|-----|
|North America <br> **Note** <br> Supports both Microsoft as a carrier for the US numbers (Customers with billing locations in United Kingdom, Ireland, and Puerto Rico are the only ones in capacity to buy the US numbers) and [Bring your own carrier or number](voice-channel-bring-your-own-number.md) via [Azure direct routing](/azure/communication-services/concepts/telephony/telephony-concept#azure-direct-routing) |November 2021  | November 2021|
|Europe <br> *See the note that follows. |December 2021 |January 2022|
|Asia Pacific <br> *See the note that follows. |December 2021 |January 2022|
|Australia<br> *See the note that follows. |December 2021 |January 2022|
|South America|To be announced | To be announced|
|Country clouds: Canada, France, Germany, India, Japan, Switzerland, United Arab Emirates (UAE), United Kingdom	|To be announced |To be announced|
|Government Community Cloud (GCC) |To be announced |To be announced|
||||

> [!NOTE]
>
> - Bring your own carrier or number via Azure direct routing is supported for local country numbers using certified Session Border Controllers (SBCs). Regional availability of Microsoft as a carrier is limited to only US numbers. Customers with billing locations in United Kingdom, Ireland, and Puerto Rico are the only ones in capacity to buy the US numbers.
> - Country-specific cloud deployments for the voice channel in Omnichannel for Customer Service are excluded. For example, if you are looking for United Kingdom country local deployment then it is “Yet to be announced” and is not part of the Europe geo region availability. However, you can serve United Kingdom customers from the Europe instance if you want.
> - The voice channel will be generally available for the regions according to the timelines mentioned in the table. This means that underlying Azure direct routing (though in preview in some of these regions) will also provide GA level of support for the voice customers.


## Supported languages and locale codes

| Language Name |Locale Code |
| ---- | ---- |
| Arabic - Saudi Arabia	| ar-SA  |
| Basque - Spain | 	eu-ES  |
| Bulgarian - Bulgaria | 	bg-BG  |
| Catalan - Spain	| ca-ES  |
| Chinese - China	| zh-CN  |
| Chinese - Hong Kong | 	zh-HK  |
| Chinese - Taiwan	| zh-TW  |
| Croatian - Croatia | 	hr-HR  |
| Czech - Czech Republic	| cs-CZ  |
| Danish - Denmark | da-DK  |
| Dutch - Netherlands | 	nl-NL  |
| English - United States | 	en-US  |
| Estonian - Estonia	| et-EE  |
| Finnish - Finland	| fi-FI  |
| French - France	| fr-FR  |
| Galician - Spain	| gl-ES  |
| German - Germany	| de-DE  |
| Greek - Greece	| el-GR  |
| Hebrew - Israel	| he-IL  |
| Hindi - India	| hi-IN  |
| Hungarian - Hungary	| hu-HU  |
| Indonesian - Indonesia	| id-ID  |
| Italian - Italy	| it-IT  |
| Japanese - Japan	| ja-JP  |
| Kazakh - Kazakhstan	| kk-KZ  |
| Korean - Korea	| ko-KR  |
| Latvian - Latvia	| lv-LV  |
| Lithuanian - Lithuania	| lt-LT  |
| Malay - Malaysia	| ms-MY  |
| Norwegian Bokmal - Norway	| nb-NO  |
| Polish - Poland	| pl-PL  |
| Portuguese - Brazil	| pt-BR  |
| Portuguese - Portugal	| pt-PT  |
| Romanian - Romania	| ro-RO  |
| Russian - Russia	| ru-RU  |
| Serbian (Cyrillic) - Serbia	| sr-Cyrl-CS  |
| Serbian (Latin) - Serbia	| sr-Latn-CS  |
| Slovak - Slovakia	| sk-SK  |
| Slovenian - Slovenia	| sl-SI  |
| Spanish - Spain	| es-ES  |
| Swedish - Sweden	| sv-SE  |
| Thai - Thailand	| th-TH  |
| Turkish - Turkey	| tr-TR  |
| Ukrainian - Ukraine	| uk-UA  |
| Vietnamese - Vietnam	| vi-VN |
|||

## Language limitations by feature

### What languages are supported in the voice channel at general availability (GA)

For our GA release of voice channel, language support is feature-specific. 

We use Azure Cognitive Service Speech’s Speech-to-Text for transcription, so we plan on supporting all of the languages that Speech-To-Text supports today. Power Virtual Agents is available only for a subset of languages, so for Power Virtual Agents-based IVR, we will support the languages that Power Virtual Agents supports. We also support a bring-your-own-bot through Azure Bot Service for IVR that will be constrained by the languages that speech-to-text supports. For AI suggestions, we have added more languages as of April 2021.  

### Are there any real-time limitations

We're planning to support additional languages for the GA release in 2021. See the list of supported languages.

 
| Feature |	List of supported languages |
| ---- | ---- |
| Transcription | [Language and speech support](/azure/cognitive-services/speech-service/language-support) |
| Power Virtual Agents (IVR) | [Power Virtual Agents supported languages](/power-virtual-agents/authoring-language-support) |
| Bring your own bot (IVR) | [Language and voice support for the Speech service](/azure/cognitive-services/speech-service/language-support)  |
| AI suggestions | [Language support for AI suggestions](csw-enable-ai-suggested-cases-knowledge-articles.md#language-support-for-ai-suggestions) |
| Sentiment Analysis | [Multi-language sentiment](enable-sentiment-analysis.md#multi-language-sentiment)  |
| Other Omnichannel features | [Language availability in Omnichannel for Customer Service](international-availability.md#language-availability)


### See also

[Overview of the voice channel](voice-channel.md)  
