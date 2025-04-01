---
title: Manage custom productivity tools
description: Learn how to manage the custom productivity tools to improve agent productivity in Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.date: 01/16/2024
ms.custom: bap-template
---

# Manage custom productivity tools (preview)

[This article is prerelease documentation and is subject to change.]

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note-d365.md)]

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


The productivity pane supports custom productivity tools developed as custom pages or Power Apps component framework controls. You can create multiple custom productivity tools and make them available to your users with agent experience profiles.

## Prerequisites

Ensure that the following prerequisites are met:

- You have the **Productivity tools administrator** security role. To learn more, see [Assign roles and enable users](../implement/add-users-assign-roles.md).
- Agents and supervisors have the **Productivity tools user** security role. To learn more, see Assign roles and enable users.
- A custom page or a Power Apps component framework control to be hosted as a custom productivity tool. To learn more, see [Overview of custom pages for model-driven apps](/power-apps/maker/model-driven-apps/model-app-page-overview) and [Power Apps component framework](/power-apps/developer/component-framework/overview).

## Configure a custom productivity tool

1. In Dynamics 365, go to Customer Service admin center.
1. In the site map, select **Productivity** in **Agent experience**.
1. On the page that appears, select **Manage** for **Productivity tools (Preview)**.
1. Select **New**, and enter the following details on **New Pane tool configuration**:

   - **Name**: The display name of the custom productivity tool.
   - **Unique Name**: A unique name.
   - **Type**: Select **Control** or **Custom Page**.
     - **Custom Page Name**: The name of the custom page.
     - **Control Name**: The name of the control.
   - **Icon**: The web resource containing the target icon to be displayed in the productivity pane (optional).
   - **Global**: Select **Yes**. The custom tool is globally available across sessions, including the home session.
   - **Description**: A description of the productivity pane (optional).
   - **Learn More Link**: A link to the help page for the custom productivity tool (optional).
1. Save the changes.
1. In the site map, select **Workspaces** in **Agent experiences**, and select **Manage** for **Agent experience profiles**.
1. Select the agent experience profile that you want to modify, and select **Edit** for **Productivity pane** on the page that appears.
1. Enable the custom productivity tool, and save the changes.

 > [!NOTE]
 > Custom productivity tools,
 > - hosted in the productivity pane aren't contextually bound to the session. 
 > - don't have a mechanism to retrieve information from the session context.

### Related information

[Productivity tools in Customer Service](productivity-tools.md)  