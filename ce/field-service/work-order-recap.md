---
title: Work order recap with Copilot in Field Service (preview)
description: Let AI generate a work order recap to quickly understand the state of a work order and get appropriate next steps.
ms.date: 03/19/2024
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

The summary feature adheres to [responsible AI guidelines](faqs-work-order-recap.md) and avoids information that violates certain restrictions. The content of a recap isn't saved. It's only available to the user who generated it. Users must generate their own recaps, and the content is based on their permissions.

Watch this brief video to learn more about the new work order experience in Field Service, including work order recaps:

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW18MN2]

## Prerequisites

- Your environment must be in the United States or the United Kingdom.

- The feature is disabled by default for environments in the United Kingdom. An administrator must enable [**Copilot for work order**](configure-default-settings.md#features-settings).

- You must have a paid Field Service environment. The work order recap feature isn't available in trial environments.

- You must [update your environment](update-field-service.md) to the latest Early Access build for 2023 wave 2.

## How recaps are generated

When you generate a recap, the system uses the work order ID and your security profile to determine whether relevant data exists and that you have access to it. If so, the system pulls contextual information directly from the work order and related records to generate the summary.

By default, Copilot provides summaries based on a list of fields that Microsoft maintains. Administrators can [change the summary configuration](#configure-the-summary) to meet their business needs.

The default summary includes the following data fields from work orders and related records:  

- Booking information
- Activity details
- Notes from the work order and bookings
- Work order product details
- Work order service details
- Work order service tasks
- Asset information and work order history

The recap focuses on the most relevant information based on the work order's lifecycle stage.

- **Unscheduled**: Information that's relevant to scheduling the work order, like requirements.

- **Scheduled**: Information that's relevant to planning, arrival at the work order site, and understanding the issue. For example, asset information and the asset's work order history.

- **In Progress**: Information that's relevant to completing the work order and the current state of work, like asset information and the asset's work order history.

- **Completed**, **Posted**, and **Canceled**: The core information in all recaps includes a summary of costs and prices and, for completed and posted work orders, invoice details.

## Summary configuration (preview)

Administrators can configure the information for the AI-generated summary to tailor the output to their business needs.

:::image type="content" source="media/configure-summary-settings.svg" alt-text="Screenshot of the summary configuration for the copilot-based summary control.":::

### Configure the summary

1. In Field Service, change to the **Settings** area and go to **Copilot settings** > **Summary configuration**.
1. Open the configuration template for the records you want to configure. Currently, the summary supports two entity templates: work orders and bookable resource bookings.
1. Set the **Configure summary** setting to **On**.
1. The summary includes data fields based on record types. You can change, remove, and add more mappings. Depending on the record type you choose, different data fields might be available.
1. **Save** your changes when you're done making changes.

### Test configuration

In the **Sample summary** section, you can choose a record from your system as sample data and select **Test** to see a sample output based on the summary configuration.

### Reset to default configuration

To reset an updated summary configuration to the recommended defaults, select **Reset to recommendation** on the summary configuration record and save the changes. If you want to use the summary configured by Microsoft, turn off the **Configure summary** setting.

## Generate a summary in the web app

Open a [work order form (preview)](work-order-experience.md) or a booking record.

- To generate a recap, select **Generate** in the **Copilot** control.

- To refresh the recap, select **Regenerate** in the **Copilot** control.

Use the like/dislike buttons in the **Copilot** control to provide feedback and, optionally, more context about your preferences. Your feedback helps us understand if the recap is useful or not and why.

## Generate a summary in the mobile app

Frontline workers can get valuable contextual information about their scheduled work using work order recaps in the Field Service mobile app. You can generate a recap on your mobile device and refresh it as you progress through the work order lifecycle. Your device must be connected to the Internet for the recap feature to work.

To enable work order recaps in the Unified Interface mobile app, an administrator needs to enable the feature in the settings area.

When the feature is enabled, the Copilot control is added to the **Bookable Resource Booking** form. If your Bookable Resource Booking form is customized, it might require configuring the work order recap control onto the form.

### Configure the work order recap component

The work order recap control can be configured only on the **Bookable Resource Booking** and **Work Order** forms. Follow these steps to add the control:

1. In the Field Service Mobile app module, change to the **Settings** area and go to the **Features** page.
1. In the Preview section, enable **Copilot Recap for Mobile (Unified Interface)**.
1. Sign in to [Power Apps](https://make.powerapps.com).
1. Select your environment.
1. Go to **Apps** and select the **Field Service Mobile** app module
1. Edit the *Bookable Resource Booking* or *Work Order* form.
1. Add the component **Field Service Copilot - Recap** to a section on the form.
1. Set **Table column** as **System Status (Choice)**.
1. In the side pane, under **Display options**, enable **Hide label**.
1. **Save and publish** the form and publish the app module.

## Summaries in the new mobile user experience

The recap feature is available for the new user experience in the Field Service mobile application. When the new mobile experience is enabled, Copilot Recap (Summarize) can be enabled from the Field Service Mobile app settings. Once enabled, the Copilot Summarize and [Copilot Update](work-order-update.md) features are available from the header area of the mobile booking within the new experience. Open a booking form in the new mobile user experience and select the Copilot icon. Select **Summarize** to get a recap of the work order to which the booking relates.

### See also

- [FAQ about work order recap with Copilot (preview)](faqs-work-order-recap.md)
- [New work order experience (preview)](work-order-experience.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
