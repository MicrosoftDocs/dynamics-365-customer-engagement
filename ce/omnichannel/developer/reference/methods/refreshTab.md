---
title: "refreshTab (Omnichannel for Customer Service Session API reference) | MicrosoftDocs"
description: 
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 10/05/2020
ms.topic: article
---
# refreshTab

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Provides the functionality to the refresh a tab. This API expects the unique tab id as a parameter.

## Syntax

`Microsoft.Apm.refreshTab(tabId);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| tabId | string | - Unique id of the tab to be in focus | 

## Return Value

void

## Example

`Microsoft.Apm.refreshTab("tab-id-8");`

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
