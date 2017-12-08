---
title: "Step 4: Store your AppSource Package on Azure storage and generate a URL with SAS key (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "App builders must be memebers of Microsoft Partner Network (MPN) to publish apps on AppSource."
ms.custom: ""
ms.date: 12/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 270d7049-b933-4214-a088-79ed23c4323b
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Step 4: Store your AppSource Package on Azure Storage and generate a URL with SAS key

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Microsoft Azure Storage is a Microsoft-managed cloud service that provides storage that is highly available, secure, durable, scalable, and redundant. More information: [Introduction to Microsoft Azure Storage](https://docs.microsoft.com/azure/storage/common/storage-introduction).

To maintain security of your files, all partners must store their AppSource package file in a Microsoft Azure Blob storage account, and use a shared access signature (SAS) key to share the package file. Microsoft will retrieve the package file from your Azure Storage location for certification, and then for AppSource trials.

To upload your package to Azure Blob storage:

1. Create a free trial or pay as you go Azure account at [https://azure.microsoft.com](https://azure.microsoft.com).
2. Sign in to Azure Management portal at [https://portal.azure.com](https://portal.azure.com)
 

> [!div class="nextstepaction"]
> [Create and manage VM disks](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/tutorial-manage-disks) 
  

