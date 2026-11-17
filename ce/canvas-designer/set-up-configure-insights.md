---
title: Set up and configure insights (preview)
description: Set up insights, choose the business data Copilot can use, add business instructions, and configure organization-wide settings.
ms.date: 11/17/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Set up and configure insights (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Set up insights to give supported canvases and agents shared business context. You can configure insights only for Account and Contact tables.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you begin, ensure that:

- You have the **Contact and Account Insights Admin** security role to turn on, create, and edit insights. This role isn't assigned automatically.
- You have the **System Administrator** security role for the one-time setup of your business data, business skills, duplicate detection, and Work IQ.
- You have the Work IQ license.
- You set up Copilot credits for your environment in Canvas studio. Insights use your organization's Copilot credits. For more information, see [Copilot credits](insights-overview.md#copilot-credits).

## Open the insights setup

You can open the insights setup from the Sales Hub app or Copilot Service Admin Center app. Depending on the app you're using, follow the appropriate navigation path to open the insights setup:

**Sales Hub:** 
    1. From the lower-left corner of the Sales Hub app, select **App Settings**.
    1. Select **Dynamics 365 AI hub** > **Canvas Studio**.
    1. From the **Insights** section, select **Set up insights**.
**Copilot Service Admin Center:** 
    1. Select **Agent Hub** from the Home page.
    1. From the **Canvas studio** card, select **Open canvas studio**.
    1. From the **Insights** section, select **Set up insights**.

The setup wizard contains four steps: **Prerequisite**, **Choose your business data**, **Teach Copilot how your business works**, and **Review**.

## Complete the prerequisites

On the **Prerequisite** page, set up Work IQ. Work IQ is required for default insights and custom insights.

1. If its status is **Not set up**, select **Set up**.
1. In the Power Platform admin center, turn on Work IQ for the current environment. This step requires a Power Platform administrator role.
1. Return to Canvas studio, and then select **Refresh**.
1. When the status changes to **Ready**, select **Continue**.

## Choose your business data

The **Choose your business data** page lists the Dataverse tables that insights can use. 

1. Review the included tables.
1. To include more standard or custom tables, select **Add more tables**.
1. Search for and select the tables to include.
1. Select **Add tables** and **Continue**.

You can select **Skip** and add tables later. Adding a table doesn't grant users permission to its records.

> [!NOTE]
> In Power Apps, this business-data configuration is called the semantic model. Insights use Dataverse search to index configured tables, which can use Dataverse storage capacity.

## Teach Copilot how your business works

Add business instructions to explain your processes, policies, terminology, and table relationships in plain language.

1. On **Teach Copilot how your business works**, select **Add instructions**.
1. Search for and select existing instructions in the environment, and then select **Add instructions**.
1. To create instructions, select **Write new instructions**.
1. Enter the following information:

   - **Name:** A short, recognizable name.
   - **Description:** When and why Copilot should use the instructions.
   - **Instructions:** The definitions, relationships, steps, exceptions, and time periods that Copilot should apply. Write instructions as if you're briefing a new employee. Avoid vague terms that aren't defined elsewhere. The following example defines organization-specific account tiers and fiscal periods:

    Treat an active account as strategic when its Account tier is Tier 1 or its annual revenue is greater than 10 million USD. Our fiscal year starts on July 1. Use fiscal quarters for every quarter-based calculation.

1. Select **Save** and then **Continue**.

In Power Apps, these instructions are called business skills. You can select **Go to Power Apps** to manage advanced business-skill settings.

## Review and complete setup

1. On **Review your insights setup**, verify the following information:

   - Work IQ is ready.
   - The correct tables are selected under **Your business data**.
   - The correct instructions are listed under **How your business works**.

1. Select **Complete setup**.

After the setup finishes, insights for Account and Contact canvases are turned on. The first synchronization of the semantic model can take up to two hours.

## Change insights settings

Choose more tables, and add or modify instructions as needed.

1. In Canvas studio, select **Manage insights**.
1. In the page header, select **Settings**.

The **Insights management settings** pane contains organization-wide settings. 

## Configure duplicate detection

Duplicate detection helps supported account and contact insights account for records that represent the same customer. It doesn't merge, delete, or reparent records.

1. Open [Insights management settings](#change-insights-settings).
1. In **Insights management settings**, expand **Duplicate detection** and select **View or tailor the definition**.
1. Review the current matching rules and technical definition.
1. Edit the instructions to describe how your organization identifies duplicates. 
1. Select **Review changes**.
1. Review the rules marked **New** or **Removed**.
1. Select **Save**.
1. Turn on **Duplicate detection**.

 To restore default instructions, select **Reset to Microsoft's**, review the changes, and save them.

When duplicate detection is on, insights on account and contact canvases show values rolled up across the customer's duplicate records. There's no separate setting on the canvas.

## Configure activity sentiment

Activity sentiment labels supported activities as positive, neutral, or negative on canvas timelines.

1. In **Insights management settings**, turn on **Activity sentiment**.
1. Select **Choose activities and preview**.
1. Select the activity types that Copilot should read.
1. Review the timeline preview.

Activity sentiment uses Copilot credits for each activity that it reads. Turn it off when your organization doesn't need sentiment labels.


## Related information

- [Insights overview for administrators](insights-overview.md)
- [Create and manage custom insights](create-manage-custom-insights.md)
- [Fine-tune semantic model signals](/power-apps/maker/data-platform/fine-tune-semantic-model-signals)
- [Create and use business skills](/power-apps/maker/data-platform/data-platform-business-skills)
- [Manage participation in Work IQ](/power-platform/admin/business-applications-work-iq/manage-participation)
