---
title: Work with Predictive lead scoring
description: Use the predictive lead scoring feature to prioritize your leads based on scores and achieve higher lead qualification rates.
ms.date: 05/10/2023
author: lavanyakr01
ms.author: lavanyakr
ms.custom: bap-template
ms.topic: conceptual
ms.service: dynamics-365-sales
---

# Prioritize leads through scores  

Use the predictive lead scoring feature to prioritize your leads based on scores and achieve higher lead qualification rates.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)(security-roles-for-sales.md)|


## What is predictive lead scoring

In a highly competitive market, you need to be sure you're spending your time on high-quality leads to reach your sales targets. The predictive lead scoring feature in Dynamics 365 Sales uses a model to generate scores for the leads in your pipeline. The out-of-the-box model chooses the top factors that influence the score. An administrator can view and modify the top influencing factors by customizing the model. [Learn how to configure predictive lead scoring](configure-predictive-lead-scoring.md).

The model assigns a score between 0 and 100 to leads based on the signals from leads and related entities, such as contact and account. Using these scores, you can identify and prioritize leads that have a higher chances of converting to opportunities.

For example, say you have two leads - Lead A and Lead B - in your pipeline. The lead scoring model applies a score of 80 for Lead A and 50 for Lead B. Comparing the scores, you can predict that Lead A has a higher chance of converting to an opportunity. Also, you can analyze why Lead B scored low by looking at the top reasons influencing its score and decide whether to try to improve it.
 
To use predictive lead scoring in your organization, ask your system administrator to [configure predictive lead scoring](configure-predictive-lead-scoring.md).

## Real-time scoring

With real-time scoring, new leads are scored in near real-time. The score will be calculated within a few minutes of saving or importing a new lead; refresh the lead page to view the score.  

The following considerations apply for real-time scoring:

- Real-time scoring is available only for leads that are scored by models created or edited, and published after the real-time scoring was feature rolled out. So, if a new lead is not scored within 15 minutes of saving or importing, edit and retrain the model that's scoring the lead.

- Business process flows are not taken into consideration for real-time scoring. Lets say you have different models for each business process flow, with the same filter condition. When a new lead that matches the filter condition is created, real-time scoring will use one of models to score the lead, ignoring the business process flow.
- Real-time scoring works only for new leads. The scores for updated leads are refreshed only after every 24 hours.  

## Understand predictive lead scoring in views

The **My Open Leads Scored** system view is available when predictive lead scoring is enabled in your organization. This view provides a list of leads with different parameters including lead score, lead grade, and lead score trend. 

:::image type="content" source="media/my-open-lead-score-view.png" alt-text="Screenshot of the My Open Leads Scored view.":::

Legend:

1.	**Score** shows the likelihood, on a scale of 1 to 100, that the lead will convert to an opportunity. A lead with a score of 100 has the highest likelihood of converting to an opportunity. The scores are refreshed after every 24 hours.

1. **Score Trend** shows the direction in which a lead is trending, such as **Improving** (up arrow), **Declining** (down arrow), **Steady** (right arrow), or **Not enough info**. Trends are calculated by comparing the current lead score with the previous score. For example, if a lead was scored 65 and is now scored 45, the **Lead Score Trend** column displays a down arrow to indicate that the lead is losing traction and needs some action from you to improve the score.

1. **Grade** ranks leads based on the generated score. Leads with higher grades have more chances of converting to opportunities. Grades are categorized as A, B, C, and D, with colors green, purple, yellow, and red, respectively. Grade A (green) is the lead with the highest likelihood for conversion to an opportunity. Grade D (red) is least likely to convert. System administrators can define lead score ranges for a grade, depending on your organizational requirements.

## Understand lead scoring widget

In forms, the Lead score widget displays the top positive and negative reasons that influence the score. These reasons come from the lead attributes and attributes from related entities. The reasons help you analyze and work on the lead to improve its score and convert it to a possible opportunity. The following image shows a typical **Lead score** widget.

:::image type="content" source="media/predictive-lead-scoring-widget-annotated.png" alt-text="Screenshot of the predictive Lead score widget.":::

Legend:

1. This section displays basic information such as lead score, lead grade, and score trend.

2. This section displays the most important reasons, both positive and negative, that affect the lead score. You can use these reasons to determine how you might convert the lead to an opportunity.

When you move your cursor over a reason, a tooltip displays an insight about what's causing the reason to be listed. You can work on this insight and take any necessary action to improve the lead.

In the following example, for the reason "Finance is a strong industry," the tooltip displays the insight "64% of leads from the financial industry are qualified within 3 days." 

:::image type="content" source="media/predictive-lead-scoring-widget-top-reasons-tool-tip.png" alt-text="Screenshot of a predictive lead score reason tooltip.":::

The Lead score widget displays only the top five positive and negative reasons. To view all the positive and negative reasons that are affecting the lead score, select **Details**. 

The Lead score pane shows a list of all factors that improved the score and those that harmed it, along with a graph that shows how the lead score is trending over time.

:::image type="content" source="media/predictive-lead-scoring-widget-top-reasons-details-tab.png" alt-text="Screenshot of predictive lead score details.":::

For more information about the lead score, select the **About** tab. The **About** tab helps you understand what the lead score is and how it works. Under **What does it mean?**, you'll find information about how lead scores are categorized by admins in your organization. Under **What impacts the score?**, you'll find the attributes that affect lead scores in your organization.

:::image type="content" source="media/predictive-lead-scoring-widget-top-reasons-about-tab.png" alt-text="Screenshot of predictive lead score About tab.":::

### See also

[Configure predictive lead scoring](configure-predictive-lead-scoring.md)  
[Predictive lead and opportunity scoring](faqs-sales-insights.md#predictive-lead-and-opportunity-scoring)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
