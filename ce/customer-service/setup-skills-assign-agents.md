---
title: "Set up skills and assign agents | MicrosoftDocs"
description: "Learn how to create skills and assign agents to those skills in Omnichannel for Customer Service."
ms.date: 04/09/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Set up skills, create a rating model, and assign agents

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Set up skills

As an administrator, to create skills, you need at least one skill type in the system. For example, to add **Spanish** as a skill, you need a skill type called **Language**. You must first create a skill type and then create skills.

### Create skill types

1. Sign in to the Dynamics 365 instance as an administrator.

2. Select **Settings** > **Customizations** >  **Customize the System**.

3. Select **Option Sets** from the left pane.

4. Double-click the **Bookable Resource Characteristic Type** from the list. A new window opens.

5. Select the **Add** icon under the Options container.

6. Type a name for the Label field. For example, **Language**.

7. Select **Save** to save the skill type.

8. Create as many skill types as required.

9. Select **Publish** to publish the customization changes.

    > [!div class=mx-imgBorder] 
    > ![Create skill type](media/create-skill-type.png "Create skill type")

### Create skills

After you create a skill type, you can create skills in the Omnichannel admin center or Omnichannel Administration app.

1. In the Omnichannel admin center app, select **User attributes** in the site map, and select **Manage** beside **Skills** on the **User attributes** page. In the Omnichannel Administration app, select **Skills** under **Queues & Users** in the site map.

3. Select **New**.

4. Specify the following in the **New Skill** page.

    | Field | Description  | Example value |
    |-----------|---------------------|------------------------------|
    | Name | Specify the name of the skill. | Spanish <br> **Note:** <br> The name must be unique. |
    | Type | Select a skill type from the drop-down list. | Language |
    | Description | Provide a description of the skill. | This record is used to define the skill level of the Spanish language. |

5. Select **Save**.

After you save, the **Users (Agents)** section appears. In this section, you add the agents and rating value. To learn more, see [Assign agents to the skill](#assign-agents-to-skill).

## Rating value of skills

When you add a skill to an agent, you also need to rate the proficiency of the skill. This enables the system to do an exact or closest match against the requirement of a conversation and distribute the conversation accordingly. You can use the default rating model, edit it, or create a new one to match the needs of your organization.

You must provide the minimum and maximum rating value. Also, in the **Rating Values** section, you must create rating value text against each score between the minimum and maximum rating value. This text appears when you're updating an agent's skill and proficiency.

### Create a rating model

1. In the Omnichannel admin center or Customer Service Hub app, select **User attributes** in the site map, and select **Manage** beside **Skill-based routing** on the **User attributes** page. If you're using the Omnichannel Administration app, select **Skill Based Routing** under **Settings** in the site map.

2. On the **Omnichannel Configuration** page, in the **Rating Model** section, select **New Rating Model**.

3. Specify the following in the **New Rating Model** page.

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

## Add agents as bookable resource

Add the agents as a bookable resource so that you can assign skills to them.

1. In the site map of Omnichannel admin center, select **Users** under **General settings**. If you're using the Omnichannel Administration app, select **Users** under **Queues & Users**.

2. Select a user from the list and select the **Omnichannel** tab.

3. Select **New Bookable Resource** in the **Skills Configurations** section. The **New Bookable Resource** page appears.

4. Specify the name of the user in the **Name** field.

5. Select **Save**.

## Assign agents to skill

1. In the site map of Omnichannel admin center, select **User attributes** under **Advanced settings**, and then select **Manage** for **Skills**. If you're using Omnichannel Administration, select **Skills** under **Users & Queues** in the site map.

2. Select a skill from the list for which you want to assign the agents.

3. Select **New Bookable Resource Characteristic** in the **Users (Agents)** section. The **Quick Create: Bookable Resource Characteristic** pane appears.

4. Select an agent name for the **User (Agent)** field. Only the name of the agents who are added as Bookable Resources appears in drop-down.

5. Select a rating value from the list. The values that appear are based on the rating model and rating values that you created. To learn more, see [Rating value of skills](#rating-value-of-skills).

6. Select **Save and Close**. The agent you added is displayed in the grid.

    > [!div class=mx-imgBorder] 
    > ![Assign agents to skill](media/assign-user-skill.png "Assign agents to skill")

7. Repeat steps 3 through 6 to add more agents to the skill.

8. Select **Save**.

Alternatively, you can also add a skill to the user (agent). To learn more, see [Manage users](users-user-profiles.md).

## See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Manage users](users-user-profiles.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
