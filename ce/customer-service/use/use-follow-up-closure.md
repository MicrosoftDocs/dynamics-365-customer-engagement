---
title: Use Autonomous Case Follow-up and Closure
description: Learn how to Use Autonomous Case Follow-up and Closure.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to #Required; don't change.
ms.collection: get-started #Required; If this isn't a getting started article, don't remove the attribute, but leave the value blank. The values for this attribute will be updated over time.
ms.date: 01/13/2025
ms.custom: bap-template #Required; don't change.
---

# Use Autonomous Case Follow-up and Closure

The autonomous case agent uses AI to generate and send periodic follow-up emails that keep customers informed about their case status. If customers don't respond after a configured number of follow-up attempts, the agent can automatically resolve and close these cases.

## Use case follow-up

After you send a closure email to the customer, the agent performs the following actions:

- Checks if the trigger condition set by the administrator is met.
- Determines if the customer has sent a response to your email within the configured duration for the first response time.
- If there's no response, the agent initiates the follow-up process. Based on the administrator's configuration of the automation level, the agent does one of the following.


   ### [Fully autonomous](#tab/fullyautonomous)
  
  - Displays a Suggested actions card with a Preview button.
  - When the service representative selects the button, the email form opens in a new tab with an email drafted by the agent.
  - The service agent can view the email.

   ### [Require agent confirmation](#tab/requireagentconfirmation)

   - Displays a Suggested actions card with a Review and send button.
   - When the service representative selects the button, the email form opens in a new tab with an email drafted by the agent.
   - The service agent can view, edit, and send the email.

---

## Autonomous case resolution

After the configured number of follow-ups are sent, the agent initiates the case resolution process. Based on the administrator's configuration of the automation level, the agent does one of the following:


 ### [Fully autonomous](#tab/fullyautonomous)

  Sets the case status to resolved after populating configured case resolution fields. All open activities linked to the case are also closed.

 ### [Required agent confirmation](#tab/requireagentconfirmation)

  Displays the case resolution dialog with the set resolution fields updated. The service representative can then close any open activities and then resolve the case.

---