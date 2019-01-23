---
title: "Push Notifications | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/22/2019
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

# Push Notifications


common examples:

## Prerequisites

Field Service v7.5.5 or v8.3+  

Field Service Mobile v11.1+ for Windows, iOS, or Android devices. You can verify your mobile app version in the **About** section

You have consented to notifications in your device's settings for the **Field Service Mobile** app

## Verify push notifications are activated

Navigate to **Settings > Solutions** and verify the **Field Service Mobile Push Notifications** solution is installed. If it is not installed you will need to upgrade to the Field Service v8.3+ solution that it is included in.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-solution.png)

Part of this solution is a workflow titled **Notify user about booking** that must be **Activated**. If it is not activated navigate to the default solution or an unmanaged solution via **Settings > Customizations > Customize the system > Processes** and activate it.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-solution-details.png)

## Schedule a work order and view push notifications

Create a bookable resource to schedule work orders to and that you would like to receive push notifications. This is done in **Field Service > Resources**

This bookable resource must have a **Resource Type** of **User**.

Verify you can log into the Field Service Mobile app with the user record and credentials related to the bookable resource.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-login.png)

Schedule a work order to your bookable resource.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-schedule-board.png)

Shortly thereafter a push notification will display on your device. In the image below a banner notification is displayed on our Windows device.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-banner.png)

The push notification is also displayed in the Windows Notification Center. This is true for iOS and Android devices as well.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-notification-center.png)

Selecting or tapping the notification will open the booking record.


## Create a custom push notification

An organization may want to create a custom push notification that displays a different message or relates to a different entity than Bookable Resource Booking.

> [!Note]
> Do not edit the out of the box **Notify user about booking** process. Instead deactivate it and create a new one using it as a template.

Navigate to **Settings > Customizations > Customize the system > Processes > +New**

Set **Category** to **Workflow** 

For **Entity** select the entity that should be opened when the push notification is selected.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-custom-workflow1.png)

To add push notifications into your workflow, click **Add Step > Field Service Mobile > Entity Push Notification**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-custom-workflow2.png)

Then select **Set Properties**.
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-custom-workflow3.png)

Here you will enter the details of the push notification message.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-custom-workflow4.png)


**Message:** enter the message displayed in the push notification. 

**Category:** **ViewRecord**

**User:** enter the user the push notification will be sent to. As an example, enter the following for push notifications related to  (User(Resource)(Bookable Resource))

**Team:** enter the team the push notification will be sent to.

**Pro Tip:** You can use the out of the box workflow process as a reference, seen in the image below, .

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-workflow-template.png)






## Configuration considerations

## Additional Notes

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-push-notification-entity-not-found.png)
