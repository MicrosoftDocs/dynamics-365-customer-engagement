## Syntax

`Microsoft.CIFramework.setWidth(value).then(successCallback, errorCallback);`

## Parameters

| Name   | Type   | Required | Description |
|--------|--------|----------|-------------|
| value           | Number   | Yes      | The width of the panel in pixels. |
| successCallback | Function | No       | A function to call when the panel width is set successfully. |
| errorCallback   | Function | No       | A function to call when the panel width is setting operation fails. |

> [!NOTE]
> If the `value` parameter passed for setWidth is greater than half of screen width, the side panel will collapse. setWidth API should be called with lesser width value to be able to use the side panel.

## Return value

Returns a promise object with a value.
