## Syntax

`Microsoft.CIFramework.removeHandler(eventName, handlerFunction);`

## Parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| eventName | string | Yes | Name of the event for which the handler is set. <br>The supported events are as follows:<br><ul><li><b>onclicktoact:</b> The event is invoked when the outbound communication (ClickToAct) enabled filed is clicked.</li> <li><b>onmodechanged:</b> The event is invoked when the panel mode is manually toggled between Minimized (0) and Docked (1). </li><li><b>onsizechanged:</b>The event is invoked when the panel size is manually changed by dragging </li><li><b>onpagenavigate:</b>The event is triggered before a navigation event occurs on the main page </li><li><b>onsendkbarticle: </b> The event is invoked when the user clicks the send button on the KB control.</li></ul>  |
| handlerFunction | Function | Yes | The handler function that is to removed. |

## Example

```Javascript

Microsoft.CIFramework.removeHandler(eventName, handlerFunction).then(
  function (result) {
      // result will indicate if the passed in handler function has been removed
      console.log(result)
  },
  function (error) {
      // code handling for promise failure
      console.error(error)
  }
);
```