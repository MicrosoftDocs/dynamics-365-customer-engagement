---
title: Sales Copilot data movement across geographies
description: Learn how data that's used in Sales Copilot moves across geographies where its features aren't available by default.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.collection:
ms.date: 09/21/2023
ms.custom: bap-template
search.app: salescopilot-docs
---

# Sales Copilot data movement across geographies


Sales Copilot AI features use the Microsoft Azure OpenAI Service, which is currently available only in the North America region. If your Dynamics 365 environment is in any other geography, your data will be moved outside of your geography to handle Sales Copilot requests.

 You'll see the opt-in terms when you enable Sales Copilot for regions other than North America. The opt-in terms mention about the transfer of relevant data outside of your default geography.

> [!NOTE]
> The opt-in terms aren't applicable to organizations in the North America geography and therefore won't be visible to customers in this region.

When you use any copilot feature in an organization that's outside the North America region, your data, including personal data, used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency.

To learn more about how Azure OpenAI protects your data, read [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).


### See also
 
[Enable and set up Sales Copilot](enable-setup-copilot.md)  
[Configure Sales Copilot](configure-sales-copilot.md)
