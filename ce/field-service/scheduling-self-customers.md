---
title: Enable self-scheduling service appointments in Dynamics 365 Field Service | MicrosoftDocs
description: Learn how to allow customers to schedule work orders via a customer portal in Dynamics 365 Field Service
ms.date: 04/21/2021
ms.service: dynamics-365-customerservice
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shellyha
ms.custom:
  - dyn365-fieldservice
search.app:
  - D365CE
  - D365FS
---




# Enable customers to self-schedule service appointments in Field Service

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use](https://go.microsoft.com/fwlink/p/?LinkId=511446).


Field Service self-service scheduling aims to improve your customers' scheduling experience by providing them flexibility to schedule on their own time, directly from their devices.

> [!div class="mx-imgBorder"]
> ![Self-service scheduling functionality on a tablet and mobile device.](./media/SS_Hero-screens.png)

## Prerequisites

- Field Service version (8.8.30.103+)
- SMS provider supporting the Power Automate connector for mobile SMS communication
- Office 365 Exchange account for email communications

## Step 1: Set up the Field Service customer experiences portal (preview)

First, we need to set up the customer experience portal with Power Apps portals.

1. Go to [http://make.powerapps.com](http://make.powerapps.com), and select **Create**.

1. Select **Field Service Portal**.

   > [!div class="mx-imgBorder"]
   > ![Power Apps, showing the Field Service portal.](./media/C2-Customer-Portal.png)

1. Enter your portal's name and subdomain, select the display language you want, and then select **Create**.

You'll get an email when the portal has been provisioned, and then you can move on to the next step.


## Step 2: Configure email and SMS connectors in Power Automate

Customers will access their service portal with a unique link sent to their email or as a text message. To set this up, you'll need to configure one or both communication methods.

We provide a links directly to the Power Automate Flows for Email and SMS via Field Service [Customer Portal Settings](#set-up-the-customer-experience)

Alternately, you can access the Power Automate Flows for Email and SMS within Power Automate:

Go to [http://make.powerapps.com](http://make.powerapps.com) > **Solutions**. Select **Dynamics 365 Field Service PowerApps Portal – Flow** in the list.

> [!div class="mx-imgBorder"]
> ![List of Power Apps solutions with "Dynamics 365 Field Service PowerApps Portal – Flow" selected.](./media/SS_paflow_solution.jpg)

Here you'll find three Power Automate flows. Email and SMS flows are off by default, so we'll need to configure both to enable them. 

> [!div class="mx-imgBorder"]
> ![List of flows available in the "Dynamics 365 Field Service PowerApps Portal – Flow" solution.](./media/SS_PAFlow_Flows.jpg)

> [!NOTE]
> The following procedures use the popular providers Exchange and Twilio as examples. You can substitute an alternate connector by cloning the flows and configuring the connector you want.
<!--markdownlint-disable MD036-->

To configure email:

- Click the **Field Service PowerApps Power Flow Email Notification**. This will open the Flow in a new tab.
- With the Flow open, select **Edit**.
- Select the **Send an Email** Exchange connector.
- Add your Office 365 Exchange account connection.
- Save and **Turn On** the flow.

To configure SMS:

- Select **Field Service PowerApps Power Flow SMS Notification**. This will open the Flow in a new tab.
- With the Flow open, select **Edit**.
- Select the Twilio connector.
- Add your Twilio account details.
- Save and **Turn On** the flow.


## Step 3: Set up the customer experience

> [!NOTE]
> As you enable this experience, messages can be sent to contacts of the Field Service account associated with bookings. If you're testing in a non-production org, make sure your test data doesn't contain real customer email addresses or phone numbers. If your org contains real data, you can prevent unnecessary communication by adding accounts to exclusion lists.

In Field Service, go to **Field Service Settings** > **Customer Portal** > **Customer Portal Settings**.  

### General and notification settings

> [!NOTE]
> The same Field Service customer portal contains multiple customer-focused features, including self-scheduling (preview) and **Track My Technician**. These features are independently enabled, although they share common configurations. Some settings on the **General** tab only apply to one experience, while others apply to multiple experiences.

Configure the following settings, as needed: 

- **Send self-scheduling experience to Account Contacts**: When enabled, new contacts who are associated with active Field Service accounts will be sent an email that invites the contact to create a Power Apps portals account for self-scheduling. More information: [Notification types](#notification-types)

    >[!NOTE]
    >When enabling this option, you can choose to send the invitation only to new contacts going forward, or to all existing contacts. If a contact has already received the invitation, they won't receive a second one. 

- **Messaging**: Messages are sent at specific points in the Field Service customer lifecycle. These messages can be enabled or disabled independently. More information: [Notification types](#notification-types)

- **Communication Type**: Define whether the customer will receive email, SMS, or both message types. 
- 
- **Send Messages To**: This feature is only used with [Track My Technician](reminders-arrival-time.md).  

- **Include Survey (Preview)**: This feature is only used with [Track My Technician](reminders-arrival-time.md). 

- **Exclusion lists**: Exclude specific service accounts or service types from all messaging.

- **Powre Automate (Email & SMS links)**: These are direct links to the Power Automate Flows where you configure the [Email and SMS connectors](#step-2:-configure-email-and-sms-connectors-within-power-automate).

> [!div class="mx-imgBorder"]
> ![The customer portal settings in Field Service.](./media/SS_Settings_Config.PNG)

You can also directly access the Power Automate flows for email and SMS setup from the **Configuration** tab.

### Branding and content

Customize the branding and content for your customer portals.

From the customer portal settings, go to the **Display** tab.

Here you can customize:

- Font type and color for the online portal.
- Background and foreground colors.
- Code snippets: These snippets are dynamic content strings that&mdash;when updated&mdash;reflect consistent content across the portal, email, and SMS when applicable. Some important code snippets include:
  - Contact email
  - Contact phone
  - Company name
  - Page title
  - Page footer

> [!div class="mx-imgBorder"]
> ![The customer portal settings, showing options on the Display Settings tab.](./media/SS_Settings_Display.png)

> [!NOTE]
> To upload and update the portal header image, go to the Power Apps portal designer. There's a link to the designer on the **Display Settings** tab. More information: [Portal designer](#portal-designer)


### Self-scheduling settings

Let's take a look at the self-scheduling settings, and what they do: 

- **Minimum lead time for new bookings**: Sets the minimum time, in days from today, during which the customer can schedule their booking.
- **Maximum lead time for new bookings**: Sets the maximum time, in days from today, during which the customer can schedule their booking.
- **Enable Asset Selection**: When this option is enabled, the customer has the option to select a specific asset to associate with their account while they schedule their booking.
- **Enable Additional Details**: When this option is enabled, the customer can submit text to your organization while scheduling their booking. This text will be saved as a note on the booking timeline.
- **Include Resource with maximum travel radius**: The maximum radius from the scheduled location in which a resource can be scheduled. A value of **0** means there is no maximum radius.


> [!div class="mx-imgBorder"]
> ![The customer portal settings, showing the display options.](./media/SS_Settings_SSS.png)


### Configure incident type

As part of the self-scheduling experience, the customer can select the incident type (shown as **Service Type**) that represents the work needed. As a Field Service administrator, you can make specific incident types available to your customers and set a user-friendly display name for the incident type shown on the self-scheduling portal.

> [!div class="mx-imgBorder"]
> ![Customer portal settings, showing the field for the user-friendly name for incident types.](./media/SS_Incident_Type-displayname.png)


### Authentication

The portal is an authenticated experience. By default, local authentication is enabled when the portal is provisioned. This can be reconfigured by the organization's administrator. Configure authentication through Power Apps portals. 

More information: [Overview of authentication in Power Apps portals](/powerapps/maker/portals/configure/configure-portal-authentication)

> [!div class="mx-imgBorder"]
> ![List of identity providers in Power Apps.](./media/SS_Authentication.png)


## Step 4: Testing the experience as a customer

To review and test changes, set up an account and contact in Field Service as if you were a customer:

1. Create an account in Field Service.

1. Add test assets to the account, if they're used by your organization.

1. Create a contact in Field Service.

1. Add the contact to your account.

   This will generate an invitation email, which is sent to the contact. The invitation will link to the portal, where you can create your portal account.

1. Sign in to the self-service scheduling portal.

   You'll be taken to a profile page. This page is shown the first time after a user creates their account. You can skip this page.

1. Schedule service via the self-scheduling portal. You'll receive an email confirming your booking.

1. Back in Field Service, confirm that the work order is created and the booking is scheduled.


## Configuration considerations

### Notification types

**Self-scheduling portal invitation**: As new contacts are added to accounts, they'll be sent an invitation link that allows the customer to create an account with the self-scheduling portal. This notification is sent only as email.

> [!div class="mx-imgBorder"]
> ![Email invitation with a link to the self-scheduling portal.](./media/SS-Email-Invite.png)

**Booking confirmed**: When a contact self-schedules in the Field Service customer portal, they'll receive an email or SMS confirming their booking date and time, with the option to reschedule.

> [!div class="mx-imgBorder"]
> ![Email showing the customer that their booking in confirmed.](./media/SS-Email-scheduled.png)

**Booking reminder**: When a contact self-schedules with the Field Service customer portal, they'll receive a reminder within one to seven days of the booking scheduled date. This reminder will include an option to reschedule. 

> [!div class="mx-imgBorder"]
> ![Email reminder, showing the customer a summary of upcoming work.](./media/SS-emailreminder.png)

**Booking reschedule**: When a booking is rescheduled, either by the system or a customer through the portal, the contact will receive a notification of the new date and time. This notification will include the option to reschedule.

> [!div class="mx-imgBorder"]
> ![Email confirmation showing that a booking has been rescheduled.](./media/SS-email-rescheduled.png)

**Booking canceled**: When a booking is canceled, the contact will receive a notification.

> [!div class="mx-imgBorder"]
> ![Email confirmation showing that a booking has been canceled.](./media/SS_email-Booking-Canceled.png)

**Booking completed**: When a booking is completed, the contact will receive a notification.

> [!div class="mx-imgBorder"]
> ![Email confirmation showing that the scheduled work has been completed.](./media/SS-Email-Complete.png)

> [!NOTE]
> The **Technician Traveling** notification is relevant only to the [**Track My Technician**](reminders-arrival-time.md) functionality, and isn't available if only self-scheduling has been enabled.


### Portal experience

Field Service contacts associated with active accounts can receive invitations to the Field Service customer experiences portal. After creating an account, customers can sign in to the portal.

> [!div class="mx-imgBorder"]
> ![The Field Service customer portal sign-in screen.](./media/SS-Portal-Login.png)

The first time a user signs in to the Field Service customer portal, they'll see their portal profile. Details here are optional. 

> [!div class="mx-imgBorder"]
> ![The customer portal contact profile screen.](./media/SS-Portal_Profile.png)

Select the **Self Scheduling** option in the header to access the scheduling experience. 

> [!div class="mx-imgBorder"]
> ![The customer portal, showing the full self-scheduling experience.](./media/SS-Portal-scheduling.png)

From the self-scheduling experience, customers can: 

1. Select their **Service Product**, which is a list of assets associated with their account. This functionality must be enabled in [self-scheduling settings](#self-scheduling-settings).
    The address shown under the service product is the account location, by default. If a service product with a different functional location is selected, the address for the booking is updated to the address for that functional location.

2. Select their **Service Type**, which is a list of incident types made available to them.

3. Based on the service product and service type, the user is presented a list of dates and times that technicians are available, based on the skills required for the job.

4. When enabled via [self-scheduling settings](#self-scheduling-settings), the user can optionally enter additional details with their scheduling request. 

5. Select **Book**. 

After successfully submitting their scheduling request, the user will then see a confirmation message that includes the details for their booking.

> [!div class="mx-imgBorder"]
> ![The customer portal, showing self-scheduling confirmed.](./media/SS-Portal-scheduled.png)

### Portal designer

As an alternative to using content snippets, you can update content and access more advanced configuration as part of the portal designer experience. 

1. Go to https://make.powerapps.com.
1. Select **Apps**.
1. Select **Edit** on the portal you created.

> [!div class="mx-imgBorder"]
> ![Power Apps, showing the list of apps.](./media/SS_edit-portal.jpg)

In the portal designer, selected content can be updated and will be reflected in the customer portal. Updating content snippets in the portal designer will also update content in the messages, when applicable.

You can use the portal designer to upload a customized header image or make more fine-tuned adjustments to the style sheet and the portal's header or footer.

> [!div class="mx-imgBorder"]
> ![The Power Apps portal designer.](./media/SS_PortalDesigner.png)

> [!NOTE] 
> Elements of the portal outside of the header and footer&mdash;and the highlighted content snippets&mdash;aren't editable.

### Notification settings

Notification settings provide a read-only view of all messages sent to customers. Here you can see which customers have received a message, the type of message, and the state of the message.

> [!div class="mx-imgBorder"]
> ![The list of active notifications in Field Service.](./media/07_FSSettings_notifications.jpg)

> [!div class="mx-imgBorder"]
> ![Notification details page in Field Service.](./media/07a_FSSettings_notifications-details.jpg)

### Booking notification codes

With booking notification codes, Field Service admins can extend, expire, or block access to a portal link that has been shared with a customer.

> [!div class="mx-imgBorder"]
> ![List of active notifications, along with their codes.](./media/08_FSSettings_BookingNotifications.jpg)

> [!div class="mx-imgBorder"]
> ![Notification details in Field Service.](./media/09_FSSettings_BookingNotifications-details.jpg)

## FAQ for self-scheduling portals

### While testing I deleted and and re-added my Contact to an Account but I do not receive an new Self Scheduling invite email?

Presently a contact with a matching email will only recieve the portal invite once, even if the Contact is deleted and re-added to the system. You can work around this with the following steps:
	1. Navigate to “Portal Management” app in Power App Admin.
	2. Open the newly created contact record.
	3. On the command bar, click on “Create Invitation”.
	4. From the newly created invitation record, copy the “invite code”
	5. Navigate to the “Web Roles” tab and click on “Add existing web role”
	6. Select the “Web Api Users” web role.
	7. Send the invite code and the portal link to desired email contact.
 
From the Portal Side: 
	1. Open your self scheduling Portal and navigate to the Login screen. 
	2. Click on “redeem invitation”.
	3. Use the invite code to create a portal account.

### Can you cancel a booking from the portal?

You can only reschedule bookings from the portal; you can't cancel them. Check back soon for feature enhancements as we work toward general availability. For more information about upcoming enhancements, see the [Dynamics 365 and Power Platform release plans](https://docs.microsoft.com/dynamics365/release-plans/). 

### Who receives the notifications when a booking is self-scheduled?

When someone self-schedules, they'll be added as the *Reported By* contact associated with the work order for the booking. All future communication&mdash;including reminders and reschedule notifications&mdash;will be sent to that *Reported By* contact on the work order.

### Will all bookings result in notifications such as confirmations and reminders?

Only bookings that were created through the self-scheduling portal will receive the notifications. During the preview period, these bookings will carry a unique booking ID, which is how the system knows they were scheduled through the self-scheduling portal.


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


### Does the Field Service customer experiences portal support all languages?

The portal will support Field Service languages with the exception of Arabic and Hebrew.

### How do I change the timing of reminder messages?

Reminder messages are triggered by a flow that runs daily at 10:00 AM UTC. Any bookings that fall into your reminder message time period, and aren't part of exclusion lists, will receive a reminder message.

**To edit the reminder message**

1. Go to https://make.powerapps.com > **Solutions** and find the solution **Dynamics 365 Field Service PowerApps Portal – Flow**.
1. Edit the flow named **Create notification items for bookings**.
1. Find the location recurrence connector, and set the **Flow Recurrence** value to the time you want.

> [!div class="mx-imgBorder"]
> ![The recurrence connecter in the flow.](./media/recurrance-flow.jpg)

### Can I still provision this Field Service customer experience portal if I already have an existing portal created with Power Apps portals?

Yes, you can have multiple portals; however, you can only have one copy of the Field Service customer experience portal per environment.

### Can I integrate this experience within an existing portal created with Power Apps portals?

Currently the Field Service customer portal is deployed as a standalone experience and can't be integrated into an existing portal.

### Will the Field Service customer experiences portal receive updates?

When we make updates to the customer experience portal, new features or enhancements will be unpublished. Your org admin must publish the updates before they're reflected in the live experience.

### I don't have a Twilio or Office 365 Exchange account. Are there other services I can use for messaging?

Yes, you can use alterative SMS or email providers as long as they have connectors supported by Power Automate. Clone the existing email and SMS flows, remove the current connectors, and add the connectors you want.

### How do I edit email and SMS content?

The general content and format of the notifications are based on a fixed template and can't be changed. However, you can update individual words within the email and SMS content by using content snippets found in Field Service settings. 

### How do I update my Field Service customer experiences portal?

We'll publish updates over time to introduce new features and functionality for the customer portal. Updates aren't automatically published to your portal; they must be applied by the organization administrator for your environment. To apply an update, go to https://admin.powerplatform.microsoft.com/, select the environment that has the Field Service customer experiences portal installed, and then select **Portals**. If an update is available, you'll see a message saying so, with an option to **Update now**. Select your portal, and apply the update to your environment. 
<!--markdownlint-enable MD036-->



## Known Issues and Limitations in Preview
 - Scheduling is done for user resources only at this time.
 - You can receive scheduling slots for resources which location agnostic or outside of the service territory from which the user is scheduling.
 - Under some circumstances the address of the Account is not populated in a work order when self scheduling.
 - Technician is currently not booked taking into account Travel Time.
 - Currently cannot self-schedule incident types which require crews or requiremnets which require multiple resources. 
