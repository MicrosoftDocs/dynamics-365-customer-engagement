---
title: Set up skill-based routing in unified routing
description: Use the information to set up skill-based routing for unified routing in Customer Service.
ms.date: 12/18/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Set up skill-based routing in unified routing

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The steps to configure skill-based routing are as follows:

1. [Create a rating model](setup-skills-assign-agents.md#create-a-rating-model).
2. [Create skill types and skills](setup-skills-assign-agents.md#create-skill-types).
3. [Assign representative to skills](setup-skills-assign-agents.md#assign-agents-to-skill).
4. [Set exact or closest match as the default skill-matching algorithm for a workstream](create-workstreams.md#configure-work-distribution).
5. Choose one of the following skill-classification methods:
   - [Author logical classification rules to attach skills for a workstream](configure-work-classification.md#create-logical-skill-classification-rulesets).
   - [Set up intelligent skill finder model](set-up-isf-model.md) and [author machine learning-based classification rules to attach skills](configure-work-classification.md#create-machine-learning-based-skill-classification-rulesets).
6. [Choose out-of-the-box assignment method or author a custom assignment method for a queue](assignment-methods.md).
7. [Enable skill control for the representative](allow-agents-update-skills.md).

## How skills are matched

This section explains how the default skill match algorithm works when you set the value as exact match or closest match in a workstream. When the work classification skill rules attach skills and proficiency level, the assignment method matches the required skill with the skills of the customer service representative (service representative or representative). Then the system assigns the conversation to a representative based on the chosen skill criteria.

The default skill-matching algorithm works with the out-of-the-box assignment method only. If you use the custom assignment method, then you need to write the conditions to achieve skill-based routing. The rules written for custom assignment override the algorithm in the work distribution settings of the workstream.

You can achieve the following skill matching based on the business requirements:

- Exact skill match
- Closest or nearest skill match

When you select one of these skill-matching types, you must configure the skill attachment rules for the conversation to be routed to the correct representative.

### Exact match

In exact skill matching, the assignment logic searches for a representative with the required skills and proficiency.

Exact match filters all matched representatives whose rating value is greater than or equal to the required value. It then orders them based on the higher available capacity, capacity profile, or round robin as per the selected order by attribute.

If a representative isn't available with all the required skills and corresponding proficiency, then the conversation remains unassigned in the queue.

You can configure exact skill match in one of the following ways:

- In the work distribution settings of the workstream, set the value for **Default skill matching algorithm** as **Exact Match**. In the assignment method of the queue, choose highest capacity or round robin assignment method. The exact match algorithm isn't applicable to work items if yhe custom assignment method is applied to a queue. You need to write rules to achieve exact match for the custom assignment method.
- Create a custom assignment method and create rules on attribute user skills:

  In exact skill match, as part of custom assignment method, you can write rule conditions to enable assignment logic to search for representatives who match all the required skills or match all skills within a skill type. The matched representatives can be ordered using the following order by options:
  - Nearest proficiency
  - Nearest proficiency within skill type
  - Most proficient
  - Most proficient within skill type
  - Skill count
  - Skill count within skill type
  - Round robin
  - Capacity

  For example, order by nearest proficiency or most proficiency puts the representative with skill proficiency nearest to required proficiency or highest proficiency at the top, accordingly. It can be configured within a skill type as well.

  The following table lists a few examples of how skills are matched and results are ordered when the algorithm is "exact match".

  |Skills required|Representative characteristics|Scenario description|Rule condition|Order by/Result   |
  |----|----|---|----|----|
  |<ul><li> Cafe A-100 (Type: Product); Proficiency required: 2</li><li> Spanish (Type: Language); Proficiency required: 3 </li></ul> |<ul><li> Name: Carlos; Capacity: 100; Cafe A-100 (2); Spanish (3) </li><li> Name: Eric; Capacity: 200; Cafe A-100 (3); Spanish (4) </li></ul>| Exact match all skills | Agent.User skills. Exact match.All skills AND (optional) Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity| Choose from one of the Order by options: <ul><li> **Available capacity**: Eric</li><li> **Nearest Proficient**: Carlos</li><li> **Most Proficient**: Eric </li><ul>|
  |<ul><li> Cafe A-100 (Type: Product); Proficiency required: 2</li><li> Spanish (Type: Language); Proficiency required: 3 </li></ul> |<ul><li> Name: Carlos; Capacity: 100; Cafe A-100 (2); Spanish (3) </li><li> Name: Eric; Capacity: 200; Cafe A-100 (3); Spanish (4) </li></ul>|Exact match language skill only | Agent.User skills.Exact match.Skill type: Language AND (optional) Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options: <ul><li> **Available capacity**: Eric</li><li> **Nearest Proficient**: Carlos</li><li> **Most Proficient**: Eric </li><ul>|

### Closest Match

When it's more important to find a representative quickly rather than wait for a representative who has the exact required skills, unified routing provides you with an option to order the representatives using proficiency or skill count. Ordering helps achieve the goal of the closest skill match.

The Closest Match feature puts all representatives in an order that's based on their closeness to the required skill and proficiency. For example, if the required skills are four, then representatives with four skills are put on top (exact qualified), then representative with five skills (overqualified), followed by a representative with three skills (underqualified).

If no representative is available with any of the required skills, then the conversation might be assigned to a representative without any required skills.

You can achieve closest skill match in one of the following ways:

- In the work distribution settings of the workstream, set the value for **Default skill matching algorithm** as **Closest Match**. In the assignment method of the queue, choose highest capacity or round robin assignment method.

  In this scenario, where closest match is chosen as the skill-matching algorithm at the workstream level, and round robin or highest capacity assignment method is chosen, if more than one representative with same skill score is there, the system won't order them by round robin or highest capacity. The system continues to assign all the incoming work items to the same representative until other constraints, like capacity and presence, are satisfied.

- Create a custom assignment method and create order by using proficiency or skill count to achieve closest match.
  
  You need to select order by > Proficiency > All skills or skill type > Nearest Proficient.

  In closest skill matching as part of custom assignment method, you can choose from the following order by options:
  
  - Nearest proficiency
  - Nearest proficiency within skill type
  - Most proficiency
  - Most proficiency within skill type
  - Skill count
  - Skill count within skill type
  
   The following table lists a few examples of how the skills are matched and results are ordered when the default skill-matching algorithm is "closest match".

  |Skills required| Representative characteristics|Scenario description|Rule condition|Order by/Result|
  |----|----|---|----|----|
  |<ul><li>Cafe A-100 (Type: Product); Proficiency required :2</li><li>Coffee machine (Type: Product); Proficiency required: 3</li> <li>Spanish (Type: Language); Proficiency required: 3</li></ul> | <ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4); Spanish (1)</li><li>Name: Jamie; Cafe A-100 (1); Coffee machine (2); Spanish (1)</li> |Closest match all skills|Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options:<ul><li>Nearest Proficient: Carlos > Eric > Jamie </li><li>Most Proficient: Eric > Carlos > Jamie</li></ul> |
  |<ul><li>Café A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3 </li><li>Spanish (Type: Language); Proficiency required: 3</li> |<ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4); Spanish (1)</li><li>Name: Jamie; Cafe A-100 (1); Coffee machine (2); Spanish (1)</li>|Closest match product skill only |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options:<ul><li>Nearest Proficient: Carlos > Eric > Jamie </li><li>Most Proficient: Eric > Carlos > Jamie</li></ul>|
  |<ul><li>Café A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3 </li><li>Spanish (Type: Language); Proficiency required: 3</li> |<ul><li>Carlos Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4)</li><li>Name: Jamie; Cafe A-100 (1)</li>|Closest match with all skills using skill count |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Order by option: <br>Skill count: Carlos > Eric > Jamie|
  |<ul><li>Cafe A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3</li><li>Spanish (Type: Language); Proficiency required: 3</li></ul> |<ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4);</li><li>Name: Jamie; Cafe A-100 (1);</li></ul> |Closest match product skill only using skill count |Agent.PresenceStatus Equals Conversation.Work Stream.Allowed Presences AND Agent.Available capacity >= Conversation.Work Stream.Capacity|Order by:<br> Skill count: System randomly picks from Carlos or Eric|

> [!NOTE]
> We recommend that you use the same rating model across skills. However, if skills that belong to different rating models are there, then the system normalizes and calculates the skill scores.

### Related information

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Overview of unified routing](overview-unified-routing.md)  
[FAQ on unified routing](unified-routing-faqs.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]  
