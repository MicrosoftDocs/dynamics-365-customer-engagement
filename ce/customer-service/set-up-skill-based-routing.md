---
title: "Set up skill-based routing | MicrosoftDocs"
description: "Use the information to set up skill-based routing for unified routing in Customer Service."
ms.date: 06/02/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Set up skill-based routing for unified routing

The steps to configure skill-based routing are as follows:

1. [Create a rating model](setup-skills-assign-agents.md#create-a-rating-model).
2. [Create skill types and skills](setup-skills-assign-agents.md#create-skill-types).
3. [Assign agents to skills](setup-skills-assign-agents.md#assign-agents-to-skill).
4. [Set exact or closest match as the default skill matching algorithm for a workstream](create-workstreams.md#configure-work-distribution).
5. Author classification rules to attach skills for a workstream
6. Choose out of box assignment method or author a custom assignment method for a queue
7. Enable skill control for the agent.

You can also configure skill-based routing using the machine learning (ML) model. More information: 

## Match skills

When the work classification skill rules attach skills and proficiency level, the assignment method matches the required skill with the skills of the agent. The system assigns the conversation to an agent based on the skill criteria chosen.

You can achieve the skill matching based on the business requirements:

- Exact skill matching
- Closest or nearest skill matching

### Exact match

In exact skill matching, the assignment logic searches for an agent with the required skills and proficiency.

Exact match filters all matched agents whose rating value is greater than or equal to the required value, and then orders them based on the higher available capacity or capacity profile or round robin as per the chosen assignment method.

If an agent isn't available with all the required skills and corresponding proficiency, then the conversation remains unassigned in the queue.

You can configure exact skill match in one of the following ways:

- In the work distribution settings of the workstream, set the value for **Default skill matching algorithm** as **Exact Match**. In the assignment method of the queue, choose one of the out-of-the-box assignment methods (highest capacity or round robin). The exact match algorithm does not apply to work items if custom assignment method is applied to a queue.
- Create a custom assignment method and create rules on attribute user skills:

  In exact skill match, as part of custom assignment method, you can write rule conditions to enable assignment logic to search for agents who match all the required skills or match all skills within a skill type. The matched agents can be ordered using various the following order by options:
  - Nearest proficiency
  - Nearest proficiency within skill type
  - Most proficient
  - Most proficient within skill type
  - Skill count
  - Skill count within skill type
  - Round robin
  - Capacity

  For example, order by nearest proficiency or most proficiency will have the agent with skill proficiency nearest to required proficiency or highest proficiency at the top accordingly. It can be configured within a skill type as well.

  |Skills required|Agents|Scenario description|Rule condition|Order by/Result|
  |----|----|---|----|----|
  |<ul><li> Cafe A-100 (Type: Product); Proficiency required: 2</li><li> Spanish (Type: Language); Proficiency required: 3 </li></ul> |<ul><li> Carlos; Capacity: 100; Cafe A-100 (2); Spanish (3) </li><li> Eric; Capacity: 200; Cafe A-100 (3); Spanish (4) </li></ul>| Exact match all skills |Agent.User skills.Exact match.All skills AND (optional) Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the Order by: <ul><li> Available capacity: Eric</li><li> Nearest Proficient: Carlos</li><li> Most Proficient: Eric </li><ul>|
  |<ul><li> Cafe A-100 (Type: Product); Proficiency required: 2</li><li> Spanish (Type: Language); Proficiency required: 3 </li></ul> |<ul><li> Carlos; Capacity: 100; Cafe A-100 (2); Spanish (3) </li><li> Eric; Capacity: 200; Cafe A-100 (3); Spanish (4) </li></ul>|Exact match language skill only |Agent.User skills.Exact match.Skill type: Language AND(optional) Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by: <ul><li> Available capacity: Eric</li><li> Nearest Proficient: Carlos</li><li> Most Proficient: Eric </li><ul>|
  ||||||

### Closest Match

For business scenarios where finding agent at the earliest is more important than waiting for agent with exact required skills; unified routing provides with an option to order agents using proficiency or skill count and thereby achieving closest skill match.

Closest match orders all agents based on their closeness to the required skill and proficiency. For example, if the required skills are four, then agents with four skills will be put on top (exact qualified), then agent with five skills and so on (overqualified) and then agent with three skills and so on (under qualified).

If an agent isn't available with any of the required skills, then the conversation may get assigned to an agent without any required skills.

You can achieve closest skill match in one of the following ways:

- In the work distribution settings of the workstream, set the value for **Default skill matching algorithm** as **Closest Match**. In the assignment method of the queue, choose one of the out-of-the-box assignment methods (highest capacity or round robin).

  In this scenario where closest match is chosen as the skill matching algorithm at work stream level, and one of the out of box assignment method is chosen (round robin or highest capacity); if more than one agents with same skill score are there; system won't order them by round robin or highest capacity. System will keep assigning all the incoming work items to the same agent till other constraints like capacity and presence are being satisifed.

- Create a custom assignment method and create order by using proficiency or skill count to achieve closest match.
  
  You need to select order by > Proficiency > All skills or skill type > Nearest Proficient.

  In closest skill matching as part of custom assignment method, you can choose from the following order by options:
  
  - Nearest proficiency
  - Nearest proficiency within skill type
  - Most proficiency
  - Most proficiency within skill type
  - Skill count
  - Skill count within skill type
  
  |Skills required|Agents|Scenario description|Rule condition|Order by/Result|
  |----|----|---|----|----|
  |<ul><li>Cafe A-100 (Type: Product); Proficiency required :2</li><li>Coffee machine (Type: Product); Proficiency required: 3</li> <li>Spanish (Type: Language); Proficiency required: 3</li></ul> | <ul><li>Carlos Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Eric Cafe A-100 (5); Coffee machine (4); Spanish (1)</li><li>Jamie Cafe A-100 (1); Coffee machine (2); Spanish (1)</li> |Closest match all skills|Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by:<ul><li>Nearest Proficient: Carlos > Eric > Jamie </li><li>Most Proficient: Eric > Carlos > Jamie</li></ul> |
  |<ul><li>Café A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3 </li><li>Spanish (Type: Language); Proficiency required: 3</li> |<ul><li>Carlos Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Eric Cafe A-100 (5); Coffee machine (4); Spanish (1)</li><li>Jamie Cafe A-100 (1); Coffee machine (2); Spanish (1)</li>|Closest match product skill only |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by:<ul><li>Nearest Proficient: Carlos > Eric > Jamie </li><li>Most Proficient: Eric > Carlos > Jamie</li></ul>|
  |<ul><li>Café A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3 </li><li>Spanish (Type: Language); Proficiency required: 3</li> |<ul><li>Carlos Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Eric Cafe A-100 (5); Coffee machine (4)</li><li>Jamie Cafe A-100 (1)</li>|Closest match with all skills using skill count |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Order by: <br>Skill count: Carlos > Eric > Jamie|
  |<ul><li>Cafe A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3</li><li>Spanish (Type: Language); Proficiency required: 3</li></ul> |<ul><li>Carlos Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Eric Cafe A-100 (5); Coffee machine (4);</li><li>Jamie Cafe A-100 (1);</li></ul> |Closest match product skill only using skill count |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Order by:<br> Skill count: 
System will randomly pick from Carlos or Eric|
|||||

> [!NOTE]
> We recommend that the same rating model be used across skills. However, if skills belonging to different rating models are there, the system will normalize and calculate the skill scores.

### 

