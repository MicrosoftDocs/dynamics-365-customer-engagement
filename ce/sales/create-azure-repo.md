---
title: Set up own storage for call recordings
description: This article describes how to create a call recording repository in Azure storage for storing your Teams recordings.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi 
ms.topic: how-to 
ms.date: 12/28/2023
ms.custom: bap-template
---

# Set up own storage for call recordings

This article describes how to create a call recording repository in Azure storage for storing your Teams recordings and configure conversation intelligence to use your own Azure storage.

## Prerequisites

- [An Azure storage account](/azure/storage/common/storage-account-create?tabs=azure-portal) 
- [A container in the Azure storage account](/azure/storage/blobs/blob-containers-portal) 

##  Configure the conversation intelligence service principal to access resources in Azure

The conversation intelligence service principal needs access to your Azure storage account to store and process call recordings. To grant access, work with your Microsoft Entra administrator to assign the following roles to the **SalesInsightsWebApp** application in the Azure Portal:

- **Storage Blob Data Owner**
- **Storage Account Contributor**

:::image type="content" source="media/SIwebapp-roles.png" alt-text="Screenshot of the role assignment tab with the roles assigned for the SalesInsightsWebApp in the Azure portal":::

[Learn more about assigning a role in the Azure Portal](entra/identity-platform/howto-create-service-principal-portal#assign-a-role-to-the-application).

Now you are ready to configure conversation intelligence to use your [own Azure storage](fre-setup-ci-sales-app.md#configure-conversation-intelligence-settings).  
