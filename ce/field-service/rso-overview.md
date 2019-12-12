---
title: Resource Scheduling Optimization (RSO)
author: shellyhaverkamp
manager: shellyha
ms.date: 12/12/2019
ms.topic: article
ms.custom: 
  - dyn365-fieldservice
ms.service: dynamics-365-customerservice
ms.author: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Overview of the Resource Scheduling Optimization (RSO) solution

Resource Scheduling Optimization (RSO) is an add-on capability for the Dynamics 365 Field Service application that enables you to automatically schedule work orders for the most appropriate resources, by optimizing bookings for the shortest travel time, available work hours, and many other constraints.

RSO is one of three ways to schedule with Dynamics 365 Field Service:

1.  **Manual scheduling**: Drag and drop work order requirements from the bottom panel to the resource’s calendar above.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of ](media/29a8d922fb088fa1d668c598f6887e65.png)

2.  **Scheduling Assistant**: This allows you to filter resources on the left panel by travel range, skills, dates, roles, territories, and more. The system recommends available resources on the right and displays estimated travel times.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of ](media/131ed6d21d96cbc0ccc5a730dcbe1bd0.png)

3.  **Resource Scheduling Optimization**: This add-on evaluates routes and automatically schedules bookable records to minimize travel time and maximize working hours and more, based on your configured objectives, such as “minimize travel time” and “maximize working hours.”

    > [!div class="mx-imgBorder"]
    > ![Screenshot of ](media/8cce1b1462b960eecac5012ad1a2d685.png)

 
- **Automated scheduling**: Automatically scheduling the majority of
requirements saves time and empowers dispatchers to focus on exceptions and
billing.

- **Achieve scale**: Allows dispatchers to manage more resources, enabling the
business to scale.

- **Customer satisfaction**: Improved efficiency drives more predictable
arrival and completion times and seamlessly schedules alternate technicians
for urgent situations.

- **Technician efficiencies and reduced cost**:
  -   Fitting more appointments into working hours drives revenue and reduces
    overtime costs.
  -   Matching work orders and technician skillsets reduces the cost of lost
    appointments.

- **Reduced travel time means reduced fuel consumption and less vehicle maintenance**:
  -   Ensuring your technicians are taking the shortest possible route with
    turn-by-turn directions from Bing Maps or your custom mapping provider
    reduces fuel consumption and wear and tear on vehicles.
  -   If each field technician saves one tank of gas a month, the savings
    generally will surpass the cost of RSO. 

- **Improved customer retention**: Giving preference to higher-priority work orders helps avoid service level agreement (SLA) penalties and helps you meet customer service commitments.


- continuum of manual and semi-automated scheduling
- considerations - skills, territory, priority

Why You need it
- 5 resources and 1 job
- 5 resources and 2 jobs
- 1 resource 4 jobs
- 1 resource 5 jobs
- 5 resources 10 jobs

## Scenarios

overnight
simulation
single resource 
emergency (workflow)
intra-day
cases, projects, custom entities

## System requirements

online
built on URS which is inlcuded with FS, PSA, and CS
uses things like requirements, the schedule board

## How it works

Ways to run RSO
adds on to URS and optimizes anything
- scopes, goals, schedules
- schedule board
- Azure 
- Bing Maps

## Optimized schedules

- same location back to back
- reduce overall travel time
- traveling time vs working time


## Next steps
[Get RSO](rso-get-install.md)

[Deploy RSO](rso-deployment.md)

## See also

[RSO Quickstart](rso-quickstart.md)

![Video symbol](../field-service/media/video-icon.png "Video symbol") [RSO Quickstart](https://youtu.be/oJ-3HTJWRMo)

[Configure RSO](rso-configuration.md)