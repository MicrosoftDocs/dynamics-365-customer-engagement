---
title: Overview of Dynamics 365 Field Service
description: Learn about Dynamics 365 Field Service and its features.
ms.date: 12/18/2024
ms.topic: overview
ms.custom: bap-template
author: jshotts
ms.author: jasonshotts
---

# Overview of Dynamics 365 Field Service

The Dynamics 365 Field Service business application helps organizations deliver onsite service to customer locations. The application combines workflow automation, scheduling algorithms, and mobility to set up mobile workers for success when they're onsite with customers fixing issues. With Copilot in Field Service, users can access the latest AI models in various areas of the application. These AI-based features are rapidly evolving and help users be more productive.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=b7cbb5e1-9ecc-45c1-9e90-10563f1a4d8f]

The Field Service application enables you to:

- Improve first-time fix rate
- Complete more service calls per technician per week
- Manage follow-up work and take advantage of upsell and cross sell opportunities
- Reduce travel time, mileage, and vehicle wear and tear
- Organize and track resolution of customer issues
- Communicate an accurate arrival time to customers
- Provide accurate account and equipment history to the field technician
- Keep customers updated with the status of their service call and the resolution
- Schedule onsite visits when it's convenient for the customer
- Avoid equipment downtime through preventative maintenance

Examples of organizations that use the application to manage their field service scenarios:

- **Manufacturing** -  A medical device manufacturer sells machines to hospitals and clinics, and uses the application to manage maintenance services over the lifetime of the machines.
- **Utilities** -  A fiber optic cable utility company uses the application to respond to outages by dispatching technicians to problem areas.
- **Health care**  - An  in-home health care service provider uses the application to schedule and dispatch healthcare workers to administer medicine and other care to multiple patients.
- **Equipment maintenance** -  A facilities manager uses the application to deliver maintenance and repair services for heating and cooling equipment.

## Key capabilities

Field service capabilities include:

- **Work orders** to define the service work needed primarily (but not exclusively) at customer locations.
- **Scheduling and dispatch tools** to manage resources and equipment needed for customer service, visualize onsite appointments, and optimize service schedules with efficient routing and resource skill matching.
- **Communication tools** to enhance collaboration between customer service agents, dispatchers, field technicians, customers, and other stakeholders.
- **An easy-to-use mobile application** that guides technicians through schedule changes and service work.
- **Copilot in Field Service** features are integrated in the application. Copilot generates summaries of work orders in a customizable format and answers natural language questions about your data in a side pane of the web app.
- **Asset management** capabilities to keep track of customer equipment and service history.
- **Preventive maintenance** by automatically generating recurring maintenance appointments for equipment.
- **Inventory, purchasing, and returns capabilities** to manage truck stock, purchase order requests and fulfillment, and product returns.
- **Billing capabilities** to generate invoices based on products and services delivered to customers.
- **Time tracking** to help you track how resources are spending their time, whether they're traveling, on break, or working.
- **Analytics for reporting** on key performance indicators for managing work orders, scheduling activities, and interacting with customers.

## Field Service roles

The Field Service application provides tools for these key roles on your service team:

- **Customer service agents** triage incoming requests and determine when to create work orders for onsite visits. Agents primarily use the application through a web browser.
- **Service managers** track performance metrics and oversee service delivery, finding ways to increase efficiency and standardize processes. Service managers primarily use the application through a web browser.
- **Dispatchers** review and schedule work orders, and assign them to resources on the schedule board through resource availability searches, and through the fully automated Resource Scheduling Optimization Add-in for Dynamics 365 Field Service. Dispatchers primarily use the application through a web browser.
- **Field technicians** manage their assigned work orders using the mobile app on a phone or tablet, and perform maintenance and repairs onsite at customer locations.
- **Inventory managers** ensure field technicians have what they need to complete their service calls. Inventory managers also handle product returns and purchase new inventory. Inventory managers primarily use the application through a web browser.

## Using the Field Service application

Work orders describe the work that a technician needs to perform at a customer location. In the Field Service application, a typical work order lifecycle looks like this:

1. Work orders generate from service cases, sales orders, emails, phone calls, service agreements, web portals, or Internet of Things (IoT) data and then display in Field Service. Work orders are typically grouped by geographical territory and lines of business. Work order details consist of a checklist of tasks, parts to use, labor to bill to the customer, and skills required. Copilot in Field Service can generate a customizable summary the detailed work order.

   Most work orders also include a location based on the related customer account and/or equipment that needs attention; this location routes the field technician from job to job. Finally, incoming work orders that are marked as ready for assignment are passed along to a dispatcher for scheduling.

   :::image type="content" source="media/work-order-process-1.png" alt-text="Screenshot of Work Orders in Field Service." lightbox="media/work-order-process-1.png":::

1. An interactive schedule board helps dispatchers assign work orders to the best resources based on location, availability, skill set, priority, and more. This is done via a manual drag-and-drop method, a semi-automated scheduling assistant, or fully automated with Resource Scheduling Optimization.

    The schedule board displays each resource--whether an employee, contractor, or equipment--and their scheduled work orders. Resources and their assigned jobs are also displayed on a map along with routes and traffic patterns in real time. The schedule board is extensible and can be used to schedule anything within Dynamics 365, including work orders, sales orders, projects, and custom entities. Additionally, Microsoft 365 integration allows for emailing and skype calling to available resources.

   :::image type="content" source="media/work-order-process-2.png" alt-text="Screenshot of the Schedule Board in Field Service." lightbox="media/work-order-process-2.png":::

1. An easy-to-use mobile app for iOS, Android, and Windows devices guides field technicians through the process of resolving assigned work orders. Copilot supports technicians with quick summaries of each work order and supports them by updating work orders to save time on the job. For each work order, the field technician can view important information such as location, step-by-step instructions, customer assets, and service history. They can use their device to take pictures and videos or record a digital customer signature. Field technicians can also automatically download important information to their devices for offline work when internet isn't available.

    After the technician completes the work, they mark the work order as complete or as requiring a follow-up; the dispatcher can then see this change on the schedule board.

1. As technicians submit completed work orders, equipment service history and inventory levels update automatically. Service managers can manage and track inventory needed, and track movement of parts from order to inventory to onsite installation.

    For example, if an equipment part is installed at a customer's location during an installation or repair, the system documents a reduction in inventory from the related warehouse or truck and document the part as a new customer asset along with installation/repair details. Closing a work order generates an invoice for any used parts or labor.

   :::image type="content" source="media/work-order-process-4.png" alt-text="Screenshot of a completed work order in Field Service." lightbox="media/work-order-process-4.png":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]
