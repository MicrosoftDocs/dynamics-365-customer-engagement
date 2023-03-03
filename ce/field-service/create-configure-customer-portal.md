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

The following sections guide you through the setup process and provide helpful information to configure the portal template.

## Create the Field Service customer experiences portal

<!-- user privilege prerequisites to create portal and customize it? -->

1. Go to the [Power Aps Maker portal](http://make.powerapps.com).

1. Choose an environment with Dynamics 365 Field Service and select **Create**.

1. Search for Field Service and select **Field Service Portal**.

> [!div class="mx-imgBorder"]
> ![Power Apps, showing the Field Service portal.](./media/C2-Customer-Portal.png)

1. Enter the name of the portal, the desired subdomain, and choose a display language and select **Create**.

The Power Pages portal site gets created in the background. This process can take a few minutes. You'll get an email when it's ready or you can check the notification area for updates.

## Configure the customer portal settings

Admins can configure most customer portal settings directly in Field Service.

1. In Field Service, open the **Settings** area. Under **Customer Portal**, select **Customer Portal** and open the settings record.

1. Configure the following settings as needed.

### Configuration tab

- **Portal Name**: A label referenced by website code to retrieve the appropriate setting. The name should be unique for the associated website, because the code retrieving the setting will take the first record found with the matching name.

- **Field Service Website**: The associated website. Opening the associated website record takes you to the [Portal Management app](/power-apps/maker/portals/configure/configure-portal).

- **Track My Technician**: Enables the options to configure the [Track a technician feature](customer-portal-technician-tracking.md).

- **Self Scheduling (Preview)**: Enables the self-scheduling experience in the portal.

- **Send self-scheduling experience to Account Contacts**: Enables automated notifications with access information for the portal. The information is sent to every contact that isn't part of an excluded account. When enabling this feature, choose if you want to send invites to all contacts or only to new contacts moving forward.

- **Messages**: Messages are sent at specific points of the work order lifecycle. These messages can be enabled or disabled independently. For details on each message, go to [Set up notifications for the Field Service Portal (preview)](customer-portal-notification-settings.md).

- **Communication Type**: Define whether you want the system to send your customer email, SMS, or both message types.

- **Send Messages To**: By default, the system sends messages to the contact that created the service request through the portal. If no such contact exists, messages go to the contact type noted in this setting.

- **Exclusion lists**: These lists allow you to exclude specific service accounts or service types from all messaging.

- **Include Survey (Preview)**: [Embed a Customer Voice survey for service feedback](#embed-a-customer-voice-survey-for-service-feedback), which will be presented to your customers on the portal when the booking is complete.

- **Configure SMS and Email Connector**: Direct links to the Power Automate flows where you [configure the email and SMS connectors](customer-portal-notification-settings.md).

- **Excluded Work Order Types**: List work order types that you don't want to expose as an option in the portal.

- **Excluded Accounts**: List customer accounts for which you don't want to enable the portal. Contacts related to excluded accounts won't receive invitations to the portal either.

### Display tab

Use this tab to set basic design values for the portal. <!-- where in portal management can I change CSS as defined in the FS settings?---> The Advanced Display Configuration field contains the direct link to open [the Portal Management app](/power-apps/maker/portals/configure/configure-portal). Use the Portal Management app to configure all the details for your portal.

### Self Scheduling (Preview) tab

If you enabled the Self Scheduling (Preview) option, this tab let's you configure schedling parameters.

:::image type="content" source="media/SS_Settings_SSS.png" alt-text="Screenshot of the self-scheduling settings.":::

- **Minimum lead time for new bookings (days)**: Sets the minimum time, in days from today, during which the customer can schedule their booking.

- **Maximum lead time for new bookings (days)**: Sets the maximum time, in days from today, during which the customer can schedule their booking.

- **Enable Asset Selection**: When this option is enabled, the customer has the option to select a specific asset to associate with their account while they schedule their booking. <!--any asset in the asset list or only assets that are already linked to customer account?-->

- **Enable Additional Details**: Enables the options to submit extra text while scheduling the booking. The system saves the text as a note on the booking timeline.

- **Default Radius Unit**: Sets the radius unit to miles or kilometers.

- **Include Resource with maximum travel radius**: The maximum radius from the scheduled location in which a resource can be scheduled.

> [!NOTE]
> The travel radius are shared settings with the [schedule board in Field Service](configure-schedule-board.md). Changing the value on one will change the value for the other.

## Configure incident type for the portal

As part of the self-scheduling experience, the customer can select the incident type (shown as **Service Type**) that represents the work needed. As a Field Service administrator, you can make specific incident types available to your customers and set a user-friendly display name for the incident type shown on the self-scheduling portal.

1. Open an [existing incident type](configure-incident-types.md) and set the **Enable for C2** setting to **Yes**.
1. Provide a **Display Name** for the portal.
1. Set a **Default Work Order** type, which is associated with a price list for the incident type.
1. Set an estimated duration for the incident type. This value is the work duration shown in the portal.

> [!div class="mx-imgBorder"]
> ![Customer portal settings, showing the field for the user-friendly name for incident types.](./media/SS_Incident_Type-displayname.png)

## Configure identity providers for the portal

The portal requires customers to authenticate before they can open service requests. By default, the portal uses local authentication. Administrators can add and change authentication options.

More information: [Overview of authentication in Power Apps portals](/powerapps/maker/portals/configure/configure-portal-authentication)

> [!div class="mx-imgBorder"]
> ![List of identity providers in Power Apps.](./media/SS_Authentication.png)

<!-- maybe create a separate article for design?-->

## Customize the portal design

You can update the design and styling of your portal to meet your branding requirements. User the Power Pages design studio or the Power Apps designer.

<!-- continue here-->

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


## Embed a Customer Voice survey for service feedback

<!-- needs more detail and links to customer voice-->

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

## Next steps

- [Set up notifications for the Field Service Portal](customer-portal-notification-settings.md)
