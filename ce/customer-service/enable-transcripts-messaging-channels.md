---
title: "Enable transcript for messaging channels in Omnichannel for Customer Service | MicrosoftDocs"
description: "Enable transcript for messaging channels in Omnichannel for Customer Service"
ms.date: 08/31/2021
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

# Preview: Enable transcription of conversations for messaging channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
>
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]


## Introduction

As an administrator, you can enable live transcription and recording of conversations, which allows agents and supervisors to view transcripts of customer conversations. The transcriptions include sentiment analysis data and can be searched through.

> [!NOTE]
> Many countries and states have laws and regulations that apply to the recording of PSTN, voice, and video calls, and may require that users first consent to the recording of their communications. It is your responsibility to use the call recording capabilities in compliance with the law. Before using call recording features, you must obtain consent from the parties of recorded communications in a manner that complies with all applicable laws for each participant.

## Enable the new transcript experience

Do the following to enable transcripts:

1. In the Omnichannel admin center, under **Advanced settings** on the sitemap, select **Agent experience**.

2. For **Transcript (preview)**, select **Manage**.

   > [!div class="mx-imgBorder"]
   > ![Advanced settings transcript option.](./media/voice-channel-enable-recordings-transcripts.png)

3. On the **Omnichannel Configuration Transcript settings** page, turn on the **Try out our new transcript experience for digital messaging channels** toggle.

4. Select **Save**.

## View the transcripts

You can view the conversation transcriptions in Omnichannel admin center.

1. On the Omnichannel admin center site map, select **Users**, and then select the user whose conversations you want to view.
2. Select the **Related** tab, and then select **Conversations** from the dropdown menu.
3. Select **Closed conversations** from the dashboard dropdown menu.
4. Select the conversation for which you want to access the transcript.
  
   > [!div class="mx-imgBorder"]
   > ![Screenshot of closed conversation list.](./media/voice-channel-conversations-list.png)

### See also

[Configure chat](add-chat-widget.md)  
[View communication panel](oc-conversation-control.md)
