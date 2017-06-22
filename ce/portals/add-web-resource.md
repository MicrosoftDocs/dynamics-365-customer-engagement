---
title: "Add web resource to a form in Dynamics 365 | MicrosoftDocs"
description: "Steps to add web resource to a form."
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 6598B118-E243-40AD-AE8C-342F8604754F
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Add a web resource

Attachments uploaded to Azure Storage instead of directly to Dynamics 365 can be managed using an interface like the stock [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Notes interface.

To enable this interface, a Web Resource must be added to the form on which you wish to use it, and [Azure Storage must be configured for your organization](enable-azure-storage.md).

> [!Note]
> For the purposes of this document, the form will be added to the form "Lead" for the Lead entity. We recommend using caution when editing existing forms.

When a file (for example, "attachments.zip") is uploaded to Azure Storage through the Portals, it is represented by a Note on an entity, with a placeholder attachment:

![Attachement on a form](media/notes-attachment-lead-form.png "Primary connection string value")

Note that the attachment file is now named "attachment.zip.txt". By default, Dynamics 365 has no conception of an Azure file, so this placeholder text file is stored in its place in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. The contexts of the placeholder file show details of the file that is stored in Azure:
```
{
 "Name": "attachment.zip",
 "Type": "application/x-zip-compressed",
 "Size": 24890882,
 "Url": "https://accountname.blob.core.windows.net/storage/81a9a9491c36e51182760026833bcf82/attachment.zip"
}
```
To see and interact with the file stored in Azure, you must add the Web Control adx.annotations.html to the form:
1.	In the form editor for the relevant form, click "Web Resource" in the INSERT tab of the Ribbon.
2.	In the "Web resource" lookup field, select the resource named "adx_annotations/adx.annotations.html".
3.	Give the resource any name and label you wish
4.	In the "Custom Parameter (data)" field, add the parameter "azureEnabled=true". You may use the web resource without enabling Azure support in this way, in which case it will function almost entirely the same as the default control.
5.	In the Formatting tab, set whatever formatting rules you prefer. We recommend unchecking the "Display border" box.
6.	Press OK to save the resource.
7.	Optionally, you may wish to remove the existing notes control, or move it to a tab or section that is marked not visible by default.
8.  Save the form, and publish the changes.

    ![Add web resource](media/add-web-resource.png "Add web resource")

The new control will now render on the page, giving you the ability to manage your attachments in Azure Storage:

![Azure file attachment on a form](media/azure-file-attachment-lead-form.png "Azure file attachment on a form")

The paperclip icon has been replaced with a cloud icon to denote that this file is stored in Azure Storage. You may continue to store attachments in Dynamics 365, in which case those files will have a paperclip icon.

If the attached file is an image, whether it is stored in Dynamics 365 or Azure Storage, the control will display the image as a thumbnail.

> [!Note]
> The thumbnail feature is limited to images under 1 MB in size.

![Notes thumbnail](media/notes-thumbnail.png "Notes thumbnail")