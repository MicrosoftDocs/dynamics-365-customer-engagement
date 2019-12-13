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

 Manual scheduling

Resource Scheduling Optimization (RSO) automatically schedules jobs to the people, equipment, and facilities best equipped to complete them. This includes automatically scheduling work orders to field technicians, cases to customer service reps, and any other example based on how you are using Dynamics 365 Field Service, Customer Service, and Project Service Automation. 

RSO is one of three ways to schedule with Dynamics 365 Field Service. Whereas the schedule board and the schedule assistant help dispatchers schedule a single job, RSO can schedule many jobs at one time, maximizing overall utilization and minimizing total travel time. Furthermore, RSO considers the requirements of the job and the unique attributes of the resources like if the job requires an experienced manager with specific skills in the same area.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of ](media/8cce1b1462b960eecac5012ad1a2d685.png)
 

### Benefits of using Resource Scheduling Optimization

For many organizations, using RSO for automated scheduling is a requirement because scheduling a high volume of jobs manually would take too long. For other organizations, they adopt RSO to aid their schedulers in job matching and to free up some of their time to focus on other tasks.

- **Automated scheduling**: Automatically scheduling the majority of requirements saves time and empowers dispatchers to focus on exceptions and billing.

- **Achieve scale**: Allows dispatchers to manage more resources, enabling the
business to scale to new territories or lines of business.

- **Customer satisfaction**: Improved efficiency drives more predictable arrival and completion times and seamlessly schedules alternate technicians for urgent situations.

- **Technician efficiencies and reduced cost**:
  -   Fitting more appointments into working hours drives revenue and reduces overtime costs.
  -   Matching work orders and technician skillsets reduces the cost of lost appointments.

- **Reduced travel time means reduced fuel consumption and less vehicle maintenance**:
  -   Ensuring your technicians are taking the shortest possible route with turn-by-turn directions from Bing Maps or your custom mapping provider reduces fuel consumption and wear and tear on vehicles.
  -   If each field technician saves one tank of gas a month, the savings generally will surpass the cost of RSO. 

- **Improved customer retention**: Giving preference to higher-priority work orders helps avoid service level agreement (SLA) penalties and helps you meet customer service commitments. 


- continuum of manual and semi-automated scheduling
- considerations - skills, territory, priority


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
its an add on

## How it works

traveling salesman problem and vehicle routing problem

Ways to run RSO
adds on to URS and optimizes anything
- scopes, goals, schedules
- schedule board
- Azure 
- Bing Maps

you can schedule some jobs one way, and other jobs another

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

[5 stages of scheduling adoption](5-stages-scheduling-adoption.md)