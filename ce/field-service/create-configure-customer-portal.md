---
title: Create and configure the Field Service portal
description: Learn how to set up and configure the Field Service portal.
ms.date: 08/20/2024
ms.topic: how-to
author: anilmur
ms.author: anilmur
ms.reviewer: mhart
---

# Create and configure the Field Service portal

This article guides you through the setup process and provides helpful information to configure the portal template.

## Create the Field Service customer experiences portal

1. Sign in to the [Power Pages portal](https://make.powerpages.microsoft.com/) and choose the environment with Dynamics 365 Field Service installed.

   You can navigate directly to the Power Pages portal for your environment. [Determine the environment ID where you have Field Service installed](/power-platform/admin/determine-org-id-name) and insert it in the following URL: `https://make.powerpages.microsoft.com/environments/<EnvironmentID>/portals/home`.

1. In the left navigation, select **Templates**.

1. Search for *Field Service* and select **Choose this template** on the **Field Service** template card.

   :::image type="content" source="media/field-service-portal-template.svg" alt-text="Screenshot of the templates in Power Pages showing Field Service.":::

1. Enter the name of the portal, the desired subdomain, choose a display language, and select **Done**.

The Power Pages portal site gets created in the background. This process can take a few minutes. You get an email when it's ready or you can check the notification area for updates.

## Configure the customer portal settings

Admins can configure most customer portal settings directly in Field Service.

1. In Field Service, select the **Settings** area. Under **Customer Portal**, select **Customer Portal** and open the settings record.

   :::image type="content" source="media/customer-portal-settings.svg" alt-text="Screenshot of the Customer Portal settings in Dynamics 365 Field Service.":::

1. On the **Configuration** tab, update the settings to meet your business needs.

   - **Portal Name**: A label referenced by website code to retrieve the appropriate setting. The name should be unique for the associated website because the code retrieving the setting takes the first record found with the matching name.

   - **Field Service Website**: The associated website. Opening the associated website record takes you to the [Portal Management app](/power-apps/maker/portals/configure/configure-portal).

   - **Track My Technician**: The option that enables the [Track a technician feature](customer-portal-technician-tracking.md).

   - **Self Scheduling (Preview)**: The option that enables the self-scheduling experience in the portal.

   - **Send self-scheduling experience to Account Contacts**: The option that enables automated notifications with access information for the portal. The information is sent to every contact that isn't part of an excluded account. When enabling this feature, choose if you want to send invites to all contacts or only to new contacts moving forward.

   - **Messages**: Messages are sent at specific points of the work order lifecycle. These messages can be enabled or disabled independently. For details on each message, go to [Set up notifications for the Field Service portal (preview)](customer-portal-notification-settings.md).

   - **Communication Type**: The type of communication the system sends your customer: email, SMS, or both.

   - **Send Messages To**: By default, the system sends messages to the contact that created the service request through the portal. If no such contact exists, messages go to the contact type noted in this setting.

   - **Include Survey (Preview)**: The [Customer Voice survey](/dynamics365/customer-voice/about) to embed in the portal. When [adding a survey embed code](/dynamics365/customer-voice/embed-web-page), the survey automatically shows when the booking is complete.

   - **Configure SMS and Email Connector**: Direct links to the Power Automate flows where you [configure the email and SMS connectors](customer-portal-notification-settings.md).

   - **Excluded Work Order Types**: Work order types that you don't want to expose as an option in the portal.

   - **Excluded Accounts**: Customer accounts that you don't want to enable in the portal. Contacts related to excluded accounts don't receive invites to the portal either.

1. On the **Display** tab, set basic design values for the portal. The **Advanced Display Configuration** field contains the direct link to open [the Power Pages designer](/power-apps/maker/portals/configure/configure-portal). Use the Portal Management app to configure all the details for your portal.

1. If you enabled **Track My Technician**, select the **Track My Technician** tab and [configure track my technician settings](customer-portal-technician-tracking.md#configure-track-my-technician-settings).

1. If you enabled **Self Scheduling (Preview)**, select the **Self Scheduling (Preview)** tab and configure scheduling parameters.

   - **Minimum lead time for new bookings (days)**: The minimum time, in days from today, during which the customer can schedule their booking.

   - **Maximum lead time for new bookings (days)**: The maximum time, in days from today, during which the customer can schedule their booking.

   - **Enable Asset Selection**: If you want the customer to select a specific asset to associate with their account while they schedule their booking, set it to **Yes**.

   - **Enable Additional Details**: If you want the customer to submit extra text while scheduling the booking, set it to **Yes**. The system saves the text as a note on the booking timeline.

   - **Default Radius Unit**: The radius unit to miles or kilometers.

   - **Include Resource with maximum travel radius**: The maximum radius from the scheduled location in which a resource can be scheduled.

   > [!NOTE]
   > The travel radius settings are shared with the [schedule board in Field Service](work-with-schedule-board.md). Changing the value on one changes the value for the other.

1. Select **Save & Close**.

## Configure incident types for the portal

As part of the self-scheduling experience, the customer can select the incident type (shown as **Service Type**) that represents the work needed. As a Field Service administrator, you can make specific incident types available to your customers and set a user-friendly display name for the incident type shown on the self-scheduling portal.

1. Open an [existing incident type](configure-incident-types.md).

1. On the **General** tab, set the **Enable for C2** setting to **Yes** and provide a **Display Name** for the portal.

   :::image type="content" source="media/SS_Incident_Type-displayname.svg" alt-text="Screenshot of the Customer Portal settings, showing the field for the user-friendly name for incident types.":::

1. On the **Details** tab, set a **Default Work Order** type that is associated with a price list for the incident type.

1. Set an estimated duration for the incident type. This value is the work duration shown in the portal.

## Configure identity providers for the portal

The portal requires customers to authenticate before they can open service requests. By default, the portal uses local authentication. Administrators can add and change authentication options. Learn more at [Overview of authentication in Power Apps portals](/powerapps/maker/portals/configure/configure-portal-authentication).

## Customize the portal design

Makers can update the design and styling of your portal to meet your branding requirements. Use the [Power Pages design studio](/power-pages/configure/editing-sites) or the [legacy Power Apps portals Studio](/power-apps/maker/portals/portal-designer-anatomy) to customize the portal site.

You can only [edit elements in the header and footer](/power-pages/getting-started/edit-header), and content snippets. [Updating content snippets](/power-apps/maker/portals/configure/customize-content-snippets) in the portal also updates notifications if they're enabled.

## Update the Field Service portal

When we release new features, we don't update your portal automatically. An administrator must apply them to your environment. For more information, see [Update a website package](/power-pages/admin/update-solution#update-a-website-package).

## Next steps

- [Set up notifications for the Field Service portal](customer-portal-notification-settings.md)
- [Let customers schedule service appointments (preview)](customer-portal-self-scheduling.md)
- [Track a technician on the Field Service portal](customer-portal-technician-tracking.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
