---
title: "RecalculatePrice Action - Developer Guide | MicrosoftDocs"
description: "Programmatically trigger the out-of-the-box price calculation for Opportunity, Quote, Sales Order or Invoice entities."
ms.date: 04/25/2019
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - dyn365-sales
---
# RecalculatePrice Action 

This action is used to trigger out of the box price calculation for Opportunity, Quote, Sales Order or Invoice entities. This action is applicable for both server and client invocations.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System customizer <br>  More information: [Predefined security roles for Sales](../../security-roles-for-sales.md)|


## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|entityLogicalName|String|Yes|Entity logical name|
|entityId|GUID|Yes|Entity GUID|

## Examples

### Server Invocation

**Request**

```HTTP
POST [Organization URI]/api/data/v9.1/RecalculatePrice
{
    "entityLogicalName": "quote",
    "entityId":"91F3EDB0-213B-E911-8190-000D3AFD8945"
}
```

**Response**

```
HTTP/1.1 204 No Content
OData-Version: 4.0
```

### Client Invocation

```JavaScript
function RecalculatePrice(formContext) {
    var entityName = formContext.data.entity.getEntityName();
    var parameters = {};
    var target = {};
    target[entityName + "id"] = formContext.data.entity.getId();
    target["@odata.type"] = "Microsoft.Dynamics.CRM." + entityName;
    parameters.Target = target;

    var recalculatePriceRequest = {
        Target: parameters.Target,

        getMetadata: function () {
            return {
                boundParameter: null,
                parameterTypes: {
                    "Target": {
                        "typeName": "mscrm.crmbaseentity",
                        "structuralProperty": 5
                    }
                },
                operationType: 0,
                operationName: "CalculatePrice"
            };
        }
    };

    Xrm.WebApi.online.execute(recalculatePriceRequest).then(
        function success(result) {
            if (result.ok) {
                //Success
            }
        },
        function (error) {
            Xrm.Utility.alertDialog(error.message);
        }
    );
}
```



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
