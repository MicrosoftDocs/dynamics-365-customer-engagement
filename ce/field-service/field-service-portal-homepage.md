---
title: "Customer experience homepage in Dynamics 365 Field Service (contains video) | MicrosoftDocs"
description: Learn about how customers can manage their upcoming service visits with customer experience portals in Field Service.
ms.date: 10/21/2021

ms.topic: article
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: Deana-Fuller
ms.author: drfuller
search.app:
- D365CE
- D365FS
---

# Field Service customer experience homepages

Customer experience homepages provide a one-stop destination for your service end customers to book new appointments, manage existing appointments, track their technician, and provide feedback.

In this article, we'll walk through the customer experience homepages, and how they work for end customers.

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWO5EO]


## Prerequisites

- To make sure end customers can use a homepage, enable self-scheduling in Field Service. For more information, see: [Enable self-scheduling for customers](scheduling-self-customers.md).

- If you want customers to see information about their technician location and arrival time, see: [Send current technician location and arrival times to your customers](reminders-arrival-time.md). This setting is optional.

## Set up the homepage

If you are provisioning the Field Service customer experiences portal (preview) for the first time, then there are no additional steps to enable homepages.

If you have the Field Service customer experiences portal (Preview) already provisioned, then you will need to [upgrade your solution package](/powerapps/maker/portals/admin/update-portal-solution).

## Access and view the home page

Field Service contacts associated with active accounts can receive invitations to the Field Service customer experiences portal. After creating an account, customers can sign in to the portal.
 
The first time a user signs in to the Field Service customer portal, they'll see their portal profile. Details here are optional.
 
Select the **Home icon** to go to the homepage.
 
> [!div class="mx-imgBorder"]
> ![The customer experience portal in Field Service.](./media/homepage-empty-homepage-with-book-a-new-appo.jpg) 

## Self-schedule an appointment

Select **Book a new appointment** to go to the self-scheduling page.

> [!div class="mx-imgBorder"]
> ![The customer experience portal, showing the "Book a new appointment" option.](./media/homepage-self-scheduling-page.jpg)

> [!div class="mx-imgBorder"]
> ![Self-scheduling page of the customer experience portal, showing booking options.](./media/homepage-self-scheduling-with-selected.jpg)

Select an asset (optional) and service type to see available time slots.

Select **Book** to create the appointment.

> [!div class="mx-imgBorder"]
> ![Successful booking screen in the customer experience portal.](./media/homepage-booking-confirmation-page.jpg)

Select the **Home icon** to go back to the homepage.

## Modify an appointment

End customers can also modify existing appointments in the customer experiences portal by choosing a new time, or canceling altogether.

To change or update an appointment, select **Modify** on an existing appointment in the customer experience portal.

From the modify screen, customers can select a new time, and save their changes.

> [!div class="mx-imgBorder"]
> ![Customer experiences portal, showing a modified time for an appointment.](./media/homepage-reschedule-booking-page-with-new-date-and-time-selected.jpg)

> [!div class="mx-imgBorder"]
> ![Confirmation screen in the modify appointment section of the customer experience portal.](./media/homepage-booking-reschedule-page.jpg)
 
To cancel the service visit, select **Cancel appointment** and provide a brief description for the reason.

> [!div class="mx-imgBorder"]
> ![Cancellation dialog in the customer experience portal.](./media/homepage-cancel-appointment-with-cancellations-reason.jpg) 

## Appointment states

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
