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

Using the general properties and scheduling, you can define a forecast model by specifying a hierarchy and timespan. 

To enter configuration and scheduling information in the **General** step, follow these steps:

1.	On the **General** step, enter a descriptive name for the forecast. For example, **Kenny’s Org FY 2019 Forecast**.

    > [!div class="mx-imgBorder"]
    > ![Enter a Name for the forecast](media/forecast-general-properties-forecast-name.png "Enter a Name for the forecast")

2.	By default, the **Rollup entity** is configured as **Opportunity**. This value can't be changed.

    > [!div class="mx-imgBorder"]
    > ![Forecast rollup entity](media/forecast-rollup-entity-opportunity.png "Forecast rollup entity")

3.	Choose a **Default underlying records view**. This is the default view when users select a row or a cell of the forecast to view the underlying opportunities. To learn more, see [View and edit the underlying opportunities](View-manage-underlying-opportunities.md).

4.	The **Hierarchy route** is configured based on the template that you’ve selected. This determines how the forecast will roll up through your organization. The following **Hierarchy routes** are pre-defined:

    | Template | Hierarchy route | Description |
    |----------|-----------------|-------------|
    | Org chart forecast | Opportunity > Owner | The forecast hierarchy is defined based on the organizational hierarchy. |
    | Territory forecast | Opportunity > Account > Territory | The forecast hierarchy is defined based on the territory hierarchy. |

5.	In **Top of hierarchy**, choose the user or territory that is at the top of this forecast hierarchy. 

    For example, When the hierarchy route is selected as the Opportunity > Owner, the top of the hierarchy lists all active users in your organization. You can then select a user from the list for the top of the hierarchy. Say, **Kenny Smith**, a sales director, wants a forecast for his team, then he'll select his name as top name in the hierarchy for **Org chart** based forecast. 

    Once selected, you'll see a preview of full hierarchy on the right pane. 

    > [!div class="mx-imgBorder"]
    > ![Configuration section](media/forecast-general-tab-configuration-section.png "Configuration section")

6.	In the **Scheduling** section, specify the required information:

    | Parameter | Description |
    |-----------|-------------|
    | Forecast period | Select whether the forecast is to be generated monthly or quarterly. By default, **Quarterly** is selected. You can schedule the forecast up to one year. |
    | Fiscal year | Select the fiscal year for the forecast. This is populated based on the organization’s fiscal year settings. |
    | Forecast starts at | Select the time period to start forecasting. If you select the forecast period as **Monthly**, select the month from which you want to start forecasting. If you select the forecast period as **Quarterly**, select the quarter from which you want to start forecasting. |
    | Number of periods | Enter the number of forecast periods to be generated. You can only create forecasts that span a full year. <br> **Note**: If you select the Forecast period as monthly, Fiscal year as FY19, Forecast starts at as January, and Number of periods as 4, the generated forecasts will be grouped by four months, January, February, March, and April. In such case, the Forecast start and end dates are automatically set to January 1, 2019, and April 30, 2019, respectively. |
    | Valid from | The start date is read-only and helps you to identify the date when the forecast starts. |
    | Valid to | The end date is read-only and helps you to identify the date when the forecast ends. |
 
    > [!div class="mx-imgBorder"]
    > ![Scheduling section](media/forecast-general-tab-scheduling-section.png "Scheduling section")

7.	Select **Next**.

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Previous step: Select a template](select-template-forecast.md)
</td><td>

> [!div class="nextstepaction"] 
> [Next step: Provide permissions](provide-permissions-forecast.md)
</td></tr>
</table>

### See also

[Configure a forecast in your organization](configure-forecast.md)
