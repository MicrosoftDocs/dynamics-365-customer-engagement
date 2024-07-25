---
title: Use 3D models with customer assets
description: Learn how to use 3D models in Dynamics 365 Field Service.
ms.date: 07/01/2024
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: JonBaker007
ms.author: jobaker
---

# Use 3D models with customer assets

Organizations can upload 3D models into Dynamics 365 Field Service. Field technicians can then refer to them while they work in the field. Typically, a 3D model is related to a specific product or customer asset, and helps field technicians with equipment repair and other tasks. Instead of having to record videos or write long manuals, field service organizations can use pre-existing 3D models to generate what are effectively 3D knowledge articles.

You can configure 3D models by using a many-to-many (N:N) relationship between the 3D model and customer asset entities. This relationship enables 3D models to be associated with customer assets.

## Prerequisites

- Dynamics 365 version 9.0 or later is required.
- Field Service version 8.0 or later is required.
- Ensure that the **3D Viewer** solution is installed. Sign in to [Power Apps](https://make.powerapps.com/), select **Solutions**, and search for *3D Viewer*.
- Increase storage for large 3D file sizes. In [Email settings](/power-platform/admin/settings-email), set the **Maximum file size for attachments** field to the maximum value (128 MB).
- Ensure that the supported 3D file types aren't blocked for attachments. In [System Settings](/power-platform/admin/system-settings-dialog-box-general-tab), adjust the **Set blocked file extensions for attachments** settings as needed.

    > [!NOTE]
    > The 3D viewer supports the following file types: *GLB*, *GLTF*, and *OBJ*.

## Associate customer assets with 3D models

1. In Field Service, select the **Service** area.
1. Under **Assets**, select **Assets**.
1. Open the desired customer asset record.
1. Select **Related** > **Three-Dimensional Models**.

    :::image type="content" source="media/3Dmodel.png" alt-text="Screenshot showing how to access 3D models for an asset.":::

1. Select **Add Existing Three-Dimensional Model**.
1. Select **New Record** > **Three-Dimensional Model**.
1. In the **Name** field, enter a name for the 3D model.
1. In the **Storage Type** field, select **Note Attachment**.
1. Select **Save**.

    :::image type="content" source="media/3Dmodel-new.svg" alt-text="Screenshot of a new 3D model.":::

1. In the **Timeline** section, select the paperclip icon, browse to your 3D file, and then select **Open**.
1. In the **Title** field, enter a title for the note. Then select **Add note**.
1. Select **Save & Close**.
1. Select **Add** to associate the 3D model with the customer asset.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
