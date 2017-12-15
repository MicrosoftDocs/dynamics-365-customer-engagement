---
title: View Type Definition
description: 
keywords: Customer Insights; type; View
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/07/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: f9fb52af-efbc-448a-8375-39b7583e12a7
---

View Type Definition
====================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

An Application View represents a visual representation of specific profile or a subset of a profile in the context of a business process.  Each view is comprised of a set of 
[Widge Types](./widgettype.md) (charts and controls) arranged in a specific layout. These are often customized for a target role or audience; for example, a bank can 
create customer-specific views for tellers in their front-offices, and aggregated views for managers or analysts in the back-office.

A view can be scoped to a tenant or for a specific user. The role-based access control for the [Profiles](./profile.md) and [Interactions](./interaction.md) in Customer 
Insights ensures that only the desired audience has access to a view with the information and insights required for their business success.


## View properties

Property names appended with asterisks* are required.

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|viewName*|string|Name of the view (ID) (readonly)|
|userId|string|User identifier|
|tenantId|string|Hub identifier (readonly)|
|displayName|Map <string, string>|Localized display name for the view|
|definition*|string|Definition for the view|
|created|DateTime|Time when view type was created (readonly)|
|changed|DateTime|Time when view type was last modified (readonly)|
| | | |


## JSON example
```{json}
{ 
    "viewName": "testView117",
    "tenantId": "sdktesthub",
    "userId": "*",
    "definition": "{\\\"isProfileType\\\":false,\\\"profileTypes\\\":[],\\\"widgets\\\":[],\\\"style\\\":[]}",
    "displayName": {
        "en": "View 117 Preview"
    },
    created: '2017-03-30T21:46:24'
}
```
