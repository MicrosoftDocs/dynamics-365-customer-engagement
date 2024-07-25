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