# getFocusedTab 

Returns the focused tab's tabId in focused session, if the session belongs to the provider.

### Syntax

Microsoft.CIFramework.getFocusedTab().then(successCallback,errorCallback);

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                                 |
|-----------------|----------|--------------|-------------------------------------------------|
| successCallback | Function | No           | A function to call when the operation succeeds. |
| errorCallback   | Function | No           | A function to call when the operation fails.    |

## **Returns**

Promise with the value as String

**Example**

Microsoft.CIFramework.getFocusedTab().then(
function success(result) {
console.log(result);
// perform operations on tab id value
},
function (error) {
console.log(error.message);
// handle error conditions
}
);

