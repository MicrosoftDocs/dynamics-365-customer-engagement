## Syntax

`Microsoft.CIFramework.getMode().then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description |
|-----------------|----------|----------|-------------|
| successCallback | Function | No       | A function to call when the request for the current state of the panel is successful. |
| errorCallback   | Function | No       | A function to call when the request for the current state of the panel fails.         |

## Return value

**Type:** String

**Description:** Returns Promise object with the value (current state of the panel). Returns 0 for minimized mode and 1 for docked mode.

## Examples

The sample code demonstrates how to create a sample contact record.

```JavaScript
Microsoft.CIFramework.getMode().then(
    function (result) {
        // result will have current state of the panel.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
