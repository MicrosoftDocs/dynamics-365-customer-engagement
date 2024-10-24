---
title: Work order summary with Copilot in Field Service (preview)
description: Let AI generate a work order summary to quickly understand the state of a work order and get appropriate next steps.
ms.date: 06/14/2024
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
ms.reviewer: m-hartmann
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/30/2023
ms.collection: bap-ai-copilot 
---

# Summarize records with Copilot in Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The AI-generated work order and booking recap in Dynamics 365 Field Service provides a summary of a record and its related data. It helps service managers, dispatchers, and frontline workers quickly understand the context and the next steps. The recap summarizes the record's history, future actions, arrival times, work criticality, required parts, and other contextual information.

The summary feature adheres to [responsible AI guidelines](faqs-work-order-recap.md) and avoids information that violates certain restrictions. The content of a summary isn't saved. It's only available to the user who generated it. Users must generate their own summaries, and the content is based on their permissions.

Watch this brief video to learn more about the new work order experience in Field Service, including work order summaries:

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW18MN2]

## Prerequisites

- The feature is disabled by default for environments in the United Kingdom. An administrator must enable [**Copilot for work order**](configure-default-settings.md#features-settings). For regional availability, see the [Copilot International Availability Report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

- You must have a paid Field Service environment. The work order summary feature isn't available in trial environments.

- You must [update your environment](update-field-service.md) at least to the latest Early Access build for 2023 wave 2.

## How summaries are generated

When you generate a summary, the system uses the work order ID and your security profile to determine whether relevant data exists and that you have access to it. If so, the system pulls contextual information directly from the work order and related records to generate the summary.

By default, Copilot provides summaries based on a list of fields that Microsoft maintains. Administrators can [change the summary configuration](#how-to-configure-the-summary) to meet their business needs.

The default summary includes the following data fields from work orders and related records:  

- Booking information
- Activity details
- Notes from the work order and bookings
- Work order product details
- Work order service details
- Work order service tasks
- Asset information and work order history

The summary focuses on the most relevant information based on the work order's lifecycle stage.

- **Unscheduled**: Information that's relevant to scheduling the work order, like requirements.

- **Scheduled**: Information that's relevant to planning, arrival at the work order site, and understanding the issue. For example, asset information and the asset's work order history.

- **In Progress**: Information that's relevant to completing the work order and the current state of work, like asset information and the asset's work order history.

- **Completed**, **Posted**, and **Canceled**: The core information in all summaries includes a recap of costs and prices and, for completed and posted work orders, invoice details.

## About summary configuration (preview)

Copilot in Field Service provides predefined summaries that are optimized for specific tables. With summary configuration, administrators can replace the default summaries by configuring their own to tailor to their business needs.

You need to configure the summary for the *bookable resource booking* and *work order* tables separately.

:::image type="content" source="media/copilot-summary-configuration.png" alt-text="Screenshot of the summary configuration for the copilot-based summary control.":::

### How to configure the summary

1. In Field Service, change to the **Settings** area and go to **Copilot settings** > **Summary Configuration**.
1. From the list, choose the table for which you want to configure the summary. Currently, you can configure two out-of-the-box tables: work orders and bookable resource bookings.
1. Enable the **Configure summary** setting.
1. You can add, remove, and change the data columns that Copilot uses to generate the summary. Under **Table name**, open the drop-down to search or select the table by navigating through relationships. After you choose a table, the columns of the table will be available under **Column name**.
1. In the **Sample summary** section, you can test this configuration using a row from the Dataverse table and preview the summary that Copilot generates based on real data.
1. **Save** your changes when you're done making changes.

To revert to the default summary provided by Field Service, disable the **Configure summary** setting.

> [!NOTE]
>
> - To generate configured summaries, users need read permission for the *msdyn_fieldservicesummaryconfiguration* table. [Update custom security roles](/power-platform/admin/security-roles-privileges#table-privileges) to avoid issues when generating a configured summary.
> - The optimization used in the generation of default summaries, where there may be different details depending on work order status, is not applied to administrator-configured summaries.
> - In cases where Field Service was pre-installed in an environment, you might see an empty list in **Summary Configuration** even after enabling the feature. To resolve, go to a work order and generate a summary. This reinitializes the out-of-the-box summary configuration and populates the list. Then, navigate back to **Summary Configuration**.

## Generate a summary in the web app

Open a [work order form (preview)](work-order-experience.md) or a booking record.

- To generate a summary, select **Generate** in the **Copilot** control.

- To refresh the summary, select **Regenerate** in the **Copilot** control.

Use the like/dislike buttons in the **Copilot** control to provide feedback and, optionally, more context about your preferences. Your feedback helps us understand if the summary is useful or not and why.

## Add the summary control to a form

By default the work order summary is included on the out-of-the-box [work order form](work-order-experience.md). The control can be added to a custom work order or booking form for web or mobile.

1. Sign in to [Power Apps](https://make.powerapps.com).
1. Select your environment.
1. Go to **Apps** and select your app module.
1. Edit the *Bookable Resource Booking* or *Work Order* form.
1. Add the component **Field Service Copilot - Recap** to a section on the form.
1. Set **Table column** as **System Status (Choice)**.
1. In the side pane, under **Display options**, enable **Hide label**.
1. **Save and publish** the form and publish the app module.

## Enable the control

After configuring the summary control, enable it. It's enabled by default for the web app and and admin has to enable it for the mobile app.

Mobile:

1. In the Field Service Mobile app module, change to the **Settings** area and go to the **Features** page.
1. In the Preview section, enable **Copilot Recap for Mobile (Unified Interface)**.

Web app:

1. In the Field Service app module, change to the **Settings** area.

1. Go to **Field Service Settings**.

1. In the **General** section, turn on **Copilot for work order**.

## Enable summaries in the new mobile user experience

When the [new mobile experience is enabled](mobile/set-up-field-service-mobile.md#enable-the-new-mobile-user-experience), the copilot-based summary can be enabled from the Field Service Mobile app settings. Once enabled, the summary and [work order update](work-order-update.md) features are available from the agenda view of the new experience. Users can access Copilot by swiping on a booking, or from the action menu associated to a booking.

:::image type="content" source="media/mobile-copilot-control.png" alt-text="Screenshot of a mobile device showing the swipe action, copilot summary option, and a generated summary.":::

## Send feedback

Use the like/dislike buttons in the Copilot control to provide feedback and, optionally, more context about your preferences. Your feedback helps us understand if the summary is useful or not and why.

### See also

- [FAQ about work order summary with Copilot (preview)](faqs-work-order-recap.md)
- [New work order experience (preview)](work-order-experience.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
