---
title: "msdyn_ApplyRoutingRuleEntityRecord Action Reference (Developer Guide for Omnichannel for Customer Service)| MicrosoftDocs"
description: "Reference information about the msdyn_ApplyRoutingRuleEntityRecord Action."
author: "v-sailab"
ms.author: "v-sailab"
manager: "shujoshi"
ms.date: 10/03/2019
ms.topic: "reference"
ms.service: dynamics-365-customerservice
applies_to: 
  - "Dynamics 365 (online)"
---

# msdyn_ApplyRoutingRuleEntityRecord Action Reference

Applies the active routing rule to an entity.

**Owning Solution**: Microsoft.Dynamics.CRM.System

## Parameters

Parameters allow for data to be passed to the action.


| Name | Type | Nullable | Unicode | Description |
|------|------|------|------|------|
| Target | Microsoft.Dynamics.CRM.crmbaseentity | False | True | The entity to apply the routing rule to.|

## Return value

This action has no return value.

## Entities

This action will apply to entities which have Routing Rule set to active.

## Example

The example given below shows how you can create a Web API request to call `msdyn_ApplyRoutingRuleEntityRecord` action for `Incident` entity.

**Request**

```http
POST [Organization URI]/api/data/v9.1/msdyn_ApplyRoutingRuleEntityRecord
Accept: application/json
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0

{
    "Target":"incidents(<incidentid>)"
}
```

**Response**

```http
HTTP 204 No Content
```

### See also

[Developer guide for Omnichannel for Customer Service](../../omnichannel-developer.md)
