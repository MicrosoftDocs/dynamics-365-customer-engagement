---
title: "Allow agents to update skills | MicrosoftDocs"
description: "Learn about how to enable agents to update skills at runtime and attach a rating model for skill-based routing in Customer Service Hub and Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 06/07/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Allow agents to update skills

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

By default, skill-based routing is enabled. You can create skills to attach to agents and define proficiency levels by using a rating model. You can enable agents to add or remove skills for a work item at runtime. By default, the skill control is available only for the messaging channels. For the records channel, you'll need to customize the form. More information: [Add a skill control for routed records](add-skill-control.md).

Perform the following steps to enable the setting that allows agents to update skills for a work item.

1. Sign in to Dynamics 365.

2. In Omnichannel admin center or in Customer Service Hub, in the site map, select **User attributes**, and then select **Manage** next to **Skill-based routing** on the **User attributes** page.

3. On the **Skill based routing** tab, set the **Enable update skill control** toggle to **Yes**.

4. Select a rating model from the list for the **Rating Models** field.

   If the rating model doesn't exist, create a rating model. To learn more, see [Create rating model](setup-skills-assign-agents.md#create-a-rating-model).

   After you select a rating model, the **Rating Model Details** section displays the **Name**, **Min Rating Value**, **Max Rating Value**, and the **Rating Values (Rating Model)** grid.

   Use the following steps to add a rating value in the grid:

   1. Select **New Rating Value**. The **Quick Create: Rating Value** pane appears.

   2. Specify a name and value.

   3. Select **Save and Close** to save and add the rating value.

5. Select **Save**.


### See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Set up skills and assign agents](setup-skills-assign-agents.md)  
[Attach skills to conversation](attach-skills.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]