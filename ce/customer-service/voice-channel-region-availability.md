---
title: "Regional Availability in the Voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ROBOTS: NOINDEX,NOFOLLOW
---

# Regional Availability and Supported Languages of the Voice Channel

## Supported Regions

OC Voice is currently only available in the United States

## Supported locations and locale codes

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
Languages 

What languages are supported in the voice channel at GA? 

For our GA release of voice channel, language support is feature-specific. 

We use Azure Cognitive Service Speech’s Speech-to-Text for transcription, so we plan on supporting all the languages that Speech-To-Text supports today. Power Virtual Agents is only available in a subset of languages, so for PVA-based IVR, we will be supporting the languages that PVA supports. We also support a Bring your own Bot through Azure Bot Service for IVR that will be constrained by the languages Speech-To-Text supports. For the AI Suggestions, we are adding more languages in April 2021.  


Are there any real-time limitations? 

We are planning to support additional languages for general availability release in 2021. See list of supported languages below. 

 

Feature 

List of supported languages 

Transcription 

https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support  

Power Virtual Agents (IVR) 

https://docs.microsoft.com/en-us/power-virtual-agents/authoring-language-support  

Bring your own bot (IVR) 

https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support  

AI Suggestions 

https://docs.microsoft.com/en-us/dynamics365-release-plan/2021wave1/service/dynamics365-customer-service/multi-language-support-ai-suggested-knowledge-articles-similar-cases  

Sentiment Analysis 

https://docs.microsoft.com/en-us/dynamics365/customer-service/enable-sentiment-analysis#multi-language-sentiment  

Other Omnichannel features 

https://docs.microsoft.com/en-us/dynamics365/customer-service/international-availability#language-availability   

 