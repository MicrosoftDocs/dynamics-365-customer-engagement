---
title: Edit and retrain a lead scoring model
description: Learn how to edit and retrain a predictive lead scoring model in Dynamics 365 Sales when its prediction accuracy doesn't meet your expectations. 
ms.date: 12/06/2024
ms.custom: bap-template
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Edit and retrain a lead scoring model

When the prediction accuracy of a lead scoring model doesn't meet your expectations, or a model duplicates an existing one, you can edit the attributes it uses and retrain it.

> [!NOTE]
> The real-time scoring feature was rolled out in December 2022, as part of Sales Insights version 9.0.22121.10001. Models that were published before this roll out, need to be edited and published again to be able to score in real-time. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Edit a model

1. Go to **Change area** in the lower-left corner of the Sales Hub app, and select **Sales Insights settings**.
1. On the site map under **Predictive models**, select **Lead scoring**.
1. On the **Predictive lead scoring** page, open the model and make sure that **Retrain automatically** is turned off.
1. Select **Edit model** and perform any of the following actions:

    - Select an attribute to [view insights about its influence on the model](pls-attribute-influence.md).

    - Select attributes that you want the model to consider—including custom attributes—from the lead entity and its related entities (contact and account) to train the model.

    - [Select intelligent fields](#select-intelligent-fields) to include in the model.

    :::image type="content" source="media/si-admin-predictive-lead-scoring-edit-model-page.png" alt-text="Screenshot of the Predictive lead scoring > Edit page.":::
    
   > [!NOTE]
   > The scoring model doesn't support the following types of attributes:
   > - Attributes on custom entities
   > - Date and time&ndash;related attributes
   > - System-generated attributes such as leadscore, leadgrade, version number, entity image, exchange rate, and predictive score ID

1. (Optional) Scroll to the right of the attributes list and turn on **Ignore empty values**.

   By default, empty values in the attribute are included for training the model. If you notice that empty values are acting as detractors or are producing false positives, turn on **Ignore empty values**.

    :::image type="content" source="media/ignore-empty-values.png" alt-text="A screenshot of the Ignore empty values option in the model attributes list.":::

    The **Ignore empty values** option is disabled for the following type of attributes:

    - Attributes that are automatically validated for empty values, such as firstname_validation_engineered.
    - Attributes that affect the score based on whether the value exists or not, such as zipcode or business phone.

    When you turn on **Ignore empty values** for an attribute, the scoring widget indicates that the score is calculated after excluding blank values.

1. Select **Retrain model**.  

    Allow a few minutes for the model to be retrained. When it's ready, you'll receive a message like this one:

    :::image type="content" source="media/pls-model-ready.png" alt-text="A screenshot of the message that appears after the model is trained.":::

1. If you want the application to automatically retrain the model after every 15 days, select **Retrain automatically**. 

1. Perform one of the following actions: 
    - If you're ready to publish, select **Publish**. The model is applied to leads that match the criteria specified in the model configuration. Users can see the lead scoring in their views under the **Lead score** column and a widget in the lead form. More information: [Convert leads into opportunities](../sales/work-predictive-lead-scoring.md)

    - If you want to verify the model's accuracy, select **View Details** and then select the **Performance** tab. For more information, see [View the accuracy and performance of a predictive scoring model](scoring-model-accuracy.md).

    - If the accuracy of the retrained model aren't satisfactory, edit the attributes and retrain the model. If you want to go back to the previous version, [revert to that version](understand-pls-configuration-page.md#actions-you-can-perform-on-the-model).


### Select intelligent fields

Intelligent fields help the model better understand records and distinguish between factors that improve score and those that harm it. For example, the model can distinguish between business email addresses and personal email addresses by identifying and grouping email types using data that's available in the application and intelligence that has been added to the model. Through this identification, the model can generate detailed insights about how the groups of fields affect predictive scores.

[Edit the model](#edit-a-model) as described in the previous section to choose the intelligent fields that you want your model to use. The following image illustrates how you can select intelligent fields.

:::image type="content" source="media/si-admin-predictive-lead-scoring-edit-model-intelligent-fields.png" alt-text="Screenshot of the Edit fields page showing the Model concepts section with a list of intelligent fields selections.":::

Select the link in the **Prediction influence** column to view insights about the field's influence, such as its qualification rate and the most influential factors, both positive and negative, for the rate. [Learn how to view the influence of an attribute on the model](pls-attribute-influence.md).

You can select the following fields: **Email domain validation (Email)**, **First name validation (First name)**, and **Last name validation (Last name)**. The model always gives preference to:

- Email addresses that are part of a business domain
- First and last names that contain alphanumeric characters and no special characters

By default, intelligent fields are considered while training a model by using out-of-the-box values. If the outcome of the intelligent fields is satisfactory, the model includes the fields to train; otherwise, the fields are ignored. However, even if the outcome is unsatisfactory, you can still choose to include the intelligent fields to train the model if necessary.

> [!NOTE]
> Intelligent fields aren't available in the lead entity or its related entities, contact and account.

## Retrain a model

Retrain a model when its prediction accuracy score doesn't meet your organization's standards, or the model is too old. Typically, retraining increases a model's prediction accuracy score. The application uses the latest leads in your organization to train the model so that it can provide more accurate scores to your sellers.

For better prediction accuracy scoring, retrain a model after the data in your organization is refreshed.

You can retrain a model [automatically](#automatic-retraining) or [manually](#manual-retraining).

### Automatic retraining

Automatic retraining allows the application to retrain a model every 15 days. This allows the model to learn from the latest data and improves its prediction accuracy score. 

To retrain a model automatically, go to the model's **Predictive lead scoring** page and select **Retrain automatically**. By default, this option is turned on when a model is published.

Depending on the model's accuracy, the application makes an informed decision whether to publish or ignore the retrained model. The application automatically publishes the model in the following scenarios:

- When the accuracy of the retrained model is equal to or greater than 95 percent of the accuracy of the active model.
- When the current model is more than three months old.

Otherwise, the application keeps the current model.

### Manual retraining

You can retrain a model manually in the following cases:

- You want to edit the model for better accuracy and retrain it.
- You've turned off **Retrain automatically**.

In both cases, you have to [edit the model](#edit-a-model) to trigger manual retraining.  



[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
