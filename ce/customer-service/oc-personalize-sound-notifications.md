---
title: "Personalize sound notifications in Omnichannel for Customer Service | MicrosoftDocs"
description: "How agents can personalize sound notification settings in Omnichannel for Customer Service."
ms.date: 07/20/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Personalize sound notification settings

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

You can personalize sound notification settings for incoming conversation requests using the personalization menu available on the application tab panel. The sound notifications are available across all channels and can also be set for messages for ongoing conversations.

## Prerequisites

- You can personalize the sound notifications only when your administrator has enabled the corresponding setting. More information: [Enable sound notifications](enable-sound-notifications.md) 
- Your browser should allow sounds to be played. In Microsoft Edge, sound is allowed by default. However, if for some reason, sound settings are turned off, you can enable them by going to the [media autoplay](edge://settings/content/mediaAutoplay) setting in Microsoft Edge. For information on how to enable sound notifications for other browsers, see the browser-specific documentation.

## Personalize sound notifications

The personalized settings have precedence over the administrator settings. You can enable notifications at each channel level for all the channels that are provisioned and available for you.

1. On the application tab panel, select the plus icon, and then select **Personalization**. The **Personalization User settings** page appears.

2. Select **Sound Settings**.

3. Personalize the following settings for the channels:
   - **Play Sound:** Set the toggle to **Yes**.
   - **Repeat until answered:** Set the toggle to **Yes** if you want the sound to be played until you respond.
   - **Sound:** Accept the default setting or search and select a different audio file. You can use the **New Audio File** option to upload and use an audio file of your choice. You also have the option to preview the audio.
   - **Volume:** Accept the default setting or use the slider to adjust the volume.
      > ![Personalize sound notifications.](media/oc-personalize-sound-notifications.png "Personalize sound notifications")
   
   - **Reset to default settings:** When you customize any setting, the button is enabled for you to reset to the out-of-the-box settings.

4. In the **Incoming messages for open sessions** section, customize the options for sound notifications for messages in open sessions, such as live chat or a social channel.
    > ![Sound notification settings for open sessions.](media/sound-notification-open-session.png "Sound notification settings for open sessions")

5. Select **Save**.

### See also

[View communication panel](oc-conversation-control.md)  
[View notifications](oc-notifications.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
