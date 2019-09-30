# getFocusedSession

Returns the unique identifier of the session that is in focus, if it belongs to the channel provider else returns null. 

### Syntax

Microsoft.CIFramework.getFocusedSession().then(successCallback, errorCallback);

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                                                               |
|-----------------|----------|--------------|-------------------------------------------------------------------------------|
| successCallback | Function | No           | A function to call when the request for setting the panel state is successful |
| errorCallback   | Function | No           | A function to call when the request for setting the panel state fails         |

**Return Value**

## Promise with the value as String

**Example**

Microsoft.CIFramework.getFocusedSession().then(
function success(result) {
console.log(result);
// perform operations on session id value
},
function (error) {
console.log(error.message);
// handle error conditions
}
);

