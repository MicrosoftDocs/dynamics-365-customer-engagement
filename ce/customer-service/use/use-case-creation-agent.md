---
title: Use Case Management Agent to create and update cases 
description: Learn how to use autonomous Case Management Agent to efficiently handle case management tasks in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/14/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Use Case Management Agent to create and update cases 


The case creation and update feature in Case Management Agent does the following actions, eliminating the need for manual case creation and reducing errors:

- Autonomously creates cases from chat, digital messaging, and incoming voice conversations
- Autonomously updates case fields when a conversation ends or from incoming emails
- Populates the case fields for a manually created case from a conversation or an email

## Prerequisites

- Your administrator has [Set up Case Management Agent to create and update cases](../administer/set-up-autonomous-case-agents.md).

## Autonomous case creation

When you accept a conversation routed directly or escalated by a self-assist agent with enough context, Case Management Agent performs the following actions:

- Maps the conversation context to the fields configured by the administrator and predicts their values.
- Creates a new case that opens in a new tab in the **Active Conversation** form. A case is created only if the agent has enough context to populate the configured fields. Only the fields for which sufficient context is available are predicted. However, when you end the conversation, the agent creates a case if enough information is available and the case isn't created manually.
- Populates the values of the fields in the case.
- Automatically saves the case.

On the case form, an AI toolbar appears and allows you to do the following actions:

- [Use Copilot's form fill assistance](/power-apps/user/form-filling-assistance).
- View a message that indicates that the AI agent created the case.
- Select the link. The **Audit History** page appears on which you can review the fields updated by the AI agent. You need to have access to audit history to be able to view the AI updates.
- Provide feedback.

## Autonomous case updates

- **For a case created from a conversation**: For a case associated with a conversation, when the conversation is in wrap-up state, the agent performs the following actions:
   - Updates the case fields with context from the conversation.
   - If there isn't enough context to populate the fields, the agent doesn't update the fields.
   - For a case you created manually and is linked to the conversation, the AI agent updates the specified fields.
   - A note is created in the timeline with the summary of the conversation.

- **For a case created from an email**: The agent populates the fields with context from incoming emails linked to the case. 

On the case form, an AI toolbar appears and allows you to do the following actions:

- [Use Copilot's form fill assistance](/power-apps/user/form-filling-assistance).
- View a message that indicates that the AI agent updated the case fields.
- Select the link. The **Audit History** page appears on which you can review the fields updated by the AI agent. You need to have access to audit history to be able to view the AI updates.
- Provide feedback.

> [!NOTE]
> Based on your [administrator configuration](../administer/set-up-autonomous-case-agents.md#configure-autonomous-case-updates), if case fields configured for AI agent updates are updated manually, the AI agent either overwrites the manual updates or leaves them intact.

### Create cases with AI assistance

The AI agent predicts the values for all the available case fields and populates them when you manually create a case as follows:

- When you select **New Case** on the **Active Conversation** form for an ongoing conversation.
- When you select **Convert to case** on the Email form for an email conversation.

The case appears in a new tab. You can do the following actions: 

- You can review the values that the agent predicted. A visual indicator indicates that the values were predicted by the AI agent.
- An AI toolbar appears and allows you to do the following actions:
   - [Use Copilot's form fill assistance](/power-apps/user/form-filling-assistance).
   - Select **Accept suggestions** to accept all the predicted values. Alternatively, you can hover over the field to accept or reject the predicted value one at a time. 
   - Provide feedback.

If your administrator configured autonomous case updates, the AI agent then autonomously updates the case fields with information from a conversation that's in wrap-up state or incoming emails.


## Next steps

 [Use autonomous follow-up and closure of cases](use-case-follow-up-closure.md)