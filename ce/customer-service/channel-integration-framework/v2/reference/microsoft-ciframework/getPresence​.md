---
title: "getPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the getPresence method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 02/28/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Returns the presence status of the agent in the client session​.

## Syntax

`Microsoft.CIFramework.getPresence();`

## Parameters

None.

## Return value

Returns a Boolean value of success.

## Example

```javascript
Microsoft.CIFramework.getPresence().then( 
                        function (result) { 
                            if (result == "FAILED") 
                                document.getElementById("presenceOnChangeText").innerHTML = "OC Presence is in error state"; 
                            else { 
                                document.getElementById("presenceOnChangeText").innerHTML = result; 
                                displayPresence(result); 
                            } 
                            return result; 
                        }, 
                        function (error) { 
                            document.getElementById("presenceOnChangeText").innerHTML = "ERROR"; 
                            reject(error); 
                        }); 
```

### See also
[Configure and manage custom presence](../../../../../presence-custom-presence.md)  

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
