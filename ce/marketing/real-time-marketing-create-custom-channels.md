---
title: "How to create custom channels (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create custom channels in Dynamics 365 Marketing."
ms.date: 10/27/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---
# Preview: Custom channels

## Install a custom channel app 

To create a new custom channel, you need to begin by installing the corresponding custom channel app first.

There are two ways to install a custom channel app: 

1. Manually create and install the package. [Learn how here](real-time-marketing-extend-outreach-custom-channels).
2. Install the package through AppSource if the app is listed by your service provider.

## Create a new custom channel

1. Start creating a new custom channel from Settings > Custom channels after installing the corresponding custom channel app.

> [!div class="mx-imgBorder"]
> ![create a custom channel](media/real-time-marketing-create-a-custom-channel.png "create a custom channel")

2. Select **+New channel** or **Add a channel** if you have no custom channels created yet.
3. Select the custom channel app you want to use to create your new channel.
3. Enter all the details required to connect the channel.
4. Review and finish the setup.

## Create a custom channel message

To create a new custom channel message for an existing channel, go to Real-time marketing > Channels > More channels.

> [!div class="mx-imgBorder"]
> ![create a custom channel message](media/real-time-marketing-create-a-custom-channel-message.png "create a custom channel message")

To create a new message:
1. Select **+New message**.
2. Select the custom channel you’d like to create a message for.
3. Use the editor to add your message content.
4. Select **Save** to save a draft or **Ready to Send** if your message is ready.

## Use a custom channel in journeys

You can now use custom channel messages in customer journeys the same way you would with an email or SMS template. 

To add a custom channel message action:

1. Select the **+ button** on the canvas and choose the **Send other types of messages** action.

> [!div class="mx-imgBorder"]
> ![use custom channel in journey](media/real-time-marketing-use-custom-channel-in-journey.png "use custom channel in journey")

2. Select the Custom channel and the relevant message you want to send in the right pane

> [!div class="mx-imgBorder"]
> ![select custom channel](media/real-time-marketing-select-custom-channel.png "select custom channel")
