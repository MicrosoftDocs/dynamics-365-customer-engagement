# IMode

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [imode-description](includes/imode-description.md)]

## allocatedHeight

Height in pixels allocated to the control.

**Type**: `number`



## allocatedWidth

Width in pixels allocated to the control.

**Type**: `number`



## blur

Unfocus this control and any children.

**Type**: `function`



## contextInfo

Contains type, id and record name of current entity.

**Type**: `object`

The contextInfo object contains the following properties:

|Name|Type|Optional|Description|
|--|--|--|--|
|`entityId`|`string`|no|The unique id for the entity|
|`entityRecordName`|`string`|yes|The value of the primary name attribute of the entity|
|`entityTypeName`|`string`|no|Logical name of the entity|


## focus

Focus this control and any parents.

**Type**: `function`


## hasFocus

Whether the control or it's child control has focus

**Type**: `boolean`


## isActive

Whether the control is on an active page in the navigation stack on the dom.

**Type**: `boolean`


## isControlDisabled

Whether the control is disabled.

**Type**: `string`


## isRead

Placeholder description: IMode.isRead

**Type**: `boolean`


## isVisible

Whether the control is visible on the page.

**Type**: `boolean`



## label

The defined control label.

**Type**: `string`



## rowSpan

The span of a rows for the multi-line controls.

**Type**: `number`



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