---
title: Collaborate in mixed reality with Field Service and Remote Assist
description: Learn how to collaborate in mixed reality by integrating Dynamics 365 Field Service with Dynamics 365 Remote Assist.
ms.date: 04/05/2024
ms.topic: how-to
author: josephshum-msft
ms.author: jshum
---

# Collaborate in mixed reality with Field Service and Remote Assist

> [!TIP]
> To collaborate with other users including annotating in their environment, see [Use Teams mobile to annotate in a user's environment (preview)](annotate-teams-mobile.md).

If your organization uses Dynamics 365 Field Service to manage field service work orders, your frontline workers can see their Field Service bookings and quickly call a remote collaborator using Dynamics 365 Remote Assist.

By integrating Field Service and Dynamics 365 Remote Assist, you can:

- Launch the Remote Assist mobile app directly from bookings on the Field Service mobile app via deep links.
- See relevant work order information.
- Post the Remote Assist call information to the associated work order's timeline.

In this article, we explore how a field technician can use the Remote Assist mobile app to call an expert for help with completing a work order. We also explore the requirements to set up and use Remote Assist and Field Service on a HoloLens.

<!--
For a guided walkthrough, see the following video.

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RE4yt5l]
-->
## Prerequisites

Before you begin, make sure you have the following set-up:

- [A Dynamics 365 Field Service subscription](buy-fs.md).
- [Dynamics 365 Field Service mobile app installed](mobile/set-up-field-service-mobile.md).
- [Dynamics 365 Remote Assist mobile app installed](/dynamics365/mixed-reality/remote-assist/deploy-remote-assist#download-and-install-the-app).
- At least two bookable resources with resource type *User*. One for the technician (frontline worker) and another for the remote collaborator. Both users need a Field Service license, which gives them access to Remote Assist too. For more information about setting up users and assigning licenses, see [Set up users and security roles](view-user-accounts-security-roles.md).

## Enable the Dynamics 365 integration on the Remote Assist mobile app

To enable the integration, sign in to the Remote Assist mobile app with the credentials you use for the Field Service mobile app.

After signing in, enable Dynamics 365 integration. Select **Enable feature** from the popup, or turn it on in **Settings**.

> [!div class="mx-imgBorder"]
> ![Screenshot of two mobile devices in Dynamics 365 Remote Assist. The screen on the left shows the Dynamics 365 integration popup option. The screen on the right shows the settings screen for Dynamics 365 Remote Assist, with the Dynamics 365 integration toggle set to on.](./media/remote-assist-field-service-ram-signin-ALL.png)

## Launch Remote Assist from the Field Service mobile app

When a technician signs in to the Field Service mobile app, they see their planned work for that day. To talk to a remote collaborator, they can launch the Dynamics 365 Remote Assist mobile app from the work order.

Select **More options** (&hellip;) and choose **Remote Assist**.

> [!div class="mx-imgBorder"]
> ![Screenshot of four mobile devices and the workflow that brings up the Dynamics 365 Remote Assist launching option.](./media/remote-assist-booking-deeplink.png)

## Make a Dynamics 365 Remote Assist call

By default, the app suggests calling the support contact listed on the work order. You can search through the directory for other users.

The remote collaborator receives the call, like any other Teams call.

The technician can share what they see through their mobile device's camera, making annotations as needed. The remote collaborator can make annotations in Teams. For more information, see [Annotate the technician's shared environment](/dynamics365/mixed-reality/remote-assist/mobile-app/annotate-shared-environment).

For more information about making calls, see [Make calls between Dynamics 365 Remote Assist mobile and Microsoft Teams](/dynamics365/mixed-reality/remote-assist/mobile-app/remote-assist-mobile-to-teams-calls).

## Post a Remote Assist call log

After the technician ends the call, they can [post the call as an activity to the work order timeline](/dynamics365/mixed-reality/remote-assist/mobile-app/fs-integration).

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365 Remote Assist on a mobile device, showing the option to select a booking to post to.](./media/remote-assist-field-service-call-post-to-work-order-choose-BOTH.png)

Documenting the Remote Assist calls can help your organization better understand challenging issues and react to them.

## Set up Field Service for the HoloLens

If a technician is equipped with a HoloLens, they can view and interact with bookings and work order on their mixed reality device.

For more information, see [Update a Field Service booking in Remote Assist on HoloLens](/dynamics365/mixed-reality/remote-assist/update-field-service-booking-hololens).

For more information about using the Remote Assist on HoloLens, see [Overview of Remote Assist on HoloLens](/dynamics365/mixed-reality/remote-assist/overview-hololens).

## Access the Remote Assist calls dashboard from Field Service

Field Service provides a quick [access to the calls dashboard](/dynamics365/mixed-reality/remote-assist/calls-dashboard).

In the **Service** area, under **Mixed Reality Apps**, select **Calls dashboard** to open the dashboard.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
