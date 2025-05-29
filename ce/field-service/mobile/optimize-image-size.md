---
title: Optimize images for upload
description: Turn on a user setting to optimize file sizes of images before uploading it to Dataverse.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 08/28/2024
author: josephshum-msft
ms.author: jshum
---

# Optimize images for upload

Frontline workers often use high-quality cameras on their mobile devices to take photos of assets and customer locations. The resulting images are often large files with a high resolution and uploading them consumes a lot of network bandwidth and storage. Often, high-resolution images aren't necessary and a compressed version does the job.  

The Dynamics 365 Field Service mobile app on iOS and Android lets technicians turn on image upload optimization to decrease network usage and save on Dataverse storage space. When this option is turned on, the application compresses the image during upload and stores smaller files in Dataverse.

> [!NOTE]
> This feature is not supported on the Field Service app for Windows.

## Turn on optimized image upload

1. Open the Field Service mobile app on your mobile app.
1. Go to the environment selection menu:

   - In the Unified Interface app, open the navigation, select your profile image, and then select **Reconfigure**.
   - In the [new mobile experience](do-work-newux.md), select your profile image and choose **Settings**. In the Apps section, select the app module.  

1. On the environment selection page, open the navigation :::image type="icon" source="../../sales/sales-mobile/media/sm-hamburger-menu.png" border="false":::.

1. Turn on **Optimize images for upload**.

:::image type="content" source="../media/optimize-images-upload.png" alt-text="Screenshot of the Field Service mobile app showing the environment settings options.":::

If enabled, image optimization is applied when uploading images using:

- Timeline
- Quick notes
- Inspection

For custom controls in model-driven apps that deal with images, see [Xrm.Device (Client API reference)](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-device).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
