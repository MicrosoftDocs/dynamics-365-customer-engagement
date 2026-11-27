---
title: Use Case Management Agent to resolve cases
description: Learn how to use autonomous Case Management Agent to help customer support teams efficiently resolve cases.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 11/26/2026
ms.update-cycle: 180-days
ms.custom: bap-template
ai-usage: ai-assisted
---


# Use Case Management Agent to resolve cases

Case Management Agent identifies intent from incoming emails, gathers required customer information, and drafts responses. Depending on your administrator's configuration, the agent sends the email automatically or requires a service representative to review and send it.

## Prerequisites

- Autonomous case resolution is configured. Learn more in [Set up Case Management Agent to resolve cases](../administer/set-up-case-resolution-agent.md).
- [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent) is configured.
- If you want to change the automation level, you must be a supervisor with the appropriate permissions.

<a name="use-case-management-agent-to-resolve-case"></a>

## Use Case Management Agent to resolve cases

When the AI agent identifies the case intent, the **Intent-based suggestions** card in the Copilot help pane displays:

- The intent as the issue and the questions needed to resolve it.
- Visual indicators showing which questions the customer answered.
- Customer responses alongside each question.

If the agent uses knowledge articles, citations appear in the email editor under **Agent Sources**.

The case resolution workflow depends on your administrator's configuration.

### [Fully automated case resolution](#tab/fullyautomatedcaseresolution)

The AI agent identifies case intent, sends emails to customers, and resolves cases without human intervention. The case is routed to a separate AI mailbox that a supervisor monitors. If the agent can't resolve the case automatically, it escalates the case to you.

You can:

- View emails sent by the AI agent in the case timeline. Emails sent by Copilot have a distinct visual indicator.
- Select an email to open it in a new tab. A message at the bottom identifies the email as AI-generated. You can also provide feedback in this tab.

### [Semi-autonomous case resolution](#tab/semiautonomouscaseresolution)

The AI agent identifies case intent and drafts a response. You must review and send the email to the customer.

- If you haven't sent an initial response, the **Timeline** displays an **Upcoming actions** card with the **Send email to customer** action. Select **Review email** to open a Copilot-generated draft based on the case intent. The email editor shows the template used to generate the draft. Review the draft, make any necessary edits, and send it to the customer.
- If you receive an email response from the customer, the **Timeline** displays an **Upcoming actions** card with these actions:
  - **Reply to customer**: Appears when the agent needs more information to offer a resolution. Select **Review email** to open a Copilot-generated draft requesting the information.
  - **Suggest a resolution**: Appears when the agent has enough information to offer a resolution. Select **Review email** to open a Copilot-generated resolution draft using the appropriate template.
- In the email editor, review the template the agent used. Use the response as is, edit it, or select another template to generate the email. Learn more in [Use Copilot to draft an email](/dynamics365/contact-center/use/use-copilot-email).

---

<a name="change-automation-level-for-case"></a>

## Change the automation level for cases

As a supervisor, you can use the **Edit AI Automation** option to change the case resolution automation level for an individual case or multiple cases in real time. For example, you can change a case from fully autonomous resolution to semi-autonomous resolution when you want a service representative to review responses before they're sent to the customer.

The available automation levels support the following behaviors:

| Automation level | Case resolution behavior |
|----------|-------------|
| Fully autonomous | Case Management Agent handles case resolution automatically, including sending email responses to the customer. |
| Semi-autonomous | Case Management Agent drafts email responses for a service representative to review and send. |
| Disabled | Case Management Agent doesn't draft or send new case resolution email responses. |

If you change the automation level while Case Management Agent is performing an action, that action completes. Subsequent case resolution actions use the newly selected level. Changing the level doesn't undo actions the agent already completed.

> [!IMPORTANT]
> **Edit AI Automation** settings apply only to case resolution. They don't change automation for case follow-up and closure or other Case Management Agent capabilities.

[!INCLUDE[review-agent-activity](../../includes/review-agent-activity.md)]

## Related information

[Monitor and supervise autonomous agents](supervise-ai-agents.md)