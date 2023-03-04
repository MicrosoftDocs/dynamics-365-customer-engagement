---
title: Enable self-scheduling service appointments in Dynamics 365 Field Service (contains video) | MicrosoftDocs
description: Learn how to allow customers to schedule work orders via a customer portal in Dynamics 365 Field Service
ms.date: 09/07/2021
ms.topic: article
author: Deana-Fuller
ms.author: drfuller
search.app:
  - D365CE
  - D365FS
---

# Use the portal to schedule service appointments (preview)

This article discusses the main scenarios for users of the self-scheduling portal.

## Access and view the home page

<!--would like to repro this and take screenshots of initial screen and clarify if they can use different auth options -->

The portal requires users to create a portal profile before they can sign in and book services.

1. Open the link you received in the invite.

   > [!div class="mx-imgBorder"]
   > ![The Field Service customer portal sign-in screen.](./media/SS-Portal-Login.png)

1. Select the **Redeem invitation** tab and use the code you received in email.

1. Create your profile for the portal.

    > [!div class="mx-imgBorder"]
    > ![The customer portal contact profile screen.](./media/SS-Portal_Profile.png)

1. Optionally, select **Manage external authentication** to sign in with other identity providers.

1. Save the profile and sign in to the self-service scheduling portal.

1. Schedule services on the portal. You'll receive an email confirming your booking.

## Book an appointment

1. Sign in to the portal. On the homepage, select **Book a new appointment**.

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

 The map will show near real-time location of technician based on signal from the Field Service mobile application. 

> [!Note] 
> Technicians must be sharing their location from their Field Service mobile app to provide estimated travel time and display their near-real-time location on the portal. Under normal conditions, the technician location may be between 2-4 minutes off the location shown on the portal map. Latency between the technician's real-world location and location represented on the portal map may increase when in limited network areas or if there is disruption of the connection to the technician's mobile device. This latency may result in the technician being closer to the end location versus what is shown on the portal map.

> [!div class="mx-imgBorder"]
> ![Screenshot of the customer portal showing active technician details.](./media/TMT-Desktop-Traveling.png)

### Traveling

Appointments in the **Traveling** state mean the technician is on their way to a service appointment.

If technician tracking is turned on, customers can see the technician's location on a map. They can see the location by selecting **View Live Map**.

Appointments set to **Traveling** appear in the **Active appointment** section on the customer experience portal.
 
> [!div class="mx-imgBorder"]
> ![Active appointments in the customer experience portal.](./media/homepage-homepage-with-1-booking-in-travelling-state-which-has-link-to-tmt.jpg)

If there are multiple appointments set to traveling, only one will appear in the **Active appointment**. The other active appointments will be listed in the **Upcoming appointments** section, but the **View Live Map** option will appear.

> [!div class="mx-imgBorder"]
> ![Customer experience portal showing multiple active appointments.](./media/homepage-homepage-with-2-bookings-in-travelling-state.jpg)

### In Progress

Appointments set to **In Progress** appear in the **Upcoming appointments** section of the portal. Appointments set to **In Progress** can't be changed or canceled.

> [!div class="mx-imgBorder"]
> ![Upcoming appointments section of the customer experience portal, with an active appointment and a greyed out modify option.](./media/homepage-one-booking-in-travelling-and-1-in-progress.jpg)
 
### Scheduled

Scheduled appointments are listed in the **Upcoming appointments** section. Scheduled appointments can be modified or canceled.

> [!div class="mx-imgBorder"]
> ![List of upcoming scheduled appointments in the customer experience portal.](./media/homepage-homepage-with-upcoming-bookings.jpg)

### Canceled or Completed

Canceled and completed appointments are listed in the **Past appointments** tab. If customer surveys are enabled, then completed appointments will give customers the option to send feedback.

> [!div class="mx-imgBorder"]
> ![List of past appointments in the customer experience portal, showing the option to send feedback.](./media/homepage-past-bookings-with-send-feedback-option-for-completed-bookings.jpg)

> [!div class="mx-imgBorder"]
> ![Survey form shown to the customer when they choose to send feedback on a service visit.](./media/homepage-send-feedback-page.jpg)


<!-- do we need to keep that info? 
1. ### While testing, I deleted and and readded my contact to an account but I don't receive an new self-scheduling invite email. Why not? 

A contact with a matching email will only receive the portal invite once, even if the contact is deleted and readded to the system. You can work around this with the following steps:

1. Go to **Portal Management** app in the Power Apps admin center.
1. Open the newly created contact record.
1. On the command bar, select **Create Invitation**.
1. From the newly created invitation record, copy the *Invite code*.
1. Go to the **Web Roles** tab and select **Add existing web role**.
1. Select the *Web Api Users* web role.
1. Send the invite code and the portal link to desired email contact.
 
From the portal side: 

1. Open your self-scheduling portal and go to the signin screen. 
2. Select **Redeem invitation**.
3. Use the invite code to create a portal account.
-->



### I tried to reset my password in the Field Service customer portal and never received an email. Why not?

Make sure you have the correct process enabled for this functionality.

1. Go to **Field Service** > **Settings** > **Processes**.
2. Search for **Send Password Reset to Contact**.
3. Open the process to edit. Scroll down and select **View Properties**.
4. Edit the **From** field to a user&mdash;most likely the same account you use to send notifications for the scheduling experience&mdash; and then select **Save and Close**.
5. Go to **Settings** > **Email Configuration** > **Mailboxes**. 
6. Select the user you set in step 4, select **Approve Email**, and then select **Test & Enable Mailbox**.

> [!div class="mx-imgBorder"]
> ![Field Service process edit page, showing the "Send Password Reset to Contact" process.](./media/SS-Process-sendemail.PNG)

### Known issues and limitations in preview

 - Scheduling is done for user resources only at this time.

 - Currently cannot self-schedule incident types, which require crews or requirements with multiple resources. 
 - 

### Which resource is booked when the booking is created?

Available resources are filtered based on any consraints associated with the account and the resource, like territory and any other characteristics. Among the filtered resources, the resource with the minimum travel distance to the customer's location is booked for the booking.

