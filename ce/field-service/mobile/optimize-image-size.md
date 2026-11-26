---
title: Optimize images for upload
description: Optimize image uploads in Field Service mobile on iOS and Android. Enable the setting to compress high-resolution photos during upload to cut bandwidth costs.
ms.topic: how-to
ms.subservice: field-service-mobile
ms.date: 08/31/2026
author: JonBaker007
ms.author: jobaker
ms.reviewer: v-wendysmith
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 08/31/2026
ai-usage: ai-assisted
---

# Optimize images for upload

Frontline workers often use high-quality cameras on their mobile devices to take photos of assets and customer locations. The resulting images are often large files with a high resolution. Uploading these images consumes a lot of network bandwidth and storage. Often, you don't need high-resolution images and a compressed version works well.  

The Dynamics 365 Field Service mobile app on iOS and Android lets technicians turn on image upload optimization to decrease network usage and save on Dataverse storage space. When you turn on this option, the application compresses the image during upload and stores smaller files in Dataverse.

> [!NOTE]
> This feature isn't supported on the Field Service app for Windows.

## Turn on optimized image upload

1. Open the Field Service mobile app on your mobile device.
1. Go to the environment selection menu:

   - In the Unified Interface app, open the navigation, select your profile image, and then select **Reconfigure**.
   - In the [new mobile experience](do-work-newux.md), select your profile image and choose **Settings**. In the Apps section, select the app module.  

1. On the environment selection page, open the navigation :::image type="icon" source="../../sales/sales-mobile/media/sm-hamburger-menu.png" border="false":::.

1. Turn on **Optimize images for upload**.

:::image type="content" source="../media/optimize-images-upload.png" alt-text="Screenshot of the Field Service mobile app showing the environment settings options.":::

When enabled, the app optimizes images during upload when you use:

- Timeline
- Quick notes
- Inspection

For custom controls in model-driven apps that handle images, see [Xrm.Device (Client API reference)](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-device).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
