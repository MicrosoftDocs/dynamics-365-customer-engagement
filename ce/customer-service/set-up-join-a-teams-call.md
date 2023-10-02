---
title: Configure Join a Teams call for agents
description: Learn how to set up the Join a Teams call feature in Dynamics 365 Customer Service.
ms.date: 10/02/2023
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Set up Join a Teams call for agent conversations with customers (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

Join a Teams call is a new feature that helps agents in your organization give their customers a more personalized support experience by using Teams to share their screen, cobrowse, and connect through video. Customers don’t need to have a Teams license or previous experience using Teams.

## Prerequisites

Ensure that the following prerequisites are met:

- Agents in your organization must be able to access and use Teams.
- Agents must be able to access the productivity pane to see the Join a Teams call app. More information: [Assign templates and enable the productivity pane and channels](../app-profile-manager/app-profile-manager.md#assign-templates-and-enable-productivity-pane-and-channels)
- If you want agents to be able to invite their customers to Teams meetings via email, their email must be configured for outbound email.

## Set up Join a Teams call for agents

1.	In Power Platform admin center, go to **Settings** > **Product** > **Collaboration**, and then toggle on **End users can join Teams meetings from appointments**.
   
1.	In Customer Service admin center, go to **Agent experience** > **Collaboration**.
	
1.	In **Join a Teams call**, select **Manage**.

1.	On the **Join a Teams call** page, turn on the toggle for **Join a Teams call**.

1.	If you want to enable the Join a Teams call feature for nondefault agent profiles, you must manually enable them. Select **Manage** next to **Turn on for specific multisession users.** More information: [Add the Teams chat setting page for specific multisession users](configure-teams-chat.md#add-the-teams-chat-settings-page-for-specific-multisession-users)

1. Save the changes. The Join a Teams call feature is now enabled for Customer Service workspace.

### See also

[Configure Teams ](oc-customer-summary.md) <br>
[Use Join a Teams call](join-a-teams-call.md) <br>
[Configure Teams chat in Customer Service](configure-teams-chat.md)
