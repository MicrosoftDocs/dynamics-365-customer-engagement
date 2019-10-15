---
title: "Microsoft.CIFramework (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
description: ""
keywords: ""
ms.date: 12/10/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 0C8C3084-1ABD-401C-946F-149EB9319DC2
author: susikka
ms.author: susikka
manager: shujoshi
---

# Microsoft.CIFramework methods (CIF JavaScript API reference)

Provides methods to use JavaScript API to manage the channel (widget), records, and forms in the Dynamics 365.

## Communication Panel Management APIs

| Methods | Description |
|---------|-------------|
| [setWidth](microsoft-ciframework/setWidth.md) | [!INCLUDE[setWidth-description](microsoft-ciframework/includes/setWidth-description.md)] |
| [getWidth](microsoft-ciframework/getWidth.md) | [!INCLUDE[getWidth-description](microsoft-ciframework/includes/getWidth-description.md)] |
| [setMode](microsoft-ciframework/setMode.md) | [!INCLUDE[setMode-description](microsoft-ciframework/includes/setMode-description.md)] |
| [getMode](microsoft-ciframework/getMode.md) | [!INCLUDE[getMode-description](microsoft-ciframework/includes/setMode-description.md)] |

## CRUD Operations APIs

| Methods | Description |
|---------|-------------|
| [createRecord](microsoft-ciframework/createRecord.md)| [!INCLUDE[createRecord-description](microsoft-ciframework/includes/createRecord-description.md)] |
| [retrieveRecord](microsoft-ciframework/retrieveRecord.md) | [!INCLUDE[retrieveRecord-description](microsoft-ciframework/includes/retrieveRecord-description.md)] |
| [updateRecord](microsoft-ciframework/updateRecord.md) | [!INCLUDE[updateRecord-description](microsoft-ciframework/includes/updateRecord-description.md)] |
| [deleteRecord](microsoft-ciframework/deleteRecord.md) | [!INCLUDE[deleteRecord-description](microsoft-ciframework/includes/deleteRecord-description.md)] |

## Notification Management APIs

| Methods | Description |
|---------|-------------|
| [notifyEvent](microsoft-ciframework/notifyEvent.md)| Displays a notification that can be used to inform agent about an incoming conversation. |

## Application Tab Management APIs

| Methods | Description |
|---------|-------------|
| [createTab](microsoft-ciframework/createtab.md) | |
| [getTabs](microsoft-ciframework/gettabs.md) | |
| [focusTab](microsoft-ciframework/focustab.md) | |
| [getFocusedTab](microsoft-ciframework/getfocusedtab.md) | |
| [refreshTab](microsoft-ciframework/refreshtab.md) | |
| [setTabTitle](microsoft-ciframework/settabtitle.md) | |

## Channel Analytics APIs

Channel Analytics APIs enable you to track event analytics.

| Methods | Description |
|---------|-------------|
| [initLogAnalytics](microsoft-ciframework/initLogAnalytics.md) | Invoke this method on an incoming conversation to log analytics.|
| [logAnalyticsEvent](microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events.|

## Miscellaneous Methods

| Methods | Description |
|---------|-------------|
| [getEntityMetadata](microsoft-ciframework/getEntityMetadata.md) | [!INCLUDE[getEntityMetadata-description](microsoft-ciframework/includes/getEntityMetadata-description.md)] |
| [setClickToAct](microsoft-ciframework/setClickToAct.md) | [!INCLUDE[setClickToAct-description](microsoft-ciframework/includes/setClickToAct-description.md)] |
| [getClickToAct](microsoft-ciframework/getClickToAct.md) | [!INCLUDE[getClickToAct-description](microsoft-ciframework/includes/getClickToAct-description.md)] |
| [searchAndOpenRecords](microsoft-ciframework/searchAndOpenRecords.md) | [!INCLUDE[searchAndOpenRecords-description](microsoft-ciframework/includes/searchAndOpenRecords-description.md)] |
| [getEnvironment](microsoft-ciframework/getEnvironment.md) | [!INCLUDE[getEnvironment-description](microsoft-ciframework/includes/getEnvironment-description.md)] |
| [openForm](microsoft-ciframework/openForm.md) | [!INCLUDE[openForm-description](microsoft-ciframework/includes/openForm-description.md)] |
| [renderSearchPage](microsoft-ciframework/renderSearchPage.md)| [!INCLUDE[openForm-description](microsoft-ciframework/includes/renderSearchPage-description.md)] |
| [addHandler](microsoft-ciframework/addHandler.md) | [!INCLUDE[addHandler-description](microsoft-ciframework/includes/addHandler-description.md)] |
| [removeHandler](microsoft-ciframework/removeHandler.md) | [!INCLUDE[removeHandler-description](microsoft-ciframework/includes/removeHandler-description.md)] |