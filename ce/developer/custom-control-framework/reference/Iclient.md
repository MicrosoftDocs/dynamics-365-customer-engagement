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

**Type**: `ICustomControlExposedOrgSettings`

<!--QUESTION: Why is ICustomControlExposedOrgSettings different from IOrgSettings? -->


## Methods

|Method | Description | 
| ------------- |-------------|
|[getClient](iclient/getclient.md)|[!INCLUDE [getclient-description](iclient/includes/getclient-description.md)]|
|[getClientState](iclient/getclientstate.md)|[!INCLUDE [getclientstate-description](iclient/includes/getclientstate-description.md)]|
|[getFormFactor](iclient/getformfactor.md)|[!INCLUDE [getformfactor-description](iclient/includes/getformfactor-description.md)]|
|[ignoreSelfUpdates](iclient/ignoreselfupdates.md)|[!INCLUDE [ignoreselfupdates-description](iclient/includes/ignoreselfupdates-description.md)]|
|[isOffline](iclient/isoffline.md)|[!INCLUDE [isoffline-description](iclient/includes/isoffline-description.md)]|
|[setFullScreen](iclient/setfullscreen.md)|[!INCLUDE [setfullscreen-description](iclient/includes/setfullscreen-description.md)]|
