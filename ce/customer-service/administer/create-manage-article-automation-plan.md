---
title: Create and manage knowledge article automation plans
description: Create knowledge article automation plans to generate and update articles from cases. Follow these steps to define conditions and output settings.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.date: 11/27/2026
ms.custom: bap-template
---

# Create and manage knowledge article automation plans

Create knowledge article automation plans to determine which records are processed and how knowledge articles are generated or updated. Plans can run bulk processing, near real-time processing, or both. You can define conditions to control which records are used to create or update knowledge articles. To create a plan:

1. In Copilot Service admin center, go to **Support experience** > **Knowledge**.
1. Select **Manage** for **Customer Knowledge Management Agent**. The **Customer Knowledge Management Agent** page appears.
1. In the **Knowledge Automation Plan** section, select **Create**.
1. In the **New knowledge automation plan** dialog box, provide the following information:

  1. For **Basic details**:

      - Enter a plan name and select a knowledge source.
      - Select **Manage attributes** and specify the fields to use for knowledge articles. Learn more in [Configure attribute mapping for knowledge discovery plans](#configure-attribute-mapping-for-knowledge-discovery-plans).
        > [!NOTE]
        > Custom attributes are supported only for cases and custom record types. Conversations use predefined attributes.
      - Save and close.
      
  1. For **Conditions setup**:

      - If you select a **Case** or custom record as the knowledge source, use natural language eligibility filters to specify which cases or custom records the plan processes for knowledge article generation and which cases it excludes. Select the conditions from the **Record eligibility filters (AI-evaluated)** dropdown list to determine which cases a plan processes. A default set of conditions, called **Default eligibility condition**, is provided.

        > [!NOTE]
        > Eligibility filter groups are supported for case-based knowledge discovery and custom records only. Conversations don't support this capability.
    
      - To create a condition group, select **Add**. On the **Condition** dialog box, provide a name, description, and the conditions that cases must meet to be used for article generation. Save the changes.
      - You can create reusable groups of conditions and apply them across multiple plans without having to recreate the criteria.
      - You must add at least one condition that records must meet before being used for article creation or update. You can add, edit, or delete conditions to a plan.

  1. For **Output setup**:

      Plans can process both historical and new records within a single configuration. Instead of maintaining separate configurations for historical processing and near real-time processing, you can define a time range for existing records and continue processing incoming records with the same plan.

      - Select the historical records duration from which articles must be generated from the **First, generate articles from historical records in** dropdown list. If you select **No backfill**, the plan doesn't run bulk processing.

      - Select for which records the plan must keep running from the **Then keep the plan running** dropdown list. If you select **Backfill** and set the schedule to **Just once**, the agent performs a one-time bulk processing run only and doesn't process records in near real time.

      - Select the article template and the output language. The template and language configured as defaults are preselected when a plan is created. You can change these settings at the plan level, which overrides the default configuration.

      - Select **Automatically update existing articles**, if you want the agent to automatically apply minor updates to existing knowledge articles. By default, a new minor version of the article is created with the updated information. We recommend that you select this option so that new records can continuously contribute updates to your knowledge articles.

      - Select **Automatically publish compliant articles**, to configure whether Customer Knowledge Management Agent can automatically publish articles and minor updates that meet the specified **Compliance** status. You can also select the target audience that can view the published articles.

      - Select **Internal target audiences** if you want articles to be available to your service representatives and Copilot internally. 
      - Select **Internal and external target audiences** if you want to publish these articles to external portals.

1. Save and activate the plan. Record processing starts immediately upon activation.

You can edit, activate, or deactivate a plan. A paused plan isn't evaluated until it is resumed. You can also manage the real-time run order of the plans. Select **Manage real-time run order** and on the dialog box, select the record type from the dropdown list and manage the plan order by moving the plans up or down as required. Save the order.

This section displays all plans configured for real-time processing. Records are evaluated from top to bottom, and when a record matches more than one plan, the first matching plan is used while the remaining plans are ignored.

## Configure attribute mapping for knowledge discovery plans

You can configure attribute mapping at the plan level. This configuration allows different knowledge discovery plans to use different sets of attributes. The system uses the attributes you select to generate knowledge articles. The configuration applies consistently across bulk and real-time knowledge discovery modes. The configuration supports both:

- 1-to-1 attributes, which map a single related record to the generated article. You can map up to 10 attributes.
- 1-to-many attributes, which map multiple related records to the generated article. You can map up to 6 attributes.

When you create a plan, the following attributes are configured by default. You can remap the attributes to different fields, and disable or delete them, except for the **Title** and **Description** attributes.

| Data type | Record type | Field | Description |
| --- | --- | --- | --- |
| 1-to-1 | Case | Title | Title text |
| 1-to-1 | Case | Description | Description text |
| 1-to-1 | Product | Name | Product |
| 1-to-1 | Subject | Title | Subject |
| 1-to-many | Incident Resolution | Description | Incident Resolution |
| 1-to-many | Email Content | Description | Email Content |
| 1-to-many | Conversation Summary | Description | Conversation Summary |
| 1-to-many | Note (Regarding) | Description | Case Notes |

## Monitor plan results

After you activate a knowledge plan, you can monitor article creation, article updates, knowledge coverage improvements, and record-processing results from the plan results page.

The page provides visibility into knowledge discovery progress, generated knowledge articles, and the impact of the plan on overall knowledge coverage.

The **Articles Summary** section provides a consolidated view of article creation and update activities. Use this section to understand how many draft articles require review before publication.

This section displays:

- **Articles created**: Number of new draft knowledge articles generated.
- **Articles updated**: Number of existing knowledge articles updated by the agent.
- **Review draft articles**: Opens generated draft content for review.

The **Processed records** section lists records evaluated by the plan. Use the filters and search box to find specific processing results.

- **Record filter**: Filter records by processing scope.
- **Outcome filter**: Filter records by processing outcome.
- **Search**: Search for specific records or articles.

The table displays information such as **Record processed**, **Outcome**, **Knowledge Article Title**, and **Date**. Use these details to understand how individual records contributed to article creation or updates.

## Related information

[Review knowledge articles created by the Customer Knowledge Management Agent](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent)  
[Use knowledge insights for Customer Knowledge Management Agent](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent)