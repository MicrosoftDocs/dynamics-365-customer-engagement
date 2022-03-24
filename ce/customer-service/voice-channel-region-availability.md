---
title: "Regional availability of the voice channel | MicrosoftDocs"
description: "Learn about the region availability and supported languages for the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 02/22/2022
ms.topic: article

---

# Regional availability and supported languages for the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

This article provides information about the availability of the voice channel in different geographical regions, supported languages, locale codes, and language limitations by feature.

> [!NOTE]
> For information about availability of live chat and digital messaging channels, see [International availability of Omnichannel for Customer Service](international-availability.md#international-availability-of-omnichannel-for-customer-service).

## Supported regions

Use the information in the following table to know about the availability of the voice channel in Omnichannel for Customer Service.

> [!IMPORTANT]
> Your Microsoft 365 tenant must be co-located in one of the following geographic locations where Omnichannel for Customer Service is available. These geographic locations refer to your Microsoft 365 tenant only and not the data center where your Dynamics 365 environment or org instance resides.

|Geographic location | Availability | Availability in Customer Service trial|
|----------|---------|-----|
|North America (crm.dynamics.com) <sup> **1** </sup> |November 2021  | November 2021|
|Europe, Middle East, Africa (crm4.dynamics.com) <sup>**2**</sup> |December 2021 |To be announced|
|Asia Pacific (crm5.dynamics.com) <sup>**2**</sup> |December 2021 |To be announced|
|Australia, New Zealand, Fiji (crm6.dynamics.com) <sup>**2**</sup> |December 2021 |To be announced|
|South America (crm2.dynamics.com) |To be announced | To be announced|
|Country/Region clouds: Canada, France, Germany, India, Japan, Switzerland, United Arab Emirates (UAE), United Kingdom |To be announced |To be announced|
|Government Community Cloud (GCC) (crm9.dynamics.com) |To be announced |To be announced|
||||

> [!NOTE]
>
> - <sup>**1**</sup> Supports [Microsoft as a carrier](/azure/communication-services/concepts/telephony/telephony-concept) for purchasing new US numbers and also [porting your existing US or toll-free phone numbers](/azure/communication-services/quickstarts/telephony/port-phone-number). Customers with billing locations in United States, United Kingdom, Ireland, and Puerto Rico are the only ones who can purchase numbers through Microsoft as a carrier. Even though Microsoft as a carrier is available in other regions, only the listed billing locations will be supported. Other customers can select a [different carrier](voice-channel-bring-your-own-number.md) by using Azure direct routing.
> - <sup>**2**</sup>  Microsoft as a carrier is available only in specific billing postal codes, however bring your own carrier via Azure direct routing is supported everywhere using certified Session Border Controllers (SBCs). More information: [Bring your own carrier](voice-channel-bring-your-own-number.md). Though Azure direct routing is in public preview everywhere, it will provide generally available level of support for Dynamics 365 customers where the voice channel is generally available in the region. Country/Region-specific cloud deployments for the voice channel in Omnichannel for Customer Service are excluded, you must use the general region deployment. For example, in the preceding table, country/region cloud for local deployment in United Kingdom is **"To be announced"** and is not part of the Europe geographical region availability. If you want your data to stay within the country/region, you'll need to wait for country/region-specific local deployment of the voice channel. More information: [Datacenter regions](/power-platform/admin/new-datacenter-regions)


## Supported languages and locale codes

See the information in the following table to know about the supported languages and locale codes.

We use the Azure Cognitive Services Speech service Speech-to-Text for transcription, so we'll support all the languages that Speech-to-Text supports today. We also support a bring-your-own bot through Azure Bot Service for Interactive Voice Response (IVR) that will be constrained by the languages that Speech-to-Text supports. For end to end voice support, including IVR, a language must be supported by the Power Virtual Agents or  Azure bot service and Omnichannel Voice. Sentiment and AI insights are optional for the base voice functionality.  

| Language | Language code | Voice channel in Omnichannel for Customer Service | Power Virtual Agents | Speech-to-Text | Text-to-Speech | Sentiment | AI recommendations | UI Language availability|
|:-|:-:|:-:|:-:|:-:|:-:|:-:| :-:| :-:|
| Afrikaans - South Africa | `af- ZA` ||||||||
| Albanian | `sq` ||||||||
| Amharic | `am- ET` |||||||
| Arabic - Algeria| `ar-DZ` |||✔|✔||||
| Arabic - Bahrain| `ar-BH` |||✔|✔||||
| Arabic - Egypt| `ar-EG` |||✔|✔||||
| Arabic - Iraq| `ar-IQ` |||✔|✔||||
| Arabic - Israel| `ar-IL` |||✔|||||
| Arabic - Jordan| `ar-JO` |||✔|✔||||
| Arabic - Kuwait| `ar-KW` |||✔|✔||||
| Arabic - Lebanon| `ar-LB` |||✔|||||
| Arabic - Libya| `ar-LY` |||✔|✔||||
| Arabic - Morocco| `ar-MA` |||✔|✔||||
| Arabic - Oman | `ar-OM` |||✔|||||
| Arabic - Palestenian Authority| `ar-PS` |||✔|||||
| Arabic - Qatar| `ar-QA` |||✔|✔||||
| Arabic - Saudi Arabia| `ar-SA` |✔||✔|✔||✔|✔|
| Arabic - Syria| `ar- SY` |||✔|✔||||
| Arabic - Tunisia| `ar-TN` |||✔|✔||||
| Arabic - United Arab Emirates| `ar-AE` |||✔|✔||||
| Arabic - Yemen| `ar-YE` |||✔|✔||||
| Armenian | `hy` ||||||||
| Assamese | `as` ||||||||
| Azerbaijani | `az` ||||||||
| Bangla - Bangladesh| `bn-BD` ||||||||
| Bashkir | `ba` ||||||||
| Basque| `eu-ES` |||||||✔|
| Bengali - India| `bn-IN` ||||||||
| Bosnian (Latin) | `bs` ||||||||
| Bulgarian | `bg-BGC UI` |✔||✔|✔|✔||✔|
| Burmese - Myanmar| `my-MM` ||||||||
| Catalan | `ca` |✔||✔|✔|✔||✔|
| Chinese - China - Mandarin| `zh-CN` |✔|✔|✔|✔|✔||✔|
| Chinese - Hong Kong SAR - Cantonese - Taiwan - Traditional| `zh-CN` |✔|✔|✔|✔|✔||✔|
| Chinese - Literary | `lzh` ||||||||
| Croatian - Croatia | `hr-HR` |✔||✔|✔|✔||✔||
| Czech - Czech Republic | `cs-CZ` |✔||✔|✔|✔||✔|
| Danish - Denmark | `da-DK` |✔|✔|✔|✔|✔||✔|
| Dari | `prs` ||||||||
| Divehi | `dv` ||||||||
| Dutch - Belgium | `nl-BE` |||✔|✔||||
| Dutch - Netherlands | `nl-NL` |✔|✔|✔|✔|✔|✔|✔|
| English - Australia | `en-AU` |||✔|✔||||
| English - Canada | `en-CA` |||✔|✔||||
| English - Ghana | `en-GH` |||✔|✔||||
| English - Hong Kong | `en-HK` |||✔|✔||||
| English - India | `en-IN` |||✔|✔||||
| English - Ireland | `en-IE` |||✔|✔||||
| English - Kenya | `en-KE` |||✔|✔||||
| English - Nigeria | `en-NG` |||✔|✔||||
| English - New Zealand | `en-NZ` |||✔|✔||||
| English - Philippines | `en-PH` |||✔|✔||||
| English - Singapore | `en-SG` |||✔|✔||||
| English - South Africa | `en-SA` |||✔|✔||||
| English - Tanzania | `en-TZ` |||✔|✔||||
| English - United Kingdom | `en-GB` |||✔|✔||||
| English - United States | `en-US` |✔|✔|✔|✔|✔|✔|✔|
| Estonian - Estonia | `et-EE` |✔||✔|✔|✔||✔|
| Fijian | `fj` ||||||||
| Filipino | `fil-PH` ||||✔||||
| Finnish | `fi-FI` |✔||✔|✔|✔||✔|
| French -Canada | `fr-CA` |||✔|✔||||
| French - France | `fr-FR` |✔|✔|✔|✔|✔|✔|✔|
| French - Switzerland| `fr-CH` |||✔|✔||||
| Galician | `gl-ES` |||||||✔|
| Georgian | `ka` ||||||||
| German - Austria| `de-CH` |||✔|✔||||
| German - Germany | `de-DE` |✔|✔|✔|✔|✔|✔|✔|
| German - Switzerland | `de-AT` |||✔|✔||||
| Greek - Greece| `el-GR` |✔||✔|✔|✔||✔|
| Gujarati - India | `gu-IN` |||✔|✔||||
| Haitian Creole | `ht` ||||||||
| Hebrew - Israel | `he-IL` |✔||✔|✔|✔||✔|
| Hindi - India | `hi-IN` |✔|✔|✔|✔|✔||✔|
| Hmong Daw | `mww` ||||||||
| Hungarian - Hungary | `hu-HU` |✔||✔|✔|✔||✔|
| Icelandic - Iceland| `is-IS` ||||||||
| Indonesian - Indonesia | `id-ID` |✔|✔|✔|✔|✔||✔|
| Inuinnaqtun | `ikt` ||||||||
| Inuktitut | `iu` ||||||||
| Inuktitut - Latin | `iu-Latn` |||||||| 
| Irish - Ireland | `ga-IE` |||✔|✔||||
| Italian - Italy| `it -IT` |✔|✔|✔|✔|✔|✔|✔|
| Japanese - Japan | `ja-JP` |✔|✔|✔|✔|✔|✔|✔|
| Javanese - Indonesia | `jv-ID` |||||||| 
| Kannada - India | `kn-IN` |||✔|✔||||
| Kazakh - Kazakhstan | `kk-KZ` |||||||✔|
| Khmer - Cambodia | `km-KH` ||||||||
| Klingon | `tlh-` ||||||||
| Klingon (plqaD) | `tlh-Piqd` ||||||||
| Korean - Korea | `ko-KR` |✔|✔|✔|✔|✔||✔|
| Kurdish (Central) | `ku` ||||||||
| Kurdish (Northern) | `kmr` ||||||||
| Kyrgyz | `ky` ||||||||
| Lao - Laos | `lo-LA` ||||||||
| Latvian - Latvia | `lv-LV` |✔||✔|✔|✔||✔|
| Lithuanian - Lithuania | `lt-LT` |✔||✔|✔|✔||✔|
| Macedonian - Republic of North Macedonia | `mk-MK` ||||||||
| Malagasy | `mg` ||||||||
| Malay - Malaysia | `ms-MY` |✔||✔|✔|✔||✔|
| Malayalam - India | `ml-IN` ||||||||
| Maltese - Malta | `mt-MT` |||✔|✔||||
| Maori | `mi` ||||||||
| Marathi - India | `mr-IN` |||✔|✔||||
| Mongolian - Cyrillic | `mn-Cyrl` ||||||||
| Mongolian - Traditional | `mn-Mong` ||||||||
| Nepali | `ne` ||||||||
|Norwegian Bokmal - Norway| `nb-NO` |✔|✔|✔|✔|✔||✔|
| Odia | `or` ||||||||
| Pashto - Afghanistan | `ps-AF` ||||||||
| Persian - Iran | `fa-IR` ||||||||
| Polish - Poland | `pl-PL` |✔|✔|✔|✔|✔||✔|
| Portuguese - Brazil | `pt-BR` |✔|✔|✔|✔|✔||✔|
| Portuguese - Portugal | `pt-PT` |✔||✔|✔||||
| Punjabi | `pa` ||||||||
| Queretaro Otomi | `otq` ||||||||
| Romanian - Romania | `ro-RO` |✔||✔|✔|✔||✔|
| Russian - Russia | `ru-RU` |✔|✔|✔|✔|✔||✔|
| Samoan | `sm` ||||||||
| Serbian (Cyrillic) - Serbia | `sr-Cyrl-CS` or sr-RS |||||✔||✔|
| Serbian (Latin) - Serbia | `sr-Latn-CS` |||||✔||✔|
| Sinhala - Sri Lanka | `si-LK` ||||||||
| Slovak - Slovakia | `sk-SK` |✔||✔|✔|✔||✔|
| Slovenian - Slovenia| `sl-SL` |✔||✔|✔|✔||✔|
| Somali - Somalia | `so-SO` ||||||||
| Spanish - Argentina | `es-AR` |||✔|✔||||
| Spanish - Bolivia| `es-BO` |||✔|✔||||
| Spanish - Chile | `es-CL` |||✔|✔||||
| Spanish - Colombia | `es-CO` |||✔|✔||||
| Spanish - Costa Rica| `es-CR` |||✔|✔||||
| Spanish - Cuba| `es-CU` |||✔|✔||||
| Spanish - Dominican Republic| `es-DO` |||✔|✔||||
| Spanish - Ecuador| `es-EC` |||✔|✔||||
| Spanish - El Salvador| `es-SV` |||✔|✔||||
| Spanish Equatorial Guinea| `es-GQ` |||✔|✔||||
| Spanish - Guatemala| `es-GT` |||✔|✔||||
| Spanish - Honduras| `es-HN` |||✔|✔||||
| Spanish - Mexico | `es-MX` |||✔|✔||||
| Spanish - Nicaragua| `es-NI` |||✔|✔||||
| Spanish - Panama| `es-PA` |||✔|✔||||
| Spanish - Paraguay| `es-PY` |||✔|✔||||
| Spanish - Peru| `es-PE` |||✔|✔||||
| Spanish - Puerto Rico| `es-PR` |||✔|✔||||
| Spanish - Spain | `es-ES` |✔|✔|✔|✔|✔|✔|✔|
| Spanish - Venezuela| `es-VE` |||✔|✔||||
| Spanish - Uruguay| `es-UY` |||✔|✔||||
| Spanish - US| `es-US` |||✔|✔||||
| Sudanese - Indonesia | `su-ID` ||||||||
| Swahili - Kenya| `sw-KE` |||✔|✔||||
| Swedish - Sweden | `sv-SE` |✔|✔|✔|✔|✔||✔|
| Swahili - Tanzania| `sw-TZ` ||||||||
| Tahitian | `ty` ||||||||
| Tamil - India | `ta-IN` |||✔|✔||||
| Tatar | `tt` ||||||||
| Telugu - India | `te-IN` |||✔|✔||||
| Thai - Thailand | `th-TH` |✔||✔|✔|✔||✔|
| Tibetan | `bo` ||||||||
| Tigrinya | `ti` ||||||||
| Tongan | `to` ||||||||
| Turkish - Turkey | `tr-TR` |✔|✔|✔|✔|✔||✔|
| Ukrainian - Ukraine | `uk-UA` |||||✔||✔|
| Upper Sorbian | `hsb` ||||||||
| Urdu - India | `ur-IN` |||||||||
| Uyghur | `ug` ||||||||
| Uzbek - Uzbekistan | `uz-UZ` ||||||||
| Vietnamese - Vietnam | `vi-VN` |✔||✔|✔|✔||✔|
| Welsh - United Kingdom | `cy-GB` ||||||||
| Yucatec Maya | `yua` ||||||||
| Zulu - South Africa| `zu-ZA` ||||||||
|||

Use the information in table to find more about language support for voice related features.
 
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

