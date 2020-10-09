---
title: "Get started with the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to get started with the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/28/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Get started with the Field Service (Dynamics 365) mobile app

The Field Service (Dynamics 365) mobile app is designed and optimized for technicians to view Dynamics 365 Field Service work orders, customer assets, accounts, and contacts. This mobile app is built on Microsoft's Power Platform as a [model-driven app](https://docs.microsoft.com/powerapps/maker/model-driven-apps/model-driven-app-overview) and is customizable to your business needs with the same admin console as all Dynamics 365 business apps.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-tablet-website.png)

Available natively for Apple iOS and Google Android phones and tablets, the Field Service (Dynamics 365) mobile app offers technicians many capabilities they need to perform onsite customer service, such as:  

- A calendar view of assigned jobs
- Support for picture, video, and asset barcode scanning
- Customer signature capture
- Offline capabilities so technicians can continue viewing and recording work in areas without internet


## Prerequisites

- **Field Service v8.8.22+**. The Field Service (Dynamics 365) mobile app will appear in your list of Dynamics 365 applications.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Dynamics 365 list of apps, showing the Field Service Mobile solution in the list.](./media/mobile-2020-admin-assign-role-app.png)

- Select the ellipses icon on the **Field Service Mobile** application, then choose **Manage Roles** and assign the app to the Field Service-Resource, Field Service-Administrator, and other relevant roles that will need access to the mobile app.

- Set up a Dynamics 365 Field Service user with the **Field Service-Resource** security role. This user will sign in to the Field Service (Dynamics 365) mobile app as a technician.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Manage Roles dialogue in Dynamics 365.](./media/mobile-2020-resource-security-role.png)

- To view work orders on the mobile app, you must also [create a bookable resource](./set-up-bookable-resources.md) related to your technician user and schedule work orders to the bookable resource.

> [!div class="mx-imgBorder"]
> ![Screenshot of the schedule board, showing a list of unscheduled work orders.](./media/mobile-2020-scheduled-work-orders.png)

## Install and sign into the Field Service (Dynamics 365) mobile app

Go to the app store on your iOS or Android device and search for **Field Service mobile**.

Download the app called **Field Service (Dynamics 365)**, as seen in the following screenshot. It's the mobile app built on the Power Platform.

> [!div class="mx-imgBorder"]
> ![Screenshot of a mobile device app store, showing two Field Service Mobiles in the list, and highlighting the Field Service (Dynamics 365) app.](./media/mobile-2020-download-signin.jpg)

Launch the app and sign in with your username and password, which should be the user credentials of the technician user with the **Field Service - Resource** security role.


## Use the Field Service (Dynamics 365) mobile app

Once you sign in, the app will prompt you to download offline data (your scheduled work orders) to the device. If you anticipate not having internet access, select **Download**. Otherwise you can **Skip for now**. If you're unsure, we recommend downloading the offline data just in case. 

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service (Dynamics 365), showing the download data dialogue.](./media/mobile-2020-download-offline.png)

### View scheduled work orders

The first screen you'll see is a calendar view of your scheduled work orders.

Select **More** > **Show as** > **Read-only Grid** to see the bookings as a list as shown on the right side of the following screenshot.

> [!div class="mx-imgBorder"]
> ![Simulated image showing two mobile devices with Field Service (Dynamics 365). The screen on the left has a list of My Open Resource Bookings by date. The screen on the right has a list of My Open Resource Bookings in a flat list.](./media/mobile-2020-booking-view.jpg)

Select a booking to see more details about the booking time and the work order. For example, you can update the status to **Traveling** to indicate you are driving to the customer location; on the **Customer tab**, you can see the work order location on a map and trigger turn-by-turn driving directions from a GPS app on your phone such as Bing Maps, Apple Maps, Waze, or Google Maps.

> [!div class="mx-imgBorder"]
> ![Simulated image showing two mobile devices side by side, both with screenshots of Field Service (Dynamics 365). Screenshot on the left shows a bookable resource booking on the general tab. Screenshot on the right shows a map.](./media/mobile-2020-work-order-navigate-directions-map.jpg)

On the **Service tab**, you'll see work order details like work order service tasks, products, and services.

On the **Notes tab**, you'll see a way to add note text, pictures, and videos, as well as customer signature capture.


> [!div class="mx-imgBorder"]
> ![Simulated image showing three mobile devices with Field Service (Dynamics 365) open. First screenshot on the left shows the service tab on the bookable resource booking. Middle screenshot shows the service tab. Right screenshot shows the notes tab.](./media/mobile-2020-work-order-service-notes.jpg)

### Find more information

To get to the sitemap, select the menu icon from the calendar view. From here, you can find other important information like accounts, contacts, customer assets, or to record time off.

> [!div class="mx-imgBorder"]
> ![Simulated image showing two mobile devices with screenshots of Field Service (Dynamics 365). The device on the left shows the full menu for Field Service (Dynamics 365). The device on the right shows an account detail page.](./media/mobile-2020-sitemap-account.jpg)

### Work offline

If you expect to be in areas without wifi or cellular internet access, you can download important information to your device to keep working.

From the home screen, select the cloud icon in the bottom left.

Then select **Download offline updates**. If you are prohibited from downloading offline profiles and the option is greyed out, you must:

1. Set up an offline profile.
2. Add your user to an offline profile.
3. Ensure your user has the **Field Service - Resource** security role. See the section: **Configure the Field Service (Dynamics 365) mobile app**.

> [!div class="mx-imgBorder"]
> ![Simulated image showing three mobile devices with Field Service (Dynamics 365). The device on the left shows the menu, with attention to the cloud icon at the bottom. The middle device shows the offline status screen. The device on the right shows the offline status as available, showing the list of available entities.](./media/mobile-2020-offline.jpg)

When **Status** is set to **Available**, you'll have all the data you need to work offline.

Then toggle the **Work in offline mode** to on. If you lose internet connection unexpectedly, the app will automatically work in offline mode if you previously downloaded data.

### Connected Field Service on the Field Service (Dynamics 365) mobile app

For organizations using Connected Field Service, technicians can view and interact with IoT data and actions in the Field Service (Dynamics 365) mobile app.
 
> [!div class="mx-imgBorder"]
> ![Simulated image showing three phones with Field Service mobile app and IoT device readings.](./media/mobile-2020-cfs.png)

For more information, see the article on [Connected Field Service for the Field Service (Dynamics 365) mobile app](cfs-mobile-powerapp.md).

### Trigger Dynamics 365 Remote Assist

Organizations using Dynamics 365 Remote Assist will see that technicians can trigger a deep link from the work order to open the Dynamics 365 Remote Assist mobile app.

> [!div class="mx-imgBorder"]
> ![Simulated image showing a phone with Field Service mobile and a menu option to launch Dynamics 365 Remote Assist.](./media/mobile-2020-remote-assist.png)

For more information, see the article: [Using Field Service with Dynamics 365 Remote Assist](remote-assist-hololens.md).
