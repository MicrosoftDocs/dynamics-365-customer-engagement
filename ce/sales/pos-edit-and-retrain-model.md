---
title: Edit and retrain an opportunity scoring model
description: When the prediction accuracy of the opportunity scoring model doesn't meet your expectations, you can edit the attributes used by the model and retrain the model. 
ms.date: 10/11/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Edit and retrain an opportunity scoring model

When the prediction accuracy of a model doesn't meet your expectations, you can edit the attributes used by the model and retrain it.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Edit the model

1. Go to **Change area** in the lower-left corner of the Sales Hub app, and select **Sales Insights settings**.

1. On the site map under **Predictive models**, select **Opportunity scoring**. 
1. On the predictive opportunity scoring page, open the model and ensure that **Retrain automatically** is turned off.

1. Select **Edit model**.
1. On the **Edit model** page, you can,
    - Select an attribute to view its prediction influence and other insights about the attribute. For more information, see [View the influence of an attribute on the model](pls-attribute-influence.md).
    
    - Select attributes that you want the model to consider—including custom attributes—from the opportunity entity and its related entities (contact and account) to train the model.

    :::image type="content" source="media/si-admin-predictive-opportunity-scoring-edit-model-page.png" alt-text="A screenshot of the Edit model page.":::  

    >[!NOTE]
    >The scoring model don't support the following types of attributes:
    >- Attributes on custom entities
    >- Date and time related attributes
    >- System generated attributes (such as, opportunityscore, opportunitygrade, version number, entity image, exchange rate, and predictive score ID)

3. If you've enabled per stage modeling, you'll see an additional column named **Applicable stages** and the **Prediction influence** column will display the influence of the attribute at each stage.
        :::image type="content" source="media/per-stage-modelling-selection.png" alt-text="Screenshot of the edit fields page with the Applicable stages and Prediction influence columns.":::


    - In the **Applicable stages** field, select the stages for which the model should use the attribute. For example, the Actual Revenue attribute will have more influence during the Close stage rather than initial stages. You can select more than one stage for each attribute. 
    
    - Use the information in the **Prediction influence** column to understand the influence of the attribute at each stage. Prediction influence is calculated based on historical data and ranges from very low to very high. For example, let's say that you don't want to consider Budget Amount for Develop stage, but historical data shows that it has a high influence. In this case, you might want to reconsider your decision or analyze why it has such a high influence.  

3. (Optional) Scroll to the right of the attributes list and turn on **Ignore empty values**.  
    By default, empty values in the attribute are included for training the model. If you notice that empty values are acting as detractors or are producing false positives, turn on **Ignore empty values**.  
    :::image type="content" source="media/ignore-empty-values.png" alt-text="A screenshot of ignore empty values option in the attributes list.":::

    > [!NOTE]
    > When you turn on **Ignore empty values** for an attribute, the scoring widget will indicate that the score is calculated after excluding blank values in the attribute, as shown in the following screenshot:
    :::image type="content" source="media/ignore-empty-values-scoring-widget-opp.png" alt-text="A screenshot of scoring widget when the Ignore empty values option is turned on."::: 

1. Select **Retrain model**.

    The model is retrained by using the selected attributes, and a notification is displayed on the screen.
    
    After the model is trained, a popup message is displayed. 
    :::image type="content" source="media/pls-model-ready.png" alt-text="A screenshot of the popup message that appears after the model is trained":::

1. If you want the application to automatically retrain the model after every 15 days, select **Retrain automatically**. 

1. Perform one of the following actions: 
    - If you're ready to publish, select **Publish**. The model is applied to opportunities that match the criteria specified in the model configuration. Users can see the opportunity scoring in their views under the **Opportunity score** column and a widget in the opportunity form. More information: [Prioritize opportunities through scores](work-predictive-opportunity-scoring.md)
    
    - If you want to verify the model's accuracy, select **View Details** and then select the **Performance** tab. For more information, see [View the accuracy and performance of a predictive scoring model](scoring-model-accuracy.md).

    - If the accuracy of the retrained model aren't satisfactory, edit the attributes and retrain the model. If you want to go back to the previous version, [revert to that version](understand-pls-configuration-page.md#actions-you-can-perform-on-the-model).


## Retrain a model

Retrain a model when its prediction accuracy score doesn't meet your organization's standards, or the model is too old. Typically, retraining  increases the prediction accuracy score. The application uses the latest opportunities in your organization to train the model so that it can provide more accurate scores to your users.

> [!NOTE]
> For better prediction accuracy scoring, retrain a model after the data in your organization is refreshed.

You can retrain the model [automatically](#automatic-retraining) or [manually](#manual-retraining).

## Automatic retraining

Automatic retraining allows the application to retrain a model automatically after every 15 days. This allows the model to learn from latest data and improve its prediction accuracy. Depending on the model's accuracy, the application makes an informed decision whether to publish or ignore the retrained model.

To retrain a model automatically, go to the predictive lead scoring configuration page of the model and select **Retrain automatically**. By default, this option is enabled when a model is published. Here are the scenarios where the application automatically publishes the model:

- When the accuracy of the retrained model is equal to or greater than 95 percent of the accuracy of the active model.
- When the current model is more than three months old.

> [!NOTE]
> A retrained model might not be published if the accuracy of the model isn't maintained to the standards of the application. If this occurs, the existing user-published model will be retained.

### Manual retraining

You can retrain a model manually in the following cases:

- You want to edit the model for better accuracy and retrain it.
- You have turned off **Retrain automatically** to avoid automatic retraining.

In both cases, you have to [edit the model](#edit-the-model) to trigger manual retraining.  

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]