---
title: #Required; Keep the title body to 60-65 chars max including spaces and brand
description: #Required; Keep the description within 100- and 165-characters including spaces 
author: #Required; your GitHub user alias, with correct capitalization
ms.author: #Required; microsoft alias of author
ms.service: #Required; use the name-string related to slug in ms.product/ms.service
ms.topic: concept-article #Required; leave this attribute/value as-is.
ms.date: #Required; mm/dd/yyyy format.

---

# Understand Copilot language support

Copilot detects your UI language and generates responses from cases and conversations in that language. When the input contains mixed languages, Copilot generates responses based on the language that is set for your UI.  For Copilot to generate responses from knowledge articles, the knowledge article must be tagged with the same language as the UI language.

This article describes Copilot behaviour for different UI input language scenarios.

## Scenarios

| Scenarios | Expected outcome | 
| --- | --- | --- |
| **Summarization** | | |
|A case has notes in Spanish, and the user's UI language is set to Spanish. | The Copilot generates the summary in Spanish. |
| For a case, the description is in French, email thread is in Spanish, and the user's UI language is set to Spanish. |  The Copilot generates the case summary in Spanish. |
| **Knowledge Base** | | |
| The user's UI language is set to Spanish. The knowledge base articles are in Spanish. If the user asks a question in Spanish. | The knowledge base is filtered to articles authored in the user's UI language. Responses are returned in the user's UI language. |
| The user's UI language is set to Spanish, and the user asks a question in French. | Copilot generates the response based on the UI language, so the response is in Spanish. |
|  The user's UI language is set to Spanish. There are no knowledge base articles authored in Spanish, only English. The user asks a question in Spanish.| there will be no response returned. |
| **Bing** | | |
| The user's UI language is set to Japanese. The user asks a question where the source content is derived from the admin configured public web pages. The Bing Market is set based on the user's preferred language of Japanese and their current location of Japan to ja-JP | Content is returned from the restricted Bing search if it is available in the set market code. |

> [!NOTE]
> Copilot tries to generate responses in your preferred UI language even if that isn't an officially supported language.

## Next step
TODO: Add your next step link(s)
> [!div class="nextstepaction"]
> [Write concepts](article-concept.md)

<!-- OR -->

## Related content
TODO: Add your next step link(s)
- [Write concepts](article-concept.md)

<!--
Remove all the comments in this template before you sign-off or merge to the 
main branch.

-->
