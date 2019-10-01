---
title: "Configure forecasting (Dynamics 365 Sales) | MicrosoftDocs"
description: "Define the data and period to use for the purpose of forecasting in Dynamics 365 Sales."
keywords: ""
ms.date: 04/05/2019
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
ms.assetid: 1517b3d4-639b-4fec-bbbc-8474320d1867
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Configure forecast in your organization

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]
> - Microsoft doesn't provide support for this preview feature. Microsoft Technical Support won’t be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use](https://go.microsoft.com/fwlink/p/?linkid=870960).

Capture information about parameters such as the period for which the forecast should be generated or the data to use for forecasting.

Forecasting helps your organization to predict how much revenue can a sales team generate in a specified timeline. As an administrator or Forecast manager, you can configure forecast in your organization for your or for a sales manager.  

> [!NOTE]
> The **Forecast manager** role is created specifically to configure forecasting. Using this role, you can:
> - Create, assign, and edit forecast configurations in your business unit and other business units that are subordinate to your business unit.
> - Delete forecast configuration that are defined only for your business unit.
> - Share forecast with all users in your organization.
> - View and edit forecast at your business unit and other business units that are subordinate to your business unit, after the configured forecast is published.
 
The following changes are made to the forecast configuration from the previous release:

| Feature type | Previous version | Current version |
|--------------|------------------|-----------------|
| Security roles | Forecast manager and Forecast user roles are supported.| Removed Forecast user role and support only Forecast manager to configure forecast.|
| Settings site map | The option to configure the forecast was Forecast definitions. | The option to configure the forecast is Forecast configuration. |
| Entity support |Supported opportunity entity only with the options set as Forecast category. | Supported opportunity entity with the custom options sets. |
| Feedback and comments | -- | Send your feedback or comments to [Forecast feedback](mailto:forecastingfeedback@microsoft.com). |


Perform the following steps to configure forecast in your organization:

1. [Review the prerequisites.](#prerequisites)

2. [Configure forecasting in your organization.](#configure-forecasting)

## Prerequisites

Verify the following prerequisites Before configuring the forecast:

- Administrator or Forecast manager role is assigned to you.

- Preview feature option is enabled. To learn more, see [How do I enable a preview feature](../admin/what-are-preview-features-how-do-i-enable-them.md#how-do-i-enable-a-preview-feature).

- Proper hierarchy is defined for the users for whom you are creating the forecast.

## Configure forecasting

Configuration of forecasting includes the following steps:

1. [Open forecast configuration wizard](#open-forecast-configuration-wizard)

2. [Enter configuration and scheduling information in the General tab](#enter-configuration-and-scheduling-information-in-the-general-tab)

3. [Setup column options in the Layout tab](#setup-column-options-in-the-layout-tab)

4. [Publish and upload quota for forecast](#publish-and-upload-quota-for-forecast)

### Open forecast configuration wizard

1.	Sign in to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] and open **Sales Hub** app.

2.  In the lower left of the site map, select the **Change area** icon ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area"), and then select the **App Settings** area.	

3.	In the site map, select **Goal Management** > **Forecast configuration**.

    The forecast configuration home page opens with a list of created forecasts.

    > [!div class="mx-imgBorder"]
    > ![Forecast configuration home page](media/forecast-home-page.png "Forecast configuration home page")

4.	Select **Org chart forecast**. A forecast configuration wizard opens.

    > [!div class="mx-imgBorder"]
    > ![Forecast configuration page with general tab](media/forecast-general-tab.png "Forecast configuration page with general tab")
    
    You can proceed creating forecast.
 
### Enter configuration and scheduling information in the General tab

Use the **General** tab to define the basic information such as name, configurations, and schedule details.

1. In **General** tab, enter a name of the forecast that explains what the forecast is about.

    > [!div class="mx-imgBorder"]
    > ![Enter forecast configuration name](media/forecast-general-tab-forecast-name.png "Enter forecast configuration name")

2. In the **Configuration** section, fill **Top user in hierarchy** field with the user whose team you want to create a hierarchy for. To the right of the selection, you can see a preview of the hierarchy for the selected user.

   Based on the user hierarchy (as defined by the **Manager** field of the User object) a forecast is created for all child users. For example, Aaron James (manager) requests his administrator (who has Forecast manager role) to create a forecast for his group. While configuring the forecast, the admin selects Aaron James as the top of the hierarchy so that the forecast is created based on Aaron's hierarchy. 

    > [!NOTE]
    > The parameters **Rollup entity** and **This hierarchy is made up of** are predefined and cannot be changed. Here, the **Rollup entity** value is **Opportunity** and **This hierarchy is made up of** value is **User**.

    > [!div class="mx-imgBorder"]
    > ![Configuration section](media/forecast-general-tab-configuration-section.png "Configuration section")

3. In the **Scheduling** section, enter the following information:

    | Parameter | Description |
    |-----------|-------------|
    | **Forecast period** | Select whether the forecast is to be generated monthly or quarterly. Quarterly is selected by default. You can create a forecast for up to a year.|
    | **Fiscal year** | Select the fiscal year for the forecast. This is populated based on the org’s fiscal year settings. |
    | **Forecast starts at** | Select when to start forecasting. If you select the forecast period as Monthly, select the month from which you want to start forecasting. If you select the forecast period as Quarterly, select the quarter from which forecasting should start. |
    | **Number of periods** | Enter the number of forecast periods that need to be generated. For example, when you select the forecast period as monthly, you can create a minimum of one to a maximum of 12 forecasts. <br> **Note:** If you select the forecast period as monthly, Fiscal year as FY19, Start month as January, and Number of forecasts as 4, the forecasts that are generated are grouped by four months, January, February, March, and April. In such case, the Forecast start and end date is automatically set to Jan 1, 2019, and April 30, 2019, respectively.|
    | **Valid from** | The start date is ready only and helps you to identify the date when the forecast starts. |
    | **Valid to** | The end date is ready only and helps you to identify the date when the forecast ends. |
 
    > [!div class="mx-imgBorder"]
    > ![Scheduling section](media/forecast-general-tab-scheduling-section.png "Scheduling section")

4. Select **Next** after you enter the required information. 

    You are guided to Layout tab to define what to display in the forecast grid.

### Setup column options in the Layout tab

Use the **Layout** tab to set up the columns for the forecast. This defines how the forecast grid appears for the users. You can choose these columns from option sets that are defined for opportunities in your organization.

1. In the **Layout and column** section, select **+ Add from option set**. A list of option set appears.

2. Choose an option set and select **Choose selected**. The application adds the columns to your forecast configuration.

    > [!TIP]
    > We recommend you to use **Forecast category** option set to configure the columns. When you select, a message appears to auto-populate the configuration parameters, Select **OK**. The values are auto-populated. This helps you to skip the process of configuring each parameter. However, if you want to edit a column, proceed to Step 3. 

    > [!div class="mx-imgBorder"]
    > ![Choose option set for forecast](media/forecast-layout-column-selection.png "Choose option set for forecast")

3. Hover the cursor over a column name and select the vertical ellipses and select **Configure**. 

    For example, hover the cursor over best case and select **Configure**.

    > [!div class="mx-imgBorder"]
    > ![Column configuration](media/forecast-layout-column-configuration-selection.png "Column configuration")

4. In the column configuration page, enter the following information:

    | Parameter | Description |
    |-----------|-------------|
    | **Name** | Name of the column|
    | **Type** | By default, **Rollup** is selected. This value depends on the **Rollup entity** that is selected in **General** tab.|
    | **Amount field** | Select an amount type for which you want to calculate the forecast revenue. The values displayed are based on the selected **Rollup entity** (**Opportunity**). For example, if **Forecast category** option set is selected, the amount field is configured as **Est. Revenue**.
    | **Date field** | Select a date type on which you want to calculate the forecast revenue. The values displayed are based on the selected **Rollup entity** (**Opportunity**). For example, if **Forecast category** option set is selected, the date field is configured as **Est. Close Date**. |
    | **Selector** | Select the column name for which you want to apply this configuration. |
    | **Allow adjustments** | Select this column for forecast owners to change or edit the forecast revenue in the forecast grid. when enabled, you can see a pencil icon corresponding to the forecast revenue for that column. |
    | **Show progress compared to quota** | Select this option to compare the actual revenue with forecast revenue. when enabled, you can see a progress bar with the achievement percentage below the forecast revenue for that column. |
    | **Unique name** | Unique name of the column.|

    After configuring the column, you can see a preview of the configuration in the **Preview** section. 

5. **Save and Close** the configuration.

    > [!div class="mx-imgBorder"]
    > ![Column configuration page with preview](media/forecast-layout-column-configuration-page.png "Column configuration page with preview")

6. Repeat **step 4** and **step 5** for the columns that you want to edit.

7. Select **Next**.

    Now, you can publish the configured forecast and set quota for the users to display in the forecast grid.

### Publish and upload quota for forecast

Use the **Publish & Quota** tab to generate a forecast based on the configurations defined in **General** and **Layout** tabs. Also, upload a template (excel file) with the proposed quota for users based on the selected **Top of hierarchy** in the **General** tab. 

> [!NOTE]
> The option to download and upload the template that specifies quota will not be active until you publish the forecast. So, you must publish the forecast before you upload the quota template to the forecast configuration.   

1. In the **Publish forecast** section, select **Publish forecast**.  The configured forecast starts calculating the values for forecast and is available for users in your organization. The publishing will take few minutes.

    > [!div class="mx-imgBorder"]
    > ![Publishing the forecast](media/forecast-publish-quota-publishing-forecast.png "Publishing the forecast")

    After the forecast is published, a confirmation message is displayed. Also, the option to download template is active.

    > [!NOTE]
    > If the publishing fails, the forecast definition’s status and status reason is set to Published and Failed respectively. To learn more, see [Why am I unable to publish forecast definition? ](../sales-enterprise/troubleshooting.md#why-am-i-unable-to-publish-forecast-definition).

2. In the **Upload a quota for this forecast** section, select **Download quota template**. A template (Excel file) with users in the hierarchy is downloaded to your local computer. 

    > [!div class="mx-imgBorder"]
    > ![Download quota template](media/forecast-publish-quota-download-quota-template.png "Download quota template")

    The name convention of the downloaded file is ***forecastname*_Quota.xlsx**. For example, if you have created a forecast with name **Aaron's forecast 2019**, the name of the downloaded file is **Aaron's forecast 2019_Quota.xlsx**.
    
3. Open the downloaded file and it contains two spreadsheets, **Individual** and **Manager**.
     
    - **Individual spreadsheet**: In the individual spreadsheet, you can view all the sales reps including the managers in the hierarchy. In the spreadsheet, enter quota for each individual under the **Quota as Individual** column. When the file is uploaded, the added quota is displayed under the **Quota** column in the forecast grid for each individual, including the managers. The quota you enter for managers in the **Individual** spreadsheet will not affect the quota that you enter in the **Manager** spreadsheet. A manager can also be working on opportunities and will have a quota an individual. In the following example, all the sales reps including the managers (**Wanda Graves** and **Rodger Pearl**) are listed and the quota is entered to all the individuals.

        > [!div class="mx-imgBorder"]
        > ![Enter individual quota in excel sheet](media/forecast-excel-individual-quota.png "Enter individual quota in excel sheet")

    - **Manager spreadsheet**: In the manager spreadsheet, you can view the users who are listed as managers in the selected hierarchy. In the spreadsheet, enter quota for each manager under the **Quota as Manager** column. When the file is uploaded, the added quota is displayed under the **Quota** column in the forecast grid for managers at a level above the individuals. In the following example, the quota is entered for the managers **Wanda Graves** and **Rodger Pearl**.

        > [!div class="mx-imgBorder"]
        > ![Enter manager quota in excel sheet](media/forecast-excel-manager-quota.png "Enter manager quota in excel sheet") 

    > [!IMPORTANT]
    > Do not change any values in the file other than the quota values.

4. Save and close the file.

5. In the **Upload a quota for this forecast** section, select the option to browse and upload, or drag and drop the file in the upload area. After you upload the file, the application processes the file and you can see the status at the bottom of the upload area.

    In this example, we are dragging and dropping the file in the upload area.

    > [!div class="mx-imgBorder"]
    > ![Drag and drop file in the upload area](media/forecast-publish-quota-drag-drop-file.png "Drag and drop file in the upload area")

6. After the file successfully uploads, select **Finish**.
 
    You are directed to the forecast configuration home page, where you have the forecasts defined for your organization are listed.

## See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)  

[View forecasts](view-forecasts.md)