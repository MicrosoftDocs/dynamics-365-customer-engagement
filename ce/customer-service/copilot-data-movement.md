---
title: Copilot data movement across geographies (preview)
description: Learn how data that's used in copilot features in Dynamics 365 Customer Service moves across geographies where its features aren't available by default.
ms.date: 09/28/2023
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: conceptual
ms.custom: bap-template
---

# Copilot data movement across geographies (preview)

[This article is prerelease documentation and is subject to change.]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

Copilot AI features use Azure OpenAI Service and are provided by default to only those customers with environments that have United States as their geography for data processing and storage. While the Azure OpenAI Service is available in multiple geographies including Australia, Canada, United States, France, Japan and UK, Copilot does not follow the same regional rollout schedule.

Meanwhile, customers with environments outside the United States can use Copilot AI features by opting in to share relevant data with the Azure OpenAI Service in United States or Switzerland. 

The information in the following table outlines the Azure OpenAI service that's used by the Copilot services based on the geography of their Dynamics 365 environment when they opt-in to share data.

|Copilot availability|Dynamics 365 geography|Azure OpenAI geography|
|----------|-------------|-----------------|
| Yes | Asia Pacific | United States |
| Yes | Australia | United States |
| Yes | Canada | United States |
| No | China | N/A|
| Yes | Europe | Switzerland |
| Yes | France | Switzerland |
| Yes | Germany | Switzerland |
| No | Government Community Cloud (GCC) | N/A |
| Yes | India | United States |
| Yes | Japan | United States |
| No | Korea | N/A|
| No | Norway | N/A|
| No | Singapore | N/A |
| No | South Africa | N/A|
| Yes | South America | United States |
| Yes | Switzerland | Switzerland |
| Yes | United Arab Emirates | United States |
| Yes | United Kingdom | Switzerland |
| Yes | United States | United States |

The copilot AI opt-in is in limited preview. Do the following steps to opt-in to data movement across geographies:

1. Send an email to `d365_csaipreview@microsoft.com` with the Organization ID of the Dynamics 365 instance where you want to use Copilot. In two business days, the copilot setup experience will be visible in your Dynamics 365 instance.

   :::image type="content" source="media/copilot-data-boundaries-opt-in.png" alt-text="Screenshot of the Copilot opt-in to let data move outside geographical boundaries.":::

2. Opt-in and set up Copilot using [Enable copilot features in Customer Service](configure-copilot-features.md). The opt-in terms don't apply to organizations in the United States and therefore aren't visible to them.


When you use any copilot feature in an organization that's outside the United States or Switzerland geography, your data, including personal data, that's used in prompts or returned in responses might be transmitted outside the geographic locations that you've selected for your primary data residency.


:::image type="content" source="media/copilot-compliance-boundaries.png" alt-text="Visual view of data movement and compliance boundaries.":::

To learn more about how Azure OpenAI protects your data, read [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).

Examples of customer data, along with personal data that's shared with Azure OpenAI, include relevant customer and agent chat messages, emails, case attributes, knowledge articles, agent name, email address, and customer name. Personal information is used to provide replies to a specific user.

### See also

[Responsible AI FAQ for Dynamics 365 Customer Service](responsible-ai-overview.md)
[Region availability of analytics and insights](cs-region-availability-service-limits.md#region-availability-of-analytics-and-insights)  
[Configure copilot capabilities](configure-copilot-features.md)  
