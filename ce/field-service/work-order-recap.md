---
title: Work order summary with Copilot in Field Service
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

# Summarize records with Copilot in Field Service

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

By default, Copilot provides summaries based on a list of fields that Microsoft maintains. Administrators can [change the summary configuration](#configure-the-summary) to meet their business needs.

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

## Summary configuration

Copilot in Field Service provides predefined summaries that are optimized for specific tables. With summary configuration, administrators can replace the default summaries by configuring their own to tailor to their business needs. The optimization used in the generation of default summaries isn't applied to administrator-configured summaries.

:::image type="content" source="media/copilot-summary-configuration.png" alt-text="Screenshot of the summary configuration for the copilot-based summary control.":::

> [!TIP]
> To generate configured summaries, users need read permission for the *msdyn_fieldservicesummaryconfiguration* table. [Update custom security roles](/power-platform/admin/security-roles-privileges#table-privileges) to avoid issues when generating a configured summary.

### Configure the summary

1. In Field Service, change to the **Settings** area and go to **Copilot settings** > **Summary Configuration**.
1. From the list, choose the table for which you want to configure the summary. Currently, you can configure two out-of-the-box tables: work orders and bookable resource bookings.
1. Enable the **Configure summary** setting.
1. You can add, remove, and change the data columns that Copilot uses to generate the summary. Under **Table name**, open the drop-down to search or select the table by navigating through relationships. After you choose a table, the columns of the table will be available under **Column name**.
1. In the **Sample summary** section, you can test this configuration using a row from the Dataverse table and preview the summary that Copilot generates based on real data.
1. **Save** your changes when you're done making changes.

> [!NOTE]
> In cases where Field Service was pre-installed in an environment, you might see an empty list in **Summary Configuration** even after enabling the feature. To resolve, go to a work order and generate a summary. This reinitializes the out-of-the-box summary configuration and populates the list. Then, navigate back to **Summary Configuration**.

### Revert to the predefined summary

To use the default summary provided by Field Service, disable the **Configure summary** setting.

## Generate a summary in the web app

Open a [work order form](work-order-experience.md) or a booking record.

- To generate a summary, select **Generate** in the **Copilot** control.

- To refresh the summary, select **Regenerate** in the **Copilot** control.

Use the like/dislike buttons in the **Copilot** control to provide feedback and, optionally, more context about your preferences. Your feedback helps us understand if the summary is useful or not and why.

## Generate a summary in the mobile app

Frontline workers can get valuable contextual information about their scheduled work using work order summaries in the Field Service mobile app. You can generate a summary on your mobile device and refresh it as you progress through the work order lifecycle. Your device must be connected to the Internet for the summary feature to work.

To enable work order summaries in the Unified Interface mobile app, an administrator needs to enable the feature in the **Settings** area.

When the feature is enabled, the Copilot control is added to the **Bookable Resource Booking** form. If your Bookable Resource Booking form is customized, it might require configuring the work order summary control onto the form.

### Configure the work order summary component

The work order summary control can be configured only on the **Bookable Resource Booking** and **Work Order** forms. Follow these steps to add the control:

1. In the Field Service Mobile app module, change to the **Settings** area and go to the **Features** page.
1. Enable **Copilot Recap for Mobile (Unified Interface)**.
1. Sign in to [Power Apps](https://make.powerapps.com).
1. Select your environment.
1. Go to **Apps** and select the **Field Service Mobile** app module.
1. Edit the *Bookable Resource Booking* or *Work Order* form.
1. Add the component **Field Service Copilot - Recap** to a section on the form.
1. Set **Table column** as **System Status (Choice)**.
1. In the side pane, under **Display options**, enable **Hide label**.
1. **Save and publish** the form and publish the app module.

## Summaries in the new mobile user experience

The summary feature is available for the new user experience in the Field Service mobile application. When the new mobile experience is enabled, Copilot Recap (Summarize) can be enabled from the Field Service Mobile app settings. Once enabled, the Copilot Summarize and [Copilot Update](work-order-update.md) features are available from the header area of the mobile booking within the new experience. Open a booking form in the new mobile user experience and select the Copilot icon. Select **Summarize** to get a summary of the work order to which the booking relates.

### See also

- [FAQ about work order summary with Copilot](faqs-work-order-recap.md)
- [New work order experience](work-order-experience.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
