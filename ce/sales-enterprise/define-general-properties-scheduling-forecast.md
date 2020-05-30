---
title: "Define general properties and scheduling for a forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "Define general properties and scheduling for a forecast in Dynamics 365 Sales."
ms.date: 02/03/2020
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Define general properties and scheduling

Using the general properties and scheduling options of the forecast configuration page, you can define a forecast model by specifying a hierarchy and timeframe. 

**To enter configuration and scheduling information**

1.	In the **General** step, enter a descriptive name for the forecast. For example, **Kenny's Org FY 2019 Forecast**.

    > [!div class="mx-imgBorder"]
    > ![Enter a name for the forecast](media/forecast-general-properties-forecast-name.png "Enter a name for the forecast")

    >[!NOTE]
    >By default, **Rollup entity** is configured as **Opportunity**. This value can't be changed.<br>
    >![Forecast rollup entity](media/forecast-rollup-entity-opportunity.png "Forecast rollup entity")

2.	Choose a **Default underlying records view**. This is the default view used when users select a row or a cell of the forecast to view its underlying opportunities. To learn more, see [View and manage underlying opportunities](view-and-manage-underlying-opportunities.md).


    **Hierarchy route** is configured based on the template that you've selected. This determines how the forecast will roll up through your organization. The following **Hierarchy routes** are predefined:

    | Template | Hierarchy route | Description |
    |----------|-----------------|-------------|
    | Org chart forecast | Opportunity > Owner | The forecast hierarchy is defined based on the organizational hierarchy. |
    | Territory forecast | Opportunity > Account > Territory | The forecast hierarchy is defined based on the territory hierarchy. |

3.	In the **Top of hierarchy** list, choose the user or territory that's at the top of this forecast hierarchy. 

    When the hierarchy route is **Opportunity > Owner**, the top of the hierarchy lists all active users in your organization. You can then select a user from the list to be displayed at the top of the hierarchy. 
    
    For example, Kenny Smith, a sales director, is looking at a forecast based on the **Org chart** template. He wants to see a forecast for his team, so he selects his name as the top name in the hierarchy. After Kenny makes his selection, he can see a preview of the full hierarchy in the rightmost pane. 

    > [!div class="mx-imgBorder"]
    > ![Configuration section](media/forecast-general-tab-configuration-section.png "Configuration section")

4.	In the **Scheduling** section, specify the following information.

    | Parameter | Description |
    |-----------|-------------|
    | Forecast period | Select whether the forecast is to be generated monthly or quarterly. By default, **Quarterly** is selected. You can schedule the forecast up to one year. |
    | Fiscal year | Select the fiscal year for the forecast. This is populated based on the organization's fiscal year settings. |
    | Forecast starts at | Select the time period to start forecasting. If you select the forecast period as **Monthly**, select the month you want to start forecasting. If you select the forecast period as **Quarterly**, select the quarter you want to start forecasting. |
    | Number of periods | Enter the number of forecast periods to be generated. You can only create forecasts that span up to one year. <br> **Note**: If you set the **Forecast period** to **Monthly**, **Fiscal year** to **FY19**, **Forecast starts at** as **January**, and **Number of periods** as **4**, the generated forecasts will be grouped by four months: January, February, March, and April. In such a case, the forecast start and end dates will automatically be set to January 1, 2019 and April 30, 2019, respectively. |
    | Valid from | This field is read-only. It identifies the date the forecast starts. |
    | Valid to | This field is read-only. It identifies the date the forecast ends. |
 
    > [!div class="mx-imgBorder"]
    > ![Scheduling section](media/forecast-general-tab-scheduling-section.png "Scheduling section")

5.	Select **Next**.

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Previous step: Select a template](select-template-forecast.md)
</td><td>

> [!div class="nextstepaction"] 
> [Next step: Provide viewing permissions](provide-permissions-forecast.md)
</td></tr>
</table>

### See also

[Configure forecasts in your organization](configure-forecast.md)

[Troubleshooting forecasts](ts-forecasts.md)
