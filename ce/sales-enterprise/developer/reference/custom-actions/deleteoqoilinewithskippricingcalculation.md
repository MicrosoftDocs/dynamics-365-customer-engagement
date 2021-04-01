---
title: "DeleteOQOILineWithSkipPricingCalculation custom action (Dynamics 365 Sales) | MicrosoftDocs"
description: 
ms.date: 07/09/2020
ms.service: dynamics-365-sales
ms.topic: get-started-article
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: susikka
ms.custom: 
  - dyn365-sales
---
# DeleteOQOILineWithSkipPricingCalculation custom action

Enables you to delete opportunity, quote, order, and invoice line item without triggering price calculation.

## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|entityName|String|Yes|Name of the entity|
|entityId|GUID|Yes|Unique identifier of the entity record|

## Example

This custom action can be used both client-side and server-side. Given below are examples on how you can make server-side and client-side calls to this custom action.

**Server-side Web API call**

```html
POST [Organization URI]/api/data/v9.1/DeleteOQOILineWithSkipPricingCalculation
{
    "entityName": "invoicedetail",
    "entityId":"91F3EDB0-213B-E911-8190-000D3AFD8945"
}
```

**Client-side Web API call**

```javascript
var deleteOQOILineWithSkipPricingCalculationRequest= new ODataContract.DeleteOQOILineWithSkipPricingCalculationRequest({guid: ClientUtility.Guid.create(Xrm.Page.data.entity.getId())}, Xrm.Page.data.entity.getEntityName());
                Xrm.WebApi.online.execute(deleteOQOILineWithSkipPricingCalculationRequest).then(() => {
                    Xrm.Page.data.refresh(false);
                }, ClientUtility.ActionFailedHandler.actionFailedCallback);

```

### See also

[msdyn_ForecastApi](msdyn_ForecastApi.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
