# blurElementById

[!INCLUDE [blurelementbyid-description](includes/blurelementbyid-description.md)]

## Syntax

`blurElementById(id,isAbsoluteId)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|id|`string`|yes|The DOM id of the control to put focus on.|
|isAbsoluteId|`boolean`|no|Whether the id is absolute.|

## Example

```JavaScript
context.accessibility.blurElementById("myControlId",false);
```

[IAccessibility](../iaccessibility.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />