---
title: Configure forecasts in your organization
description: Learn how to configure forecasts based on revenue or quantity to predict how much revenue your sales team will generate in a given time frame.
ms.date: 03/27/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
content_well_notification:
-	AI-contribution
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastconfiguration
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/12/2024
  - bap-template
---

# Configure forecasts in your organization

A forecast helps your organization predict how much revenue your sales team generates in a given time frame. When done correctly, forecasting can play a significant role in your company's success.  

[!INCLUDE [trial-cta-note](../includes/trial-cta-note.md)]

## How does forecasting help organizations?

Using forecasts helps your organization by allowing:

- Sellers to track performance against targets and identify pipeline risks that might jeopardize their ability to hit them.
- Managers to track individual sales performance against quotas to proactively provide coaching.
- Directors to forecast trends to anticipate departmental sales and reallocate resources if necessary.
- Organization leaders to project estimates to change the product strategy or provide updated projections to investors.

Forecasting isn't supported on Government Community Cloud (GCC) or mobile devices.

## Configure forecasting

You can configure forecasts that are based on revenue or quantity. You define the type of forecast, the hierarchy, access permissions, and the details you want to see in the forecast grid. After a forecast is activated, your sales team can view the revenue, or quantity, and pipeline projections. Until you activate a forecast, your sales team can view an [out-of-the-box forecast](view-forecasts.md#out-of-the-box-forecast) for the current month. The out-of-the-box forecast isn't available in the forecast configuration page and neither can it be deleted nor deactivated.

1. In the Sales Hub app, select the Change area icon ![Icon to change the work area](./media/change-area-icon.png "Icon to change the work area") in the lower-left corner, and then select **App Settings**.  

1. Under **Performance management**, select **Forecast configuration**.

1. Follow the steps to configure a forecast from scratch or use the [sample forecast configuration](#use-the-sample-forecast-configuration) to get started quickly.  

    1. [Select a template](./select-template-forecast.md).  

    1. [Define and schedule a forecast model](define-general-properties-scheduling-forecast.md).

    1. [Provide access permissions](provide-permissions-forecast.md).

    1. [Configure columns and layouts](choose-layout-and-columns-forecast.md).

    1. [Configure and manage drill-down entities](configure-manage-drill-downs.md).

    1. [Configure advanced settings](forecast-configure-advanced-settings.md).

    1. [Activate the forecast and upload data](activate-upload-simple-columns-data-forecast.md).
    
### Use the sample forecast configuration

A ready-to-publish sample forecast configuration is available to you. Use the sample forecast to experiment and discover how forecasting works.  Learn how to tweak the parameters and filters to suit your organization's needs.  

**To view the sample forecast configuration**

1. Go to **App Settings** > **Performance management** > **Forecast configuration**.

    You can directly activate the sample forecast configuration if you'd like to use the default settings. After the status turns **Active**, you can [view the forecast](view-forecasts.md).

    :::image type="content" source="media/activate-sample-forecast.png" alt-text="Screenshot of the three-dot menu for activating the sample forecast.":::

  **To see who has access to the forecast**

1. Select **Sample forecast**.
1. In the **General** step, check the **Preview** section to see the users who are part of the forecast. By default, the displayed users have access to view the forecast after you activate it.

    :::image type="content" source="./media/forecast-general-tab-configuration-section.svg" alt-text="Screenshot of the General step of the Forecast configuration page, with a preview of the selected hierarchy shown.":::

**To limit access to the forecast**

1. Go to **Permissions** and select the appropriate security roles.

**To make the forecast available to users in the hierarchy**

1. Go to **Activate & add quotas** and select **Activate forecast**.


## Find your forecasts

In the **Sales** site map, find **Forecasts** under **Performance**.

:::image type="content" source="./media/forecast-select-sales-performance-forecasts.png" alt-text="Screenshot of the Sales Hub site map that shows Forecasts under Performance.":::

In the **Opportunity** form, **Forecast Category** appears above **Description**.

:::image type="content" source="./media/capture-forecast-category-opportunity-form.png" alt-text="Screenshot of an opportunity form with the Forecast category expanded.":::

 The categories define the confidence level of closing the opportunity. If you need to, you can add custom values for your organization. To learn more, see [Capture forecast category for opportunity](./capture-forecast-category-opportunity.md).

- Forecast category options include **Won** and **Lost**. If an opportunity is closed as **Won** or **Lost**, the **Opportunity Forecast Category Mapping Process** out-of-the-box workflow automatically changes the forecast category to match.

- To view the **Opportunity Forecast Category Mapping Process** workflow, go to **Settings** > **Advanced Settings** > **Process Center** > **Processes** and select the **All Processes** view. Search for and open the **Opportunity Forecast Category Mapping Process** workflow. You can customize or deactivate the workflow according to your organization's requirements.
- Are you using a custom option set instead of forecast category? You need to create a workflow to automatically sync the opportunity status with your option set to make sure that the projection is accurate. To learn more, see [Create a cloud flow in Power Automate](/power-automate/get-started-logic-flow).

If you don't want to see the forecast category in the opportunity form, you need to customize the form. You can't use the **Visible by default** option to hide it. To learn more, see [Unable to hide forecast category field in opportunity forms](./ts-forecasts.md#hide_forecast_category_field).

>[!IMPORTANT]
>- The forecasting feature is intended to help sales managers or supervisors enhance their team’s performance.
>- The forecasting feature isn't intended for use in making decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements.
>- Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with users.
>- Customers should notify users that their communications with salespersons might be monitored, recorded, or stored and, obtain consent from users before using the feature with them (as required by applicable laws).
>- Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with users might be monitored, recorded, or stored.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

<table>
<tr><td>

> [!div class="nextstepaction"]
> [Next step: Select a template](select-template-forecast.md)
</td></tr>
</table>

## Related information

[Blog: Tips for setting up sales forecasting in Dynamics 365 Sales](https://cloudblogs.microsoft.com/dynamics365/it/2020/11/23/tips-for-setting-up-sales-forecasting-in-dynamics-365-sales/)  
[System and application users who can push data to Dataverse](/power-platform/admin/system-application-users)  
[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)  
[View forecasts](view-forecasts.md)  
[About premium forecasting](/dynamics365/ai/sales/configure-premium-forecasting)
[msdyn_ForecastApi action](developer/reference/custom-actions/msdyn_ForecastApi.md)  
[Forecasting FAQs](faq-forecasting.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
