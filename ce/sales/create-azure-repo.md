---
title: Set up own storage for call recordings
description: This article describes how to create a call recording repository in Azure storage for storing your Teams recordings.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi 
ms.topic: how-to 
ms.date: 12/14/2023
ms.custom: bap-template
---

# Set up own storage for call recordings

This article describes how to create a call recording repository in Azure storage for storing your Teams recordings. 

## Prerequisites

- [An Azure storage account](/azure/storage/common/storage-account-create?tabs=azure-portal) 
- [A container in the Azure storage account](/azure/storage/blobs/blob-containers-portal) 

##  Configure the service principal to access resources in Azure

Work with your Microsoft Entra administrator to [configure the service principal](/entra/identity-platform/howto-create-service-principal-portal#assign-a-role-to-the-application) for **SalesInsightsWebApp** and add **Storage Blob Data Owner** and **Storage Account Contributor** roles as a member of the app. This step helps ensure that conversation intelligence can store and process call recordings in your Azure storage account.

Now you are ready to configure conversation intelligence to use your [own Azure storage](fre-setup-ci-sales-app.md#configure-conversation-intelligence-settings).  
