---
title: "setPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information such as description, syntax, and parameters for the setPresence method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 03/21/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Sets the presence status of the agent in the client session​.

## Syntax

`Microsoft.CIFramework.setPresence(presenceText)`

## Parameters

| Name            | Type     | Required    | Description       |
|-----------------|----------|-------------|-------------------|
| presenceText   | String   | Yes         | Presence text for corresponding presence in Omnichannel for Customer Service. For the presence to be set correctly, the string should be an exact match with the text used in the admin app. To create custom presence, see [Configure and manage custom presence](../../../../presence-custom-presence.md).    |

## Return value

Returns a Boolean value of success.

## Example

```javascript
Microsoft.CIFramework.setPresence(custompresence).then(
                        function (result) {
                            if(!result)
                          //code handling when OC Presence is in error
                               else
                                //code handling for success
                        },
                        function (error) {
                            document.getElementById("setPresenceText").innerHTML = "ERROR";
                            reject(error);
                        });
                });
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]