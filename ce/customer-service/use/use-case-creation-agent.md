---
title: Use Case Management Agent to create and update cases (preview)
description: Learn how to use autonomous case management agents to efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 05/26/2025
ms.custom: bap-template 
---

# Use Case Management Agent to create and update cases (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Case Management Agent does the following actions:
- autonomously creates cases from chat, digital messaging, and voice conversations.
- autonomously updates case fields during ongoing conversations, from incoming emails
- populates the case fields for a case you've created manually from a conversation or an email.

These capabilities eliminate the need for manual case creation and reduce errors.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]


## Autonomous case creation

The agent creates cases automatically from conversations.

> [!NOTE]
> Autonomous case creation isn't applicable to outgoing voice conversations.

When you accept a conversation routed directly or escalated by a self-assist agent with enough context, the Case Management Agent performs the following actions:

- Maps the context from the conversation to the fields configured by the administrator and predicts the values for those fields.
- Creates a new case that opens in a new tab in the **Active Conversation** form. A case is created only if the agent has enough context to populate all the configured fields. 
- Populates the values of the fields in the case.
- Automatically saves the case.

If there isn't enough context in the conversation to populate the mandatory fields, the agent doesn't create a case when you accept the conversation. However, when you end the conversation, if there's enough information, the agent creates a case, if it isn't manually created.

On the case form, a AI toolbox appears and allows you to do the following actions:

- [Use Copilot's form fill assistance](/power-apps/user/form-filling-assistance).
- View a message that indicates that the case is created by the AI agent.
- Select the link. The **Audit History** page appears on which you can review the fields updated by the AI agent. You need to have access to audit history to be able to view the AI updates.
- Provide feedback.

## Autonomous case updates

The agent updates the fields configured by the administrator as follows:

- **For a case created from a conversation**: The agent populates the fields with context from the ongoing conversation. Updated fields are highlighted, and a banner indicates that they were modified using AI.
- If there isn't enough context to populate the fields, the agent doesn't update them and displays a message indicating no changes.
- If the conversation is in wrap-up state, the following actions occur:
   - If autonomous case creation is enabled, the agent checks if a case is created. If the case isn't created, the agent creates a new case and populates the case fields. 
   - For a case that's created manually and is linked to the conversation, the agent updates the specified fields.

- **For a case created from an email**: The agent populates the fields with context from incoming emails linked to the case. 

On the case form, a AI toolbox appears and allows you to do the following actions:

- [Use Copilot's form fill assistance](/power-apps/user/form-filling-assistance).
- View a message that indicates that the fields were updated by the AI agent.
- Select the link. The **Audit History** page appears on which you can review the fields updated by the AI agent. You need to have access to audit history to be able to view the AI updates.
- Provide feedback.

> [!NOTE]
> If case fields configured for AI agent updates are updated manually, the AI agent doesn’t overwrite the manual updates.

### AI-assisted case creation 

When you create a case manually from a conversation or an email, the AI agent predicts the values for the fields that are available on the case form and populates them. You can review the values and make changes before you save the case.

If your administrator configured autonomous case updates, the AI agent then updates the case fields with information from ongoing conversations or incoming emails, autonomously.


## Next steps

 [Use autonomous follow-up and closure of cases](use-follow-up-closure.md)