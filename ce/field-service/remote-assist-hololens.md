---
title: "Collaborate in mixed reality with Field Service, Dynamics 365 Remote Assist, and HoloLens | MicrosoftDocs"
description: Learn how to collaborate in mixed reality by integrating Dynamics 365 Field Service with Dynamics 365 Remote Assist.
ms.custom: dyn365-fieldservice
ms.date: 01/14/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
author: FieldServiceDave
ms.author: daclar
ms.manager: shellyhaverkamp
search.app: 
  - D365CE
  - D365FS
---


# Collaborate in mixed reality with Field Service, Dynamics 365 Remote Assist, and HoloLens

If your organization uses Dynamics 365 Field Service to manage field service work orders, your first-line workers using Dynamics 365 Remote Assist on HoloLens can see their Field Service bookings and quickly call the remote collaborator listed in the booking's **Support Contact** field. 

By integrating Field Service and Dynamics 365 Remote Assist, you can: 

- Launch Dynamics 365 Remote Assist mobile directly from a Field Service Mobile booking via deep links.
- See relevant work order information.
- Post the Dynamics 365 Remote Assist call information to the associated work order's timeline.

In this article, we'll explore how a field technician can use the Dynamics 365 Remote Assist mobile app to make a call to an expert for help with completing a work order. We'll also explore the requirements to set up and use Dynamics 365 Remote Assist and Field Service together on the HoloLens.

For a guided walkthrough, see the following video.

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RE4yt5l]

## Prerequisites

Before you begin, make sure you have the following set-up:

- A Microsoft Azure tenant with a Dynamics 365 subscription **and** a Dynamics 365 Remote Assist subscription. Both are required—Dynamics 365 Remote Assist is not included in any Dynamics 365 bundle.

  > [!NOTE]  
  > The tenant can have more than one Dynamics 365 instance. Dynamics 365 Remote Assist has the option to select an instance from within the app.

- You must have admin access to add or update the Dynamics 365 tenant instance.

- The Dynamics 365 instance must have the Dynamics 365 Field Service app installed, and it must include the **My Bookings for Today** view. To make sure this view is installed, we recommend Field Service version 8.2 or later. This article describes how to make sure you have the correct version and view.
    -  Note the **My In Progress Bookings** view has been renamed to **My Bookings for Today.** This doc has been updated to reflect the name change. Depending on your version of Field Service, you may see either name. The functionality remains the same regardless of the view name.
- The tenant must have at least two user accounts - one for the technician (front-line worker) and another for the remote collaborator.
  - The remote collaborator only needs a Microsoft Teams license.
  - The technician user will need a Dynamics 365 Field Service license, a Microsoft Teams license, _and_ a Dynamics 365 Remote Assist license. **Note:** A Dynamics 365 Remote Assist license includes Teams. 

- Field Service Mobile (only applicable if technicians and front line workers are not using HoloLens headsets). 


## Set up technician user

First, create a bookable resource that will serve as the technician or front line worker that will use both Field Service on the Field Service Mobile app and Dynamics 365 Remote Assist on the Dynamics 365 Remote Assist mobile app on their phone or tablet.

> [!div class="mx-imgBorder"]
> ![Screenshot of a bookable resource in Field Service on a desktop](./media/remote-assist-field-service-resource.png)

The bookable resource must have a **Resource Type** set to **User**; the related user record will need licenses to use both Field Service and Remote Assist. 

To set up a field technician to use the Field Service mobile app, see the Field Service docs articles on:

1. [Setting up Field Service users and security roles](https://docs.microsoft.com/dynamics365/field-service/view-user-accounts-security-roles#set-up-a-field-technician-user) 
2. [Install and setup the mobile app](mobile-power-app-get-started.md)

Verify you can log into the Field Service mobile app successfully as the field technician user.

> [!div class="mx-imgBorder"]
> ![Screenshot of a Field Service Mobile after logging in.](./media/mobile-power-download-signin.png)
 
Next, verify you can log into the Dynamics 365 Remote Assist mobile app with the same user. Then:

Find and download the Dynamics 365 Remote Assist mobile app in the Apple iOS or Google Android app stores. 

Sign in as the same user that you logged in to Field Service Mobile with. If your technician has a Field Service license and a Teams license, then you can simply start a free trial of Dynamics 365 Dynamics 365 Remote Assist before buying. 

> [!div class="mx-imgBorder"]
> ![Screenshot of three mobile devices, showing the Dynamics 365 Remote Assist app in an app store on the left. The middle device shows a logged in user. The device on the right shows a window prompting to get a free trial of Dynamics 365 Remote Assist.](./media/remote-assist-field-service-start-remote-assist-trial.png)

After signing in, make sure you enable Dynamics 365 integration. Select **Enable** from the popup, or go to **Settings**.

> [!div class="mx-imgBorder"]
> ![Screenshot of two mobile devices in Dynamics 365 Remote Assist. The screen on the left shows the Dynamics 365 integration popup option. The screen on the right shows the settings screen for Dynamics 365 Remote Assist, with the Dynamics 365 integration toggle set to on.](./media/remote-assist-field-service-ram-signin-ALL.png)


> [!Note]
> The Dynamics 365 Remote Assist mobile app is available on mobile devices running iOS and Android with the related ARkit or ARcore capabilities.
 

## Set up remote collaborator user

As a different user that you have identified as the remote collaborator, verify you can sign in to Microsoft Teams. This user does not need a Field Service or Dynamics 365 Remote Assist license.
   
> [!div class="mx-imgBorder"]
> ![Screenshot of Teams on desktop.](./media/remote-assist-field-service-teams-signin.png)

> [!Note]
> The remote collaborator must log into the Microsoft Teams native app on his or her PC or mobile device. Teams on web is not supported.

## Create and schedule work orders

Next, create a work order to outline the onsite work the technician or front line worker needs to perform - typically an installation or an equipment or system repair. Enter a recommended expert in the **Support Contact** field that could be called via Dynamics 365 Remote Assist for support. Technicians won't be limited to only calling this contact.

> [!div class="mx-imgBorder"]
> ![Screenshot of a Field Service work order in a desktop, with attention to the support contact field.](./media/remote-assist-field-service-work-order-support-contact.png)

Schedule the work order to the bookable resource that represents the technician also known as the front line worker who travels to customer locations to complete work orders. In our example, Abraham McCormick is the bookable resource and we scheduled work orders to them with resource scheduling optimization.

> [!div class="mx-imgBorder"]
> ![Screenshot of Abraham McCormick's booked work order on the Field Service schedule board, in a desktop window.](./media/remote-assist-field-service-work-order-schedule.png)


## View work orders and trigger Remote Assist from the Field Service mobile app

Like any typical day, the technician logs in to Field Service Mobile and sees their assigned work orders for that day. If they need guidance from a remote collaborator who better knows the product, service, equipment, or account being serviced, they can launch the Dynamics 365 Remote Assist mobile app from the work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of four mobile devices showing Field Service Mobile, and the workflow that brings up the Dynamics 365 Remote Assist launching option.](./media/remote-assist-booking-deeplink.png)

> [!Note]
> The deep link from Field Service Mobile to the Dynamics 365 Remote Assist mobile app is available on iOS and Android devices. For Field Service Mobile on iOS, your system administrator must import the [mobile project v1.0.4847 or later](https://docs.microsoft.com/dynamics365/field-service/field-service-version-history-mobile#104847). For Android devices, you must import the [mobile project v1.0.1322 or later](https://docs.microsoft.com/dynamics365/field-service/field-service-version-history-mobile#103482).

## Make a Dynamics 365 Remote Assist call

The support contact will be autoselected to call if Dynamics 365 Remote Assist was opened via the deep link; otherwise, the technician can search through the directory for Teams users inside or outside their organization.

> [!div class="mx-imgBorder"]
> ![Screenshot of a mobile device showing the Launch Call option on a contact in Dynamics 365 Remote Assist.](./media/remote-assist-field-service-launch-call.png)


The remote collaborator will then receive the call, like any other Teams call.

> [!div class="mx-imgBorder"]
> ![Screenshot of the incoming Dynamics 365 Remote Assist call to the remote collaborator, working in Teams desktop.](./media/remote-assist-field-service-receive-call-teams.png)

The technician can then begin to share what they see through their mobile device's camera, making annotations as needed.

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365 Remote Assist on a mobile device, showing an arrow annotation.](./media/remote-assist-field-service-call-annotation.png)

From Teams, the remote collaborator can also make annotations. 

## Post Dynamics 365 Remote Assist Call to work order

After gaining the necessary guidance from the remote collaborator, the technician will end the call and be given the option to post the call as an activity to the work order time line.

Technicians can choose from a list of bookings they are scheduled for on the day of the call, which matches the **Agenda** view in Field Service Mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365 Remote Assist on a mobile device, showing the option to select a booking to post to.](./media/remote-assist-field-service-call-post-to-work-order-choose-BOTH.png)

Back on the work order, the dispatcher can see a Dynamics 365 Remote Assist call took place in the work order timeline; there will be a call log and links to files shared during the call.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service on desktop, showing a work order with attention to the timeline, which now has a Dynamics 365 Remote Assist call listed.](./media/remote-assist-field-service-call-metadata-timeline.png)

Documenting the Dynamics 365 Remote Assist call on the work order is important because it lets managers know which types of issues are requiring extra help and can build training programs to accommodate.

## Set up and view Field Service bookings on HoloLens

If the technician is equipped with a HoloLens headset, then viewing and interacting with Field Service is even better. 

Technicians can:

- View today's bookings.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of Dynamics 365 Remote Assist on HoloLens, showing active Field Service bookings.](./media/remote-assist-field-service-bookings-HL2.png)

- View the work order and the recommended support contact field.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of Dynamics 365 Remote Assist on HoloLens, showing the support contact on the booking.](./media/remote-assist-field-service-bookings-HL.png)

- Attach images to the work order during the Dynamics 365 Remote Assist call so future stakeholders can see the work or problem.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of a user attaching an image in Dynamics 365 Remote Assist on HoloLens.](./media/remote-assist-field-service-save-image-HL.png)

- Update booking statuses, like marking work as complete.

  > [!div class="mx-imgBorder"]
  > ![Screenshot of Dynamics 365 Remote Assist on HoloLens, showing the option to change the status of the booking.](./media/remote-assist-field-service-bookings-status-HL.png)


### Set up Field Service for the HoloLens

1. Ensure you're using Field Service v8.2 or later. [Upgrade](https://docs.microsoft.com/dynamics365/field-service/upgrade-field-service#field-service) your solution if necessary. 
2. Confirm the **My Bookings for Today** view on the **Bookable Resource Booking** entity is included:

     - Go to **Field Service** > **Settings** > **Customizations** > **Customize the System**.

> [!Note]
> The **My In Progress Bookings** view has been renamed to **My Bookings for Today**. This doc has been updated to reflect the name change. Depending on your version of Dynamics 365 Field Service, you may see either name. The functionality remains the same regardless of the view name.

> ![Bookable Resource view](media/bookable-resource-views.PNG "Bookable Resource view")

> [!Note]
> Fields can be added to this view if necessary for your business needs.

3. Create and schedule a work order.

     - The booking will not appear in the Dynamics 365 pane in Dynamics 365 Remote Assist unless the booking status is **In progress** and the related bookable resource has a user record that matches the HoloLens user.

## Configuration considerations

### Use the Field Service mobile Power App

Technicians can deep link from the [Field Service (Dynamics 365) mobile app](mobile-2020-power-platform.md) to the Dynamics 365 Remote Assist mobile app. 
