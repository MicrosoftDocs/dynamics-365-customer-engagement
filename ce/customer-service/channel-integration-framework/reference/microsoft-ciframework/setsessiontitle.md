# setSessionTitle

Sets the session title, if the session belongs to the channel provider.

### Syntax

Microsoft.CIFramework.setSessionTitle(sessionId,title).then(successCallback, errorCallback);

**Parameters**

| **Name**        | **Type** | **Required** | **Description**                                   |
|-----------------|----------|--------------|---------------------------------------------------|
| sessionId       | String   | Yes          | Unique identifier of the session                  |
| title           | String   | Yes          | Session title                                     |
| successCallback | Function | No           | A function to call when the request is successful |
| errorCallback   | Function | No           | A function to call when the request fails         |

**Return Value**

None

**Example**

var input = {

sessionId: "session-id-16",

customer: "John"

};

// setSessionTitle needs two params in input bag.

// 1. sessionId

// 2. slug name which we use in title field of session template record.. In sample, we have given value as "Call from {customer}"

// hence we pass "customer" in the input bag parameter.

Microsoft.CIFramework.setSessionTitle(input);

