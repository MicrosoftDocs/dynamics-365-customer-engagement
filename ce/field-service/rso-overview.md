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

For many organizations, using RSO for automated scheduling is a requirement because scheduling a high volume of jobs manually would take too long. For other organizations, they adopt RSO to aid their schedulers in job matching and to free up some of their time to focus on other tasks. Here are other reasons organizations choose to adopt RSO.

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

## Glossary

- run
- optimize
- resources
- schedules, bookings
- requirements
- jobs

## Scenarios

RSO is very configurable based on your business needs. Here are common scenarios where RSO is used.

**Overnight scheduling** - RSO runs automatically each night and schedules new jobs and re-optimizes existing bookings for the next day.

**Single Resource Optimization** - a dispatcher runs RSO for a single techniciain's schedule for the rest of today to recalculate an optimal travel route after a cancellation. [See more details](single-resource-optimization.md).

**Simulation** - a service manager runs a simulation of RSO to understand how many jobs could be completed with a varying number of resources.

**Intraday scheduling** - RSO runs every 30 minutes to schedule and adjust for changing business needs as new jobs are created and others are cancelled or rescheduled.

**Emergency scheduling** - when an emergency job is created, an RSO run is triggered that schedules the high-priority-emergency job as soon as possible ahead of lower priority jobs.


## System requirements

- Dynamics 365 online
- RSO is an add-on to [Unviersal Resource Scheduling (URS)](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md) and is built on top of its entities. Organizations that use either Dynamics 365 Field Service, Customer Service, and Project Service Automation are entitled to URS. If for example, you wanted to use RSO to automatically schedule Dynamics 365 Sales opportunities to sales reps, you would need either Dynamics 365 Field Service, Customer Service, or Project Service Automation in addition to Sales in order to access URS as a prerequisite. 



## How it works

Resource Scheduling Optimization (RSO) is an enhanced application of the famous traveling salesman problem which asks the following question: "Given a list of cities and the distances between each pair of cities, what is the shortest possible route that visits each city and returns to the origin city?". 
traveling salesman problem and vehicle routing problem

- continuum of manual and semi-automated scheduling
- considerations - skills, territory, priority

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