## Syntax

`Microsoft.CIFramework.setMode(value).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description |
|-----------------|----------|----------|-------------|
| value           | Number   | Yes      | The value to set the mode of the panel.<br /><table><tr><td>CIF version 1.0</td><td>CIF version 2.0</td></tr><tr><td>Provide `0` to minimize the panel.<br />Provide `1` to dock the panel.</td><td>Provide `0` to minimize the panel.<br />Provide `1` to dock the panel.<br />Provide `2` to hide the panel.</td></tr></table> |
| successCallback | Function | No       | A function to call when the request for setting the panel state is successful.                     |
| errorCallback   | Function | No       | A function to call when the request for setting the panel state fails.                             |

## Return value

Returns a promise object with a value.
