---
title: "onPresenceChange​ event (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information about the onPresenceChange​ event such as syntax and example for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 03/14/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# onPresenceChange​ event (JavaScript API reference) for Dynamics 365 Channel Integration Framework 2.0

Invoked when the presence or availability status of an agent has changed either manually or programmatically. 

**Example**

```Javascript
handlerFunction = function (eventData) { 
                    var obj = JSON.parse(eventData); 
                    var presence = obj.presenceInfo.presenceText; 
                    displayPresence(presence) 
                } 
                window.Microsoft.CIFramework.addHandler("onPresenceChange", handlerFunction); 
```

### See also

[setClickToAct method](../../microsoft-ciframework/setClickToAct.md)  
[addHandler method](../microsoft-ciframework/addHandler.md)  
[removeHandler method](../microsoft-ciframework/removeHandler.md)  
[getPresence method](../microsoft-ciframework/getPresence.md)  
[setPresence method](../microsoft-ciframework/setPresence.md)  


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
