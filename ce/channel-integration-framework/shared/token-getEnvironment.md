## Syntax

`Microsoft.CIFramework.getEnvironment().then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description |
|-----------------|----------|----------|-------------|
| successCallback | Function | No       | A function to call when the request for environment details is successful. |
| errorCallback   | Function | No       | A function to call when the request for the environment fails.            |

## Return value

Returns a Promise object of type String with details of the current Unified Interface app and page.