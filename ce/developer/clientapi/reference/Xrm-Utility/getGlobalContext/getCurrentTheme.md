---
title: "getCurrentTheme (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: f7c1dcb1-c27b-4161-9c05-f824bf8f2b29
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getCurrentTheme (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns a string representing the current theme name in the application.

## Syntax

```JavaScript
var globalContext = Xrm.Utility.getGlobalContext();
globalContext.getCurrentTheme();
```

## Return Value

**Type**: String

**Description**: Use this information to select an appropriate theme for your HTML and
Silverlight web resources.

## Remarks

This function does not work with Dynamics 365 for tablets.

### Related topics

[Xrm.Utility.getGlobalContext](../getGlobalContext.md)
 



