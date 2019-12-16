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

RSO is a more advanced form of scheduling as you'll see in the [5 stages of scheduling adoption](5-stages-scheduling-adoption.md) for field service organizations. Whereas the schedule board and the schedule assistant help dispatchers schedule a single job, RSO can schedule many jobs at one time, maximizing overall utilization and minimizing total travel time. Furthermore, RSO considers the requirements of the job and the unique attributes of the resources like if the job requires an experienced manager with specific skills in the same area.

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

## Scenarios

RSO is very configurable based on your business needs. Here are common scenarios where RSO is used.

you can schedule some jobs one way, and other jobs another

**Overnight scheduling** - RSO runs automatically each night and schedules new jobs and re-optimizes existing bookings for the next day.

**Single Resource Optimization** - a dispatcher runs RSO for a single techniciain's schedule for the rest of today to recalculate an optimal travel route after a cancellation. [See more details](single-resource-optimization.md).

**Simulation** - a service manager runs a simulation of RSO to understand how many jobs could be completed with a varying number of resources.

**Intraday scheduling** - RSO runs every 30 minutes to schedule and adjust for changing business needs as new jobs are created and others are cancelled or rescheduled.

**Emergency scheduling** - when an emergency job is created, an RSO run is triggered that schedules the high-priority-emergency job as soon as possible ahead of lower priority jobs.


## System requirements

- Dynamics 365 online
- RSO is an add-on to [Unviersal Resource Scheduling (URS)](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md) and is built on top of its entities. Organizations that use either Dynamics 365 Field Service, Customer Service, and Project Service Automation are entitled to URS. If for example, you wanted to use RSO to automatically schedule Dynamics 365 Sales opportunities to sales reps, you would need either Dynamics 365 Field Service, Customer Service, or Project Service Automation in addition to Sales in order to access URS as a prerequisite. 

## Glossary

- **Jobs** - generic term referring to work that needs to be completed like work orders, cases, and projects; however there is no "jobs" entity in Field Service or Resource Scheduling Optimization. 
- **Resources** - anyone or anything that needs to be scheduled to a job including people, equipment, and facilities.
- **Schedules, bookings** - schedules adn bookings are used interchangibly and refer to the appointment time slot when a resource is assigned to a job.
- **Requirements** - the entity related

- **Run** - When RSO performs its scheduling and optimization functions, we call this a run. It consists of a send and receive to Azure and an update to schedules as seen on the Schedule Board.
- **Optimize** - Rather than just automatically scheduling jobs, we say that RSO optimizes jobs meaning that it attempts to find the best schedules to reduce travel time and maximize utilization as two examples.
- **Scope** - this is jobs and resources RSO will consider. As an example, you may not have RSO schedule every job in the system to every resource. You will most likley partition the jobs and resources into a scope.  
- **Goal** - this defines what the aim of an RSO run will be. What is most important for your company: minimizing travel time, maximizing utilization, handling high priority jobs, scheduling jobs as soon as possible? These are all goals that you will need to rank because sometimes there are trade-offs.


## How it works

Resource Scheduling Optimization (RSO) is an enhanced application of the famous "traveling salesman problem" which asks the following question: "Given a list of cities and the distances between each pair of cities, what is the shortest possible route that visits each city and returns to the origin city?". It's a mathematical problem and the solution is a large part of the RSO computation. Nevertheless, RSO goes beyond finding the shortest routes because it also considers things like skills, territory, roles, priority, resource preferences, promised time windows, and more. 

Here's how it works.

1. First you create a list of jobs that need to be completed. These are generally work orders for onsite service, cases for remote service, and project tasks. 

2. For each job, you list what kind of resource is needed and when it needs to be completed. As an example, for a work order you may need someone nearby with repair skills and the work order needs to be completed by the end of this week. Much of this information is automatically populated based on the job details. 

3. Next you pick a list of resources that are elegible to be considered for your list of jobs, and each resource has different attributes like where they are located, what role he or she has, what type of resource they are (employee, contractor, facility, equipment), and what skills they have. 

4. After that you Run RSO. RSO can be run manually by pushing a button, based on a predefined schedule or timetable, or triggered by a workflow. Also, RSO can run differently depending on what its scheduling. It can run differently for US jobs compared to Canadian jobs or differently for work orders compared to cases.

5. When RSO runs, the job requirements and the list of resources are sent to Azure and RSO computes an optimal schedule that is displayed on the schedule board.

6. After RSO runs, dispatchers can use the interactive schedule board and schedule assistant to makes changes as needed.

## Optimized schedules

RSO _optimizes_ schedules in addition to automatically scheduling them. After running RSO, it's important to understand the optimized results. Lets look at a few examples.

In the image below is an optimized schedule board. In the left pane you'll see a map view of the optimized bookings. One way you can see RSO working effectively is the travel routes are clustered around each resource's starting location and each color represent a different technician's route. When dispatchers manaully schedule jobs without using RSO, the travel routes are often spread across the map zig-zagging in different directions.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of ](media/rso-optimized-schedule-board-routes-with-annotation.png)

Also, in the image above you can see some bookings are scheduled back-to-back with no travel time in between. This means RSO scheduled a job and understood there was another job at the same location for the same customer and decided to schedule them together. This is a simple type of optimization that is harder for dispatchers to do manually, especially across many jobs.

Every time RSO runs, it keeps track of the total travel time compared to working time in a graph as seen in the image below. This helps you uderstand how RSO will reduce the total travel time across all of your field technicians compared to manual or semi-automated scheduling (schedule assistant).

> [!div class="mx-imgBorder"]
  > ![Screenshot of ](media/rso-working-vs-travel-time.png)

## Get started
[Get RSO](rso-get-install.md)

[Deploy RSO](rso-deployment.md)

[RSO Quickstart guide](rso-quickstart.md)

![Video symbol](../field-service/media/video-icon.png "Video symbol") [RSO Quickstart video](https://youtu.be/oJ-3HTJWRMo)

## See also

![Video symbol](../field-service/media/video-icon.png "Video symbol") [RSO overview and scenarios](https://youtu.be/fcQwIXgmnqk)

[5 stages of scheduling adoption](5-stages-scheduling-adoption.md)