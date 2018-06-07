---
title: Client | Microsoft Docs
description: 
keywords:
ms.author: nabuthuk
manager: 
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4ce41c82-bf4a-4d34-9344-5311c24d76de
---

# Client

<!-- IClient -->

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [client-description](includes/client-description.md)]

<!--## dateFormattingInfo

The interface for Date Formatting.

**Type**: [DateFormattingInfo](dateformattinginfo.md)-->

## disableScroll

Whether this control should disable its scrolling capabilities

**Type**: `string`

## formFactor

The Device form factor.

**Type**: `enum`

The `formFactor` value is an enum with the following possible values

|Value|Member|
|--|--|
|0|None|
|1|Slate|
|2|Phone|
|3|Desktop|
|4|MailApp|

<!--## isPreview

Whether the control is rendered in the customization preview mode.

**Type**: `boolean`

## numberFormattingInfo

The interface for Number Formatting.

**Type**: [NumberFormattingInfo](numberformattinginfo.md)

## orgSettings

Settings object for the organization.

**Type**: `object`-->

<!-- ICustomControlExposedOrgSettings -->

<!--The `orgSettings` object contains the following properties:

|Name|Type|Description|
|--|--|--|
|`boundDashboardDefaultCardExpanded`|`boolean`|Whether to show the Card Form in Expanded State or not|
|`fiscalPeriodConnector`|`string`|How the names of the fiscal year and the fiscal period should be connected when displayed together.|
|`fiscalPeriodFormat`|`number`|How the name of the fiscal period is displayed.|
|`fiscalPeriodType`|`number`|Type of fiscal period used.|
|`fiscalYearDisplayCode`|`number`|Whether the fiscal year should be displayed based on the start date or the end date of the fiscal year.|
|`fiscalYearFormatPrefix`|`number`|Prefix for the display of the fiscal year.|
|`fiscalYearFormatSuffix`|`number`|Suffix for the display of the fiscal year.|
|`fiscalYearFormatYear`|`number`|Format for the year.|
|`fiscalYearStartDate`|`Date`|Start date for the fiscal period.|
|`isActionCardEnabled`|`boolean`|Whether ActionCard is enabled.|
|`isEmailMonitoringAllowed`|`boolean`|Whether email monitoring is allowed.|
|`organizationId`|`string`|Identifier of the organization.|
|`showWeekNumber`|`boolean`|Information that specifies whether to display the week number.|-->


## Methods

|Method | Description | 
| ------------- |-------------|
|[getClient](client/getclient.md)|[!INCLUDE [getclient-description](client/includes/getclient-description.md)]|
|[getFormFactor](client/getformfactor.md)|[!INCLUDE [getformfactor-description](client/includes/getformfactor-description.md)]|
|[isOffline](client/isoffline.md)|[!INCLUDE [isoffline-description](client/includes/isoffline-description.md)]|
<!--|[getClientState](client/getclientstate.md)|[!INCLUDE [getclientstate-description](client/includes/getclientstate-description.md)]|
|[getFormFactor](client/getformfactor.md)|[!INCLUDE [getformfactor-description](client/includes/getformfactor-description.md)]|
|[ignoreSelfUpdates](client/ignoreselfupdates.md)|[!INCLUDE [ignoreselfupdates-description](client/includes/ignoreselfupdates-description.md)]|
|[isOffline](client/isoffline.md)|[!INCLUDE [isoffline-description](client/includes/isoffline-description.md)]|
|[setFullScreen](client/setfullscreen.md)|[!INCLUDE [setfullscreen-description](client/includes/setfullscreen-description.md)]|-->

### Related topics

[Custom Control Framework API Reference](index.md)<br />
[Custom Control Framework Overview](../custom-control-framework-overview.md)
