---
title: Copilot data movement across geographies
description: Learn to understand how data used in copilot features in Dynamics 365 Customer Service moves across geographies where it's features aren't available by default.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: concept 
ms.collection:
ms.date: 06/05/2023
ms.custom: bap-template
---

# Copilot data movement across geographies (preview)

> [!IMPORTANT]
>
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

The copilot AI features use the Microsoft Azure OpenAI Service, which is currently available only within the [United States geography](https://dynamics.microsoft.com/availability-reports/georeport). As a result, the copilot AI features are provided to only those customers who have selected the United States as their chosen geography for data processing and storage. However, customers outside of the United States can still make use of these features by opting in to share relevant data with the Azure OpenAI service in the United States. This opt-in may result in the transfer of relevant data outside of their default geography.

:::image type="content" source="media/copilot-data-boundaries-opt-in.png" alt-text="Copilot opt-in to let data movement outside geographical boundaries.":::

> [!NOTE]
> The opt-in terms aren't applicable to organizations in the United States geography and therefore won't be visible to them.
> The opt-in is in limited preview. To turn on this feature, send a request to [d365_csaipreview](d365_csaipreview@microsoft.com).

When you use any copilot feature in an organization that's outside the United States geography, your data, including personal data, used in prompts or returned in completions might be transmitted outside of the geographic locations that you have selected for your primary data residency.

:::image type="content" source="media/copilot-compliance-boundaries.png" alt-text="Visual view of data movement and compliance boundaries.":::

To learn more about how Azure OpenAI protects your data, read [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).

Examples of customer data, along with personal data that is shared with Azure OpenAI, include relevant customer and agent chat messages, emails, case attributes, knowledge articles, agent name, email address, and customer name. Personal information is used to provide replies to a specific user.

### See also

[Region availability of analytics and insights](cs-region-availability-service-limits.md#region-availability-of-analytics-and-insights)  
[Configure Copilot capabilities](configure-copilot-features.md)  