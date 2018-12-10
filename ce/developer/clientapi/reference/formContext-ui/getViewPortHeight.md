---
title: "getViewPortHeight (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: e19af732-01e8-4853-b81c-40d79192cea2
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getViewPortHeight (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getViewPortHeight-description.md](./includes/getViewPortHeight-description.md)]

The viewport is the area of the page containing form data. It corresponds to the body of the form and does not include the navigation, header, footer or form assistant areas of the page.

## Syntax

`formContext.ui.getViewPortHeight();`

## Return Value

**Type**: Number

**Description**: The viewport height in pixels. 


### Related topics

[getViewPortWidth](getViewPortWidth.md)

[formContext.ui](../formContext-ui.md)

[formContext](../../clientapi-form-context.md)

