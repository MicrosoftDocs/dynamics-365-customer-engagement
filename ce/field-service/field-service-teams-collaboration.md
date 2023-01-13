---
title: "Collaborate on work orders with Microsoft Teams (Dynamics 365 Field Service) (contains video) | MicrosoftDocs"
description: Collaborate in the context of work orders by integrating with Microsoft Teams
ms.date: 08/26/2022
ms.reviewer: mhart
ms.topic: article
ms.author: jacoh
author: jasonccohen
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Collaborate on work orders with Microsoft Teams

Integrate with Microsoft Teams to chat with team members in the context of work orders. Teams integration makes it easy to find answers and fix issues the first time. It also makes it easy to understand which team members may have previously worked on a work order.

> [!div class="mx-imgBorder"]
> ![Field Service work order, with a Teams chat panel showing related chats.](./media/work-order-teams-messages.png)

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWOc1n]

## Prerequisites

You must set up the overall integration between Microsoft Teams and Dynamics 365 apps. Go to 

Go to **Advanced Settings** > **Administration** > **System Settings** > **General** > **Microsoft Teams Integration**.

- Enable **Basic** Microsoft Teams Integration (requires system admin permissions)
- Enable **Enhanced** Microsoft Teams integration (requires tenant admin permissions). 

For more information, see [Install and set up Teams Integration](/dynamics365/teams-integration/teams-install-app).

## Configure collaboration settings in Field Service

When signed into Dynamics 365, go to **Microsoft Teams Integration** > **Collaboration Settings** and set the toggles to **Yes**.

:::image type="content" source="media/teams-integration-settings.png" alt-text="Screenshot of the collaboration settings in Field Service.":::

In the **Connect chats to Dynamics 365 records** section, add Work Orders and any other tables you'd like to collaborate on.

## Create a new chat from a work order

To start a new chat from a work order, go to **Field Service** > **Work orders** > and select a work order.

In the top-right corner of your screen, select the chat box icon to open the Teams chats panel. In the Teams chats panel, you'll see a list of chats that are contextually linked to the current work order, along with other chats in your Teams history.

:::image type="content" source="media/work-order-teams-create.png" alt-text="Field Service work order, showing linked chats in the Teams chats panel.":::

Select **New connected chat** to start a new chat that will be linked to the current work order. Add the relevant participants. By checking the **Send introduction message**, you'll start the conversation with the relevant details shown between participants of the conversation. Select **Start chat** to start the conversation.

:::image type="content" source="media/work-order-teams-compose.png" alt-text="Field Service work order Teams chat, showing a new chat linked to the work order.":::

## Connect and disconnect existing chats

To connect an existing chat to a work order, select the ellipses icon next to the chat in the Teams panel, and select **Connect to this Work Order**. That chat will now appear in the top section of the Teams panel, where other chats linked to this work order appear.

:::image type="content" source="media/work-order-teams-link-to-work-order.png" alt-text="Teams chat panel on the work order, showing the option to link chat to the work order.":::

To unlink the chat from the work order, select the ellipses icon next to the connected chat, and then **Disconnect from this Work Order**.

## Customize welcome message

When new chats are started from the work order (or other record types), some information is already defined as a welcome message in the chat panel.

To customize the information in the welcome message, go to **Microsoft Teams Integration** > **Collaboration Settings**.

Select the work order record type, then choose a view from the system. **Save** when done.

:::image type="content" source="media/work-order-teams-welcome-view.png" alt-text="Teams integration collaboration settings in Dynamics 365, showing the work order settings.":::

The first five columns in the view you choose will be shown in the welcome message when you invite someone to collaborate on a work order.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
