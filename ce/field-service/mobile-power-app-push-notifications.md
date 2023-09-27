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

In the Field Service (Dynamics 365) mobile app, push notifications send updates to technicians through their mobile phones or tablets. Push notifications use Microsoft Power Automate and support many scenarios. For example, to notify about a newly assigned booking or as a reminder to capture and enter important data.

There are two ways to enable push notifications for your organization.

1. Enable the push notification cloud flow included with Dynamics 365 Field Service. The included push notification notifies technicians when they have been assigned a booking.

1. Create a custom push notification based on custom triggers using the **Send Push Notification V2** connector in Power Automate.

## Prerequisites

- A license and permissions for [Power Automate](https://flow.microsoft.com/).
- At least Field Service (Dynamics 365) mobile app v13.20101.19+ for iOS or v3.20101.19+ Android devices. Check the version in the **About** section of the app.
- Enabled notifications in your device settings for the Field Service (Dynamics 365) mobile app.
- Review and agree to the [privacy notes for Field Service push notifications](mobile-push-notifications-privacy.md).

## Turn on push notifications included with Field Service

Field Service includes a template to enable push notifications for new bookings. You can also [create push notifications based on custom triggers](#create-a-custom-push-notification).

Configure the following cloud flow to send frontline workers a push notification on their mobile device when they're booked for a work order.

1. Sign in to [Power Apps](https://make.powerapps.com) and select the environment with your Field Service installation.

1. In the left pane, select **Solutions**. From the list of solutions, select the **Default Solution**.

1. Create two new connection references:
   - **Field Service Push Notification Connection**, using the **Power Apps Notification V2** connector.
   - **Dataverse Connection Reference**, using the **Microsoft Dataverse** connector.

   For both connection references, add a new connection and make sure they are enabled.

   :::image type="content" source="media/mobile-2020-push-connection2.png" alt-text="Edit pane for Field Service Push Notification connection reference.":::

1. In the Solutions area, edit the solution with the name `msdyn_FieldService_patch_update`.

1. Find the cloud flow called **Field Service – Notify user about booking (UCI app)** and select the **Turn On** option.

   :::image type="content" source="media/mobile-2020-push-turn-on-flow.png" alt-text="Power Apps showing the flow called Field Service – Notify user about booking (UCI app).":::

1. Open the details for the **Field Service – Notify user about booking (UCI app)** cloud flow. Make sure the **Connection References** section contains both connection references that you created in step 3.

## Test push notifications

Schedule a work order to a frontline worker that has a user set up for the mobile app.

Within 60 seconds, you should receive a push notification from the Field Service mobile app.

## Create a custom push notification

You can create push notification with custom triggers to match your business scenarios. The following steps outline an example flow that sends a push notification to users of the mobile application when they get a new booking assigned. The notification includes the work order associated to the booking.

1. Sign in to [Power Automate](https://make.powerautomate.com/) and select **Create**. Power Automate supports hundreds of connectors that can be used to trigger and provide data to the push notifications. You can use any of these triggers to send targeted push notifications to the desired set of users.

1. Select **Automated cloud flow**, give your flow a Name and choose the Microsoft Dataverse  connector. For this example, we use the Dataverse connector that triggers **When a row is created, updated, or deleted**.

   > [!div class="mx-imgBorder"]
   > ![Power Automate, showing a trigger.](./media/mobile-2020-push-notification-step1.png)

1. Choose the trigger options. In this example, we choose *Added*, *Bookable Resource Booking*, and *Organization*.

1. Add another step and choose the **Get row by ID** option to get the associated resource value. Set the table name to *Bookable Resource* and the Row ID to *Resource (Value)*.

   > [!div class="mx-imgBorder"]
   > ![Power Apps showing a Power Automate flow for Field Service push notifications.](./media/mobile-2020-push-notification-step2.png)

1. Add a condition. For our example, we want to send notifications to users, rather than resources that represent equipment, pools, and contractors. Set the condition to *Resource Type* is equal to *User (Type)*.

1. When the condition matches, we need the associated user values. Technicians sign into the mobile app with their Dynamics 365 user credentials. This step ensures that push notifications go to the appropriate users. In the **If yes** box, add a **Get row by ID** option and choose the *User (Value)* row from the *Users* table.

   > [!div class="mx-imgBorder"]
   > ![Power Apps showing a Power Automate flow, showing the step in the flow that gets associated user values.](./media/mobile-2020-push-notification-step3.png)

1. To include work order information in the push notification message, configure the flow to get work orders. Add another **Get row by ID** option and choose the *Work Order (Value)* row from the *Work Orders* table.

1. With all information available and the flow logic defined, it's time to add the **Send push notification V2** action.

1. Enter the necessary information to the action:

   - Mobile app: Field Service
   - Your app:  Field Service Mobile

   To redirect the technician to the new booking and work order form:

    - Open app: Yes
    - Entity: Bookable Resource Booking
    - Form or view:  Form – Booking and Work Order <!-- Jon: This form doesn't exist. Instead: Form - Booking and Work Order. -->
    - Record ID: Bookable Resource Booking

   To provide a custom message:

    - Recipients Item: Primary email  <!-- this was generic before, set to email as in screenshot -->
    - Message: The notification message.

1. The push notifications on the technician's mobile phone. They don't need to have the app open or use their device to receive push notifications.

> [!div class="mx-imgBorder"]
> ![A mobile phone push notification from Field Service.](./media/mobile-2020-push-notification-result-wf.png)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
