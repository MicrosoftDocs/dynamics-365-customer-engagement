# getAllSessions

### Returns the array of Session Ids for a given provider.

### Syntax

Microsoft.CIFramework.getAllSessions().then(successCallback, errorCallback);

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                   |
|-----------------|----------|--------------|-----------------------------------|
| successCallback | Function | No           | Call when the promise is resolved |
| errorCallback   | Function | No           | Call when the promise is rejected |

**Return Value**

Promise with the value as Array of strings.

**Example**

Microsoft.CIFramework.getAllSessions().then(
function success(result) {
console.log(result);
// perform operations session ids array
},
function (error) {
console.log(error.message);
// handle error conditions
}
);

