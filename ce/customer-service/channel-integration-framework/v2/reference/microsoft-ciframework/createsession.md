---
title: "createSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes information about createSession method, its syntax, and parameters in Dynamics 365 Channel Integration Framework 2.0 JavaScript API Reference."
ms.date: 11/30/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# createSession (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Creates a new session based on the session template name and returns the unique identifier of the session that was created. 

If your organization uses single or multiple channel providers, then you can use this method to start a default session. More information: [Configure support for single and multiple channel providers](../../support-multiple-providers.md)

> [!Important]
> This method supports session templates of type **Generic** only.  

## Syntax

`Microsoft.CIFramework.createSession(input, correlationId).then(successCallback, errorCallback);`

## Parameters
  
| Name                  | Type     |  Required    | Description     |
|-----------------------|----------|--------------|-----------------|
| input                 | JSON object   | Yes          | String     |
| correlationId         | GUID     | No           | Used to group all related API calls together for diagnostic telemetry.          |
| successCallback       | Function | No           | A function to call when the request is successful. The input to this function is the unique identifier of the newly created session. |
| errorCallback         | Function | No           | A function to call when the request fails  |

The structure of the `input` parameter JSON is as follows:

```json
{ 
   "templateName":"<unique name of session template>",
   "templateParameters":{ 
      "globalparam":"number value OR boolean value OR json string value OR parameterized string value",
      "app template 1":{ 
         "param 1":"number value OR boolean value OR json string value OR parameterized string value",
         "param 2":"..."
      },
      "app template 2":"…."
   }
}
```

## Return value

Promise with a value as String.

## Example

```javascript
var input = {
   // unique name of the configured template   
    templateName: "msdyn_chat_session",
 
    templateParameters: {
        customer: "Contoso",
    }
    // Global and application tab template parameters, these values will override configured values
   };
Microsoft.CIFramework.createSession(input).then(function success(sessionId) {
    console.log(sessionId);
    // perform operations on session Id retrieved
}, function(error) {
    console.log(error.message);
    // handle error conditions
});
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
