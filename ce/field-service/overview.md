---
title: Overview of Field Service for Dynamics 365
description: An English-language guide to managing resources with Field Sercice for Dynamics 365.
author: shellyha
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/10/2018
ms.topic: article
ms.prod: 
ms.technology: 
 - "field-service"
ms.author: daclar
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Overview of Dynamics 365 for Field Service 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

The Dynamics 365 for Field Service business application helps you deliver onsite support at customer locations. The Field Service application provides the tools you need to manage work orders, scheduling, your mobile workforce, and more. 

Here are some examples of the types of organizations that use the application to manage their field service:

- **Manufacturing** -  A medical device manufacturer sells machines to hospitals and clinics, and uses the application to manage maintenance services over the lifetime of the machines.
- **Utilities** -  A fiber optic cable utility company uses the appliation to respond to outages by dispatching technicians to problem areas.
- **Health care**  - An  in-home health care service service provider uses the application to schedule and dispatch healthcare workers to administer medicine and other care to multiple patients.
- **Equipment maintenance** -  A facilities manager uses the application to deliver maintenance and repair services for heating and cooling equipment.

## What's included in Field Service

Field service capabilities include: 

**Work orders** define service work to be performed primarily (but not exclusively) at customer locations.

**Scheduling and dispatch** tools to manage resources and equipment needed for customer service, visualize onsite appointments, and optimize service schedules with efficient routing, resource skill matching, and reduced travel time.

**Communication and notifications** to enhance collaboration between customer service agents, dispatchers, field technicians, customers, and other stakeholders.

**An easy-to-use mobile application** that guides technicians through schedule changes and service work.

**Asset management** capabilities for keeping track of customer equipment and service history.

**Preventive maintenance** by automatically generating recurring maintenance appointments for equipment.

**Inventory, purchasing, and returns** capabilities to manage truck stock, purchase order requests and fulfillment, and product returns.

**Billing** capabilities to generate invoices based on products and services delivered to customers.

**Time tracking** to help you track how resources are spending their time, whether they're traveling, on break, or working.

**Analytics** for reporting on key indicators for manageing work orders, scheduling activities, and interacting with customers.

## Field service roles

The Field Service application provides tools for these key roles on your service team:

**Customer service agents** triage incoming requests and determine when to create work orders for onsite visits. Agents primarily use the application through a web browser.

**Service managers** track performance metrics and oversee service delivery, finding ways to increase efficiency and standardize processes. Service managers primarily use the application through a web browser.

**Dispatchers** review and schedule work orders, and assign them to resources on the schedule board, through resource availability search, and through a fully automated resource scheduling optimization add-in. Dispatchers primarily use the application through a web browser.

**Field technicians** manage their assigned work orders using the mobile app on a phone or tablet, and perform maintenance and repairs onsite at customer locations.

**Inventory managers** ensure field technicians have what they need to complete their service calls. Inventory managers also handle product returns and purchase new inventory. Inventory managers primarily use the application through a web browser.

## Work order management
Work orders describe in detail the work that a technician is to perform at a customer location. Work orders are created from service cases, sales orders, emails, phone calls, service agreements, web portals, Internet of Things (IoT) telemetry,  and more.

An interactive schedule board helps dispatchers assign work orders to the best resources based on location, availability, skill set, priority, and more.

An easy-to-use mobile app guides field technicians through the process of resolving work orders.

As technicians submit completed work orders, equipment service history and inventory levels are updated automatically.

 > ![work-order-process](media/work-order-process-4-images-work-schedule-mobile-inventory.png) 

## Benefits for service delivery organizations

- Improved first time fix rate.
- More service calls per technician per week.
- Better management of follow up work and realization of upsell and cross sell opportunities.
- Reduced travel time, mileage and vehicle wear and tear.
- Organized tracking of customer issues and resolutions.

## Benefits for customers

- An accurate arrival time is communicated to the customer.
- The customer interacts with a field technician that looks professional, is organized, and can speak to account and equipment history.
- The customer is updated with the status of the job and the eventual resolution.
- Onsite visits are scheduled at times convenient for the customer.
- Preventative maintenance avoids equipment downtime.

## How Microsoft's Field Service is unique

Unlike other field service software providers, Microsoft Dynamics 365 for Field Service sits on top of a comprehensive business application platform. This has many advantages. First, it allows Field Service to sit in context of other business applications such as sales automation, customer service, project management, etc. This makes cross-department/cross-team collaboration easier and helps achieve better analytics of operations and data.

Second, the Dynamics platform has advanced workflow tools that allow for sophisticated automation within Field Service and between Field Service and other solutions. Field service solutions that sit outside of a platform tend to have limited automation capabilities which means more manual work will be needed. 

Finally, perhaps the greatest strength of a field service solution on a world class business application platform, is a vibrant partner ecosystem and app store. This means thousands of developers and consultants extend and augment the Microsoft Field Service solution by submitting add-ons that can be downloaded from the [Dynamics app store](https://appsource.microsoft.com/en-us/marketplace/apps?product=dynamics-365%3Bdynamics-365-for-field-services&page=1).

Beyond field service on the Dynamics platform, another advantage is how Dynamics 365 for Field Service interacts with other Microsoft products and platforms. In terms of Azure, this means Field Service data can be fed into Azure Machine learning to make better use of data. A simple example being recommending solutions to field technicians based on previous work or Azure cognitive services detecting issues in pictures submitted by customers. 

In terms of Office 365, this means field service workers can use Skype, Teams, Outlook, and Excel seamlessly in context with field service work.

## Scenarios supported by Field Service

Field Service can support any scenario where resources need to be managed to satisfy customers’ work requirements. With Field Service, an organization can:

- Maintain customer billing accounts and service accounts
- Automatically build and manage customer scopes of work with many potential variations:
- Work to be done by a single resource, within a given day.
- Work to be done by a group of resources (human or equipment) over one or more days.
- Define parameters to ensure that some work can only be done by certain resources (characteristics) and can define resources who should not be considered to do the work (excluded resources).
- Define work that must be performed at a specified geographic location, at a service depot, or work that can be done remotely, regardless of location.
- Define a required set of skills, characteristics, and efficiencies that a resource must possess to be qualified to perform the work.
- Drive creation of an estimated duration to complete tasks and work.
- Include estimated parts and labor line items, as well as a list of expected tasks to complete.
- Define a set of resources (human or non-human) with specific working hours, skills; and starting and ending location.
- Schedule resources based on defined work orders, matching on availability, territory, location, distance, skills etc.
- Manage and track inventory required for work orders and the movement of parts from order to inventory to installation at a site.
- Enable field resources to interact with key data in real-time using the Field Service mobile application with offline capabilities across any form factor or operating system.

## Business processes not supported by Field Service

Field Service doesn’t support the following types of business processes:
- Logistics management (for example scheduling freight delivery).
- Multi-day projects with multiple resources and task dependencies (these scenarios are supported by Dynamics 365 for Project Service Automation).

## Watch a video
In this video, see how the digital interactive schedule board and other tools help a service team resolve a customer service issue.

 <a name="heroArea"></a> [![Video showing how to manage your mobile workforce Dynamics 365 for Field Service](../field-service/media/field-service-manage-mobile-workforce.png "Manage your mobile workforce Dynamics 365 for Field Service")](http://go.microsoft.com/fwlink/p/?LinkId=786689)

