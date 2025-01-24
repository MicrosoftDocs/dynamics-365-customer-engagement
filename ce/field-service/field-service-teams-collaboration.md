---
title: Collaborate on work orders with Microsoft Teams
description: Collaborate in the context of work orders or other entities by integrating with Microsoft Teams.
ms.date: 01/27/2025
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
---

# Collaborate on work orders with Microsoft Teams

Integrate with Microsoft Teams to chat with team members about work orders. The Teams integration helps find answers and fix issues the first time without leaving the Field Service app. It also lists team members that have previously worked on a work order. Connecting all the associated chats to a work order provides all chats related to that work order in one place.

> [!div class="mx-imgBorder"]
> ![Field Service work order, with a Teams chat panel showing related chats.](./media/work-order-teams-messages.png)

For a guided walkthrough, check out the following video.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=a5d32328-3240-4b00-9392-00c9a4926322]

## Set up the Teams integration

An administrator must set up the overall integration between Microsoft Teams and Dynamics 365 apps. See [Install and set up Teams Integration](/dynamics365/teams-integration/teams-install-app).

## Enable and configure collaboration settings in Field Service

An administrator must enable collaboration in the Field Service settings.

1. In Field Service, go to **Settings** > **Integration** > **Teams Collaboration**. To enable or disable Microsoft Teams chat in other Dynamics 365 apps, see [Work with Microsoft Teams chat in Dynamics 365](/dynamics365/teams-integration/enable-teams-chat).

1. On the **Microsoft Teams collaboration and chat** page, turn on the toggle for **Turn on Microsoft Teams chats inside Dynamics 365**.

   :::image type="content" source="media/teams-integration-settings.png" alt-text="Screenshot of the Teams integration settings in Field Service.":::

1. Select one of the following:

   - **Turn on for all Dynamics 365 apps** – Enables Teams chat for all supported Dynamics 365 apps in your organization, including any that you add in the future.
   - **Turn on for selected Dynamics 365 apps** – Enables Teams chat for the apps you choose. If your organization already uses Teams, the selection you made previously remains. If you haven't yet set up Teams, it's enabled by default.

1. In the **Connect Teams chats to Dynamics 365 records** section, add all the tables you'd like to collaborate on.

1. Save the changes.

## Customize welcome message

When you start a new chat, predefined information creates a welcome message in the chat panel. You can customize the welcome message.

1. In Field Service, go to **Settings** > **Integrations** > **Teams Collaboration**.

1. Under **Connect Teams chats to Dynamics 365 records**, edit *Work Order*.

1. Under **Message view**, select the message you want to show in the first chat. Hover over each option for a description. Or, to create a custom message, select **Create view in Power Apps**.

1. Select **Save**.

The first five columns in the view you choose appears in the welcome message when you invite someone to collaborate on a record. If there's no data in a field, the field doesn't display.

## Create a new chat

To [start a new chat](/dynamics365/customer-service/use/use-teams-chat#start-a-new-connected-chat), open a record for a table that is connected to the Teams integration.

<!--- Can we use this link instead? https://learn.microsoft.com/en-us/dynamics365/sales/teams-integration/using-teams-chat-in-dynamics#start-a-connected-teams-chat-in-dynamics-365 --->

## Connect and disconnect existing chats

[Connect or disconnect and existing chat from a record](/dynamics365/customer-service/use/use-teams-chat#connect-or-disconnect-an-existing-chat-from-a-record).


[!INCLUDE[footer-include](../includes/footer-banner.md)]
