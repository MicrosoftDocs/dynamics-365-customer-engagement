---
title: "Enable Azure storage for portals in Dynamics 365 | MicrosoftDocs"
description: "Steps to enable Azure storage for portals."
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 450D4748-1ED4-48F6-ACEC-349B577E78EE
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Enable Azure storage
Azure Storage integration for Portals enables you to take advantage of the greater file storage capability of Microsoft Azure, using the same interface and providing the same experience for your users as in the default file attachments. This feature is supported for Web Files, Entity Forms, and Web Forms.

For instructions on creating an Azure Storage account, see azure.microsoft.com/en-us/services/storage/.

Once the Storage Account is running, Portals requires certain global settings that tell the application how to locate your storage account. From [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)], navigate to **Settings** > **Portal Settings**, and add a new Setting named `FileStorage/CloudStorageAccount`.

To locate the value for `FileStorage/CloudStorageAccount`, you must get a connection string from your Microsoft Azure portal. In the main panel for your storage account, click the "Keys" icon:

![Locate value for connection string from your Microsoft Azure portal](media/key-azure-storage.png "Locate value for connection string from your Microsoft Azure portal")

In the resulting panel, locate the input labeled **PRIMARY CONNECTION STRING**. You may click the box next to the input to copy the contents to your clipboard and paste that value into your new setting:

![Primary connection string value](media/primary-connection-string-azure-storage.png "Primary connection string value")

![Portal setting for cloud storage account](media/portal-site-setting-cloud-storage-account.png "Portal setting for cloud storage account")

## Specifying the Storage Container
If you do not already have an Azure Blob Container in your storage account, you should add one using your Microsoft Azure portal.

From [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)], navigate to **Settings** > **Portal Settings**, and add a new Setting named `FileStorage/CloudStorageContainerName`, using the name of your Container as the value:

![Portal setting for cloud storage container](media/portal-site-setting-cloud-storage-container.png "Portal setting for cloud storage container")

With these settings, your Portals application is ready to begin uploading and downloading files to and from Azure Storage. However, you cannot take full advantage of this feature until you [Add a Web Resource](add-web-resource.md) and configure [Entity Forms](entity-forms-custom-logic.md#notes-configuration-for-entity-form) or [Web Forms](configure-notes.md) to use it.