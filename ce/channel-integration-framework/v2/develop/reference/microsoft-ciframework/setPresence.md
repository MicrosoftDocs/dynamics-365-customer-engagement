---
title: setPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 
description: Includes reference information such as description, syntax, and parameters for the setPresence method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# setPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Sets the presence text of the agent in the client session​.

## Syntax

`Microsoft.CIFramework.setPresence(presenceText)`

## Parameters

| Name            | Type     | Required    | Description       |
|-----------------|----------|-------------|-------------------|
| presenceText   | String   | Yes         | Presence text for current agent in Omnichannel for Customer Service. For the presence to be set correctly, the string should exactly match the text used in the admin app. To create custom presence, see [Configure and manage custom presence](../../../../../customer-service/administer/presence-custom-presence.md).    |

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
                            reject(error);
                        });
                });
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
