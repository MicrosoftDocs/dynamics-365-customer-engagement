---
title: "Add azure storage web resource to a form in Dynamics 365 | MicrosoftDocs"
description: "Steps to add azure storage web resource to a form to enable uploading attachments to Azure Storage."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 6598B118-E243-40AD-AE8C-342F8604754F
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Add the Azure Storage web resource to a form

Attachments uploaded to [!include[Azure](../includes/pn-azure-shortest.md)] Storage instead of directly to [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] can be managed by using notes in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].

To enable attachments from a particular form to be uploaded into [!include[Azure](../includes/pn-azure-shortest.md)] Storage, you must add a web resource to that form and you must [configure Azure Storage for your organization](enable-azure-storage.md).

> [!Note]
> In this example, the form is added to the Lead form for the Lead entity. We recommend using caution when editing existing forms.

When a file (for example, attachments.zip) is uploaded to [!include[Azure](../includes/pn-azure-shortest.md)] Storage by using the portal, it is represented by a note on an entity and a placeholder for the attachment.

![Attachment on a form](media/notes-attachment-lead-form.png "Placeholder for the attachment on a form")

Note that the attachment file is now named attachment.zip.txt. By default, [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] has no conception of an [!include[Azure](../includes/pn-azure-shortest.md)] file, so this placeholder .txt file is stored in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] instead. The [!include[Azure](../includes/pn-azure-shortest.md)] Storage context for the placeholder file shows details about the file.
```
{
 "Name": "attachment.zip",
 "Type": "application/x-zip-compressed",
 "Size": 24890882,
 "Url": "https://accountname.blob.core.windows.net/storage/81a9a9491c36e51182760026833bcf82/attachment.zip"
}
```

To see and interact with the file stored in [!include[Azure](../includes/pn-azure-shortest.md)], you must add the web resource adx.annotations.html to the form.
1.	In the form editor for the relevant form, select **Web Resource** on the **Insert** tab.

2.	In the **Web resource** box, select **adx_annotations/adx.annotations.html**.

3.	Enter a name and label for the resource.

4.	In the **Custom Parameter (data)** box, enter **azureEnabled=true**. <br>You can also use the web resource without enabling [!include[Azure](../includes/pn-azure-shortest.md)] support in this way, in which case it will function almost entirely the same as the default control.</br>

5.	On the **Formatting** tab, choose whatever formatting rules you prefer. We recommend that you clear the **Display border** check box.

6.	Select **OK** to save the resource.

7.	Optionally, you might want to remove the existing notes control, or move it to a tab or section that is marked to be not visible by default.

8.  Save the form, and then publish the changes.

    ![Add web resource](media/add-web-resource.png "Add a web resource")

The new control will now be rendered on the page, giving you the ability to manage your attachments in [!include[Azure](../includes/pn-azure-shortest.md)] Storage.

![Azure file attachment on a form](media/azure-file-attachment-lead-form.png "Azure file attachment on a form")

The paper-clip icon has been replaced with a cloud icon to denote that this file is stored in [!include[Azure](../includes/pn-azure-shortest.md)] Storage. You can continue to store attachments in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]; those files will be denoted with the paper-clip icon.

> [!Note]
> You must add cross-origin resource sharing (CORS) rule on your [!include[Azure](../includes/pn-azure-shortest.md)] Storage account as follows, otherwise you will see the regular attachment icon rather than the cloud icon.
> - **Allowed origins**: Specify your Dynamics 365 domain. For example, contoso.crm.dynamics.com.
> - **Allowed verbs**: GET, PUT, DELETE, HEAD, POST
> - **Allowed headers**: Specify the request headers that the origin domain may specify on the CORS request. For example, x-ms-meta-data\*, x-ms-meta-target\*. 
> - **Exposed headers**: Specify the response headers that may be sent in the response to the CORS request and exposed by the browser to the request issuer. For example, x-ms-meta-\*.
> - **Maximum age (seconds)**: Specify the maximum amount time that a browser should cache the preflight OPTIONS request. For example, 200.

> [!include[More information](../includes/proc-more-information.md)] [CORS support for the Azure Storage Services](https://docs.microsoft.com/rest/api/storageservices/cross-origin-resource-sharing--cors--support-for-the-azure-storage-services).

If the attached file is an image, the control will display the image as a thumbnail whether it is stored in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] or [!include[Azure](../includes/pn-azure-shortest.md)] Storage.

> [!Note]
> The thumbnail feature is limited to images under 1 MB in size.

![Notes thumbnail](media/notes-thumbnail.png "Notes thumbnail")
