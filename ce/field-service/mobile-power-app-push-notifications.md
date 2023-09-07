---
title: Enable push notifications for the Field Service (Dynamics 365) mobile app
description: Learn how to enable push notifications for the Field Service (Dynamics 365) mobile app.
ms.date: 09/07/2023
ms.subservice: field-service-mobile
ms.topic: article
author: JonBaker007
ms.author: jobaker
---

# Enable push notifications

In the Field Service (Dynamics 365) mobile app, push notifications send updates to technicians through their mobile phones or tablets. Push notifications use Microsoft Power Automate and can be triggered by many scenarios. For example, to notify about a newly assigned booking or as a reminder to capture and enter important data.

There are two ways to enable push notifications for your organization.

1. Enable the push notification cloud flow included with Dynamics 365 Field Service. The included push notification notifies technicians when they have been assigned a booking.

1. Create a custom push notification based on custom triggers using the **Send Push Notification V2** connector in Power Automate .

## Prerequisites

- A license and permissions for [Power Automate](https://flow.microsoft.com/).
- At least Field Service (Dynamics 365) mobile app v13.20101.19+ for iOS or v3.20101.19+ Android devices. Check the version in the **About** section of the app.
- Enabled notifications in your device settings for the Field Service (Dynamics 365) mobile app.
- Review and agree to the [privacy notes for Field Service push notifications](mobile-push-notifications-privacy.md).

## Turn on push notifications included with Field Service

Field Service includes a template to enable push notifications for new bookings. You can also [create push notifications based on custom triggers](#create-a-custom-push-notification).

Configure the following cloud flow to send frontline workers a push notification on their mobile device when they are booked for a work order.

1. Sign in to [Power Apps](https://make.powerapps.com) and select the environment with your Field Service installation.

1. In the left pane, select **Solutions**. From the list of solutions, select the **Default Solution**.

1. Edit the **Field Service Push Notification Connection**. In the **Connection** field, create and add the **Power Apps Notification V2** connection.

   :::image type="content" source="media/mobile-2020-push-connection2.png" alt-text="Edit pane for Field Service Push Notification connection reference.":::

1. Edit the **CDS Connection Reference** and make sure it's enabled for your environment.
   <!-- Jon: What connection to choose here? Flows looks like they are enabled by default but the connection field is empty. -->

1. In the **Solutions** area edit the solution with the name `msdyn_FieldService_patch_update`.

   <!-- Jon: Seems here's where the flow breaks because the solution is managed. -->
   <!-- Jon: Does the user have to create a new solution, add connection references to it that we listed above, then import the solution to their environment? -->

   > [!div class="mx-imgBorder"]
   > ![Power Apps showing the Field Service solution in the list of solutions.](./media/mobile-2020-push-solution.png)

1. Find the cloud flow called **Field Service – Notify user about booking (UCI app)** and select the **Turn On** option.

   <!-- Jon: I can do that in the managed solution. -->

   > [!div class="mx-imgBorder"]
   > ![Power Apps showing the flow called "Field Service – Notify user about booking (UCI app)".](./media/mobile-2020-push-turn-on-flow.png)

1. Open the details for the **Field Service – Notify user about booking (UCI app)** cloud flow and make sure the **Connection References** section contains both the **CDS Connection Reference** and the **Field Service Push Notification Connection**.

> [!div class="mx-imgBorder"]
> ![Power Automate, showing the "Connection References" section on the flow record.](./media/mobile-2020-push-connection4.png)

<!-- Jon: Image outdated, needs CDS connection fixed in my env to update. Also, is the note below required? Seems like an odd tipp. -->

> [!NOTE]
> If the **Connection References** are not listed, repeat the previous steps in this article in a new private web browser window.

## Test push notifications

Schedule a work order to a frontline worker that has a user set up for the mobile app.

Within 60 seconds, you should receive a push notification from the Field Service mobile app.

## Create a custom push notification

### 1. Go to Power Automate and create a new flow

Go to Power Automate and select **Create**. Start from blank or a template to create a flow based on your needs.

> [!div class="mx-imgBorder"]
> ![Power Apps showing a list of flows.](./media/mobile-push-notifications-create.png)

### 2. Use any of the available connector triggers

Power Automate supports hundreds of pre-built connectors that can be used to trigger and provide data to the push notifications. You can use any of these triggers to send targeted push notifications to the desired set of users.

For the next example, we use the Common Data Service (current environment) connector with the *When a record is created, updated, or deleted* trigger so that we can notify the relevant user when a new record has been created. 

> [!div class="mx-imgBorder"]
> ![Power Automate, showing a trigger.](./media/mobile-2020-push-notification-step1.png)

### 3. Get bookable resources

From the bookable resource booking, get the associated resource value. This value is the resource the booking was scheduled to.

> [!div class="mx-imgBorder"]
> ![Power Apps showing a Power Automate flow for Field Service push notifications.](./media/mobile-2020-push-notification-step2.png)


### 4. Create condition (optional)

Isolate resources that have **Resource Type** set to *User*. Isolating these resources makes it so push notifications are only sent to resources who are users, rather that resources that represent equipment, pools, and contractors. 

> [!div class="mx-imgBorder"]
> ![Push notifications flow in Power Apps, showing the condition that isolates user-type resources.](./media/mobile-2020-push-notification-condition.png)


### 5. Get users 

From the resources, get the associated user values. Technicians sign into the mobile app with their Dynamics 365 user credentials, so this step is necessary to send push notifications to the appropriate users.

> [!div class="mx-imgBorder"]
> ![Power Apps showing a Power Automate flow, showing the step in the flow that gets associated user values.](./media/mobile-2020-push-notification-step3.png)


### 6. Get work orders (optional)

In order to include work order information in the push notification message, configure the flow to get work orders. 

> [!div class="mx-imgBorder"]
> ![Push notifications flow in Power Apps, showing the condition that fetches work order information.](./media/mobile-2020-push-notification-step4.png)


### 7. Add the push notification action

The **Power Apps Notifications v2** connector includes the *Send a push notification V2* action. Add this action as a step in your flow and enter the necessary information to configure the push notification, using any of the dynamic data provided by earlier steps.

In the following screenshot, we create a push notification to the Field Service technician (bookable resource) when a new booking has been assigned. The push notification, when selected, will open the booking resource booking record on the booking and work order form. 

> [!div class="mx-imgBorder"]
> ![Power Automate, showing the push notification configurations.](./media/mobile-2020-push-notification-notificaton.png)

To send a message to the Field Service (Dynamics 365) mobile app, make sure the following fields are configured:

- Mobile app: Field Service
- Your app:  Field Service Mobile

If you want to redirect the technician to the new booking and work order form, configure these fields:

- Open app: Yes
- Entity: Bookable Resource Booking
- Form or view:  Form – Booking and Work Order
- Record ID: Bookable Resource Booking

Use these fields to provide a custom message:

- Recipient Items: The desired set of recipients for the notification
- Message: The notification message.

### 8. View in the Field Service (Dynamics 365) mobile app

Download the Field Service (Dynamics 365) mobile app from the app store.

When the app launches, accept the prompt to receive notifications. Otherwise, enable notifications in your devices settings. 

The push notifications will be shown to the technician using the mobile phone. Field technicians do not need to be in the app or using their device to receive push notifications.

> [!div class="mx-imgBorder"]
> ![A mobile phone push notification from Field Service.](./media/mobile-2020-push-notification-result-wf.png)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
