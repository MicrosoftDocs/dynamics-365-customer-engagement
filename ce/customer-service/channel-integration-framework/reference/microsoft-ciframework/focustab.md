# focusTab

Sets the focus on a tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.

### Syntax

Microsoft.CIFramework.focusTab(tabId, correlationId).then(successCallback, errorCallback);

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                                |
|-----------------|----------|--------------|------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab                   |
| successCallback | Function | No           | A function to call when a record is retrieved. |
| errorCallback   | Function | No           | A function to call when the operation fails.   |

**Return Value**

None

**Example**

Microsoft.CIFramework.focusTab(tabId, correlationId).then(

function(result) {

return Promise.resolve(result);

},

function(error) {

return Promise.reject(error)

};

