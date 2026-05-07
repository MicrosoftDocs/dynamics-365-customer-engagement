---
title: Understand how skill match algorithm works in unified routing
description: Understand how skill match works in unified routing in Customer Service and Dynamics 365 Contact Center.
ms.date: 05/07/2026
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Understand how skill match algorithm works in unified routing

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The steps to configure skill-based routing are as follows:

1. [Create a rating model](setup-skills-assign-agents.md#create-a-rating-model).
2. [Create skill types and skills](setup-skills-assign-agents.md#create-skill-types).
3. [Assign representatives to skills](setup-skills-assign-agents.md#assign-representatives-to-skill).
4. [Set exact or closest match as the default skill-matching algorithm for a workstream](create-workstreams.md#configure-work-distribution).
5. Choose one of the following skill-classification methods:
   - [Author logical classification rules to attach skills for a workstream](configure-work-classification.md#create-logical-skill-classification-rulesets).
   - [Set up intelligent skill finder model](set-up-isf-model.md) and [author machine learning-based classification rules to attach skills](configure-work-classification.md#create-machine-learning-based-skill-classification-rulesets).
6. [Choose out-of-the-box assignment method or author a custom assignment method for a queue](assignment-methods.md).
7. [Enable skill control for the representative](allow-agents-update-skills.md).

## How skills are matched

This section explains how the skill match algorithm works when you set the value to exact match or closest match. 

- When the work classification skill rules attach skills and proficiency level to a work item, the assignment method finds the customer service representative with the skills that match the required skills of the work item. 
- For out-of-the-box assignment strategy, the system assigns a conversation to a service representative who meets the selected skill criteria and also satisfies capacity and presence requirements. With custom assignment, representatives must meet the required skills and any other configured rules.

The default skill-matching algorithm configured in the workstream is supported only with the out-of-the-box assignment method. If you use the custom assignment method, then you need to write the conditions to achieve skill-based routing. The rules written for custom assignment override the algorithm in the work distribution settings of the workstream.

You can achieve the following skill matching based on the business requirements:

- Exact skill match
- Closest or nearest skill match

> [!Important]
> When you select one of these skill-matching types, you must configure the skill attachment rules for the conversation to be routed to the correct representative.

### Exact match

In exact skill matching, the assignment logic searches for a representative with the required skills and proficiency.

Exact match filters all matched representatives whose skill rating value is greater than or equal to the required value, and then orders them based on the selected out-of-the-box assignment strategy: highest capacity, round robin, or most idle routing. For custom assignment, select the **Order by** attribute. 

If a representative isn't available with all the required skills and corresponding proficiency, then the conversation remains unassigned in the queue.

You can configure exact skill match in one of the following ways:

- **Out-of-the-box assignment**: In the work distribution settings of the workstream, set the value for **Default skill matching algorithm** as **Exact Match**. In the assignment method of the queue, choose highest capacity or round robin assignment method.
When a workstream is configured with "exact match" skill matching and an out-of-the-box assignment method is set, if multiple agents possess the exact skills required for a work item, the system ranks them based on the assignment method. The work item is then assigned to the representative based on this ordering.
- **Custom assignment**: In the custom assignment rule conditions, create a rule with **User skills**, select **Exact match** and then select **All skills** or a specific skill type. Use **All skills** if you want to find an agent matching all the skills that are attached to the work item. This lets the assignment logic find representatives who either match all required skills or match all skills within a selected skill type.
The exact match algorithm configured in workstream isn't applicable if custom assignment method is applied to a queue. You need to write rules to achieve exact match for the custom assignment method. 

If more than one matching agent is found, the matched agents can be ordered using the following order by options: 
  - Nearest proficiency
  - Nearest proficiency within skill type
  - Most proficient
  - Most proficient within skill type
  - Skill count
  - Skill count within skill type
  - Round robin
  - Capacity

  The following table lists a few examples of how skills are matched and results are ordered when the algorithm is "exact match".

  |Skills required|Representative characteristics|Scenario description|Rule condition|Order by/Result   |
  |----|----|---|----|----|
  |<ul><li> Cafe A-100 (Type: Product); Proficiency required: 2</li><li> Spanish (Type: Language); Proficiency required: 3 </li></ul> |<ul><li> Name: Carlos; Capacity: 100; Cafe A-100 (2); Spanish (3) </li><li> Name: Eric; Capacity: 200; Cafe A-100 (3); Spanish (4) </li></ul>| Exact match all skills | Agent.User skills. Exact match. All skills AND (optional) Agent.PresenceStatus Equals Conversation.Work Stream. Allowed Presences AND Agent. Available capacity >= Conversation.Work Stream.Capacity| Choose from one of the Orders by options: <ul><li> **Available capacity**: Eric</li><li> **Nearest Proficient**: Carlos</li><li> **Most Proficient**: Eric </li><ul>|
  |<ul><li> Cafe A-100 (Type: Product); Proficiency required: 2</li><li> Spanish (Type: Language); Proficiency required: 3 </li></ul> |<ul><li> Name: Carlos; Capacity: 100; Cafe A-100 (2); Spanish (3) </li><li> Name: Eric; Capacity: 200; Cafe A-100 (3); Spanish (4) </li></ul>|Exact match language skill only | Agent. User skills. Exact match. Skill type: Language AND (optional) Agent.PresenceStatus Equals Conversation.Work Stream. Allowed Presences AND Agent. Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options: <ul><li> **Available capacity**: Eric</li><li> **Nearest Proficient**: Carlos</li><li> **Most Proficient**: Eric </li><ul>|

### Closest Match

When it's more important to find a representative quickly rather than wait for a representative who has the exact required skills, unified routing provides you with an option to order the representatives using proficiency or skill count. Ordering helps achieve the goal of the closest skill match.

The Closest Match feature puts all representatives in an order that's based on their closeness to the required skill and proficiency. For example, if the work item requires four skills, then representatives with four skills are put on top (exact qualified), then representative with five skills (overqualified), followed by a representative with three skills (underqualified).

If no representative is available with any of the required skills, then the conversation might be assigned to a representative without any required skills.

You can achieve closest skill match in one of the following ways:

- **Out-of-the-box assignment**: In the work distribution settings of the workstream, set the value for **Default skill matching algorithm** as **Closest Match**. In the assignment method of the queue, choose one assignment method among - highest capacity, round robin, or most idle routing.  

When **Closest Match** is selected at the workstream level and an out-of-the-box assignment method is used, if multiple representatives have the same skill score, the system ranks them according to the selected assignment method, then assigns the work item based on the order.

- **Custom assignment**: Create a custom assignment method and create order by using proficiency or skill count to achieve closest match. For closest match, no custom assignment rule needs to be configured.  

To achieve closest match, select order by > Proficiency > All skills or skill type > Nearest Proficient.

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
  |<ul><li>Cafe A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3</li> <li>Spanish (Type: Language); Proficiency required: 3</li></ul> | <ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4); Spanish (1)</li><li>Name: Jamie; Cafe A-100 (1); Coffee machine (2); Spanish (1)</li> |Closest match all skills|Agent.PresenceStatus Equals Conversation.Work Stream. Allowed Presences AND Agent. Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options:<ul><li>Nearest Proficient: Carlos > Eric > Jamie </li><li>Most Proficient: Eric > Carlos > Jamie</li></ul> |
  |<ul><li>Café A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3 </li><li>Spanish (Type: Language); Proficiency required: 3</li> |<ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4); Spanish (1)</li><li>Name: Jamie; Cafe A-100 (1); Coffee machine (2); Spanish (1)</li>|Closest match product skill only |Agent.PresenceStatus Equals Conversation.Work Stream. Allowed Presences AND Agent. Available capacity >= Conversation.Work Stream.Capacity|Choose from one of the order by options:<ul><li>Nearest Proficient: Carlos > Eric > Jamie </li><li>Most Proficient: Eric > Carlos > Jamie</li></ul>|
  |<ul><li>Café A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3 </li><li>Spanish (Type: Language); Proficiency required: 3</li> |<ul><li>Carlos Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4)</li><li>Name: Jamie; Cafe A-100 (1)</li>|Closest match with all skills using skill count |Agent.PresenceStatus Equals Conversation.Work Stream. Allowed Presences AND Agent. Available capacity >= Conversation.Work Stream.Capacity|Order by option: <br>Skill count: Carlos > Eric > Jamie|
  |<ul><li>Cafe A-100 (Type: Product); Proficiency required: 2</li><li>Coffee machine (Type: Product); Proficiency required: 3</li><li>Spanish (Type: Language); Proficiency required: 3</li></ul> |<ul><li>Name: Carlos; Cafe A-100 (2); Coffee machine (3); Spanish (3)</li><li>Name: Eric; Cafe A-100 (5); Coffee machine (4);</li><li>Name: Jamie; Cafe A-100 (1);</li></ul> |Closest match product skill only using skill count |Agent.PresenceStatus Equals Conversation.Work Stream. Allowed Presences AND Agent. Available capacity >= Conversation.Work Stream.Capacity|Order by:<br> Skill count: System randomly picks from Carlos or Eric|

> [!NOTE]
> We recommend that you use the same rating model across skills. However, if skills that belong to different rating models are there, then the system normalizes and calculates the skill scores.

### Related information

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Overview of unified routing](overview-unified-routing.md)  
[FAQ on unified routing](unified-routing-faqs.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]  
