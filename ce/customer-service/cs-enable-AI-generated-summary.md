---
title: "Configure AI-generated summary for customer service | MicrosoftDocs"
description: "Learn how AI-generated summary works"
ms.date: 04/07/2022
ms.topic: article
author: mgandham
ms.author: gandhamm
manager: shujoshi
---
# Configure AI-generated conversation summary  (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Agents can collaborate with other contacts directly through Microsoft Teams to quickly resolve customer issues. As an administrator, you can enable the Microsoft Teams collaboration feature to help them summarize the ongoing chat with the customer to the expert.

This feature uses the AI capability to automatically summarize the agents ongoing conversation in real-time, when the agent selects the **New linked chat**.

## How AI-generated summary works

The summary generation feature uses a natural language generation model, so that admins can enable the feature by setting the toggle without the need for extra model training.  the AI model generates summaries from full conversation transcripts with up to 7,000 characters. If a transcript contains more than 7,000 characters, the first 7,000 characters are considered from the beginning to generate the summary. The summary is generated only for active conversations, as follows:
- **Issue description** summarizes the key customer problems to solve in a conversation. At least 3 customer messages are required to generate the issue description. 
- **Resolution tried** generates a list that summarizes if any resolutions agents have tried with the customer. If a resolution can't be discovered by the AI model from the transcript, no resolution is displayed in the summary. 
 
## Regional availability and supported languages

The AI generated summary is supported in geographical locations that AI suggestions for similar cases supports. More information: [Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md)
 
The AI-generated summary is supported in the following geographical locations:
- United States
- Europe
- United Kingdom.

This feature is supported only in English.

## Prerequisites

Tenant permissions to enable the enhanced integration with Microsoft Teams feature.

## Enable the AI-generated summary

1. In Customer Service Hub, go to **Service Management**.
1. In the site map, select **Embedded chat using Teams** in **Collaboration**.
1. Under **Link chat to Dynamics 365 records**, select **Conversation**. The **Conversation** settings flyout menu appears on the right.
1. In **Provide context for new linked chats**, turn on the toggle for **AI generated introduction message**.

### See also

[AI-generated summary for ongoing conversations in Microsoft Teams](cs-ai-generated-summary.md)                                                  
[Overview of Customer Service workspace](csw-overview.md)  
