---
title: "Create and manage operating hours | MicrosoftDocs"
description: "Instructions to create and manage operating hours in Omnichannel for Customer Service."
author: sbmjais
ms.author: shjais
manager: shujoshi
ms.date: 07/01/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Create and manage operating hours

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Operating hours define the hours when your organization's customer support team is active and available to serve customers. By setting up operating hours, you help your customers and your organization work together to resolve issues. After you create an operating hour record, you must add it to the **Design** tab of the appropriate chat widget to control the display of the widget.

> [!NOTE]
> The chat widget will be shown only during the defined operating hours. At all other times, it will be hidden.

## Create an operating hour record

1. Sign in to Omnichannel Administration.

2. Go to **Settings** \> **Operating Hours**.

3. Select **New** to add an operating hour record.

4. In the **Quick Create: Operating Hour** pane, provide the following information:

    - **Name**: Enter a name for the operating hour record.
    - **24/7**: Select **Yes** if the chat widget should be available 24/7. Select **No** if the chat widget should be available only on specific days of the week. By default, **No** is selected. 
    - **Start time (HH:mm)**: Specify the start time of the operating hours, in 24-hour format.
    - **End time (HH:mm)**: Specify the end time of the operating hours, in 24-hour format.

        > [!NOTE]
        > The end time should not be earlier than the start time. In addition, it should not be less than five minutes after the start time.

    - **Work days**: Specify the days of the week when customer support is available.
    - **Time zone**: Specify the time zone of the operating hours.
    - **Description**: Enter an optional description of the operating hour record.

    > [!div class=mx-imgBorder]
    > ![Create an operating hour record](../media/oc-quick-create-operating-hour.png "Create an operating hour record")

5. Select **Save and close**.

## Add operating hours to chat widget

1.	Open the chat widget to which you want to add operating hours.
2.	Go to the **Design** tab.
3.	In the **Operating hours** field, browse and select the operating hour record. The chat widget is displayed during the hours specified in the selected operating hour record.

    > [!div class=mx-imgBorder]
    > ![Add operating hours in a chat widget](../media/oc-chat-widget-design-tab.png "Add operating hours in a chat widget")

### See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Create quick replies](create-quick-replies.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Dynamics 365 Portals](embed-chat-widget-portal.md)
