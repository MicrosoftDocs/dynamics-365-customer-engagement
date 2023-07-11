## Syntax

`Microsoft.CIFramework.getWidth().then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description |
|-----------------|----------|----------|-------------|
| successCallback | Function | No       | A function to call when the request for the current width value is successful. |
| errorCallback   | Function | No       | A function to call when the request for the current width value fails. |

## Return value

**Type:** Number

**Description:** Returns a promise object containing the width of the panel, in pixels.

## Examples

```Javascript

Microsoft.CIFramework.getWidth().then(
    function (result) {
        // result will have width of the panel, in pixels.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```
