---	
title: Route cases automatically using entity records channel | MicrosoftDocs	
description: Learn how you can route cases automatically using entity records channel in the Omnichannel for Administrator app."		
author: kabala123	
ms.author: kabala	
manager: shujoshi	
applies_to: 	
ms.date: 08/16/2019
ms.service: dynamics-365-customerservice	
ms.topic: article	
ms.assetid: 5e6285ee-4b79-473d-b920-d1fab636c82e	
ms.custom: 	
---	
# Route cases automatically	

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0	

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

## Overview
 
In Omnichannel, Cases entity record channel helps you to automatically route cases to the agents based on the agents' skill, capacity, and availability.

### Existing case routing experience

Today, case routing in Dynamics 365 for Customer Service enables organizations to route cases to static queues, and then these cases are either manually distributed by supervisors or manually picked by agents. 

That is, the cases are routed to the queues based on the routing rules, and then the agents pick the cases manually, or the supervisor assigns it to the agents manually.

The routing rules don't consider the availability, capacity, and also the skill that agents require to address the case. The manual distribution of cases leads to an unbalanced case distribution and affects the productivity of the agents.

### Automatic distribution of cases

With unified routing, cases can be routed to omnichannel enabled queues along with work items that originate from other channels such as Chat and SMS.

That is, the cases are routed to the queues based on the routing rules, and then the work distribution engine distributes the cases automatically to the agents based on the availability, capacity, and skill.

This allows organizations to tightly define the work profile that their agents are supposed to handle, and organizations can automate the work flow assignment across channels and assign the work items based on agents capacity, availability, and skill.

## Cases channel

Omnichannel leverages the existing CDS queue entity to automatically route cases. In omnichannel, first, the application routes the cases to the queues. From the queues the work distribution engine automatically distributes the cases to the agents.

> [!Note]
> - If you have already setup queues for cases or other entities in Dynamics 365 for Customer Service, you can continue to use the same for omnichannel work distribution.
>
> - Only case entity is supported in this release.

### See also 	

[Understand and create work streams](work-streams-introduction.md)