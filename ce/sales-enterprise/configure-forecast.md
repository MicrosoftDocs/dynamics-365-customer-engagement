---
title: "Configure forecasting (Dynamics 365 Sales) | MicrosoftDocs"
description: "Define the data and period to use for the purpose of forecasting in Dynamics 365 Sales."
ms.date: 05/25/2020
ms.service: dynamics-365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastconfiguration
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement

---

# Configure forecasts in your organization

A forecast helps your organization predict how much revenue your sales team will generate in a given timeframe. When done correctly, forecasting can play a significant role in your company's success. By using a forecast:    
- Sellers can track performance against their targets and identify pipeline risks that might jeopardize their ability to hit their targets.   
- Managers can track individual sales performance against quotas to proactively provide coaching.    
- Directors can use forecast trends to anticipate departmental sales and reallocate resources if necessary.   
- Organization leaders can use the projected estimates to change the product strategy or convey updated projections to investors.   

>[!IMPORTANT]
>Forecasting is not available on Government Community Cloud (GCC).  

## Prerequisite   
View the minimum required application, user permissions, and license:     

| Requirements | Description |
|--------------|-------------|
| Application | Sales Hub |
| User permissions | Administrator, Forecast manager, or equivalent permissions.<br> More information: [Security roles and privileges](/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user). |
| License | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or Microsoft Relationship Sales | 

## Enable forecasting    
You can configure forecasts in your organization that are based on revenue or quantity. You can define the type of forecast, its hierarchy, permissions for accessing it, and the details you want to appear on the forecast grid. After a forecast is activated, your sales team can view the revenue or quantity, and pipeline projections.   
By default, forecasting is available in your organization and the following page is displayed when you select **Forecast configuration**:   

> [!div class="mx-imgBorder"]
> ![Forecasting configuration page](media/forecast-enable-forecasting-enabled.png "Forecasting configuration page") 

**To go to forecast configuration page**   
1.  Sign in to the **Sales Hub** app.     
2.  In the site map, select the Change area icon ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area"), and then select **App Settings**.    
3.  Under **Performance management**, select **Forecast configuration**.     
    The forecast configuration page opens.     

Also, you can observe the following changes in the **Sales Hub** app:    
-	**Forecasts** appears under **Performance** in the **Sales** site map.    
    > [!div class="mx-imgBorder"]
    > ![Forecasts option in sales site map](media/forecast-select-sales-performance-forecasts.png "Forecasts option in the Sales site map")      
-	**Forecast category** appears on the **Opportunity** form. The categories define the confidence level of closing an opportunity. If necessary, you can add custom values specifically defined for your organization. To learn more, see [Capture forecast category for opportunity](capture-forecast-category-opportunity.md).     
    > [!div class="mx-imgBorder"]
    > ![Forecast category option in opportunity form](media/capture-forecast-category-opportunity-form.png "Forecast category in an opportunity form")    

    > [!NOTE]
    > **Forecast category** options consists of **Won** and **Lost** opportunity statuses. If an opportunity is set as **Won** or **Lost**, the forecast category automatically changes status through the **Opportunity Forecast Category Mapping Process** out-of-the-box workflow. <br>
    > To view the **Opportunity Forecast Category Mapping Process** workflow, go to **Settings** > **Process Center** > **Processes** and select **All Processes** view. Search and open the **Opportunity Forecast Category Mapping Process** workflow. You can customize or deactivate the workflow according to your organization's requirements. <br>
    > If you're using a custom option set instead of forecast category, you must create a workflow to automatically sync the opportunity status with your option set to ensure that the forecast is projecting accurate values. <br> 
    >  To learn more, see [Use Workflow processes to automate processes that don't require user interaction](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/customize/workflow-processes).

    Currently, the **Forecast category** field in the **Opportunity** form can't be hidden through the **Visible by default** option in the form customization. If you don't want to use the **Forecast category** field in opportunity form, remove the field through form customization. To learn more, see [Unable to hide forecast category field in Opportunity forms](ts-forecasts.md#hide_forecast_category_field).    



## Configure a forecast     
To configure a forecast in your organization, follow these steps:    
1.	[Review the prerequisite tasks](#prerequisite-tasks)    
2.	[Select a template](select-template-forecast.md)     
3.	[Define general properties and scheduling](define-general-properties-scheduling-forecast.md)   
4.	[Provide viewing permissions](provide-permissions-forecast.md)    
5.	[Choose layout and columns](choose-layout-and-columns-forecast.md)    
6.	[Apply additional filter](add-additional-filters.md)     
7.	[Configure and manage drill-down entities](configure-manage-drill-downs.md)    
8.	[Configure advanced settings](forecast-configure-advanced-settings.md)    
9.	[Activate and upload simple columns data](activate-upload-simple-columns-data-forecast.md)

>[!IMPORTANT]
>This feature is intended to help sales managers or supervisors enhance their team’s performance. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with end users may be monitored, recorded, or stored.

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Next step: Select a template](select-template-forecast.md)
</td></tr>
</table>

### See also   
[Blog: Tips for setting up sales forecasting in Dynamics 365 Sales](https://cloudblogs.microsoft.com/dynamics365/it/2020/11/23/tips-for-setting-up-sales-forecasting-in-dynamics-365-sales/)   
[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)   
[View forecasts](view-forecasts.md)   
[About premium forecasting](https://docs.microsoft.com/dynamics365/ai/sales/configure-premium-forecasting)
