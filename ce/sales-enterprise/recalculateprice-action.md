---
title: "RecalculatePrice Action (Dynamics 365 for Sales) | MicrosoftDocs"
description: ""
keywords: recalculateprice
ms.date: 04/02/2019
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

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

This action is used to trigger out of box price calculation for Opportunity, Quote, Sales Order and Invoice entities. This action can be invoked server-side and client-side.

## Parameters

|Name|Type|Required|Description|
|----|----|----|----|
|entityName|string|Yes|Entity logical name|
|entityId|GUID|Yes|Entity GUID|

## Examples

**Request**

```HTTP
POST : [Organization URI]/api/data/v9.1/RecalculatePrice
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

### Client-side sample

```JavaScript
var recalculatePriceRequest = new ODataContract.ReCalculatePriceRequest({guid: ClientUtility.Guid.create(Xrm.Page.data.entity.getId())}, Xrm.Page.data.entity.getEntityName());
                Xrm.WebApi.online.execute(recalculatePriceRequest).then(() => {
                );
```

