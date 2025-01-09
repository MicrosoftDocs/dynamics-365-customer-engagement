---
title: Configure Microsoft Teams collaboration
description: Learn how to configure collaboration with Microsoft Teams in Customer Service.
ms.date: 11/28/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: bap-ai-copilot
ms.custom: bap-template
---

# Configure AI suggestions for contacts in Microsoft Teams

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

Agents can collaborate with other contacts directly through Microsoft Teams to quickly resolve customer issues. As an administrator, you can enable the Microsoft Teams collaboration feature to help them find the right contacts.

This feature uses the AI capability to automatically suggest contacts in real-time, based on the currently open active case or support conversation when agents explore contacts in the embedded chat experience.

> [!NOTE]
> - Case is applicable to Customer Service only.
> - Through Teams, agents can connect and engage with customers also if Omnichannel for Customer Service is enabled.

## Prerequisites

- AI suggestions for similar cases must be enabled. More information: [Enable AI suggestions for similar cases](csw-enable-ai-suggested-cases-knowledge-articles.md)

- Tenant permissions to enable the enhanced integration with Microsoft Teams feature.

## How AI-suggested contacts works

The suggestions capability uses AI to recommend contacts who might be able to help agents resolve an issue described in an active case or a support based on similar cases those contacts have worked on. It uses similar case suggestions to find similar cases, and then identifies the most logical contacts based on a few factors related to the experience and proficiency of the contacts in resolving those similar cases, including the following:

- The number of similar cases that the suggested contacts have resolved. A higher number of similar cases that the suggested contacts have resolved might indicate that they have more experience in resolving the issue described in the cases or conversations.

- The similarity level of the similar cases to the active case. A higher similarity of the cases means that the similar cases the contacts have resolved are more related to the active case or conversation that agents are currently working on.

- How recently the suggested contacts have resolved the similar cases. More recent experience might indicate the contact has more current knowledge about resolving the issue described in the cases or conversations.

- The average time that the suggested contacts use to resolve similar cases. Less time spent in resolving similar cases compared to others might indicate that the contact is more familiar than others about how to resolve the issue type.

AI-suggested contacts works with a set of out-of-the-box AI models, so that admins can enable the feature by setting the toggle without the need for extra model training.

For more information about similar case suggestions that impact the AI-suggested contacts, see [How AI suggestions for similar cases and knowledge articles work](csw-enable-ai-suggested-cases-knowledge-articles.md#how-ai-suggestions-for-similar-cases-and-knowledge-articles-work).

## Region availability and supported languages

The AI suggestions are supported in geographical locations that AI suggestions for similar cases supports. Learn more about supported regions and languages in [Region availability and service limits for Customer Service](cs-region-availability-service-limits.md).

## Enable collaboration with Microsoft Teams

Perform the following steps:

1. In the site map of Contact Center admin center or Customer Service admin center, go to **Agent experience** > **Collaboration**.
    
1. In **Embedded chat using Teams**, select **Manage**.

1. On the **Microsoft Teams collaboration and chat**, set the toggle for **Turn on the linking of Dynamics 365 records to Microsoft Teams channels** to **Yes**.

1. To get suggested contacts for active cases or supported conversations, perform the following steps:
   
   1. In **Connect Teams chat to Dynamics 365 records**, select **Case** or **Conversation**. Based on your selection, the **Case settings** or **Conversation settings** pane appears on the right.

   1. In **Suggest contacts**, turn on the toggle for **AI-based suggested contacts**.

    It takes 24 hours for the data to be preprocessed for the first time use.

    :::image type="content" source="../media/enable-ai-suggested-contacts.png" alt-text="Enable the settings for AI-suggested contacts.":::

1. Optionally, set the toggle for **Turn on Enhanced Microsoft Teams Integration** to **Yes**. This setting lets agents pin records and views to a Teams channel directly from Dynamics 365 and also suggests agents who worked on similar cases.

1. Optionally, set the toggle for **Enable Confidential Labels** to **Yes** to create private Teams messages and add sensitivity or confidentiality labels in enhanced Microsoft Teams integration.


### Related information

[Collaborate with AI-suggested contacts in Microsoft Teams chat](../use/use-ai-suggested-contacts-teams.md)  
[Overview of Customer Service workspace](../implement/csw-overview.md)  

