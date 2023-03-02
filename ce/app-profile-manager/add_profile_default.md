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

:::image type="content" source="media/agent-exp-profiles-options-mini.png" alt-text="agent experience profiles options" lightbox="media/agent-exp-profiles-options.png":::

## Set a default custom agent experience profile

1. In **Customer Service admin center** select **Workspaces** in **Agent experience**.
1. On **Agent experience profiles** select a custom agent experience profile, and then select  **Set as default**.

When you've set a default custom profile, all the options configured in the profile such as specific session templates, conversation channels, and productivity tools are available for all the users.

> [!NOTE]
> - The default custom profile isn't applicable to a user who is assigned specifically to a different custom profile.
> - You can't set the agent profiles that are available out of the box as default profiles.

For example, you've created a new custom agent profile, Contoso Agent profile, with knowledge search and agent scripts features enabled. If you set the Custom Agent profile as the default profile, all the users in the organization can access knowledge search and agent scripts in the productivity pane.

You've also create another custom agent profile, Datum Agent profile, with the smart assist feature enabled. You add only a specific user, Angel Chiu to this agent profile. 

In this scenario, the configurations in Contoso Agent profile don't apply to the user. Hence, Angel Chiu can access only the smart assist feature in the productivity pane.

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

For example, user John Doe has both the Customer Service Representative and Omnichannel agent roles assigned. The table summarizes the mapping of agent profiles to the corresponding roles.

|Agent experience profile   | Rank  | Security Role|
|----------|-----------|------------|
| Contoso Agent profile     |1 | Customer Service Representative |
| Datum Agent profile |2   |  Omnichannel agent |

The application assigns the Contoso agent profile to John Doe, as the rank of the profile is higher.

### Remove rank and roles assigned to a custom profile

You can remove the rank and roles assigned to a custom agent profile by selecting the required custom agent profile and then selecting **Remove rank and roles**. If you select this option, all the roles mapped to the profile will be removed.

## Manage users assigned to custom agent profile

The application lets you set a default agent profile and assign custom agent profiles to a security role. However, the default agent profiles aren't applicable to the users who are assigned the security roles with agent profiles mapped.

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
