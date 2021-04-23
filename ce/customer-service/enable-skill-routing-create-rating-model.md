---
title: "Configure settings for skill-based routing, create rating model | MicrosoftDocs"
description: "Learn about how to configure settings for skill-based routing and create rating model in Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Allow agents to update skills, create a rating model

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

By default, skill-based routing is enabled. You can create skills to attach to agents and define proficiency levels by using a rating model.

## Allow agents to update skills

Perform the following steps to enable the setting that'll allow agents to update skills for a work item.

1. Sign in to Dynamics 365.

2. Do one of the following depending on the app you're using:
   - In Omnichannel admin center, in the site map, select **User attributes**, and then select **Manage** beside **Skill-based routing**.
   - In Customer Service Hub, in the site map, select **User attributes** under **Unified Routing**, and then select **Manage** beside **Skill-based routing**.

3. On the **Skill based routing** tab, set the **Enable update skill control** toggle to **Yes**.

4. Select a rating model from the list for the **Rating Model** field.

   If the rating model doesn't exist, create a rating model. To learn more, see [Create rating model](#create-rating-model).

   After you select a rating model, the **Rating Model Details** section displays the **Name**, **Min Rating Value**, **Max Rating Value** and the **Rating Values (Rating Model)** grid.

   Use the following steps to add a rating value in the grid:

   1. Select **New Rating Value**. The **Quick Create: Rating Value** pane appears.

   2. Specify a name and value.

   3. Select **Save and Close** to save and add the rating value.

5. Select **Save**.

## Rating value of skills

When you add a skill to an agent, you also need to rate the proficiency of the skill. This enables the system to do an exact or closest match against the requirement of a conversation and distribute the conversation accordingly. You can use the default rating model, edit it, or create a new one to match the needs of your organization.

You must provide the minimum and maximum rating value. Also, in the **Rating Values** section, you must create rating value text against each score between the minimum and maximum rating value. This text appears while updating an agent's skill and proficiency.

### Create rating model

1. In the Omnichannel Configuration page, in the **Rating Model** section, select **New Rating Model**.

2. Specify the following in the **New Rating Model** page.

  | Tab | Field | Description | Example value  |
  |------------|-----------------|----------------|--------------------------------------------|
  | General | Name | Specify a name for the rating model. | Language rating model |
  | General | Min Rating Value | Provide a minimum rating value. | 1 |
  | General | Max Rating Value | Provide a maximum rating value. | 10 |
  ||||

3. Select **Save**. The **Rating Values** section appears.

4. Select **New Rating Value**. The **Quick Create: Rating Value** pane appears.

5. Specify the following in the **Rating Value** page.

  | Field | Description | Value  |
  |-----------------|----------------|--------------------------------------------|
  | Name | Specify a name for the rating value. | ★★★★★★★★★★ <br> **Note:** <br>This is an example value.|
  | Value | Provide a value. | 10 <br> **Note:** <br>This is an example value.|
  |||

6. Select **Save and Close** to save and add the rating value to the grid.

7. Select **New** to add other rating values and repeat step 4 and 5.

8. Select **Save** to save the rating model changes.

### Recommended proficiency level

We recommend that you use a rating model with minimum value as 1 and maximum value as 10, and define the rating values accordingly.

For example:

| Rating value name | Value |
|-------------------|-------|
| ★★★★★★★★★★| 10 star|
| ★★★★★★★★★ | 9 star|
| ★★★★★★★★ | 8 star|
| ★★★★★★★ | 7 star |
| ★★★★★★ | 6 star|
| ★★★★★ | 5 star|
| ★★★★ | 4 star|
| ★★★ | 3 star|
| ★★ | 2 star|
| ★ | 1 star|

### See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Set up skills and assign agents](setup-skills-assign-agents.md)  
[Attach skills to conversation](attach-skills.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]