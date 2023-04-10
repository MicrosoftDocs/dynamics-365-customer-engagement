---
title: "onPresenceChange​ event (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information about the onPresenceChange​ event such as syntax and example for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 04/04/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# onPresenceChange​ event (JavaScript API reference) for Dynamics 365 Channel Integration Framework 2.0

Invoked when the presence status of an agent has changed manually or programmatically.

## eventData

The `onPresenceChange` event takes the following eventData:

| eventData | Example |
|-----------|---------|
| ```{"presenceId": <guid>}``` | ```{"presenceId": "efdeb843-c07a-e811-8162-000d3aa11f50"}``` |
| ```{"presenceInfo":{"basePresenceStatus":<string>, "presenceColor":<string>, "presenceId":<string>,"presenceText":<string>}}``` | ```{"presenceInfo":{"basePresenceStatus: "BUSY", "presenceColor": "#ff0000", "presenceId":"efdeb843-c07a-e811-8162-000d3aa11f50", "presenceText": "Busy"}}``` |

**Example**

```Javascript
handlerFunction = function (eventData) { 
                    var obj = JSON.parse(eventData); 
                    var presence = obj.presenceInfo.presenceText; 
                } 
                window.Microsoft.CIFramework.addHandler("onPresenceChange", handlerFunction); 
```

### See also

[setClickToAct method](../microsoft-ciframework/setClickToAct.md)  
[addHandler method](../microsoft-ciframework/addHandler.md)  
[removeHandler method](../microsoft-ciframework/removeHandler.md)  
[getPresence method](../microsoft-ciframework/getPresence.md)  
[setPresence method](../microsoft-ciframework/setPresence.md)  

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
