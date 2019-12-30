---
title: "Resource Preferences | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/16/2019
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

# Resource Preferences

Resource preferences allow dispatchers to give preference to specific resources over others when scheduling with Schedule Assistant or Resource Scheduling Optimization (RSO). 

From a requirement, the dispatcher can add a one or more resource preference records. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-resource-preference.png)


For each resource that is added as a resource preference, you can define a **Preference Type**: 
- **Preferred:** these resources will show at the top of Schedule Assistant results and RSO will prioritize these resource over others but will not guarantee the requirement is scheduled to them.
- **Restricted:** these resources will be excluded from Schedule Assistant results and RSO will not auto schedule this requirement to them.
- **Must choose from:** only these resources will show in Schedule Assistant results and RSO will schedule to one of them. If none of these resources are available, the requirement will not be scheduled.

## Prerequisites

- Resource Scheduling Optimization v3.0.19263.1+ for RSO to consider the "Must choose from" constraint

> [!Note]
>


## Preferred
**Preferred** resources will show at the top of Schedule Assistant results and RSO will prioritize these resource over others but will not guarantee the requirement is scheduled to them.

## Restricted
**Restricted** these resources will be excluded from Schedule Assistant results and RSO will not auto schedule this requirement to them.

> [!Note]
>



## Must choose from
**Must choose from:** only these resources will show in Schedule Assistant results and RSO will schedule to one of them. If none of these resources are available, the requirement will not be scheduled.

## Configuration considerations
## Additional Notes
- what if there is a must choose from but the resource doesnt meet other conditions like skills?