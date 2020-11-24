---
title: "Enable Push Notifications for the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to configure the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/30/2020
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


# Enable push notifications

In the Field Service (Dynamics 365) mobile app, push notifications allow you to send updates to technicians through their mobile phones or tablets. Push notifications utilize Power Automate and can be triggered by many scenarios. 

Push notifications can be used to:

- Notify technicians they have been assigned a booking.
- Remind technicians to enter important business data.

## Prerequisites
To use Field Service mobile push notifications, you'll need:
-	[Power Automate](https://flow.microsoft.com/)
-	Dynamics 365 Field Service mobile application v13.20101.19+ for iOS or v3.20101.19+ Android devices. Visit the app's About section to check which version you have.
-	Consent for notifications in your device's settings for the Field Service app.
-	Review the [privacy notes for Field Service push notifications](mobile-push-notifications-privacy.md). PLEASE NOTE: Google Cloud Messaging, Apple Push Notification, and Windows Push Notification services are not provisioned in a dedicated data center for exclusive use by you and does not provide data segregation, such as for the Government Community Cloud. Your use of Google Cloud Messaging, Apple Push Notification, and Windows Push Notification services shall not be subject to any product-specific terms and conditions applicable to Dynamics 365 online for Government. If you do not wish to use the Push Notification, then you must ensure that your administrator keeps the feature off.

## 1. Go to Power Automate and create a new flow
Navigate to Power Automate and select Create on the left-hand side. Start from blank or a template to create a flow based on your needs. 
 
## 2. Use any of the available connector triggers
Power Automate supports hundreds of pre-built connectors that can be used to trigger and provide dynamic data to the push notifications. You can use any of these triggers to send targeted push notifications to the desired set of users.

 For this example below, we are using the Common Data Service (current environment) connector with the When a record is created, updated or deleted trigger so that we can notify the relevant user when a new record has been created. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-push-notification-create1.png)

## 3. Add the push notification action
The Power Apps Notifications V2 connector includes the Send a push notification V2 action. Add this action as a step in your flow and enter the necessary information to configure the push notification, using any of the dynamic data provided by earlier steps. 

To send a message to the Field Service mobile app, make sure 
-	Mobile app:  Field Service
-	Your app:  Field Service Mobile

If you want to redirect the technician to the new booking and work order form, set 
-	Open app: Yes
-	Entity: Bookable Resource Booking
-	Form or view:  Form – Booking and Word Order
-	Record ID: Bookable Resource Booking

Use these fields to provide a custom message.
-	Recipient Items: The desired set of recipients for the notification
-	Message: The notification message.

In this screenshot, we are creating a push notification to the Field Service technician (Bookable Resource) when a new booking has been assigned. The push notification, when tapped on, will open the Booking Resource Booking record on the Booking and Work Order form. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-push-notifications-create2.png)

## 4. View in Field Service mobile app
Download the Dynamics Field Service mobile app from the app store.

When the app launches, accept the prompt to receive notifications.

The push notifications will be shown to the technician using the mobile phone notification.  Field technicians do not need to be in the app or using their device to receive push notifications.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-push-notification-view.png)


### See also
-	For more information, see the [Power Apps mobile push notification documentation](https://docs.microsoft.com/powerapps/mobile/power-apps-mobile-notification). 
-	These notifications work with the [Power Apps mobile app](https://powerapps.microsoft.com/en-us/blog/announcing-the-public-preview-of-new-power-apps-mobile-app-that-runs-both-canvas-and-model-driven-apps/) that runs both canvas and model-driven apps.

