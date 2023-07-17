---
title: Create and configure the Field Service portal
description: Set up and configure the Field Service portal.
ms.date: 05/03/2023
ms.topic: how-to
author: m-hartmann
ms.author: mhart
search.app:
  - D365CE
  - D365FS
---

# Create and configure the Field Service portal

The following sections guide you through the setup process and provide helpful information to configure the portal template.

## Create the Field Service customer experiences portal

1. Go to the [Power Apps Maker portal](https://make.powerapps.com).

1. Choose an environment with Dynamics 365 Field Service and select **Create**.

1. Search for Field Service and select **Field Service Portal**.

   > [!div class="mx-imgBorder"]
   > ![Power Apps, showing the Field Service portal.](./media/C2-Customer-Portal.png)

1. Enter the name of the portal, the desired subdomain, choose a display language, and select **Create**.

The Power Pages portal site gets created in the background. This process can take a few minutes. You'll get an email when it's ready or you can check the notification area for updates.

## Configure the customer portal settings

Admins can configure most customer portal settings directly in Field Service.

In Field Service, open the **Settings** area. Under **Customer Portal**, select **Customer Portal** and open the settings record.

:::image type="content" source="media/customer-portal-settings.svg" alt-text="Screenshot of the Customer Portal settings in Dynamics 365 Field Service.":::

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

- **Include Survey (Preview)**: Embed a [Customer Voice survey](/dynamics365/customer-voice/about) in the portal. When [adding a survey embed code](/dynamics365/customer-voice/embed-web-page), the survey will automatically show when the booking is complete.

- **Configure SMS and Email Connector**: Direct links to the Power Automate flows where you [configure the email and SMS connectors](customer-portal-notification-settings.md).

- **Excluded Work Order Types**: List work order types that you don't want to expose as an option in the portal.

- **Excluded Accounts**: List customer accounts for which you don't want to enable the portal. Contacts related to excluded accounts won't receive invites to the portal either.

### Display tab

Use this tab to set basic design values for the portal. The Advanced Display Configuration field contains the direct link to open [the Power Pages designer](/power-apps/maker/portals/configure/configure-portal). Use the Portal Management app to configure all the details for your portal.

### Track my technician tab

For more information, see [Configure track my technician settings](customer-portal-technician-tracking.md#configure-track-my-technician-settings).

### Self Scheduling (Preview) tab

If you enabled the Self Scheduling (Preview) option, this tab lets you configure scheduling parameters.

:::image type="content" source="media/SS_Settings_SSS.png" alt-text="Screenshot of the self-scheduling settings.":::

- **Minimum lead time for new bookings (days)**: Sets the minimum time, in days from today, during which the customer can schedule their booking.

- **Maximum lead time for new bookings (days)**: Sets the maximum time, in days from today, during which the customer can schedule their booking.

- **Enable Asset Selection**: When this option is enabled, the customer can select a specific asset to associate with their account while they schedule their booking.

- **Enable Additional Details**: Enables the options to submit extra text while scheduling the booking. The system saves the text as a note on the booking timeline.

- **Default Radius Unit**: Sets the radius unit to miles or kilometers.

- **Include Resource with maximum travel radius**: The maximum radius from the scheduled location in which a resource can be scheduled.

> [!NOTE]
> The travel radius settings are shared with the [schedule board in Field Service](configure-schedule-board.md). Changing the value on one will change the value for the other.

## Configure incident types for the portal

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

## Customize the portal design

Makers can update the design and styling of your portal to meet your branding requirements. Use the [Power Pages design studio](/power-pages/configure/editing-sites) or the [legacy Power Apps portals Studio](/power-apps/maker/portals/portal-designer-anatomy) to customize the portal site.

You can only [edit elements in the header and footer](/power-pages/getting-started/edit-header), and content snippets. [Updating content snippets](/power-apps/maker/portals/configure/customize-content-snippets) in the portal also updates notifications if they're enabled.

## Update the Field Service portal

When we release new features, we won't update your portal automatically. An administrator must apply them to your environment. For more information, see [Update a website package](/power-pages/admin/update-solution#update-a-website-package).

## Next steps

- [Set up notifications for the Field Service portal](customer-portal-notification-settings.md)
- [Let customers schedule service appointments (preview)](customer-portal-self-scheduling.md)
- [Track a technician on the Field Service portal](customer-portal-technician-tracking.md)
