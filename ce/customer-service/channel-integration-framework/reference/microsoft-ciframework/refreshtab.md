# refreshTab

Refreshes the tab.

### Syntax

Microsoft.CIFramework.refreshTab(tabId, correlationId).then(successCallback, errorCallback);

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                                                       |
|-----------------|----------|--------------|-----------------------------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab                                          |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry |
| successCallback | Function | No           | A function to call when a record is retrieved.                        |
| errorCallback   | Function | No           | A function to call when the operation fails.                          |

**Return Value**

None

**Example**

Microsoft.CIFramework.refreshTab(tabId, correlationId).then(

function(result) {

// perform operations

},

function(error) {

return Promise.reject(error)

};

# Notification API reference

