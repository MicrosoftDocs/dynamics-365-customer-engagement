---
title: "Send customers the technician's arrival time | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 01/05/2021
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

# Send customers the technician's arrival time


> [!Note]
> Feature currently in Public Preview and only available in English language in North American environments.


Improve your customers Field Service experience by providing visibility into upcoming service visits. Automated service reminders will ensure customers are ready and available when the technician arrives, eliminating wasted trips.  Real-time location tracking while the technician is in route will help your customers better plan their time around a service visit. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/technician-locator-hero.jpg)

Key Features:
- Send automated service schedule reminders and updates to your customers via Email and/or SMS.  
- Responsive online destination providing additional details on a service visit allows your customer to access via Mobile, Tablet, or Desktop.
- Customers receive information about the technician and their estimated arrival time, with the ability to track progress to destination via live map.
- Accessibility compliant experience for your customers.

## Prerequisites
- Field Service version (8.8.30.103+)
- Field Service Mobile application
- Technician Location Sharing should be enabled from CRM and from technicians Field Service Mobile application to properly communicate estimated arrival time and track location.
- Account with an SMS provider supporting Power Automate connector. By default we will be using Twilio Connector.
- Account with Office 365 Exchange Account which will be used to send Email communication.



## Setup & Deployment
1.	Provision Field Service Customer Experience portal for your org.
-- Navigate to  http://make.powerapps.com > Create
-- Select the Customer Experiences 



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/01_PAPortal_FSTemplate.jpg)


-- Enter your Portal name and desired subdomain.
-- This portal will include required packages for Field Service and Power Automate. 
-- You will receive an email notifying you when the portal is provisioned.

2. Turn on Power Automate Flows.
-- Navigate to https://make.powerapps.com > Solutions
-- Click to access solution named Dynamics 365 Field Service PowerApps Portal – Flow
-- There are three Power Automate Flows under this solution. By default, these flows are off and will need to be turned on to enabled.
- Field Service PowerApps Power Flow Email Notification (required if using Email)
-- Click into the Flow
-- Click Edit
-- Configure your Twilio account details*
-- Turn on
- Field Service PowerApps Portal Flow SMS Notifications (required if using SMS)
-- Click into the Flow
-- Click Edit
-- Configure your Exchange service account**
-- Turn On
- Create notification items for bookings
-- By default, this Flow is “On”; no further action is needed.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/03_PAFlow_Solution.jpg)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/02_PAFlow_Flows.jpg)

*By default, Twilio is used as a popular SMS provider. You can substitute an alternate connector by cloning the Flow and modifying.

**By default, Exchange is used as a common Email provider. You can substitute an alternate email connector by cloning the Flow and modifying.

## Messaging
> [!Note] Please be aware that when configuring Email & SMS communication, reminder emails will be sent to Primary Contacts of the Account associated with bookings. When testing in non-production orgs, please ensure your test data does not have real customer email or phone numbers. If your org contains real data you can evaluate preventing unnecessary communication by adding all accounts to Exclusion Lists.

Messages are sent via SMS and/or Email.  Messages are sent to Primary Contact of the Service Account. Messages are automatically generated with the following events:

- Service Reminder: Sent when a Booking is scheduled. This reminder message is sent within 7 days of the scheduled service time. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/10_email-reminder.jpg)

- By default Service Reminders will send daily at X:XX UTC. This time can be adjusted in the Power Automate Flow.
- Technician Traveling: Sent when Booking status is “Traveling”. This message communicates estimated time of arrival while considering traffic on expected route.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/13-email-traveling.jpg)


- Service Complete: Sent when Booking status is “Complete”.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/15-email-completed.jpg)

- *Service Rescheduled: Sent when a scheduled service appointment changes by >10 minutes from previously scheduled start time.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/11_email-reschedule.jpg)


- *Service Canceled: When a scheduled service appointment is canceled.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/15-email-cancel.jpg)

*Service Reschedule & Service Cancel messages are only sent if a Reminder message had previously been sent.


## Power Apps Portal Experience
Customers primary means of interacting with the experience is via Power Apps Portals. Your portal will have different states depending on the Field Service booking lifecycle.

- Remind, Traveling, and Completion messages include a link to an online web experience hosted on Power Portals.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/12-portal-desktop-reminder.jpg)


- Responsive design makes this portal accessible from mobile, tablet, or desktop. 
- This online customer portal renders different states depending on state of the associated Booking.
- When Booking is in “Traveling” state, the experience includes details of the Technician as well as the Technicians current location on an Azure map. The map will show near real-time location of technician based on signal from the Field Service Mobile application.



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/13-portal-traveling.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/14-portal-completed.jpg)



## Customize the portal
Configuration is done via Field Service Settings > Customer Portal > Customer Portal Settings 

Configuration options include:
- Name: Name of your customer portal
- Enable Notifications: Toggles if notifications are sent with access to the portal
- Reminder Timing: Option to send messages between 0 and 7 days before scheduled booking time. 
- Communication Type: Define if your customer will receive Email, SMS or both message types.
- Show/Hide Resource information: When in traveling state the customer can be informed of Technician name and image if available in CRM. 
- Show/Hide Map: Toggles the Portal map experience on or off.
- Exclusion lists where messages/experience will not be offered.
-- Service Accounts
-- Service Types


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/05_FSSettings_landing.jpg)



## Add branding & content to the portal
Branding & Content updates are done via Field Service Settings > Customer Portal > Customer Portal Settings > Display
Branding Options:
- Font Type & Color of the online portal experience.
- Background & Foreground Colors of the online portal experience.
- “Code Snippets”: Dynamic content strings that when updated can reflect consistent content across SMS, Email, and Portal.

![Field Service Customer Portal Display Settings](./media/ABC.png "Field Service Customer Portal Display Settings")

> [!Note] As an alternative you can also update branding and styles via Power Apps Portal Admin interface.

## Additional Settings
Two additional sections under Customer Portal in Field Service settings provide a way to review all past messages and overwrite messaging settings for the portal.

### Notification settings
Notification settings area provides a real-only view of all messages which have been sent to customers. Here you can view which customers have received a message, which type of message, and which state of the message.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/07_FSSettings_notifications.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/07a_FSSettings_notifications-details.jpg)


### Booking Notifications
The Booking Notification settings area provides visibility the Field Service Admin a way to extend, expire, or block access to a portal link which has been shared with a customer. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/08_FSSettings_BookingNotifications.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/09_FSSettings_BookingNotifications-details.jpg)