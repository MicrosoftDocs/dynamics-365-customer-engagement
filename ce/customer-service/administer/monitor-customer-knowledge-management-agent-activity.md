---
title: View the Customer Knowledge Management Agent dashboard
description: The Customer Knowledge Management Agent dashboard shows how each record is processed. Filter by outcome, review generated articles, and export data for audits.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.date: 11/27/2026
ms.custom: bap-template
---

# View the Customer Knowledge Management Agent dashboard

Use the Customer Knowledge Management Agent dashboard to track every record that Customer Knowledge Management Agent processes across all your knowledge article automation plans. Use search, filters, and sorting to review historical processing activity, understand why a record did or didn't result in a knowledge article, and review the articles that the agent creates or updates.

## Prerequisites

- You have the **System Administrator** role or the **Customer Service Manager** role.
- You configured and activated at least one knowledge article automation plan.
- Customer Knowledge Management Agent processed at least one record.

## View the dashboard

1. In Copilot Service admin center, go to **Support experience**> **Knowledge**.
1. Select **Manage** for **Customer Knowledge Management Agent**. The **Customer Knowledge Management Agent** page appears.
1. In the **Knowledge Automation Plan** section of the **Customer Knowledge Management Agent** page, select an active plan  to monitor the Customer Knowledge Management Agent activity for the specific plan.

    You see specific plan details such as **Knowledge Coverage Impact**, **Articles Summary**, and **Processed records**.

## Dashboard details

To view the processed records across all plans on the plan page, select the **Customer Knowledge Management Agent Dashboard** link.

### Processed records

The **Processed records** grid lists each record that the agent processed. By default, the grid is sorted by **Processed On**, with the most recent records first.

| Column | Description |
|---|---|
| **Plan name** | The plan that processed the record. Select the plan name to open the plan.|
| **Record processed** | The source record that the agent analyzed, such as a case. |
| **Outcome** | The result of processing the record. Learn more in Processing outcomes. |
| **Knowledge Article Title** | The title of the article that the agent created or updated, or the existing article that already covers the content. |
| **Processed On** | The date and time when the agent processed the record. |

### Outcome values

The dashboard displays one of the following outcomes for each processed record.

| Outcome | Description |
|---|---|
| **Already covered** | The information in the record is already represented in an existing knowledge article. No action is taken.|
| **Article created** | No existing knowledge article matched. The system created a new article and linked it to the source record.|
| **Article updated** | The system found an existing knowledge article with related content. It added new information to the article to keep it current. |
| **Not relevant**| The content didn't contain knowledge valuable for reuse. The system didn't create or update a knowledge article.|
| **Quality check rejected**|The generated content failed one or more quality validation checks. The system didn't publish the content to avoid inaccurate or incomplete knowledge. |
| **Processing error**| An unexpected system or processing issue occurred during execution. The system couldn't complete the request and it might require a retry.|

### Filter and search records

Use the available controls to narrow down dashboard results:

- **All plans**: View records processed by a specific plan or across all plans.
- **All records**: Filter records by record type.
- **All outcomes**: Display records with a specific processing result.
- **Search**: Search for records, plans, or knowledge articles.
- **Sort**: Sort results by any column, such as processing date.

### Review article activity

Select a knowledge article title in the grid to open and review the corresponding article. Use this information to:

- Verify newly generated content.
- Review updates applied to existing articles.
- Assess the quality and relevance of generated knowledge.

### Export dashboard data

Use the **Export** option to export dashboard activity data for reporting, auditing, or analysis purposes.

## Related information

[Review knowledge articles created by the Customer Knowledge Management Agent](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent)  
[Use knowledge insights for Customer Knowledge Management Agent](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent)