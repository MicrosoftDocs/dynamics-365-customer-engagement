---
title: "Set up skills and assign agents | MicrosoftDocs"
description: "Learn how to create skills and assign agents to those skills in Omnichannel for Customer Service." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: E8E820AC-64BD-4E76-809D-4A012DDDADA7
ms.custom: 
---

# Set up skills and assign agents

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Set up skills

As an administrator, to create skills, you need at least one type in the system. For example, To add **Spanish** as a skill, you need a skill type called **Language**. You must first create a skill type and then create skills.

### Create Skill type

PM need to share information for this section.

### Create skills

After you create skill type, you can create skills.

1. Sign in to the **Omnichannel for Administrator** app.

2. Select **Skills** in under **Users & Queues** in the sitemap.

3. Select **+ New**.

4. Specify the following in the **New Skill** page.

    | Field | Description  | Example Value |
    |-----------|---------------------|------------------------------|
    | Type | Select a skill type from the drop-down list. | Language |
    | Name | Type the skill. | Spanish |

5. Select **Save**. 

After you save, the **Agents** section appears. In this section, you add the agents and proficiency level. To learn more, see [Assign agents to the skill](#assign-agents-to-skill)

### Assign agents to skill

1. Sign in to the **Omnichannel for Administrator** app.

2. Select **Skills** in under **Users & Queues** in the sitemap.

3. Select a skill from the list for which you want to assign the agents.

4. Select **+ Add Existing Agent** in the **Agents** section. The **Lookup Records** pane appears.

5. Select an agent from the list.

6. Select a skill proficient level from the drop-down. The values that appear are based on the rating model and rating values. To learn more, see [Proficiency level (Rating model) of skills](enable-skill-routing-create-rating-model.md#proficiency-level-rating-model-of-skills)

7. Select **Add** to add the agents.

8. Select **Save** to save the changes.

9. Repeat the steps 4 through 8 to add more agents to the skill.


Alternatively, you can also add a skill to the user (agent). To learn more, see [Manage users](users-user-profiles.md).