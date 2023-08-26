---
title: Sales Copilot data movement across geographies (preview)
description: Learn how data that's used in Sales Copilot (preview) moves across geographies where its features aren't available by default.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.collection:
ms.date: 08/10/2023
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

Sales Copilot AI features use the Microsoft Azure OpenAI Service, which is currently available only in North America and Europe. If your Dynamics 365 environment is in any of these two regions, all requests are routed to your geography's endpoint. For all other geographies, your requests will be routed to the following endpoints, when you enable Sales Copilot:

- Requests from the United Kingdom (UK), Norway, Germany, France, and China are routed to the Europe endpoint.  
- Requests from all the other regions are routed to the North America endpoint. 

 You'll see the opt-in terms when you enable Sales Copilot for regions other than North America or Europe. The opt-in terms mention about the transfer of relevant data outside of your default geography.

> [!NOTE]
> The opt-in terms aren't applicable to organizations in the North America or Europe geography and therefore won't be visible to customers in these regions.

When you use any copilot feature in an organization that's outside the North America or Europe geography, your data, including personal data, used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency.

To learn more about how Azure OpenAI protects your data, read [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).


### See also
 
[Enable and set up Sales Copilot (preview)](enable-setup-copilot.md)  
[Configure Sales Copilot (preview)](configure-sales-copilot.md)
