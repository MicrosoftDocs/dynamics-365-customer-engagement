---
title: "msdyn_ForecastRecalculateAsync Action Reference (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "Recalculates the hierarchy represented by the input forecast asynchronously."
ms.date: 02/21/2019
ms.service: crm-online
ms.topic: reference
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 21CECC98-D5EA-45B9-85ED-643F158204FD
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# msdyn_ForecastGeneralHierarchy Action Reference

For Internal Use only.

Generates forecast hierarchies for the given forecast definition. If `IsRefresh` is `true`, updates the forecast hierarchy according to current user hierarchy for the given forecast definition and recurrence index.

## Parameters

|Name|Type|Nullable|Unicode|Description|
|-----|-----|-----|-----|-----|
|ForecastDefinition|EntityReference|No|True|For Internal Use only.<br />Target forecast definition record. Hierarchies are generated/updated for this FD|
|IsRefresh|Boolean|No|True|For Internal Use only.<br />Flag indicating if the hierarchy has to be generated from scratch or updated according to current user hierarchy|
|RecurrenceIndex|Integer|No|True|For Internal Use only.<br />In case above flag is true, the combination of this param and FD provides the exact hierarchy which needs to be updated|

## Returns

|Name|Type|Description|
|-----|-----|-----|
|ForecastCollection|EntityCollection|Collection of root forecast instances for the generated/updated hierarchies|

## See Also

[User guide for Dynamics 365 for Sales](../../user-guide.md)