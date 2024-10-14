---
title: Supported languages and locale codes for voice channel
description: Know about the supported languages and locale codes for the voice channel in Omnichannel for Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 02/14/2024
ms.topic: conceptual
ms.collection:
ms.custom: bap-template
---
# Supported languages and locale codes for voice channel

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

This article provides information about the supported languages and locale codes for the voice channel.

## Supported languages and locale codes

Omnichannel for Customer Service uses the Azure Cognitive Services speech-to-text service for transcription. So, all languages supported by speech-to-text can be transcribed. More information: [Speech-to-text documentation](/azure/cognitive-services/speech-service/index-speech-to-text)

> [!NOTE]
> - End-to-end voice and IVR support is available only if a language is supported in the Voice Channel and Copilot Studio.
> - Sentiment and AI insights are optional for the voice functionality.
> - For improved performance, we recommend that you use [Customer Service workspace](migrate-to-csw.md). Learn more about Customer Service workspace in [Overview of Customer Service workspace](../../customer-service/implement/csw-overview.md).

See the information in the following table to know about the supported languages and locale codes.

| Language | Locale code | Voice channel | Copilot Studio | IVR | Speech-to-text | Text-to-speech | Sentiment | AI suggestions | UI language support |
|---|---|---|---|---|---|---|---|---|
| Afrikaans - South Africa | `af- ZA` |No|No|No|No|No|No|No|No|
| Amharic | `am- ET` |No|No|No|No|No|No|No|No|
| Arabic - Algeria| `ar-DZ` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Bahrain| `ar-BH` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Egypt| `ar-EG` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Iraq| `ar-IQ` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Israel| `ar-IL` |No|No|No|Yes|No|No|No|No|
| Arabic - Jordan| `ar-JO` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Kuwait| `ar-KW` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Lebanon| `ar-LB` |No|No|No|Yes|No|No|No|No|
| Arabic - Libya| `ar-LY` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Morocco| `ar-MA` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Oman | `ar-OM` |No|No|No|Yes|No|No|No|No|
| Arabic - Palestinian Authority| `ar-PS` |No|No|No|Yes|No|No|No|No|
| Arabic - Qatar| `ar-QA` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Saudi Arabia| `ar-SA` |Yes|No|No|Yes|Yes|Yes|Yes|Yes|
| Arabic - Syria| `ar- SY` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Tunisia| `ar-TN` |No|No|No|Yes|Yes|No|No|No|
| Arabic - United Arab Emirates| `ar-AE` |No|No|No|Yes|Yes|No|No|No|
| Arabic - Yemen| `ar-YE` |No|No|No|Yes|Yes|No|No|No|
| Armenian | `hy` |No|No|No|No|No|No|No|No|
| Assamese | `as` |No|No|No|No|No|No|No|No|
| Azerbaijani | `az` |No|No|No|No|No|No|No|No|
| Bangla - Bangladesh| `bn-BD` |No|No|No|No|No|No|No|No|
| Bashkir | `ba` |No|No|No|No|No|No|No|No|
| Basque| `eu-ES` |No|No|No|No|No|No|No|Yes|
| Bengali - India| `bn-IN` |No|No|No|No|No|No|No|No|
| Bosnian (Latin) | `bs` |No|No|No|No|No|No|No|No|
| Bulgarian | `bg-BGC UI` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Burmese - Myanmar| `my-MM` |No|No|No|No|No|No|No|No|
| Catalan | `ca` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Chinese - China - Mandarin| `zh-CN` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Chinese - Hong Kong SAR - Cantonese | `zh-HK` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Chinese - Taiwan - Traditional | `zh-TW` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Chinese - Literary | `lzh` |No|No|No|No|No|No|No|No|
| Croatian - Croatia | `hr-HR` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Czech - Czech Republic | `cs-CZ` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Danish - Denmark | `da-DK` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Dari | `prs` |No|No|No|No|No|No|No|No|
| Divehi | `dv` |No|No|No|No|No|No|No|No|
| Dutch - Belgium | `nl-BE` |Yes|No|No|Yes|Yes|No|No|No|
| Dutch - Netherlands | `nl-NL` |Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|
| English - Australia | `en-AU` |Yes|Yes|Yes|Yes|Yes|No|No|No|
| English - Canada | `en-CA` |No|No|No|Yes|Yes|No|No|No|
| English - Ghana | `en-GH` |No|No|No|Yes|Yes|No|No|No|
| English - Hong Kong SAR | `en-HK` |No|No|No|Yes|Yes|No|No|No|
| English - India | `en-IN` |No|No|No|Yes|Yes|No|No|No|
| English - Ireland | `en-IE` |No|No|No|Yes|Yes|No|No|No|
| English - Kenya | `en-KE` |No|No|No|Yes|Yes|No|No|No|
| English - Nigeria | `en-NG` |No|No|No|Yes|Yes|No|No|No|
| English - New Zealand | `en-NZ` |Yes|No|No|Yes|Yes|No|No|No|
| English - Philippines | `en-PH` |No|No|No|Yes|Yes|No|No|No|
| English - Singapore | `en-SG` |No|No|No|Yes|Yes|No|No|No|
| English - South Africa | `en-SA` |No|No|No|Yes|Yes|No|No|No|
| English - Tanzania | `en-TZ` |No|No|No|Yes|Yes|No|No|No|
| English - United Kingdom | `en-GB` |Yes|Yes|Yes|Yes|Yes|No|No|No|
| English - United States | `en-US` |Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|
| Estonian - Estonia | `et-EE` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Fijian | `fj` |No|No|No|No|No|No|No|No|
| Filipino | `fil-PH` |No|No|No|No|Yes|No|No|No|
| Finnish | `fi-FI` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| French - Canada | `fr-CA` |Yes|Yes|Yes|Yes|Yes|No|No|No|
| French - France | `fr-FR` |Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|
| French - Switzerland| `fr-CH` |No|No|No|Yes|Yes|No|No|No|
| Galician | `gl-ES` |No|No|No|No|No|No|No|Yes|
| Georgian | `ka` |No|No|No|No|No|No|No|No|
| German - Austria| `de-AT` |No|No|No|Yes|Yes|No|No|No|
| German - Germany | `de-DE` |Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|
| German - Switzerland | `de-CH` |No|No|No|Yes|Yes|No|No|No|
| Greek - Greece| `el-GR` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Gujarati - India | `gu-IN` |No|No|No|Yes|Yes|No|No|No|
| Haitian Creole | `ht` |No|No|No|No|No|No|No|No|
| Hebrew - Israel | `he-IL` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Hindi - India | `hi-IN` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Hmong Daw | `mww` |No|No|No|No|No|No|No|No|
| Hungarian - Hungary | `hu-HU` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Icelandic - Iceland| `is-IS` |No|No|No|No|No|No|No|No|
| Indonesian - Indonesia | `id-ID` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Inuinnaqtun | `ikt` |No|No|No|No|No|No|No|No|
| Inuktitut | `iu` |No|No|No|No|No|No|No|No|
| Inuktitut - Latin | `iu-Latn` |No|No|No|No|No|No|No|No|
| Irish - Ireland | `ga-IE` |No|No|No|Yes|Yes|No|No|No|
| Italian - Italy| `it -IT` |Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|
| Japanese - Japan | `ja-JP` |Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|
| Javanese - Indonesia | `jv-ID` |No|No|No|No|No|No|No|No| 
| Kannada - India | `kn-IN` |No|No|No|Yes|Yes|No|No|No|
| Kazakh - Kazakhstan | `kk-KZ` |No|No|No|No|No|No|No|Yes|
| Khmer - Cambodia | `km-KH` |No|No|No|No|No|No|No|No|
| Klingon | `tlh-` |No|No|No|No|No|No|No|No|
| Klingon (plqaD) | `tlh-Piqd` |No|No|No|No|No|No|No|No|
| Korean - Korea | `ko-KR` |Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|
| Kurdish (Central) | `ku` |No|No|No|No|No|No|No|No|
| Kurdish (Northern) | `kmr` |No|No|No|No|No|No|No|No|
| Kyrgyz | `ky` |No|No|No|No|No|No|No|No|
| Lao - Laos | `lo-LA` |No|No|No|No|No|No|No|No|
| Latvian - Latvia | `lv-LV` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Lithuanian - Lithuania | `lt-LT` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Macedonian - Republic of North Macedonia | `mk-MK` |No|No|No|No|No|No|No|No|
| Malagasy | `mg` |No|No|No|No|No|No|No|No|
| Malay - Malaysia | `ms-MY` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Malayalam - India | `ml-IN` |No|No|No|No|No|No|No|No|
| Maltese - Malta | `mt-MT` |No|No|No|Yes|Yes|No|No|No|
| Maori | `mi` |No|No|No|No|No|No|No|No|
| Marathi - India | `mr-IN` |No|No|No|Yes|Yes|No|No|No|
| Mongolian - Cyrillic | `mn-Cyrl` |No|No|No|No|No|No|No|No|
| Mongolian - Traditional | `mn-Mong` |No|No|No|No|No|No|No|No|
| Nepali | `ne` |No|No|No|No|No|No|No|No|
|Norwegian Bokmal - Norway| `nb-NO` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Odia | `or` |No|No|No|No|No|No|No|No|
| Pashto - Afghanistan | `ps-AF` |No|No|No|No|No|No|No|No|
| Persian - Iran | `fa-IR` |No|No|No|No|No|No|No|No|
| Polish - Poland | `pl-PL` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Portuguese - Brazil | `pt-BR` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Portuguese - Portugal | `pt-PT` |Yes|No|No|Yes|Yes|No|No|No|
| Punjabi | `pa` |No|No|No|No|No|No|No|No|
| Queretaro Otomi | `otq` |No|No|No|No|No|No|No|No|
| Romanian - Romania | `ro-RO` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Russian - Russia | `ru-RU` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Samoan | `sm` |No|No|No|No|No|No|No|No|
| Serbian (Cyrillic) - Serbia | `sr-Cyrl-CS` or sr-RS |No|No|No|No|No|Yes|No|Yes|
| Serbian (Latin) - Serbia | `sr-Latn-CS` |No|No|No|No|No|Yes|No|Yes|
| Sinhala - Sri Lanka | `si-LK` |No|No|No|No|No|No|No|No|
| Slovak - Slovakia | `sk-SK` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Slovenian - Slovenia| `sl-SL` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Somali - Somalia | `so-SO` |No|No|No|No|No|No|No|No|
| Spanish - Argentina | `es-AR` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Bolivia| `es-BO` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Chile | `es-CL` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Colombia | `es-CO` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Costa Rica| `es-CR` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Cuba| `es-CU` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Dominican Republic| `es-DO` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Ecuador| `es-EC` |No|No|No|Yes|Yes|No|No|No|
| Spanish - El Salvador| `es-SV` |No|No|No|Yes|Yes|No|No|No|
| Spanish Equatorial Guinea| `es-GQ` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Guatemala| `es-GT` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Honduras| `es-HN` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Mexico | `es-Mx` |Yes|No|No|Yes|Yes|No|No|No|
| Spanish - Nicaragua| `es-NI` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Panama| `es-PA` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Paraguay| `es-PY` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Peru| `es-PE` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Puerto Rico| `es-PR` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Spain | `es-ES` |Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|
| Spanish - Venezuela| `es-VE` |No|No|No|Yes|Yes|No|No|No|
| Spanish - Uruguay| `es-UY` |No|No|No|Yes|Yes|No|No|No|
| Spanish - US| `es-US` |Yes|Yes|Yes|Yes|Yes|No|No|No|
| Sudanese - Indonesia | `su-ID` |No|No|No|No|No|No|No|No|
| Swahili - Kenya| `sw-KE` |No|No|No|Yes|Yes|No|No|No|
| Swahili - Tanzania| `sw-TZ` |No|No|No|No|No|No|No|No|
| Swedish - Sweden | `sv-SE` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Tahitian | `ty` |No|No|No|No|No|No|No|No|
| Tamil - India | `ta-IN` |No|No|No|Yes|Yes|No|No|No|
| Tatar | `tt` |No|No|No|No|No|No|No|No|
| Telugu - India | `te-IN` |No|No|No|Yes|Yes|No|No|No|
| Thai - Thailand | `th-TH` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Tibetan | `bo` |No|No|No|No|No|No|No|No|
| Tigrinya | `ti` |No|No|No|No|No|No|No|No|
| Tongan | `to` |No|No|No|No|No|No|No|No|
| Turkish - Türkiye | `tr-TR` |Yes|Yes|Yes|Yes|Yes|Yes|No|Yes|
| Ukrainian - Ukraine | `uk-UA` |No|No|No|No|No|Yes|No|Yes|
| Upper Sorbian | `hsb` |No|No|No|No|No|No|No|No|
| Urdu - India | `ur-IN` |No|No|No|No|No|No|No|No|
| Uyghur | `ug` |No|No|No|No|No|No|No|No|
| Uzbek - Uzbekistan | `uz-UZ` |No|No|No|No|No|No|No|No|
| Vietnamese - Vietnam | `vi-VN` |Yes|No|No|Yes|Yes|Yes|No|Yes|
| Welsh - United Kingdom | `cy-GB` |No|No|No|No|No|No|No|No|
| Yucatec Maya | `yua` |No|No|No|No|No|No|No|No|
| Zulu - South Africa| `zu-ZA` |No|No|No|No|No|No|No|No|

Use the information in the following table to find out more about language support for voice-related features.

| Feature |	List of supported languages |
| ---- | ---- |
| Transcription | [Language and speech support](/azure/cognitive-services/speech-service/language-support)|
| Copilot Studio (IVR) | [Languages supported by Copilot Studio](/power-virtual-agents/authoring-language-support)|
| Bring your own bot (IVR) | [Language and voice support for the Speech service](/azure/cognitive-services/speech-service/language-support)|
| AI suggestions | [Language support for AI suggestions](csw-enable-ai-suggested-cases-knowledge-articles.md#language-support-for-ai-suggestions)|
| Sentiment Analysis | [Multilingual sentiment](enable-sentiment-analysis.md#multilingual-sentiment) |
| Other Omnichannel for Customer Service features | [Language availability in Omnichannel for Customer Service](../implement/international-availability.md#language-availability)|

## Next steps

[Provision voice channel](voice-channel-install.md)  

### Related information

[Overview of the voice channel](voice-channel.md)  
[FAQ about the voice channel in Omnichannel for Customer Service](voice-channel-faqs.md)  

