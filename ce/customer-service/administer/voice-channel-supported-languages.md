---
title: Supported languages and locale codes for voice channel
description: Know about the supported languages and locale codes for the voice channel in Dynamics 365 Contact Center.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 09/02/2026
ms.topic: concept-article
ms.collection:
ms.custom: bap-template
---
# Supported languages and locale codes for voice channel

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

This article provides information about the supported languages and locale codes for the voice channel.

## Supported languages and locale codes

The voice channel uses the Azure Cognitive Services speech-to-text service for transcription for only those languages that it supports in the channel. Learn more in [Speech-to-text documentation](/azure/cognitive-services/speech-service/index-speech-to-text).

> [!NOTE]
> Sentiment and AI insights are optional for the voice functionality.

The supported languages and locale codes are as follows.

| Language | Locale code | Voice channel | IVR | Sentiment | UI language support |
| --- | --- | --- | --- | --- | --- |
| Arabic - Saudi Arabia | `ar-SA` | Yes | Yes | Yes | Yes |
| Bulgarian | `bg-BGC UI` | Yes | No | Yes | Yes |
| `Basque` - Spain | `eu-ES` | Yes | No | Yes | Yes |
| `Catalan` - Spain| `ca` | Yes | No | Yes | Yes |
| Chinese - China - Mandarin | `zh-CN` | Yes | Yes | Yes | Yes |
| Chinese - Hong Kong SAR - Cantonese | `zh-HK` | Yes | No | Yes | Yes |
| Chinese - Taiwan - Traditional | `zh-TW` | Yes | No | Yes | Yes |
| Croatian - Croatia | `hr-HR` | Yes | Yes | Yes | Yes |
| Czech - Czech Republic | `cs-CZ` | Yes | Yes | Yes | Yes |
| Danish - Denmark | `da-DK` | Yes | Yes | Yes | Yes |
| Dutch - Belgium | `nl-BE` | Yes | No | No | No |
| Dutch - Netherlands | `nl-NL` | Yes | Yes | Yes | Yes |
| English - Australia | `en-AU` | Yes | Yes | No | No |
| English - India | `en-IN` | Yes | No | No | No |
| English - New Zealand | `en-NZ` | Yes | Yes | No | No |
| English - United Kingdom | `en-GB` | Yes | Yes | No | No |
| English - United States | `en-US` | Yes | Yes | Yes | Yes |
| Estonian - Estonia | `et-EE` | Yes | No | Yes | Yes |
| Finnish - Finland | `fi-FI` | Yes | Yes | Yes | Yes |
| French - Canada | `fr-CA` | Yes | Yes | No | No |
| French - France | `fr-FR` | Yes | Yes | Yes | Yes |
| French - Switzerland | `fr-CH` | Yes | No | No | No |
| German - Austria | `de-AT` | Yes | No | No | No |
| German - Germany | `de-DE` | Yes | Yes | Yes | Yes |
| German - Switzerland | `de-CH` | Yes | No | No | No |
| Greek - Greece | `el-GR` | Yes | Yes | Yes | Yes |
| Hebrew - Israel | `he-IL` | Yes | Yes | Yes | Yes |
| Hindi - India | `hi-IN` | Yes | Yes | Yes | Yes |
| Hungarian - Hungary | `hu-HU` | Yes | Yes | Yes | Yes |
| Indonesian - Indonesia | `id-ID` | Yes | Yes | Yes | Yes |
| Italian - Italy | `it -IT` | Yes | Yes | Yes | Yes |
| Japanese - Japan | `ja-JP` | Yes | Yes | Yes | Yes |
| Korean - Korea | `ko-KR` | Yes | Yes | Yes | Yes |
| Latvian - Latvia | `lv-LV` | Yes | No | Yes | Yes |
| Lithuanian - Lithuania | `lt-LT` | Yes | No | Yes | Yes |
| Malay - Malaysia | `ms-MY` | Yes | No | Yes | Yes |
| Norwegian Bokmal - Norway | `nb-NO` | Yes | Yes | Yes | Yes |
| Polish - Poland | `pl-PL` | Yes | Yes | Yes | Yes |
| Portuguese - Brazil | `pt-BR` | Yes | Yes | Yes | Yes |
| Portuguese - Portugal | `pt-PT` | Yes | Yes | No | No |
| Romanian - Romania | `ro-RO` | Yes | Yes | Yes | Yes |
| Russian - Russia | `ru-RU` | Yes | Yes | Yes | Yes |
| Slovak - Slovakia | `sk-SK` | Yes | No | Yes | Yes |
| Slovenian - Slovenia | `sl-SL` | Yes | No | Yes | Yes |
| Spanish - Mexico | `es-Mx` | Yes | No | No | No |
| Spanish - Spain | `es-ES` | Yes | Yes | Yes | Yes |
| Spanish - US | `es-US` | Yes | Yes | No | No |
| Swedish - Sweden | `sv-SE` | Yes | Yes | Yes | Yes |
| Thai - Thailand | `th-TH` | Yes | Yes | Yes | Yes |
| Turkish - Türkiye | `tr-TR` | Yes | Yes | Yes | Yes |
| Ukrainian - Ukraine | `uk-UA` | Yes | Yes | Yes | Yes |
| Urdu - India | `ur-IN` | Yes | No | No | No |
| Vietnamese - Vietnam | `vi-VN` | Yes | Yes | Yes | Yes |

Use the information in the following table to find out more about language support for voice-related features.

| Feature |	List of supported languages |
| ---- | ---- |
| Transcription | [Language and speech support](/azure/cognitive-services/speech-service/language-support)|
| Copilot Studio (IVR) | [Languages supported by Copilot Studio](/power-virtual-agents/authoring-language-support)|
| Bring your own bot (IVR) | [Language and voice support for the Speech service](/azure/cognitive-services/speech-service/language-support)|
| AI suggestions | [Language support for AI suggestions](csw-enable-ai-suggested-cases-knowledge-articles.md#language-support-for-ai-suggestions)|
| Sentiment Analysis | [Multilingual sentiment](enable-sentiment-analysis.md#multilingual-sentiment) |
| Other Dynamics 365 Contact Center features | [Language availability in Dynamics 365 Contact Center](/dynamics365/contact-center/implement/international-availability#language-availability)|

## Next steps

[Provision voice channel](voice-channel-install.md)  

## Related information

[Overview of the voice channel](voice-channel.md)  
[FAQ about the voice channel in Dynamics 365 Contact Center](voice-channel-faqs.md)  