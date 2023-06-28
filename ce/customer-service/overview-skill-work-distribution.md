---
title: Skill-based routing in Omnichannel for Customer Service
description: This topic provides information about the skill-based routing in the Omnichannel for Customer Service app to ensure that work items are assigned to the best-suited agent.
ms.date: 03/08/2023
ms.topic: overview
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Overview of skill-based routing

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!NOTE]
> The data such as but not limited to skills, rating model, and rating value that is created, updated, and used in Omnichannel for Customer Service is shared with other model-driven apps (Field Service and Project Service Automation) installed in your environment. Similarly, the data that are created, updated, and used in other model-driven apps are available for use in Omnichannel for Customer Service.

In the customer service center, your agents have different skill sets and abilities. The customers who reach out to the contact center might have different needs. Skill-based routing lets your customer service center distribute work items (conversations) to the agent who is most qualified to solve the issue. Skill-based routing improves the quality of customer service by automatically distributing work items to the agent who has the skills necessary to do the work.

You can also associate skills with bots and route work items using skill-based routing.

For example, for an incoming conversation related to **Xbox** from Spain, the skill required is knowledge of the **Xbox** product and **Spanish** language. Now, with skill-based routing, the system identifies the agents with those specific skills and distributes the conversation to one of them.

Skill-based routing allows you to easily match the conversation with the agent that's most proficient in dealing with it while maintaining the workload of the agent. You can associate distinct skills with each agent on your team and create rules to make sure that conversations matching those skills are always assigned to them.

You can also [enable your agents to update skills](allow-agents-update-skills.md) for the work items assigned to them. Agents can assess, add, remove, and update skills required for a particular work item, based on their abilities and experience. Now, if your organization uses machine learning model for skill prediction, you can use the updated skill information to retrain your skill finder model, so that the system is later able to efficiently and effectively route the work items (conversations) to the agent best suited for the work. More information: [Retrain skill finder model](set-up-skill-based-routing.md#retrain-the-model-iteratively)

## Value proposition of skill-based routing

- Assign conversations to agents who are best qualified to address the issue.

- Minimize overheads in queue maintenance.

- Use agent skills effectively.

- Enhance productivity.

- Effectively manage skills based on the CSAT and KPIs.

- Resolve conversations faster.

## Prerequisites

If your environment has scheduling solutions, then you must have version 9.0.0.0 or later.

## Videos

[Skill-based routing in Omnichannel for Customer Service](https://go.microsoft.com/fwlink/p/?linkid=2114717)

To view more videos on Omnichannel for Customer Service, see [Videos](videos.md).

### See also

[Set up skills and assign agents](setup-skills-assign-agents.md)  
[Attach skills to conversation](attach-skills.md)  
[Set up skill-based routing](set-up-skill-based-routing.md)  
[Model data tables as skills](model-tables-as-skills-ur.md)  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
