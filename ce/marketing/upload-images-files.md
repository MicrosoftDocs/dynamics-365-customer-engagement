---
title: "Work with images and other files (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to upload, tag, and find images and other files for use in emails and marketing pages in Dynamics 365 for Marketing"
keywords: "image, file, keyword"
ms.date: 04/01/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom:
  - "dyn365-marketing"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 162d17d7-bdd4-4a44-b84f-8ab94e7267f3
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Upload and use images and files in online content

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Images are an important part of most marketing-page and marketing-email designs. To use images in your designs, you must upload them to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], which also hosts the images and delivers them when contacts open an email or marketing page.

> [!NOTE]
> For security purposes, this feature only allows you to upload image files. The following image formats are supported:
> 
> - GIF
> - BMP
> - JPEG
> - PNG
> 
> You will see an error message if you attempt to upload a file of an unsupported type.

## Upload files to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]

Whenever you add an image block to a marketing page or email, you can choose to add an image that already exists in your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] database or upload a new one. After you've uploaded a file in this way, the file will also be available for use in other designs.

![Upload a picture dialog](media/upload-picture.png "Upload a picture by dragging it to the upload dialog box")

You can also add images for use later in some future design. You might do this to establish a collection of clip-art images that your message and page designers can use as needed. Go to **Marketing** &gt; **Internet Marketing** &gt; **Files** to see a list view of all files available to your organization, and then select **New** to upload a new file. You can also find and edit existing images here.

Note that you can apply keywords each time you upload a file. Keywords can make it much easier for other users to find and identify files in the future, so we recommend that you use them.

## Establish keywords

Keywords make it easier to find your images later when you want to use them in content. Each time you upload a new image, you're offered a chance to apply a keyword to it. You can also add or remove keywords from existing images by going to **Marketing** &gt; **Internet Marketing** &gt; **Files**.

To help keep your keywords under control, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] requires you to establish a list of specific keywords that users can apply to their files. Users must therefore select keywords from a list rather than enter free text. This helps prevent users from applying competing ontologies and also helps prevent typos.

To view and edit the keywords available to your organization, go to **Marketing** &gt; **Internet Marketing** &gt; **Keywords**. All existing keywords are listed here. Select any listed keyword to edit it, or select **New** to create a new one. You can also delete keywords here.

Be careful when editing or deleting keywords. If you edit an existing keyword, all existing files that use it will instead show the new value from now on. If you delete a keyword, it is simply removed from all files that use it.

## Use images in your content

To add an image to a marketing page or email, start by dragging an image block onto your design, which positions a placeholder. Then select the block with the placeholder image and open the **Properties** tab, where you can define the source, alt text, and link for the image. Select the browse button ![Browse for picture button](media/browse-button.png "Browse for picture button") for **Source** to open an image browser where you can find any image already uploaded to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

![The picture library](media/select-picture.png "Select a picture from the library")

To find an image more quickly, try using the **Filter Keyword** drop-down list to show only images that include the keyword you selected.

If the image you need isn't there, select **Upload a Picture** to add a new one. We recommend that you apply one or more keywords when uploading the image to make it easier for you and others to find later.

### See also

[Manage images](manage-images.md)
