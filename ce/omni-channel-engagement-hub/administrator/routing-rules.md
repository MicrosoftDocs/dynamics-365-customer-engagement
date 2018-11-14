---
title: "Work with routing rules"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: ae408147-bb2c-4016-8ae7-cf06eb12ceb0
ms.custom: 
---
# Omni-channel routing rules

Routing rules in Omni-channel Engagement Hub unify work items from multiple work streams and distribute them to the right agents so that customers are assisted quickly. They are an entry point to the routing and work distribution eco-system. As soon as the routing rules are invoked, they evaluate the destination of an incoming work item and route it to the correct queue.

Routing rules are configured for each work stream. There can be multiple routing rules for a work stream where they help in collecting work items according to the condition applied and route them to the right queue.

![MarkdownConversionFile_Omni channel Engagement Hub Guide image10](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image10.png)  

**Note**: The destination for the work item can be a queue or an agent. In private preview, only queues are supported as the destination.

![MarkdownConversionFile_Omni channel Engagement Hub Guide image11](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image11.png)  

Routing rules evaluate the work items based on the context channel, customer attributes, and agent attributes.

For example, you can define a rule so that chats from preferred customers who have specific queries about investments can be routed to a specific queue. For the above example, the rule configuration will be:

![omni-channel administration sitemap](media/oc-admin-sitemap.png "Omni-channel administration sitemap")  

With the help of using appropriate conditions in the routing rules, you can achieve many more routing combinations to route work items, like:

-   Incoming customer chat request from the portal with specific pre-chat answers should be routed to a specific queue.

-   Incoming custom entity like Change\_Requests, etc. should be routed to omni-channel queue with live agents.

When you define conditions for the omni-channel routing rules, you can choose from:

-   Entity

-   Attribute

-   Operator

-   Value

![MarkdownConversionFile_Omni channel Engagement Hub Guide image13](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image13.png)  

So, for an entity, you can choose from a set of attributes, operators, and values related with the entity### .

## Omni-channel queues

Omni-channel queues are used to collect work items or customer queries and distribute them to different groups of agents or teams. You can achieve optimum distribution in the many ways, like:

-   Creating multiple queues for same issue type. For example, for investment issue, you can create queues for experienced agents and new agents, so that specific customer queries are directed to experienced agents and generic or simpler queries are directed to new agents.

-   Queues created for different issue types. For example, you can create separate queues for different issue types like billing, investments etc.

![MarkdownConversionFile_Omni channel Engagement Hub Guide image14](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image14.PNG)  

Given below are some key characteristics of omni-channel queues:

-   You can assign priority to queues. In that case, all work items in that queue will carry the same priority and will be serviced accordingly.

-   All omni-channel queues are private. Only the members of the queues can view and work on the respective work items.

-   A queue can have agents having different work streams assigned to them.

-   Supervisors can view the work assignment and track work progress in the Queues Dashboard.

-   For each org, there is a default omni-channel queue. An admin user cannot delete the default queue. All omni-channel users are by default members of this queue. Hence, the membership of this queue cannot be altered. Default queue carries the highest priority.

 **Note**: When no queues or routing rules are defined, all the work items are collected in the Default queue. All omni-channel users are the members of the Default queue.

Omni-channel queues provide flexibility for the organizations to define queues as per their business priorities. Both single channel as well as blended agent queues are supported. Hence, omni-channel queues can be used for:

-   Collecting work items for a product or an issue type originating from multiple channels

-   Distributing work item originating from a single channel into different issue types based on customer inputs like pre-chat answers or IVR responses. Also, organizations can model Customer Type as context variables and chose to route the work items to different queues.### 

