`---
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

    -  **Committed.** Customer has committed to closing the deal.

    -  **Omitted.** To exclude an opportunity’s numbers from the forecast. 
    
    - **Won.** If an opportunity is closed as won.
    
    - **Lost.** If an opportunity fails and is closed as lost.

       > [!div class="mx-imgBorder"]
       > ![Capture forecast category on an opportunity](media/capture-forecast-category-opportunity-form.png "Capture forecast category on an opportunity")

## Sync opportunity status with forecast category

You must sync opportunity status with forecast category in real-time to ensure that the forecast is projecting proper values. The forecast categories are not synced automatically when the opportunity status is updated. You must configure workflows to automatically sync the opportunity status with forecast category. To cerate workflow, follow these steps:
 
1. Sign in to Dynamics 365 Sales and go to **Sales Hub** app.

2. On the Sales Hub page, **Select Settings** > **Advanced Settings**.

    A new tab opens with **Business Management** settings page.

3. On the site map, select **Settings** > **Process Center** > **Processes**.
 
    The processes page opens.

4. Select **+ New**.

    The create processes dialog box opens.

    > [!div class="mx-imgBorder"]
    > ![Create process flow dialog box](media/forecast-create-process-dialog.png "Create process flow dialog box")

5. Enter basic information for the workflow process and select **OK**:

    - **Process name**: Enter a name for the process workflow.

    - **Category**: Select the category as **Workflow**.

    - **Entity**: Select the entity as **Opportunity**. 

    The process configuration page opens.

    > [!div class="mx-imgBorder"]
    > ![Configure process flow page](media/forecast-create-process-configuration-page.png "Configure process flow page")

6. Select **Start when** as **Record status changes** to automatically start the workflow when the status of an opportunity changes.

    > [!div class="mx-imgBorder"]
    > ![Select Start when option as Record status changes](media/forecast-create-process-configuration-page-start-when.png "Select Start when option as Record status changes")

7. Select **Add Step** > **Check Condition** to add conditions on how the value should change when the condition is true.

    > [!div class="mx-imgBorder"]
    > ![Add condition](media/forecast-create-process-configuration-add-condition.png "Add condition")

8. Define the condition as following for the step:

    - **Description:** Enter a description for the step. For example, **Sync opportunity status with forecast category**.

    - **If condition:** Define the If condition as **Opportunity** **Status** is **Equal** to **Won**. After you save the **If** condition, define what should happen when the condition is true through **Then** condition. 

        > [!div class="mx-imgBorder"]
        > ![Define If condition](media/forecast-create-process-configuration-if-condition-opportunity-status.png "Define If condition")
    
    - **Then condition:** Select **Add Step** > **Update Record**. Enter the description and then select **Set Properties**. Go to **Additional Fields** section and select **Forecast Category** as **Won**.

        > [!div class="mx-imgBorder"]
        > ![Select forecast category as won](media/forecast-create-process-configuration-then-condition-forecastcategory-won.png "Select forecast category as won")

9. Select the previous **If** condition step (here it is **Won**) and select **Conditional Branch**. Repeat steps 7 and 8 for **Lost**.

    > [!div class="mx-imgBorder"]
    > ![Add conditional branch](media/forecast-create-process-configuration-add-condition-branch.png "Add conditional branch")

10. Similarly, repeat steps 7 to 9 for other opportunity statuses **Pipeline**, **Best case**, **Committed**, and **Omitted**.

11. Save and close the workflow process.

    The workflow process to automatically sync opportunity status with forecast category is created.

To learn more about creating a workflow, see [Use Workflow processes to automate processes that don't require user interaction](/dynamics365/customer-engagement/customize/workflow-processes) 

## See also

[Create or edit an opportunity](create-edit-opportunity-sales.md)  

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)  

[View forecasts](view-forecasts.md)