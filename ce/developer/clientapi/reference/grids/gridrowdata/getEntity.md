---
title: "getEntity (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 11/10/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 1672c213-d315-48fb-b49c-47cc19d23c28
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getEntity (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getEntity-description.md](./includes/getEntity-description.md)]

As this is deprecated, you should use **GridRowData.entity**.

## Grid types supported

Read-only and editable grids

## Syntax

`gridRowData.getEntity();`

## Return Value

**Type**: [GridEntity](../gridentity.md)

## Remarks

To get the `gridRowData` object, see [GridRowData](../gridrowdata.md). 

