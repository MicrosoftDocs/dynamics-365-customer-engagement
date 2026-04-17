---
title: "Create work orders using the Dataverse Web API"
description: "Learn how to create one or multiple work orders in Dynamics 365 Field Service using the Dataverse Web API with HTTP/JSON examples."
ms.date: 04/07/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: puneetsingh
search.audienceType:
  - developer
---

# Create work orders using the Dataverse Web API

This article provides examples of creating work orders in Dynamics 365 Field Service using the [Dataverse Web API](/power-apps/developer/data-platform/webapi/overview). The examples use the [msdyn_workorder](developer/reference/entities/msdyn_workorder.md) entity.

## Prerequisites

- A Dynamics 365 Field Service environment with the Web API endpoint (for example, `https://yourorg.api.crm.dynamics.com/api/data/v9.2/`).
- An authenticated request using OAuth 2.0. Learn more in [Authenticate to Dataverse with the Web API](/power-apps/developer/data-platform/webapi/authenticate-web-api).
- Existing records for the required lookup fields:
  - **Service Account** (`account` entity)
  - **Work Order Type** (`msdyn_workordertype` entity)
  - **Price List** (`pricelevel` entity)

> [!IMPORTANT]
> The GUIDs in the following examples are fictitious. Replace them with the actual record IDs from your Dynamics 365 environment.

## Create a single work order

Send a `POST` request to the `msdyn_workorders` entity set to create a work order. Learn more in [Create a table row using the Web API](/power-apps/developer/data-platform/webapi/create-entity-web-api).

### HTTP request

```http
POST [Organization URL]/api/data/v9.2/msdyn_workorders
Accept: application/json
Content-Type: application/json
OData-MaxVersion: 4.0
OData-Version: 4.0
Authorization: Bearer <access_token>

{
  "msdyn_serviceaccount@odata.bind": "/accounts(e1a2b3c4-5678-9abc-def0-1234567890ab)",
  "msdyn_workordertype@odata.bind": "/msdyn_workordertypes(a1b2c3d4-5678-9abc-def0-1234567890cd)",
  "msdyn_pricelist@odata.bind": "/pricelevels(f1e2d3c4-5678-9abc-def0-1234567890ef)",
  "msdyn_systemstatus": 690970000,
  "msdyn_taxable": false,
  "msdyn_instructions": "Install new equipment"
}
```

### HTTP response

A successful request returns `HTTP 204 No Content` with a `OData-EntityId` header containing the URL of the new work order record.

## Create multiple work orders

To create multiple work orders in a single request, use the `CreateMultiple` action. This is more performant than individual POST requests or batch operations. Learn more in [Use bulk operation messages](/power-apps/developer/data-platform/bulk-operations).

### HTTP request

```http
POST [Organization URL]/api/data/v9.2/msdyn_workorders/Microsoft.Dynamics.CRM.CreateMultiple
Accept: application/json
Content-Type: application/json
OData-MaxVersion: 4.0
OData-Version: 4.0
Authorization: Bearer <access_token>

{
  "Targets": [
    {
      "@odata.type": "Microsoft.Dynamics.CRM.msdyn_workorder",
      "msdyn_serviceaccount@odata.bind": "/accounts(e1a2b3c4-5678-9abc-def0-1234567890ab)",
      "msdyn_workordertype@odata.bind": "/msdyn_workordertypes(a1b2c3d4-5678-9abc-def0-1234567890cd)",
      "msdyn_pricelist@odata.bind": "/pricelevels(f1e2d3c4-5678-9abc-def0-1234567890ef)",
      "msdyn_systemstatus": 690970000,
      "msdyn_taxable": false,
      "msdyn_instructions": "Work order 1 - Install new equipment"
    },
    {
      "@odata.type": "Microsoft.Dynamics.CRM.msdyn_workorder",
      "msdyn_serviceaccount@odata.bind": "/accounts(e1a2b3c4-5678-9abc-def0-1234567890ab)",
      "msdyn_workordertype@odata.bind": "/msdyn_workordertypes(a1b2c3d4-5678-9abc-def0-1234567890cd)",
      "msdyn_pricelist@odata.bind": "/pricelevels(f1e2d3c4-5678-9abc-def0-1234567890ef)",
      "msdyn_systemstatus": 690970000,
      "msdyn_taxable": false,
      "msdyn_instructions": "Work order 2 - Preventive maintenance check"
    }
  ]
}
```

### HTTP response

A successful request returns `HTTP 200 OK` with the IDs of the created records.

```json
{
  "@odata.context": "[Organization URL]/api/data/v9.2/$metadata#Microsoft.Dynamics.CRM.CreateMultipleResponse",
  "Ids": [
    "c1d2e3f4-5678-9abc-def0-111111111111",
    "c1d2e3f4-5678-9abc-def0-222222222222"
  ]
}
```

## Retrieve a work order

After you create a work order, retrieve it with a `GET` request.

```http
GET [Organization URL]/api/data/v9.2/msdyn_workorders(<work-order-id>)?$select=msdyn_name,msdyn_systemstatus,msdyn_address1,msdyn_city
Accept: application/json
OData-MaxVersion: 4.0
OData-Version: 4.0
Authorization: Bearer <access_token>
```

### Response

```json
{
  "@odata.context": "[Organization URL]/api/data/v9.2/$metadata#msdyn_workorders(msdyn_name,msdyn_systemstatus,msdyn_address1,msdyn_city)/$entity",
  "@odata.etag": "W/\"7998533\"",
  "msdyn_workorderid": "d4e5f6a7-1234-5678-9abc-def012345678",
  "msdyn_name": "00051",
  "msdyn_systemstatus": 690970000,
  "msdyn_address1": "205 108th Ave NE",
  "msdyn_city": "Bellevue"
}
```

> [!NOTE]
> The `msdyn_name` field contains the auto-assigned work order number generated by Field Service. The `msdyn_address1` and `msdyn_city` values are populated from the service account record.

## Error handling

Common error responses when creating work orders:

| Status Code | Reason | Resolution |
|---|---|---|
| `400 Bad Request` | Missing required fields or invalid field values. | Verify that all required fields (`msdyn_serviceaccount`, `msdyn_workordertype`, `msdyn_pricelist`, `msdyn_systemstatus`, `msdyn_taxable`) are included with valid values. |
| `400 Bad Request` (code `0x80060888`) | Lookup field value is a bare GUID without an entity set path. | Use the full OData entity reference format, for example `/accounts(guid)` instead of just the GUID. |
| `401 Unauthorized` | Missing or expired access token. | Refresh or obtain a new OAuth 2.0 access token. |
| `403 Forbidden` | Insufficient privileges. | Ensure the user has the **Field Service - Dispatcher** or **Field Service - Administrator** security role. |
| `404 Not Found` | A referenced lookup record doesn't exist. | Verify that the GUIDs for Service Account, Work Order Type, and Price List reference existing records. |

## Related content

- [Work Order (msdyn_workorder) entity reference](developer/reference/entities/msdyn_workorder.md)
- [Create a work order in Field Service](create-work-order.md)
- [Create a table row using the Web API](/power-apps/developer/data-platform/webapi/create-entity-web-api)
- [Use bulk operation messages](/power-apps/developer/data-platform/bulk-operations)
