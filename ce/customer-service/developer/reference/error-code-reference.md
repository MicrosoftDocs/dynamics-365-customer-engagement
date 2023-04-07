---
title: "Error code reference for Omnichannel for Customer Service | MicrosoftDocs"
description: "This topic contains reference information about the error codes and error messages that are returned when using the live chat SDK methods."
ms.date: 04/04/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
---
# Error code reference for Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Here are the error codes and error messages that are returned by the live chat SDK methods.

|Error code|Error message|
|-----|-----|
|1|Custom context provider method execution failed|
|2|Auth token provider method execution failed|
|3|Auth token provider didn't provide any token|
|4|Auth token provider provided invalid token|
|7|Live chat widget scripts failed to load|
|8|Auth function cannot be found on webpage|

> [!Note]
> The live chat widget script can fail to load for a number of reasons. One possible reason is the user has disabled access to session and local storage in their browser. The reason will be described in the `errorDetail` attribute. 

Here's a sample `errorEvent` object that's raised when the context provider method fails to run.

```JSON
{
    detail: {
        errorCode: 1, // Error code corresponding to the error event
        errorDescription: "Context provider method execution failed" // Description of the error
    }
}
```

### See also

[Live chat SDK reference](../omnichannel-reference.md)  
[Developer guide](../omnichannel-developer.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
