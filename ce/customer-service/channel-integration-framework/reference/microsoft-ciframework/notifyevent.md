# notifyEvent

Displays a notification that can be used to inform agent about an incoming conversation.

### Syntax

Microsoft.CIFramework.notifyEvent(input, correlationId).then(successCallback, errorCallback);

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                                                                                                  |
|-----------------|----------|--------------|------------------------------------------------------------------------------------------------------------------|
| input           | String   | Yes          | JSON input                                                                                                       |
| successCallback | Function | No           | On success callback, response object will have the information about whether customer selected Accept or Reject. |
| errorCallback   | Function | No           | A function to call when the operation fails.                                                                     |

**Return value**

None

**Example**

var input = {

templateName: "IncomingCallNotification",

templateParameters: {

number: "+1-123-4560-000"

}

}

Microsoft.CIFramework.notifyEvent(input).then(

function success(result) {

console.log(result);

// Perform operations

},

function (error) {

console.log(error.message);

// Handle error conditions

}

);

