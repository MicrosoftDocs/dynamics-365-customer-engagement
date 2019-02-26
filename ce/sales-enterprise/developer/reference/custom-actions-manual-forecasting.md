---
title: "Custom actions for Manual forecasting (Developer Guide for Dynamics 365 for Sales)| MicrosoftDocs"
description: "Reference documentation for the custom actions of Forecasting"
ms.date: 02/26/2019
ms.service: "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
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
# Custom actions for Manual forecasting

> [!NOTE]
> The custom actions for Manual forecasting documented below are for internal use only.

<a name="bkmk_msdynforecastrecalculate"></a>

## msdyn_ForecastRecalculate Action

[!INCLUDE[msdyn_ForecastRecalculate-description](includes/msdyn_ForecastRecalculate-description.md)]

### Parameters

|Name|Type|Description|
|-----|-----|-----|
|ForecastInstance|EntityReference|For Internal Use only.<br />Targets forecast instance record. Recalculation is performed on the forecast hierarchy of which this forecast instance is a part|
|IsRefreshHierarchy|Boolean|For Internal Use only.<br />Flag indicating whether hierarchy is to be updated as per current user hierarchy before recalculation|

<a name="bkmk_forecastrecalculateasync"></a>

## msdyn_ForecastRecalculateAsync Action

[!INCLUDE[msdyn_ForecastRecalculateAsync-description](includes/msdyn_ForecastRecalculateAsync-description.md)]

### Parameters

|Name|Type|Description|
|-----|-----|-----|
|ForecastInstance|EntityReference|For Internal Use only.<br />Targets forecast instance record. Recalculation is performed on the forecast hierarchy of which this forecast instance is a part|
|IsRefreshHierarchy|Boolean|For Internal Use only.<br />Flag indicating if hierarchy is to be updated as per current user hierarchy before recalculation|

<a name="bkmk_msdynforecastgeneratehierarchy"></a>

## msdyn_ForecastGenerateHierarchy Action

[!INCLUDE[msdyn_ForecastGenerateHierarchy-description](includes/msdyn_ForecastGenerateHierarchy-description.md)]

### Parameters

|Name|Type|Description|
|-----|-----|-----|
|ForecastDefinition|EntityReference|For Internal Use only.<br />Targets forecast definition record. Hierarchies are generated/updated for this forecast definition|
|IsRefresh|Boolean|For Internal Use only.<br />Flag indicating if the hierarchy has to be generated from scratch or updated according to current user hierarchy|
|RecurrenceIndex|Integer|For Internal Use only.<br />In case above flag is true, the combination of this param and FD provides the exact hierarchy which needs to be updated|

### Returns

|Name|Type|Description|
|-----|-----|-----|
|ForecastCollection|EntityCollection|Collection of root forecast instances for the generated/updated hierarchies|

<a name="bkmk_msdynforecastrecalculateall"></a>

## msdyn_ForecastRecalculateAll Action

[!INCLUDE[msdyn_ForecastRecalculateAll-description](includes/msdyn_ForecastRecalculateAll-description.md)]

### Parameters

None

## See also

[User guide for Dynamics 365 for Sales](../../user-guide.md)<br />
[Administrator and Sales Manager guide](../../admin-guide.md)