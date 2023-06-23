## Syntax

`Microsoft.CIFramework.setWidth(value).then(successCallback, errorCallback);`

## Parameters

| Name   | Type   | Required | Description |
|--------|--------|----------|-------------|
| value           | Number   | Yes      | The width of the panel in pixels. |
| successCallback | Function | No       | A function to call when the panel width is set successfully. |
| errorCallback   | Function | No       | A function to call when the panel width setting operation fails. |

> [!NOTE]
> - If the `value` parameter passed for setWidth is greater than half of screen width, the side panel will collapse. 
> - The width should be greater than or equal to 300. The API doesn't consider any value less than 300.

## Return value

Returns a promise object with a value.

## Examples

The sample code demonstrates how to create a sample contact record.

```Javascript
// Setting Panel Width to 500
Microsoft.CIFramework.setWidth(500).then(
    function (result) {
        // result will have width of the panel, in pixels.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
