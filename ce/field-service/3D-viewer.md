---
title: Use 3D models with customer assets
description: Learn about how to use 3D models in Dynamics 365 Field Service.
ms.date: 06/28/2024
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: JonBaker007
ms.author: jobaker
---

# Use 3D models with customer assets

Dynamics 365 Field Service allows organizations to upload 3D models for field technicians to reference in the field. Typically a 3D model relates to a specific product or customer asset and helps field technicians with equipment repair and other tasks. As opposed to recording videos or writing long manuals, field service organizations can use pre-existing 3D models to generate what are effectively 3D knowledge articles.

You can configure 3D models by using an N:N relationship between the 3D model and customer asset entities, which enables 3D models to be associated with customer assets.

## Prerequisites

- Dynamics 365 v9.0+ 
- Field Service v8.0+
- Ensure the **3D Viewer** solution is installed in **Settings** > **Customizations**
- Increase storage for large 3D file sizes. Increase the [attachment file size limit](/power-platform/admin/settings-email) to the maximum.
- Ensure that the supported 3D file types aren't blocked for attachments. See [**Set blocked file extensions for attachments**](/power-platform/admin/system-settings-dialog-box-general-tab).

  > [!Note]
  > The supported file 3D viewer types are **GLB**, **GLTF**, and **OBJ**.

## Associate customer assets with 3D models

1. In Field Service, select the **Service** area. Under **Assets**, select **Assets**.

1. Open the desired customer asset record and select the **Related** tab. Select **Three-Dimensional Models**.

   :::image type="content" source="media/3Dmodel.png" alt-text="Screenshot showing how to access 3D model for an asset.":::

1. Select **Add Existing Three-Dimensional Model**.

1. Select **New Record** > **Three-Dimensional Model**.

1. Enter a **Name** for the 3D model.

1. For **Storage Type**, select **Note Attachment**. Then **Save** the form.

   :::image type="content" source="media/3Dmodel-new.svg" alt-text="Screenshot of a New 3D model.":::

1. In the **Timeline** section, select the paperclip icon, browse to your 3D file, and then select **Open**.

1. Give the note a **Title** and then select **Add note**.

1. Select **Save & Close**. Then, select **Add** to associate that 3D model with the customer asset.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
