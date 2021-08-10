---
title: Create and manage capacity profiles | MicrosoftDocs
description: "Know how to create and manage capacity profiles in Customer Service"
ms.date: 04/09/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Create and manage capacity profiles

You can create capacity profiles to define the types and amount of work that agents can take. Capacity profiles improve efficiency in work distribution.

- Capacity management helps administrators create various capacity profiles and associate users with the matching profiles.
- The supervisor has the flexibility to use the agents for maximum customer services while the agents have the control to work on the maximum number of cases assigned to them daily. The capacity is not considered during consult or monitor.
- The administrator has the capability to block certain period of agents' time while they are busy working with high priority cases.
- The supervisor can override the agent's configured capacity and assign work to user manually.
- In the queue assignment rule, you can create a rule to find an agent whose capacity profile matches that of the work item.

> [!IMPORTANT]
> We recommend that you configure either capacity profiles or capacity units in your organization, but not both.

## Create a capacity profile and assign to users

Create a capacity profile, and use it in a workstream that is used for routing work items. More information: [Configure work distribution](create-workstreams.md#configure-work-distribution).

For a capacity profile, you can edit any setting except reset frequency, and add or remove users. If you no longer require the profile, you can delete it.

Perform the following steps to configure the capacity profile:

1. In Omnichannel admin center, select **User attributes** under **Advanced settings** in the site map. In Customer Service Hub, select **User attributes** under **Unified routing** in the site map.

  > [!NOTE]
  > In Customer Service Hub, the **User attributes** area will appear in the site map only if unified routing is enabled in service configuration settings.

2. On the **User attributes** page, select the **Manage** option for **Capacity profile**.
3. On the **Capacity profiles** page, select **Create new**.
4. On the **Details** tab of the **Create capacity profile** dialog box, enter the following details:
   - **Profile name**: Name for the capacity profile.
   -  **Work item limit**: Number of units of the work type that the agent can be assigned.
   -  **Reset frequency**: Period after which capacity consumption can be reset for agents. If you select **Immediate**, capacity will be reset immediately. If you select **End of day**, capacity will be reset after the agent's shift ends. Once configured, you'll have to recreate the capacity profile if you want to change the reset frequency.
   -  **Assignment blocking**: Set the toggle to **Yes**. When the agent reaches the work item limit of the capacity profile, any new work items won't be automatically assigned to the agent.
5. On the **Users** tab, select **Add user**, and in the **Users** list, select the users.
   > [!IMPORTANT]
   > Users must be configured as a bookable resource to be assigned the capacity profile. More information: [Manage users](users-user-profiles.md).
6. Select **Add user**. The capacity profile is assigned to the user.

> [!NOTE]
> In Omnichannel Administration, you can create a capacity profile in the **Capacity** area of the **User** page.

## Use capacity profiles

After you have created the capacity profiles, you can configure the following settings to assign work items to agents at runtime:

- Set the capacity profile in the work distribution settings. The profile will be applied to all the work items that are routed through the workstream.
- Set the capacity profile in a classification ruleset for the workstream as a rule output. This setting will override the capacity profile that you have defined at the work distribution level.

You needn't define assignment rules specific to capacity profiles at queue level to find agents with matching capacity profiles. If capacity profile is attached to a work item, then the system will ensure that the assigned agent has the matching capacity profile.

### See also

[Create workstreams](create-workstreams.md)  
[Manage users in Omnichannel for Customer Service](users-user-profiles.md)  
[Map role personas](role-persona-mapping.md)  
