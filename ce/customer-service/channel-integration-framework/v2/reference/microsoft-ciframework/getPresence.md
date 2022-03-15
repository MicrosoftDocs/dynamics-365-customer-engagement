---
title: "getPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information such as description, syntax, and parameters for the getPresence method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 03/15/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getPresence (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Returns the presence status of the agent in the client session​.

## Syntax

`Microsoft.CIFramework.getPresence();`

## Parameters

None.

## Return value

Returns the presence status of the agent in the client session.

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

                           // code handling for promise faiure
                        });

                });
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
