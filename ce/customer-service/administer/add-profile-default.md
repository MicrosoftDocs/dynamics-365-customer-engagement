---
title: Add users to experience profiles
description: Learn about adding a default profile and mapping experience profiles to security roles.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.date: 04/30/2025
ms.custom: bap-template 
---

# Add users to experience profiles

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

When your organization has a large number of users, adding them to experience profiles can be time consuming. As an administrator, you can effectively assign users to experience profiles and provide a targeted app experience, based on their roles.

## Search for users

Before you assign users to experience profiles, you can search for users to see if they're already associated with a profile.

1. In **Experience profiles** select **Search by user**. The **Experience Profile Search by User** pane appears.
1. In the **User** field, enter the name of the user. The application displays the users that match the search criteria. 
1. Select the required user from the list or select **Advanced lookup** to perform an advanced search.
1. The application displays the experience profiles that the selected user is associated with along with one of the following assignment methods:
     - **Default**: The user is assigned to out-of-the-box experience profiles or custom default profile.
     - **Role-based**: The user is assigned a profile based on the security role.
     - **Direct**: The user is directly assigned to a profile. <br>
You can also select the experience profile to view the profile details.

## Set a custom experience profile as default

You can set a custom experience profile as the default profile. When you set a default profile, all the options configured in the profile such as specific session templates, conversation channels, and productivity tools are available for all the users.

> [!NOTE]
> - The custom experience profile that set as the default isn’t applicable to users who are assigned specific custom experience profiles.
> - You can't set the out-of-the-box experience profiles as the default.

For example, you created a new experience profile, Contoso Representative profile, with knowledge search and scripts features enabled. If you set the Contoso Representative profile as the default profile, all the users in the organization can access knowledge search and scripts in the productivity pane.

You also have another experience profile, Datum Representative profile, with specific user, Angel Chiu. Only the smart assist feature is enabled for the profile.

In this scenario, Contoso Representative profile doesn't apply to Angel Chiu, and the user can access only the smart assist feature in the productivity pane.

To set the experience profile as a default profile, perform the following steps:

1. In **Copilot Service admin center** select **Workspaces** in **Support experience**.
1. On **Experience profiles** select a custom experience profile, and then select  **Set as default**.

### Switch default profiles

You can't set multiple profiles as the default profile. If you must change the default profile, use **Remove Default** to remove the default status and then set an alternative profile as the default.

## Map security roles to experience profiles

When you have multiple user groups with different roles and privileges, you can assign experience profiles to a security role to provide customized app experiences for each group. The application assigns the experience profile to all the users with the specified security role. However, assignment of experience profiles based on [team membership](/power-platform/admin/create-edit-business-units#change-the-business-unit-for-a-team) isn't allowed.

If users have multiple security roles, the application links the profile with the higher rank to the user. 

For example, your organization has both Customer Service Representative and Omnichannel agent roles to which users are assigned. The table summarizes the mapping of experience profiles to the corresponding roles.

|Experience profile   | Rank  | Security Role|
|----------|-----------|------------|
| Contoso Representative profile     |1 | Customer Service Representative |
| Datum Representative profile |2   |  Omnichannel agent |

All the service representatives with the Customer Service Representative role get the options enabled in the Contoso Representative profile. Users with Omnichannel agent role see the options set in the Datum Representative profile. 

The user, John Doe, has both the Customer Service Representative and Omnichannel agent roles assigned. The application assigns the Contoso Representative profile to John Doe, as the rank of the profile is higher.

To add a security role and rank to an experience profile, perform the following steps:

1. In **Copilot Service admin center** select **Workspaces** in **Support experience**.
1. On **Experience profiles** select a custom experience profile, and then select  **Set rank and roles**. You can't set security roles and rank to the out-of-the-box profiles.

When you set a custom profile as the default, the following changes occur:
 - You can't set security roles and rank to the out-of-the-box profiles.
 - You no longer can assign security roles to the default profile.
 - Existing security roles are removed.

1. In **Profile rank and roles assignment** specify the following details:
     - **Rank**: Used to determine the custom experience profile that must be mapped to a user when multiple roles are assigned to a user.
     - **Roles**: The user roles that the custom experience profile can be mapped to.

### Remove rank and roles assigned to a profile

Select the required experience profile and then select **Remove rank and roles** to remove the rank and roles assigned to the profile. If you select this option, all the roles mapped to the profile are removed.

## Manage users assigned to experience profiles

The application lets you set a default experience profile and assign security roles to a profile. However, if a profile is assigned a security role, the default experience profile isn't applicable to the users with the specific security role.

:::image type="content" source="../media/agent-exp-profiles-mini.png" alt-text="experience profiles" lightbox="../media/agent-exp-profiles.png":::

For example, you set up your experience profiles and mapped users as summarized in the table.

|Experience profile   | Rank  | Security Role|User |
|----------|-----------|------------|---------------|
| Contoso Supervisor profile     |1 | Omnichannel Supervisor | |
| Datum Representative profile |2   | Omnichannel agent | Kendall Collins|
| Contoso Representative profile | | | Default|
| Datum Supervisor profile | | | Gabriel Diaz, Kayla Lewis|

Here's how the application assigns the experiences profiles:

- Users with the Omnichannel Supervisor role are assigned the Contoso Supervisor profile.
- Users with the Omnichannel agent role are assigned the Datum Representative profile.
- Users with both the Omnichannel Supervisor and the Omnichannel agent role are assigned the Contoso Supervisor profile.
- User Kendall Collins is assigned the Datum Representative profile.
- Users Gabriel Diaz and Kayla Lewis are assigned the Datum Supervisor profile.
- All the remaining users are assigned the Contoso Representative profile.

> [!NOTE]
> If you haven't set a default custom profile or assigned an experience profile to a role, the application assigns the default out-of-the-box profile to all the available users.

### FAQs

For more information about adding users to experience profiles, see [FAQs about adding users to experience profile](faq-agent-experience-profile.md)

### Related information

[FAQ about adding users to experience profile](faq-agent-experience-profile.md)<br>
[Create and use experience profiles](create-agent-experience-profile.md)<br>
[Manage session template](session-templates.md)  
[Overview of Dynamics 365 Productivity Tools](productivity-tools.md)  
[Overview of channels](../use/channels.md)  
[Overview of experience profiles](overview.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
