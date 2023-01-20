---
title: Guidance to set up unified routing in Customer Service
description: Use this article to know about the best practices to set up unified routing in Customer Service and things to do and avoid for a successful implementation.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: conceptual
ms.date: 12/15/2022
ms.custom: bap-template
---

# Guidance to set up unified routing in Customer Service

This article lists discusses some of the important aspects to successfully deploy and manage unified routing that focuses on the most common areas where you might have questions.

## Limit number of change requests while making Dataverse API calls to set up users in bulk

**Scenario**
I want to set up users in bulk in unified routing using API and configure settings such as work hours, capacity, and skills.

**Recommendation**
To configure a large number of users, you'll need to make one request per user and change. The overall limit is 500 requests every 15 minutes. To add 10 skills to one user after the required roles are provided would mean 10 different requests. In this case, you should enable users in batches of 50 every 15 minutes.

For information on using the API, see [Use the Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/overview).

The process is as follows:

1. Enable users by importing or creating users
1. Enable unified routing
1. Add users to queues
1. Create bookable resources
1. Attach skills or capacity profiles as required
1. Provide required unified routing roles

> [!NOTE]
> Any changes take 15 minutes to come into effect. If you want the cadence to be shorter, contact Microsoft Support.

## Considerations when the top 100 items in a queue have extended wait times

The auto-assignment process in unified routing matches incoming work items with the best-suited agents based on the configured assignment rules. This continuous process is made up of multiple assignment cycles. Each cycle picks up the top unassigned work items in a default block of 100 items and attempts to match each work item with an appropriate agent. Work items that couldn't be assigned to agents is routed back to the queue. The next assignment cycle picks up another block of 100 top-priority items.

For information about the assignment methods, see [Assignment methods](assignment-methods.md).

**Scenario**
Agents aren't available for extended periods to be assigned the top 100 work items while eligible agents are available for lower-priority work items.

**Recommendation**
We recommend that you use features such as overflow management to manage high load and review agent availability, agent schedules, and configure skills to expand the eligible agent pool. If these options aren't adequate for your use case and eligible agents are available for items lower in priority, then contact Microsoft Support with your business scenario to determine whether the default block size of 100 can be increased.

> [!NOTE]
> An increase in the block size to a large number might affect performance. Therefore, we recommend that you share your business scenario and the queue back log and queue staffing projections for Microsoft Support to suggest the most optimized block size that addresses your use case.

## Considerations to set up single or multiple queues to manage different types of work

**Scenario**
I would like to address the following scenarios:
- My service team supports two types of records: delivery issues and refund requests. However, most of the users will have the skills for one type only.
- During standard operations, the team will have two subgroups, and each group will handle one type of incoming records.
- During peak load, certain users can handle records from both types.

**Recommendation**
We recommend that you configure skill-based match process to assign work items to the agent who has the necessary skills to handle the case.

The following table lists the recommendations to use according to the applicable scenario.

|Scenario|Multiple queues|Match skills|
|---------|----------|---------|
|Agents belong to different line of businesses and security isolation is required|Recommended| Not recommended|
|Line of businesses with different operational hours even if agents are shared|Recommended| Not recommended|
|Large backlog in queue or more than 100 work items per the following queue type:<br> - Voice queue<br> - Messaging queue<br>- Record queue |Recommended| Can be used but queues will need to be split based on load<br>Can be used with queue overflow|
|Same agents overlap multiple queues with same profile| Not recommended| Recommended|
|Gradual relaxation of assignment rules| Not available| Recommended|
|Prioritization across multiple work types| Not available | Recommended|

## Next steps

- [Overview of unified routing](overview-unified-routing.md)  
- [FAQ about unified routing](unified-routing-faqs.md)

