---
title: "Configure mobile offline profiles for files and images| MicrosoftDocs"
ms.custom: 
description: Configure mobile offline profiles for files and imagese for Dynamics 365 phones and tablets app and Power Apps mobile.
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

# Configure mobile offline profiles for files and images

To work with files and images in  offline mode, you must add additional tables and relationships. 

This should be considered when the profile contains tables where **Date type** is a file or image.

To find the maximum size for files and images, go to column settings in **Advanced options** in Power Apps for columns where **Data type** is an **Image**.

> [!div class="mx-imgBorder"]
>![Maximum size for files and images.](media/offline-file-images-1.png "Maximum file and image size")

Legend

1. Date type is a file or image.
2. Maximum size for a file or image.
   
## Expand a mobile offline profile to include files and images

1.	Make sure to first add all applicable tables with file and/or image type columns.
2.	If at least one table has an image column, add the **Image Descriptor (table)** to make images available offline.


   > [!div class="mx-imgBorder"]
    >![Add image descriptor.](media/offline-file-images-2.png "Add image descriptor")

3.	Select Related records only.
4.	Under Relationships:
a.	For each table with image columns, select Field name: under Relationships.
5.	Add the **FileAttachment table**. This is required to make images and files available offline:

    > [!div class="mx-imgBorder"]
    >![Add FileAttachment table.](media/offline-file-images-3.png "Add FileAttachment table.")
    
6.	Select Related records only.
7.	Follow these steps, Under Relationships
  .	Select Image Descriptor, Field name:.
Do not select Image Descriptor, Field name: Regarding.
  b.	For each table with image and/or file columns to be downloaded, select Field name: Regarding. 
