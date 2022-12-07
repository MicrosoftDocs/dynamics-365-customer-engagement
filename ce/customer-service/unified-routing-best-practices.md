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

## Considerations to set up users in bulk using API

**Scenario**
I want to set up users in bulk in unified routing using API and configure settings such as profiles, capacity, and skills.

**Recommendation**
To configure a large number of users, you'll need to make one request per user to create the agent availability collection. The overall limit is 500 requests every 15 minutes. To add 10 skills to one user after the required roles are provided would mean 10 different requests. So, you should enable users in batches of 50 every 15 minutes.

For information on using the API, see [Use the Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/overview).

The process is as follows:

1. Enable users by importing or creating users
1. Enable unified routing
1. Add users to queues
1. Create bookable resources
1. Attach skills
1. Provide required unified routing roles

> [!NOTE]
> Any changes take 15 minutes to come into effect. If you want the cadence to be shorter, contact Microsoft Support.

## Considerations to set up a queue to prioritize the handling of a large number of cases

**Scenario**
I would like to address the following scenarios while managing cases:

- Handle cases from multiple business units or regions. If region-specific queues exist, work items need to be distributed to agents based on case priority and the service-level agreement (SLA).
- Handle cases that flow into the system round the clock.
- Handle dark hours shifts that will have fewer number of agents.
- Assign cases based on customer preferred language and case topic (subject matter expert).
- On an average, handle 3000 new cases per day.

**Recommendation**
We recommend that you keep your queue backlog within 1000 cases by using one of the following options:

- **Option 1**: Backlog doesn't exceed 1000 cases
  - Configure one queue that's operational round the clock
  - Configure agent work hours based on their shift cycles
  - Configure prioritization as per business requirements
- **Option 2**: Backlog exceeds 1000 cases
  - Configure multiple queues for different channels.

> [!NOTE]
> Multiple queues will impact overall prioritization as cross-queue prioritization isn't supported.

## Considerations to set up single or multiple queues to manage different types of work

**Scenario**
I would like to address the following scenarios:
- My service team supports two types of cases: delivery issues and refund requests. However, most of the users will have the skills for one type only.
- During standard operations, the team will have two subgroups, and each group will handle one type of incoming cases.
- During peak load, certain users can handle cases from both types.

**Recommendation**
We recommend that you configure skill-based matching to assign work items to the agent who has the necessary skills to handle the case.

The following table lists the recommendations to use according to the applicable scenario.

|Scenario|Multiple queues|Match skills|
|---------|----------|---------|
|Agents belong to different line of businesses and security isolation is required|Recommended| Not recommended|
|Line of businesses with different operational hours even if agents are shared|Recommended| Not recommended|
|Large backlog in queue or more than 200 work items per the following queue type:<br> - Voice queue<br> - Messaging queue<br>- Record queue |Recommended| Can be used but queues will need to be split based on load<br>Can be used with queue overflow|
|Same agents overlap multiple queues with same profile| Not recommended| Recommended|
|Gradual relaxation of assignment rules| Not available| Recommended|
|Prioritization across multiple work types| Not available | Recommended|

## Next steps

- [Overview of unified routing](overview-unified-routing.md)  
- [FAQ about unified routing](unified-routing-faqs.md)

