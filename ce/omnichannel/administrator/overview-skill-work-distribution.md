---
title: "Skill-based routing in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the skill-based routing in Omnichannel for Customer Service app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 81343ED1-4115-4D6A-874D-2282F0BFA3A9
ms.custom: 
---
# Overview of skill based routing

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

In the customer service center, your agents have different skill sets and abilities. The customers who reaches out to the contact center might have different needs. Skills based routing lets your customer service center distribute the work item (conversation) to the best-qualified agent who is best able to solve the issue. Skills-based routing improves the quality of customer service by automatically distributing the work items to the agent who has the skills necessary to do the work.

For example, for an incoming conversation related to **Xbox** and **Surface** hardware, the skill required is knowledge of **Xbox** and **Surface** products. Now, with skill based routing, the system identifies the agents with specific skill and the distributes the conversation solve it.

Skill based routing allows you to easily match conversation to the agent most proficient in dealing with them in your group, while simultaneously maintaining the load that the agent has to work with. You can associate distinct skills to each agent on your team and create rules to make sure that conversations matching those skills are always assigned to them.

## Value proposition of skill based routing

- Assign conversations to agents who are best qualified to address the issue.

- Minimize overhead in queue maintenance.

- Effective utilization of agents skills.

- Enhanced productivity.

- Effective management of skills based on the CSAT and KPIs.

- Faster conversation resolution.

## Understand skill based routing

When a customer initiates a conversation the following happens:

 - Based on the context variables, the system attaches the skills to the conversation. 
 - Based on the routing rules, the system routes the conversation to the appropriate queue.
 - Now, the work distribution engines starts matching the skills against the attached skill.
 - After finding a match as per the match criteria (exact or closest), the work distribution engine assigns the conversation to the agent.

   > [!div class=mx-imgBorder] 
   > ![Skill based routing](../media/skill-based-routing1.png "Skill based routing")

## Prerequisites

- You must use the latest Omnichannel for Customer Service (October 2019 update).
- If your environment has scheduling solutions, then the it must have a version not lower than \<version\> and not higher than \<version\>.

## Skill based routing overview steps

   > [!div class=mx-imgBorder] 
   > ![Skill based routing set up](../media/skill-based-routing2.png "Skill based routing set up")

- [Step 1: Enable skill based routing](enable-skill-routing-create-rating-model.md#enable-skill-based-routing)
- [Step 2: Create rating model](enable-skill-routing-create-rating-model.md#create-rating-model)
- [Step 3: Create skill type](setup-skills-assign-agents.md#create-skill-type)
- [Step 4: Create skills](setup-skills-assign-agents.md#create-skills)
- [Step 5: Assign agent to skills](setup-skills-assign-agents.md#assign-agents-to-skill)
- [Step 6: Create rules to attach skill](attach-skills.md#create-rules-to-attach-skill)
- [Step 7: Enable skill based routing in queues](attach-skills.md#enable-the-queues-for-skill-based-routing)


## See also

[Enable skill based routing and create rating model](enable-skill-routing-create-rating-model.md)

[Set up skills and assign agents](setup-skills-assign-agents.md)

[Attach skills to conversation](attach-skills.md)