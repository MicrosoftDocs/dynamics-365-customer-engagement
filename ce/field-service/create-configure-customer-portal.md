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

# Create and configure the Field Service Portal (preview)

## Step 1: Set up the Field Service customer experiences portal

First, we need to set up the customer experience portal with Power Apps portals.

Go to  http://make.powerapps.com and select **Create**.

Select **Field Service Portal (Preview)**.

> [!div class="mx-imgBorder"]
> ![Power Apps, showing the Field Service portal.](./media/C2-Customer-Portal.png)

Enter your portal's name and desired subdomain and display language, then select **Create**.

You'll get an email when the portal has been provisioned, and you can move on to the next step.


## Step 2: Configure email and SMS connectors within Power Automate

See [Set up notifications for the Field Service Portal](customer-portal-notification-settings.md)


## Step 3: Set up the customer experience

> [!Note]
> When enabling customer experience, messages can be sent to contacts of the account associated with bookings. If testing in non-production orgs, make sure your test data does not have real customer email addresses or phone numbers. If your org contains real data, you can prevent unnecessary communication by adding accounts to exclusion lists.

In Field Service, Go to **Field Service Settings** > **Customer Portal** > **Customer Portal Settings**.

### portal settings in Field Service

Configure the following settings as needed: 

- **Messaging**: Messages are sent at specific points in the Field Service customer lifecycle. These messages can be enabled or disabled independently. For details on each message see [Notifications](#notifications).

- **Communication Type**: Define whether your customer will receive email, SMS, or both message types.

- **Send Messages To**: By default messages will be sent to the "Reported By" contact in the Work Order. If there is no Reported By contact, messages will be sent to Contact noted in this field.

- **Exclusion lists**: These lists allow you to exclude specific service accounts or service types from all messaging.

- **Include Survey (Preview)**: You can embed a Customer Voice survey, which will be presented to your customers on the portal at the conclusion of the booking. For more information, see [Field Service Customer Portal Survey](/dynamics365/field-service/reminders-arrival-time#field-service-customer-portal-survey)

- **Power Automate (Email & SMS links)**: These are direct links to the Power Automate flows where you configure the [email and SMS connectors](#step-2-configure-email-and-sms-connectors-within-power-automate).

> [!div class="mx-imgBorder"]
> ![The customer portal settings in Field Service.](./media/TmT_Configuration.png)

## Self-scheduling settings

Let's take a look at the self-scheduling settings, and what they do: 

- **Minimum lead time for new bookings**: Sets the minimum time, in days from today, during which the customer can schedule their booking.
- **Maximum lead time for new bookings**: Sets the maximum time, in days from today, during which the customer can schedule their booking.
- **Enable Asset Selection**: When this option is enabled, the customer has the option to select a specific asset to associate with their account while they schedule their booking.
- **Enable Additional Details**: When this option is enabled, the customer can submit text to your organization while scheduling their booking. This text will be saved as a note on the booking timeline.
- **Default Radius Unit**: Sets the radius unit to miles or kilometers.
- **Include Resource with maximum travel radius**: The maximum radius from the scheduled location in which a resource can be scheduled. 
   
    > [!NOTE]
    > **Default Radius Unit** and **Include Resource with maximum travel radius** are shared settings for the schedule board; changing the value on one will change the value for the other.


> [!div class="mx-imgBorder"]
> ![The customer portal settings, showing the display options.](./media/SS_Settings_SSS.png)


## Configure incident type

As part of the self-scheduling experience, the customer can select the incident type (shown as **Service Type**) that represents the work needed. As a Field Service administrator, you can make specific incident types available to your customers and set a user-friendly display name for the incident type shown on the self-scheduling portal.

Incident types must be configured with following steps to properly appear in the self-scheduling portal:

1. Check **Enable for C2** and apply a user-friendly name.
2. Set a **Default Work Order** type, which is associated with a price list for the incident type.
3. Set an estimated duration for the incident type. This value is the work duration shown in the portal.
4. Incident type should not be associated with a requirement group.

    > [!NOTE]
    > If any of these conditions are not met when saving an incident type after making it **Enable for C2**, then an appropriate error will be shown.


> [!div class="mx-imgBorder"]
> ![Customer portal settings, showing the field for the user-friendly name for incident types.](./media/SS_Incident_Type-displayname.png)


## Authentication

The portal is an authenticated experience. By default, local authentication is enabled when the portal is provisioned. This can be reconfigured by the organization's administrator. Configure authentication through Power Apps portals. 

More information: [Overview of authentication in Power Apps portals](/powerapps/maker/portals/configure/configure-portal-authentication)

> [!div class="mx-imgBorder"]
> ![List of identity providers in Power Apps.](./media/SS_Authentication.png)

## Branding and content

Configure the branding and content for your Field Service customer portal.

From the customer portal settings, go to the **Display** tab.

Here you can customize:

- Font type and color for the online portal.
- Background and foreground colors.
- Code snippets: These snippets are dynamic content strings that when updated, reflect consistent content across the portal, email, and SMS when applicable. Here are a few important code snippets to include:
  - Contact email
  - Contact phone
  - Company name
  - Page title
  - Page footer

> [!div class="mx-imgBorder"]
> ![Field Service customer portal settings, showing the display options.](./media/TMT-DisplaySettings.png)

> [!Note]
> The header and footer of your portal are updated in the portal designer. There is a link to the designer experience from the **Display Settings** tab. For more information on portal designer, see the section in this article: [Portal designer](#portal-designer).

### Portal designer

You can update your portal header and footer images, adjust colors, and access more advanced configuration from the Power Apps portal designer. 

There is a direct link to the portal designer from **Customer Portal Settings** > **Design**. To go there directly: 

- Go to https://make.powerapps.com.
- Select **Apps**.
- Select **Edit** on the portal you created.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps showing the list of apps.](./media/new-edit-portal.jpg)

In the portal designer, selected content can be updated and will be reflected in the customer portal. Updating content snippets in the portal maker will also influence content in the messages when applicable.

In the portal designer, upload your mobile and desktop header images, and adjust the color theme of the header and footer areas.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Apps portal designer.](./media/portaleditor_exp.jpg)

> [!Note] 
> Elements of the portal outside of header and footer - and the highlighted content snippets - are not editable.


## Field Service customer portal survey

You can now embed a Customer Voice survey directly within the Field Service customer experience portal. When the survey embed code is added into configuration, it will automatically render the survey on the portal when the work is complete.

> [!div class="mx-imgBorder"]
> ![An embedded survey on a Field Service customer portal, as shown in a browser.](./media/TMT-Desktop-Complete-Survey.png)

> [!div class="mx-imgBorder"]
> ![An embedded survey on a Field Service customer portal, as shown on mobile.](./media/TMT-Mobile-Complete-Survey.png)



### How do I update my Field Service customer experiences portal?

We will publish updates over time to introduce new features and functionality for the customer portal. Updates are not automatically published to your portal; they must be applied by the organization administrator for your environment. To apply an update, go to https://admin.powerplatform.microsoft.com/, select the environment that has the Field Service customer experiences portal installed, and select **Portals**. If an update is available, you'll see a message saying so, with an option to **Update now**. Select your portal and apply the update to our environment. 



### Will the Field Service customer experiences portal receive updates?

When we make updates to the customer experience portal, new features or enhancements will be unpublished and require the org admin to publish the update before they reflect on the live experience.

### Can I customize the portal by including my own entities and fields?

No. At this time, the portal is not customizable and configuration is limited to what is defined in the [Field Service customer experience settings.](#step-3-set-up-the-customer-experience).


