---
title: "Create and manage users and user profiles | MicrosoftDocs"
description: "This article provides steps that you can perform to manage users in Omnichannel for Customer Service."
ms.date: 10/03/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Use the enhanced experience to manage users (preview)

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
>
> The enhanced user management feature is in preview. [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Use the information in this article to manage your agent users for Customer Service. The enhanced user management experience is a simplified UI that eases the complexity of configuring the various settings required for your agent users to provide customer service optimally.

You can manage the following settings for the users in bulk:

- Skills
- Queues
- Capacity profiles
- Swarming

On the user management page, the following three views are available:

- **Contact center users**: Lists users who are assigned the agent, supervisor, or admin persona.
- **All users**: Lists all the Customer Service users.
- **Swarm experts**: Lists users who are assigned to be swarm experts.

The enhanced user management experience is available in Customer Service admin center only.

**To manage the contact center users**

The attributes that you want to add must be configured in the system. You can update up to 25 users in a single step. For the selected users, you can update up to five attributes in a single step. If you need to update more than five attributes for the selected users, you can save the changes and then update the next set of attributes.

1. Sign in to Dynamics 365, and go to the Customer Service admin app.

1. Select **User management** under **Customer support** in the site map.

1. On the page that appears, select **Manage** for **Enhanced user management (Preview)**. The **Contact center users** view displays the users that have been configured in Power Platform admin center.

1. Hover the pointer over the rows of the users that you want to update and select the check boxes.

1. To update user attributes, select **Update user attributes**, and select one of the following options:

   - **Update skills**: On the dialog box that appears, do the following:
       - **Add skills to users:** In the **Skills** box, select the skills that you want to add, select a proficiency, and then select **Add to all**. The selected skill and proficiency is added for the users in the list. To have a different proficiency for the skills, select one skill and proficiency at a time.
       - **Activate or deactivate**: Select a skill in the **Skills** box, and select the ellipses to select **Activate for all** or **Deactivate for all**. Users with a deactivated skill will not be considered during assignment if the skill requirement of a work item matches the deactivated skill.
       - **Remove skills**: To remove a skill from the list of users, select the skill in the **Skills** box, and select **Remove from all**. Save your changes. The selected skills are removed for the users.

   - **Update queues**: On the dialog box that appears, in the **Queues** box, select the queues to add or remove, and then select **Add to all** or **Remove from all**. Save your changes.

   - **Update capacity**: On the dialog box that appears, in the **Capacity profiles** box, select the profiles that you want to add or remove, and then select **Add to all** or **Remove from all**. Save your changes.

1. To add users as swarm experts, select **Swarming** and then select **Add as swarm expert**.

1. If you want to see the list of swarm experts, select the **Swarm experts** view. More information: [Configure customer support swarming](configure-customer-support-swarming.md)

The users and their updated attributes will be displayed in the **Contact center users** view.

:::image type="content" source="media/enhanced-user-management.png" alt-text="View of the contact center users managed through the enhanced user management experience.":::

## Manage users using the classic experience

Users should be configured as a bookable resource so that they can be assigned work items by using unified routing.

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
   
    1. In the site map, select **User management** in **Customer support**.
    
    1. On the **User management** page, select **Manage** for **Users**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Users** in **General settings**.

   ### [Customer Service Hub](#tab/customerservicehub)

    - Go to the **Service Management** site map, and in **Unified Routing**, select **Users**.

2. On the **Omnichannel Users** page, double-click a user in the list.

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
    > To add the work hours for a bookable resource, universal resource scheduling must be available in your organization. Universal resource scheduling is available with Dynamics 365 Field Service, Dynamics 365 Project Service, or Dynamics 365 Service Scheduling. More information: [Overview of Service Scheduling](/dynamics365/customer-service/basics-service-service-scheduling)

   3. You can update the existing work hours or create work hours for the user.

   4. On the **Omnichannel** tab of the **Bookable Resource** page for the user, select **New Bookable Resource Characteristic**.
   
   5. In **Skill Name**, search for and select a skill.
   
   6. In **Rating Value**, select the rating value that the user has on the skill.
   
   7. Save and close to return to the **Omnichannel** tab of the **User** page.

7. If capacity profile is configured, in the **Capacity** area, select **Add Existing Capacity Profile**, and select a profile in the list.

   > [!div class=mx-imgBorder]
   > ![Default presence.](media/oc-user-omni-tab.png)

8. To use the user schedule for assignment, set up the bookable resource calendar. More information: [Apply a calendar to a resource](../field-service/calendar-resource.md)

9. Add the user to the required queue that's configured for unified routing. More information: [Configure queues for unified routing](queues-omnichannel.md)
   
   > [!NOTE]
   > Bots in a queue are modeled as a bookable resource and therefore will be considered for assignment. However, we recommend that you don't add bots to queues that are used for routing records.

All users who are assigned the **Omnichannel administrator**, **Omnichannel supervisor**, or **Omnichannel agent** security role can use Omnichannel for Customer Service.

For more information on how to create users and assign security roles, see [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md).

For users to access the Omnichannel for Customer Service experiences, the roles that you map to personas in role persona mapping must be assigned to the users directly and not through team memberships. For more information about role persona mapping, see [Role persona mapping](role-persona-mapping.md).

### Capacity

Capacity is the arbitrary scale that you choose and set for each of the work streams corresponding to the channels. The capacity assigned to the agent must be a multiplier of the capacity unit that you have defined for the associated workstream. Check the capacity unit defined for the workstreams to determine the value that must be assigned to your agents.

For example, if the capacity unit is 1 for a workstream and you want an agent to be able to take up to 3 conversations simultaneously, the capacity that you assign to the agent should be 3 units. Similarly, if your capacity unit is 5 for the work stream and you want the agent to be able to take up to 3 conversations simultaneously, you should assign 15 units as the capacity for the agent. You can also define capacity profiles. However, we recommend that you use either capacity units or capacity profiles in your environment, and not both. More information: [Create and manage capacity profiles](capacity-profiles.md).

### See also

[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Configure and manage presence status](presence-custom-presence.md)  
[Role personas for unified routing](role-persona-mapping.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
