---
title: "Capture forecast category for opportunity (Dynamics 365 Sales) | MicrosoftDocs"
description: "Capture the forecast category in Dynamics 365 Sales to determine whether an opportunity is a low confidence or high confidence to indicate the chances of it getting converted to a sale."
ms.date: 10/01/2019
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
ms.assetid: 19ebd133-6da7-4617-baeb-a30ff9af7ae1
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Capture forecast category for opportunity

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

The forecast category is used to determine confidence level of an opportunity as it moves along the path to conversion. Forecasting shows how many opportunities are in the pipeline and which of those are committed, delivering actionable insights. 

1.	In the site map, select **Opportunities**.

2.	In the list of opportunities, open an opportunity for which you want to capture the forecast category.

3.	In the **Forecast category** drop-down list, select one of the following, and then select **Save**:

    -  **Pipeline.** The confidence of winning this opportunity is low. Any opportunity that a sales rep has just started to work on can be set to this category (this is the default value).

    -  **Best case.** Sales rep has started talking to customers or has shared quotes, and there are moderate chances of winning the opportunity.

    -  **Committed.** Customer  has committed to closing the deal.

    -  **Omitted.** To exclude an opportunity’s numbers from the forecast. 
    
    - **Won.** If an opportunity is closed as won.
    
    - **Lost.** If an opportunity fails and is closed as lost.

       > [!div class="mx-imgBorder"]
       > ![Capture forecast category on an opportunity](media/capture-forecast-category-opportunity-form.png "Capture forecast category on an opportunity")

> [!TIP]
> You can create a workflow to change the forecast category based on changes in the business process stage or in the probability of an opportunity. To learn more about creating a workflow, see [Use Workflow processes to automate processes that don't require user interaction](/dynamics365/customer-engagement/customize/workflow-processes) 

## See also

[Create or edit an opportunity](create-edit-opportunity-sales.md)  

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)  

[View forecasts](view-forecasts.md)
