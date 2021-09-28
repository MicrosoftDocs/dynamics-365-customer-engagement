---
title: "Field Service Customer Portal Homepage | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 10/01/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Field Service Customer Portal Homepage


Customer engagement Homepage provides a one-stop destination for end customers to book new appointments, manage existing appointments, track their technician and provide feedback.

## Prerequisites
> [!Note]
>

>[!TIP] 
> 


For end-customers to be able to use Homepage, it is mandatory to Enable self scheduling for customers.

Track my technician is optional to be enabled.

## Set up the Homepage
If you are provisioning the Field Service customer experiences portal(Preview) for the first time then there are no additional steps to enable Homepage.
If you have the Field Service customer experiences portal (Preview) already provisioned, then you will need to upgrade your solution package.
Note: You will have to complete setup of Self-scheduling for customers to be able to use the Homepage.

Portal experience
Field Service contacts associated with active accounts can receive invitations to the Field Service customer experiences portal. After creating an account, customers can sign-in to the portal.
 
The first time a user signs-in to the Field Service customer portal, they'll see their portal profile. Details here are optional.
 
Click on the ‘Home’ icon to navigate to the Homepage.
 

Click on the ‘Book a new appointment’ button to go to the self-scheduling page.
 
Select an Asset (optional) and Service type to see available time slots
 
Click on Book to create the Appointment
 
Click on ‘Home’ icon to navigate to the Homepage (the screenshot shows multiple Appointments booked via Self scheduling)
 
Click on ‘Modify’ button to navigate to the Modify Appointment page
 
On the Modify Appointment page, end-customers can either:
Re-schedule the Appointment by choosing a new date and time-slot
 
Cancel the Appointment by clicking on Cancel appointment. Users will also need to provide a reason for cancellation.
 

### Different Appointment states:

#### Appointments in Travelling state: 
If an appointment is in the Travelling state and Track my technician is enabled, then users will have the option to click on ‘View Live Map’.
The appointment in Travelling state will be shown under the Active appointment tab. If there are more than one appointment in Travelling state, then only one will be shown in the Active appointment tab and others will be shown in the Upcoming appointment tab with ‘View Live Map’ button.
 
 
#### Appointments in ‘In Progress’ state:
Appointments in the ‘In Progress’ state will show under the Upcoming appointments and will have the Modify button disabled so the end-customer will not have the option to re-schedule or cancel the appointment.
 
#### Appointments in the ‘Scheduled’ state:
Scheduled appointments will show under the Upcoming appointments tab have a Modify button which users can use to re-schedule or cancel the appointment.
 
#### Appointments in the ‘Canceled’ or ‘Completed’ states:
Canceled and Completed appointments will show up under the Past appointments tab. If Customer survey is enabled, then Completed appointments will have the option of ‘Send Feedback’.
 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-booking-confirmation-page.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-booking-reschedule-page.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-cancel-appointment-with-cancellations-reason.jpg)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-empty-homepage-with-book-a-new-appo.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-homepage-with-1-booking-in-travelling-state-which-has-link-to-tmt.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-homepage-with-2-bookings-in-travelling-state.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-homepage-with-upcoming-bookings.jpg)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-modify-booking-page.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-one-booking-in-travelling-and-1-in-progress.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-past-bookings-with-send-feedback-option-for-completed-bookings.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-reschedule-booking-page-with-new-date-and-time-selected.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-self-scheduling-page.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-self-scheduling-with-selected.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/homepage-send-feedback-page.jpg)



