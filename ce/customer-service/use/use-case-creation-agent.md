---
title: Use autonomous case management agents
description: Learn how to set up autonomous case management agents to help customer support teams efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to #Required; don't change.
ms.collection: get-started #Required; If this isn't a getting started article, don't remove the attribute, but leave the value blank. The values for this attribute will be updated over time.
ms.date: 01/13/2025
ms.custom: bap-template #Required; don't change.
---

# Use autonomous case management agents

The autonomous case management agent  uses live chat conversations and incoming emails  to create cases and fill in relevant case fields. It can also update case fields during ongoing conversations, eliminating the need for manual case creation and reducing errors. Additionally, it automates sending follow-up emails to keep customers informed about case progress. The agent can even automatically resolve cases if no response is received after a set number of follow-up emails, streamlining the closure process and freeing up support representatives for more complex issues.

## Autonomous case creation and update for live chat

When you accept a conversation that is routed directly or is escalated by a self-assist agent (bot) with enough context, the autonomous case management agent performs the following actions:

- Maps the context from the conversation to the fields configured by the administrator and predicts the values for those fields.
- Creates a new case that opens in a new tab in the Active Conversation form. A case is created only if the agent has enough context to populate all the configured fields.
- Populates the values of the fields in the case.

If there isn't enough context in the conversation to populate the mandatory fields, the agent doesn't create a case when you accept the conversation. However, the agent creates a if there's enough information from the chat to predict the mandatory fields when you end the conversation, and you haven't already created a case.

## Update a case

After the agent creates a case, the **Update from conversation** button appears on the case form. When you select this button, the following actions occur:

- Based on the configurations set by the administrator, the agent populates the fields with the updated context from the conversation.
- During conversation wrap-up, the agent checks if a case is created. If the case exists, the specified fields are updated.
- The fields populated by the agent are highlighted.
- The application displays a banner that fields were modified using AI.

If there isn't enough context in the conversation to populate the configured fields, the agent doesn't update them. The application displays a message that there aren't any changes to update the fields.

## Autonomous case creation and Update for Email

For an incoming email, a case is created automatically based on the configured ARC rules. If the automated case creation is enabled for emails, the agent performs the following actions:

- Updates the case fields in the new case with context from the email automatically.
- For incoming emails that are linked to the case, the agent updates the configured fields from the emails.
- The fields populated by the agent are highlighted.
- The application displays a banner that fields were modified using AI.

> [!NOTE]
> If you manually update the case fields, they may be overridden by AI predictions when the agent updates the case.
