---
title: Collaborate in mixed reality with Field Service and Remote Assist
description: Learn how to collaborate in mixed reality by integrating Dynamics 365 Field Service with Dynamics 365 Remote Assist.
ms.date: 03/07/2025
ms.topic: how-to
author: josephshum-msft
ms.author: jshum
---

# Collaborate in mixed reality with Field Service and Remote Assist

> [!TIP]
> To collaborate with other users including annotating in their environment, go to [Use Teams mobile to annotate in a user's environment](annotate-teams-mobile.md).

If your organization uses Dynamics 365 Field Service to manage field service work orders, your frontline workers can see their Field Service bookings and quickly call a remote collaborator using Microsoft Teams.

In this article, we explore how a field technician can use Remote Assist to call an expert for help with completing a work order. We also explore the requirements to set up and use Remote Assist and Field Service on a HoloLens.

<!--
For a guided walkthrough, see the following video.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=cf44e193-bd97-449a-82d9-9fa7c2a3515a]
-->
## Prerequisites

Before you begin, make sure you have the following set-up:

- [A Dynamics 365 Field Service subscription](buy-fs.md).
- [Dynamics 365 Field Service mobile app installed](mobile/set-up-field-service-mobile.md).
- At least two bookable resources with resource type *User*. One for the technician (frontline worker) and another for the remote collaborator. Both users need a Field Service license, which gives them access to Remote Assist too. For more information about setting up users and assigning licenses, see [Set up users and security roles](view-user-accounts-security-roles.md).

## Launch Remote Assist from the Field Service mobile app

When a technician signs in to the Field Service mobile app, they see their planned work for that day. To talk to a remote collaborator, they can make a call from the work order.

Select **More options** (&hellip;) and choose **Remote Assist**. Calls are initiated through Teams.

> [!div class="mx-imgBorder"]
> ![Screenshot of four mobile devices and the workflow that brings up the Dynamics 365 Remote Assist launching option.](./media/remote-assist-booking-deeplink.png)

## Make a Dynamics 365 Remote Assist call

By default, the app suggests calling the support contact listed on the work order. You can search through the directory for other users.

The remote collaborator receives the call, like any other Teams call.

The technician can share what they see through their mobile device's camera, making annotations as needed. The remote collaborator can make annotations in Teams. For more information, see [Annotate the technician's shared environment](/dynamics365/mixed-reality/remote-assist/teams-mobile-annotate).

For more information about making calls, see [Collaborate with any user through Microsoft Teams mobile](/dynamics365/mixed-reality/remote-assist/teams-mobile-all).

## Set up Field Service for the HoloLens

If a technician is equipped with a HoloLens, they can view and interact with bookings and work order on their mixed reality device.

For more information, see [Update a Field Service booking in Remote Assist on HoloLens](/dynamics365/mixed-reality/remote-assist/update-field-service-booking-hololens).

For more information about using the Remote Assist on HoloLens, see [Overview of Remote Assist on HoloLens](/dynamics365/mixed-reality/remote-assist/overview-hololens).

## Access the Remote Assist calls dashboard from Field Service

Field Service provides a quick [access to the calls dashboard](/dynamics365/mixed-reality/remote-assist/calls-dashboard).

In the **Service** area, under **Mixed Reality Apps**, select **Calls dashboard** to open the dashboard.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
