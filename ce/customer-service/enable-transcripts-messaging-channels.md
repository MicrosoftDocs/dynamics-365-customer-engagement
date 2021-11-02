---
title: "Enable transcript for messaging channels in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how to set up the transcript experience for messaging channels in Omnichannel for Customer Service."
ms.date: 11/02/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Enable the transcription experience for messaging channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

As an administrator, you can enable live transcription and recording of conversations, which allows agents and supervisors to view transcripts of customer conversations. The transcriptions include sentiment analysis data and can be searched through.

> [!IMPORTANT]
> Many countries and states have laws and regulations that apply to the recording of PSTN, voice, and video calls, and may require that users first consent to the recording of their communications. It is your responsibility to use the call recording capabilities in compliance with the law. Before using call recording features, you must obtain consent from the parties of recorded communications in a manner that complies with all applicable laws for each participant.

## Enable the transcript experience

> ![NOTE]
> This feature is generally available; however, in some environments, you might see a preview tag or banner in the interface. Any preview annotations for this feature can safely be ignored.

Do the following to enable transcripts:

1. In the Omnichannel admin center, under **Advanced settings** on the sitemap, select **Agent experience**.

2. For **Transcript**, select **Manage**.

   > [!div class="mx-imgBorder"]
   > ![Advanced settings transcript option.](./media/voice-channel-enable-recordings-transcripts.png)

3. On the **Omnichannel Configuration Transcript settings** page, turn on the **Try out our new transcript experience for digital messaging channels** toggle.

4. Select **Save**.

> [!NOTE]
> The current transcript viewer experience will be deprecating at the end of the year, and will be replaced with this new transcript experience.

## View the transcripts

You can view the conversation transcriptions in the Omnichannel admin center and Omnichannel for Customer Service apps.

To view transcripts in Omnichannel admin center, do the following:

1. On the Omnichannel admin center site map, select **Users**, and then select the user whose conversations you want to view.
2. Select the **Related** tab, and then select **Conversations** from the dropdown menu.
3. Select **Closed conversations** from the dashboard dropdown menu.
4. Select the conversation for which you want to access the transcript.
  
   > [!div class="mx-imgBorder"]
   > ![Screenshot of closed conversation list in Omnichannel admin center.](./media/voice-channel-conversations-list.png)

To view transcripts in Omnichannel for Customer Service, do the following:

1. Open the Omnichannel for Customer Service app, and then switch to the **Omnichannel Agent Dashboard** view.
   Completed chat conversations are displayed in the **Closed work items** column.
2. Do one of the following:<br>
    a. Select the closed work item for which you want to view the transcript.<br>
    OR<br>
    b. Right-click the three dots to view the transcript.
    
   > [!div class="mx-imgBorder"]
   > ![Screenshot of closed conversation list in Omnichannel for Customer Service.](./media/agent-dashboard-closed-chat.png)

### See also

[Configure chat](add-chat-widget.md)  
[View communication panel](oc-conversation-control.md)
