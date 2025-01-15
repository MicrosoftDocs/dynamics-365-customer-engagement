---
title: Use autonomous case management agents (preview)
description: Learn how to set up autonomous case management agents to help customer support teams efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to #Required; don't change.
ms.collection: get-started #Required; If this isn't a getting started article, don't remove the attribute, but leave the value blank. The values for this attribute will be updated over time.
ms.date: 01/13/2025
ms.custom: bap-template #Required; don't change.
---

# Use autonomous case management agents (preview)

The autonomous case management agent  uses live chat conversations and incoming emails  to create cases and fill in relevant case fields. It can also update case fields during ongoing conversations, eliminating the need for manual case creation and reducing errors.

## Autonomous case creation

The agent creates cases automatically from chat conversations and incoming email.

### Live chat

When you accept a conversation that is routed directly or is escalated by a self-assist agent (bot) with enough context, the autonomous case management agent performs the following actions:

- Maps the context from the conversation to the fields configured by the administrator and predicts the values for those fields.
- Creates a new case that opens in a new tab in the Active Conversation form. A case is created only if the agent has enough context to populate all the configured fields.
- Populates the values of the fields in the case.

If there isn't enough context in the conversation to populate the mandatory fields, the agent doesn't create a case when you accept the conversation. However, when you end the conversation, if there's enough information, the agent creates a case, if it isn't manually created.

### Email

For an incoming email, a case is created automatically based on the configured ARC rules. The agent then predicts and populates the configured default fields with the context from the email. 

## Update a case

The agent updates the fields configured by the administrator as follows:

- **For a case created from a conversation**: The **Update from conversation** button appears on the case form. When you select the button, the agent populates the fields with context from the ongoing conversation. Updated fields are highlighted, and a banner indicates they were modified using AI.
  - If the conversation is in wrap-up state, the agent checks if a case is created and updates the specified fields.
  - If there isn't enough context to populate the fields, the agent doesn't update them and displays a message indicating no changes.

- **For a case created from an email**: The agent populates the fields with context from incoming emails linked to the case. Updated fields are highlighted, and a banner indicates they were modified using AI.

> [!NOTE]
> Manually updated case fields configured for agent updates will be overwritten by AI predictions.

## Next steps

 [Use autonomous follow-up and closure of cases](use-follow-up-closure.md)