---
title: Use best practices to set up unified routing in Customer Service
description: Learn best practices for setting up and managing unified routing in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.date: 09/30/2026
ms.custom: bap-template
---

# Use best practices to set up unified routing in Customer Service

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Use these best practices to deploy and manage unified routing and to address common implementation questions.

## Set up unified routing

### Verify service limits and default quotas

Dynamics 365 Customer Service relies on shared cloud resources for data and processing. Check the service limits and default quotas for the resources before you provision unified routing. To increase an adjustable limit, contact Microsoft Support to find out whether an increase is available. Learn more in [Service quotas](../implement/service-quotas.md).

## Manage users

Use the following guidance to set up users in bulk:

- Follow the recommended sequence for bulk user setup with Dataverse API calls.
- Limit the number of change requests when setting up users in bulk using Dataverse API calls.

### Follow a specific sequence to set up users in bulk using Dataverse API calls

To set up users in bulk, follow these steps:

1. Create or import users to enable them.
1. Add the users to queues. Learn more in [Create and manage queues](queues-omnichannel.md).
1. Create bookable resources. Learn more in [Manage users](users-user-profiles.md#manage-users-using-the-classic-experience).
1. Add skills. Learn more in [Set up skills](setup-skills-assign-agents.md).
1. Assign the capacity profiles. Learn more in [Create and manage capacity profiles](capacity-profiles.md).
1. Assign the required roles. Learn more in [Assign roles](../implement/add-users-assign-roles.md).

If you don't follow the recommended order, user information might be inconsistent. For example, users, skills, or capacity profiles might be missing.

### Limit change requests for bulk user setup with Dataverse API calls

Customer Service lets you make API calls to set up users in bulk. A change request is an add or update operation, such as defining one skill, capacity profile, or role for a user.

To help the system process changes efficiently and avoid throttling, submit 500 change requests every 15 minutes. If you exceed this recommended rate for bulk updates, user data might be inconsistent after the update finishes. For example, skills might not be updated as expected.

For example, in a contact center with 1,000 customer service representatives (service representatives or representatives), you need to assign each representative two skills, one capacity profile, and one role.

Based on our recommendation of 500 requests per 15 minutes, make these requests in eight batches as follows:

|Change request type|Number of requests|Number of batches|
|-----------|---------|------------|
|Two skills per service representative|250 requests per batch|Four|
|One capacity profile per service representative|500 requests per batch|Two|
|One role per service representative |500 requests per batch|Two|

Learn how to use the API in [Use the Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/overview).

### Monitor service representative capacity

You can view a representative's presence, current conversations, conversation sentiment, and available capacity across capacity profiles. Use the **Agents insights** report to monitor the representative's capacity. You can reset capacity at the end of the workday or immediately after a work item is closed. Learn more in [Create and manage capacity profiles](capacity-profiles.md).

Depending on how you implement capacity, use the following tables to review representative status and status history.

- **Capacity profiles**
  - [Agent capacity update history (msdyn_agentcapacityupdatehistory) table](../../developer/reference/entities/msdyn_agentcapacityupdatehistory.md)
  - [Agent Capacity Profile Unit (msdyn_agentcapacityprofileunit) table](../../developer/reference/entities/msdyn_agentcapacityprofileunit.md)

- **Unit-based capacity profiles**
  - [Agent Status (msdyn_agentstatus) table](../../developer/reference/entities/msdyn_agentstatus.md)
  - [Agent Status history (msdyn_agentstatushistory) table](../../developer/reference/entities/msdyn_agentstatushistory.md)

### Use representative attributes to optimize workload

To manage representative availability and workload:

- Configure a default presence status for representatives at the start of their workday to help manage their availability and workload. Learn more in [Create and manage users and user profiles](users-user-profiles.md).
- If no default presence is set, the system automatically sets the presence to **Available** when they sign in.
- Ensure that representatives and supervisors don't manually change the presence status, so assignment cycles can run without interruption.
- Configure assignment rules to route and assign cases and conversations based on shift schedules imported from external workforce management (WFM) systems. Verify schedules in advance to avoid routing tasks to off-duty representatives and reduce the risk of delays. Learn more in [Configure routing based on external schedules](configure-routing-on-agent-calendar.md).

## Manage queues

- Manage automatic assignment if the top 100 work items have extended wait times.
- Use skill-based routing to distribute work items to the most qualified service representatives.
- Set up one or more queues with skill matching to manage different types of work.

### Use classification rules for enhanced assignment performance

Complex rules and conditions in prioritization rulesets add latency to the prioritization and assignment cycles. These assignment cycles are iterative and run until the system finds a service representative and assigns the work item. 

To simplify management and reduce assignment latency, use workstream classification rules to check for static values and categorize conversations. For example, during classification, you can check once whether a conversation is from a VIP customer or concerns an urgent query that requires immediate attention. Set an attribute in the classification rule, and then use that attribute in route-to-queue and prioritization rules.

### Manage auto-assignment if work items have extended wait times

The auto-assignment process in unified routing matches incoming work items with the best-suited service representatives based on the configured assignment rules. This continuous process is made up of multiple assignment cycles. Learn about the auto-assignment process in [How automated assignment works](assignment-methods.md#how-automated-assignment-works).

If representatives are unavailable to receive work items for an extended period, consider the following options:

- To reduce wait times, use overflow management to handle high workloads, or use custom assignment rules to gradually relax assignment criteria and expand the pool of eligible representatives.
- Review representative availability and schedules to determine whether additional staffing is needed.

### Use skill-based routing to distribute work items to the most qualified representatives

Skill-based routing lets your contact center distribute work items (conversations) to the service representative who is most qualified to solve the issue. Whether you need skill-based routing depends on your business scenario.  

For the following contact center scenario, we recommend skill-based matching to assign work items to representatives with the required skills:

- Your service team handles two types of work items: order delivery issues and refund requests. Most representatives have the skills to handle only one type.
- During standard operations, the team has two subgroups, and each group handles one type of incoming work items.
- During peak periods, some representatives can handle both types of work items.

Skill-based routing helps reduce the number of queues your organization needs to manage.

## Next steps

[Overview of unified routing](overview-unified-routing.md)  
[FAQ about unified routing](unified-routing-faqs.md)  

## Related information

[Provision unified routing](provision-unified-routing.md)  
[Set up skill-based routing](set-up-skill-based-routing.md)  
