---
title: "Enable a custom entity to appear in the Regarding lookup in Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: Enable activities to use Set Regarding lookup in App for Outlook.
ms.date: 05/20/2021
ms.reviewer: jimholtz
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: sidhartg
ms.author: sidhartg
search.audienceType: 
  - admin
  - customizer
  - enduser
---
# Enable activities to use Set Regarding lookup in App for Outlook

In App for Outlook the **Set Regarding** lookup lets you link an email message, appointment, or task to a specific app row. To use the **Set Regarding** lookup, activities need to be enabled for the table. 

Most out-of-box (OOB) tables have activities enabled by default, which cannot be disabled. For custom tables that you create, make sure to enable activities to use  the **Set Regarding** lookup in App for Outlook. Once activities are enabled, it cannot be disabled for any table.


   > [!div class="mx-imgBorder"]
   >![Set regaring lookup.](media/set-regarding-lookup.png "Set regarding lookup")


## Enable activities for a table

1. To enable activities, Sign in to [Power Apps](https://make.powerapps.com).

  
2. On the left nav, select **Dataverse** to expand it and then select **Tables**.  

   > [!div class="mx-imgBorder"]
   >![Go to Tables in maker portal.](media/maker-data-tables.png "Go to Tables in maker portal")
![Screenshot of the Power Apps window, which shows the Dataverse menu open and the Tables menu item is highlighted.](https://user-images.githubusercontent.com/57445531/160470571-79831772-d686-4627-836c-f823c06e3d27.png)

   
  
3. Select a table.

4. On the command bar, select **Settings**. 

   > [!div class="mx-imgBorder"]
   >![Select settings.](media/maker-row-settings.png "Select setting")

5. Expand **Advanced options** > **Make this table an option when**, and select the checkbox for **Creating a new activity**.
6. 
   > [!div class="mx-imgBorder"]
   >![Communication and collaboration activity enabled.](media/enable-activity-for-table.png "Communication and collaboration activity enabled")
   ![Screenshot of the Power Apps window, which shows that the Creating a new activity checkbox is filled.](https://user-images.githubusercontent.com/57445531/160470941-1077d61f-f287-44bb-905c-defde6e4d662.png)

  > [!IMPORTANT]
  > Once enabled this setting can't be disabled. If prompted, select **Okay** to confirm.
   
6.  Select **Save**.


## Verify the table is added to the app designer


1. Sign in to [Power Apps](https://make.powerapps.com).
2. On the left navigation pane, select **Apps**.
3. From the list of apps select **Dynamics 365 App for Outlook** and then select **Edit**.

   > [!div class="mx-imgBorder"]
   > ![Select Dynamics 365 App for Outlook and then select edit.](media/edit-apps-outlook.png)

4. In the app designer, choose table and browse to find your custom table.

   > [!div class="mx-imgBorder"]
   > ![Select and add the custom table.](media/app-designer-add-table.png)

5. Select **Save** and then **Publish** the app.



## See also

[Filter entities and views that appear in Dynamics 365 App for Outlook](/dynamics365/customer-engagement/outlook-app/filter-entities-and-views).


[!INCLUDE[footer-include](../includes/footer-banner.md)]
