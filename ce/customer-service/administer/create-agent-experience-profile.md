---
title: Configure experience profiles
description: Learn how to create and manage experience profiles for customized service representative experiences in Dynamics 365 Contact Center and Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 06/10/2025
ms.topic: how-to
---

# Create and use experience profiles

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

By default, the following experience profiles are available out of the box for Copilot Service workspace. These profiles can't be deleted or modified.  When you don't assign a custom profile to a customer service representative (service representative or representative), the system assigns the default profile.

- Omnichannel for Customer Service - default profile
- Customer Service workspace - default profile
- Customer Service workspace + channels - default profile

You can configure experience profiles in Copilot Service admin center. 

## Prerequisites

- The App Profile Manager Administrator role. Learn more in [Security roles](security-roles.md).

- The Basic User role that's required to create profiles in Copilot Service admin center.

## Create experience profiles

By using experience profiles, you can create targeted app experiences for service representatives and supervisors. Profiles help access the features that your service representatives and supervisors can use in their daily tasks to resolve customer issues.

1. In Copilot Service admin center, go to  **Experience profiles** in **Support experience** > **Workspaces**.

1. Select **New**, and enter the following details on the **Create a new experience profile** dialog.

   - **Name:** The app profile name.
   - **Unique name:** A unique identifier in the <*prefix*>_<*name*> format.
   - **Description:** A description for the profile.

1. Select **Create**. An experience profile is created.

### Assign users, templates, configure productivity pane, channels

For the experience profile that you created, you can add users and configure options, such as specific session templates and conversation channels.

1. Go to **Experience profiles**, select the checkbox for the profile, and then configure the following settings:

   - On the command menu, use the **Set as default** option to set the profile as the default profile. If you set a default profile, all the available users are associated with this profile.
   - Use **Set rank and roles** to assign a rank and security roles to the profile. Learn more in [Add users to custom experience profiles](add-profile-default.md).
1. Optionally, select **Search by user** to search for users to see if they are already associated with a profile. Learn more in [search for users](add-profile-default.md#search-for-users).
1. Select the profile and on the profile page that appears, perform the following steps:
   - In the **Users** section, select **Add Users** to select users from the available users, or search for and add users to the profile.
   - Select **Add entity session template** to link a session template to the profile. On the **Entity session templates** pane, you can select an existing template or create an entity session template.
   - In the **Productivity pane**, select **On** to enable the productivity tools pane and then turn on the options that the service representatives can access when they work on their assigned tasks. The following productivity tool options are available:
  
      - Default mode: Set the toggle to expanded or collapsed mode as the default.
      - Copilot
      - Knowledge search
      - Scripts
      - Join a Teams call
      - Teams chats
      - Smart assist
      - Case handling time
      
      Turn on the toggle against each option in the **Productivity Pane** to enable it for the service representative.
   - In the **Inbox** section, select **Edit** to enable the inbox view. Service representatives can view all their work items on one screen and prioritize tasks and efficiently work on multiple tasks.
   - In the **Channel providers** section, select **Edit** to enable the channels and select non-Microsoft voice channel providers. On the **Channel providers**  pane you can:
      - Turn on the **All active channels** toggle. All the channels that you have set up and the presence settings are loaded.
      - Select a channel provider or create channel providers in the **Third party voice channel providers** section.
  
     :::image type="content" source="../media/agent-experience-profile.png" alt-text="The experience profile with configured settings in Copilot Service admin center.":::

### Enable Copilot features for experience profiles

To enable service representatives to use the copilot features in Copilot Service workspace, you need to enable the copilot features inexperience profiles. By default, service representatives added to the out-of-the-box experience profiles can use the Copilot features. Learn more in [Make Copilot available to service representatives](configure-copilot-features.md#make-copilot-available-to-representatives).

### Related information

[Manage session template](session-templates.md)  
[Overview of Dynamics 365 Productivity Tools](productivity-tools.md)  
[Overview of channels in Dynamics 365 Contact Center](../use/channels.md)  
[Overview of experience profiles](overview.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
