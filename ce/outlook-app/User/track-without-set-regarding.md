---
title: "Track an email or appointment without linking it to a specific row in your app (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: Use set regarding in Dynamics 365 App for Outlook to link an email message or meeting to a specific row in your Dynamics 365 app.
ms.date: 04/15/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---

# Track an email or appointment without linking it to a specific row 

Use **Track without Regarding** in Dynamics 365 app for Outlook to track an email message or appointment without linking it to a specific row in your app.


1. Open an email or appointment that you want to associate to a row in your app. 

2. Select **Dynamics 365** to open the **Dynamics 365** pane.  

   > [!div class="mx-imgBorder"] 
   > ![Open App for Outlook pane](../media/open-pane-appforoutlook.png)  

3. Next to **Not tracked**, select **More commands** > **Track without Regarding**.

   > [!div class="mx-imgBorder"] 
   > ![Select track without linking the item to a specific row in your app](../media/track-without-regarding.gif)
   
4. The status of the meeting invitation changes to **Processing, please wait** for both the user and the delegated user. Don't close the Outlook item until the status changes to **Track pending**. If you close it too early, then the item may not track successfully. Once the email has finished synchronizing in Microsoft Dataverse, the status of the meeting invitation changes to **Tracked** for both the user and the delegated user.


### View the linked item using Track without Regarding in your app 

1. To see the item in your app, next to **Tracked regarding**, select **More commands** ![More commands for tracked regarding](../media/more-command-button-tracked-regarding.png) > **View in Dynamics 365**.

   > [!div class="mx-imgBorder"] 
   > ![View the tracked item in Dynamics 365](../media/view-in-app.png)  

2. The item is created as an email activity in  Dynamics 365 and isn't linked to a specific row.

   > [!div class="mx-imgBorder"] 
   > ![See the track without regarding item in your app](../media/track-without-regarding-in-app.png)
