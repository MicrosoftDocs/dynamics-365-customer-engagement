---
title: "Get started with Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to get started with Dynamics 365 Field Service
ms.date: 11/30/2022
author: jshotts
ms.author: jasonshotts
ms.custom: intro-internal
search.app:
- D365CE
- D365FS
---

# Get started with Dynamics 365 Field Service

This article helps you get started as a new users of Dynamics 365 Field Service. To set up the application, you'll need **System Administrator** or **Field Service - Administrator** privileges.

After [installing Dynamics 365 Field Service](install-field-service.md), [assign licenses to your users](view-user-accounts-security-roles.md). Then, set up frontline workers and start scheduling work orders. Take a look at the **Get Started** page, which contains shortcuts to all relevant tasks.

In the **Learn about Field Service** section, there are cards with videos and links to documentation that introduce some key app functionality.

In the **Get up and running** section, there are a set of actions and tutorial videos that guide you through important Field Service processes.

In the **More resources** section, you find link to helpful resources.

## Get started

The following section walk you through a quick end-to-end scenario that you can achieve right from the **Get started** page.

### Set up your frontline workers

First, you must set up your frontline workers. Frontline workers are individuals who complete work orders.

From the **Getting Started** page, select the **Set Up** option.

Enter the required information. Recommended values are automatically filled in. Don't change these values unless necessary.

You can also email a link to a frontline worker to get the mobile app. For more information, see [Send frontline workers an email with a link to download Dynamics 365 Field Service mobile app](frontline-worker-set-up-email-approval.md).

### Create your accounts

Next, create an account that represents one of your customers.

From the **Getting Started** page, Select **Create**.

In the form, fill out relevant details and save it.

For more information, see [Create and manage accounts in Dynamics 365 Field Service](accounts.md).

### Create your work orders

Create a work order that outlines work that needs to be done for a customer, typically at the customer's location or at the location of an asset or equipment.

From the **Getting Started** page, select **Create**.

In the form, fill out relevant details.

- The **Service Account** represents the customer.
- **Tasks** are a checklist of things that need to be done.
- **Products** are parts needed to complete the work order.
- **Services** represents labor needed to complete the work order.

For more information, see [Create a work order to coordinate and schedule resources and activities](create-work-order.md).

### Schedule your work orders

Schedule the work order and book a frontline worker to complete the job.

On the **Getting Started** page, select **Schedule** to go to the schedule board.

Find your work order in the requirement pane at the bottom. Then, drag and drop if to the frontline worker.

For more information, see [Schedule a work order](schedule-work-order.md).

### Analyze your operations

Finally, you can analyze your operation by enabling and looking at work order summary and resource utilization Power BI reports.

On the **Getting Started** page, select **Configure** in the **Analyze your operations** section to go to the insights setting page.

You'll see reports under **Analytics and Insights**.

For more information, see [Reports overview](reports.md).

## Dive deeper

Before you roll Field Service out to other users in your organization, make sure you familiarize with the following core functionality.

### Configure Field Service settings

Review default settings for the Field Service app.

1. In the **Field Service** app, open the **Settings** area.

1. Go to **General** > **Field Service Settings** > **Work Order / Booking**.

1. Review the all mandatory values and set optional values for your organization. For more information, go to [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md)

### Set up resource scheduling

Field Service needs latitude and longitude values for service account records to estimate travel times when scheduling a work order to a resource.

1. Make sure the environment is connected to the Bing Maps service. For more information, go to [Connect to maps](field-service-maps-address-locations.md#connect-to-maps).

1. Enable **Auto Geo Code Addresses** to let the system help assign coordinates to an address. For more information, go to [Turn on auto geocoding to calculate estimated travel time](turn-on-auto-geocoding.md).

1. Enable map and location settings on work orders and other relevant records. For more information, see [Location and map settings](field-service-maps-address-locations.md).

1. Enable resource scheduling for entities. Go to **Resource Scheduling > Administration > Enable Resource Scheduling for Entities**. Verify that work orders are enabled for resource scheduling. For more information, go to [Enable an entity for scheduling in Dynamics 365 Field Service](schedule-new-entity.md).

### Test geocoding

Geocoding maps a latitude and longitude to an address. Coordinates allow dispatchers to locate work orders more effectively than an address.

1. In the **Field Service** app, open the **Service** area.

1. Go to **Scheduling** > **Work Orders** and select **+New**.

1. In the **Location** tab, begin typing an address to see suggestions.

   :::image type="content" source="media/address-suggestion.png" alt-text="Screenshot of suggested addresses on a work order form.":::

Choose a suggested address and the system fills in the rest of the details in the form, including the latitude and longitude.

### Configure the Field Service (Dynamics 365) mobile app

Frontline workers should download the Field Service (Dynamics 365) mobile app from the iOS or Android app stores onto their phone or tablet. 

- [iOS - Field Service (Dynamics 365) mobile app](https://aka.ms/fsmobile-apple)
- [Android - Field Service (Dynamics 365) mobile app](https://aka.ms/fsmobile-google)

Sign in with the username and password of the frontline worker user.

- For the **Username**, enter the frontline worker's username. For example, username@org.onmicrosoft.com
- For the **Password**, enter the password you set for the frontline worker.

For more information, see the article on [getting started with the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md).

