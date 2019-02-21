---
title: "msdyn_ForecastRecalculate Action Reference (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "Recalculates the hierarchy represented by the input forecast."
ms.date: 02/21/2019
ms.service: "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: reference
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 9970C2FA-64E4-4678-BC0D-E1EA7DE4C81B
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# msdyn_ForecastRecalculate Action

For Internal Use only.

[!INCLUDE[msdyn_ForecastRecalculate-description](includes/msdyn_ForecastRecalculate-description.md)]

## Parameters

|Name|Type|Nullable|Unicode|Description|
|-----|-----|-----|-----|-----|
|ForecastInstance|EntityReference|No|True|For Internal Use only.<br />Target forecast instance record. Recalculation is performed on the forecast hierarchy this forecast instance is part of|
|IsRefreshHierarchy|Boolean|No|True|For Internal Use only.<br />Flag indicating if hierarchy is to be updated as per current user hierarchy before recalculation|

## See Also

[User guide for Dynamics 365 for Sales](../../user-guide.md)