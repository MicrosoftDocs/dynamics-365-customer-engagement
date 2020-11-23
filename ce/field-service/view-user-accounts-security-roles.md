---
title: "Set up Dynamics 365 Field Service users and security roles | MicrosoftDocs"
description: Learn how to set up Field Service users and security roles in Dynamics 365 Field Service
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/11/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Set up Dynamics 365 Field Service users and security roles

[!INCLUDE[pn_field_service](../includes/pn-field-service.md)] comes with security roles and field security profiles unique to the Field Service application.

By setting security roles for users, you control the types of data and entities a user can access and edit. By setting field security profiles, you control which fields a user sees for an entity. For example, a user may have permission to see accounts but not to see specific fields for an account. 
 > [!div class="mx-imgBorder"]
 > ![Screenshot of security roles in Dynamics 365](media/users-1.png) 

> [!Note]
> Any users assigned to Field Service security roles need a Dynamics 365 license that includes the Field Service application. After you complete the steps in this article, it's recommended that you sign in to verify that the capabilities appear as expected.

## Field Service roles

**Field Service—Administrator** is designed for service managers and IT administrators. This role has access to all field service entities including work orders, scheduling, and inventory. Additionally, this role has full Create, Read, Update, Delete (CRUD) abilities. For example, a field service administrator can create new work order types for the organization, which other people can then use on work orders that they create.

**Field Service—App Access** and **Field Service—Resource** are designed for field technicians and should be assigned to field technician users who carry out work orders for customers primarily via the mobile application. This role is generally characterized by read and update privileges. An example is the ability to view and update information on work orders that are assigned to this user (and only this user).

**Field Service—Dispatcher** is designed for schedulers who are responsible for managing and assigning a group of work orders to a group of resources. It is characterized by limited CRUD abilities for scheduling related entities within their business unit. An example is editing and scheduling work orders to resources in the Washington territory.

**Field Service—Inventory Purchase** is designed for inventory managers who are responsible for managing truck stocks, purchasing and reordering inventory, and processing product returns. It is characterized by limited CRUD abilities for inventory-related entities within their business unit. An example is processing a product return for one or many lines of business. **This security role should be given to a user in addition to the Field Service-Resource or Field Service-Dispatcher security roles**.

**IoT - Administrator** is designed for users who are responsible for device registration and device data pulls that are IoTHub operations related to Connected Field Service. These roles are characterized by full CRUD abilities for IoT  related entities. For example, a user with these roles may have access to all IoT Alerts and devices. 

**IoT - Endpoint User** is used by Microsoft to connect Dynamics 365 to IoT systems. For more information on CFS security, see the article on [setting up security roles for Connected Field Service](cfs-security-roles.md).  

## Prerequisites

- Dynamics 365 System Administrator access


> [!Note]
> New product releases may update field service security roles. You can either make custom roles or copies of existing roles to mitigate the risks. If you intend to *add* additional privileges, we recommend creating a custom security role with the added privileges, and assigning both the Field Service security role and the add-on role. If you intend to *remove* or lower privileges, then we recommend that you make a copy of the Field Service security role, make your changes, and assign the copied security role to the user. To copy a security role, go to **Settings** > **Security** > **Security Roles**, then select a security role record and choose **Actions** > **Copy Role**. See the following screenshot for reference.

> [!div class="mx-imgBorder"]
> ![Screenshot of copying a security role](media/admin-security-role-copy.png) 

## Create users for Field Service

Once you have a Dynamics 365 environment with Field Service, you need to create users to use the application. Many different roles interact with Field Service like system administrators, technicians, dispatchers, service managers, inventory managers, customer service representatives and more.

Sign into [https://admin.microsoft.com/](https://admin.microsoft.com/) as a system administrator.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Microsoft 365 apps list.](./media/quickstart-o365-admin.png)

Go to **Users** and create new users as needed. Some will represent back-office administrators and others will represent dispatchers or technicians.

Assign each user a license or trial license that includes Dynamics 365 Field Service.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Microsoft 365 admin center showing active users.](./media/quickstart-o365-admin-users.png)

Go to the [Power Apps admin center](https://admin.powerplatform.microsoft.com/).

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Apps admin center.](./media/quickstart-o365-admin-powerapp.png)

Select your environment that has Field Service installed. Select **Settings** > **Users + permissions** > **Users**.

Add the users you created that have Field Service licenses or trial licenses to the environment.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center showing a list of users.](./media/quickstart-ppac-users-add.png)

## 2. Assign appropriate security roles to your users 

Next we need to assign each user the correct Field Service security role.

Select **Manage users in Dynamics 365**.

> [!NOTE]
> Make sure you're seeing the "Enabled Users" view.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center showing the settings.](./media/quickstart-ppac-users.png)

## Set up a dispatcher user

Follow these steps to set up a dispatcher who schedules work orders for field technicians.

1. Go to **Settings** > **Security** > **Security Roles** and copy the **Field Service - Dispatcher** role.

> [!div class="mx-imgBorder"]
> ![Screenshot of copying a security role.](media/admin-security-role-copy.png)

2. Select a user, and then choose **Manage Roles**.

> [!div class="mx-imgBorder"]
> ![Screenshot of adding a security role to a User](media/users-3.png) 

3. Assign the copied **Field Service—Dispatcher** role to allow schedule, dispatch, and work order editing capabilities to the user. Or, if the user is responsible for more than schedule and dispatch, make a copy of the **Field Service – Administrator** role and assign it to the user.

After assigning a user a security role, you must assign the user the corresponding field security profile.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Security profiles](media/users-2.png) 

4. Open the dispatcher's user record, and then select **Field Security Profiles**.

> [!div class="mx-imgBorder"]
> ![Screenshot of field security profiles in Dynamics 365 dropdown](media/users-4.png) 

1.  Assign the **Field Service – Dispatcher** field security role.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Security profile for dispatchers](media/users-5.png) 

## Set up a technician user

1. Go to **Settings** > **Security** > **Users**.

2. Select a user other than your dispatcher/administrator user to be a field technician, and then assign the **Field Service – Resource** and **Field Service—App Access** security roles.

> [!div class="mx-imgBorder"]
> ![Screenshot of adding secuirty roles for resources (field technicians)](media/users-6.png) 

3. For the same user, select **Field Security Profiles**.

> [!div class="mx-imgBorder"]
> ![Screenshot of accessing field security profiles from the dynamics 365 dropdown menu](media/users-8.png) 

5. Assign the field technician user the **Field Service – Resource** field security profile. 

> [!div class="mx-imgBorder"]
> ![Screenshot of adding the resource field security profiles to a user record](media/users-9.png) 

> [!Note]
> Field technicians aren't able to edit fields on the mobile work order form untl you complete this step.

> [!div class="mx-imgBorder"]
> ![Screenshot of field security profile](media/users-10.png) 

## Set up geocoding for a field technician user
To set up geocoding to enable location awareness for scheduling and routing, define where each resource starts and/or ends the day. 

1.  Go to **Settings** > **Users**, and then select the field technician's record.

2.  Verify that the record includes an address. 

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365 user record address](media/users-14.png) 

If there isn't already an address for the user, navigate to the Microsoft 365 admin center and enter one. To display the address in the Dynamics 365 organization, refresh the page.

> [!div class="mx-imgBorder"]
> ![Screenshot of office 365 user](media/users-15.png) 

3.  To enable geocoding in the Dynamics 365 organization, go to **Resource Scheduling** > **Administration** > **Scheduling Parameters**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Scheduling Administration in Dynamics 365 dropdown menu](media/users-17.png) 

> [!div class="mx-imgBorder"]
> ![Screenshot of how to access scheduling parameters](media/users-18.png) 

4.  To tag a latitude and longitude for the address on the user record, set **Connect to Maps** to **Yes**. The API key is filled out automatically to use Bing Maps API.

> [!div class="mx-imgBorder"]
> ![Screenshot of connecting to maps and Bing Maps API in Dynamics](media/users-19.png) 

5. Go to the user record, and then select **Geo Code**.

> [!div class="mx-imgBorder"]
> ![Screenshot of geocoding user record](media/users-20.png) 

6. On the **Found Places** dialog, choose the address.
> [!div class="mx-imgBorder"]
> ![Screenshot of system finding address](media/users-21.png) 

7.  Select **Change**.

> [!div class="mx-imgBorder"]
> ![Screenshot of latitiude and longitude from geocoding process](media/users-22.png)

8. Verify that the latitude and longitude display in the **Scheduling** section.

> [!div class="mx-imgBorder"]
> ![Screenshot of latitiude and longitude being populated on user record](media/users-23.png) 

> [!Note]
> If you are having trouble populating an address or geocoding an address, manually enter a latitude and longitude into the fields.


