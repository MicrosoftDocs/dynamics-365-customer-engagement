---
title: Overview of Field Service for Dynamics 365
description: An English-language guide to managing resources with Field Sercice for Dynamics 365.
author: NeilWOrint
manager: ShellyHa
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-fieldservice
ms.date: 9/28/2018
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

# Overview Dynamics 365 for Field Service 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

The Dynamics 365 for Field Service business application helps you deliver onsite support at customer locations. With the Field Service application, you get the tools you need to manage work orders, scheduling, your mobile workforce, and more. 

Here are some examples of the types of organizations that use the application to manage their field service:

- **Manufacturing**  A medical device manufacturer sells machines to hospitals and clinics, and uses the application to manage maintenance services over the lifetime of the machines.
- **Utilities** A fiber optic cable utility company uses the appliation to respond to outages by dispatching technicians to problem areas.
- **Health care** An  in-home healthcare service service provider uses the application to schedule and dispatch healthcare workers to administer medicine and other care to multiple patients.
- **Equipment repair** A facilities manager uses the application to deliver maintenance and repair services for heating and cooling equipment.

## Field Service trends

Field Service anticipates and solves the most common onsite scenarios. 

According to [Gartner](https://www.gartner.com/doc/reprints?id=1-3KXDGG5&ct=161028&st=sb"), in 2020, two out of three large field service organizations will equip field technicians with a mobile application that drives profitability by creating revenue streams, efficiency and customer satisfaction.

Gartner also says that through 2020, 80% of organizations with more than 75 field technicians will miss more than 20% of the planned efficiency gains due to incomplete integration or deployment.

The [Aberdeen Group](http://www.aberdeen.com/about) said: “65% of incoming service requests require a field visit or dispatch. Nearly 26% of these dispatches require secondary or additional follow-up visits, thereby making the effective management of field resources and the overall field service organization extremely vital in the pursuit of service excellence.”

## The parts of Field Service

Field service capabilities extend Dynamics 365 to provide a complete management solution for mobile workers and onsite service. 

Here’s what it can do for you:

**Work orders** define service work to be performed primarily but not exclusively at your customers’ locations.

**Schedule and dispatch** tools help manage resources used for service including people and equipment, visualize onsite appointments, and optimize service schedules with efficient routing, resource skill matching, and reduced travel time.

**Communication and notifications** enhance collaboration between customer service, dispatch, field technicians, customers, and other stakeholders.

**An easy-to-use mobile application** guides resources through schedule changes and service work.

**Asset management** keeps track of customer equipment and service history.

**Preventative maintenance** automatically generates recurring maintenance for specific equipment at customers’ locations.

**Inventory,** **purchasing** **& returns** capabilities manage truck stock, purchase order requests and fulfillment, and product returns.

**Billing** capabilities generate invoices based on products and services delivered to customers.

**Time keeping** functionality understands how resources are spending their time traveling, on break, working, etc.

**Analytics** report data flowing from work orders, scheduling activities, and customer interactions.


## Typical roles

**Customer service representatives** identify incoming requests and qualifies them as work orders requiring onsite visits. This role primarily uses the application via the web browser.

**Dispatchers** review and prepare work orders for scheduling, and assigns them to the most appropriate resources with scheduling tools such as the schedule board (manually), resource availability search (semi-automated), and resource scheduling optimization (fully automated). This role primarily uses the application via the web browser.

**Field technicians** receive assigned work orders on the mobile application and travel to customer locations to perform maintenance and repairs. This role primarily uses the application via a mobile phone/tablet on iOS, Android, or Windows devices.

**Inventory managers** ensure field technicians have inventory to perform service calls, manage product returns and purchase new inventory. This role primarily uses the application via the web browser.

**Service managers** track metrics regarding customer satisfaction and resource utilization and look for ways to promote standardization and efficiency. This role primarily uses the application via the web browser.

## Using Field Service

1. **Work Orders** - Work Orders describe in detail work that must be performed at the customer's location and are created from emails, phone calls, service agreements, web portals, Internet of Things (IoT) telemetry, cases, sales orders, and more.
2. **Scheduling** - A digital interactive schedule board helps dispatchers assign Work Orders to the most appropriate resources based on location, availability, skill set, priority, and more.
3. **Mobile App** - An easy to use mobile application on iOS, Windows, and Android devices guides field technicians through schedule changes and step-by-step work.
4. **Assets & Inventory** - Equipment service history and inventory levels are updated as technicians complete and submit Work Orders. 

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

