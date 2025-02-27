---
title: Use autonomous follow-up and closure of cases
description: Learn how to Use Autonomous Case Follow-up and Closure.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection:
ms.date: 03/04/2025
ms.custom: bap-template 
---

# Use autonomous follow-up and closure of cases

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]


The autonomous case agent management uses AI to generate and send periodic follow-up emails that keep customers informed about their case status. If customers don't respond after a configured number of follow-up attempts, the agent can automatically resolve and close these cases.

Based on your administrator's configuration, the agent can perform these actions autonomously or with agent confirmation.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note-d365.md)]


## Use case follow-up and closure

After you send a closure email to the customer, the agent performs the following actions:

1. Checks if the trigger condition set by the administrator is met.
2. Determines if the customer responded to your email within the configured duration for the first response time.
3. If there's no response, the agent initiates the follow-up process. The **Suggested actions** card appears on the case form. Based on the administrator's configuration, you can perform the following actions:


  ### [Fully autonomous](#tab/fullyautonomous)
  
   - Select the **Preview** button to view the email drafted by the agent in a new tab.
   - After the configured number of follow-ups are sent, the agent sets the case status to resolved after populating configured case resolution fields. All open activities linked to the case are also closed.

  ### [Require agent confirmation](#tab/requireagentconfirmation)

   - Select the **Review and send** button to view the email drafted by the agent in a new tab. You can edit the email and then send it to a customer.
   - After the required follow-up emails are sent, the agent displays the case resolution dialog with the configured resolution fields updated. You can then close any open activities and resolve the case.

---
