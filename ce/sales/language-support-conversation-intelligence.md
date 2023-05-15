---
title: Languages supported for conversation intelligence 
description: This article lists the native and non-native language support for conversation intelligence.
author: lavanyakr01 
ms.author: lavanyakr 
ms.reviewer: shujoshi 
ms.service: dynamics-365-sales
ms.topic: conceptual 
ms.date: 05/15/2023
ms.custom: bap-template 
---

# Languages supported for conversation intelligence

Conversation intelligence generates various insights from call transcripts, including action items, brands, keywords, sentiments, and questions. These insights are available in multiple languages, either natively or through translation. When a language has native support, the transcript is analyzed and insights are generated in that language. For languages with non-native support, the transcript is first translated to English and then insights are generated in English.


In the following table, **Y** indicates native support and **N** indicates non-native support.

| **Language** | **Transcription** | **Tracked keywords and competitors** | **General Keywords mentions** | **People, prices, and times mentions** | **Brands mentions** | **Automated note suggestions and action items** | **Voicemail, reschedule requests, unwanted calls detection** | **Segmentation topics** | **Sentiment analysis** | **Sellers and customers' Question detection** |
|------------------------|--------------------|--------------------------------------|--------------------------------|----------------------------------------|----------------------|-------------------------------------------------|--------------------------------------------------------------|---------------------|------------------------|------------------------------------------------|
| English       | Y         | Y         | Y   | Y  | Y  | Y  | Y      | Y | Y    | Y |
| English (UK)      | Y         | Y         | Y   | Y  | Y  | Y  | Y      | Y | Y    | Y |
| French        | Y         | Y         | Y   | Y  |  N  |  N  |    N    |  N | Y    |  N |
| French (Canadian)       | Y         | Y         | Y   | Y  |  N  |  N  |    N    |  N | Y    |  N |
| German        | Y         | Y         | Y   | Y  |  N  |  N  |    N    |  N |   N   |  N |
| Spanish       | Y         | Y         | Y   | Y  |  N  |  N  |    N    |  N |   N   |  N |
| Spanish (Mexico)      | Y         | Y         | Y   | Y  |  N  |  N  |    N    |  N |   N   |  N |
| Chinese       | Y         | Y         | Y   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Dutch         | Y         | Y         | Y   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Italian       | Y         | Y         | Y   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Japanese      | Y         | Y         | Y   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Portuguese    | Y         | Y         | Y   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Portuguese (Brazil)    | Y         | N      |  N   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Hebrew        | Y         | Y         | Y   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Danish        | Y         | Y         |  N   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Swedish       | Y         | Y         |  N   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Finnish       | Y         | Y         |  N   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Norwegian     | Y         | Y         |  N   |  N  |  N  |  N  |    N    |  N |   N   |  N |
| Arabic        | Y         | N         | Y   |  N  |  N  |  N  |    N    |  N |   N   |  N |


All of the above insights are available in the **Call summary** page. For more information, see [View and understand call summary page in the Sales Hub app](view-and-understand-call-summary-sales-app.md).
