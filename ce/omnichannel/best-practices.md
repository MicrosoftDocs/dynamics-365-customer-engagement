---
title: "Best practices to use Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about best practices to use Omnichannel for Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 06/28/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Best practices to use Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Here are the best practices to use Omnichannel for Customer Service, so that the data in the dashboards are not affected:

-  Agents should sign out or set presence as Appear away before stepping out. This avoids the routing of conversation requests to them.

-  As an administrator or supervisor, you should not configure routing rules to assign conversation requests for agents whose presence is away or offline. This ensures that conversations from channels that require immediate attention are not assigned to the agents who are away or offline. 

-  Close the session in the app once the conversation with the customer is complete. Closing a session ensures that you have capacity to work on the next conversation request. 
