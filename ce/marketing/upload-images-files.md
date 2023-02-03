---
title: "Upload and use images in online content (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to upload, tag, and find images for use in emails and marketing pages in Dynamics 365 Marketing."
ms.date: 02/01/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Upload and use images in online content

Images are an important part of most marketing page and marketing email designs. The images you use must be available publicly on the internet so your emails and pages can access and display them. Though you could host your images anywhere, one convenient place to keep them is in the Dynamics 365 Marketing library, which stores the images, hosts them publicly, and provides an image browser that helps you find and place them while working in Dynamics 365 Marketing.

> [!NOTE]
> For security purposes, this feature only allows you to upload images. The following image formats are supported:
>
> BMP, GIF, JPEG, PNG
>
> You will see an error message if you attempt to upload a file of an unsupported type. The maximum file size for uploaded images is 5 MB.

> [!TIP]
> Images will be stored in the user's Microsoft Dataverse storage and will count against their file storage capacity. For more information on Dataverse storage capacity, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## Upload images to Dynamics 365

Whenever you add an image element to a marketing page or email, you can choose to add an image that already exists in your Dynamics 365 Marketing library or upload a new one. After you've uploaded an image in this way, the image will also be available for use in other designs.

> [!div class="mx-imgBorder"]
> ![Upload a picture by dragging it to the upload dialog box.](media/upload-picture.png "Upload a picture by dragging it to the upload dialog box")

You can also add images for use later in some future design. You might do this to establish a collection of clip-art images that your message and page designers can use as needed. Go to **Outbound marketing** > **Marketing content** > **Library** to see a list view of all images available to your organization, and then select **New** to upload a new image. You can also find and edit existing images here.

You can apply keywords each time you upload an image. Keywords can make it much easier for other users to find and identify images in the future, so it's recommended that you use them.

## Establish keywords

Keywords make it easier to find your images later when you want to use them in content. Each time you upload a new image, you're offered a chance to apply a keyword to it. You can also add or remove keywords from existing images by going to **Outbound marketing** > **Marketing content** > **Library**.

To help keep your keywords under control, Dynamics 365 Marketing requires you to establish a list of specific keywords that users can apply to their images. Users must therefore select keywords from a list rather than enter free text. This helps prevent users from applying competing ontologies and also helps prevent typos.

To view and edit the keywords available to your organization, go to **Outbound marketing** > **Marketing content** > **Keywords**. All existing keywords are listed here. Select any listed keyword to edit it, or select **New** to create a new one. You can also delete keywords here.

Be careful when editing or deleting keywords. If you edit an existing keyword, all existing images that use it will instead show the new value from now on. If you delete a keyword, it's removed from all images that use it.

## Use images in your content

To add an image to a marketing page or email, start by dragging an image element onto your design, which positions a placeholder. Then select the placeholder image to open the **Edit image** tab, where you can define the source, alt text, and link for the image. Select **Choose an image** > **Browse library** to open an image browser where you can find any image already uploaded to Dynamics 365 Marketing.

> [!div class="mx-imgBorder"]
> ![Select a picture from the library.](media/select-picture.png "Select a picture from the library")

To find an image more quickly, try using the **Filter by keyword** search bar to look for specific keywords.

If the image you need isn't there, select **+Upload** to add a new one. It's recommended that you apply one or more keywords when uploading the image to make it easier for you and others to find later.

### See also

[Manage images](manage-images.md)  
[Link to documents stored in the asset library](real-time-marketing-email.md#link-to-documents-and-videos-stored-in-the-asset-library)

[!INCLUDE[footer-include](../includes/footer-banner.md)]