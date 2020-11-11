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

This quickstart shows how a dispatcher creates and schedules a work order that a field technician then views on the mobile app.

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

### Make sure the Field Service application is installed

Sign in as a system administrator and verify that the Field Service application is listed in the main menu. See the following screenshot for reference. If you don't see Field Service, ensure you are signed in as a system administrator. If you still do not see the app, go to the topic on [installing Field Service](install-field-service.md). 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-apps.png)

## 1. Set up users 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-o365-admin.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-o365-admin-users.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-o365-admin-powerapp.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-ppac-users-add.png)

 ## 2. Assign appropriate security roles to your users 

- Navigate to **Settings** > **Security** > **Users**.

- Select a user, and then choose **Manage Roles**.



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-ppac-users.png)

- Assign the user the **Field Service – Administrator** role to give the user scheduling, dispatching, and configuration capabilities. If this user is only acting as a dispatcher, then assign the **Field Service—Dispatcher** role.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-roles-admin.png)

2. Select a user other than the dispatcher/administrator, and then assign **only** the **Field Service – Resource** security role. If you don't have a user to assign this role, create a new one in the [Admin center](https://login.microsoftonline.com). 

> [!NOTE]
> The user needs a Dynamics 365 Field Service license. After you create the user, verify that you can sign in with the new user record. You may be prompted to set a temporary password.

> [!div class="mx-imgBorder"]
> ![Screenshot showing the Field Service - Resource role on the Manage Roles dialog](media/qs-1-img10.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-roles-resource.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-advanced-settings.png)

1. Navigate to **Settings** > **Security** > **Users**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-field-secuirty-profile.png)


4. Select **Field Security Profiles**.

> [!div class="mx-imgBorder"]
> ![Screenshot showing where to find Field Security Profiles on the menu](media/qs-1-img12.png)

5. Assign the **Field Service – Resource** field security profile to the field technician user. Note that field technicians can't edit fields on mobile work orders unless they have this profile assigned. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-field-secuirty-profile-resource.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-field-secuirty-profile-admin.png)


## 3. Create a bookable resource

Next, create a bookable resource record for the field technician user. Creating a bookable resource lets you schedule work orders for the field technician, which the field tecnician sees in the mobile app.

1. Navigate to **Field Service** > **Administration** > **Resources**.



2. Choose **New**.

- Create a new field technician resource  with the following settings: 

    - Resource Type = **User**
    - User = **\[User record you assigned Resource role to\]**
    - Warehouse = **\[assign a warehouse or create a new one. Ex: Truck 1\]**
    - Hourly Rate = **$60**
    - Start Location = **Resource Address**
    - End Location = **Resource Address**
    - Display on Schedule Board = **Yes**
    - Enable for Availability Search = **Yes**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quiickstart-new-bookable-resource.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-new-bookable-resource-complete.png)

See the topic on [setting up bookable resources](set-up-bookable-resources.md) for more details.

## 4. Create a work order 

Navigate to **Field Service** > **Work Orders**.

Choose **New**.

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

Next, you add the field technician to the schedule board.

1. Navigate to **Field Service** > **Schedule Board**.



2. In the **Filter and Map View** panel, select **Options** > **Select Resources**.



3. Find the new field technician with the **Resource Type** set to **User**, and then move the user to selected resources. Choose **Apply**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-schedule-board-1.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-schedule-board-2.png)

## 6. Schedule the work order to the bookable resource

In the lower pane, find the work order to schedule. This work order is listed in the **Open Requirements** view, and the **Unscheduled Work Orders** view. To schedule the work order, drag it to the field technician.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-schedule-board-3.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-schedule-board-4.png)



## 7. View the scheduled work order on the mobile app

Download the Field Service (Dynamics 365) mobile app from the iOS or Android app stores. See the topic on [installing the mobile app](mobile-power-app-get-started.md) for more details.

3. Sign in with the username and password for the technician user.


- For the **Username**, enter the username of the technician user. For example, username@org.onmicrosoft.com
- For the **Password**, enter the password you set for the field technician.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-mobile-signin.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-error-contact-administrator-show-nonproduction-apps.png)

1. In the **Booking** tab, verify that the work order (or booking) is scheduled for the field technician.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/quickstart-mobile-work-order.png)














## Additional notes

### Set up geo-coding for the organization

Setting up geocoding for an organization enables the system to attach latitudes and longitudes to addresses.

1. Navigate to **Resource Scheduling** > **Administration** > **Scheduling Parameters**.

> [!div class="mx-imgBorder"]
> ![Screenshot showing settings for scheduling parameters](media/qs-1-img22.png)  

2. Set **Connect to Maps** to **Yes**. The API key fills in automatically to use the Bing Maps API, which enables the system to assign a latitude and longitude to the user record's address.

> [!div class="mx-imgBorder"]
> ![Screenshot showing the Bing maps API field](media/qs-1-img23.png)  

3. Navigate to the user record, and then select **Geocode**. 

> [!div class="mx-imgBorder"]
> ![Screenshot showing geocoding on the user record](media/qs-1-img24.png)  

4. Confirm the address, and then choose **Close**.

> [!div class="mx-imgBorder"]
> ![Screenshot showing the Found Places dialog](media/qs-1-img25.png)  

5. Choose **Change** to populate the **Scheduling** section of the user record with the latitude and longitude.

> [!div class="mx-imgBorder"]
> ![Screenshot of Schedule a work order and view it on the mobile application image26](media/qs-1-img26.png)   

> [!NOTE]
> Alternatively, you can type the latitude and longitude into the address fields on the user record.