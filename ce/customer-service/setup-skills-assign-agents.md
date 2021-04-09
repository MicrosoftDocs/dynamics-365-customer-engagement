---
title: "Set up skills and assign agents | MicrosoftDocs"
description: "Learn how to create skills and assign agents to those skills in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Set up skills and assign agents

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Set up skills

As an administrator, to create skills, you need at least one skill type in the system. For example, to add **Spanish** as a skill, you need a skill type called **Language**. You must first create a skill type and then create skills.

### Create skill type

1. Sign in to the Dynamics 365 instance as an administrator.

2. Select **Settings** > **Customizations** >  **Customize the System**.

3. Select **Option Sets** from the left pane.

4. Double-click the **Bookable Resource Characteristic Type** from the list. A new window opens.

5. Select the **Add** icon under the Options container.

6. Type a name for the Label field. For example, **Language**.

7. Select **Save** to save the skill type.

8. Select **Publish** to publish the customization changes.

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

### Add agents as bookable resource

Add the agents as a bookable resource so that you can assign skills to them.

1. In the site map of Omnichannel admin center, select **Users** under **General settings**. If you're using the Omnichannel Administration app, select **Users** under **Queues & Users**.

2. Select a user from the list and select the **Omnichannel** tab.

3. Select **New Bookable Resource** in the **Skills Configurations** section. The **New Bookable Resource** page appears.

4. Specify the name of the user in the **Name** field.

5. Select **Save**.

### Assign agents to skill

1. In the site map of Omnichannel admin center, select **User attributes** under **Advanced settings**, and then select **Manage** for **Skills**. If you're using Omnichannel Administration, select **Skills** under **Users & Queues** in the sitemap.

2. Select a skill from the list for which you want to assign the agents.

3. Select **New Bookable Resource Characteristic** in the **Users (Agents)** section. The **Quick Create: Bookable Resource Characteristic** pane appears.

4. Select an agent name for the **User (Agent)** field. Only the name of the agents who are added as Bookable Resources appears in drop-down.

5. Select a rating value from the list. The values that appear are based on the rating model and rating values that you created. To learn more, see [Rating value of skills](enable-skill-routing-create-rating-model.md#rating-value-of-skills).

6. Select **Save and Close**. The agent you added is displayed in the grid.

    > [!div class=mx-imgBorder] 
    > ![Assign agents to skill](media/assign-user-skill.png "Assign agents to skill")

7. Repeat steps 3 through 6 to add more agents to the skill.

8. Select **Save**.

Alternatively, you can also add a skill to the user (agent). To learn more, see [Manage users](users-user-profiles.md).

## See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Enable skill-based routing and create rating model](enable-skill-routing-create-rating-model.md)  
[Attach skills to conversation](attach-skills.md)  
[Manage users](users-user-profiles.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]