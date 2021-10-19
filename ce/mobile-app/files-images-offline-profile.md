---
title: "Configure mobile offline profiles for files and images| MicrosoftDocs"
ms.custom: 
description: Configure mobile offline profiles for files and images for Dynamics 365 phones and tablets app and Power Apps mobile.
ms.date: 10/18/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
caps.latest.revision: 1
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Sales
---

# Configure mobile offline profiles for images and files 

To work with file and images columns in offline mode, you need to add additional tables and relationships.

Follow the steps in this topic, for a mobile offline profile that has a table with a column where **Date type** is set to a file or image.



## View column properties for file or image 

1. Sign in to [Power Apps](https://make.powerapps.com).

2. On the left nav select **Data** to expand it and then select **Tables**.  

   > [!div class="mx-imgBorder"]
   >![Go to tables.](media/maker-data-tables.png "Go to tables")
  
  
3. Select the **Display name** of a column where **Date type** is set to a file or image.

4. The column properties show the **Date type**. Expand **Advanced options** to view the maximum size for a file or image.

   > [!div class="mx-imgBorder"]
   >![Maximum size for files and images.](media/offline-file-images-1.png "Maximum file and image size")


## Add image columns to mobile offline 

It is required to add both the **Image Descriptor** and **FileAttachment** tables to your mobile offline profile to make images, columns where **Data type** is **Image**, available in offline mode..

1. Go to Power Platform Admin center, [https://admin.powerplatform.microsoft.com](https://admin.powerplatform.microsoft.com) and sign-in as an admin.

2. On the right, select **Environments**.

   > [!div class="mx-imgBorder"]
   >![Select a Environment.](media/offline_admincenter_enviroments.png "Select a Environment")
 
3. Choose an environment and then select **Settings**.

   > [!div class="mx-imgBorder"]
   >![Environment settings.](media/offline_open_an_enviroment.png "Environment settings")
 
4. Expand **Users + permissions**,  and then select **Mobile configuration**.

   > [!div class="mx-imgBorder"]
   >![Mobile configuration setting.](media/offline_mobile_config_settings.png "Mobile configuration settings")

5. Select a mobile offline profile to edit it.

6. In **Data available offline** select **Add table**.

7. Select **Image Descriptor** and then select **Next**.

   > [!div class="mx-imgBorder"]
    >![Select image descriptor.](media/offline-file-images.png "Select image descriptor")

8. Under **Choose the records that you want to make available offline**, select **Related records only**.
9. Expand **Relationships**, for each table with a column to be downloaded, select **Column name**.

   > [!div class="mx-imgBorder"]
    >![Add image descriptor.](media/offline-file-images-2.png "Add image descriptor")
  
10. Select **Save**.
11. In **Data available offline** select **Add table** > **FileAttachment** > **Next**. 
12. Expand **Relationships** and select **Image Descriptor, Column name: FileId**.
    
    > ![Note] Don't select **Image Descriptor, Column name: Regarding**.

    > [!div class="mx-imgBorder"]
    > ![Add FileAttachment table.](media/mobile-offline-edit-image.png "Add FileAttachment table")

10. Select **Save**.

## Add file columns to mobile offline 

Add all tables to your mobile offline profile where the column type is a file. For any tables that have a file column, add the **FileAttachment** table to make file available in offline mode.

1. Go to Power Platform Admin center, [https://admin.powerplatform.microsoft.com](https://admin.powerplatform.microsoft.com) and sign-in as an admin.

2. On the right, select **Environments**.

   > [!div class="mx-imgBorder"]
   >![Select a Environment.](media/offline_admincenter_enviroments.png "Select a Environment")
 
3. Choose an environment and then select **Settings**.

   > [!div class="mx-imgBorder"]
   >![Environment settings.](media/offline_open_an_enviroment.png "Environment settings")
 
4. Expand **Users + permissions**,  and then select **Mobile configuration**.

   > [!div class="mx-imgBorder"]
   >![Mobile configuration setting.](media/offline_mobile_config_settings.png "Mobile configuration settings")

5. Select a mobile offline profile to edit it.

6. In the **Data available offline** select **Add table**.

7. Select **FileAttachment**  and then select **Next**.

   > [!div class="mx-imgBorder"]
    >![Select FileAttachment.](media/offline-file-images-4.png "Select FileAttachment")

8. Under **Choose the records that you want to make available offline**, select **Related records only**.
9. Expand **Relationships** and select applicable **Columns names** i.e., columns for each table where **Data type** is **Image**.

   > ![Note] Don't select **Column name: Regarding.**.

    > [!div class="mx-imgBorder"]
    >![Edit FileAttachment table.](media/offline-file-images-9.png "Edit FileAttachment table.")
   

 11. Select **Save**. 
  
  
  
## Offline status of files and images

You can use the **[Offline Status](work-in-offline-mode.md#see-whether-offline-mode-is-available)** page to see the number of files and images to be downloaded and the current progress.

- The number of images is listed for the **Image Descriptor** table.
- The number of files are listed for each table with file attachments as shown for **DemoTable2** table.

  > [!div class="mx-imgBorder"]
  >![Offline status of files and images.](media/offline-status.png "Offline status of files and images.")
