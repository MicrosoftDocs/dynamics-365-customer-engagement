---
title: "Setting up a proof of concept for Resource Scheduling Optimization | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/19/2019
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
ms.author: daclar
ms.reviewer: krbjoran
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Setting up a proof of concept for Resource Scheduling Optimization

Setting up a proof of concept (POC) for Resource Scheduling Optimization (RSO) should follow some basic guidance, and include the following stages: 

1. **Discovery**, where you learn about customer needs and expectations


2. **Initial configuration of RSO**, and knowing which entities are critical for a successful POC


3. **Running simulations of data,** which shows the POC in action


4. **Presenting results of the POC**, which can help your customer understand how working with RSO can benefit their organizations

## Discovery

A collaborative RSO proof of concept should engage a client to actively work with the optimizer rather than simply comparing features on paper. Setting up a useful discovery phase for your RSO proof of concept means understanding your client's needs, defining success criteria, and making sure they have the right expectations going in. 

### Defining the customer's participation 

First, you'll want to make sure that the customer has the right level of expectations around their participation in this proof of concept process. This is very much a collaborative effot, and your customer must actively participate in order to find value in the outcomes. 

### Understanding your client's needs 

No two organizations run the exact same way, so understanding how your clients use data is critical to running a successful POC. This means you want to work with real data for this run. Make sure to understand *how* they are using their data and for what business reasons.

The data that your client may provide, such as work orders or cases, will result in a requirement record when imported. This means that entities other than just work orders can be configured as schedulable entities during this POC run. For example, if training or time off is important for the client, create a custom entity and import that type of record along with the typical transactional data like a work order. 

Here are a few questions to ask clients that will help tailor the RSO POC: 

- How many resources are they working with? 
- What types of resources are there? (people, equipment, facilities, and so on)
- How frequently are resources scheduled? 
- Where do resources start and end their days? 
- How many territories do resources work within?
- What types of skills or characteristics are important for resources? 
- What tools are currently in use for scheduling and optimization?
- How do they manage emergencies / exceptions with resourcing? 
- How are resource priorities defined and managed?

Any other questions that help determine how the customer is currently managing or optimizing their resources will help for a successful discovery.

### Defining success criteria

To know if the POC works well for the customer, you first need to determine what measurable success looks like. While it's tempting to declare that "improved travel times" or "decreased overtime" are successes, they aren't specific or measurable enough. Work with the customer to define *measurable* success criteria, such as *reduce travel time by 10 %* or *schedule no overtime for maintenance work*. 

Be sure that what the cusomter is asking for is something we can actually measure. For example, reducing the number of trips to a customer’s site is not easily measured, as each requirement will create a related booking when scheduled. RSO will often schedule work at the same location back-to-back, as long as other criteria like the scheduling window allow for it; to report this as a single trip to the customer site, however, is very difficult with multiple booking records. Typically work booked at the same location back-to-back with another work order will have zero travel time or zero miles, so think of ways to present these as success criteria to your customer or prospect. 

Also, understand the data in terms of dates and timeframes. It’s common to receive a data set from prior periods where the expectation is the customer can compare the RSO results to what really happened. This is difficult because RSO cannot schedule in the rears. If you simply add days to the dates provided, remember that a week day in September may be a weekend date in December. If you are maximizing work hours and there are no resources working weekends, this requirement will not be scheduled. Be sure to discuss this up front with the POC stakeholders and define a plan to work around this. 

You should also consider how you might manage SLAs or response times. It's not uncommon to receive SLA terms as text. RSO can't act upon text so you should have a plan to convert the various terms and conditions to dates. These can be retained as Time From Promised and Time To Promised fields on the work order, or by setting the start date and end dates on a requirement. You'll often see examples such as “next day before 12:00 PM” or even something like "within 4 hours or within 8 hours." Work out a plan on how you'll address these types of scenarios. 

Whatever you choose, be sure the result is a date window that can be acted upon by RSO. RSO will only consider these requirements within that date window. If not scheduled, these requirements will not be considered in future RSO runs targeting dates outside that time frame. Have a plan to address those requirements with small scheduling windows, or have a process to push the scheduling window forward as you do subsequent RSO runs. 



## Initial configuration of the POC

So we've set expectations, defined goals, and understand what success looks like. Now, we need the actual data to get the POC up and running. Once gathered, that data can then be imported into Dynamics 365. 

Typical types of data include: 

- Accounts
- Addresses
- Territories
- Bookable Resources
- Resource territories
- Skills and characteristics
- Start and end locations
- Work hours
- Priorities
- Work orders (and other transactional data)

### Accounts

Account information is helpful when dealing with work orders, since **Service Account** is a required field. The account information can typically be derived from the work order data if an address or longitude and latitude are provided. A generic naming convention can be used for privacy reasons (see GDPR requirements). We frequently see customers who provide data with names removed, and only include an account number so that they can refer to actuals from existing systems.

### Addresses

Addresses should be geocoded on import. To make sure this happens, go to **Resource Scheduling Optimization** > **Resource Scheduling Parameters**. Make sure that **Connect to Maps** is set to yes and that there is a valid **Map API Key*.* 

> [!div class="mx-imgBorder"]
> ![Screenshot of the connect to maps and map api key settings](./media/rso-poc-address1.png) 

On that same screen, go to the **Resource Scheduling Optimization** tab, and set **Enable Resource Scheduling Optimization** to **Yes**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the enable resource scheduling setting set to yes](./media/rso-poc-address2.png) 

Addresses will then be automatically geocoded. If you're working with a small amount of address data, you can geocode them manually as well.

If you don't wish to rely on geocoding, you can also import longitude and latitude directly to the account by adding those values in the imported Excel doc. However, manually added latitude and longitude are typically less accurate than the geocoded results.

> [!div class="mx-imgBorder"]
> ![Screenshot of the latitude and longitude fields on an account](./media/rso-poc-address4.png) 

Territories can then be assigned to the account, and will default to the work orders as imported.

> [!div class="mx-imgBorder"]
> ![Screenshot of the territories on an account record](./media/rso-poc-address5.png) 


### Territories

RSO needs at least 1 territory in order to operate.  However, having multiple territories allows for additional demo flexibility and makes it so optimization schedules can be more precisely defined. This also means that multiple schedules can run simultaneously. If no territories are provided, use state or some other criteria to create artificial territories so that you can filter RSO schedules to smaller subsets of data. 

Note that if no territories are provided, you may need to define your own schema. See more on using territories under the defining schedules section of this topic.

### Bookable resources 

Include a subset of actual resource data for the purposes of this POC. Working with real data makes it easier to drill into specific use cases and also limits the related data required for resources, such as work hours, resource territories, or skills and characteristics. Resources must be related to a user, account, or contact. The easiest way to make sure this happens is to relate resources to contacts - this ensures that they are separate from the accounts you're scheduling. Of course, if the resources are also users, then relating them to a user record is also acceptable.

> [!Note]
> If you do relate resource data to user data, note that location data for start and end locations are mainatined in the user record, which can only be edited by an administrator.

Be sure to set the proper time zone on the resource. This will inform the required work hours. If multiple time zones are needed for the POC, be sure that you have schedule board views set up with the proper time zone filters, or you may misread the outputs. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the bookable resource record with time zone highlighted](./media/rso-poc-resource1.png) 

Resources can start or end their day from an **Organization Unit** if it has been setup with a latitude and longitude. This represents starting or ending from an office or warehouse; however, this is fixed for a user and not adjustable for different days of the week.

> [!div class="mx-imgBorder"]
> ![Screenshot of the bookable resource record with organizational unit highlighted](./media/rso-poc-resource2.png) 

On the bookable resource record, go to the **Resource Scheduling Optimization** tab and set the **Optimize Schedule** to **Yes**. This can be done on import, or manually afterwards.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Optimize Schedule setting set to yes on the resource record](./media/rso-poc-resource3.png) 

### Resource Territories 
Resource territory records must be created for each resource so that RSO will include the resources in any optimization run. RSO will be more efficient if you can use multiple territories to filter the data to smaller subsets. You can run multiple RSO schedules at the same time for separate data sets and territory is a great way to do that. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a highlighted resource territory field on a resource record](./media/rso-poc-territory1.png) 

### Skills & Characteristics 
While not required for a POC, skills and characteristics can be used as additional filter criteria, as well as in the goals and objectives setups. You can set constraints to **Meet Required Characteristics**, which will add additional dimensions to RSO results. However, we recommend keeping a POC to a manageable number of skills and characteristics.

> [!div class="mx-imgBorder"]
> ![Screenshot of a characterstic record with type set to skill](./media/rso-poc-skillscharacteristics.png) 


### Start and end locations

Start and end locations are maintained on the resource record. The latitudes and longitudes used by RSO, however, are maintained in whatever record the resource is related to, such as user, account, or contact. Additionally, if using **Organizational Unit**, the latitude and longitude must also be added.

### Work hours 

Work hours are required for RSO to consider a resource for scheduling. We recommend grouping your resources so you can set work hours for one person, and then using the work hour template feature and set calendar for a given group. Time zone is derived from the resource record and while you can change it on the work hours record, be aware this can cause conflicts. It's best to set on the resource record and allow it to default to the work hours.

You can set work hours for the specific day of the week by checking off the days that the resource will not be working. You can also select **Vary by day** or set work hours.

> [!div class="mx-imgBorder"]
> ![Screenshot of a weekly schedule window with work hour fields highlighted](./media/rso-poc-workhours1.png) 
 
If you select the **Vary by day** setting, work hours for the first day will replicate for the remaining days. Make sure to review, make the proper adjustments, and save. If you return to set work hours again, the settings will default to the original. 
 
> [!div class="mx-imgBorder"]
> ![Screenshot of a weekly schedule window with vary by day set to yes](./media/rso-poc-workhours2.png) 

When setting up work hours, you may also set a fixed break time, which RSO will honor during optimizations.  Set the duration for the break, and include a start and end time to represent the scheduling window RSO should use to fit the break into the optimized schedule.

> [Note!]
> If you require floating breaks or breaks based on other business logic, you'll need to build a custom scheduleable entity for breaks.

> [!div class="mx-imgBorder"]
> ![Screenshot of a Set Work Hours and Service Restrictions window with the break fields highlighted](./media/rso-poc-workhours3.png) 
 
Also, be sure to flag the related resource requirement to **Optimize** in the **Scheduling Method** field.

> [!div class="mx-imgBorder"]
> ![Screenshot of a resource requirement record with the scheduling method set to optimize](./media/rso-poc-workhours4.png) 


### Priorities

Priorities provide additional dimensions to an RSO run. Using high priority requirements as a constraint will provide control over those more urgent requirements. If the data provided doesn’t include levels of priority, you should develop a simple prioritization logic. For example, perhaps requirements where the scheduling window is small are a higher priority than those with wider scheduling windows. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a priority record with the level of importance set to 10](./media/rso-poc-priorities1.png) 

You can define priority codes as high, medium, or low and then set a ranking value (1-10). RSO uses this numerical range to address priorities while optimizing. We recommended that you assign color coding to priorities, which will then be reflected on the schedule board as a colorful corner on the scheduled work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of a work order on the schedule board, with a bright yellow corner to signify priority](./media/rso-poc-priorities2.png) 

Using or excluding priority as a constraint will produce different optimized schedules. You should review both to see which best meets the success criteria.

### Work orders (and other transactional data)
This data represents the work you are trying to schedule, typically in the form of work orders, which we will use for the purposes of this topic. 

Field service POCs are typically set up to receive a bulk load of data that represent a block of maintenance jobs. For example, this might look like a full month of maintenance work and service calls broken down by the day or hour. The service calls are typically more urgent and can require re-optimization of the maintenance jobs in order to take advantage of where a resource will be when he addresses those calls. This may require a separate optimization schedule with different scope, goals, and objectives, and is also typically a different time frame, such as a few days or a week. The key to this schedule is to keep it to a smaller time frame as more service calls are expected - it's much quicker to optimize a smaller, focused data set. We'll look at defining these optimization schedules in the next section.



### Time off

Since RSO's goal is to optimize resource scheduling, you should be ready to accommodate time off. You can create time off entries to make a resource unavailable for a specific period of time, but RSO will treat this like time outside of work hours and will schedule according to the **Schedule within Work Hours** and **Scheduling Windows** constraints.

If your requirements for time off are more complex, you can create a custom time off entity as a schedulable entity and flag the related requirement to optimize. This would allow you to create more robust time off entries which can then be handled more like work orders with time from and time to promise scheduling windows, priorities, and so on.

You can see the related time off entries by going to the **Resource Record** > **Related Items**.

> [!div class="mx-imgBorder"]
> ![Screenshot of new time off request record.](./media/rso-poc-timeoff.png) 

## Running simulations
### Simulating a period of time
### Scheduling initial data
### Receiving disruptors
### Defining Views and Schedules
### Defining goals with specific constraints and objectives
#### Constraints
#### Objectives
#### Simulations
#### Schedule Board Optimization, selected resources

## Presenting results
### Reporting on the success criteria
### Reviewing Routes and Booking details
