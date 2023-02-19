---
title: "Send current technician location and arrival times to your customers with Dynamics 365 Field Service (contains video) | MicrosoftDocs"
description: Learn how to send customers information about their upcoming service in Dynamics 365 Field Service
ms.date: 04/22/2022
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: Deana-Fuller
ms.author: drfuller
search.app:
- D365CE
- D365FS
---

# Track a technician

Provide your customers with automated service reminders and notifications that include estimated technician arrival times; these reminders make it so customers can better plan their time around service visits.

> [!div class="mx-imgBorder"]
> ![Branded service details portal, along with a device render showing technician location on a mobile phone.](./media/technician-locator-hero.jpg)

With this functionality, you can:

- Send customers automated service reminders and updates by email or text message.
- Provide customers with a responsive, accessible, and customizable online portal that shows them information about their upcoming service, including: 
  - Technician location
  - Estimated arrival time
  - Service updates

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWymMU]

  
In this article, we'll walk through how to set up and configure service notifications, and how to set up the customer portal.

## Prerequisites

- Field Service version (8.8.30.103+)
- The Field Service mobile app
- [Technician location sharing](mobile-powerapp-location-auditing.md) must be enabled in Field Service, and also allowed from the technician's mobile device.
- SMS provider supporting Microsoft Power Automate connector for mobile SMS communication.
- Office 365 Exchange account for email communications.



### Track my technician settings

- **Enable Map**: When enabled the map will be shown on the portal experience. 

- **Show Resource Name**: When the technician is traveling, the portal and messaging will show the technician name as defined in their Field Service user record.

- **Show Resource Image**: When the technician is traveling, the portal will show an image of the technician. If no image is available, only the resource initials are shown.

- **Show Resource Phone**: When the technician is traveling, a phone icon will be shown on the portal, which the customer can select to call or text the technician. This interaction will use the **Main Phone** value configured for the technician. If no phone number is available for the technician, no phone icon will be shown to the customer.


> [!div class="mx-imgBorder"]
> ![Track my technician settings.](./media/TmT-GASettings.png)

## Step 4: Testing the experience as an end user

To review and test changes, we recommend setting up an account and contact as if you are an end customer.  


1. Create an account in Field Service with an address local to your area.
2. Next, create a contact in Field Service with a test email address and mobile phone number.
3. Assign the contact as the primary contact of the test account you created.
4. Create a work order and assign the service account you created.
5. Create a booking for the work order, and set the status to *Scheduled*. Set the start date within the range of your **Booking Reminder** notifications.
6. Assign a resource to the booking. The resource assigned to the booking should have access to the Field Service mobile app, with **Location Sharing** enabled.
7. After saving the booking, you will receive an email or SMS notification to the test email address and mobile phone number associated with the test contact. Follow the link the notification to review the portal, and you'll find a map showing the location of the service account.
8. Change the booking status to *Traveling*. You will receive a second email or SMS notification. This notification will include a map showing the current location of the technician and their estimated arrival time to the service account location.
9. Finally, change the booking status to *Complete*, which will trigger the booking complete notification.

To test reschedule notifications and cancel notifications, perform steps 1-6; then after the scheduled booking is in place, reschedule the time slot of the booking or cancel the booking.

## Configuration considerations




## Additional notes



### How can I manually enter a resource location without sharing location from the Field Service mobile app?

To inject a new location, use advanced find in **Field Service** and search for **Geolocation Tracking**. Choose **New Geolocation Tracking**. Enter the resource and the desired latitude and longitude values.

>[!NOTE]
> Be sure to enable **Geolocation Tracking** in Field Service settings.

