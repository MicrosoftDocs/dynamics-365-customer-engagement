## Syntax

`Microsoft.CIFramework.getEnvironment().then(successCallback, errorCallback);`

## Parameters

| Name            | Type    | Required | Description |
|-----------------|----------|---------|-------------|
| successCallback | Function | No      | A function to call when the request for environment details are successful |
| errorCallback   | Function | No      | A function to call when the request for the environment fails              |

## Return value

Returns a promise object of type String with the available details of the current Unified Interface page. The details include: `appid`, `pagetype`, `record-id` (if available), `clientUrl`, `appUrl`, `orgLcid`, `orgUniqueName`, `userId`, `userLcid`, `isDirty`, and `username`.
