# requestFocusSession

Sets the focus on the session whose Session Id is passed as a parameter, if the session belongs to the channel provider.

### Syntax

Microsoft.CIFramework.requestFocusSession(sessionId, correlationId).(successCallback, errorCallback);

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                                                        |
|-----------------|----------|--------------|------------------------------------------------------------------------|
| sessionId       | String   | Yes          | Unique identifier of the current session                               |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry. |
| successCallback | Function | No           | A function to call when the request is successful                      |
| errorCallback   | Function | No           | A function to call when the request fails                              |

**Return Value**

None

**Example**

Microsoft.CIFramework.requestFocusSession("session-id-1", correlationId).then(

function (result) {

return Promise.resolve(result);

},

function (error) {

return Promise.reject(error)

};

