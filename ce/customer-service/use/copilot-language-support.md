---
title: Understand Copilot language support
description: Understand how Copilot generates responses in different languages
author: gandhamm
ms.author: mgandham
ms.service: 
ms.topic: concept-article 
ms.date: 01/25/2024

---

# Understand Copilot language support

Copilot supports respond to questions, summarize cases and conversations features in [multiple languages](../administer/cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service).

The key features of copilot language support are as follows:

- Copilot detects your UI language and generates responses from cases and conversations in that language. 
- Copilot uses knowledge articles that are tagged with the same language as the UI language to generate responses.
- When the input contains mixed languages, Copilot generates responses based on the language that is set for your UI.
- Copilot tries to generate responses in your preferred UI language even if that isn't an officially supported language.

## Scenarios

| Scenarios | Copilot response | 
| --- | --- | 
|A case has notes in Spanish, and the UI language is set to Spanish. | Case summary is generated in Spanish. |
| For a case, the description is in French, email thread is in Spanish, and the language is set to Spanish. | Case summary is generated in Spanish. |
| The UI language is set to Spanish. The knowledge base articles are in Spanish. The agent asks a question in Spanish. | Results displayed are in Spanish. |
| The  UI language is set to Spanish, and the agent asks a question in French. | Results displayed are in Spanish. |
|  The UI language is set to Spanish. There knowledge base articles are only English. The agent asks a question in Spanish.| No response is generated. |
| The UI language is set to Japanese. The Bing Market language is set to Japanese and current location to ja-JP. The agents asks a question where Copilot uses content from public web pages. | Responses are  returned from the restricted Bing search if results available in the set market code of ja-JP. More information: [Market and language codes used by Bing Web Search API](/bing/search-apis/bing-web-search/reference/market-codes). |


### See also

[Use Copilot to solve customer issues](../use/use-copilot-features.md)
