---
title: "Configure post-call recordings and transcripts in the voice channel administrator dashboard | MicrosoftDocs"
description: "Learn how to configure post-call recordings and transcripts in the voice channel for Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 08/23/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ROBOTS: NOINDEX,NOFOLLOW
---

# Preview: Configure post-call recordings and transcripts in the voice channel 

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
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]>

## Enable the transcript experience

As an administrator, you can enable live transcription and recording of conversations, which allows agents and supervisors to listen to call recordings and view transcripts of customer calls.

> [!NOTE] 
> Many countries and states have laws and regulations that apply to the recording of PSTN, voice, and video calls, and may require that users first consent to the recording of their communications. It is your responsibility to use the call recording capabilities in compliance with the law. Before using call recording features, you must obtain consent from the parties of recorded communications in a manner that complies with all applicable laws for each participant.

1. In the Omnichannel admin center, under **Advanced settings** on the sitemap, select **Agent experience**.
2. To the right of **Transcript (preview)**, select **Manage**.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of Advanced settings transcript option.](./media/voice-channel-enable-recordings-transcripts.png)

3. On the **Omnichannel Configuration Transcript settings** page, toggle **Try out our new transcript experience for digital messaging channels** to **Yes**.
4. Select **Save**.


## Enable call recordings and transcripts for each phone number in a workstream

1. In the Omnichannel admin center, under **General settings** on the sitemap, select **Workstreams**.
2. Select the workstream for which you want to enable recordings and transcripts.
3. In the **Phone number** section, next to the pencil icon, select **Edit**.
4. On the **Voice settings** page, select the **Behaviors** tab.
   > [!div class="mx-imgBorder"]
   > ![Screenshot of Behaviors tab on the Voice settings page.](./media/voice-channel-recording-number.png)
5. In the **Transcription and recording** section, select the **Transcript and recording** dropdown menu, select either **Transcription** or **Transcription and recording**, depending on your preference.
6. Select **Save**.


### See also

[Overview of the voice channel](voice-channel.md)<br>
[Agent experience: View call recordings and transcripts](voice-channel-agent-experience.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
