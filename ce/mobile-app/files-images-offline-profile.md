---
title: "Configure mobile offline profiles for files and images| MicrosoftDocs"
ms.custom: 
description: Configure mobile offline profiles for files and images for Dynamics 365 phones and tablets app and Power Apps mobile.
ms.date: 10/15/2021
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

Add all tables to your mobile offline profile where the column type is a image. For any tables that have an image column, add the **Image Descriptor** table to make images available in offline mode.

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

7. Select **Image Descriptor** and then select **Next**.

   > [!div class="mx-imgBorder"]
    >![Select image descriptor.](media/offline-file-images.png "Select image descriptor")

8. Under **Choose the records that you want to make available offline**, select **Related records only**.
9. Expand **Relationships** and select **Field name**

   > [!div class="mx-imgBorder"]
    >![Add image descriptor.](media/offline-file-images-2.png "Add image descriptor")
   
10. For each table with a image column to be downloaded, select **Field name: Regarding**.
    
11. Select **Save**.


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
9. Expand **Relationships** and select **Image Descriptor, Field name**.

   > ![Note] Don't select **Image Descriptor, Field name: Regarding**.

10. For each table with a file column to be downloaded, select **Field name: Regarding**. 

    > [!div class="mx-imgBorder"]
    >![Add FileAttachment table.](media/offline-file-images-3.png "Add FileAttachment table.")
   

 11. Select **Save**. 
  
