---
title: "Attach skill to an incoming conversation | MicrosoftDocs"
description: "Learn about how to attach skills to an incoming conversation in Omnichannel for Customer Service app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/06/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Attach skills to conversation

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Understand skill

In the portal, when a customer fills in the prechat survey questions, the system receives them as context variables. The system attaches these variables to the incoming conversation as a skill. The work distribution engine matches the skills of the agents. The skill is matched on exact or closest match. If the agent and conversation skills match, the work distribution engine assigns the conversation to the agent.

For example:

Bert Hair, is a customer from Spain, who uses **Xbox** product. Bert goes to **www.contoso.com** portal to initiate a chat with the Contoso customer service. In the pre-chat survey question, Bert chooses **Xbox**. Because Bert's geolocation is Spain, the system attaches **Xbox** as the product and the **Spanish** language as the skill to the conversation. Then, the work distribution engine assigns the conversation to an agent who matches the skill and language.

> [!Note]
> The system attaches the skills to a conversation based on the skill attachment rules.

## Match skills

When the skill attachment logic attaches a skill and proficiency level, the work distribution system considers the proficiency level as the minimum requirement. The system assigns the conversation to an agent only if the agent skills meet the criteria.

If the minimum proficiency requirements aren't met, then the system searches for the next proficiency level based on the skill-matching criteria.

The two skill-matching types are:

- Exact skill matching
- Closest skill matching
 
### Exact skill matching

In exact skill matching, the skill attachment logic identifies the skills and proficiency level that an agent should have. Next, the work distribution system searches for an agent with the required skills and proficiency level. 

The skill attachment logic identified proficiency level is set as minimum criteria while searching for the agents. 

- If the minimum proficiency level isn't met, then the system searches for a higher proficiency level. 

- If an agent isn't available with a higher proficiency level, then the conversation remains in the queue.

The following table describes how exact skill matching works for a single or multiple-skill scenario.

| Skill scenario | Skill & proficiency criteria  | Description |
|--------|---------------------|-----------------|
| Single | Xbox = 4 |<ul><li> First, the system searches for an agent with **Xbox** = **4**, the minimum criteria. </li> <li> When the criteria aren't met, the system searches for an agent with **Xbox** proficiency greater than **4**. </li> <li> If the criteria aren't met, then the conversation (work item) remains in the queue. </li></ul>|
| Multiple |Xbox = 4 <br> Spanish = 5 |<ul><li> First, the system searches for an agent with **Xbox** = **4** and **Spanish** = **5**, the minimum criteria for each. </li> <li> When the criteria aren't met, the system searches for an agent with **Xbox** proficiency greater than **4**, and **Spanish** proficiency greater than **5**.</li> <li> If the criteria aren't met, then the conversation (work item) remains in the queue. </li></ul> |

### Closest skill matching

In closest skill matching, the skill attachment logic identifies the skills and proficiency level that an agent should have to work on the conversation. Next, the work distribution system searches for an agent with the required skills and proficiency level. 

The skill attachment logic identified proficiency level is set as minimum criteria while searching for the agents, and when the system finds an agent with the necessary skill and proficiency level, it assigns the conversation to that agent.

- If the minimum proficiency criteria aren't met, then the system searches for a higher proficiency level. 

- If an agent isn't found with a higher proficiency level, then the system searches for a lower proficiency level than the minimum criteria. System will assign the conversation to an agent if atleast one of the skills is matching the criteria.

- When skill proficiency level criteria are not met, then the work distribution system assigns the conversation based on the capacity and availability of the agent.


The following table describes how exact skill matching works for a single- or multiple-skill scenario.

| Skill scenario | Skill & proficiency  | Description |
|--------|---------------------|-----------------|
| Single | Xbox = 4 | <ul><li>First, the system searches for an agent with Xbox = 4 as this is the minimum criteria. </li> <li> When the criteria aren't met, the system searches for an agent with **Xbox** proficiency greater than **4**. If found, the system assigns the conversation to the agent.</li> <li> When the greater than criteria aren't met, the system searches for an agent with **Xbox** proficiency lesser than **4**. If found, the system assigns the conversation to the agent.</li><li> When the criteria are not met, the system assigns the conversation based on the capacity and availability of the agent. </li></ul>|
| Multiple |Xbox = 4 <br> Spanish = 5 |<ul><li> First, the system searches for an agent with **Xbox** = **4** and **Spanish** = **5**, the minimum criteria. </li> <li> When the criteria aren't met, the system searches for an agent with **Xbox** proficiency greater than **4**, and **Spanish** proficiency greater than **5**. </li> <li> When the greater than criteria are not met, the system searches for an agent with **Xbox** proficiency lesser than **4**, and **Spanish** proficiency lesser than **5**. If found, the system assigns the conversation to the agent.</li> <li>  When the lesser than criteria isn't met, the system searches for an agent either with **Xbox** proficiency lesser than **4**, or **Spanish** proficiency lesser than **5**. If found, the system assigns the conversation to the agent.</li> <li> When the criteria aren't met, the system assigns the conversation based on the capacity and availability of the agent. </li> </ul>|

> [!Note]
> The system provides a score for the agents against each skill based on the above-mentioned scenarios. The system calculates the average score of the agent considering the skills and then, based on the score, assigns the conversation to the agents.

## Prerequisites

To attach skills, you need a workstream record. You can either create or use an existing workstream configuration.

## Create rules to attach a skill

1. Sign in to the **Omnichannel Administration** app.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select a workstream from the list.

4. Select the **Skill Attachment Rules** tab.

5. Select a skill-matching option for the **Matching Logic** field. You can select one of the following:

    - [Exact skill matching](attach-skills.md#exact-skill-matching)
    - [Closest skill matching](attach-skills.md#closest-skill-matching)

    To learn more, see [Match skills](attach-skills.md#match-skills).

6. Select **Add** to create a new skill rule. The **SKILL ATTACHMENT RULE** page opens.

7. Specify the following in the **New Skill Attachment Rule** page.

    | Field | Description | Value |
    |--------|----------|-------------------|
    | Name | Provide a name for the skill rule. | Xbox product and Spain location |
    | Description | Describe the skill rule. | This is a skill-matching rule for the Xbox product and Spain location. |

8. Set up the conditions. Select an **Entity**, **Related Attribute**, **Attribute**, **Operator**, and **Value**. For an entity, you can define rules based on related level 1 attributes.

    An example is as follows.

    | Entity | Related Attribute | Attribute | Operator | Value |
    |--------|----------|-------------------|-----------|---------|
    | Account (Conversation) | Primary contact (Contact) | Address 1: Country/Region | Equals | Spain |
    
9. Select **Save** to save the record. After you save, the **Skill** section appears.

10. Select **Add Existing Skill**. The **Quick Create: Attach Skill** pane appears.

11. Select a skill from the lookup menu, and select a proficiency level from the list, and then select **Save and Close** to save and add the skill to the grid.

    > [!div class=mx-imgBorder] 
    > ![Attach skill to a conversation](media/attach-skill1.png "Attach skill")

    If the condition (criteria) matches, then the omnichannel system attaches the skill.

12. Select **Save**. After you save, the rule appears in the **Attachment Rules** section of the workstream.

    > [!div class=mx-imgBorder] 
    > ![Add skill rule to workstream](media/attach-skill2.png "Add skill rule to workstream")

### See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Enable skill-based routing and create rating model](enable-skill-routing-create-rating-model.md)  
[Set up skills and assign agents](setup-skills-assign-agents.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]