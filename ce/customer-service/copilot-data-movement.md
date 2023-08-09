---
title: Copilot data movement across geographies (preview)
description: Learn how data that's used in copilot features in Dynamics 365 Customer Service moves across geographies where its features aren't available by default.
ms.date: 08/16/2023
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: conceptual
ms.custom: bap-template
---

# Copilot data movement across geographies (preview)

[This article is prerelease documentation and is subject to change.]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

The copilot AI features use the Microsoft Azure OpenAI Service, which is available only in the [United States and Switzerland](https://dynamics.microsoft.com/availability-reports/georeport). As a result, copilot AI features are provided only to customers who have selected the United States or Switzerland as their geography for data processing and storage. However, customers outside the United States and Switzerland can use these features by opting in to share relevant data with the Azure OpenAI Service in the Switzerland for European Union customers or United States for non-EU customers. Opting in may result in the transfer of data outside their default geography.

:::image type="content" source="media/copilot-data-boundaries-opt-in.png" alt-text="Screenshot of the Copilot opt-in to let data move outside geographical boundaries.":::

The opt-in terms don't apply to organizations in the United States and Switzerland geographies and therefore aren't visible to them.

> [!NOTE]
> The copilot AI opt-in is in limited preview. To turn it on, email a request to `d365_csaipreview@microsoft.com`.

When you use any copilot feature in an organization that's outside the United States or Switzerland geography, your data, including personal data, that's used in prompts or returned in responses might be transmitted outside the geographic locations that you've selected for your primary data residency.

:::image type="content" source="media/copilot-compliance-boundaries.png" alt-text="Visual view of data movement and compliance boundaries.":::

To learn more about how Azure OpenAI protects your data, read [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).

Examples of customer data, along with personal data that's shared with Azure OpenAI, include relevant customer and agent chat messages, emails, case attributes, knowledge articles, agent name, email address, and customer name. Personal information is used to provide replies to a specific user.

### See also

[Region availability of analytics and insights](cs-region-availability-service-limits.md#region-availability-of-analytics-and-insights)  
[Configure copilot capabilities](configure-copilot-features.md)  
