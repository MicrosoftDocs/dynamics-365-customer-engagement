---
title: Configure agent experience profiles
description: Learn how to create and manage agent experience profiles for customized agent experiences.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 01/20/2025
ms.topic: article
---

# Create and use agent experience profiles

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

By default, the following agent experience profiles are available out of the box for Customer Service workspace and Contact Center workspace. These profiles can't be deleted or modified.  When you don't assign a custom profile to an agent, the system assigns the default profile.

- Omnichannel for Customer Service - default profile
- Customer Service workspace - default profile
- Customer Service workspace + channels - default profile

You can configure agent experience profiles in Customer Service admin center. 

## Prerequisites

- The App Profile Manager Administrator role. Learn more in [Security roles](security-roles.md).

- The Basic User role that's required to create profiles in Customer Service admin center.

## Create agent experience profiles

By using agent profiles, you can create targeted app experiences for agents and supervisors. Profiles help access the features that your agents and supervisors can use in their daily tasks to resolve customer issues.

1. In Customer Service admin center or Contact Center admin center, go to  **Agent experience profiles** in **Agent experience** > **Workspaces**.

1. Select **New**, and enter the following details on the **Create a new agent experience profile** dialog.

   - **Name:** The app profile name.
   - **Unique name:** A unique identifier in the <*prefix*>_<*name*> format.
   - **Description:** A description for the profile.

1. Select **Create**. An agent experience profile is created.

### Assign users, templates, configure productivity pane, channels

For the agent experience profile that you created, you can add users and configure options, such as specific session templates and conversation channels.

1. Go to **Agent experience profiles**, select the checkbox for the profile, and then configure the following settings:

   - On the command menu, use the **Set as default** option to set the profile as the default profile. If you set a default profile, all the available users are associated with this profile.
   - Use **Set rank and roles** to assign a rank and security roles to the profile. Learn more in [Add users to custom agent experience profiles](add-profile-default.md).
1. Select the profile and on the profile page that appears, perform the following steps:
   - In the **Users** section, select **Add Users** to select users from the available users, or search for and add users to the profile.
   - Select **Add entity session template** to link a session template to the profile. On the **Entity session templates** pane, you can select an existing template or create an entity session template.
   - In the **Productivity pane**, select **Turn on** to enable the productivity tools that the agents can access when they work on their assigned tasks. The following productivity tool options are available:
  
      - Default mode
      - Copilot
      - Knowledge search
      - Agent scripts
      - Join a Teams call
      - Teams chats
      - Smart assist
      
      Turn on the toggle against each option in the **Productivity Pane** to enable it for the agent.
   - In the **Inbox** section, select **Edit** to enable the inbox view. Agents can view all their work items on one screen and prioritize tasks and efficiently work on multiple tasks.
   - In the **Channel providers** section, select **Edit** to enable the channels and select non-Microsoft voice channel providers. On the **Channel providers**  pane you can:
      - Turn on the **All active channels** toggle. All the channels that you have set up and the presence settings are loaded.
      - Select a channel provider or create channel providers in the **Third party voice channel providers** section.
  
     :::image type="content" source="../media/agent-experience-profile.png" alt-text="The agent experience profile with configured settings in Customer Service admin center.":::

### Enable Copilot features for agent experience profiles

To enable agents to use the copilot features in Customer Service workspace, you need to enable the copilot features in agent experience profiles. By default, agents added to the out-of-the-box agent experience profiles can use the Copilot features. Learn more in [Make Copilot available to agents](configure-copilot-features.md#make-copilot-available-to-agents).

### Related information

[Manage session template](session-templates.md)  
[Overview of Dynamics 365 Productivity Tools](productivity-tools.md)  
[Overview of channels in Omnichannel for Customer Service](../use/channels.md)  
[Overview of agent experience profiles](overview.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
