---
title: getPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0
description: Includes reference information such as description, syntax, and parameters for the getPresence method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# getPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Returns the presence text of the agent in the client session​.

## Syntax

`Microsoft.CIFramework.getPresence();`

## Parameters

None.

## Return value

Promise with the presence text of the current agent, as String.

## Example

```javascript
function getPresence() {
                return new Promise((resolve, reject) => {
                    Microsoft.CIFramework.getPresence().then(
                        function (result) {
                            if (result == "FAILED")
                               //your code handling for failure
                            else {
                               //your code for success
                            }
                            return result;
                        },
                        function (error) {
                           // code handling for promise failure
                        });
                });
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
