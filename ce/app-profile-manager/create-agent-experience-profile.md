---
title: "Configure agent experience profiles | MicrosoftDocs"
description: "Learn how to create and manage agent experience profiles for customized agent experiences."
author: gandhamm
ms.author: mgandham
ms.date: 02/02/2023
ms.topic: article
---

# Create and use agent experience profiles

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

By default, the following agent experience profiles are available out of the box for Customer Service workspace and Omnichannel for Customer Service. These profiles can't be deleted or modified.  When you don't assign a custom profile to an agent, the default profile is assigned.

- Omnichannel for Customer Service - default profile
- Customer Service workspace - default profile
- Customer Service workspace + channels - default profile

You can configure agent experience profiles in Customer Service admin center or app profile manager. The app profile manager can be accessed through Power Apps. 

## Prerequisites

Make sure you have the App Profile Manager Administrator role. More information: [Security roles](security-roles.md)

The Basic User role is also required to create profiles in Customer Service admin center.

## Create agent experience profiles in Customer Service admin center

By using agent profiles, you can create targeted app experiences for agents and supervisors. Profiles help access the features that your agents and supervisors can use in their daily tasks to resolve customer issues.

1. Go to  **Agent experience profiles** in **Agent experience** > **Workspaces**.

1. Select **New**, and enter the following details on the **Create a new agent experience profile** dialog.

   - **Name:** The app profile name.
   - **Unique name:** A unique identifier in the <*prefix*>_<*name*> format.
   - **Description:** A description for the profile.

1. Select **Create**. An agent experience profile is created.

### Assign users, templates, configure productivity pane, channels

For the profile that you created, you can add users and configure option such as specific session templates, conversation channels, and productivity tools.

 Go to **Agent experience profiles** and select the required agent experience profile. You can perform the following actions:

- Set  an agent experience profile as the default profile. If you set a default profile, all the available users are associated with this profile. You can also assign a custom profile to a security role and assign a rank to the profile. More information: [Add users to custom agent experience profiles](add-profile-default.md)
- In the **Users** section, specify the agents this profile must be associated with. Select **Add Users** to select users from the available users, or search for and add users to the profile.
- Select **Add entity session template** to link a session template to the profile. On the **Entity session templates** pane, you can select an existing template or create a new entity session template.
- In the **Productivity pane**, select **Turn on** to enable the productivity tools that the agents can access when they work on their assigned tasks. The following productivity tool options are available:
  
  - Default mode
  - Smart assist
  - Agent scripts
  - Microsoft Teams
  - Knowledge search

  Turn on the toggle against each option in the **Productivity Pane** to enable it for the agent.
- In the **Inbox** section, select **Edit** to enable the inbox view. This allows agents to view all their work items on one screen and helps them to prioritize tasks and efficiently work on multiple tasks.
- In the **Channel providers** section, select **Edit** to enable the channels and select third-party voice channel providers. On the **Channel providers**  pane you can:
  - Turn on the **All active channels** toggle
  - Select a channel provider or create channel providers in the **Third party voice channel providers** section.
  
:::image type="content" source="../customer-service/media/agent-experience-profile.png" alt-text="The agent experience profile with configured settings in Customer Service admin center.":::

### See also

[Manage session template](session-templates.md)  
[Overview of Dynamics 365 Productivity Tools](productivity-tools.md)  
[Overview of channels in Omnichannel for Customer Service](../customer-service/channels.md)  
[Overview of agent experience profiles](overview.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
