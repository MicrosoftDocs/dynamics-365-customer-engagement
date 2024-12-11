---
title: CIFInitDone event (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0 
description: Learn about the CIFInitDone event raised by the Channel Integration Framework library in Dynamics 365 Channel Integration Framework 1.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# CIFInitDone event (JavaScript API reference) for Dynamics 365 Channel Integration Framework 1.0

The CIFInitDone event is raised by the Dynamics 365 Channel Integration Framework library when Channel Integration Framework is loaded. This event is used to determine whether the Channel Integration Framework APIs are ready to be consumed.

**Example**

```Javascript
(function () {
            window.addEventListener("CIFInitDone", function () {
                //Code that consumes CIF library APIs.
            });
        })();
```

### Related information

[setClickToAct](../microsoft-ciframework/setClickToAct.md)  
[addHandler](../microsoft-ciframework/addHandler.md)  
[removeHandler](../microsoft-ciframework/removeHandler.md)  

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
