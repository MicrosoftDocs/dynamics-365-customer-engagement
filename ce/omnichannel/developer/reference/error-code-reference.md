---
title: "Error code reference for Omnichannel for Customer Service | MicrosoftDocs"
description: "Read about the error codes and error messages that are returned when using the live chat SDK methods, and how to resolve the errors"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 07/09/2019
ms.topic: article
---
# Error code reference for Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Here are the error codes and error messages that are returned when using live chat JavaScript API methods.

|Error Code|Error message|
|-----|-----|
|1|Custom context provider method execution failed|
|2|Auth token provider method execution failed|
|3|Auth token provider didn't provide any token|
|4|Auth token provider provided invalid token|

Given below is a sample `errorEvent` object that is raised when the context provider method execution fails.

```JSON
{
    detail: {
        errorCode: 1, // Error code corresponding to the error event
        errorDescription: "Context provider method execution failed" // Description of the error
    }
}
```

### See also

[JavaScript API reference for Live chat SDK](../omnichannel-reference.md)<br />
[Developer guide](../omnichannel-developer.md)
