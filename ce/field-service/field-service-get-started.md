---
title: Get started
description: Learn how to get started with Dynamics 365 Field Service.
ms.date: 10/24/2024
author: jshotts
ms.author: jasonshotts
ms.topic: overview
ms.custom: bap-template
---

# Get started

This article guides you through the first steps with the application and the scenario of creating and scheduling a work order to resolve a customer's service request.

:::image type="content" source="media/get-started-page.png" alt-text="Screenshot of the Get Started page in Dynamics 365 Field Service with a highlight on the navigation item.":::

> [!TIP]
> You can add users and create the following records quickly from the **Get started** page in the **Service** area of Field Service.

## Install Dynamics 365 Field Service

A system administrator needs to install the Field Service application for your organization. For more information, see [How to install Dynamics 365 Field Service](install-field-service.md).

## Configure Field Service settings

Review default settings for the Field Service app.

1. In the **Field Service** app, open **Settings**.

1. Go to **General** > **Field Service Settings** > **Work Order / Booking**.

1. Review the mandatory values and set optional values for your organization. For more information, go to [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md).

## Set up resource scheduling

Field Service needs latitude and longitude values for service account records to estimate travel times when scheduling a work order to a resource.

1. Make sure the environment is [connected to the Bing Maps service](field-service-maps-address-locations.md#connect-to-maps).

1. [Enable **Auto Geo Code Addresses**](turn-on-auto-geocoding.md) to let the system help assign coordinates to an address.

1. [Enable map and location settings](field-service-maps-address-locations.md) on work orders and other relevant records.

1. [Enable resource scheduling for entities](schedule-new-entity.md).

   Administrators decide which entities can be scheduled to resources. A solution called [Universal Resource Scheduling](universal-resource-scheduling-for-field-service.md) adds scheduling capabilities to entities and provides the schedule board. Any entity (including custom entities) can be enabled for scheduling; typical examples include cases, opportunities, and orders.

## Assign Field Service licenses to users

Create users or select existing users and assign them a license for Field Service. Users with a license can access the Field Service application, according to their user role. For more information, go to [Set up Dynamics 365 Field Service users and security profiles](users-licenses-permissions.md).

Set up at least a dispatcher and a frontline worker. Dispatchers manage work orders for your organization. They schedule the work and assign it to a frontline worker, who completes the work for the customer.

## Create customer accounts

Every customer of your company usually has its own account record. It lists their location, contact information, billing information, and numerous related details. Field Service represents individuals working for your customer as contacts. You can create relationships between contacts and accounts to ensure you get in touch with the right person.

[Create an account](accounts.md) that represents one of your customers.

## Configure the work order summary

Define the fields that Copilot uses to generate a summary of a work order. Learn more: [Configure the work order summary](work-order-recap.md#configure-the-summary).

## Create a work order

[Work orders contain all the information for a service request](create-work-order.md) that originates from a customer. It outlines the work to be done, typically at the customer's location or at the location of an asset or equipment. To quickly create a work order, go to the Get Started page and select **Create** in the work order section and enter relevant details.

- The [**Service Account**](accounts.md) represents the customer who the work order relates to.
- **Tasks** are a checklist of things that need to be done.
- **Products** are parts that the technician needs for the job.
- **Services** represents required labor to complete the work order.

## Schedule a work order

Schedule the work order to a frontline worker to complete the work.

There are [several ways to schedule a work order](universal-resource-scheduling-for-field-service.md). For manual scheduling, open the **Schedule Board** in the **Scheduling** section of the **Service** area.

Find your work order in the requirement pane. Drag it to a free time slot in the future for one of your frontline workers.

## View the scheduled work order on the Field Service mobile app

Frontline workers use the mobile experience on their phone or tablet.

[Download and install the mobile app](mobile/set-up-field-service-mobile.md) and sign in as the technician to whom the work order is assigned.

The **Booking** tab shows the work order you scheduled to the frontline worker. Update the status of the booking and related details to indicate completion of the work order.

## Analyze your operations

In the Field Service web application, service managers can [analyze day-to-day operations with Power BI reports](reports.md).

Reports appear under **Analytics and Insights**.
