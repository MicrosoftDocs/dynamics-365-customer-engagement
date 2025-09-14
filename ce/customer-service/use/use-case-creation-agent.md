---
title: Use Case Management Agent to create and update cases (preview)
description: Learn how to use autonomous case management agents to efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 08/08/2025
ms.custom: bap-template
---

# Use Case Management Agent to create and update cases (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The case creation and update feature in Case Management Agent does the following actions:
- autonomously creates cases from chat, digital messaging, and incoming voice conversations
- autonomously updates case fields when a conversation ends or from incoming emails
- populates the case fields for a case you created manually from a conversation or an email

These capabilities eliminate the need for manual case creation and reduce errors.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- Your administrator has [Set up Case Management Agent to create and update cases (preview)](../administer/set-up-autonomous-case-agents.md).

## Autonomous case creation

When you accept a conversation routed directly or escalated by a self-assist agent with enough context, the Case Management Agent performs the following actions:

- Maps the conversation context to the fields configured by the administrator and predicts their values.
- Creates a new case that opens in a new tab in the **Active Conversation** form. A case is created only if the agent has enough context to populate the configured fields. Only the fields for which sufficient context is available are predicted. 
- Populates the values of the fields in the case.
- Automatically saves the case.

If the conversation doesn't contain enough context to populate any of the configured fields, the agent doesn't create a case when you accept the conversation. However, when you end the conversation, the agent creates a case if enough information is available and the case isn't created manually.

On the case form, an AI toolbar appears and allows you to do the following actions:

- [Use Copilot's form fill assistance](/power-apps/user/form-filling-assistance).
- View a message that indicates that the AI agent created the case.
- Select the link. The **Audit History** page appears on which you can review the fields updated by the AI agent. You need to have access to audit history to be able to view the AI updates.
- Provide feedback.

## Autonomous case updates

The AI agent updates the fields configured by the administrator as follows:

- **For a case created from a conversation**: The agent populates the fields with context from the ongoing conversation. 
- If there isn't enough context to populate the fields, the agent doesn't update the fields.
- If the conversation is in wrap-up state, the following actions occur:
   - If autonomous case creation is enabled, the agent checks if a case is created. If the case isn't created, the agent creates a new case and populates the case fields. 
   - For a case you created manually and is linked to the conversation, the AI agent updates the specified fields.

- **For a case created from an email**: The agent populates the fields with context from incoming emails linked to the case. 

On the case form, an AI toolbar appears and allows you to do the following actions:

- [Use Copilot's form fill assistance](/power-apps/user/form-filling-assistance).
- View a message that indicates that the AI agent updated the case fields.
- Select the link. The **Audit History** page appears on which you can review the fields updated by the AI agent. You need to have access to audit history to be able to view the AI updates.
- Provide feedback.

> [!NOTE]
> Based on your [administrator configuration](../administer/set-up-autonomous-case-agents.md#configure-autonomous-case-updates), if case fields configured for AI agent updates are updated manually, the AI agent either overwrites the manual updates or leaves them intact.

### Create cases with AI assistance

The AI agent predicts the values for all the available case fields when and populates them when you manually create a case as follows:

- When you select **New Case** on the **Active Conversation** form for an ongoing conversation.
- When you select **Convert to case** on the Email form for an email conversation.

The case appears in a new tab. You can do the following actions: 

- You can review the values that the agent predicted. A visual indicator indicates that the values were predicted by the AI agent.
- An AI toolbar appears and allows you to do the following actions:
   - [Use Copilot's form fill assistance](/power-apps/user/form-filling-assistance).
   - Select **Accept suggestions** to accept all the predicted values. Alternatively, you can hover over the field to accept or reject the predicted value one at a time. 
   - Provide feedback.

If your administrator configured autonomous case updates, the AI agent then updates the case fields with information from ongoing conversations or incoming emails, autonomously.


## Next steps

 [Use autonomous follow-up and closure of cases](use-case-follow-up-closure.md)