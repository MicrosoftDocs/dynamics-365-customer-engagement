---
title: "CIFInitDone event (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about the CIFInitDone event raised by the Channel Integration Framework library in Dynamics 365 Channel Integration Framework 2.0."
ms.date: 02/25/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# CIFInitDone event (JavaScript API reference) for Dynamics 365 Channel Integration Framework 2.0

CIFInitDone event is raised by the Channel Integration Framework library when Channel Integration Framework is loaded. This event is used to determine if Channel Integration Framework APIs are ready to be consumed.

**Example**

```Javascript
(function () {
            window.addEventListener("CIFInitDone", function () {
                //Code that consumes CIF library APIs.
            });
        })();
```

### See also

[setClickToAct](../microsoft-ciframework/setClickToAct.md)

[addHandler](../microsoft-ciframework/addHandler.md)

[removeHandler](../microsoft-ciframework/removeHandler.md)


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
