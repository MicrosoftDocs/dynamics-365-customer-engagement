---
title: "Set up bookable resources (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/20/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
author: krbjoran
ms.assetid: 7ed1712e-acd6-433b-bb78-22f8d58c5c61
caps.latest.revision: 14
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Set up bookable resources (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

A bookable resource in Field Service is anything that needs to be scheduled. This most commonly includes people, equipment, and physical spaces (facilities).   

Each resource can have different attributes that distinguish it from each other including but not limited to:

- Characteristics (ex: Accounting)
- Categories (ex: Manager)
- Territories (ex: Seattle)
- Organizational Unit (ex: Manager)
- Location (ex: Location Agnostic)
- Resource Type (ex: User)

In this article let's explore creating a bookable resource and adding details to distinguish it from other resources. In addition, let's explore the most common details for setting up field technician resources for Field Service organizations.

## Create a bookable resource  
  
1.  From the Field Service main menu, click **Resources** > **Resources entity**. 

2.  On the **Active Bookable Resources** screen, click **New**.  


> [!div class="mx-imgBorder"]
> ![Screenshot navigating to Resources](media/resource-create-new-navigation.png)

> [!div class="mx-imgBorder"]
> ![Screenshot showing where to find the Active Bookable Resources grid](media/qs-1-img28.png)

    
3.  Select a **Resource Type**  
  
  Resource type is a classification of who or what the resource is and how the resource relates to your organization. 

   - **User**: Choose this option if the resource is a person and a member of your organization. This resource type must be chosen if the resource is a field technician who needs access to the Field Service Mobile app.
   - **Account** or **Contact**: Choose this option if the resource is not directly a part of your organization, but needs to be scheduled. A common example is subcontractors. In addition, this allows the scheduling framework to more easily apply to an organization's existing Dynamics system that may be using Accounts and Contacts to manage workers, partners, contractors before Field Service is purchased and implemented. 
  - **Equipment**: Choose this option if the resource is an equipment, tool, or machine that must be scheduled.
  - **Crew**: Choose this option as the first step to create a crew to assemble a group of resources where scheduling the crew resource will schedule all crew members. A typical example is two or more people or a person and a vehicle. The general process is to create a crew header resource with the resource type of crew and then add other resources of resource type user, account, or equipment as resource children to the crew header. For more information see the topic on [resource crews](resource-crews.md).
  - **Facility**: Choose this option if the resource is a physical space that needs to be scheduled such as a building or room. For more information see the topic on [facility scheduling](facility-scheduling.md).
  - **Pool**: Choose this option as the first step to create a pool to assemble a group of similar resources to manage capacity. Among other differences, a pool differs from a crew in that scheduling a pool does not schedule all pool members. For more information see the topic on [resource pools](resource-pools.md).   
  
     
  
  After selecting a resource type, a lookup field will appear to choose a related record when applicable. As an example, if User is selected, you will then need to select the related User record.


4.  **Name** Enter a name, this can be different from the name of the related user, account, or contact record. The name entered here will appear on the schedule board.
5.  **Time Zone** Select the time zone the resource is located in. This is considered in the schedule process.  

6. **Start/End Location** Decide where the resource starts and ends his or her working day for scheduling and routing purposes.
   1. **Location agnostic** - select this option if the location of this resource is not required for the business need and does not need to be considered during the scheduling process. If the work location of a requirement is set to On site, location agnostic resources will not return in results. 
   2. **Resource Address** - select this option if the resource starts and ends his or her day at a unique location. The exact location is derived from the latitude and longitude values on the related user, account, or contact records depending on the resource type. It is important to [connect to maps and turn on geo coding](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-1-resource-scheduling) in your environment for this purpose. 
   3. **Organizational Unit** - select this option if the resource starts and ends the day at an organizational unit, typically representing a company location. The exact location is derived from the latitude and longitude values on the selected organizational unit for which there is a lookup field on the bookable resource form. If the resource is of type facility, the organizational unit acts as the location of the facility.
7. **Organizational Unit** Select the organizational unit the resource belongs to. This can represent a team the resource belongs to, an office the resource reports to, and the location where the resource starts and ends his or her day. 
8. **Display On Schedule Board** Determines if the resource is eligible to be added to the schedule board. If set to **yes**, then the resource can be added to the schedule board based on the filters or manually selected.
9. **Enable for Availability Search** Determines if the resource is eligible to be returned in schedule assistant results given the resource attributes meet the filter criteria of the requirement.
10. **Hourly Rate** Enter the internal hourly cost of the resource. This is the hourly pay that the resource should be paid by the company. It is utilized by schedule journals to calculate pay for time worked.
11. **Warehouse**  Select the default warehouse the resource will get his or her parts from. For Field Service scenarios, this is the default warehouse inventory is deducted from when a field technician uses an inventory work order product.
12. **Time Off Approval Required** Choose if time off needs to be approved or not. If set to **No** then a time off request record will block time on the schedule board and show as nonworking hours for that resource. If set to **yes**, the same result will occur once the time off request is approved. 
13. **Enable Drip Scheduling** Controls how many bookings can appear on the Field Service Mobile app at one time. Set to **No** to allow all bookings for a resource to display  based on mobile settings (view and sync filters). Set to **Yes** to display a new field titled **Bookings to Drip** where you can enter the total number of bookings displayed at one time. As a resource completes bookings (sets booking status to completed) more bookings will be appear on in the bookings tab of the Field Service Mobile app.
14. **Enabled for Field Service Mobile** Set to **Yes** if the resource will need to use the Field Service Mobile app on his or her phone or tablet. 

**Save** the record.  
  
## Add work hours  

After saving the bookable resource, set the working hours of the resource. Working hours are considered by the schedule board by displaying working and nonworking hours as different colors, by the schedule assistant by only displaying resources that are working in the results, and by resource scheduling optimization that automatically books requirements to resources that are working. 
  
1.  To set working hours
    - In the web interface (Field Service v7.x or earlier), select the arrow next to the resource name, and choose **Work Hours**.
    - In the unified client interface (Field Service v8.x or later), select **Show Working Hours** at the top of the form. 
  
2.  Click the **Set-Up** drop-down list and choose one of the following:  
  
    - **New Weekly Schedule**: Set an ongoing weekly schedule for the resource.  
  
    - **Work Schedule for One Day**: Set the hours the resource can be scheduled for on a particular day.  
  
    - **Time Off**: Set the dates and times the resources can't work. 

Alternatively, double click a day to set the working hours. 

> [!Note]
> Whether setting the working hours for a day or longer, ensure the Time Zone reflects the time zone the resource is located in and that was entered on the resource form.


> [!div class="mx-imgBorder"]
> ![Screenshot of setting working horus and timezone](media/resource-working-hours-timezone.png)
 
## Setting up field technician resources for field service organizations 

At its simplest, a field technician is a mobile worker employed at your organization who utilizes the Field Service Mobile app on his or her phone or tablet to view Field Service entities such as work orders.

A bookable resource that represents a field technician for field service scenarios must have:
1. **Resource Type** = **User**
2. **Enabled for Field Service Mobile** = **Yes**

> [!div class="mx-imgBorder"]
> ![Screenshot showing where to find the fields on the Bookable Resource form](media/qs-1-img29.png)

Other fields important for field technicians in field service scenarios are:

**Start/End Location** because where the resource starts and ends his or her day is factored into schedule work order requirements to the closest field technician.
**Display On Schedule Board** because displaying a field technician resource on the schedule board is crucial for enabling dispatchers to manage their schedules.
**Enable for Availability Search** because the schedule assistant is a dispatchers best tool to schedule field technicians to work orders. 
**Warehouse**  because this connects a field technician to a warehouse (typically the truck) to consume inventory on work orders. 

In Field Service v8.2+ latitude and longitude fields exist on the bookable resource entity and are populated with the latest location coordinates from the Field Service Mobile app, though the fields may need to be added to the bookable resource form. See the topic on [enabling location tracking](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/geofencing#step-3-enable-location-auditing-for-the-field-service-mobile-app) for more details. 


## Add characteristics, territories, and categories 

The most common attributes to distinguish resources are characteristics, territories, and roles.


### Add characteristics 

Characteristics represent skills and certifications that a resource possesses. An example can be very concrete such as a CPR certification, more general such as accounting or web development experience, or as simple as security clearance for a specific building or fluency in the Spanish language.

A resource can have multiple characteristics. Once the characteristic record is created, you can add it to a resource. Learn more on the [setting up characteristics page](../field-service/set-up-characteristics.md).
  
1. From the resource record, navigate to related entities and choose **Resource Characteristics**.  
  
2. Click **Add New Bookable Resource Characteristics**.  
  
3. Select a **Characteristic** from the lookup.
4. Select a **Rating Value** that represents the resource's proficiency in that skill. This can be a simple 1 to 10 rating or even represent the score on a certification exam. 
   1. Rating value can be left blank. 
   2. You can customize or create new rating values by going to Proficiency Models.
   3. When dispatchers are searching for resource's to fulfill requirements, the dispatcher can choose which rating value is required for particular skills.
5. **Save & Close**. 

  
### Add categories 

Resource categories serve as roles and titles to distinguish resources. Common examples include service manager, junior field technician, senior field technician, and territory manager. You can add categories to resources via the Resource Category Association entity.  

A resource can have multiple categories. Once the category record is created, you can add it to a resource. Learn more on the [setting up resource categories page](../field-service/set-up-bookable-resource-categories.md).

1. From the resource record, navigate to related entities and choose **Resource Category Assns**  
  
2. Click **Add New Resource Category Assns**. 
  
3. Select a **Category** from the lookup then **Save & Close**.  


### Add territories 

Territories represent geographic regions the resource conducts work in. Common examples include a city, county, specific zip codes, state or a general region. A resource can be part of multiple territories, but requirements can only exist in a single territory. 

Once the territory record is created, you can add it to a resource. Learn more on the [setting up territories](../field-service/set-up-territories.md).

1. From the resource record, navigate to related entities and choose **Resource Territories**.  
  
2. Click **Add New Resource Territory**. 
  
3. Select a **Territory** from the lookup then **Save & Close**.   

## Resource Scheduling Optimization

If Resource Scheduling Optimization (RSO) is enabled in your organization, a new tab will appear on the bookable resource form. To allow RSO to automaitcally schedule requirements to the resource, go to the new tab and set **Optimize Schedule** to **Yes**.

Setting to Yes does not mean requirements will automatically be scheduled to this bookable resource, instead it means that after RSO is set up and with the appropriate scope to include this bookable resource, then it would be eligible for automatic schedules.

## Additional notes

- Only one resource record can be associated to a user record, however multiple resources can be associated to a single account or contact record. 
- the start and end location is used during break time as well
- hidden lat and long fields
- drip scheduling is currently unavailable for field service mobile 11.0+


### See also   
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set up bookable resource categories](../field-service/set-up-bookable-resource-categories.md)   
 [Set up characteristics](../field-service/set-up-characteristics.md)   
 [Set up resource pay types](../field-service/set-up-resource-pay-types.md)<br>
 [User's Guide](../field-service/user-guide.md) 
