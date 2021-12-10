---
title: "Manage phone music in the voice channel | MicrosoftDocs"
description: "Use this topic to understand how you can configure hold and wait music in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/10/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage phone music

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Services comes with out-of-the-box music files that you can use to set hold tunes and wait tunes. You can replace them with your own music files, or even upload new ones to be used for hold or wait music for your customer calls. The hold or wait music will automatically be played on loop.

You can also configure hold and wait music for each language in each of the workstreams.

> [!Note]
> - Music files can be up to 20 MB. For best experience, upload MP3 files. 
> - The music files must have the ID3 tags so that they play successfully when the call is put on hold.

## Edit music files

You can update existing music files and replace them with your own music files.

**To use existing music files**

1. In Omnichannel admin center, go to **Advanced settings** > **Customer settings**.

2. In the **Customer experience** area, select **Phone music**, and then select **Manage**.
   You'll see a list of out-of-the-box music files.

3. Select any music file from the list and then select **Edit**.

4. In the **Edit phone music** dialog, you can do the following:
   - **Name**: Edit the name of the music file.
   - **Replace**: Select **Replace** to update the music file with any other music file from your computer.
   - You can play the music file to test it.

5. Select **Save and close**.

## Add custom hold and wait music

You can also add new music files to use them in calls as hold and wait music.

**To add new music files**

1. In Omnichannel admin center, go to **Advanced settings** > **Customer settings**.

2. In the **Customer experience** area, select **Phone music**, and then select **Manage**.
   You'll see a list of out-of-the box music files.

3. Select **Add new**.

4. In the **Add new phone music** dialog, enter the following details:
   - **Name**: Enter a name for your music file.
   - **Sound file**: Select **Upload** to upload any sound file from your computer with a file size no more than 20 MB. Be sure to choose some music that loops well.

5. Select **Save and close**.

### See also

[Overview of the voice channel](voice-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
