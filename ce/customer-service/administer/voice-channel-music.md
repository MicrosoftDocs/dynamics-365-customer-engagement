---
title: "Manage phone music in the voice channel | MicrosoftDocs"
description: "Use this topic to understand how you can configure hold and wait music in Contact Center admin center."
ms.date: 06/14/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.collection: get-started
---

# Manage phone music

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!NOTE] 
> We recommend that you use the audio file formats that are supported by Azure Communication Services. Learn more at [Playing audio in call](/azure/communication-services/concepts/call-automation/play-action). 

You can use the out-of-the-box music files to set hold and wait tunes. You can replace them with your own music files, or even upload new ones to be used for hold or wait music in your customer calls. The hold or wait music will automatically be played on loop.

You can also configure hold and wait music for each language in each of the workstreams.

The following characteristics are applicable to the music files.

- The files can be up to 20 MB; for best experience, upload MP3 files.
- The files must have the ID3 tags so that they play successfully when the call is put on hold.
- The quality of the audio files that you upload might be reduced because audio file URLs are embedded in Speech Synthesis Markup Language (SSML). The telephony gateway gets Pulse Code Modulation (PCM) 16k audio bytes as part of the speech orchestration. More information: [Add recorded audio](/azure/ai-services/speech-service/speech-synthesis-markup-voice#add-recorded-audio).
- When audio files pass through public service telephone networks (PSTN), their quality might be reduced to a sample rate of 8 kHz (narrowband). While the voices in these files remain audible, the music quality isn't good. We recommend that you lower the sample rate of the music file to 8 kHz and assess whether the sound quality is good.
- Hold music files are played directly and aren't embedded in SSML.

## Edit music files

You can update existing music files and replace them with your own music files in the Customer Service admin center or Contact Center admin center app.

**To update existing music files**

1. In the site map, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.
1. In the **Phone Music** section, select **Manage**. The **Phone music** page is displayed.
1. Select any music file from the list and then select **Edit**.
1. In the **Edit phone music** dialog, you can do the following:
   - **Name**: Edit the name of the music file.
   - **Replace**: Select **Replace** to update the music file with any other music file from your computer.
   - You can play the music file to test it.
1. Select **Save and close**.

## Add custom hold and wait music

You can also add new music files to use them in calls as hold and wait music.

**To add new music files**

1.In the site map of Customer Service admin center or Contact Center admin center, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.

1.In the **Phone Music** section, select **Manage**. The **Phone music** page is displayed.

1. Select **Add new**.

1. In the **Add new phone music** dialog, enter the following details:
   - **Name**: Enter a name for your music file.
   - **Sound file**: Select **Upload** to upload any sound file from your computer with a file size no more than 20 MB. Be sure to choose some music that loops well.

1. Select **Save and close**.

## Add hold and wait music to the workstream

1. In Customer Service admin center or Contact Center admin center, go to the voice workstreams, and then select the workstream to configure the phone music.
1. Select **Edit** next to the pencil icon, and then on the **Voice settings** page, select **Language**.
1. Select the type of hold and wait music you want the customer to hear. For example, for the primary language, you might always want to use a certain type of hold music, but for a secondary language, you might choose a different type of music.
1. When you've finished configuring the settings, select **Confirm**.

### Related information

[Overview of the voice channel](voice-channel.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
