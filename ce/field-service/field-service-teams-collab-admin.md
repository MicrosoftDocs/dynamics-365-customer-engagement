---
title: Set up the Teams integration with Field Service
description: Learn how to integrate Dynamics 365 Field Service with Microsoft Teams.
ms.date: 01/27/2025
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
---

# Set up the Teams integration with Field Service

Set up the Teams integration with Field Service to enable team members to collaborate on work orders. For more information, go to [Overview of Microsoft Teams integration](/dynamics365/teams-integration/teams-integration).

## Set up the Teams integration

[Set up the overall integration between Microsoft Teams and Dynamics 365 apps](/dynamics365/teams-integration/teams-install-app).

## Enable and configure collaboration settings in Field Service

Enable collaboration in Teams.

1. In Field Service, go to **Settings** > **Integration** > **Teams Collaboration**. To enable or disable Microsoft Teams chat in other Dynamics 365 apps, go to [Work with Microsoft Teams chat in Dynamics 365](/dynamics365/teams-integration/enable-teams-chat).

1. On the **Microsoft Teams collaboration and chat** page, turn on the toggle for **Turn on Microsoft Teams chats inside Dynamics 365**.

   :::image type="content" source="media/teams-integration-settings.png" alt-text="Screenshot of the Teams integration settings in Field Service.":::

1. Select one of these options:

   - **Turn on for all Dynamics 365 apps** – Enables Teams chat for all supported Dynamics 365 apps in your organization, including any that you add in the future.
   - **Turn on for selected Dynamics 365 apps** – Enables Teams chat for the apps you choose. If your organization already uses Teams, the selection you made previously remains. If Teams isn't set up, it's enabled by default.

1. In the **Connect Teams chats to Dynamics 365 records** section, add all the tables you'd like to collaborate on.

1. Save the changes.

## Customize welcome message

When a user starts a new chat, predefined information creates a welcome message in the chat panel. Customize the welcome message to your business needs.

1. In Field Service, go to **Settings** > **Integrations** > **Teams Collaboration**.

1. Under **Connect Teams chats to Dynamics 365 records**, edit *Work Order*.

1. Under **Message view**, select the message you want to show in the first chat. Hover over each option for a description. Or, to create a custom message view, select **Create view in Power Apps**.

1. Select **Save**.

The first five columns in the view you choose appears in the welcome message when a user invites someone to collaborate on a record. If there's no data in a field, the field doesn't display.

## See also

[Collaborate on work orders with Microsoft Teams](field-service-teams-collaboration)