---
title: Edit and retrain an opportunity scoring model
description: Learn how to edit and retrain a predictive opportunity scoring model in Dynamics 365 Sales when its prediction accuracy doesn't meet your expectations. 
ms.date: 11/30/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Edit and retrain an opportunity scoring model

When the prediction accuracy of a model doesn't meet your expectations, or a model duplicates an existing one, you can edit the model's attributes and retrain it.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Edit a model

1. Go to **Change area** in the lower-left corner of the Sales Hub app, and select **Sales Insights settings**.
1. On the site map under **Predictive models**, select **Opportunity scoring**.
1. On the **Predictive opportunity scoring** page, open the model. Make sure that **Retrain automatically** is turned off.
1. Select **Edit model**.
1. On the **Edit model** page:

    - Select an attribute to [view insights about its influence on the model](pls-attribute-influence.md).

    - Select attributes that you want the model to consider—including custom attributes—from the opportunity entity and its related entities (account) to train the model.

    :::image type="content" source="media/si-admin-predictive-opportunity-scoring-edit-model-page.png" alt-text="Screenshot of the Edit model page.":::
    
    >[!NOTE]
    >The scoring model don't support the following types of attributes:
    >- Attributes on custom entities
    >- Date and time related attributes
    >- System generated attributes (such as, opportunityscore, opportunitygrade, version number, entity image, exchange rate, and predictive score ID)

1. If you've enabled per stage modeling, another column, **Applicable stages**, will be available. Select one or more stages for which the model should use the attribute.

    Use the **Prediction influence** column to understand the attribute's influence on the model at each stage. Prediction influence is calculated based on historical data and ranges from very low to very high.

    For example, maybe you don't want to consider Budget Amount for the Develop stage. However, if historical data shows that it has a high influence, you might want to reconsider your decision or analyze why it has such a high influence.

    :::image type="content" source="media/per-stage-modelling-selection.png" alt-text="Screenshot of the Edit fields page with the Applicable stages and Prediction influence columns shown.":::

1. (Optional) Scroll to the right of the attributes list and turn on **Ignore empty values**.  

    By default, empty values in the attribute are included for training the model. If you notice that empty values are acting as detractors or are producing false positives, turn on **Ignore empty values**.

    :::image type="content" source="media/ignore-empty-values.png" alt-text="A screenshot of the Ignore empty values option in the model attributes list.":::

    When you turn on **Ignore empty values** for an attribute, the scoring widget will indicate that the score is calculated after excluding blank values.

1. Select **Retrain model**.

    Allow a few minutes for the model to be retrained. When it's ready, you'll receive a message like this one:

    :::image type="content" source="media/pos-model-ready.png" alt-text="A screenshot of the popup message that appears after the model is trained.":::
1. If you want the application to automatically retrain the model after every 15 days, select **Retrain automatically**. 

1. Perform one of the following actions: 
    - If you're ready to publish, select **Publish**. The model is applied to opportunities that match the criteria specified in the model configuration. Users can see the opportunity scoring in their views under the **Opportunity score** column and a widget in the opportunity form. More information: [Prioritize opportunities through scores](work-predictive-opportunity-scoring.md)

    - If you want to verify the model's accuracy, select **View Details** and then select the **Performance** tab. For more information, see [View the accuracy and performance of a predictive scoring model](scoring-model-accuracy.md).

    - If the accuracy of the retrained model aren't satisfactory, edit the attributes and retrain the model. If you want to go back to the previous version, [revert to that version](understand-pls-configuration-page.md#actions-you-can-perform-on-the-model).

## Retrain a model

Retrain a model when its prediction accuracy score doesn't meet your organization's standards, or the model is too old. Typically, retraining  increases the prediction accuracy score. The application uses the latest opportunities in your organization to train the model so that it can provide more accurate scores to your sellers.

For better prediction accuracy scoring, retrain a model after the data in your organization is refreshed.

You can retrain a model [automatically](#automatic-retraining) or [manually](#manual-retraining).

### Automatic retraining

Automatic retraining allows the application to retrain a model automatically after every 15 days. This allows the model to learn from latest data and improve its prediction accuracy. Depending on the model's accuracy, the application makes an informed decision whether to publish or ignore the retrained model. The application automatically publishes the model:

- When the accuracy of the retrained model is equal to or greater than 95 percent of the accuracy of the active model
- When the current model is more than three months old

Otherwise, the application keeps the current model.

To retrain a model automatically, go to the model's **Predictive opportunity scoring** page and select **Retrain automatically**. By default, this option is turned on when a model is published.

### Manual retraining

[Edit the model](#edit-a-model) to trigger manual retraining.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
