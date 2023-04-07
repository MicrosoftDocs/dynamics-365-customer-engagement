---
title: "Attach skill to an incoming conversation | MicrosoftDocs"
description: "Learn about how to attach skills to an incoming conversation in Omnichannel for Customer Service app."
ms.date: 02/25/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Attach skills to conversations in Omnichannel Administration

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> - Support for the Omnichannel Administration app ended on April 30, 2022. We recommend that you use the Omnichannel admin center or Customer Service admin center app to configure the latest features, such as unified routing and voice channel. More information: [Omnichannel Administration app is deprecated](../customer-service/deprecations-customer-service.md#omnichannel-administration-app-is-deprecated).
> - We recommend that you upgrade to the latest version of Omnichannel for Customer Service and use unified routing. For more information, see [Overview of unified routing](overview-unified-routing.md). With the upgrade, you can also use the Omnichannel admin center app. For more information, see [Omnichannel admin center](oc-admin-center.md).

## Understand skill-based routing

When a customer initiates a conversation, the following happens:

- Based on the skill attachment rules, the system attaches the skills to the conversation.
- Based on the routing rules, the system routes the conversation to the appropriate queue.
- Now, the assignment system starts matching the agents' skills with those skills attached to the conversation. After finding a match as per the match criteria (exact or closest), the assignment engine assigns the conversation to the agent.

In the portal, when a customer fills in the prechat survey questions, the system receives them as context variables. The system attaches these variables to the incoming conversation as a skill. The assignment engine matches the skills of the agents. The skill is matched on exact or closest match. If the agent and conversation skills match, the assignment engine assigns the conversation to the agent.

For example:

Bert Hair, is a customer from Spain, who uses **Xbox** product. Bert goes to **www.contoso.com** portal to initiate a chat with the Contoso customer service. In the pre-chat survey question, Bert chooses **Xbox**. Because Bert's geolocation is Spain, the system attaches **Xbox** as the product and the **Spanish** language as the skill to the conversation. Then, the assignment engine assigns the conversation to an agent who matches the skill and language.

> [!Note]
> The system attaches the skills to a conversation based on the skill attachment rules.

## Match skills

When the skill attachment rules attach skills and proficiency levels, the assignment logic matches the required skill with the skills of the agent. The system assigns the conversation to an agent based on the skill criteria that is chosen.

Admins can achieve the skill matching based on the business requirements:

- Exact skill matching
- Closest or nearest skill matching

### Exact skill matching

In exact skill matching, the assignment logic searches for an agent with the required skills and proficiency and lists them in the order of highest available capacity by default. The default order can be set to round robin by the administrator.

If no agent is available with all the required skills and corresponding or higher proficiency, then the conversation remains unassigned in the queue.

Exact match will filter all matching agents whose proficiency is greater than or equal to the required proficiency.

The following table describes how exact skill matching works for a single or multiple-skill scenario.

| Skill scenario | Skill & proficiency criteria  | Description |
|--------|---------------------|-----------------|
| Single | Xbox = 4 |The system searches for all agents with **Xbox** greater than or equal to **4**. |
| Multiple |Xbox = 4 <br> Spanish = 5 | The system searches for all agents with **Xbox** skill rating greater than or equal to 4 and **Spanish** skill rating greater than or equal to 5. |
||||

### Closest skill matching

If no agent is available with any of the required skills, then the conversation might be assigned to an agent without the required skills.

The closest skill match will order all agents based on their closeness to the required skill and proficiency. For example, if the required skills are four, then agents with four skills will be put on top (exact qualified), then agent with five skills (overqualified), and then agent with three skills (under qualified). In this scenario where closest match is chosen as the skill matching algorithm at workstream level; if more than one agent with same skill score are there; the system will not order them by round robin or highest capacity. The system will continue to assign all the incoming work items to the same agent till other constraints like capacity and presence are met.

> [!NOTE]
> If you do not intend to use skills based routing model, choose **None** in the **Default skill matching algorithm** option in the workstream settings.

The following table describes how exact skill matching works for a single- or multiple-skill scenario.

| Skill scenario | Skill & proficiency  | Description |
|--------|---------------------|-----------------|
| Single | Xbox = 4 | <ul><li> Agents are first ordered by exact qualified match (Xbox equals 4), followed by overqualified match (Xbox is greater than 4), and then underqualified match (Xbox is less than 4)</li> <li> If none of the criteria are met, then the work item might be assigned to an agent who doesn't have the Xbox skill.</li> </ul>|
| Multiple | Xbox = 4 <br> Spanish = 5 |<ul><li> Agents are first ordered by exact qualified (Xbox equals 4, Spanish equals 5), then overqualified (Xbox is greater than 4, Spanish is greater than 5) and then underqualified (Xbox is less than 4, Spanish is less than 5). </li> <li> If none of the criteria are met, then the work item might be assigned to an agent who doesn't have the Xbox and Spanish skills. </li></ul>|

> [!Note]
> The system provides a score for the agents against each skill based on the scenarios mentioned and rating model. The system calculates the normalised score of the agent by considering the skills and then, based on the score, assigns the conversation to the agents.

## Prerequisites

To attach skills, you need a workstream record. You can either create or use an existing workstream configuration.

## Create rules to attach a skill in Omnichannel Administration

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
    > ![Attach skill to a conversation.](media/attach-skill1.png "Attach skill")

    If the condition (criteria) matches, then the omnichannel system attaches the skill.

12. Select **Save**. After you save, the rule appears in the **Attachment Rules** section of the workstream.

    > [!div class=mx-imgBorder] 
    > ![Add skill rule to workstream.](media/attach-skill2.png "Add skill rule to workstream")

### See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Allow agents to update skills](allow-agents-update-skills.md)  
[Set up skills and assign agents](setup-skills-assign-agents.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
