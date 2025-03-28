---
title: Use autonomous follow-up and closure of cases
description: Learn how to Use Autonomous Case Follow-up and Closure.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection:
ms.date: 03/28/2025
ms.custom: bap-template 
---

# Use autonomous follow-up and closure of cases

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]


The Case Management Agent uses AI to generate and send periodic follow-up emails that keep customers informed about their case status. If customers don't respond after a configured number of follow-up attempts, the AI agent suggests that you can close the case.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]



## How does autonomous case follow-up work

Based on the follow-up rules and trigger configured by your administrator, the AI agent performs the following actions:
 
1. Checks if a case meets the rules set to qualify for the follow-up process.
1. Maps the **Status Reason** value on the case form to the status reason trigger set by your administrator. 
1. Determines if the customer responded to your email within the configured duration for the first response time. If the status reason matches the trigger, the AI agent displays the **Suggested actions** card on the case form with the next steps you can take.
 
## Use the Suggested actions card

You can see the **Suggested actions** card on the case form based on the configurations set by the administrator. The **Suggested actions** card displays the following:

 - The next steps you can take.
 
      - **Send follow-up**: The customer didn't respond to your last email within the configured duration. Select **Review and send email** to view the email drafted by the agent in a new tab. You can edit the email and then send it to the customer.
      - **Send next follow-up**: The customer didn't respond to the follow-up email within the configured duration. Select **Review and send email** to view the email drafted by the agent in a new tab. You can edit the email and then send it to the customer.
     - If the customer responds to the email at any point in the follow-up process, with a favorable response, the AI agent stops sending follow-up emails and the **Suggested actions** card is no longer displayed on the the case form.
     - **Reply to customer**: The customer responds to the email within the follow-up duration with a response that the agent can't process or contains a negative response. Select **Draft reply** to view the email drafted by the agent in a new tab. You can edit the email and then send it to the customer.
      - **Resolve case**: The customer didn't respond to any of the follow-up emails you sent. Select **Resolve case** to view the **Case Resolution** dialog. You can then close any open activities and resolve the case.
 - An AI generated summary of when the customer last responded to your email and the next steps you can take. You can provide feedback by selecting the Thumbs up or Thumbs down option. You can also hide or expand this summary.





