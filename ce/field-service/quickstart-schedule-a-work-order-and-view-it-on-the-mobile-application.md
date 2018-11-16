---
title: "Quickstart #1: Schedule a work order and view it on the mobile application - Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/02/2018
ms.reviewer: "krbjoran"
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
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

# Quickstart \#1: Schedule a work order and view it on the mobile application

This quickstart will show you how to create and schedule a work order as a dispatcher, and view the work order on the mobile application as a field technician.

Estimated Duration: 20 minutes

Steps:

1.  Prerequisites

2.  Set up a dispatcher role

3.  Create a work order or select a sample one

4.  Set up a resource (field technician) role

5.  Create a bookable resource

6.  Add the bookable resource to the schedule board

7.  Schedule the work order to the bookable resource

8.  Download the Field Service Mobile (2017) mobile app

9.  Sign into the mobile application as a technician

10. View the Work Order on the mobile application

## 1. Prerequisites

This quickstart assumes you have the [Field Service solution](install-field-service.md) and the mobile solution installed. Sample data imported from the [package deployer](install-sample-data-8-x.md) is **highly recommended**.  

### Ensure the Field Service application is installed

When logged in to Dynamics 365 as a system administrator, you will see the Field Service module

![Quickstart 1 Schedule a work order and view it on the mobile application image1](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image1.png)  

### Ensure the mobile solution is installed

When logged in as a system administrator, Woodford will appear under **Settings > Solutions** and as an icon under Settings

![Screenshot of Schedule a work order and view it on the mobile application image2](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image2.png)  

![Screenshot of Schedule a work order and view it on the mobile application image3](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image3.png)  

### Ensure the sample data in imported

If the sample data has been properly imported, you'll see multiple records under **Field Service &gt; Work Orders**.

![Screenshot of Schedule a work order and view it on the mobile application image4](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image4.png)  

### ![Screenshot of Schedule a work order and view it on the mobile application image5](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image5.png)  

## 2. Set up a dispatcher role 

Within Dynamics 365, navigate to **Settings** &gt; **Security** &gt; **Users**

Select your user and then **Manage Roles** at the top.

![Screenshot of Schedule a work order and view it on the mobile application image6](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image6.png)

Assign your User the **Field Service – Administrator** role. This will give your User schedule and dispatch capabilities as well as configuration abilities. If this user is solely a dispatcher, then assign the **Field Service—Dispatcher** role.

## 3. Create a work order or select a sample one

If you have sample data, skip this step.

Navigate to **Field Service &gt; Work Orders**

Select +New

Create new Work Order with…

Service Account = **\[select from list or create a new one. Ex: Contoso\]**

Work Order Type = **\[select from list or create a new one. Ex: Inspection\]**

System Status = **Open-Unscheduled**

Price List = **\[select from list or create new one. Ex: Default Price List\]**

Taxable = **No**

![Screenshot of Schedule a work order and view it on the mobile application image7](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image7.png)  

> [!NOTE]
> **Hint:** You may have to click on another tab to access more required fields. In this example, the **Settings** tab.

![Screenshot of Schedule a work order and view it on the mobile application image8](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image8.png)  

Enter a valid address

![Screenshot of Schedule a work order and view it on the mobile application image9](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image9.png)  

Click Save

## 4. Set up a resource (field technician) role 

First, let’s designate one of our users as a field technician.

Navigate to **Settings** > **Security** > **Users**

Select the D365 User (different than your dispatcher/administrator User) that will be a field technician and assign him/her the **Field Service – Resource** security role (and only this role).

![Screenshot of Schedule a work order and view it on the mobile application image10](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image10.png)

Next, open the Field technician’s User record and select “**Field Security Profiles**” in the ribbon

![Screenshot of Schedule a work order and view it on the mobile application image11](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image11.png)

![Screenshot of Schedule a work order and view it on the mobile application image12](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image12.png)

Then assign your Field technician User the **Field Service – Resource** Field Security Profile

![Screenshot of Schedule a work order and view it on the mobile application image13](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image13.png)

**WARNING:** This is a very important step. Field Technicians will not be able to edit fields on the mobile work order form without completing this step.

![Screenshot of Schedule a work order and view it on the mobile application image14](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image14.png)

If you do not have a User to assign this role to, you can create a new one by navigating to the Admin center in the Office 365 interface from <https://login.microsoftonline.com>.

![Screenshot of Schedule a work order and view it on the mobile application image15](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image15.png)![Screenshot of Schedule a work order and view it on the mobile application image16](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image16.png)

![Screenshot of Schedule a work order and view it on the mobile application image17](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image17.png)

> [!NOTE]
> **Hint:** This user must have a Dynamics 365 license that is valid for Field Service. It is recommended to verify you can log into D365 with the new user record as you may need to reset a temporary password.

Finally, we want to **geocode** our field technician user record. Field technician locations are very important in Field Service because it is used for scheduling and routing. We want every field technician user record to be geocoded, so we can use this information to define where each resource starts and/or ends his/her day.

> [!NOTE]
> **Pro Tip:** the solution can also accommodate scenarios where field technicians begin and/or end their day at a central location.

Back in Dynamics 365…

Navigate to your field technician’s user record in **Settings &gt; Users**

Every user record has an address that is taken from the user record in Office 365. Ensure an address is present.

![Screenshot of Schedule a work order and view it on the mobile application image18](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image18.png)  

If one is not present, navigate to the Office 365 admin center and enter an address for the user.

![Screenshot of Schedule a work order and view it on the mobile application image19](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image19.png)  

![Screenshot of Schedule a work order and view it on the mobile application image20](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image20.png)  

Back in Dynamics 365, refresh the field technician user record to see the address from Office 365 appear.

Next, we need to enable geocoding in your Dynamics 365 organization. Geocoding allows the solution to stamp latitudes and longitudes to addresses.

Navigate to **Resource Scheduling &gt; Administration &gt; Scheduling Parameters**

![Screenshot of Schedule a work order and view it on the mobile application image21](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image21.png)  

![Screenshot of Schedule a work order and view it on the mobile application image22](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image22.png)  

Set **Connect to Maps** to **Yes**.

The API key should be filled out automatically and uses Bing Maps API

![Screenshot of Schedule a work order and view it on the mobile application image23](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image23.png)  

This will allow us to tag a latitude and longitude to the address on the user record.

Navigate back to the user record and select **Geocode** in the ribbon.

![Screenshot of Schedule a work order and view it on the mobile application image24](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image24.png)  

![Screenshot of Schedule a work order and view it on the mobile application image25](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image25.png)  

This will geocode the address on the user record taken from Office 365

![Screenshot of Schedule a work order and view it on the mobile application image26](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image26.png)  

Select **Change** and the Latitude and Longitude will be populated under the Scheduling section of the user record

![Screenshot of Schedule a work order and view it on the mobile application image27](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image27.png)  

> [!Note]
> **Pro Tip:** if you are having trouble populating an address or geocoding an address, it is acceptable to manually enter a latitude and longitude into the fields on the user record.

Congratulations! You have successfully set up a dispatcher and resource (field technician) users and security roles. You are on your way to using Field Service. A recommended next step is to create a bookable resource related to your resource (field technician) user to schedule work orders that he/she will view on the mobile application.

## 5. Create a bookable resource

Back in Dynamics 365…

Navigate to **Field Service** &gt; **Administration** &gt; **Resources**

![Screenshot of Schedule a work order and view it on the mobile application image28](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image28.png)

Select **+New**

Create new Resource (Field Technician) with..

Resource Type = **User**

User = **\[User record you assigned Resource role to\]**

Warehouse = **\[assign a warehouse or create a new one. Ex: Truck 1\]**

Hourly Rate = **$60**

Start Location = **Resource Address**

End Location = **Resource Address**

Display on Schedule Board = **Yes**

Enable for Availability Search = **Yes**

![Screenshot of Schedule a work order and view it on the mobile application image29](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image29.png)

![Screenshot of Schedule a work order and view it on the mobile application image30](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image30.png)  

**Optional:** Related to the Resource (Field technician) assign a…

Resource Characteristic: **\[Add an existing one or create a new one: Ex: Electrical\]**

Resource Territory: **\[Add an existing one or create a new one: Ex: WA\]**

### ![Screenshot of Schedule a work order and view it on the mobile application image31](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image31.png)  

## 6. Add the bookable resource to the schedule board

Lets add this new field technician to the schedule board

Navigate to **Field Service** &gt; **Schedule Board**

![Screenshot of Schedule a work order and view it on the mobile application image32](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image32.png)

In the left pane of the Schedule Board, select **Options** &gt; **Select Resources**

![Screenshot of Schedule a work order and view it on the mobile application image33](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image33.png)

Find your new **Field Technician** with a Resource Type = **User** and move him/her to the right to selected resources, then choose **Apply**

![Screenshot of Schedule a work order and view it on the mobile application image34](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image34.png)![Screenshot of Schedule a work order and view it on the mobile application image35](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image35.png)

## 7. Schedule the work order to the bookable resource

In the lower pane, find the work order you created or select a sample work order. This work order should be found in both the Open Requirements view and the Unscheduled Work Orders view, click and drag the work order from the bottom to the new Field technician

![Screenshot of Schedule a work order and view it on the mobile application image36](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image36.png)

Let’s now view this scheduled work order on the mobile application as a field technician.

## 8. Download the Field Service Mobile (2017) mobile app

First, download the **Field Service Mobile (2017)** mobile app from the Windows, iOS, or Android app stores onto your phone, tablet, or Windows 10 device.

![Screenshot of Schedule a work order and view it on the mobile application image37](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image37.png)

## 9. Sign into the mobile application as a technician

Navigate to the **Field Service Mobile (2017)** mobile application on your Windows, iOS, or Android device, then **Setup** and sign in with the credentials of the User record of your Field Technician

![Screenshot of Schedule a work order and view it on the mobile application image38](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image38.png)

![Screenshot of Schedule a work order and view it on the mobile application image39](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image39.png)

URL: **\[enter the URL of your Dynamics 365 org. Ex: https://org.crm.dynamics.com]\**

Username: **\[enter the username of the User associated with your Field Technician. Ex: username@org.onmicrosoft.com]\**

Password: **\[enter the password of the User associated with your Field Technician\]**

> [!NOTE]
> **Hint:** If you recently created a User to be a field technician, it is recommended to log in to the web browser with this user first as you may need to reset a temporary password.

![Screenshot of Schedule a work order and view it on the mobile application image40](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image40.png)

##  10. View the Work Order on the mobile application 

In the **Booking** tab you will now see the Booking (Work Order) scheduled to the field technician.

![Screenshot of Schedule a work order and view it on the mobile application image41](media/Quickstart--1-Schedule-a-work-order-and-view-it-on-the-mobile-application-image41.png)

> [!NOTE]
> **Hint:** You should see only bookings assigned to the Field Technician resource, in the above example only a single booking. This is because the Field Technician has a security role of Field Service – Resource. If you are seeing many bookings for many different resources, this most likely means you are signed in to the mobile application as an administrator.

**Congratulations!** You are now on your way to using Field Service!
