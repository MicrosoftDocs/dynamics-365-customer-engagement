---
title: "Regional availability in the Voice channel | MicrosoftDocs"
description: "Learn abou the region availability and supported languages for the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 08/13/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ROBOTS: NOINDEX,NOFOLLOW
---

# Regional availability and supported languages for the Voice channel

## Supported Regions

Omnichannel for Customer Service's voice channel is currently available only in the United States.

## Supported languages and locale codes

| Language Name |	Locale Code |
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
| Danish - Denmark	| da-DK  |
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

## Language limitations by feature

### Languages 

**What languages are supported in the voice channel at general availability (GA)?**

For our GA release of voice channel, language support is feature-specific. 

We use Azure Cognitive Service Speech’s Speech-to-Text for transcription, so we plan on supporting all of the languages that Speech-To-Text supports today. Power Virtual Agents is only available in a subset of languages, so for PVA-based IVR, we will be supporting the languages that PVA supports. We also support a bring-your-own-bot through Azure Bot Service for IVR that will be constrained by the languages that Speech-To-Text supports. For AI suggestions, we are adding more languages as of April 2021.  


**Are there any real-time limitations?**

We're planning to support additional languages for the GA release in 2021. See the list of supported languages below. 

 
| Feature |	List of supported languages |
| ---- | ---- |
| Transcription | [Language and speech support](https://docs.microsoft.com/azure/cognitive-services/speech-service/language-support) | 
| Power Virtual Agents (IVR) | [Power Virtual Agents supported languages](https://docs.microsoft.com/power-virtual-agents/authoring-language-support) |
| Bring your own bot (IVR) | [Language and voice support for the Speech service](https://docs.microsoft.com/azure/cognitive-services/speech-service/language-support)  |
| AI suggestions | [Language support for AI suggestions](csw-enable-ai-suggested-cases-knowledge-articles.md) |
| Sentiment Analysis | [Multi-language sentiment](https://docs.microsoft.com/dynamics365/customer-service/enable-sentiment-analysis#multi-language-sentiment) |
| Other Omnichannel features | [Language availability in Omnichannel for Customer Service](https://docs.microsoft.com/dynamics365/customer-service/international-availability#language-availability) | 


### See also

[Overview of the voice channel](voice-channel.md)
