---
title: Understand the sales pipeline chart and its phases
description: Understand how sales reps or managers use the Sales Pipeline chart to visualize revenue for an opportunity.
ms.date: 03/27/2025
ms.topic: concept-article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope:
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-*
  - D365-UI-Dashboard
  - Dynamics 365
  - Sales
  - Customer Engagement
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:11/17/2023
  - bap-template
---
# Understand the sales pipeline chart and its phases

As a seller or sales manager, you can use the out-of-the-box Sales Pipeline chart to visualize the value of the opportunities in each pipeline phase. This chart helps you understand the health of your sales pipeline and focus on the opportunities that are most likely to close. For example, if you see that a large number of opportunities are in the **Develop** phase, you can prioritize those opportunities and take action to move them to the next phase, before looking at the opportunities in the **Qualify** phase. 

:::image type="content" source="media/sales-pipeline-chart.png" alt-text="Screenshot of the sales pipeline chart.":::

The colors of the pipeline phases in the chart are based on the category values of the business process flow stages. The legend at the top of the chart shows the colors associated with each pipeline phase. To understand the sales pipeline phases, see [Understand the sales process](nurture-sales-from-lead-order-sales.md)

> [!NOTE]
> If you've associated different stages of the business process flow to multiple entities, the pipeline phases shown in the chart will only be based on the stages associated with the opportunity entity. For example, if you've associated only the qualify and develop stages with the opportunity entity, the chart displays data only for these two stages.

The pipeline phase of an opportunity is based on the stage of the business process flow that it's currently in. When an opportunity moves through the stages of its business process flow, the pipeline phase is set to a value in the form of _{StageCategoryIndex} - {CategoryName}_. Learn more about business process flows in [Create or customize a business process flow](customize-business-process-flows.md).

The following screenshot shows how the admin can configure the business process flow stages and their categories in Power Apps.

:::image type="content" source="media/opportunity-sales-process-definition.png" alt-text="Screenshot of the sales process definition.":::

## Related information

- [Manage opportunities using pipeline view](use-opportunity-pipeline-view.md)  
- [Gain insights with dashboards in Dynamics 365 Sales](dashboards.md)  
- [Troubleshooting sales pipeline chart and its phases](/troubleshoot/dynamics-365/sales/troubleshoot-sales-pipeline-issues)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
