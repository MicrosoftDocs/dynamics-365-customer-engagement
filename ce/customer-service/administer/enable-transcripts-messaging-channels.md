---
title: Enable transcript for messaging channels
description: Learn how to set up the transcript experience for messaging channels in Omnichannel for Customer Service.
ms.date: 04/25/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
search.audienceType: 
  - admin
  - customizer
---

# Enable the transcription experience for messaging channels

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

As an administrator, you can enable live transcription and recording of conversations, which allows customer service representatives (service representatives or representatives) and supervisors to view transcripts of customer conversations. The transcriptions include sentiment analysis data and can be searched through.

> [!IMPORTANT]
> Many countries/regions and states have laws and regulations that apply to the recording of PSTN, voice, and video calls, and may require that users first consent to the recording of their communications. It is your responsibility to use the call recording capabilities in compliance with the law. Before using call recording features, you must obtain consent from the parties of recorded communications in a manner that complies with all applicable laws for each participant.

## Enable the transcript experience

> [!NOTE]
> The transcript feature is generally available; however, in some environments, you might see a preview tag or banner in the interface. Any preview annotations for this feature can safely be ignored.

1. In the site map of Copilot Service admin center, select **Productivity** in **Support experience**.

1. On the **Productivity** page, select **Manage** for **Transcript**.

1. On the **Omnichannel Configuration - Transcript settings** page, turn on the **Try out our new transcript experience for digital messaging channels** toggle.

1. Select **Save**.

## View the transcripts

You can view the conversation transcriptions in the Copilot Service admin center and Copilot Service workspace apps.

1. In the admin center site map, select **User management**, and then select **Manage** for **Users**.
2. Select the user whose conversations you want to view.
3. Select the **Related** tab, and then select **Conversations** from the dropdown menu.
4. Select **Closed conversations** from the dashboard dropdown menu.
5. Select the conversation for which you want to access the transcript.
  
   > [!div class="mx-imgBorder"]
   > ![Screenshot of closed conversation list.](../media/voice-channel-conversations-list.png)

To view transcripts in Copilot Service workspace, do the following:

1. Open the app and then switch to the **Omnichannel Agent Dashboard** view. The completed chat conversations are displayed in the **Closed work items** column.
1. Do one of the following:<br>
 
   1. Select the closed work item for which you want to view the transcript.<br>
   1. Right-click the three dots to view the transcript.

> [!NOTE]
> As an administrator, only you have access to the conversations that are handled by other representatives.

### Related information

[Configure chat](../administer/add-chat-widget.md)  
[View communication panel](../use/oc-conversation-control.md)
