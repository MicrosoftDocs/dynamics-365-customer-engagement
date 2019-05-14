---
title: "RecalculatePrice Action (Dynamics 365 for Sales) | MicrosoftDocs"
description: ""
keywords: recalculateprice
ms.date: 04/25/2019
ms.service:
  - dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: article
applies_to:
  - Dynamics 365 for Customer Engagement
  - Dynamics 365 for Customer Engagement apps version 9.x
ms.assetid: 1B6B25C3-5DD5-4527-987A-A786DEB240F4
author: susikka
ms.author: susikka
manager: shujoshi
---

# RecalculatePrice Action

[!INCLUDE[cc-applies-to-update-9-0-0](../../../includes/cc_applies_to_update_9_0_0.md)]

This action is used to trigger out of the box price calculation for Opportunity, Quote, Sales Order or Invoice entities. This action is applicable for both server and client invocations.

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

