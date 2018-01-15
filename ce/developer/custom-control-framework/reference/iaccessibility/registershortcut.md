# registerShortcut

[!INCLUDE [registershortcut-description](includes/registershortcut-description.md)]

## Syntax

`registerShortcut(keyCombination,shortcutHandler,isGlobal,areaName,shortcutDescription,srcElementId)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|keyCombination|`number[]`|yes|The keycodes for the shortcut keys.|
|shortcutHandler|`function`|yes|The function to be called back when the shortcut is pressed. The function must accept a [KeyboardEvent](https://developer.mozilla.org/docs/Web/API/KeyboardEvent) as a parameter and return void. |
|isGlobal|`boolean`|yes|Whether this shortcut applies to the full page or only a specific element.|
|areaName|`string`|yes|The area where this shortcut belongs to.|
|shortcutDescription|`string`|yes|The description of what the shortcut does.|
|srcElementId|`string`|no|If this shortcut is applied to a specific element, (isGlobal should be false), the id of the element.|





### Related topics

[IAccessibility](../iaccessibility.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />