---
title: "Enable a custom entity to appear in the Regarding lookup in Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: Enable activities to use Set Regarding lookup in App for Outlook.
ms.date: 02/16/2020
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
# Enable activities to use Set Regarding lookup in App for Outlook

In App for Outlook **Set Regarding** lets you link an email message, appointment, or task to a specific app record. To use **Set Regarding** activities needs to be enabled for the table. 

Most out-of-box (OOB) tables have activities enabled by default, which cannot be disabled. For custom tables that you create, make sure to enable activities to use **Set Regarding** in App for Outlook. Once activities is enabled it cannot be disabled for any table.


   > [!div class="mx-imgBorder"]
   >![Set regaring lookup](media/set-regarding-lookup.png "Set regarding lookup")


## Enable activities for a table

1. To enable activities, Sign in to [Power Apps](https://make.powerapps.com).

  
2. On the left nav select **Data** to expand it and then select **Tables**.  

   > [!div class="mx-imgBorder"]
   >![Go to Tables in maker portal](media/maker-data-tables.png "Go to Tables in maker portal")
   
  
3. Select a table.

4. On the command bar, select **Settings**. 

   > [!div class="mx-imgBorder"]
   >![Select settings](media/maker-row-settings.png "Select setting")

5. Expand **Collaboration**, and select **Enable for activities**. and then choose **Done**. 

   > [!div class="mx-imgBorder"]
   >![Communication and collaboration activity enabled](media/enable-activity-for-table.png "Communication and collaboration activity enabled")
   
> [!IMPORTANT]
> Once enabled this setting can't be disabled. If prompted, select **Okay** to confirm.
   
6.  Select **Save Table** > and then publish the table.



[!INCLUDE[footer-include](../includes/footer-banner.md)]

See also

[Filter entities and views that appear in Dynamics 365 App for Outlook](https://docs.microsoft.com/dynamics365/customer-engagement/outlook-app/filter-entities-and-views).



