---
title: "msdyn_ForecastRecalculateAsync Action Reference (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "Recalculates the hierarchy represented by the input forecast asynchronously."
ms.date: 02/21/2019
ms.service: crm-online
ms.topic: reference
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 9A57F6C3-4BF8-4CE4-BECD-C09CF18BA43C
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# msdyn_ForecastRecalculateAsync Action Reference

For Internal Use only.

Recalculates the hierarchy represented by the input forecast asynchronously. If `IsRefreshHierarchy` is `true`, updates the forecast hierarchy according to current user hierarchy before starting recalculation.

## Parameters

|Name|Type|Nullable|Unicode|Description|
|-----|-----|-----|-----|-----|
|ForecastInstance|EntityReference|No|True|For Internal Use only.<br />Target forecast instance record. Recalculation is performed on the forecast hierarchy this forecast instance is part of|
|IsRefreshHierarchy|Boolean|No|True|For Internal Use only.<br />Flag indicating if hierarchy is to be updated as per current user hierarchy before recalculation|

## See Also

[User guide for Dynamics 365 for Sales](../../user-guide.md)