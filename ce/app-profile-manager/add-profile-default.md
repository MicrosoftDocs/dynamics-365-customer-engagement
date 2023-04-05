---
title: Add users to agent experience profiles | MicrosoftDocs 
description: Learn about adding a default profile and mapping agent profiles to security roles
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to
ms.date: 04/01/2023 
ms.custom: bap-template 
---

# Add users to agent experience profiles

When your organization has a large number of users, adding them to agent profiles can be time consuming. As an administrator, you can effectively assign users to agent experience profiles and provide a targeted app experience, based on their roles.

## Set a custom agent profile as default

You can set a custom agent experience profile as the default profile. When you've set a default profile, all the options configured in the profile such as specific session templates, conversation channels, and productivity tools are available for all the users.

> [!NOTE]
> - The default custom profile isn't applicable to a user who is assigned specifically to a different custom profile.
> - You can't set the agent profiles that are available out of the box as default profiles.

For example, you've created a new agent profile, Contoso Agent profile, with knowledge search and agent scripts features enabled. If you set the Contoso Agent profile as the default profile, all the users in the organization can access knowledge search and agent scripts in the productivity pane.

You also have another agent profile, Datum Agent profile, with specific user, Angel Chiu. Only the smart assist feature is enabled for the profile.

In this scenario, Contoso Agent profile doesn't apply to Angel Chiu, and the user can access only the smart assist feature in the productivity pane.

To set the agent profile as a default profile, perform the following steps:

1. In **Customer Service admin center** select **Workspaces** in **Agent experience**.
1. On **Agent experience profiles** select a custom agent experience profile, and then select  **Set as default**.

### Switch default profiles

You can't set multiple profiles as the default profile. If you must change the default profile, use **Remove Default** to remove the default status and then set an alternate profile as the default profile.

## Map security roles to agent profiles

When you have multiple user groups with different roles and privileges, you can assign agent profiles to a user role to provide customized app experiences for each group.

If users have multiple security roles, the applications links the profile with the higher rank to the user. 

For example, your organization has both Customer Service Representative and Omnichannel agent roles to which users are assigned. The table summarizes the mapping of agent profiles to the corresponding roles.

|Agent experience profile   | Rank  | Security Role|
|----------|-----------|------------|
| Contoso Agent profile     |1 | Customer Service Representative |
| Datum Agent profile |2   |  Omnichannel agent |

All the agents with the Customer Service Representative role get the options enabled in the Contoso Agent profile. Users with Omnichannel agent role see the options set in the Datum Agent profile. 

The user, John Doe, has both the Customer Service Representative and Omnichannel agent roles assigned. The application assigns the Contoso agent profile to John Doe, as the rank of the profile is higher.

To add a security role and rank to an agent profile, perform the following steps:

1. In **Customer Service admin center** select **Workspaces** in **Agent experience**.
1. On **Agent experience profiles** select a custom agent experience profile, and then select  **Set rank and roles**. 
   > [!NOTE]
   > - If the default custom profile is set, you can't assign the same profile to user security roles.
   >- You can't set security roles and rank to the out-of-the-box profiles.
1. In **Profile rank and roles assignment** specify the following:
     - **Rank**: Used to determine the custom agent profile that must be mapped to a user when multiple roles are assigned to a user.
     - **Roles**: The user roles that the custom agent profile can be mapped to.

### Remove rank and roles assigned to a profile

Select the required agent profile and then select **Remove rank and roles** to remove the rank and roles assigned to the profile.  If you select this option, all the roles mapped to the profile will be removed.

## Manage users assigned to agent profiles

The application lets you set a default agent profile and assign security roles to a profile. However, if a profile is assigned a security role, the default agent profile isn't applicable to the users with the specific security role.

:::image type="content" source="media/agent-exp-profiles-mini.png" alt-text="agent experience profiles" lightbox="media/agent-exp-profiles.png":::

For example, you've set up your agent experience profiles and mapped users as summarized in the table:

|Agent experience profile   | Rank  | Security Role|User |
|----------|-----------|------------|---------------|
| Contoso Supervisor profile     |1 | Omnichannel Supervisor | |
| Datum Agent profile |2   | Omnichannel agent | Kendall Collins|
| Contoso Agent profile | | | Default|
| Datum Supervisor profile | | | Gabriel Diaz, Kayla Lewis|

Here's how the application assigns the agent profiles:

- Users with the Omnichannel Supervisor role are assigned the Contoso Supervisor profile.
- Users with the Omnichannel agent role are assigned the Datum Agent profile.
- Users with both the Omnichannel Supervisor and the Omnichannel agent role are assigned the Contoso Supervisor profile.
- User Kendall Collins is assigned the Datum Agent profile.
- Users Gabriel Diaz and Kayla Lewis are assigned the Datum Supervisor profile.
- All the remaining users are assigned the Contoso Agent profile.

> [!NOTE]
> If you haven't set a default custom profile or assigned an agent profile to a role, the application assigns the default out-of-the box profile to all the available users.

### FAQs

For more information about adding users to agent profiles, see [FAQs about adding users to agent experience profile](faq-agent-experience-profile.md)

### See also

[FAQ about adding users to agent experience profile](faq-agent-experience-profile.md)<br>
[Create and use agent experience profiles](create-agent-experience-profile.md)<br>
[Manage session template](session-templates.md)  
[Overview of Dynamics 365 Productivity Tools](productivity-tools.md)  
[Overview of channels in Omnichannel for Customer Service](../customer-service/channels.md)  
[Overview of agent experience profiles](overview.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
