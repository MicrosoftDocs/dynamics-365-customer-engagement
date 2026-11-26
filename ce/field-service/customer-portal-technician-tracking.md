---
title: Track a technician on the Field Service portal
description: Send customers information about a technician's location for their upcoming service appointment in the Power Pages portal for Dynamics 365 Field Service.
ms.date: 10/16/2025
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
ms.reviewer: puneetsingh
search.app:
- D365CE
- D365FS
---

# Track a technician on the Field Service portal

Provide customers with automated service reminders and notifications that include estimated technician arrival times. These reminders help customers plan their time better around service visits.  

:::image type="content" source="media/technician-locator-hero.jpg" alt-text="Screenshot of branded service details portal, along with a device render showing technician location on a mobile phone.":::

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=4f2a146e-6d25-48ec-a7c9-9b345cdef537]

## Prerequisites

To enable technician tracking in the Field Service portal, you need:

- The Field Service mobile app.
- [Technician location sharing](mobile/track-technician-location.md) enabled in Field Service and allowed from the technician's mobile device.
- An SMS provider with a supported Power Automate connector for mobile SMS communication.
- An email provider with a supported Power Automate connector, such as Office 365 Outlook, for email communications.

## Configure track my technician settings

To enable technician tracking in the Field Service portal, update the customer portal settings in Field Service.

1. In Field Service, select the **Settings** area.
1. Under **Customer Portal**, select **Customer Portal**, and open the settings record. Turn on the **Track My Technician** setting. 
1. Select the **Track My Technician** tab, and enable the appropriate settings.

   - **Enable Map**: The map shows service appointments in the self-scheduling portal.
   - **Show Resource Name**: When the technician travels, the portal and notifications show the name of the technician as defined in their Field Service user record.
   - **Show Resource Image**: When the technician travels, the portal shows an image of the technician, if available.
   - **Show Resource Phone**: When the technician travels, a phone icon appears in the portal. Customers can call or text the technician using the *Main Phone* value configured for the technician, if available.

   :::image type="content" source="media/TmT-GASettings.svg" alt-text="Screenshot of Track My Technician settings in Field Service.":::

> [!NOTE]
> Location tracking for a technician isn't available when the booking status changes to *In Progress* because the system assumes the technician performs work at the designated work location.

## Test the experience as a customer

To review and test changes, set up an account and a contact as if you were one of your customers. This procedure also lets you test rescheduling and canceling a booking through the portal.

1. Create a test account in Field Service with an address local to your area.
1. Create a test contact in Field Service with an email address and mobile phone number.
1. Assign the contact as the primary contact for the test account you create.
1. Create a work order related to the service account you create.
1. Create a booking for the work order, and set the status to *Scheduled*. Set the start date within the range of the booking reminder notification.
1. Assign a resource to the booking. Give the resource access to the Field Service mobile app, and enable location sharing. Save the booking to trigger an email or SMS notification sent to the email address or phone number of the test contact.
1. Open the email or SMS notification, and follow the link in the notification to review the portal. A map showing the location of the service account appears.
1. Change the booking status to *Traveling*, which triggers a second email or SMS notification. This notification includes a map showing the technician's current location and estimated arrival time at the service account location.
1. Change the booking status to *Complete*, which triggers the booking complete notification.


[!INCLUDE [footer-include](../includes/footer-banner.md)]