---
title: Create and manage users and user profiles | MicrosoftDocs
description: Know how to create and manage users and user profiles in the Omnichannel for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 05/31/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage users in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

All users who are assigned the **Omnichannel administrator**, **Omnichannel supervisor**, or **Omnichannel agent** security role are enabled to use Omnichannel for Customer Service.

For more information on how to create users and assign security roles, see [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md).


## Manage a user in Omnichannel for Customer Service

1. In the site map of Omnichannel admin center, select **Users** under **General settings**. If you're using the Omnichannel Administration app, select **Users** under **Queues & Users**.

2. In the **Omnichannel Users** view, double-click a user in the list.

3. Select the **Omnichannel** tab.

4. Specify the following in the user page.

    | Section | Field | Description | Example value |
    |---------------|---------------------|---------------------|-------------------------------------------------|
    | User Details | Capacity | If capacity units is configured, allocate a value that indicates the capacity of the agent. For information: [Capacity](#capacity). | 100 |
    | User Details | Default Presence | Assign a default presence status for agent. This is the status that the agent is logged in with, in the Omnichannel for Customer Service app. |

5. Select **New Bookable Resource** under the **Skills Configuration** section. The **New Bookable Resource** page appears.

6. Do the following:
   1. Specify the name of agent in the **Name** field.

   2. Select **Save**. The **Work Hours** tab is enabled.
 
    > [!IMPORTANT]
    > To add the work hour for a bookable resource, universal resource scheduling must be available in your organization. Universal resource scheduling is available with Dynamics 365 Field Service, Dynamics 365 Project Service, or Dynamics 365 Service Scheduling. More information: [Overview of Service Scheduling](/dynamics365/customer-service/basics-service-service-scheduling)

   3. You can update the existing work hours or create work hours for the user.

   4. On the **Omnichannel** tab of the **Bookable Resource** page for the user, select **New Bookable Resource Characteristic**.
   
   5. In **Skill Name**, search for and select a skill.
   
   6. In **Rating Value**, select the rating value that the user has on the skill.
   
   5. Save and close to return to the **Omnichannel** tab of the **User** page.

8. If capacity profile is configured, in the **Capacity** area, select **Add Existing Capacity Profile**, and select a profile in the list.

> [!div class=mx-imgBorder]
> ![Default presence](media/oc-user-omni-tab.png)

### Capacity

Capacity is the arbitrary scale that you choose and set for each of the work streams corresponding to the channels. The capacity assigned to the agent must be a multiplier of the capacity unit that you have defined for the associated work stream. Check the capacity unit defined for the work streams to determine the value that must be assigned to your agents. For example, if the capacity unit is 1 for a workstream and you want an agent to be able to take up to 3 conversations simultaneously, the capacity that you assign to the agent should be 3 units. Similarly, if your capacity unit is 5 for the work stream and you want the agent to be able to take up to 3 conversations simultaneously, you should assign 15 units as the capacity for the agent. You can also define capacity profiles. However, we recommend that you use either capacity units or capacity profiles in your environment and not both. More information: [Create and manage capacity profiles](capacity-profiles.md).

### See also

[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Configure and manage presence status](presence-custom-presence.md)  
[Role personas for unified routing](role-persona-mapping.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]