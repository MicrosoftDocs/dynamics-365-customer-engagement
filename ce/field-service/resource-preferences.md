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

Resource preferences allow dispatchers to give preference to specific resources over others when scheduling with the Schedule Assistant or Resource Scheduling Optimization (RSO). This is helpful for scenarios where a particular person or list of people are the only people that can perform a work order or job requirement. It is also helpful for scenarios where a person or group of people should *not* be eligible for a work order or job requirement.

From a requirement, the dispatcher can add a one or more resource preferences. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-resource-preference.png)


For each resource that is added as a resource preference, you can define a **Preference Type**:

- **Preferred:** these resources will show at the top of Schedule Assistant results and RSO will prioritize these resource over others but will not guarantee the requirement is scheduled to them.
- **Restricted:** these resources will be excluded from Schedule Assistant results and RSO will not auto schedule this requirement to them.
- **Must choose from:** only these resources will show in Schedule Assistant results and RSO will schedule to one of them. If none of these resources are available, the requirement will not be scheduled.

Because you can add multiple resource preferences to a single requirement, you can note both preferred resources and restricted resources on the same requirement.

To explain resource preferences, let's look at one example for each preference type: preferred, restricted, and must choose from.


## Prerequisites

- Resource Scheduling Optimization v3.0.19263.1+ for RSO to consider the "Must choose from" constraint

## Preferred

**Preferred** resources will show at the top of Schedule Assistant results and RSO will prioritize these resource over others but will not guarantee the requirement is scheduled to them.

First create a work order.

Then go to the resource requirement that is automaticlaly created when a work order is created.

Alongside where you can add skills and resource roles that are required, add a new resource preference record.

Select a resource and choose **Preferred** for **Preference Type**.


In the example below, we created a work order (WO-1000000053) and then added Abraham McCormick as a preferred resource to the related resource requirement.



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-resource-preference-preferred.png)

From the schedule board, select and highlight the requirement and choose **Find Availability** to trigger the schedule assistant. You will notice your preferred resource is shown at the top of the list with a heart icon indicating he or she is preferred.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-resource-preference-preferred-grid.png)

> [!Note]
> The preferred resource will only show if it meets the other fitler criteria such as location, skills, resource types, etc.

## Restricted

**Restricted** these resources will be excluded from Schedule Assistant results and RSO will not auto schedule this requirement to them.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-resource-preference-restricted.png)

> [!Note]
> Expiration date

## Must choose from

**Must choose from:** only these resources will show in Schedule Assistant results and RSO will schedule to one of them. If none of these resources are available, the requirement will not be scheduled.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-resource-preference-must-choose-from.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-resource-preference-must-choose-from-grid.png)

## Configuration considerations

### Using resource preferences with RSO

For RSO to consider resource preferences when automatically scheduling, add the **Meets Resource Preferences** constraint to the related Optimization Goal. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-constraints-meets-resource-preferences.png)

## Additional Notes
- The resource that is added as a preferred resource (including the "Must choose from" preference type) must meet the other conditions of the requirement. As an example, if a requirement calls for "Skill A", and a resource without Skill A is added as a "Preferred" or "Must choose from" resource preference, the resource will not show in results or be autoamtically scheduled.
