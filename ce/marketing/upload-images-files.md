---
title: Use images, files, and videos in your content
description: "How to Upload, manage and use images, files and videos in Dynamics 365 Marketing."
ms.date: 03/02/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Upload, manage and use images, files, and videos in online content

Shareable assets are critical for meaningful and successful customer experiences. The files you use must be available publicly on the internet so your emails and pages can access and display them. The Dynamics 365 Marketing library stores images, documents, and videos, hosting them publicly and providing an easy way to find and link to them while creating content. The library is shared across real-time and outbound marketing, making it easy to upload and use assets where you need them. 

> [!NOTE]
> The following files types are supported: AVI, CS, CSS,DOC, DOCX, EPUB,GIF, JPG, JPEG, MP3, MP4, MPEG, MPG, ODP, ODS, ODT, PDF, PNG, PPT, PPTX, PS, RTF, SVG, TAR, TGZ, TXT, WMV, XLS, XLSX, XML, ZIP
>
> You will see an error message if you attempt to upload a file of an unsupported type. 
> The maximum file size is: 
> - 5MB for images
> - 32MB for documents
> - 128MB for videos

> [!TIP]
> Files are stored in the organization’s Microsoft Dataverse storage and will count against their file storage capacity. For more information on Dataverse storage capacity, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## Upload files

You can create a collection of images, videos, and files for later use. To upload new files, go to **Real-time marketing > Assets > Library** and select **New**.

> [!div class="mx-imgBorder"]
> ![upload replace asset](media/upload-replace-asset.png "upload replace asset")

You can add **keywords** when you upload a file so it’s easier to organize and find it later.
When you add an image element to your content or need to [link to a file or video](/dynamics365/marketing/real-time-marketing-email#link-to-documents-and-videos-stored-in-the-asset-library), you can choose to use a file that already exists in your Marketing app library or upload a new one. After you've uploaded a file in this way, it will also be available in the library for use in other content.

You can **replace** your assets with newer versions whenever needed. To replace an asset:
1. Select the image.
2. Select **Upload file** in the command bar.
3. Select a new image.
4. A new version of the asset will appear in the asset library. The new version will also appear wherever the asset is currently being used.
5. If you open the asset, you can see the version number, but you can't view the previous versions.

## Use images in your content

To add an image, start by dragging an image element onto your design, which positions a placeholder. Then select the placeholder image to open the **Edit image** tab, where you can define the source, alt text, and link for the image. Select **Choose an image > Browse library** to open an image browser where you can find any image already uploaded to Dynamics 365 Marketing.

> [!div class="mx-imgBorder"]
> ![add an image](media/add-an-image.png "add an image")

To find an image more quickly, try using the **Filter by keyword** search bar to look for specific keywords.
If the image you need isn't there, select **+Upload** to add a new one.

### See also

[Link to documents stored in the asset library](/dynamics365/marketing/real-time-marketing-email#link-to-documents-and-videos-stored-in-the-asset-library)

[!INCLUDE[footer-include](../includes/footer-banner.md)]