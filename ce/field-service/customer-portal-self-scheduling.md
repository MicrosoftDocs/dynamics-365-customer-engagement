---
title: Enable self-scheduling service appointments in Dynamics 365 Field Service (preview)
description: Learn how to allow customers to schedule work orders via a customer portal in Dynamics 365 Field Service.
ms.date: 10/20/2025
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
ms.reviewer: puneetsingh
search.app:
  - D365CE
  - D365FS
---

# Enable self-scheduling service appointments in Dynamics 365 Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

This article explains the main scenarios for users of the self-scheduling portal.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Access and view the home page

The portal requires users to create a portal profile before they can sign in and book services.

1. Open the link you received in the invitation.

   :::image type="content" source="media/SS-Portal-Login.svg" alt-text="Screenshot of the Field Service customer portal sign-in screen.":::

1. Select the **Redeem invitation** tab, and enter the code you received in the email.
1. Create your profile for the portal.
1. Select **Manage external authentication** to sign in with other identity providers, if needed.
1. Save the profile and sign in to the self-service scheduling portal.
1. Schedule services on the portal. You receive an email confirming your booking.

## Book an appointment

1. Sign in to the portal. On the home page, select **Book a New Appointment**.
1. Choose the product and service type.
1. Choose a date and time. When you select a day, available time slots appear automatically.
1. Provide optional comments about the appointment or service.
    
    :::image type="content" source="./media/homepage-self-scheduling-with-selected.png" alt-text="Screenshot of self-scheduling page of the customer experience portal, showing booking options.":::

1. Select **Book** to create the appointment.

## Modify an appointment

Change an appointment in the portal by selecting a new date and time, or canceling it.

1. Sign in to the portal and select **Modify** on an existing appointment.
1. Select a new date and time and save your changes.
1. To cancel the service visit, select **Cancel appointment** and provide a note about the reason.

## View different states of the booking on the portal

### Traveling

Appointments in the **Traveling** state indicate the technician is traveling to a service appointment. Appointments set to **Traveling** appear in the **Active appointment** section of the portal home page.

If [technician tracking is turned on](customer-portal-technician-tracking.md), the portal shows the technician's location on a map. Select **View Live Map** to see the location.

:::image type="content" source="./media/TMT-Desktop-Traveling.png" alt-text="Screenshot of the customer portal showing active technician details.":::

If multiple appointments are set to **Traveling**, only one appears in the **Active appointment** section. The other active appointments are listed in the **Upcoming appointments** section. Select **View Live Map** to view their locations.

:::image type="content" source="./media/homepage-homepage-with-1-booking-in-travelling-state-which-has-link-to-tmt.png" alt-text="Screenshot of active appointments in the customer experience portal.":::

> [!NOTE]
> Technicians must [share their location from the Field Service mobile app](mobile/track-technician-location.md) to enable location tracking and estimated travel time. A slight delay exists between the technician's actual location and the location shown on the map, which might increase with limited network coverage of the technician's mobile device.

### In Progress

Appointments in the **In Progress** state appear in the **Upcoming appointments** section of the portal home page. These appointments can't be changed or canceled.

### Scheduled

Scheduled appointments appear in the **Upcoming appointments** section. Change or cancel scheduled appointments as needed.

:::image type="content" source="./media/homepage-homepage-with-upcoming-bookings.png" alt-text="Screenshot of a list of upcoming scheduled appointments in the customer experience portal.":::

### Canceled or completed

Canceled and completed appointments move to the **Past appointments** tab. [Optional surveys](create-configure-customer-portal.md) for sending feedback appear on completed appointments.

:::image type="content" source="./media/homepage-past-bookings-with-send-feedback-option-for-completed-bookings.png" alt-text="Screenshot of a list of past appointments in the customer experience portal, showing the option to send feedback.":::

## Manually send an invite to a contact

Before customers can use the Field Service portal, make sure you [configure the portal settings](create-configure-customer-portal.md) and enable notifications.

1. Sign in to Field Service.
1. Open a contact record, and select **Create Invitation**.
1. On the contact record, select **Related** > **Web roles**.
1. Select **Add Existing Web Role**, and choose the **Web API User** role.
1. Select **Add**, and save the changes.

## Advanced user notification scenarios

### Receive a new self-scheduling invite for contacts deleted and added again

A contact with a matching email only receives the portal invite once, even if the contact is deleted and readded to the system. To resend an invite:

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com) and select your organization's environment.
1. In **Resources**, select **Power Apps** and then select **Power Pages Management**.
1. In **Security**, select **Contacts** in the left pane, and open the newly created contact record.
1. On the command bar, select **Create Invitation**. Fill in any additional information and select **Save**.
1. Select **Advanced**, and copy the *Invitation code*.
1. In the General tab, go to **Assign To Web Roles**, and select **Add existing web role**.
1. Select the **Web API Users** web role.
1. Send the invite code and the portal link to the desired contact.

From the portal side:

1. Open your self-scheduling portal and go to the sign-in screen.
1. Select **Redeem invitation**.
1. Paste the invite code, and create a portal account.

### Receive a password reset email

Ensure the correct [business process flow](/power-automate/create-business-process-flow) is enabled for this functionality.

1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Select **Solutions** and your organization's solution.
1. Under **Objects**, select **Processes**.
1. Search for and open **Send Password Reset to Contact**. 
1. In the **Send Password Reset to Contact** window, scroll to **Send password reset email**, and select **View Properties**.
1. Edit the **From** field for a user, typically the same account you use to send notifications for the scheduling experience, and then select **Save and Close**.
   :::image type="content" source="./media/SS-Process-sendemail.PNG" alt-text="Screenshot of the Field Service process edit page showing the 'Send Password Reset to Contact' process."::: 
1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com) and select your organization's environment.
1. Select **Settings** > **Email** > **Mailboxes**.
1. Select the user you set in step 6, select **Approve Email**, and then select **Test & Enable Mailbox**.



[!INCLUDE [footer-include](../includes/footer-banner.md)]
