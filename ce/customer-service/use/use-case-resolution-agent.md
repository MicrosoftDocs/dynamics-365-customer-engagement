---
title: Use Case Management Agent to resolve cases
description: Learn how to use autonomous Case Management Agent to help customer support teams efficiently resolve cases.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 02/20/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---


# Use Case Management Agent to resolve cases

Autonomous case resolution identifies intent from an incoming email, automatically gathers required customer information, and drafts professional email responses. Based on your administrator's configuration, the agent can automatically send the email or requires a representative to review and send it. 

## Prerequisites

- Autonomous case resolution is configured. Learn more in [Set up Case Management Agent to resolve cases](../administer/set-up-case-resolution-agent.md).
- [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent) is configured.

## Use Case Management Agent to resolve case

- The **Intent-based suggestions** card in the Copilot help pane and displays the following information if the AI agent identified the case intent:
  - The intent as the issue and relevant questions needed to resolve it
  - Visual indicators showing which questions the customer answered
  - Customer responses displayed alongside each question.

- If knowledge articles are used, the citations appear in the email editor under **Agent Sources**.

- Based on your administrator configuration for case resolution, the following actions occur.

   ### [Fully automated case resolution](#tab/fullyautomatedcaseresolution)
 
     - Indicates that the AI agent automatically identifies the case intent, sends emails to the customers, and resolves the case without requiring any human intervention. The case is routed to a separate AI mailbox, which a supervisor monitors. The agent escalates the case to you if it can't resolve the case automatically. You can do the following actions:
       - View the emails sent by the AI agent in the case timeline. The emails sent by Copilot have a distinct visual indicator. 
       - Select the email to view the email content in a new tab. A message appears at the bottom of the email indicating that the email was generated using AI. You can also provide feedback on the email in this tab.
 
 
   ### [Semi-autonomous case resolution](#tab/semiautonomouscaseresolution)
     - The AI agent identifies the case intent and drafts the appropriate response. However, you must review and send the email to the customer. You can do the following actions:
         - If you didn't send an initial response to the customer, the **Timeline** displays an **Upcoming actions** card with the **Send email to customer** action. When you select **Review email**, the email editor opens in a new tab with a Copilot generated email draft based on the case intent. The application displays the email template used to generate the draft. You can review the email draft, make any necessary edits, and send it to the customer.
         - If you received an email response from the customer, the **Timeline** displays an **Upcoming actions** card with the following actions:
	         - **Reply to customer**: Appears when the AI agent determines it requires further information to offer a resolution. When you select **Review email** for this action, the email editor appears with a Copilot-generated draft requesting the additional information. 
	         - **Suggest a resolution**: Appears when the AI agent determines it has enough information to offer a resolution. When you select **Review email** for this action, the email editor appears with a Copilot-generated resolution draft using the appropriate template.
         - On the email editor, you can see the email template the agent used to generate the email. You can use the response as-is or edit the content or use another email template to generate the email. Learn more in [Use Copilot to draft an email](/dynamics365/contact-center/use/use-copilot-email)

--- 
