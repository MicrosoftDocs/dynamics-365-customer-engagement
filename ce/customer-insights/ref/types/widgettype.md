---
title: WidgetType Type Definition
description: A widget represents the UI object used to display aggregated, calculated, or entity-specific information. 
keywords: Customer Insights; type; widget
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/07/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: b70dc549-0585-48f2-bdf6-61b530872e2c
---

WidgetType Type Definition
==========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A widget represents the UI object used to display aggregated, calculated, or entity-specific (e.g. about a [Profile](./profile.md)) information. 

## WidgetType properties

Property names appended with asterisks* are required.

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|widgetTypeName*|string|Name of the widget type (readonly)|
|definition*|string|Definition of the widget type| 
|displayName|Map<string,string>|Localized display names for the widget type|
|description|string|Description for the wiget|
|tenantId|string|Hub Identifier (readonly)|
|imageUrl|string|Image URL for widget type|
|created|DateTime|Time when widget type was created (readonly)|
|changed|DateTime|Time when widget type was last modified (readonly)|
|widgetVersion|string|Version of widget type|
| | | | 

## JSON example
```{json}
{ 
    "widgetTypeName": "ActivityGauge",
    "tenantId": "sdktesthub",
    "displayName": {
        "en": "Activity Gauge UX"
    },
    "definition": "<widgettype definition>",
    "imageUrl": "",
    "widgetVersion": "2016-01-01"
}
```

