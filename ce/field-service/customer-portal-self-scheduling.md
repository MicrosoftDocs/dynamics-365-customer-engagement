---
title: Enable self-scheduling service appointments in Dynamics 365 Field Service (preview)
description: Learn how to allow customers to schedule work orders via a customer portal in Dynamics 365 Field Service.
ms.date: 08/15/2024
ms.topic: how-to
author: m-hartmann
ms.author: mhart
search.app:
  - D365CE
  - D365FS
---

# Enable self-scheduling service appointments in Dynamics 365 Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

This article discusses the main scenarios for users of the self-scheduling portal.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Access and view the home page

The portal requires users to create a portal profile before they can sign in and book services.

1. Open the link you received in the invite.

   :::image type="content" source="media/SS-Portal-Login.svg" alt-text="The Field Service customer portal sign-in screen.":::

1. Select the **Redeem invitation** tab and use the code you received in email.
1. Create your profile for the portal.
1. Optionally, select **Manage external authentication** to sign in with other identity providers.
1. Save the profile and sign in to the self-service scheduling portal.
1. Schedule services on the portal. An email is sent confirming your booking.

## Book an appointment

1. Sign in to the portal. On the home page, select **Book a New Appointment**.
1. Choose the product and service type.
1. Choose a date and time. When you select a day, available time slots show automatically.
1. Provide optional comments about the appointment or service.
    > [!div class="mx-imgBorder"]
    > ![Self-scheduling page of the customer experience portal, showing booking options.](./media/homepage-self-scheduling-with-selected.jpg)
1. Select **Book** to create the appointment.

## Modify an appointment

You can change an appointment in the portal by choosing a new date and time, or canceling it.

1. Sign in to the portal and select **Modify** on an existing appointment.
1. Choose a new date and time, and save your changes.
1. To cancel the service visit, select **Cancel appointment** and provide a note about the reason.

## View different states of the booking on the portal

### Traveling

Appointments in the **Traveling** state mean the technician is on their way to a service appointment. Appointments set to **Traveling** appear in the **Active appointment** section on the portal home page.

If [technician tracking is turned on](customer-portal-technician-tracking.md), the portal shows the technician's location on a map. To see the location, select **View Live Map**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the customer portal showing active technician details.](./media/TMT-Desktop-Traveling.png)

If multiple appointments are set to traveling, only one appears in the **Active appointment**. The other active appointments are listed in the **Upcoming appointments** section, but you can select **View Live Map**.

> [!div class="mx-imgBorder"]
> ![Active appointments in the customer experience portal.](./media/homepage-homepage-with-1-booking-in-travelling-state-which-has-link-to-tmt.jpg)

> [!NOTE]
> Technicians must [share their location from the Field Service mobile app](mobile/track-technician-location.md) for location tracking and the estimated travel time. There's a small delay between their actual location and the location on the map. The delay can increase with limited network coverage of the technician's mobile device.

### In Progress

Appointments set to **In Progress** appear in the **Upcoming appointments** section of the portal home page. Appointments in progress can't be changed or canceled.

### Scheduled

Scheduled appointments show in the **Upcoming appointments** section. You can change or cancel scheduled appointments.

> [!div class="mx-imgBorder"]
> ![List of upcoming scheduled appointments in the customer experience portal.](./media/homepage-homepage-with-upcoming-bookings.jpg)

### Canceled or completed

Canceled and completed appointments move to the **Past appointments** tab. [Optional surveys](create-configure-customer-portal.md) to send feedback show on completed appointments.

> [!div class="mx-imgBorder"]
> ![List of past appointments in the customer experience portal, showing the option to send feedback.](./media/homepage-past-bookings-with-send-feedback-option-for-completed-bookings.jpg)

## Manually send an invite to a contact

Before customers can use the Field Service portal, make sure you [configured the portal settings](create-configure-customer-portal.md) and enabled notifications.

1. Sign in to Field Service.
1. Open a contact record and select **Create Invitation**.
1. On the contact record, select **Related** > **Web Roles**.
1. Select **Add Existing Web Role** and choose the **Web API User** role.
1. Select **Add** and save the changes.

## Advanced user notification scenarios

### Receive a new self-scheduling invite for contacts that were deleted and added again

A contact with a matching email only receives the portal invite once, even if the contact is deleted and readded to the system. To resent in invite:

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.com) and select your organization's environment.
1. Select **Power Apps** and then select **Portal Management**.
1. Select **Contacts** and open the newly created contact record.
1. On the command bar, select **Create Invitation**. Fill in any additional information and select **Save**.
1. Select **Advanced** and copy the *Invitation code*.
1. Select **Related** > **Web Roles** and select **Add existing web role**.
1. Select the **Web Api Users** web role.
1. Send the invite code and the portal link to the desired contact.

From the portal side:

1. Open your self-scheduling portal and go to the sign-in screen.
1. Select **Redeem invitation**.
1. Paste the invite code and create a portal account.

### Receive a password reset email

Make sure you have the correct [business process flow](/power-automate/create-business-process-flow) enabled for this functionality.

1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Select **Solutions** and your organization's solution.
1. Under **Objects**, select **Processes**.
1. Search for and open **Send Password Reset to Contact**. Scroll down and select **View Properties**.
1. Edit the **From** field for a user. Typically the same account you use to send notifications for the scheduling experience. Then, select **Save and Close**.
1. Sign in to the [Power Platform admin center](https://admin.powerplatform.com) and select your organization's environment.
1. Select **Settings** > **Email** > **Mailboxes**.
1. Select the user you set in step 5, select **Approve Email**, and then select **Test & Enable Mailbox**.

> [!div class="mx-imgBorder"]
> ![Field Service process edit page, showing the "Send Password Reset to Contact" process.](./media/SS-Process-sendemail.PNG)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
