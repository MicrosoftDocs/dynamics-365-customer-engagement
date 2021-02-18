---
title: "Skill-based routing in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the skill-based routing in Omnichannel for Customer Service app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 02/10/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Overview of skill-based routing

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!Note]
> The data such as but not limited to skills, rating model, and rating value that is created, updated, and used in Omnichannel for Customer Service is shared with other model-driven apps (Field Service and Project Service Automation) installed in your environment. Similarly, the data that are created, updated, and used in other model-driven apps are available for use in Omnichannel for Customer Service.

In the customer service center, your agents have different skillsets and abilities. The customers who reach out to the contact center might have different needs. Skill-based routing lets your customer service center distribute the work item (conversation) to the agent who is best-qualified to solve the issue. Skill-based routing improves the quality of customer service by automatically distributing the work items to the agent who has the skills necessary to do the work.

You can associate skills to bots also and route work items using skill-based routing.

For example, for an incoming conversation related to **Xbox** from Spain, the skill required is knowledge of the **Xbox** product and **Spanish** language. Now, with skill-based routing, the system identifies the agents with those specific skills and distributes the conversation to one of them.

Skill-based routing allows you to easily match the conversation to the agent most proficient in dealing with it while maintaining the workload of the agent. You can associate distinct skills with each agent on your team and create rules to make sure that conversations matching those skills are always assigned to them.

## Value proposition of skill-based routing

- Assign conversations to agents who are best qualified to address the issue.

- Minimize overhead in queue maintenance.

- Effective use of agents skills.

- Enhanced productivity.

- Effective management of skills based on the CSAT and KPIs.

- Faster conversation resolution.

## Understand skill-based routing

   > [!div class=mx-imgBorder] 
   > ![Skill-based routing](media/skill-based-routing1.png "Skill-based routing")

When a customer initiates a conversation, the following happens:

- Based on the skill attachment rules, the system attaches the skills to the conversation.
- Based on the routing rules, the system routes the conversation to the appropriate queue.
- Now, the work distribution system starts matching the agents' skills with those skills attached to the conversation. After finding a match as per the match criteria (exact or closest), the work distribution engine assigns the conversation to the agent.

## Prerequisites

- You must use the latest version of Omnichannel for Customer Service.
- If your environment has scheduling solutions, then it must be version 9.0.0.0 or later.

## Skill-based routing overview steps

   > [!div class=mx-imgBorder]
   > ![Skill-based routing setup](media/skill-based-routing2.png "Skill-based routing setup")

- [Step 1: Enable skill-based routing](enable-skill-routing-create-rating-model.md#enable-skill-based-routing)
- [Step 2: Create rating model](enable-skill-routing-create-rating-model.md#create-rating-model)
- [Step 3: Create skill type](setup-skills-assign-agents.md#create-skill-type)
- [Step 4: Create skills](setup-skills-assign-agents.md#create-skills)
- [Step 5: Assign agents to skill](setup-skills-assign-agents.md#assign-agents-to-skill)
- [Step 6: Create rules to attach skill](attach-skills.md#create-rules-to-attach-a-skill)

## Videos

[Skill-based routing in Omnichannel for Customer Service](https://go.microsoft.com/fwlink/p/?linkid=2114717)

To view more videos on Omnichannel for Customer Service, see [Videos](videos.md).

### See also

[Enable skill-based routing and create rating model](enable-skill-routing-create-rating-model.md)  
[Set up skills and assign agents](setup-skills-assign-agents.md)  
[Attach skills to conversation](attach-skills.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]