---
title: "Why can't I see my bookings when logged into the app? Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/03/2018
ms.reviewer: ""
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
search.app: 
  - D365CE
  - D365FS
---
# Why can't I see my bookings when logged into the app?

There are typically 3 possible reasons bookings don't show up in the mobile app:

1. The mobile application isn't synced to the server 

2. The application is in offline mode and the booking is outside the sync filters

3. Drip scheduling is enabled for the related resource and the booking is outside the *bookings to drip* number parameter

See below for details about each of these possible reasons. 

## 1. The mobile application isn't synced to the server

When a dispatcher books a work order to a resource, this takes place on the server and may take time to update on the mobile application. The time it takes for the booking to show on the mobile application can depend on internet speeds, internet connection, and even configurations. For example, the mobile app can be configured to sync data from the server every X minutes, or only when connected to Wi-Fi.

First, try manually syncing data from the server by selecting the sync button.

![Mobile FAQs image14](media/Mobile-FAQs-image14.png)  

If you have trouble syncing, try going to **Setup > Delete Data > **Save** and sync again.

![Mobile FAQs image15](media/Mobile-FAQs-image15.png)  

Finally, there are scenarios where forcing a full sync to the device can push changes that will allow the user to see bookings. One such scenario is a change in security roles.

To force a full sync to the device, in a non-private Internet Explorer browser as an administrator, navigate to **Settings > Woodford > MobileCRM Woodford.**

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

Once in the Woodford interface, navigate to Security, find the user’s device and check Force Full Sync.

![Mobile FAQs image16](media/Mobile-FAQs-image16.png)  

Next, log into the mobile app with the same user and sync the device.

For more information on Forcing Full Syncs, refer to the Woodford guide: <https://www.resco.net/downloads/Woodford_Guide.pdf>

### 2) You are in offline mode in the mobile app and the booking is outside the sync filters

The Field Service mobile application is designed for offline scenarios. This means data is downloaded locally to the device when the user has internet access for later when the user will not have internet access. A common example is performing work in remote areas or in underground tunnels. Rather than download all data, a mobile administrator can create sync filters that will download a targeted portion of the data for offline use later. An example is only downloading this week’s work orders rather than all work orders.

For information on sync filters, refer to the Woodford guide: <https://www.resco.net/downloads/Woodford_Guide.pdf>

There are 2 ways to fix this.

The first way is to use the mobile application in online mode, because this gives you access to all data.

Log into the mobile app and select the online/offline mode icon.

![Mobile FAQs image17](media/Mobile-FAQs-image17.png)  

Select the icon to change it to the following icon to use the application in online mode

![Mobile FAQs image18](media/Mobile-FAQs-image18.png)  

Then navigate to Bookings to view your bookings. Not this may take a few moments to load.

A second way to fix this is to edit sync filters for offline mode.

To edit sync filters for Bookings, in a non-private Internet Explorer browser as an administrator, navigate to **Settings > Woodford > MobileCRM Woodford.**

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

Enter the mobile project and navigate to **Bookable Resource Bookings > Sync Filters**

![Mobile FAQs image19](media/Mobile-FAQs-image19.png)  

This is where an administrator can decide what Bookings will be downloaded to the mobile application when in offline mode/without internet access.

If your booking is not showing in offline mode, make sure it meets the sync filter criteria or change the sync filter criteria

![Mobile FAQs image20](media/Mobile-FAQs-image20.png)  

### 3) Drip scheduling is enabled for the related resource and the booking is outside the bookings to drip number parameter

Drip scheduling is a feature that only displays the next bookings as current bookings are completed. An example is only displaying the next 2 bookings for a field technician.

One reason you may not see bookings when you log into the mobile app is because drip scheduling may be preventing the booking.

To fix this, navigate to **Field Service > Administration > Resources**

![Mobile FAQs image21](media/Mobile-FAQs-image21.png)  

And find the resource related to the user you are attempting to log into the mobile app with.

![Mobile FAQs image22](media/Mobile-FAQs-image22.png)  

Under the Field Service section, set enable drip scheduling to No, or leave it to Yes and adjust the parameters.

Then log into the mobile application and check if your Bookings are now showing
