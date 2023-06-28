---
title: Manage duplicate opportunity scoring models
description: Learn how to remove duplicate models and make sure that no models are scoring the same opportunities in Dynamics 365 Sales.
ms.date: 11/30/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Manage duplicate opportunity scoring models

When you create multiple predictive scoring models, it's important to configure them so that they don't score the same opportunities because it's difficult to identify which model scored an opportunity. If you create or edit a model that might duplicate an existing one, you'll receive a warning. You can ignore the warning and create the model anyway, or go back and change the model's configuration.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Avoid a duplicate when you're creating a model

When you create a model and select **Get started**, if the model duplicates one or more existing models, you'll receive a warning like this one:

:::image type="content" source="media/si-admin-predictive-opportunity-scoring-duplicate-model-create-model-message.png" alt-text="Screenshot of a conflict warning while creating a predictive scoring model.":::

- Select **No, Go back** and change the filter column and values so that the model is scoring unique opportunities.

    -Or-

- Select **Yes, Create model** with the understanding that it might be harder to identify the opportunities that are being scored by this model.

## Delete a duplicate published model

When you open a published model, if the model duplicates one or more existing models, the page will include a note like this one:

:::image type="content" source="media/si-admin-predictive-opportunity-scoring-duplicate-model-published-model-message.png" alt-text="Screenshot of a conflict warning while viewing a published predictive scoring model.":::

[Edit the model](pls-edit-and-retrain-model.md) so that it scores unique leads or [delete it](#delete-a-model).

## Delete a model

You can delete a scoring model when it's no longer required in your organization or it's a duplicate of an existing model. You can have up to 10 models&mdash;both published and unpublished&mdash;simultaneously.

1. In **Sales Insights settings** > **Predictive models** > **Opportunity scoring**, open the **Predictive opportunity scoring** page.
1. Select a model in the **Select model** list. Make sure **Retrain automatically** is turned off.
1. Select **Delete model**.
1. When you're asked to confirm, select **Delete**.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
