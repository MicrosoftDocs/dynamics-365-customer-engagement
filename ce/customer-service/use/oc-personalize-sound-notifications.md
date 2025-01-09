---
title: Personalize sound notifications in Omnichannel for Customer Service.
description: Learn how agents can personalize sound notification settings in their agent app.
ms.date: 08/30/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---

# Personalize sound notification settings

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

You can personalize sound notification settings for incoming conversation requests using the personalization menu available on the application tab panel. The sound notifications are available across all channels and can also be set for messages for ongoing conversations.

## Prerequisites

- You can personalize the sound notifications only when your administrator has enabled the corresponding setting. Learn more at [Enable sound notifications](../administer/enable-sound-notifications.md) 
- Your browser should allow sounds to be played. In Microsoft Edge, sound is allowed by default. However, if for some reason, sound settings are turned off, you can enable them by going to the [media autoplay](edge://settings/content/mediaAutoplay) setting in Microsoft Edge. For information on how to enable sound notifications for other browsers, see the browser-specific documentation.

## Personalize sound notifications

The personalized settings have precedence over the administrator settings. You can enable notifications at each channel level for all the channels that are provisioned and available for you.

1. In the site map of Customer Service admin center or Contact Center admin center, select **Personalization** in **Service**.

2. On the **Personalization** tab, select **Sound Settings**.

3. Set the toggle to **Yes** for **Turn on sound notifications**. The **Personalization User settings** area is displayed.

4. Personalize the following settings for the channels:
   - **Play Sound:** Set the toggle to **Yes**.
   - **Sound:** Accept the default setting or search and select a different audio file. You can use the **New Audio File** option to upload and use an audio file of your choice. You also have the option to preview the audio.
   - **Repeat until answered:** Set the toggle to **Yes** if you want the sound to be played until you respond.
   - **Volume:** Accept the default setting or use the slider to adjust the volume.
     
     > ![Personalize sound notifications.](../media/oc-personalize-sound-notifications.png "Personalize sound notifications")
   
   - **Reset to default settings:** When you customize any setting, the button is enabled for you to reset to the out-of-the-box settings.

4. In the **Incoming messages for open sessions** section, customize the options for sound notifications for messages in open sessions, such as live chat or a social channel.
   
5. Select **Save**.

### Related information

[View communication panel](oc-conversation-control.md)  
[View notifications](oc-notifications.md) 


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
