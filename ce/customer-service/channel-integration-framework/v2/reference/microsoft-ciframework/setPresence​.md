---
title: "setPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the setPresence method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 02/28/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!include[applies-to-v2](../../includes/applies-to-v2.md)]

[!include[session-api-omnichannel](../../includes/session-api-omnichannel.md)]

Sets the presence status of the agent in the client session​.

## Syntax

`Microsoft.CIFramework.setPresence(presenceState)`

## Parameters

| Name            | Type     | Required    | Description       |
|-----------------|----------|-------------|-------------------|
| presenceState   | String   | Yes         | Presence text for corresponding presence in Omnichannel for Customer Service. For the presence to be correctly set, the string should be an exact match with text used in admin application.     |

## Return value

Returns "FAILED" in case of any presence issues in Omnichannel for Customer Service. 

## Example

```javascript
Microsoft.CIFramework.setPresence(custompresence).then( 
                        function (result) { 
                            if(!result) 
                            document.getElementById("setPresenceText").innerHTML = "OC Presence is in error state"; 
                        }, 
                        function (error) {  
                            document.getElementById("setPresenceText").innerHTML = "ERROR"; 
                            reject(error); 
                        }); 
```

### See also

[Configure and manage custom presence](../../../../../presence-custom-presence.md)  

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
