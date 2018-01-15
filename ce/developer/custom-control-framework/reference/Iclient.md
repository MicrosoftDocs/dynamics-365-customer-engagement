# IClient

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [iclient-description](includes/iclient-description.md)]

## dateFormattingInfo

The interface for Date Formatting.

**Type**: `DateFormattingInfo`

## disableScroll

Whether this control should disable its scrolling capabilities

**Type**: `string`

## formFactor

Device form factor. None = 0 Slate = 1 Phone = 2 Desktop = 3 MailApp = 4

**Type**: `FormFactor`

## isPreview

Whether the control is rendered in the customization preview mode.

**Type**: `boolean`

## numberFormattingInfo

The interface for Number Formatting.

**Type**: `NumberFormattingInfo`

## orgSettings

Settings object for the organization.

**Type**: `object`

<!-- ICustomControlExposedOrgSettings -->

The `orgSettings` object contains the following properties:

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
|`showWeekNumber`|`boolean`|Information that specifies whether to display the week number.|


## Methods

|Method | Description | 
| ------------- |-------------|
|[getClient](iclient/getclient.md)|[!INCLUDE [getclient-description](iclient/includes/getclient-description.md)]|
|[getClientState](iclient/getclientstate.md)|[!INCLUDE [getclientstate-description](iclient/includes/getclientstate-description.md)]|
|[getFormFactor](iclient/getformfactor.md)|[!INCLUDE [getformfactor-description](iclient/includes/getformfactor-description.md)]|
|[ignoreSelfUpdates](iclient/ignoreselfupdates.md)|[!INCLUDE [ignoreselfupdates-description](iclient/includes/ignoreselfupdates-description.md)]|
|[isOffline](iclient/isoffline.md)|[!INCLUDE [isoffline-description](iclient/includes/isoffline-description.md)]|
|[setFullScreen](iclient/setfullscreen.md)|[!INCLUDE [setfullscreen-description](iclient/includes/setfullscreen-description.md)]|
