---
title: "Predictive work duration | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Predictive work duration

> [!Note]
> This feature is available as a public preview

## Prerequisites
- Field Service v8.x.x
- Go to Settings then under Analytics and insights section select Settings
Enable Predictive Work Duration preview

Enter a number in the **minimum number of resources per territory** field to define how big a territory must be in roder to be used in the report. This is important for provacy considerations because if 



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Bookings and requirements

### Filters (slicers)

Duration	Slicer control to list pre-defined durations to filter data in all visuals. It has 4 values:
1. Last 3 months
2. Last 6 months
3. Last 1 year
4. Last 2 years
Incident type	Slicer control to list incident types.
Territory	Slicer control to list resource territories. It filters resources and related metrics.
Skill	Slicer control to list resource skill and proficiency level. It filters resources and related metrics.


## Territory duration analysis

### Filters (slicers)

Duration	Slicer control to list pre-defined durations to filter data in all visuals. It has 4 values:
1. Last 3 months
2. Last 6 months
3. Last 1 year
4. Last 2 years
Incident type	Slicer control to list incident types.
Territory	Slicer control to list service territories.
Skill	Slicer control to list resource skill and proficiency level. It filters resources and related metrics.


## Configuration considerations
## Additional Notes