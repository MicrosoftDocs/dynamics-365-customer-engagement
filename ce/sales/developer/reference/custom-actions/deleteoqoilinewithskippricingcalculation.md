---
title: DeleteOQOILineWithSkipPricingCalculation custom action
description: Use this topic to understand the parameters, and web API calls for deleting a line item without triggering price calculation.
ms.date: 10/26/2021
ms.topic: conceptual
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
---
# DeleteOQOILineWithSkipPricingCalculation custom action 

As a developer, use this reference documentation to understand the parameters, and web API calls for deleting an opportunity, quote, order, and invoice without triggering price calculation.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System customizer <br>  More information: [Predefined security roles for Sales](../../../security-roles-for-sales.md)|


## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|entityLogicalName|String|Yes|Name of the entity|
|entityId|GUID|Yes|Unique identifier of the entity record|

## Example

This custom action can be used both client-side and server-side. Given below are examples on how you can make server-side and client-side calls to this custom action.

**Server-side Web API call**

```html
POST [Organization URI]/api/data/v9.1/DeleteOQOILineWithSkipPricingCalculation
{
    "entityLogicalName": "invoicedetail",
    "entityId":"00aa00aa-bb11-cc22-dd33-44ee44ee44ee"
}
```

**Client-side Web API call**

```javascript
var deleteOQOILineWithSkipPricingCalculationRequest= new ODataContract.DeleteOQOILineWithSkipPricingCalculationRequest({guid: ClientUtility.Guid.create(Xrm.Page.data.entity.getId())}, Xrm.Page.data.entity.getEntityName());
                Xrm.WebApi.online.execute(deleteOQOILineWithSkipPricingCalculationRequest).then(() => {
                    Xrm.Page.data.refresh(false);
                }, ClientUtility.ActionFailedHandler.actionFailedCallback);

```

## Related information

[msdyn_ForecastApi](msdyn_ForecastApi.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
