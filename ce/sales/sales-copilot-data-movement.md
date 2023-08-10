---
title: Sales Copilot data movement across geographies (preview)
description: Learn how data that's used in Sales Copilot (preview) moves across geographies where its features aren't available by default.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.collection:
ms.date: 07/18/2023
ms.custom: bap-template
---

# Sales Copilot data movement across geographies (preview)

> [!IMPORTANT]
>
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Sales Copilot AI features use the Microsoft Azure OpenAI Service, which is currently available only within the United States and Europe geography. As a result, the Sales Copilot features are provided to only those customers who have selected the United States or Europe as their chosen geography for data processing and storage. However, customers outside of the United States or Europe can still use these features by opting in to share relevant data with the Azure OpenAI Service in the United States or Europe, whichever is closer to their  geography . This opt-in may result in the transfer of relevant data outside of their default geography.

> [!NOTE]
> The opt-in terms aren't applicable to organizations in the United States or Europe geography and therefore won't be visible to them.

When you use any copilot feature in an organization that's outside the United States or Europe geography, your data, including personal data, used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency.

To learn more about how Azure OpenAI protects your data, read [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).


### See also
 
[Enable and set up Sales Copilot (preview)](enable-setup-copilot.md)  
[Configure Sales Copilot (preview)](configure-sales-copilot.md)
