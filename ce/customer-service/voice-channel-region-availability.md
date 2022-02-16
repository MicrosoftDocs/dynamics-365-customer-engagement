---
title: "Regional availability of the voice channel | MicrosoftDocs"
description: "Learn about the region availability and supported languages for the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 02/15/2022
ms.topic: article

---



# Regional availability and supported languages for the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

This article provides information about the availability of the voice channel in the different geographical regions and the supported languages and locale codes.

> [!NOTE]
> For information about availability of live chat and digital messaging channels, see [International availability of Omnichannel for Customer Service](international-availability.md#international-availability-of-omnichannel-for-customer-service).

## Supported regions

Use the information in the following table to know about the availability of the voice channel in Omnichannel for Customer Service.

> [!IMPORTANT]
> Your Microsoft 365 tenant must be co-located in one of the following geographic locations where Omnichannel for Customer Service is available. These geographic locations refer to your Microsoft 365 tenant only and not the data center where your Dynamics 365 environment or org instance resides.

|Geographic location | Availability | Availability in Customer Service trial|
|----------|---------|-----|
|North America <sup> **1** </sup> |November 2021  | November 2021|
|Europe, Middle East, and Africa <sup>**2**</sup> |December 2021 |To be announced|
|Asia Pacific <sup>**2**</sup> |December 2021 |To be announced|
|Australia <sup>**2**</sup> |December 2021 |To be announced|
|South America|To be announced | To be announced|
|Country/Region clouds: Canada, France, Germany, India, Japan, Switzerland, United Arab Emirates (UAE), United Kingdom |To be announced |To be announced|
|Government Community Cloud (GCC) |To be announced |To be announced|
||||

> [!NOTE]
>
> - <sup>**1**</sup> Supports [Microsoft as a carrier](/azure/communication-services/concepts/telephony/telephony-concept) for purchasing new US numbers and also [porting your existing US or toll-free phone numbers](/azure/communication-services/quickstarts/telephony/port-phone-number). Customers with billing locations in United States, United Kingdom, Ireland, and Puerto Rico are the only ones who can purchase numbers through Microsoft as a carrier. Other customers can select a [different carrier](voice-channel-bring-your-own-number.md) by using Azure direct routing.
> - <sup>**2**</sup>  Microsoft as a carrier is available only in specific billing postal codes, however bring your own carrier via Azure direct routing is supported everywhere using certified Session Border Controllers (SBCs). More information: [Bring your own carrier](voice-channel-bring-your-own-number.md). Though Azure direct routing is in public preview everywhere, it will provide generally available level of support for Dynamics 365 customers where the voice channel is generally available in the region. Country/Region-specific cloud deployments for the voice channel in Omnichannel for Customer Service are excluded, you must use the general region deployment. For example, in the preceding table, country/region cloud for local deployment in United Kingdom is **"To be announced"** and is not part of the Europe geographical region availability. If you want your data to stay within the country/region, you'll need to wait for country/region-specific local deployment of the voice channel. More information: [Datacenter regions](/power-platform/admin/new-datacenter-regions)


## Supported languages and locale codes

See the information in the following table to know about the supported languages and locale codes.

| Language |Locale code |
| ---- | ---- |
| Arabic - Saudi Arabia	| ar-SA  |
| Basque  | eu-ES  |
| Bulgarian - Bulgaria | 	bg-BG  |
| Catalan 	| ca-ES  |
| Chinese - China	| zh-CN  |
| Chinese - Hong Kong SAR | 	zh-HK  |
| Chinese - Taiwan	| zh-TW  |
| Croatian - Croatia | 	hr-HR  |
| Czech - Czech Republic	| cs-CZ  |
| Danish - Denmark | da-DK  |
| Dutch - Netherlands | 	nl-NL  |
| English - United States | 	en-US  |
| Estonian - Estonia	| et-EE  |
| Finnish - Finland	| fi-FI  |
| French - France	| fr-FR  |
| Galician 	| gl-ES  |
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

### Language limitations by feature

We use the Azure Cognitive Services Speech service Speech-to-Text for transcription, so we'll support all the languages that Speech-to-Text supports today. We also support a bring-your-own bot through Azure Bot Service for Interactive Voice Response (IVR) that will be constrained by the languages that Speech-to-Text supports. Power Virtual Agents is available only for a subset of languages, so for Power Virtual Agents-based IVR, we will support the languages that Power Virtual Agents supports.

In Text-to-Speech and Speech-to-Text, the following languages only are supported in the voice channel.

| Language    | Locale code |
|-------------|-------------|
| Arabic - Egypt | ar-EG |
| Arabic - Saudi Arabia | ar-SA |
| Catalan - Spain | ca-ES |
| Chinese - Mandarin, Simplified |zh-CN |
| Chinese - Cantonese, Traditional | zh-HK |
| Chinese - Taiwanese, Mandarin | zh-TW |
| Danish - Denmark | da-DK |
| Dutch - Netherlands | nl-NL |
| English - Australia | en-AU |
| English - Canada | en-CA |
| English - India | en-IN |
| English - New Zealand | en- NZ |
| English - United Kingdom | en-GB |
| English - United States | en-US  |
| Finnish - Finland | fi-FI |
| French - Canada | fr-CA |
| French - France | fr-FR |
| German - Germany | de-DE |
| Gujarati - India | gu-IN |
| Hindi - India | hi-IN |
| Hungarian - Hungary | hu-HU |
| Italian - Italy | it-IT |
| Japanese - Japan | ja-JP|
| Korean - Korea | ko-KR |
| Marathi - India | mr-IN |
| Norwegian - Norway | nb-NO |
| Polish - Poland | pl-PL |
| Portuguese - Brazil | pt-BR |
| Portuguese - Portugal | pt-PT |
| Russian - Russia | ru-RU |
| Spanish - Spain | es-ES  |
| Spanish - Mexico	| es-MX  |
| Swedish - Sweden | sv-SE |
| Tamil - India | ta-IN |
| Telugu - India | te-IN |
| Thai - Thailand | th-TH |
| Turkish - Turkey | tr-TR |
|||


Use the information in the following table to know about the feature-wise support for languages.
 
| Feature |	List of supported languages |
| ---- | ---- |
| Transcription | [Language and speech support](/azure/cognitive-services/speech-service/language-support)|
| Power Virtual Agents (IVR) | [Power Virtual Agents supported languages](/power-virtual-agents/authoring-language-support)|
| Bring your own bot (IVR) | [Language and voice support for the Speech service](/azure/cognitive-services/speech-service/language-support)|
| AI suggestions | [Language support for AI suggestions](csw-enable-ai-suggested-cases-knowledge-articles.md#language-support-for-ai-suggestions)|
| Sentiment Analysis | [Multi-language sentiment](enable-sentiment-analysis.md#multi-language-sentiment) |
| Other Omnichannel for Customer Service features | [Language availability in Omnichannel for Customer Service](international-availability.md#language-availability)
|||

### See also

[Overview of the voice channel](voice-channel.md)  
[FAQs about the voice channel in Omnichannel for Customer Service](voice-channel-faqs.md)  

