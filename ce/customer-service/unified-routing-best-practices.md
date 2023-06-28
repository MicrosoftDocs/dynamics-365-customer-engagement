---
title: Use best practices to set up unified routing in Customer Service
description: Use this article to learn about the best practices to set up unified routing in Customer Service and what to do and avoid for a successful implementation.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: how-to
ms.date: 02/20/2023
ms.custom: bap-template
---

# Use best practices to set up unified routing in Customer Service

This article discusses some of the important aspects to successfully deploy and manage unified routing and focuses on the most common areas where you might have questions.

## Set up unified routing

### Verify service limits and default quotas

Dynamics 365 Customer Service relies on shared cloud resources for data and processing. You must check the service limits and default quotas for the resources before you provision unified routing. If you need a higher limit on a measure that's indicated as adjustable, contact Microsoft Support to check whether the limit can be increased. More information: [Service quotas](service-quotas.md)

## Manage users

Use the following guidance to set up users in bulk:

- Follow a specific sequence to set up users in bulk using Dataverse API calls.
- Limit the number of change requests when setting up users in bulk using Dataverse API calls.

### Follow a specific sequence to set up users in bulk using Dataverse API calls

To manage the users in bulk, follow these steps:

1. Create or import users to enable them.
1. Add the users to queues. More information: [Create and manage queues](queues-omnichannel.md)
1. Create bookable resources. More information: [Manage users](users-user-profiles.md#manage-users-using-the-classic-experience)
1. Add skills. More information: [Set up skills](setup-skills-assign-agents.md)
1. Assign capacity profiles. More information: [Create and manage capacity profiles](capacity-profiles.md)
1. Assign required roles. More information: [Assign roles](add-users-assign-roles.md)

If you don't follow the recommended order, inconsistencies in the user information might occur, such as missing users or missing skills and capacity profiles.

### Limit number of change requests when setting up users in bulk using Dataverse API calls

Customer Service lets you make API calls to set up users in bulk. A single change request is any add or update operation like defining a single skill, capacity profile, or role per user.

We recommend that you make 500 change requests every 15 minutes for the system to process the changes optimally without getting throttled. Beyond this recommended rate for bulk updates, you might see inconsistencies in user data, such as skills not updated as expected, after the update is over.

For example, let's say you manage a contact center that has 1,000 agents working in it and need to set up each agent by assigning two skills, one capacity profile, and one role. The total number of requests to configure these settings is 4,000.

Based on our recommendation of 500 requests per 15 minutes, you'll need to make these requests in eight batches as follows:

|Change request type|Number of requests|Number of batches|
|-----------|---------|------------|
|Two skills per agent|250 requests per batch|Four|
|One capacity profile per agent|500 requests per batch|Two|
|One role per agent|500 requests per batch|Two|

For information on using the API, see [Use the Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/overview).

### Monitor agent capacity

You can use the **Agents insights** report to view details such as the agent's presence, current conversations, and the sentiments of those conversations, as well as an agent's available capacity across different capacity profiles.

If you'd like to create a custom report to monitor the agent capacity, you must use the following entities:
- the [agent status](/developer/reference/entities/msdyn_agentstatus.md) entity to get the latest capacity profile and presence status of an agent. 
- The [status history](/developer/reference/entities/msdyn_agentcapacityupdatehistory.md) entity to get the history or audit trail of the presence and capacity profile changes for an agent.

## Manage queues

- Manage automatic assignment if the top 100 work items have extended wait times.
- Use skill-based routing to distribute work items to the most qualified agents.
- Set up single or multiple queues with skill-matching to manage different types of work.

### Manage auto-assignment if top 100 work items have extended wait times

The auto-assignment process in unified routing matches incoming work items with the best-suited agents based on the configured assignment rules. This continuous process is made up of multiple assignment cycles. For information about the auto-assignment process, see [How auto assignment works](assignment-methods.md#how-auto-assignment-works).

If you have a scenario in which agents aren't available to be assigned the top 100 work items for an extended time, we recommend the following options:

- To minimize the wait time, use features like overflow management to manage high load or custom assignment rules to gradually relax rules to expand the eligible agent pool.
- Review agent availability and schedules to evaluate staffing more agents.
- If there are items lower in priority that might have eligible agents, then contact Microsoft Support with your business scenario to determine if the block size can be increased.  
  > [!NOTE]
  > A block size that's larger than the default one might affect performance and accuracy of prioritization. Therefore, we recommend that you share your business scenario with the queue backlog and queue staffing projections to help Microsoft Support recommend the most optimized block size for your use case.

### Use skill-based routing to distribute work items to the most qualified agents

Skill-based routing lets your contact center distribute work items (conversations) to the agent who is most qualified to solve the issue. However, the need to use skill-based routing is determined by your business scenario.  

For example, to address the following scenario in your contact center, we recommend that you configure skill-based matching to assign work items to the agent who has the necessary skills to handle the cases:

- My service team supports two types of work items&mdash;order delivery issues and refund requests. However, most of the users will have the skills for one type only.
- During standard operations, the team will have two subgroups, and each group will handle one type of incoming work items.
- During peak load, certain users can handle work items from both types.

Skill-based routing helps reduce the number of queues to be managed in your organization.


## Next steps

[Overview of unified routing](overview-unified-routing.md)  
[FAQ about unified routing](unified-routing-faqs.md)  

### See also

[Provision unified routing](provision-unified-routing.md)  
[Set up skill-based routing](set-up-skill-based-routing.md)  
