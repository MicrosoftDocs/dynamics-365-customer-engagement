---
title: Enable work order summary with Copilot in Field Service
description: Use Copilot in Field Service to generate AI-powered work order summaries, quickly understand work order status, and take the next steps.
ms.date: 12/05/2025
ms.update-cycle: 180-days
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date: 10/30/2023
ms.collection: bap-ai-copilot 
---

# Enable work order summary with Copilot in Field Service

The AI-generated work order and booking recap in Dynamics 365 Field Service provides a summary of a record and its related data. It helps service managers, dispatchers, and frontline workers quickly understand the context and the next steps. The recap summarizes the record's history, future actions, arrival times, work criticality, required parts, and other contextual information.

The summary feature adheres to [responsible AI guidelines](faqs-work-order-recap.md) and avoids information that violates certain restrictions. Users must generate their own summaries, and the content is based on their permissions.

> [!IMPORTANT]
> The ability for [users to provide feedback](use-work-order-recap.md#send-feedback) for a work order summary is enabled by default. Environment administrators can control whether users are able to provide feedback for each individual environment from the organization table. The tenant level Copilot feedback setting in Power Platform admin center currently doesn't affect this feature. To ensure user feedback is disabled across your tenant, you must disable it for each environment.

## Prerequisites

- The feature is disabled by default for environments in the United Kingdom. An administrator must enable [**Copilot for work order**](configure-default-settings.md#features-settings). For regional availability, see the [Copilot International Availability Report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

- You must have a paid Field Service environment. The work order summary feature isn't available in trial environments.

## How summaries are generated

When you generate a summary, the system uses the work order ID and your security profile to check if relevant data exists and that you have access to it. If so, the system pulls contextual information directly from the work order and related records to generate the summary. The summary is generated in the language that you define in the personalization settings. It provides references so that you can navigate to the source records for more details.

By default, Copilot provides summaries based on a list of fields that Microsoft maintains. Administrators can [change the summary configuration](#how-to-configure-the-summary) to meet their business needs.

The default summary includes the following data fields from work orders and related records:  

- Booking information
- Activity details
- Notes from the work order and bookings
- Work order product details
- Work order service details
- Work order service tasks
- Asset information and work order history

## Summary configuration

Copilot in Field Service provides predefined summaries that are optimized for specific tables. With summary configuration, administrators can replace the default summaries by configuring their own to tailor to their business needs.

You need to configure the summary for the *bookable resource booking* and *work order* tables separately.

:::image type="content" source="media/copilot-summary-configuration.png" alt-text="Screenshot of the summary configuration for the copilot-based summary control.":::

### How to configure the summary

Administrators can follow the steps in this section to create a custom summary configuration from scratch. Alternatively, they can get started with [a configuration template based on the work order summary](/dynamics365/guidance/resources/fs-work-order-summary-configuration-template).

1. In Field Service, change to the **Settings** area and go to **Copilot settings** > **Summary Configuration**.
1. From the list, choose the table for which you want to configure the summary. Currently, you can configure two out-of-the-box tables: work orders and bookable resource bookings.
1. Enable the **Configure summary** setting.
1. You can add, remove, and change the data columns that Copilot uses to generate the summary. Under **Table name**, open the drop-down to search or select the table by navigating through relationships. After you choose a table, the columns of the table appear under **Column name**.
1. In the **Sample summary** section, you can test this configuration using a row from the Dataverse table and preview the summary that Copilot generates based on real data.
1. **Save** your changes.

To revert to the default summary provided by Field Service, disable the **Configure summary** setting.

> [!NOTE]
>
> - To generate configured summaries, users need read permission for the *msdyn_fieldservicesummaryconfiguration* table. [Update custom security roles](/power-platform/admin/security-roles-privileges#table-privileges) to avoid issues when generating a configured summary.
> - The optimization used in the generation of default summaries, where there might be different details depending on work order status, isn't applied to administrator-configured summaries.
> - In cases where Field Service was preinstalled in an environment, you might not see the summary configurations after enabling the feature. Select **Create default configurations** to add missing configurations.

### Transport summary configurations across environments

To migrate summary configurations to other Dynamics 365 Field Service environments, admins can use the Configuration Migration tool. For more information, see [Transport summary configurations across Dynamics 365 Field Service environments](/dynamics365/guidance/resources/fs-transport-summary-configuration).

## Enable summaries on mobile for Unified Interface

After configuring the summary control, enable it. It's enabled by default for the web app. An admin must enable it for the mobile app.

1. In the Field Service Mobile app module, change to the **Settings** area and go to the **Features** page.
1. In the Preview section, enable **Copilot Recap for Mobile (Unified Interface)**.

## Enable summaries in the new mobile user experience

When you [enable the new mobile experience](mobile/set-up-field-service-mobile.md#enable-the-new-mobile-user-experience), you can turn on the copilot-based summary from the Field Service Mobile app settings. After you enable it, the summary and [work order update](work-order-update.md) features appear in the agenda view of the new experience. Users can access Copilot by swiping on a booking or from the action menu associated with a booking.

:::image type="content" source="media/mobile-copilot-control.png" alt-text="Screenshot of a mobile device showing the swipe action, copilot summary option, and a generated summary.":::

## Add the summary control to a form

By default, the work order summary is included on the out-of-the-box [work order form](work-order-experience.md). You can add the control to a custom work order or booking form for web or mobile.

1. Sign in to [Power Apps](https://make.powerapps.com).
1. Select your environment.
1. Go to **Apps** and select your app module.
1. Edit the *Bookable Resource Booking* or *Work Order* form.
1. Add the component **Field Service Copilot - Recap** to a section on the form.
1. Set **Table column** as **System Status (Choice)**.
1. In the side pane, under **Display options**, enable **Hide label**.
1. **Save and publish** the form and publish the app module.

### Related information

- [FAQ about work order summary with Copilot](faqs-work-order-recap.md)
- [New work order experience](work-order-experience.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
- [Use work order summary with Copilot in Field Service](use-work-order-recap.md)