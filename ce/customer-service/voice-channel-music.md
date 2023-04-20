---
title: "Manage phone music in the voice channel | MicrosoftDocs"
description: "Use this topic to understand how you can configure hold and wait music in Omnichannel for Customer Service."
ms.date: 11/22/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.custom: 
  - intro-internal
---

# Manage phone music

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

Omnichannel for Customer Service comes with out-of-the-box music files that you can use to set hold tunes and wait tunes. You can replace them with your own music files, or even upload new ones to be used for hold or wait music in your customer calls. The hold or wait music will automatically be played on loop.

You can also configure hold and wait music for each language in each of the workstreams.

> [!Note]
>
> - Music files can be up to 20 MB. For best experience, upload MP3 files.
> - Music files must have the ID3 tags so that they play successfully when the call is put on hold.

## Edit music files

You can update existing music files and replace them with your own music files in the Customer Service admin center or Omnichannel admin center app.

**To update existing music files**

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
     
     1. In the site map, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.
     1. In the **Phone Music** section, select **Manage**.

     The **Phone music** page is displayed.      

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Customer Settings** in **Advanced settings**. The **Customer settings** page appears.
     2. In the **Phone music** section, select **Manage**.

      The **Phone music** page is displayed.

3. Select any music file from the list and then select **Edit**.

4. In the **Edit phone music** dialog, you can do the following:
   - **Name**: Edit the name of the music file.
   - **Replace**: Select **Replace** to update the music file with any other music file from your computer.
   - You can play the music file to test it.

5. Select **Save and close**.

## Add custom hold and wait music

You can also add new music files to use them in calls as hold and wait music.

**To add new music files**

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.
     1. In the **Phone Music** section, select **Manage**.

     The **Phone music** page is displayed.      

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Customer Settings** in **Advanced settings**. The **Customer settings** page appears.
     2. In the **Phone music** section, select **Manage**.

      The **Phone music (preview)** page is displayed.

3. Select **Add new**.

4. In the **Add new phone music** dialog, enter the following details:
   - **Name**: Enter a name for your music file.
   - **Sound file**: Select **Upload** to upload any sound file from your computer with a file size no more than 20 MB. Be sure to choose some music that loops well.

5. Select **Save and close**.

## Add hold and wait music to the workstream

1. In Customer Service admin center or Omnichannel admin center, go to the voice workstreams, and then select the workstream to configure the phone music.
1. Select **Edit** next to the pencil icon, and then on the **Voice settings** page, select **Language**.
1. Select the type of hold and wait music you want the customer to hear. For example, for the primary language, you might always want to use a certain type of hold music, but for a secondary language, you might choose a different type of music.
1. When you've finished configuring the settings, select **Confirm**.

### See also

[Overview of the voice channel](voice-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
