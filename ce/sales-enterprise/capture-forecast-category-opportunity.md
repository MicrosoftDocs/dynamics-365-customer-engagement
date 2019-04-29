---
title: "Capture forecast category for opportunity (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Capture the forecast category in Dynamics 365 for Sales to determine whether an opportunity is a low confidence or high confidence to indicate the chances of it getting converted to a sale."
keywords: ""
ms.date: 04/23/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.1"
ms.assetid: 19ebd133-6da7-4617-baeb-a30ff9af7ae1
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Tech Reviewing
---

# Capture forecast category for opportunity

Applies to Dynamics 365 for Customer Engagement apps version 9.1.x

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]  
> - Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 for Customer Engagement apps Technical Support won’t be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use](https://go.microsoft.com/fwlink/p/?linkid=870960).
> - To know more about the feature's availability in your region, see [When will the April 2019 features be enabled for customers who did not opt in to the preview?](/power-platform/admin/preview-april-2019-updates#when-will-the-april-2019-features-be-enabled-for-customers-who-did-not-opt-in-to-the-preview)

The forecast category is used to determine the different confidence levels of an opportunity as it moves through the different stages before it is converted to a sale. This information is used in forecasting to indicate how many opportunities are committed versus how many are still in the pipeline so appropriate actions can be taken. 

**To capture the forecast category**

1. Make sure you have the Forecast user role or equivalent permissions.

2.	In the site map, select **Opportunities**.

3.	In the list of opportunities, open an opportunity for which you want to capture the forecast category.

4.	In the **Forecast category** drop-down list, select one of the following, and then select **Save**:

    -  **Pipeline (low confidence).** Any opportunity that a sales rep has just started to work on can be set to this category. The confidence of winning this opportunity is low. This is the default value.

    -  **Best case (moderate confidence).** When the sales rep has started talking to customers or has shared quotes, and there are moderate chances of winning the opportunity, change the forecast category to **Best case (moderate confidence)**.

    -  **Committed (high confidence).** When the customer is positive and committed about closing the deal, change the category to **Committed (high confidence)**.

    -  **Omitted (exclude from forecast).** If you want an opportunity’s numbers to be excluded from forecasting, use this category. 

       > [!div class="mx-imgBorder"]
       > ![Capture forecast category on an opportunity](media/capture-forecast-category-opportunity-form.png "Capture forecast category on an opportunity")

> [!TIP]
> You can create a workflow to change the forecast category based on changes in the business process stage or in the probability of an opportunity.  


## See also
[Create or edit an opportunity](create-edit-opportunity-sales.md)  
[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)  
[View forecasts](view-forecasts.md)
