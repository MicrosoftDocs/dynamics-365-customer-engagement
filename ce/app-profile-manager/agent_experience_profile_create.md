---
title: "Create and use agent experience profiles | MicrosoftDocs"
description: "Learn how to create and manage app profiles for customized agent experiences."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/04/2022
ms.topic: article
---

# Create and use agent experience profiles

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

## Introduction

By default, the following app profiles are available out of the box for Customer Service workspace and Omnichannel for Customer Service. These profiles can't be deleted or modified. When no app profile is assigned to an agent, the default profile is assigned.

- Omnichannel for Customer Service - default profile
- Customer Service workspace - default profile
- Customer Service workspace + channels - default profile

The app profile manager is available in Power Apps where you'll create the app profiles.

## Prerequisites

Make sure you have the App Profile Manager Administrator role. More information: [Security roles](security-roles.md)

To create agent experience profiles in Customer Service admin center, the Basic User role is also required.

## Create agent experience profiles in Customer Service admin center

By using profiles, you can create targeted app experiences for agents and supervisors. Profiles help access the features that your agents and supervisors can use in their daily tasks to resolve customer issues.

**To create the agent experience profile**

1. In the site map, select **Workspaces** in **Agent experience**.

2. Select **Manage** for **Agent experience profiles**.

3. Select **New**, and enter the following details on the **Create a new agent experience profile** dialog.

   - **Name:** The app profile name.
   - **Unique name:** A unique identifier in the <*prefix*>_<*name*> format.
   - **Description:** A description for the profile.

4. Select **Create**.

### Assign users to the profile

**To assign users to the profile**

1. Go to the profile that you created.
2. On the page that appears, select **Add users**.
3. On the **Add users** dialog, select the users in the **Available users** list, and then select **Add**. Alternatively, you can search for the users using the **Search** box. The assigned users are listed on the profile page. 

### Assign templates, configure productivity pane, channels

Use the options on the profile page to configure the templates that'll define the session behavior. You can turn on the productivity pane and the productivity tools that the agents can access when they work on their assigned tasks. You can also turn on the inbox view so that agents can view all their work items on one screen, that help in prioritizing tasks and working on multiple items more efficient. You can also enable the channels and select third-party voice channel providers.

**To assign templates and configure productivity pane and channels**

1. Select the profile that you need to update.

2. On the page that appears, select **Add entity session template**.

   1. On the **Entity session templates** dialog, use the **Search** box to search for the session template.

   2. Select the required template from the search results, and select **Save and close**.

3. On the profile page, in **Productivity pane**, select **Turn On**. The options for productivity pane appear.

   1. On the Productivity pane dialog, for **Productivity pane**, turn on the toggle. The additional settings are enabled.

   2. Turn on the toggle for the following settings:

      - Default mode
      - Smart assist
      - Agent scripts
      - Microsoft Teams
      - Knowledge search

   3. Select **Save and close**.

4. On the profile page, select **Edit** for **Inbox**. By default the **Inbox** view is turned off.
   1. On the **Inbox** dialog, turn on the toggle.
   2. Select **Save and close**.

5. On the profile page, for **Channel providers**, select **Edit**.
   1. On the **Channel providers** dialog, turn on the **All active channels** toggle.
   2. Optionally, select a channel provider in the **Third party voice channel providers** section.
   3. Select **Save and close**.

:::image type="content" source="../customer-service/media/agent-experience-profile.png" alt-text="The agent experience profile with configured settings in Customer Service admin center.":::