---
title: "Use the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to use the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/21/2021
ms.reviewer: krbjoran
ms.topic: article
ms.service: dynamics-365-customerservice
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---


# Use the Field Service (Dynamics 365) mobile app to complete work orders

Available natively for Apple iOS and Google Android phones and tablets, the Field Service (Dynamics 365) mobile app offers technicians many capabilities they need to perform onsite customer service, such as:  

- A calendar view of assigned jobs.
- Support for picture, video, and asset barcode scanning.
- Customer signature capture.
- Offline capabilities so technicians can continue viewing and recording work in areas without internet.


> [!div class="mx-imgBorder"]
> ![Simulated image of the Field Service (Dynamics 365) mobile app on a phone and a tablet.](./media/mobile-2020-tablet-website.png)

## Prerequisites

Before using the mobile app, a system administrator must [install and set up the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md) along with users and security roles.

## Download

Go to the app store on your iOS or Android device and search for **Dynamics 365 Field Service**.

Download the app called **Field Service (Dynamics 365)**, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of a mobile device app store, showing two Field Service Mobiles in the list, and highlighting the Field Service (Dynamics 365) app.](./media/mobile-2020-download-signin.jpg)


## Sign in

Launch the app and sign in with your username and password.  

> [!div class="mx-imgBorder"]
> ![Screenshot of sign in](./media/quickstart-mobile-signin.png)

Administrators should go to the articles on [setting up users and security roles](../field-service/view-user-accounts-security-roles.md) and [creating a Bookable Resource](set-up-bookable-resources.md) for help.

Upon sign-in, the app will download important Field Service information as defined by administrators. 

> [!div class="mx-imgBorder"]
> ![Device renders showing the Field Service (Dynamics 365) mobile app, showing the offline status.](./media/mobile-2020-offline-downloading2.png)

## Home

To get to the sitemap, select the menu icon from the calendar view. From here, you can find other important information like accounts, contacts, customer assets, or to submit time entries.

> [!div class="mx-imgBorder"]
> ![Simulated image showing two mobile devices with screenshots of Field Service (Dynamics 365). The device on the left shows the full menu for Field Service (Dynamics 365). The device on the right shows an account detail page.](./media/mobile-2020-sitemap-account.jpg)

## View scheduled work orders

The first screen you'll see is a calendar view of your scheduled work orders.


> [!div class="mx-imgBorder"]
> ![Simulated image showing two mobile devices with Field Service (Dynamics 365). The screen on the left has a list of My Open Resource Bookings by date. The screen on the right has a list of My Open Resource Bookings in a flat list.](./media/mobile-2020-booking-view.jpg)

Select **More** > **Show as** > **Read-only Grid** to see the bookings as a list as shown on the right side of the screenshot.


## Travel to job location 

Select a booking to see more details about the booking time and the work order. For example, you can update the status to **Traveling** to indicate you are driving to the customer location; on the **Customer tab**, you can see the work order location on a map and trigger turn-by-turn driving directions from a GPS app on your phone such as Bing Maps, Apple Maps, Waze, or Google Maps.

> [!div class="mx-imgBorder"]
> ![Simulated image showing two mobile devices side by side, both with screenshots of Field Service (Dynamics 365). Screenshot on the left shows a bookable resource booking on the general tab. Screenshot on the right shows a map.](./media/mobile-2020-work-order-navigate-directions-map.jpg)

The functional location field above the address tells the technician exactly where to go within an address. 

> [!div class="mx-imgBorder"]
> ![Device render with the Field Service mobile app, showing a booking and a location on a map.](./media/mobile-2020-functional-location-work-order.png)

## Perform and record work

On the **Service tab**, you'll see work order details like work order service tasks, products, and services. In one click, you can mark a service or service task complete along with the products used. Adjust the product units and the service hours as needed. Selecting the service task, service, or product name will send you to the full details form.


> [!div class="mx-imgBorder"]
> ![Simulated image showing three mobile devices with Field Service (Dynamics 365) open. First screenshot on the left shows the service tab on the bookable resource booking. Middle screenshot shows the service tab. Right screenshot shows the notes tab.](./media/mobile-2020-work-order-service-notes-new.jpg)

## Notes, pictures, and videos

On the **Notes** tab, you can add note text, pictures, videos, and customer signature capture.

> [!div class="mx-imgBorder"]
> ![Simulated image showing three mobile devices with Field Service (Dynamics 365) open. First screenshot on the left shows the service tab on the bookable resource booking. Middle screenshot shows the service tab. Right screenshot shows the notes tab.](./media/mobile-2020-work-order-service-notes-new.jpg)

## Service assets

> [!div class="mx-imgBorder"]
> ![Device renders with the Field Service mobile app, showing active customer assets in a list.](./media/mobile-2020-customer-asset-navigate.png)

Technicians can also view and interact with functional location and customer asset hierarchies on the mobile app.

> [!div class="mx-imgBorder"]
> ![Device renders with the Field Service mobile app, showing asset hierarchies and functional locations.](./media/mobile-2020-functional-location-hierarchy-combined.png)

> [!Note]
> Internet connectivity is required to view and interact with functional location and customer asset hierarchy trees on the Field Service mobile app.

For a guided walkthrough of functional locations on the Field Service mobile app, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4I2pU]

## Barcode scanning

Select the global search icon to search for records across accounts, contacts, work orders, customer assets, or any other entity. Technicians can also search by scanning a barcode with their phone's camera. The barcode scan will find records that have a matching barcode field.

> [!div class="mx-imgBorder"]
> ![Simulated image showing four mobile devices in different stages of the barcode scan process.](./media/mobile-2020-global-search-use.png)

For more information, see the article on [configuring global search](https://docs.microsoft.com/dynamics365/field-service/mobile-power-app-configure#customize-global-search-and-enable-scan-to-search).

## Work offline and update offline data

If you expect to be performing work in areas without internet access, you can download important information to your device to keep working.

Consider a scenario where a technician needs to work in the basement of an industrial complex. They will often have limited or no internet connectivity. Working offline will download their work orders, notes, service tasks, and pictures for use without connectivity; once connectivity is restored, new data is automatically synced back to the server. This process happens without interruption to the technician's experience.

Upon sign-in, the app will download important Field Service information as defined by system administrators. 

> [!div class="mx-imgBorder"]
> ![Device renders showing the Field Service (Dynamics 365) mobile app, showing the offline status.](./media/mobile-2020-offline-downloading2.png)

When the **Status** is set to **Available**, you'll have all the data you need to work offline.



> [!Note]
> When the technician has internet connectivity, data on the device is automatically refreshed every five minutes.

Technicians can also **Update offline data** manually by going to the home screen, selecting the offline icon in the bottom left, then selecting the **Update offline data** option. 

> [!div class="mx-imgBorder"]
> ![Device renders showing the Field Service (Dynamics 365) mobile app, showing how to get to the update offline data option.](./media/mobile-2020-offline-update-offline-data2.png)

Technicians may also want to sync specific views when they have internet connectivity. For instance: 

- The technician wants to check for new bookings on their calendar before starting to drive.
- The technician wants to check for updates on a work order made by other crew members. 

To sync specific views, select **Refresh** from the app's bottom menu. For example, you can refresh bookings by selecting the **Refresh** option, shown in the following screenshot.


> [!div class="mx-imgBorder"]
> ![Device render showing Field Service (Dynamics 365), with attention to the refresh option.](./media/mobile-2020-offline-refresh.png)

System administrators can find more information in the topic on [configuring offline sync filters](mobile-power-app-system-offline.md).

## Time entry

Time entry capabilities help field service organizations better track the time that technicians spend during work orders and other scenarios.

Time entries are useful for:

- reporting
- understanding utilization
- billing and invoicing for service

Technicians can view and create time entries in the mobile app. 

From the main menu, go to **Time Entry**, then create a new one. In the **Type** field select whether the time entry relates to work, vacation, absence, break, and so on.  

> [!div class="mx-imgBorder"]
> ![Screenshot of time entry on the Field Service (Dynamics 365) mobile app.](./media/mobile-2020-time-entry-all.png)

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4J6mQ]

## IoT

Technicians can view and interact with IoT data and IoT actions like pulling live device data or registering new devices in the mobile app.
 
> [!div class="mx-imgBorder"]
> ![Simulated image showing three phones with Field Service mobile app and IoT device readings.](./media/mobile-2020-cfs.png)

As seen in the following image, technicians can also view a chart of live IoT data from an IoT device, customer asset, or IoT alert record.

> [!div class="mx-imgBorder"]
> ![Simulated image showing live device readings.](./media/cfs-device-readings-mobile.png)

For more information, see the article on [Connected Field Service for the Field Service (Dynamics 365) mobile app](cfs-mobile-powerapp.md).


## Trigger Dynamics 365 Remote Assist for remote collaboration

Organizations using Dynamics 365 Remote Assist will see technicians can trigger a deep link from the work order to open the Dynamics 365 Remote Assist mobile app.

> [!div class="mx-imgBorder"]
> ![Screenshot of four mobile devices showing Field Service Mobile, and the workflow that brings up the Dynamics 365 Remote Assist launching option.](./media/remote-assist-booking-deeplink.png)

> [!div class="mx-imgBorder"]
> ![Simulated image showing a phone with Field Service mobile and a menu option to launch Dynamics 365 Remote Assist.](./media/mobile-2020-remote-assist.png)

For more information, see the article: [Using Field Service with Dynamics 365 Remote Assist](remote-assist-hololens.md).

## Create follow-up work orders

While working on site, frontline workers may need to note further work that needs to be performed at a later time. The Field Service (Dynamics 365) mobile app makes it easy to create follow-up work orders after completing the current work order. This feature prepopulates several columns from the current work order, making it easier for the technician to quickly create the new work order.

For a guided walkthrough, check out the following video.

> [!VIDEO 
https://www.microsoft.com/videoplayer/embed/RWyHY4]


To create a follow-up work order, the technician must select the **Follow-up** option in the bottom app menu. This option is only available if the booking status is set to **Completed** and the user has **create** permissions for the work order table. For more information on the security roles, see [users and security roles](./view-user-accounts-security-roles.md).

> [!div class="mx-imgBorder"]
> ![Device render showing the Field Service (Dynamics 365) mobile app, showing the follow up work order option](./media/mobile-2020-follow-up.png)

After selecting **Follow up**, the technician is guided through the new work order creation flow.

The following columns are prepopulated based on the current work order: 

- Address - including msdyn_addressName, msdyn_address1, msdyn_address2, msdyn_address3, msdyn_city, msdyn_country, msdyn_latitude, msdyn_longitude, msdyn_postalCode, msdyn_stateOrProvince
- Billing Account
- Service Account
- Service Territory
- Exchange Rate
- Tax Code
- Taxable
- Transaction Currency ID

Once the technician saves the work order, it gets uploaded and available to be booked by the dispatcher.

## Home + settings

### Sign out and reconfigure

Reconfiguring the app is a good way to troubleshoot issues and remove all cached data.

Go to the main menu, then select the person icon in the top left.

Then select **Reconfigure**.

> [!div class="mx-imgBorder"]
> ![Device render showing the Field Service (Dynamics 365) mobile app, showing the reconfigure option.](./media/mobile-2020-offline-reconfigure.png)

Reconfiguring deletes data and metadata for the current organization from the cache.

> [!Tip]
> Don't rely solely on the reconfiguration for security measures.

Make sure to reconfigure before you sign out. You won't be able to reconfigure if you're signed into another organization.

### Recent + pins

Use the **Recent** option in the main menu to quickly go to recently viewed, like work orders, assets, time entries, and more. You can also "pin" important records for easy access.


> [!div class="mx-imgBorder"]
> ![Device render showing the Field Service (Dynamics 365) mobile app, showing the recent and pin icons in the menu.](./media/mobile-2020-menu-pin.png)

### Update offline data

If you expect to be performing work in areas without internet access, you can download important information to your device to keep working.

Consider a scenario where a technician needs to work in the basement of an industrial complex. They will often have limited or no internet connectivity. Working offline will download their work orders, notes, service tasks, and pictures for use without connectivity; once connectivity is restored, new data is automatically synced back to the server. This process happens without interruption to the technician's experience.

Upon sign-in, the app will download important Field Service information as defined by system administrators.

> [!div class="mx-imgBorder"]
> ![Device renders showing the Field Service (Dynamics 365) mobile app, showing the offline status.](./media/mobile-2020-offline-downloading2.png)

When the **Status** is set to **Available**, you'll have all the data you need to work offline.

> [!Note]
> When the technician has internet connectivity, data on the device is automatically refreshed every five minutes.

Technicians can **Update offline data** manually by going to the home screen, selecting the offline icon in the bottom left, then selecting the **Update offline data** option. 

> [!div class="mx-imgBorder"]
> ![Device renders showing the Field Service (Dynamics 365) mobile app, showing how to get to the update offline data option.](./media/mobile-2020-offline-update-offline-data2.png)

Technicians may also want to sync specific views when they have internet connectivity. For instance: 

- The technician wants to check for new bookings on their calendar before starting to drive.
- The technician wants to check for updates on a work order made by other crew members. 

To sync specific views, select **Refresh** from the app's bottom menu. For example, you can refresh bookings by selecting the **Refresh** option, shown in the following screenshot.


> [!div class="mx-imgBorder"]
> ![Device render showing Field Service (Dynamics 365), with attention to the refresh option.](./media/mobile-2020-offline-refresh.png)

System administrators can find more information in the topic on [configuring offline sync filters](mobile-power-app-system-offline.md).


### See also

[Install and set up the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
