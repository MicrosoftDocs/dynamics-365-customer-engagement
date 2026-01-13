---
title: Use autonomous follow-up and closure of cases
description: Learn how to Use Autonomous Case Follow-up and Closure in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/14/2026
ms.custom: bap-template

---

# Use autonomous follow-up and closure of cases

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]


Case Management Agent uses AI to generate and send periodic follow-up emails that keep customers informed about their case status. If customers don't respond after a configured number of follow-up attempts, the AI agent suggests that you can close the case.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## How does autonomous case follow-up work

Based on the follow-up rules and trigger configured by your administrator, the AI agent performs the following actions:
 
### Runtime experience

Based on the follow-up rules and trigger configured, the AI agent performs the following actions:
 
1. Checks if a case meets the rules set to qualify for the follow-up process.
1. Maps the **Status Reason** value on the case form to the status reason trigger set by you. 
1. Determines if the customer responded to the service representative's email within the configured duration for the first response time.
1. If the status reason matches the trigger, based on the configuration, the AI agent does the following:

### [Fully automated case follow-up and closure](#tab/fullyautomatedcasefollowup)
 
Automatically sends the follow-up emails to customer and then resolves the case without human intervention.
  - You can view the emails sent by the AI agent in case timeline. The emails sent by Copilot have a distinct visual indicator. 
  - Select the email to view the email content in a new tab. A message appears at the bottom of the email indicating that the email was generated using AI. You can also provide feedback on the email in this tab.
  - After the configured number of follow-ups are sent, the agent initiates the case resolution process. It sets the case status to resolved after populating configured case resolution fields. All open activities linked to the case are also closed. 
 
### [Requires agent confirmation](#tab/requiredagentconfirmation)

You are required to review and send the email drafted by the AI agent. You can see the **Suggested actions** card on the case form that contains an AI generated summary of when the customer last responded to your email and the next steps you can take. You can provide feedback by selecting the Thumbs up or Thumbs down option. You can also hide or expand this summary. 

The **Suggested actions** card displays the following actions:
   - **Send follow-up**: The customer didn't respond to your last email within the configured duration. Select **Review and send email** to view the email drafted by the agent in a new tab. You can edit the email and then send it to the customer.
   -  **Send next follow-up**: The customer didn't respond to the follow-up email within the configured duration. Select **Review and send email** to view the email drafted by the agent in a new tab. You can edit the email and then send it to the customer.
   - If the customer responds to the email at any point in the follow-up process, with a favorable response, the AI agent stops sending follow-up emails and the **Suggested actions** card is no longer displayed on the case form.
   - **Reply to customer**: The customer responds to the email within the follow-up duration with a response that the agent can't process or contains a negative response. Select **Draft reply** to view the email drafted by the agent in a new tab. You can edit the email and then send it to the customer.
   - **Resolve case**: The customer didn't respond to any follow-up emails you sent. Select **Resolve case** to view the **Case Resolution** dialog. You can then close any open activities and resolve the case.

---

The email drafted by the AI agent is based on the configuration you set in **Global settings (preview)** or the email templates you configured in the **Case follow-up and closure (preview)** page. Learn more in:

- [Use Copilot recommended email templates](/dynamics365/contact-center/use/use-copilot-email#use-copilot-recommended-email-templates)
- [Use line-of-business tagged email templates](/dynamics365/contact-center/use/use-copilot-email#use-email-templates-tagged-with-line-of-business)
 

## Related information

- [Set up Case Management Agent for case follow-up and closure](../administer/set-up-case-closure.md)



