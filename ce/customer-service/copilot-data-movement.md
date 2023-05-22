---
title: Copilot data movement across geographies
description: Learn to understand how data used in Copilot features in Dynamics 365 Customer Service moves across geographies where it's features aren't available by default.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: concept 
ms.collection:
ms.date: 06/02/2023
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
The Copilot features are available by default to customers in the [North America region](/power-platform/admin/new-datacenter-regions) only because the features use the Microsoft Azure OpenAI Service that's located in the United States. Customers who have their Dynamics 365 environment outside the North America region can enable access to the Copilot features after they explicitly opt-in to the “Terms of use for data movement across geographical boundaries” that permits their data to be shared with the Microsoft Azure Open AI service located in the United States.

:::image type="content" source="media/copilot-data-boundaries-opt-in.png" alt-text="Copilot opt-in to let data movement outside geographical boundaries.":::

> [!NOTE]
> The opt-in terms aren't applicable to organizations in the North America region and therefore won't be visible to them.
When any Copilot feature is used, the customer content and end user identifiable information that's part of the prompts and completions will be in transit across the tenant’s geographic or compliance boundaries as shown in the following diagram.

:::image type="content" source="media/copilot-compliance-boundaries.png" alt-text="Visual view of data movement and compliance boundaries.":::

Azure OpenAI service also stores the prompts and completions for up to thirty days to prevent abuse and harmful content generation. The data is not used to train, retrain, or improve the classification models. More information: [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation)

The data types that are shared with Azure OpenAI for each Copilot feature are as follows.

|Capability|Data attributes|
|-----|-----|
|Chat replies|Relevant customer and agent chat messages, knowledge articles, Bing results|
|Email replies|Relevant email and case attributes, knowledge articles, Bing results |
|Ask a Question, conversational chat|Relevant agent messages to Copilot, knowledge articles|
|Case and conversation  Summaries|Relevant case attributes, conversation content, emails, and notes|

### See also

[Region availability of analytics and insights](cs-region-availability-service-limits.md#region-availability-of-analytics-and-insights)  
[Configure Copilot capabilities](configure-copilot-features.md)  