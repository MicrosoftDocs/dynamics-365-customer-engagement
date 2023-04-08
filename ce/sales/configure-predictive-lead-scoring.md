---
title: Configure predictive lead scoring
description: Configure predictive lead scoring to help sellers prioritize leads.
ms.date: 11/30/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Configure predictive lead scoring

Predictive lead scoring uses a predictive machine learning model to calculate a score for open leads based on historical data. The score helps sellers prioritize leads and achieve higher lead qualification rates, and reduces the time it takes to qualify a lead.

For example, say you have two leads, Lead A and Lead B, in your pipeline. The lead scoring model calculates a score of 80 for Lead A and 50 for Lead B. Based on the scores, you can predict that Lead A has a greater chance of being converted into an opportunity. Further, you can review the top influencing factors to analyze why Lead B's score is low and decide whether to improve it.

The following image shows an example of a lead scoring widget:

:::image type="content" source="media/predictive-lead-scoring-widget.png" alt-text="Screenshot of a predictive lead score widget.":::

Historical data collection begins when you create a scoring model. Historical data is stored in the data lake for analysis. If your Dynamics 365 Sales subscription expires or your org is deleted, the historical data is deleted after 30 days.

If you have a Dynamics 365 Sales Enterprise license, you can enable predictive lead scoring in [lead and opportunity scoring quick setup](digital-selling-scoring.md#set-up-lead-and-opportunity-scoring). You'll get 1,500 scored records per month.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Prerequisites

- [Advanced Sales Insights features must be enabled](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features).

- You need to have enough leads to train the model based on past data. Your organization must have created at least 40 qualified and 40 disqualified leads in the past three months to two years. The more leads you can include to train the model, the better the prediction results will be. You can configure the time frame in the **Train with leads from the past** field of the scoring model.

## Create your first scoring model

> [!IMPORTANT]
>
> - If you're using a model that you created in a version of Dynamics 365 earlier than 2020 release wave 2, [delete the model](pls-duplicate-models.md#delete-a-model) before you create a new one. Otherwise, the previous version of the model will be applied to all leads in your organization, and new models won't have any effect on the leads.
> - As of 2020 release wave 2, the application writes the lead scoring data to the [**msdyn_predictivescore**](developer-sp/msdyn_predictivescore.md) table and no longer writes to the lead table. Both lead and opportunity scoring use the **msdyn_predictivescore** table.


A scoring model defines the criteria for choosing leads for training and scoring. If your organization follows different sales practices across different regions or business units, you can create models and unique training sets for each of them.

1. Go to **Change area** in the lower-left corner of the Sales Hub app, and select **Sales Insights settings**.

1. On the site map under **Predictive models**, select **Lead scoring**.
  
   If your organization doesn't have at least 40 qualified and 40 disqualified leads that were created in the time frame identified in the **Train with leads from the past** field, you can't create a scoring model. If there are enough leads, the app generates a model by default.

1. On the **Predictive lead scoring** page, change the values for fields such as business process flow, filter column, and so on if needed. For more information about these fields, see the next section [Add a model](#add-a-model). When you're done, select **Get started**.

Allow a few minutes for the app to train your model. You can leave the page and come back later.

The application uses standard attributes to train the model. You can [edit the model](pls-edit-and-retrain-model.md) later to include custom or intelligent attributes.

## Publish your model

1. When your model is trained and ready to publish, the **Predictive lead scoring** page displays a confirmation:

      :::image type="content" source="media/pls-model-ready.png" alt-text="Screenshot of the confirmation message that appears after a scoring model is trained and ready to publish.":::

2. If the model is trained but not ready to publish, the **Model performance** field displays **Not ready to Publish**.

1. To retrain the model every 15 days, select **Retrain automatically**.

1. Select **Publish** or **View details**.

    - If the model is ready to publish and you're ready to apply it, select **Publish**.

        The model is applied to leads that match the criteria specified in the model configuration. The lead score appears in the **Lead score** column in views and in a widget in the lead form.

    - To [view the model's accuracy and performance](scoring-model-accuracy.md) before you publish it, or if the model isn't ready to publish and you want to know why, select **View Details**, and then select the **Performance** tab.

        The app determines that the model isn't ready to publish if its accuracy falls below a threshold value, the **Area under curve (AUC) score**. You can still publish the model if you like. However, it will perform poorly.

## Add a model

You can create up to 10 models, both published and unpublished, for different sets of leads. The app warns you if you try to create a model that might score the same leads as an existing model.

1. At the bottom of the **Predictive lead scoring** page, select **Add model**.

    :::image type="content" source="media/pls-add-model.png" alt-text="Screenshot of the Predictive lead scoring page, with Add model highlighted.":::

    > [!NOTE]
    > You won't see the **Add model** button if you haven't created at least one scoring model.

    The **Predictive lead scoring** page opens with default values.

    :::image type="content" source="media/pls-new-model.png" alt-text="Screenshot of adding a new scoring model.":::

1. In the **New model name** box, enter a name that contains alphanumeric characters. Underscores are allowed, but not spaces or other special characters.

     By default, the name is **LeadScoring_**<***YYYYMMDD***><***Time***> (for example, **LeadScoring_202009181410**). The date and time are based on Coordinated Universal Time (UTC).

1. In the **Business process flow** list, select a flow that's relevant for the leads that you're generating the model for.

    The list displays all the business process flows that are defined for leads in your organization.

    To display custom business process flows in the list, [enable **Change Tracking**](/power-platform/admin/enable-change-tracking-control-data-synchronization) for the business process flow entity. When you generate the model, custom business processes are automatically enabled to sync the data to the data lake for analysis.

1. In the **State option set** list, select the option set in which the status of the leads is defined.

1. Select the corresponding values in the **Qualified Value** and **Disqualified Value** lists, respectively.

    The out-of-the-box **Status** state option set defines the values as **Qualified** and **Disqualified**. You can select a custom option set if one is defined.

1. Select **Filter column** and **Filter values** to specify the leads that the model must score.

    To filter based on multiple columns, [create a calculated field](/powerapps/maker/data-platform/define-calculated-fields) with the required columns, and then select the calculated field in the **Filter column** list.

1. In the **Train with leads from the past** list, select a time period for the training set. The default is two years.

    Your organization must have a minimum of 40 qualified and 40 disqualified leads that were created and closed during the selected period. The model analyzes closed leads from the selected period and uses that data to score open leads from the past two years.

    If you don't have the minimum closed leads in the chosen time period, the **Get started** button is disabled. Select another time period that has enough closed leads to train the model.

1. Select **Get started**. You'll get a warning message if the model is a duplicate of an existing model and is scoring the same set of leads. You can choose to create the model anyway or change the configurations to let the model score unique set of leads.
    
    :::image type="content" source="media/pls-conflicting-model.png" alt-text="Screenshot of the warning that's displayed when a new model conflicts with an existing one.":::

    The system will take a few minutes to train your model.

1. When your model is trained, [publish it or view its details](#publish-your-model).

If you create multiple scoring models, use the **Select model** list on the **Predictive lead scoring** page to select a model to view.

:::image type="content" source="media/pls-select-model.png" alt-text="Screenshot of the Predictive lead scoring page with multiple models, with the Select model list highlighted.":::

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[System and application users who can push data to Dataverse](/power-platform/admin/system-application-users)  
[Edit and retrain a lead scoring model](pls-edit-and-retrain-model.md)  
[Prioritize leads through scores](../sales/work-predictive-lead-scoring.md)  
[Predictive lead/opportunity scoring FAQs](faqs-sales-insights.md#predictive-leadopportunity-scoring)  
[Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
