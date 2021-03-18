---
title: "Best practices to use Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about guidelines to use Omnichannel for Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 06/28/2019
ms.topic: article
ms.service: dynamics-365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Best practices to use Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Use the following guidelines in Omnichannel for Customer Service, so that the data in the dashboards isn't affected:

-  Agents should sign out or set presence as Appear away before stepping out. This avoids the routing of conversation requests to them.

-  As an administrator or supervisor, you shouldn't configure routing rules to assign conversation requests for agents whose presence is away or offline. This ensures that conversations from channels that require immediate attention aren't assigned to the agents who are away or offline. 

-  Close the session in the app after the conversation with the customer is complete. This ensures that you have capacity to work on the next conversation request. 


[!INCLUDE[footer-include](../includes/footer-banner.md)]