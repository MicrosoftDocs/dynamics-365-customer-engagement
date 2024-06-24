---
title: Understand how Copilot supports different languages
description: Understand how Copilot generates responses in different languages.
author: gandhamm
ms.author: mgandham
ms.collection: bap-ai-copilot
ms.topic: conceptual
ms.reviewer: 
ms.date: 04/30/2024
ms.custom: bap-template 
---

# Understand how Copilot supports different languages

Copilot generates responses to agent's questions and supports case and conversation summary features in [multiple languages](../administer/cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service).

The key features are as follows:

- Copilot detects your UI language and generates responses from cases and conversations in the language present in the UI.
- Copilot uses those knowledge articles that are tagged with the language that's same as the UI language to generate responses.
- When the input text contains mixed languages, Copilot generates responses in your UI language.
- Copilot tries to generate responses in your preferred UI language even if that isn't an officially supported language.

## Scenarios

### Standalone app

The following scenarios can help you understand the language Copilot uses to generate responses in the standalone app.

| Scenarios | Copilot response | 
| --- | --- | 
|The UI language is set to Spanish and a case has notes in Spanish. | Copilot generates the case summary in Spanish. |
| The UI language is set to Spanish. The case description is in French. The email thread is in Spanish. | Copilot generates the case summary in Spanish. |
| The UI language is set to Spanish. The knowledge articles are in Spanish. The agent asks a question in Spanish. | Copilot displays the results in Spanish. |
| The  UI language is set to Spanish. The agent asks a question in French. | Copilot displays the results in Spanish. |
|  The UI language is set to Spanish. The knowledge articles are in the English language only. The agent asks a question in Spanish.| No response is generated. |
| The UI language is set to Japanese. The Bing Market language is set to Japanese and the location is set to ja-JP. The agents asks a question that Copilot responds to with content from the public web pages. | Copilot returns responses if the restricted Bing search results are available in the set [market code](/bing/search-apis/bing-web-search/reference/market-codes) of ja-JP. |

### Embed app

The following scenarios can help you understand the language Copilot uses to generate responses in the embedded app.


| Scenarios | Copilot response | 
| --- | --- | 
|The contact center embedded app's UI language is Spanish, the Salesforce UI language is Spanish. The knowledge articles are in Spanish. | Copilot generates responses in Spanish. |
| The contact center embedded app's UI language is Spanish, the Salesforce UI language is German. The knowledge articles are in Spanish. The Copilot prompt is in Spanish| Copilot generates responses in Spanish. |
|The contact center embedded app's UI language is Spanish, the Salesforce UI language is German. The knowledge articles are in German. The Copilot prompt is in Spanish. | Copilot doesn't display a response as the UI language and knowledge article language are different. |
| The contact center embedded app's UI language is Spanish, the Salesforce UI language is Spanish. The knowledge articles are in Spanish. The Copilot prompt is in Finnish. | Copilot displays the results in Spanish. |
| The contact center embedded app's UI language is Spanish, the Salesforce UI language is German. The knowledge articles are in Spanish. The Copilot prompt is in Finnish. |  Copilot displays the results in Spanish. |
| The contact center embedded app's UI language is Spanish, the Salesforce UI language is German. The knowledge articles are in German. The Copilot prompt is in Finnish. |  Copilot doesn't display a response as the UI language and knowledge article language are different. |


### See also

[Use Copilot to solve customer issues](../use/use-copilot-features.md)
