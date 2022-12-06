---
title: Best practices to set up unified routing in Customer Service
description: Use this article to know about the best practices to set up unified routing in Customer Service and things to do and avoid for a successful implementation.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: conceptual
ms.date: 12/09/2022
ms.custom: bap-template
---

# Best practices to set up unified routing in Customer Service

This article lists some of the best practices to help set up and use unified routing optimally for your business.

## How to set up users in bulk

**Scenario**
I want to set up users in bulk in unified routing and configure settings such as profiles, capacity, and skills.

**Recommendation**
To configure a large number of users, do the following:

1. Enable users in batches of 500 each every 15 minutes.
1. Provide required roles to the users after you attach skills and grant queue membership​ (since in this case it means 1 request per user to create Agent Availability collection).
 Adding 10 skills to 1 user after required roles are already provided, would mean 10 different requests. So, you should enable users in batches of 50 every 15 minutes in this case.  


<!--add your content here-->

<!--Next steps - Required. Provide at least one next step and no more than three. Include some context so the customer can determine why they would click the link.-->
## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
