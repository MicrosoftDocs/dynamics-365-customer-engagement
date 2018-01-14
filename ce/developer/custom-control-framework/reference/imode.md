# IMode

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [imode-description](includes/imode-description.md)]

## allocatedHeight

Height in pixels allocated to the control.

**Type**: `number`

**Required**: yes

## allocatedWidth

Width in pixels allocated to the control.

**Type**: `number`

**Required**: yes

## blur

Unfocus this control and any children.

**Type**: `function`

**Required**: yes

## contextInfo

Contains type, id and record name of current entity.

**Type**: `IContextInfo`

**Required**: yes

## focus

Focus this control and any parents.

**Type**: `function`

**Required**: yes

## hasFocus

Whether the control or it's child control has focus

**Type**: `boolean`

**Required**: yes

## isActive

Whether the control is on an active page in the navigation stack on the dom.

**Type**: `boolean`

**Required**: yes

## isControlDisabled

Whether the control is disabled.

**Type**: `string`

**Required**: yes

## isRead

Placeholder description: IMode.isRead

**Type**: `boolean`

**Required**: yes

## isVisible

Whether the control is visible on the page.

**Type**: `boolean`

**Required**: yes

## label

The defined control label.

**Type**: `string`

**Required**: yes

## rowSpan

The span of a rows for the multi-line controls.

**Type**: `number`

**Required**: yes

## Methods

|Method | Description | 
| ------------- |-------------|
|[clearNotification](imode/clearnotification.md)|[!INCLUDE [clearnotification-description](imode/includes/clearnotification-description.md)]|
|[setControlState](imode/setcontrolstate.md)|[!INCLUDE [setcontrolstate-description](imode/includes/setcontrolstate-description.md)]|
|[setFullScreen](imode/setfullscreen.md)|[!INCLUDE [setfullscreen-description](imode/includes/setfullscreen-description.md)]|
|[setNotification](imode/setnotification.md)|[!INCLUDE [setnotification-description](imode/includes/setnotification-description.md)]|
|[trackContainerResize](imode/trackcontainerresize.md)|[!INCLUDE [trackcontainerresize-description](imode/includes/trackcontainerresize-description.md)]|


### Related topics

[Custom Control Framework API Reference](index.md)<br />
[Custom Control Framework Overview](../custom-control-framework-overview.md)