This method allows you to set automation dictionary. It enables providers to add, modify and remove values of slugs and the updated values are subsequently available for future macro invocations.

## Syntax

`Microsoft.CIFramework.updateContext(input, sessionId, isDelete, correlationId);`

## Parameters

| Parameter | Type | Required| Description |
| ------- |-------|-------|-------|
|input| JSON Object | Yes | JSON string |
|sessionId| String| No | Unique identifier of the current session. |
|isDelete| Boolean | No | Set `isDelete` to `true` if the list of parameters in `input` JSON are to be deleted.<br />If `isDelete` is set to `true`, the slug values will be deleted and will no longer be available for subsequent macro invocations.|
|correlationId| GUID| No |Used to group all related API calls together for diagnostic telemetry|

## Return value

Returns a promise with string value.

## Example

```javascript
var input = { "customerName" : "Contosso" };
Microsoft.CIFramework.updateContext(input).then(
    function success(result) {
        console.log(result);
        // Perform operations upon record retrieval and opening
    },
    function (error) {
        console.log(error.message);
        // Handle error conditions
    }
);
```
