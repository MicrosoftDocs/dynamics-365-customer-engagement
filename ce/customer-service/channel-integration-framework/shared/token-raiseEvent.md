## Syntax

`Microsoft.CIFramework.removeHandler(eventName, handlerFunction);`

## Parameters

| Name                 | Type   | Required | Description    |
|------                |------  |----------|-------------   |
| eventName            | String | Yes      | Name of the event whose handler needs to be invoked. |
| eventInputParameters | String | Yes      | The input parameters that needs to be passed to the handler function. |
| correlationId        | GUID   | No       |  Used to group all related API calls together for diagnostic telemetry.  |

## Return value

Promise with a value as Boolean.

## Example

```JavaScript
// Let there be an event registered to a subscriber.
handlerFunction = function(eventInput) {
console.log(eventData);
if(eventInput != null &&  eventInput != undefined && eventInput.size > 0) {
inputData = eventInput.get("value");
correlationId = eventInput.get("correlationId");
console.log(inputData + " " + correlationId);
}
return Promise.resolve();
}

Microsoft.CIFramework.addHandler("oncustomevent", handlerFunction);

//Use raiseEvent API to invoke the subscribed handler of the event.
Microsoft.CIFramework.raiseEvent("oncustomevent", "test input value");
```
