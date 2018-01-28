# Popup

<!-- IPopupProps  -->

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [popup-description](includes/popup-description.md)]



## closeOnOutsideClick

Indicates whether we should NOT close the popup on an outside mouse click.

**Type**: `boolean`<br />
**Optional**

## content

Allows insertion of static markup to Popups.

**Type**: [HTMLElement](https://developer.mozilla.org/docs/Web/API/HTMLElement)

## id

The id to be set to the anchor control if any.

**Type**: `string`<br />
**Optional**

## name

The name of the Popup. Used like a reference to open Popups.

**Type**: `string`

## popupStyle

User-defined styles for the popup.

**Type**: [Style](style.md)<br />
**Optional**

## popupToOpen

The name of Popup which should be opened.

**Type**: `string`<br />
**Optional**

### Remarks
Should be defined ONLY in a Root Popup. To open nested Popups, should be provided string like `rootName.nestedName.[allOtherNestedNames]`. To close Popups, should be provided empty string. This property will be automatically propagated to children.

## shadowStyle

User-defined styles for the popups shadow.

**Type**: [Style](style.md)<br />
**Optional**

## type
<!-- PopupType -->
The type of Popup

**Type**: `enum`

The `type` value is an enum with the following possible values

|Value|Member|
|--|--|
|1|Root|
|2|Nested|

### Remarks
Should be only one `Root` Popup for each set of Popups.

### Related topics

[Custom Control Framework API Reference](index.md)<br />
[Custom Control Framework Overview](../custom-control-framework-overview.md)