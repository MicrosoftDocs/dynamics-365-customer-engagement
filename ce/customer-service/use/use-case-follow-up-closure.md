---
title: Use autonomous follow-up and closure of cases
description: Learn how to use autonomous case follow-up and closure in Dynamics 365 Customer Service.
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

# Use autonomous follow-up and closure of cases

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]


Case Management Agent generates and sends periodic follow-up emails to keep customers informed about their case status. If a customer doesn't respond after the configured number of follow-up attempts, the agent suggests closing the case.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## How does autonomous case follow-up work

Your administrator configures the follow-up rules and trigger that determine when the agent follows up on a case.
 
### Runtime experience

The AI agent performs the following actions:
 
1. Checks whether the case meets the follow-up rules.
1. Maps the **Status Reason** value on the case form to the configured status reason trigger.
1. Determines whether the customer responded to the service representative's email within the configured first response time.
1. If the status reason matches the trigger, follows the configured automation workflow:

### [Fully automated case follow-up and closure](#tab/fullyautomatedcasefollowup)
 
The AI agent sends follow-up emails to the customer and resolves the case without human intervention.

- View emails sent by the agent in the case timeline. Emails sent by Copilot have a distinct visual indicator.
- Select an email to open it in a new tab. A message at the bottom identifies the email as AI-generated. You can also provide feedback in this tab.
- After sending the configured number of follow-ups, the agent starts the case resolution process. It populates the configured case resolution fields and sets the case status to resolved. All open activities linked to the case also close.
 
### [Requires agent confirmation](#tab/requiredagentconfirmation)

Review and send the email the AI agent drafts. The **Suggested actions** card on the case form shows an AI-generated summary of when the customer last responded and the next steps you can take. Select **Thumbs up** or **Thumbs down** to provide feedback. You can also hide or expand the summary.

The **Suggested actions** card displays the following actions:
- **Send follow-up**: The customer didn't respond to your last email within the configured duration. Select **Review and send email** to open the agent's draft in a new tab. Edit the email as needed, and send it to the customer.
- **Send next follow-up**: The customer didn't respond to the follow-up email within the configured duration. Select **Review and send email** to open the agent's draft in a new tab. Edit the email as needed, and send it to the customer.
- **Reply to customer**: The customer responded within the follow-up duration, but the response is negative or the agent can't process it. Select **Draft reply** to open the agent's draft in a new tab. Edit the email as needed, and send it to the customer.
- **Resolve case**: The customer didn't respond to any follow-up emails. Select **Resolve case** to open the **Case Resolution** dialog. Close any open activities, and resolve the case.

If the customer responds favorably at any point during follow-up, the agent stops sending follow-up emails and hides the **Suggested actions** card.

---

The agent drafts emails based on the configuration in **Global settings (preview)** or the templates on the **Case follow-up and closure (preview)** page. Learn more in:

- [Use Copilot recommended email templates](/dynamics365/contact-center/use/use-copilot-email#use-copilot-recommended-email-templates)
- [Use line-of-business tagged email templates](/dynamics365/contact-center/use/use-copilot-email#use-email-templates-tagged-with-line-of-business)


[!INCLUDE[review-agent-activity](../../includes/review-agent-activity.md)]

## Related information

- [Set up Case Management Agent for case follow-up and closure](../administer/set-up-case-closure.md)



