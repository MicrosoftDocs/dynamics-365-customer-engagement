---
title: "Real-time marketing asset library (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to use the real-time marketing asset library in Dynamics 365 Marketing."
ms.date: 01/27/2023
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

# Real-time marketing asset library

> [!NOTE]
> By default, real-time marketing uses the [outbound file library](upload-images-files.md). To use the real-time marketing asset library, you must install the [asset library add-on](real-time-marketing-asset-add-on.md)

The real-time marketing asset library lets you upload images, videos, and documents. Images are automatically tagged using AI. When authoring email content, you can use the asset library's AI-driven suggestions to find images that best complement your email content. The asset library may already be installed for your organization. If not, you can choose to install it. Learn more: [Install the real-time marketing asset library add-on](real-time-marketing-asset-add-on.md).

> [!NOTE]
> The asset library supports images (such as JPEG, GIF, and PNG files), videos (such as MP4, AVI, and MPEG files), and documents (such as Word documents, PowerPoint files, and Adobe PDFs). Learn more about supported file types: [Upload files other than images and videos](/dynamics365/commerce/dam-upload-files).

> [!TIP]
> Use of the asset library is provided with your Dynamics 365 Marketing license at no extra charge. Images and files uploaded to the default (outbound) asset library will be stored in the user’s Microsoft Dataverse storage and will count against their file storage capacity. For more information on Dataverse storage capacity, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).
>
> If you decide to use the default (outbound) library or you are in Brazil, India, France, Switzerland, or United Arab Emirates, refer to [Upload and use images and files in online content](upload-images-files.md) for further guidance.

## Asset library features

> [!div class="mx-imgBorder"]
> ![Single photo asset library screenshot.](media/real-time-marketing-asset-library2.png "Single photo asset library screenshot")

### Quickly upload assets

You can upload a single file, bulk upload a few files, or even upload an entire folder.

### Export images from the default outbound marketing library to the asset library

> [!IMPORTANT]
> Copying assets only works for images.

You can transfer images from the default outbound marketing library to the real-time marketing asset library in just a few steps. To transfer images:

1. Go to **Outbound marketing** in the area switcher, then go to **Marketing content** > **Library**.
1. To copy individual images, choose which images you'd like to copy by selecting the blue check mark on the upper right of the image.
    > [!div class="mx-imgBorder"]
    > ![Select image.](media/real-time-marketing-asset-library-select.png "Select image")
1. To copy the images to the real-time marketing asset library, select the **Copy to Real-time marketing** button in the top ribbon.
    > [!div class="mx-imgBorder"]
    > ![Copy selected assets.](media/real-time-marketing-asset-library-copy-image2.png "Copy selected assets")
    
1. A modal window will appear and ask if you'd like to copy the selected images to real-time marketing. Select **Copy files**. A status bar at the top of the window will show the copying progress.
1. Alternatively, if you'd like to copy *all* images from the default outbound marketing library to the real-time marketing asset library, don't select any individual images. The button in the top ribbon will say **Copy all files to Real-time marketing**. To copy all images, select the button and choose **Copy files** on the modal window.

### Organize and find assets with ease

Use tags to organize your assets as needed. All images uploaded into the library are automatically analyzed and described by AI (using AI tags). As a result, you can easily find an image containing a searched object. For example, by typing “house,” you'll find all images showcasing houses, regardless of their file names. You can also sort your assets by *Title* or *Last modified* date.

> [!div class="mx-imgBorder"]
> ![Thumbnail asset library screenshot.](media/real-time-marketing-asset-library-full.png "Thumbnail asset library screenshot")

For videos and documents, you'll have to add tags manually.

### View assets in different ways

Depending on your preferences, you can view your assets as a single file, a thumbnail view, or a list view.

### Update your assets when needed

You can replace your assets with newer versions whenever needed.
