---
title: "Attach skill to an incoming conversation | MicrosoftDocs"
description: "Learn about how to attach skills to an incoming conversation in Omnichannel for Customer Service app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 44298261-18A8-438C-923A-4BB4D18406F9
ms.custom: 
---

# Attach skills to conversation

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Understand skill

In the portal, when the customer fills the pre-chat survey questions, the system receives these as context variables. The omnichannel system attaches these variables to the incoming conversation as a skill, and then the work distribution engine matches the skills of the agents based on the exact or closest match criteria. Once the skill attached to the conversation matches with the skill of an agent, then the work distribution engine assigns the conversation to that agent.

For example:

Ian Madera, a customer from Spain, uses **Xbox** product and goes to **www.contoso.com** portal to initiate a chat with the Contoso contact center. The pre-chat survey question prompts Ian Madera to choose a device, and Ian Madera chooses **Xbox**. As Ian Madera's geolocation is Spain, the Omnichannel system attaches the **Xbox** product and **Spanish** language as the skill to the conversation. After the skill attachment, the work distribution engine assigns the conversation to an agent with skill as **Xbox** and **Spanish**.

> [!Note]
> The system attaches the skills to a conversation based on the skill attachment rules.

## Match skills

When the skill attachment logic attaches a skill with a certain proficiency level, the work distribution system considers the attached proficiency level as the minimum criteria, and assign  the conversation to an agent only if this criteria is met.

If the minimum proficiency criteria is not met, then the system searches for the next best proficiency level based on the skill matching criteria.

The two skill matching types are as follows:

- Exact skill matching
- Closest skill matching
 
### Exact skill matching

In the exact skill matching, if the minimum proficiency criteria is not met, then the system always searches for a proficiency level greater than the minimum criteria.

When the proficiency level criteria is not met, then the work distribution system doesn't assign the conversation to any agent and the conversation remains in the queue.

For example,

Understand how the exact skill matching works for single or multiple skill scenario.

| Skill scenario | Skill & proficiency criteria  | Description |
|--------|---------------------|-----------------|
| Single | Xbox = 4 |<ul><li> First, the system searches for an agent with **Xbox** = **4** as this is the minimum criteria. </li> <li> When the criteria is not met, the system searches for an agent with **Xbox** proficiency greater than **4**. </li> </ul>|
| Multiple |Xbox = 4 <br> Spanish = 5 |<ul><li> First, the system searches for an agent with **Xbox** = **4** and **Spanish** = **5** as these are the minimum criteria. </li> <li> When the criteria is not met, the system searches for an agent with **Xbox** proficiency greater than **4** and **Spanish** proficiency greater than **5**.</li> </ul> |

In single or multiple skill scenarios, if the criteria is not, then the conversation (work item) remains in the queue.

### Closest skill matching

In the closest skill matching, if the minimum proficiency criteria is not met, then the system always searches for a proficiency level greater than the minimum criteria.

In the greater than the minimum criteria, if the proficiency level is not met, then the system searches for a proficiency level lower than the minimum criteria.

When skill proficiency level criteria is not met, then the work distribution system assigns the conversation based on the capacity and availability of the agent.

For example,

Understand how the exact skill matching works for single or multiple skill scenario.

| Skill scenario | Skill & proficiency  | Description |
|--------|---------------------|-----------------|
| Single | Xbox = 4 | <ul><li>First, the system searches for an agent with Xbox = 4 as this is the minimum criteria. </li> <li> When the criteria is not met, the system searches for an agent with **Xbox** proficiency greater than **4**. If found, the system assigns the conversation to the agent.</li> <li> When the greater than criteria is not met, the system searches for an agent with **Xbox** proficiency lesser than **4**. If found, the system assigns the conversation to the agent.</li></ul>|
| Multiple |Xbox = 4 <br> Spanish = 5 |<ul><li> First, the system searches for an agent with **Xbox** = **4** and **Spanish** = **5** as these are the minimum criteria. </li> <li> When the criteria is not met, the system searches for an agent with **Xbox** proficiency greater than **4** and **Spanish** proficiency greater than **5**. </li> <li> When the greater than criteria is not met, the system searches for an agent with **Xbox** proficiency lesser than **4** and **Spanish** proficiency lesser than **5**. If found, the system assigns the conversation to the agent.</li> </ul>|

## Prerequisites

To attach skills, you need a workstream record. Either you can create or use an existing workstream configuration. 

## Create rules to attach skill

1. Sign in to the **Omnichannel for Administrator** app.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select a work stream from the list.

4. Select the **Skill Attachment Rules** tab.

5. Select a skill matching option for the **Matching Logic** field. You can select one of the following:

    - Exact Skill Matching
    - Closest Skill Matching

6. Select **+ Add** to new a skill rule. The **SKILL ATTACHMENT RULE** page opens.

7. Specify the following in the **New Skill Attachment Rule** page.

    | Field | Description | Value |
    |--------|----------|-------------------|
    | Name | Provide a name to the skill rule. | Xbox product and Spain location |
    | Description | Provide a description about the skill rule. | This is a skill matching rule for the Xbox product and Spanish location. |

8. Set up the condition. Select an **Entity**, **Attribute**, and **Operator**. <br> For example, 

    | Entity | Attribute | Operator | Value |
    |-----------|-----------------|---------------------|---------------------|
    | Live Chat Context (Conversation) | Country/Region | Contains | Spain |

9. Select **Save** to save the record. After you save, the **Skill** section appears.

9. Select **+ Add Existing Skill**. The **Quick Create: Attach Skill** pane appears.

10. Select a skill from the lookup menu, and select a proficiency level from the list, and then select **Save and Close**.

    > [!div class=mx-imgBorder] 
    > ![Attach skill to a conversation](../media/attach-skill1.png "Attach skill")

    If the condition matches, then the Omnichannel system attaches the skill.

11. Select **Save**. After you save, the rule appears in the **Attach Rules** section of the workstream.

    > [!div class=mx-imgBorder] 
    > ![Add skill rule to workstream](../media/attach-skill2.png "Add skill rule to workstream")


## Enable the queues for skill-based routing

After you set up skill attachment rules for a workstream, you must enable skill-based routing for the queues that are related to the a particular workstream. If you don't enable the queues for skill-based routing, the system wouldn't route the conversation based on the skills of the agents in that particular queue.

To enable the queue for skill-based routing, follow these steps.

1. Sign in to the **Omnichannel for Administrator** app.

2. Select **Skills** in under **Users & Queues** in the sitemap. 

3. Set **Yes** for the **Enable Skill Based Routing** field.

4. Select **Save** to save the changes.

## See also

[Overview of skill-based routing](overview-skill-work-distribution.md)

[Enable skill-based routing and create rating model](enable-skill-routing-create-rating-model.md)

[Set up skills and assign agents](setup-skills-assign-agents.md)