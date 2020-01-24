## Syntax

`Microsoft.CIFramework.getEnvironment().then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description |
|-----------------|----------|----------|-------------|
| successCallback | Function | No       | A function to call when the request for environment details are successful |
| errorCallback   | Function | No       | A function to call when the request for the environment fails              |

## Return value

**Type:** String

<!--note from editor: Why are these values formatted this way, with the single asterisk and the values bracketed with straight apostrophes? Were they meant to be backticks?-->
**Description:** Returns a promise object containing a string with the available details of the current Unified Interface page. The details include: * 'appid', 'pagetype', 'record-id' (if available), 'clientUrl', 'appUrl' 'orgLcid', 'orgUniqueName', 'userId', 'userLcid', 'isDirty', and 'username'.