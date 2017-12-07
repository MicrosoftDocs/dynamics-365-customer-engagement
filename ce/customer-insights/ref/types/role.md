---
title: Role Type Definition
description: A role defines a security group that has a set of defined permissions.
keywords: Customer Insights; type; role
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/07/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: c161e908-a254-4370-927d-fe06a81781e2
---

Role Type Definition
====================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A Role defines a AAD-based security group that has a set of defined permissions on Hub resources. Roles can be defined over limited scopes, such as on selected 
[Profiles](./profile.md), [Interactions](./interaction.md), [KPIs](./kpi.md) etc. Customer Insights uses a role-based access security (RBAC) model that has the built-in roles defined in the following table.  

|**Role**|**Permission on the specified scopes**|
| --------------- | ---------- |
|Admin|ALL operations at the tenant endpoint|
|Reader|READ operations at the tenant endpoint|
|MetadataAdmin|ALL operations at the tenant's `/manage` endpoint|
|MetadataReader|READ operations at the tenant's `/manage` endpoint|
|DataAdmin|ALL operations at the tenant's `/data` endpoint|
|DataReader|READ operations at the tenant's `/data` endpoint|
| | | |


## Properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|roleName*|string|Name of the role, built-in types from table above.|
|description|string|Description of the role|
| | | |


## JSON example
```{json}
{ 
    "RoleName":"Admin", 
    "Description":"Primary administrator for Hub1" 
}

```
