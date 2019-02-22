---
title: "3d models for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# 3D models for Field Service

Dynamics 365 for Field Service allows organizations to upload 3D models for field technicians to reference in the field. Typically a 3d model relates to a specific product or customer asset and helps field technicians with equipment repair and other tasks. As opposed to recording videos or writing long manuals, field service organizations can leverage pre-existing 3D models to generate what are effectively 3D knowledge articles.

You can configure 3D models by using an N:N relationship between the 3D model and customer asset entities, which enables 3D models to be associated with customer assets.

In this topic, we'll walk through how to associate a 3D model record with a customer asset.

## Prerequisites

- Dynamics 365 for Customer Engagement v9.0+ 
- Field Service v8.0+
- Increased storage for large 3D file sizes. You can do this by increasing attachment file size limit in Dynamics 365 administration, or by using Azure Blob storage.

To increase attachment file size in D365 administration:

1. Navigate to **Settings > Administration > System Settings**
2. Select **Email** tab
3. In the **Set file size limit for attachments section** set the **Maximum file size (in Kilobytes)** to **131,072** KB. The click **Ok**.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of increasing attachment file size in D365 administration](media/3DViewerDocumentationDoc-image4.png)

To configure Azure Blob storage, use the [Microsoft Labs Attachment Management solution](https://appsource.microsoft.com/product/dynamics-365/microsoft_labs.96257e65-dbbe-43db-b775-77cf1609530c?tab=Overview).

Finally, make sure that 3D file types are not blocked for attachments in the Dynamics 365 settings:

1. Go to the **General** tab
2. Scroll down to the **Set blocked file extensions for attachments** section
3. Make sure **GLB**, **GLTF**, and **OBJ** are not listed

  > [!div class="mx-imgBorder"]
  > ![Screenshot showing that 3D file types are not blocked for attachments](media/3DViewerDocumentationDoc-image5.png) 

  > [!Note]
  > The supported file 3D viewer types are **GLB**, **GLTF**, and **OBJ**

## Open a 3D file

If you already have a 3D file, you can use Paint 3D to open it and save it as a GLB file. 

1. Open Paint 3D on your Windows 10 device.
2. Select the **3D Library** tab at the top.
3. Select a model from the library and open it on the canvas. Edit or make changes if necessary.

> [!div class="mx-imgBorder"]
> ![Screenshot of Paint 3D on a Windows 10 device](media/3DViewerDocumentationDoc-image1.png) 

4.  When done, select the **Menu** tab, go to the **Save as copy** section, and select **3D Model**.

> [!div class="mx-imgBorder"]
> ![Screenshot of save as copy](media/3DViewerDocumentationDoc-image2.png)  

5. Enter a **File Name**. For Save as type, select **3D-GLB(.glb)**. Then **Save**.
> [!div class="mx-imgBorder"]
> ![Screenshot of save as type, selecting 3D-GLB(.glb)](media/3DViewerDocumentationDoc-image3.png)  

 
## Associate Customer Assets with 3D Models

Once you have your GLB, GLTF, or OBJ file, and you have configured your organization as per the previous steps, you are ready to associate your 3D model with a customer asset.

1. Open up the desired customer asset record and select the **Related** tab
2. Select **3D Models** from the drop down
3. Click **Add Existing 3D Model**

> [!div class="mx-imgBorder"]
> ![Screenshot of associate your 3D model with a customer asset](media/3DViewerDocumentationDoc-image6.png) 

4. A quick create form for 3D Model will open. Click on **+New**
5. Enter a **Name** for the 3D Model and then select the **Storage Type** drop-down
6. Select **Note Attachment**. Then click **Save** on the form.


> [!div class="mx-imgBorder"]
> ![Screenshot of Note Attachment](media/3DViewerDocumentationDoc-image7.png)

7. After saving the record, the **Timeline** section will appear. Click on the paperclip icon to add a note with an attachment.
8. You will be prompted to select a file. Select the 3D file you saved as a GLB earlier and click **Open**.
9. After selecting a file, you should see the file attached with a paperclip icon next to it. Give the Note a **Title** and then click **Add note**.


> [!div class="mx-imgBorder"]
> ![Screenshot of Add note](media/3DViewerDocumentationDoc-image8.png)  

10. After saving the note, you should see it appear on the timeline with the attached 3D file.
11. To view the 3D file, scroll past the timeline section on the form. You can interact with the 3D viewer by scrolling, left-clicking, right-clicking and dragging. 

> [!div class="mx-imgBorder"]
> ![Screenshot of appear on the timeline with the attached 3D file](media/3DViewerDocumentationDoc-image9.png)  

12. After saving and closing the form for the 3D model, you can then select it from the lookup on the 3D Model quick create form. 
13. After selecting the 3D Model record, click **Add** to associate that 3D model with the Customer Asset.
14. The 3D Model can then be accessed via the 3D Model Associated View on the Customer Asset record.

> [!div class="mx-imgBorder"]
> ![Screenshot of 3D Model Associated View](media/3DViewerDocumentationDoc-image10.png)

## Additional notes
- 3D files are viewable on Field Service Mobile on Windows, iOS, and Android devices
