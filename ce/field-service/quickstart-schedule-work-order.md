---
title: "Quickstart: Set up users to create, schedule, and view work orders - Dynamics 365 Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/11/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Quickstart: Set up users to create, schedule, and view work orders

This quickstart shows how to set up new users, create and schedule work orders as a dispatcher via the Field Service web app, and then view scheduled work orders on the mobile app.

Steps:

1. Set up users  

2. Assign appropriate security roles to your users

3. Create a bookable resource

4. Create a work order 

5. Add the bookable resource to the schedule board

6. Schedule the work order to the bookable resource

7. View the scheduled work order on the mobile app



## Prerequisites

You need a Dynamics 365 organization with the Field Service application installed. See the topic on [installing Field Service](install-field-service.md). 

You also need a phone or tablet for viewing a scheduled work order.

It is encouraged to [perform initial configurations](perform-initial-configurations-setup.md) in your environment after installing Field Service.

### Verify the Field Service application is installed

Sign in as a system administrator and verify that the Field Service application is listed in the main menu. See the following screenshot for reference. If you don't see Field Service, ensure you are signed in as a system administrator. If you still do not see the app, go to the topic on [installing Field Service](install-field-service.md). 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-apps.png)

## 1. Set up users 

Once you have a Dynamics 365 environment with Field Service, you need to create users to use the application. Many different roles interact with Field Service like system administrators, technicians, dispatchers, service managers, inventory managers, customer service representatives and more.

For the purpose of this quickstart, we will create 2 users:

1. back office administrator and dispatcher
2. technician

Sign into [https://admin.microsoft.com/](https://admin.microsoft.com/) as a system administrator.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-o365-admin.png)

Go to Users and create at least two users. One to represent a back office administrator and dispatcher, and another to represent a field technician. 

Assign each user a license or trial license that includes Dynamics 365 Field Service.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-o365-admin-users.png)

Go to the Power Apps admin center [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/).



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-o365-admin-powerapp.png)

Select your environment that has Field Service installed > select Settings > Users + permissions > Users.

Add the two users you created that have Field Service licenses or trial licenses to the environment.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-ppac-users-add.png)

 ## 2. Assign appropriate security roles to your users 

 Next we need to assign each user the correct Field Service security role.

Select **Manage users in Dynamics 365**.

> [!NOTE]
> Ensure you are viewing the "Enabled Users" view.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-ppac-users.png)

Select the user that represents the back office administrator and dispatcher then select **Manage Roles** in the top ribbon and assign the **Field Service - Administrator** and **Field Service - Dispatcher** security roles.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-roles-admin.png)

Then select the user that represents the technician user and assign the user the **Field Service - Resource** security role.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-roles-resource.png)

Next we need to assign Field Security profiles. 

Log into your Dynamics 365 environment. In the top right select **Advanced settings**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-advanced-settings.png)

Go to **Settings** > **Security** > **Users**.

Select **Field Security Profiles**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-field-secuirty-profile.png)


Select the  **Field Service – Resource** field security profile and add the technician user.

Note that field technicians can't edit fields on mobile work orders unless they have this profile assigned. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-field-secuirty-profile-resource.png)

Then select the **Field Service - Administrator** field security profile and add the administrator user.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-field-secuirty-profile-admin.png)


## 3. Create a bookable resource

Next, create a bookable resource record for the technician user. Creating a bookable resource lets you schedule work orders for the technician, which the tecnician sees in the mobile app.

Go to **Field Service** > **Resources** > **Resources** > **+New**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quiickstart-new-bookable-resource.png)

Create a new technician resource  with the following settings: 

  - Resource Type = **User**
  - User = **\[User record that represents your technician user\]**
  - Display on Schedule Board = **Yes**
  - Enable for Availability Search = **Yes**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-new-bookable-resource-complete.png)

See the topic on [setting up bookable resources](set-up-bookable-resources.md) for more details.

## 4. Create a work order 

Go to **Field Service** > **Service** > **Work Orders** > **+New**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-work-order-new.png)

At a minimum, enter information in the following required fields.

- For **Service Account**, select an account from the list or create a new one.
- For **Work Order Type**, select a work order type from the list or create a new one. 
- For **System Status**, select **Open-Unscheduled**.
- For **Price List**, select a price list from list or create new one. 
- Set **Taxable** to **No**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-work-order-new2.png)

On the **Address** tab, enter a valid address. Then choose **Save and close**.

Consider adding incident types, products, services, and service tasks to add more details and instructions to your work orders. See the topic on [configuring incident types](configure-incident-types.md) for more details.



## 5. Add the bookable resource to the schedule board

Next, add the bookable resource to the schedule board.

Go to **Field Service** > **Schedule Board**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-schedule-board-1.png)

In the **Filter and Map View** panel, select **Options** > **Select Resources**.


Find the new technician bookable resource with the **Resource Type** set to **User**, and then move the user to selected resources. Choose **Apply**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-schedule-board-2.png)

## 6. Schedule the work order to the bookable resource

In the lower pane, find the work order to schedule. This work order is listed in the **Unscheduled Work Orders** view. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-schedule-board-3.png)

To schedule the work order, drag it to the technician's timeslot.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-schedule-board-4.png)

> [!NOTE]
> Ensure you do not schedule the work order in the past. There is a blue vertical line that represents the current time. You may need to adjust the time zone of the schedule board by selecting the gear icon in the top right of the schedule board.

## 7. View the scheduled work order on the mobile app

Download the Field Service (Dynamics 365) mobile app from the iOS or Android app stores. See the topic on [installing the mobile app](mobile-power-app-get-started.md) for more details.

Sign in with the username and password for the technician user.


- For the **Username**, enter the username of the technician user. For example, username@org.onmicrosoft.com
- For the **Password**, enter the password you set for the technician.

Select your app in the list.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-mobile-signin.png)

If you do not see your app, but instead see "Contact your administrator for access to your organization's mobile apps" then select the menu icon and toggle the **Show non-production apps** to _Yes_.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-error-contact-administrator-show-nonproduction-apps.png)

In the **Booking** tab, see the work order you scheduled to your technician bookable resource. You must be signed in with the user the bookable resource was created for in step 3.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-mobile-work-order.png)


## Additional notes

### Set up geo-coding for the organization

Setting up geocoding for an organization enables the system to attach latitudes and longitudes to addresses. 

Go to your Dynamics 365 environment's app page: "https://your-environment-name.crm.dynamics.com/apps"


> [!div class="mx-imgBorder"]
> ![Screenshot showing settings for scheduling parameters](media/quickstart-apps-rs.png) 

Go to **Resource Scheduling app** > **Administration** > **Scheduling Parameters**.

> [!div class="mx-imgBorder"]
> ![Screenshot showing settings for scheduling parameters](media/qs-1-img22.png)  

Set **Connect to Maps** to **Yes**. The API key fills in automatically to use the Bing Maps API, which enables the system to assign a latitude and longitude to the user record's address.

> [!div class="mx-imgBorder"]
> ![Screenshot showing the Bing maps API field](media/qs-1-img23.png)  

