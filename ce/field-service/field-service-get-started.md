---
title: Get started
description: Learn how to get started with Dynamics 365 Field Service.
ms.date: 03/14/2023
author: jshotts
ms.author: jasonshotts
ms.custom: get-started
search.app:
- D365CE
- D365FS
---

# Get started

This article helps organizations to get started. It guides you through the first steps with the application and the scenario of creating and scheduling a work order to resolve a customer's service request.

:::image type="content" source="media/get-started-page.png" alt-text="Screenshot of the Get Started page in Dynamics 365 Field Service with a highlight on the navigation item.":::

> [!TIP]
> You can add users and create the following records quickly from the **Get started** page in the **Service** area of Field Service.

## Install Dynamics 365 Field Service

A system administrator needs to install the Field Service application installed for your organization. For more information, see [How to install Dynamics 365 Field Service](install-field-service.md).

## Configure Field Service settings

Review default settings for the Field Service app.

1. In the **Field Service** app, open the **Settings** area.

1. Go to **General** > **Field Service Settings** > **Work Order / Booking**.

1. Review the all mandatory values and set optional values for your organization. For more information, go to [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md)

## Set up resource scheduling

Field Service needs latitude and longitude values for service account records to estimate travel times when scheduling a work order to a resource.

1. Make sure the environment is connected to the Bing Maps service. For more information, go to [Connect to maps](field-service-maps-address-locations.md#connect-to-maps).

1. Enable **Auto Geo Code Addresses** to let the system help assign coordinates to an address. For more information, go to [Turn on auto geocoding to calculate estimated travel time](turn-on-auto-geocoding.md).

1. Enable map and location settings on work orders and other relevant records. For more information, see [Location and map settings](field-service-maps-address-locations.md).

1. Enable resource scheduling for entities. Go to **Resource Scheduling > Administration > Enable Resource Scheduling for Entities**. Verify that work orders are enabled for resource scheduling. For more information, go to [Enable an entity for scheduling in Dynamics 365 Field Service](schedule-new-entity.md).

   Administrators decide which entities can be scheduled to resources. A solution called [Universal Resource Scheduling](universal-resource-scheduling-for-field-service.md) adds scheduling capabilities to entities and provides the schedule board. Any entity (including custom entities) can be enabled for scheduling; typical examples include cases, opportunities, and orders.

## Assign Field Service licenses to users

Create users or select existing users and assign them a license for Field Service. Users with a license can access the Field Service application, according to their user role. For more information, see [Set up Dynamics 365 Field Service users and security profiles](view-user-accounts-security-roles.md).

Set up at least a dispatcher and a frontline worker. Dispatchers manage work orders for your organization. They schedule the work and assign it to a frontline worker, who will then complete the work for the customer.

## Create customer accounts

Every customer of your company usually has its own account record. It lists their location, contact information, billing information, and numerous related details. Field Service represents individuals working for your customer as contacts. You can create relationships between contacts and accounts to ensure you get in touch with the right person.

[Create an account](accounts.md) that represents one of your customers.

## Create a work order

[Work orders contain all the information for a service request](create-work-order.md) that originates from a customer. It outlines the work to be done, typically at the customer's location or at the location of an asset or equipment. To quickly create a work order, go to the Get Started page and select **Create** in the work order section and enter relevant details.

- The [**Service Account**](accounts.md) represents the customer who the work order relates to.
- **Tasks** are a checklist of things that need to be done.
- **Products** are parts that the technician needs for the job.
- **Services** represents required labor to complete the work order.

## Schedule a work order

Schedule the work order to a frontline worker who will complete the work.

There are [several ways to schedule a work order](universal-resource-scheduling-for-field-service.md). For manual scheduling, open the **Schedule Board** in the **Scheduling** section of the **Service** area.

Find your work order in the requirement pane. Drag it to a free time slot in the future for one of your frontline workers.

## View the scheduled work order on the Field Service (Dynamics 365) mobile app

Frontline workers use the Field Service (Dynamics 365) mobile app on their phone or tablet.

Download and install the mobile app and sign in as the technician to who the work order is assigned.

The **Booking** tab shows the work order you scheduled to the frontline worker. Update the status of the booking and related details to indicate completion of the work order.

For more information, see [Install and set up the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md).

## Analyze your operations

Back in the Field Service web application, service managers can [analyze day-to-day operations with Power BI reports](reports.md).

You'll see reports under **Analytics and Insights**.
