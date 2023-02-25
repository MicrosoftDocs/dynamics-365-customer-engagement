---
title: Add users to custom agent experience profiles | MicrosoftDocs 
description: Learn about adding a default profile and mapping agent profiles to security roles
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to
ms.date: 02/03/2023 
ms.custom: bap-template 
---

# Add users to custom agent experience profiles

Adding users to an agent profile can be time consuming, especially if your organization has a large number of users. You can use **Set as default** and **Set rank and roles** options to effectively assign users to custom agent experience profiles and provide a targeted app experience for users, based on their roles.

> [!NOTE]
> The **Set as default** and **Set rank and roles** options aren't applicable to profiles that are available out-of-the-box.

:::image type="content" source="media/agent-exp-profiles-options-mini.png" alt-text="agent experience profiles options" lightbox="media/agent-exp-profiles-options.png":::

## Set a default custom agent experience profile

1. In **Customer Service admin center** select **Workspaces** in **Agent experience**.
1. On **Agent experience profiles** select a custom agent experience profile, and then select  **Set as default**.

When you've set a default custom profile, all the options configured in the profile such as specific session templates, conversation channels, and productivity tools are available for all the users.

> [!NOTE]
> - The default custom profile isn't applicable to a user who is assigned specifically to a different custom profile.
> - You can't set the agent profiles that are available out of the box as default profiles.

For example, the following table summarizes the two custom agent profiles that you've configured:

|Agent experience profile   | Configuration   | User |
|----------|-----------|------------|
| Contoso agent profile     | knowledge search and agent scripts features are enabled  | default        |
| Datum agent profile | smart assist, agent scripts, and knowledge search features are enabled  | John Doe |

All the users in the organization can access knowledge search and agent scripts in their productivity pane. User, John Doe, can who can also access smart assist apart from knowledge search and agent scripts.

### Set an alternate custom profile as default profile

You can't set multiple custom profiles as the default profile. If you must change the default custom profile, use **Remove Default** to remove the default status for a profile. You can then set an alternate profile as the default custom profile.

## Add a profile to a security role

When you have multiple user groups with different roles and privileges, you can assign a custom agent profile to a user role to provide customized app experiences.

1. In **Customer Service admin center** select **Workspaces** in **Agent experience**.
1. On **Agent experience profiles** select a custom agent experience profile, and then select  **Set rank and roles**. 
   > [!NOTE]
   > If the default custom profile is set, you can't assign the same profile to user security roles.
1. In **Profile rank and roles assignment** specify the following:
     - **Rank**: Used to determine the custom agent profile that must be mapped to a user when multiple roles are assigned to a user.
     - **Roles**: The user roles that the custom agent profile can be mapped to.
1. To remove an agent experience profile to 

For example, user John Doe has both the Customer Service Representative and Omnichannel agent roles assigned. The table summarizes the mapping of agent profiles to the corresponding roles.

|Agent experience profile   | Rank  | Security Role|
|----------|-----------|------------|
| Contoso agent profile     |1 | Customer Service Representative |
| Datum agent profile |2   |  Omnichannel agent |

In this scenario, the user John Doe is assigned the Contoso agent profile as the rank of the profile is higher.

## Manage users assigned to custom agent profile

The application lets you set a default agent profile and assign custom agent profiles to a security role. However, the default agent profiles aren't applicable to the users who are assigned the security roles with agent profiles mapped.

:::image type="content" source="media/agent-exp-profiles-mini.png" alt-text="agent experience profiles" lightbox="media/agent-exp-profiles.png":::

For example, you've set up your agent experience profiles and mapped users as summarized in the table:

|Agent experience profile   | Rank  | Security Role|User |
|----------|-----------|------------|---------------|
| Contoso Supervisor profile     |1 | Omnichannel Supervisor | |
| Datum agent profile |2   | Omnichannel agent | Kendall Collins|
| Contoso Agent profile | | | default|
| Datum printer agent | | | Gabriel Diaz, Kayla Lewis|

Here's how the application assigns the agent profiles:

- Users with the Omnichannel Supervisor role are assigned the Contoso Supervisor profile.
- Users with the Omnichannel agent role are assigned the Datum agent profile.
- Users with both the Omnichannel Supervisor and the Omnichannel agent role are assigned the Contoso Supervisor profile.
- User Kendall Collins is assigned the Datum agent profile.
- Users Gabriel Diaz and Kayla Lewis are assigned the Datum printer agent profile.
- All the remaining users are assigned the Contoso Agent profile.

> [!NOTE]
> If you haven't set a default custom profile or assigned an agent profile to a role, the application assigns the default out-of-the box profile to all the available users.

### See also

[FAQ about adding users to agent experience profile](faq-agent-experience-profile.md)<br>
[Create and use agent experience profiles](create-agent-experience-profile.md)<br>
[Manage session template](session-templates.md)  
[Overview of Dynamics 365 Productivity Tools](productivity-tools.md)  
[Overview of channels in Omnichannel for Customer Service](../customer-service/channels.md)  
[Overview of agent experience profiles](overview.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
