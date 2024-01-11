---
title: How to manage conversation intelligence data in Dataverse
description: Learn about the data structure, storage, access, and deletion of conversation intelligence insights in Dataverse.
author: lavanyakr
ms.author: lavanyakr01
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.collection: 
ms.date: 01/11/2024
ms.custom: 
  - bap-template
  - ai-seo-date: 01/11/2024
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-gen-desc
content_well_notification: AI-contribution
---

# How to manage conversation intelligence data in Dataverse

This article describes how your call data flows to Microsoft Dataverse to generate insights and how this data is structured. It also describes how to manage the storage, access, and deletion of conversation intelligence insights in Dataverse.

## How data flows

The following diagram depicts the flow of events starting from the time a call comes in to the time the data is saved, processed, analyzed, and displayed in the call summary page.

:::image type="content" source="media/conversation-intelligence-data-flow.svg" alt-text="Diagram depicting the flow of events starting from the time a call comes in to the time the data is saved, processed, analyzed, and displayed in the call summary page." lightbox="media/conversation-intelligence-data-flow.svg":::

As depicted in the diagram, the flow works as follows:

1. A call comes in to the Teams dialer in Dynamics 365 Sales. The call is accepted and the recording is started.

1. After the call ends, the recording is saved in the Azure blob storage or Dataverse, based on the [storage configuration in conversation intelligence settings](fre-setup-ci-sales-app.md). The transcript is saved in Dataverse.
1. Conversation intelligence uses advanced AI models to generate insights from the recording and transcript. 
1. The conversation intelligence app user updates [the tables](#how-the-data-is-structured-in-dataverse) in Dataverse with the insights. The tables are then assigned to the conversation’s owner.
1. The insights are then displayed in the call summary page. 
1. (Optional) The insights are deleted from Dataverse based on the [data retention policy](#data-retention-and-deletion) set by the Dataverse administrator.

## How data is structured in Dataverse

The conversation intelligence data is stored in Dataverse in the form of tables. The following diagram depicts the conversation intelligence tables and their relationships in Dataverse.

:::image type="content" source="media/conversation-intelligence-data-structure-in-dataverse.svg" alt-text="Diagram depicting the conversation intelligence tables and their relationships in Dataverse." lightbox="media/conversation-intelligence-data-structure.svg":::

The following table describes the tables and their purpose.

| Table Name | Description |
|-------------|-------------|
| `msdyn_SCIConversation` | Contains data required to correlate between the conversation intelligence data, phone call activity, and audio recording files. |
| `Recording` | Contains a link to the recording file in the Azure blob storage, or stores the recording itself, based on the storage configuration in conversation intelligence settings. |
| `Transcript` |  Contains the transcript data. |
| `msdyn_conversationAggregatedInsights` | Contains Key Performance Indicators (KPIs) such as longest monologue, switch count throughout the conversation, meeting duration, and more. It also contains IDs to correlate the lower level insights. |
| `msdyn_conversationSentiment` | Contains sentiment data for the conversation such as overall percent of positive, negative, and neutral customer sentiments during the conversation. |
| `msdyn_conversationSubject` | Contains the automatic categorization of segments of the conversation such as introduction, negotiation, closure, and more. |
| `msdyn_conversationParticipantInsights` | Contains identifiers for each participant, as well as their personal KPIs such as, average talking speed, own longest monologue, average pause before speaking, talk-to-listen ratio, and switch count. Each participant in a conversation, whether a seller or a customer, has their own instance of the participant table. This table also contains child nodes listed in the following rows. |
| `msdyn_conversationSignal` | Contains all the tracked keywords such as brands, times, competitors, and names that were mentioned by participants during the conversation. |
| `msdyn_conversationParticipantSentiment` | Contains the sentiment per each fragment of the participant’s speech. |
| `msdyn_conversationActionItem` | Contains suggested action items for the participant. |
| `msdyn_conversationSummarySuggestion` | Contains suggestions for the call summary which involves the participant or were a result of the participant’s communication. |
| `msdyn_conversationQuestion` | Contains questions asked by the participant. |

## Grant access to conversation intelligence tables

By default, all out-of-the-box security roles have permission to access the conversation intelligence tables in Dataverse. If you have custom security roles, work with your Dataverse administrator to grant access to [these tables](#how-the-data-is-structured-in-dataverse).

> [!NOTE]
> **Read** permission is sufficient for users who only need to view the call summary page. **Edit/write** permissions are required to edit the call summary such as tagging a call, leaving a comment on the transcript etc.

### Estimate storage space required for a conversation

The storage space required in Dataverse for a conversation depends on the duration of the conversation, the number of participants, and the configuration of the data saved. Estimate the space required for your organization so that you can plan your storage requirements accordingly.

The following table provides an estimate of the space required for a conversation based on the conversation’s duration for 2 participants:

> [!NOTE]
> Actual size may vary depending on the actual number of tables created or updated during the conversation. 

| Duration (minutes) | Size in MB (2 participants) |
|-------------------|----------------------------|
| 10                 | 0.15                         |
| 20                 | 0.30                         |
| 30                 | 0.45                         |
| 40                 | 0.60                         |
| 50                 | 0.75                         |
| 60                 | 0.90                         |
| 70                 | 1.05                         |
| 80                 | 1.20                         |
| 90                 | 1.35                         |

## Data retention and deletion

By default, there is no expiry date for the data stored in Dataverse. However, you can set a retention policy for the various tables or manually delete parts or all of the data when they're no longer needed. For more information, see [Manage data retention policies in Microsoft Dataverse](/power-apps/maker/data-platform/data-retention-manage).

The [conversation intelligence tables](#how-data-is-structured-in-dataverse) are organized in a tree structure with parent-child relationships. When you delete a record, the following rules apply:

- Deleting a record from any of the tables in the tree will cascade-delete corresponding data in all its sub-nodes. For example, deleting a record from the `msdyn_conversationParticipantInsights` table will delete corresponding records from the `msdyn_conversationSignal`, `msdyn_conversationParticipantSentiment`, `msdyn_conversationActionItem`, `msdyn_conversationSummarySuggestion`, and `msdyn_conversationQuestion` tables. 

- If you've partially deleted the data from Dataverse, the call summary page will continue to display the available insights, provided that the recording and transcripts of the call are available. For example, if you delete a participant's row in the `msdyn_conversationParticipantInsights` table, the call summary page will display all the insights, including the participant's insights for the other participants. 


## See also

- [Set up conversation intelligence for Dynamics 365 Sales](fre-setup-ci-sales-app.md)
- [Manage data retention policies in Microsoft Dataverse](/power-apps/maker/data-platform/data-retention-manage)
- [Manage storage in Microsoft Dataverse](/powerapps/maker/data-platform/manage-storage)