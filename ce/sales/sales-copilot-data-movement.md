---
title: Copilot data movement across geographies
description: Learn how data that's used in Copilot moves across geographies where its features aren't available by default.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.collection:
ms.date: 10/05/2023
ms.custom: bap-template
search.app: salescopilot-docs
---

# Copilot data movement across geographies

Copilot in Dynamics 365 Sales includes AI features that use the Microsoft Azure OpenAI Service. Azure OpenAI Service is currently available only in the North America region. If your Dynamics 365 environment is in any other geography, your data will be moved outside of your geography to handle copilot requests.

You'll see the opt-in terms when you enable the Copilot feature for regions other than North America. The opt-in terms mention about the transfer of relevant data outside of your default geography.

> [!NOTE]
> The opt-in terms aren't applicable to organizations in the North America geography and therefore won't be visible to customers in this region.

When you use any copilot feature in an organization that's outside the North America or Europe regions, your data, including personal data, used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency.

To learn more about how Azure OpenAI protects your data, read [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).


### See also
 
- [Enable and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md)  
- [Configure Copilot in Dynamics 365 Sales](configure-sales-copilot.md)  
