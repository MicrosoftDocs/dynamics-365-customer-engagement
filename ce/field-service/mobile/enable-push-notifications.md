---
title: Enable push notifications
description: Learn how to enable push notifications for the Field Service mobile app.
ms.subservice: field-service-mobile
ms.topic: how-to
ms.date: 08/07/2025
author: JonBaker007
ms.author: jobaker
---

# Enable push notifications

In the Dynamics 365 Field Service mobile app, push notifications send updates to technicians through their mobile phones or tablets. Push notifications use Microsoft Power Automate and support many scenarios. For example, to notify about a newly assigned booking or as a reminder to capture and enter important data.

There are two ways to enable push notifications for your organization.

- [Enable the push notification cloud flow included with Dynamics 365 Field Service](#turn-on-push-notifications-included-with-field-service). The included push notification notifies technicians when they're assigned a booking.

- [Create a custom push notification](#create-a-custom-push-notification) based on custom triggers using the **Send Push Notification V2** connector in Power Automate.

## Prerequisites

- You have a license and permission for [Power Automate](https://flow.microsoft.com/).
- You enabled notifications in your device settings for the Field Service mobile app.
- You reviewed and agreed to the [privacy notes for Field Service push notifications](mobile-push-notifications-privacy.md).

## Turn on push notifications included with Field Service

Field Service includes a template to enable push notifications for new bookings.

Configure the following cloud flow to send frontline workers a push notification on their mobile device when they're booked for a work order.

1. Sign in to [Power Apps](https://make.powerapps.com) and select the environment with your Field Service installation.

1. In the left pane, select **Solutions**. From the list of solutions, select the **Default Solution**.

1. Select **New** > **More** > **Connection Reference**.

1. Create a connection reference called **Field Service Push Notification Connection**. For more information, go to [Manually add a connection reference](/power-apps/maker/data-platform/create-connection-reference#manually-add-a-connection-reference-using-solution-explorer).

   - **Display name**: Field Service Push Notification Connection
   - **Connector**: Power Apps Notification V2
   - **Connection**: New connection

   > [!TIP]
   > The **Name** field automatically fills in when you enter the **Display name**.

1. Go back to the **New Connection Reference** pane, select **Refresh**, and select the new connection.

1. Select **Create**.

   :::image type="content" source="../media/mobile-2020-push-connection2.png" alt-text="Edit pane for Field Service Push Notification connection reference.":::

1. Follow steps 3 - 6 and create a connection reference called **Dataverse Connection Reference**.

   - **Display name**: Dataverse Connection Reference
   - **Connector**: Microsoft Dataverse
   - **Connection**: New connection

1. Go back to **Solutions**, select the **All** tab, and edit the solution with the name `msdyn_FieldService_patch_update`.

1. Open the details of the cloud flow called **Field Service – Notify user about booking (UCI app)**.

1. Select the **Save as** option to create a copy of the cloud flow and [add it to an unmanaged solution](/power-apps/maker/data-platform/create-solution).

1. In the unmanaged solution, select the **Turn On** option for your new cloud flow.

1. Open the details for the **Field Service – Notify user about booking (UCI app)** cloud flow. Make sure the **Connection References** section contains both connection references that you created.

## Test push notifications

Schedule a work order to a frontline worker that has a user set up for the mobile app.

Within 60 seconds, you should receive a push notification from the Field Service mobile app.

## Create a custom push notification

You can create push notification with custom triggers to match your business scenarios. The following steps outline an example flow that sends a push notification to users of the mobile application when they get a new booking assigned. The notification includes the work order associated to the booking.

1. Sign in to [Power Automate](https://make.powerautomate.com/) and select **Create**. Power Automate supports hundreds of connectors that can be used to trigger and provide data to the push notifications. You can use any of these triggers to send targeted push notifications to the desired set of users.

1. Select **Automated cloud flow**, enter a name, and choose the Microsoft Dataverse connector. For this example, we use the Dataverse connector that triggers **When a row is created, updated, or deleted**.

1. Choose the trigger options. In this example, select:
   - **Change type**: Added
   - **Table name**: Bookable Resource Bookings
   - **Scope**: Organization

1. Add another step and choose the **Get a row by ID** option to get the associated resource value.
   - **Table name**: Bookable Resources
   - **RowID**: Resource (Value)

1. Add a condition. We want to send notifications to users, rather than resources that represent equipment, pools, and contractors. In this example, select: **Resource Type** is equal to **User (Type)**.

1. When the condition matches, we need the associated user values. Technicians sign into the mobile app with their Dynamics 365 user credentials. This step ensures that push notifications go to the appropriate users. In the **If yes** box, add a **Get a row by ID** option. Select:
   - **Table name**: Users
   - **RowID**: User (Value)

1. To include work order information in the push notification message, configure the flow to get work orders. Add another **Get a row by ID** option. Select:
   - **Table name**: Work Orders
   - **RowID**: Work Order (Value)

   :::image type="content" source="../media/power-automate-custom-flow.svg" alt-text="Custom flow in Power Automate that triggers a push notification in the Field Service mobile app.":::

1. With all information available and the flow logic defined, add the **Send push notification V2** action. Select:
   - **Mobile app**: Field Service
   - **Your app**:  Field Service Mobile

   To provide a custom message:

    - **Recipients Item**: Primary email
    - **Message**: The notification message

   To redirect the technician to the new booking and work order form:

    - **Open app**: Yes
    - **Entity**: Bookable Resource Booking
    - **Form**:  Form – Booking and Work Order
    - **Record ID**: Bookable Resource Booking

1. Select **Save**. The push notification shows on the technician's mobile phone. They don't need to have the app open or use their device to receive push notifications.

   :::image type="content" source="../media/mobile-2020-push-notification-result-wf.png" alt-text="A mobile phone push notification from Field Service.":::

> [!NOTE]
> When in [mobile offline mode](offline-data-sync.md), the device receives the push notification as soon as it has connectivity. Opening the push notification results in a sync to download the record if it's not available on the device. If the sync settings are set to [sync on Wi-Fi only](/power-apps/mobile/setup-mobile-offline#define-sync-settings-on-mobile), the app syncs the data, even if not on Wi-Fi, when a cellular connection is available.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
