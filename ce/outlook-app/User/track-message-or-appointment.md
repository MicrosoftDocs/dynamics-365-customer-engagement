---
title: "Link an email message or meeting to a row in your app (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: Use set regarding in Dynamics 365 App for Outlook to link an email message or meeting to a specific row in your Dynamics 365 app.
ms.date: 03/18/2021
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

# Link an email message or appointment to a specific row in your app

Use **Set Regarding** in Dynamics 365 App for Outlook to associate an email message or appointment to a specific row in your app. When you link an email message or appointment to a specific account, opportunity, or case row and the system populates the regarding lookup for the email or appointment and tracks it in your app.


## Link an email message or appointment

1. Open an email or appointment that you want to associate to a row in your app. 

2. Select **Dynamics 365** to open the **Dynamics 365** pane.  

   > [!div class="mx-imgBorder"] 
   > ![Open App for Outlook pane](../media/open-pane-appforoutlook.png)  

3. In the **Set Regarding** textbox, type in your search text and select the row to associate the email or appointment with.

    > [!div class="mx-imgBorder"] 
    > ![Set Regarding](../media/set-regarding.gif)
    
    > [!NOTE]
    > For information on how to use search to look for a row, see [Use the lookup column on a row](/powerapps/user/lookup-field.md).
   
4. When the item is successfully tracked and linked to the selected row, you'll see a **Tracked regarding** message.

   > [!div class="mx-imgBorder"] 
   > ![Item tracked successfully](../media/track-success.png) 

## View a linked email or appointment in your app

You can easily open your app and see the meeting or appointment that you've linked.

- Next to **Tracked regarding**, select **More commands** ![More commands for tracked regarding](../media/more-command-button-tracked-regarding.png) > **View in Dynamics 365**.
   > [!div class="mx-imgBorder"] 
   > ![View the tracked item in Dynamics 365](../media/view-in-app.png)  

## Change the row an email or appointment is linked to

You can change the row an email or appointment is linked to using the **Change Regarding** feature.

1. Open the email or appointment that you want to link to a different row.
2. Select **Dynamics 365** to open the **Dynamics 365** pane.  

   > [!div class="mx-imgBorder"] 
   > ![Open App for Outlook pane](../media/open-pane-appforoutlook.png)  

3. Next to **Tracked regarding**, select **More commands** ![More commands for tracked regarding](../media/more-command-button-tracked-regarding.png) > **Change Regarding**.

   > [!div class="mx-imgBorder"] 
   > ![Change Regarding](../media/change-track-regarding.png)

4. In the **Set Regarding** textbox, enter search text. 

   > [!div class="mx-imgBorder"] 
   > ![Enter your search text](../media/change-track-regarding-1.png)
   
5. When a related row appears, select the row to link the email or appointment to.

   > [!div class="mx-imgBorder"] 
   > ![Select row](../media/change-track-regarding-2.png)

## Untrack a linked email or appointment 

- Next to **Tracked regarding**, select **More commands** ![More commands for tracked regarding](../media/more-command-button-tracked-regarding.png) > **Untrack**.
  > [!div class="mx-imgBorder"] 
  > ![Untrack a email or appointment](../media/untrack-item.png)  

