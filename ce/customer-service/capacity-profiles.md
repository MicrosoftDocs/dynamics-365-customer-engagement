---
title: Create and manage capacity profiles | MicrosoftDocs
description: "Know how to create and manage capacity profiles in Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---



<!-- In line 28, do you mean Omnichannel for Customer Service admin center? Also, I'm not sure about the use of Omnichannel in line 44. Here's the style guide info: https://styleguides.azurewebsites.net/Styleguide/Read?id=2696&topicid=48167  -->



# Create and manage capacity profiles

You can create capacity profiles to define the types and amount of work that agents can take. Capacity profiles improve efficiency in work distribution.

> [!IMPORTANT]
> We recommend that you configure either capacity profiles or capacity units in your organization but not both.

## Create a capacity profile and assign to users

Perform the following steps to configure the capacity profile:

1. In the Omnichannel admin center, select **User attributes** under **Advanced settings** in the site map. In Customer Service Hub, select **User attributes** under **Unified routing** in the site map.

  > [!NOTE]
  > Unified routing must be enabled in Service configuration settings in Customer Service Hub for the **User attributes** area to appear in the site map.

2. On the **User attributes** page, select the **Manage** option for **Capacity profile**.
3. On the **Capacity profiles** page, select **Create new**.
4. On the **Details** tab of the **Create capacity profile** dialog box, enter the following details:
   - **Profile name**: Name for the capacity profile.
   -  **Work item limit**: Number of units of the work type that the agent can be assigned.
   -  **Reset frequency**: Period after which capacity consumption can be reset for agents. If you select **Immediate**, capacity will be reset immediately. If you select **End of day**, capacity will be reset after the agent's shift ends.
   -  **Assignment blocking**: Set the toggle to **Yes**. When the agent reaches the work item limit of the capacity profile, any new work items won't be automatically assigned to the agent.
5. On the **Users** tab, select **Add user**, and in the **Users** list, select the users.
6. Select **Add user**. The capacity profile is assigned to the user.

> [!NOTE]
> In Omnichannel Administration, you can create a capacity profile in the **Capacity** area of the **User** page.
