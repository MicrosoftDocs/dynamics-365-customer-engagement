---
title: "cifinitdone event (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 1.0 | Microsoft Docs"
description: "Learn about CIFInitDone evenet for Dynamics 365 Channel Integration Framework (CIF) version 1.0."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 02/25/2021
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# CIFInitDone event (CIF JavaScript API reference)

CIFInitDone event is raised by the Channel integration framework library when the Channel integration framework  is loaded. This event is used to determine if CIF APIs are ready to be consumed.

**Example**

```Javascript
(function () {
            window.addEventListener("CIFInitDone", function () {
                //Code that consumes CIF library APIs.
            });
        })();
```

## See also

[setClickToAct](../microsoft-ciframework/setClickToAct.md)

[addHandler](../microsoft-ciframework/addHandler.md)

[removeHandler](../microsoft-ciframework/removeHandler.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]