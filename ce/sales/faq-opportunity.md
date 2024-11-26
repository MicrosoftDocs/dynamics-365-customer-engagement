---
title: Opportunity management FAQs
description: Get answers to frequently asked questions about opportunity management.
ms.date: 07/25/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Opportunity management FAQs

This article answers frequently asked questions about Opportunity management in Dynamics 365 Sales, Sales premium, and Sales professional.

## Where is the deal manager workspace?

The deal manager workspace has been replaced by the [opportunity pipeline view](use-opportunity-pipeline-view.md). All deal manager links or bookmarks are automatically redirected to the **My Open Opportunities** view. Select **Show As** > **Pipeline view** to open the opportunity pipeline view.

## Are there any differences between the opportunity pipeline view and the deal manager workspace?
  
Yes. The following table describes the differences between the deal manager workspace and the opportunity pipeline view.

| **Component** | **Opportunity pipeline view** | **Deal manager** |
|-----------|------------|-----------|
| Access control | Available for all users who have access to the Opportunities page. | Available only for security roles that were granted access to the workspace. |
| Editable grid | Uses the Power Apps editable grid control and can be customized in Power Apps. | Customization was done using JavaScript. |
| Side panel | Uses the default opportunity form in the side panel. | A separate **In Context View** form was used in the side panel with limited customizations. |

## Why can't I find the pipeline view option?

There are several possibilities:
- The **Show As** option may be hidden in the three-dot menu on the **Opportunities** page.
- Your administrator might have customized the **Show As** list. Ask your administrator to [add the control](opportunity-pipeline-view-for-admins.md#set-the-pipeline-view-as-the-default-opportunities-view).
- Your organization might not have opted in for early access features. Contact your administrator if you'd like to try them out.
- Your administrator might have disabled custom views for opportunities. Ask your administrator to [add the view manually](opportunity-pipeline-view-for-admins.md#set-the-pipeline-view-as-the-default-opportunities-view).

## Why aggregate functions return unexpected values in the Pipeline view?

When you use a linked entity in the filter of the Pipeline view, you notice that the value displayed in the **Metrics** section is different from the actual value. The following example shows how the count value is different from the total number of rows.

:::image type="content" source="media/aggregation-issue.png" alt-text="Screenshot depicting the pipeline view aggregation issue.":::

In this example, the filter is based on quotes that were created by the user. If the user has created two quotes for the same opportunity, the opportunity count is displayed as two. This is because the aggregate function counts the number of records returned by the filter. The same behavior is observed when you use the **Sum** or **Average** functions.

## Why can't I edit Est. Revenue in the Opportunity form?

To edit **Est. Revenue** in the **Opportunity** form, **Revenue** must be set as **User Provided** and the opportunity must be in an **Open** state.

:::image type="content" source="media/faqs-est-revenue.png" alt-text="Screenshot of an opportunity record with Revenue highlighted.":::

## Why aren't estimated revenue and total amount calculated automatically?
  
When you add products to an opportunity, quote, order, or invoice, the **Est. Revenue** and **Total Amount** fields are automatically updated only if you've selected system pricing calculation. For more information, go to [Configure product catalog settings](configure-product-catalog-settings.md).

## What do I need in order to use opportunity scoring?​

Install [!INCLUDE[pn_dynamics_sales_insights](../includes/pn-dynamics-sales-insights.md)] and use the standard opportunity entity.​ A minimum number of opportunities is required to build a scoring model:

To build an opportunity scoring model, you need to have a minimum of 40 won and 40 lost opportunities.  

The opportunities must have been created on or after January 1, in the previous year.


<a name="opportunity-per-stage-scoring"></a>

## How do I verify whether I have the required number of opportunities to create a per stage scoring model?

If you're planning to use the [per stage model](configure-predictive-opportunity-scoring.md#what-is-a-per-stage-model) in your opportunity scoring, ensure that you have a minimum of 40 closed opportunities in the **last stage** of the business process flow. If you aren't planning to use the per stage model, see [this section](faq-lead.md#scoring-minimum-requirement) to verify the minimum requirement.

1. On the Opportunities page, select **Closed Opportunities** from the view selector.

1. Select **Add** and set the following filters:
   - **Created On** = **Last 6 months**.

1. Select **Add** > **Add related entity** and set the following filters:
   - **Related entity** = **Lead to opportunity Sales Process** 
   - **Operator** = **Contains data**
   - **Field** = **Active Stage**
   - **Operator** = **Equals**
   - **Value** = **Close**
1. Select **Add** > **Add row** and set the following filters:
   - **Field** = **Status Reason**
   - **Operator** = **Does not equal**
   - **Value** = **Aborted**

## How often are the predictive scores updated?

**Lead scores:** For new leads, the scoring happens in near real-time. The score is displayed within 15 minutes of saving a new lead. For updated leads, the scores are refreshed every 24 hours.

**Opportunity scores:** For new and updated opportunities, the scores are refreshed every 24 hours.

## Can I customize the model?

Yes, you are able to modify which attributes are selected to train the model. That said, the out-of-the-box model automatically selects the attributes it determines are most relevant for your business.

## Can I create multiple models for opportunities?​

Yes, you can add and publish multiple models that are specific to each line of business in your organization. More information: [Add a model](configure-predictive-opportunity-scoring.md#add-a-model)

## What's the difference between a score and a grade?​

The score is generated by the machine learning model.  
The grade is just grouping scores in four buckets that the admin can configure.

