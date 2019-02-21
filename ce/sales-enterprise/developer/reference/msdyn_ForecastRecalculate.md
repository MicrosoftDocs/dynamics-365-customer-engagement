---
title: "msdyn_ForecastRecalculate Action Reference (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "Recalculates the hierarchy represented by the input forecast."
ms.date: 02/21/2019
ms.service: crm-online
ms.topic: reference
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# msdyn_ForecastRecalculate Action Reference

For Internal Use only.

Recalculates the hierarchy represented by the input forecast. If `RefreshHierarchy` parameter is `true`, updates the forecast hierarchy according to current user hierarchy before starting recalculation.

## Parameters

|Name|Type|Nullable|Unicode|Description|
|-----|-----|-----|-----|-----|
|ForecastInstance|EntityReference|No|True|For Internal Use only.<br />Target forecast instance record. Recalculation is performed on the forecast hierarchy this forecast instance is part of|
|IsRefereshHierarchy|Boolean|No|True|For Internal Use only.<br />Flag indicating if hierarchy is to be updated as per current user hierarchy before recalculation|

## See Also

[User guide for Dynamics 365 for Sales](../../user-guide.md)