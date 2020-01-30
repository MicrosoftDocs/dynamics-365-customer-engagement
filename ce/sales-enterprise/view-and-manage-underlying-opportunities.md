---
title: "View and manage the opportunities pipeline through sales forecasting (Dynamics 365 Sales) | MicrosoftDocs"
description: "View and manage the opportunities pipeline through sales forecasting in Dynamics 365 Sales."
ms.date: 02/03/2020
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# View and manage the underlying opportunities 

To understand what opportunities are impacting the forecast values, select one of the following options to see opportunities table under the forecast grid: 

- A row to show all opportunities regardless of forecast category.

- A cell to show only the opportunities that match the rollup column value.

> [!NOTE]
> Underlying opportunities will not be displayed for **Quota** and simple column types, since no opportunities will be contributing to calculate their values and you manually upload the values through an Excel file.

The opportunities you see in the table depends on the role assigned to you in the hierarchy that is used to configure the forecast.

For example, Alyce Durham is a manager and Nicolas Frizzell reports to her. Nicolas can see only his underlying opportunities and Alyce can see her and Nicolas's underlying opportunities.

You can view and edit the underlying opportunities in two ways:

- [View and edit in a table view](#view-and-edit-in-a-table-view)

- [View and edit in a Kanban view](#view-and-edit-in-a-Kanban-view)

## View and edit in a table view

Follow these steps to view and edit opportunities in table:

1.	Open a forecast. In this example, we're opening **Kenny's Org FY 2020 Forecast** for current quarter **FY2020 Q1**.

    > [!div class="mx-imgBorder"]
    > ![View forecast grid](media/forecast-view-forecast-grid.png "View forecast grid")

2.	Select a row or a cell for any level of the hierarchy for which you want to see the underlying records. 

    In this example, we're selecting **Alyce Durham** and as a manager, all the underlying opportunities that are contributing to her team’s forecast are listed.
    
    By default, the view is opened in a table experience.

    > [!div class="mx-imgBorder"]
    > ![View forecast grid](media/forecast-view-underlying-opportunities.png "View forecast grid")

    Also, you can identify whether the selected opportunities are for a team, an individual, a single cell value, or a full row by looking at the table heading. The format of the heading is described in the following table:

    | Heading format | Description |
    |----------------|-------------|
    | Username (Group) – All opportunities | You're looking at all the opportunities across different forecast categories that the selected user and user’s team own. |
    | Username - All opportunities | You're looking at all the opportunities across different forecast categories that the selected user owns. |
    | Username (Group) – Column name | You're looking at the opportunities that the selected user and user’s team own for that selected forecast category. |
    | Username – Column name | You're looking at all the opportunities that the selected user owns for the selected forecast category. |.

    You can change the view of the opportunities through the view selector. By default, the view that is selected during the forecast configuration is displayed.

3.	To edit an opportunity, click the attribute that you want to edit, such as **Topic**, **Est. Revenue**, **Actual Revenue**, and **Forecast category**.

4.	After you edit the opportunity, press **Tab** or click outside the field. The modifications are saved, the opportunity is updated in Dynamics 365 sales and the forecast amounts instantly reflect the change.

    > [!NOTE]
    > You can open the opportunity, by double-clicking in the non-editable space of the row. The opportunity opens in a new page. You can edit and save the opportunity as required.


## View and edit in a Kanban view

Follow these steps to view and edit opportunities in Kanban:

1.	Open a forecast. In this example, we're opening **Kenny's Org FY 2020 Forecast** for current quarter **FY2020 Q1**.

    > [!div class="mx-imgBorder"]
    > ![View forecast grid](media/forecast-view-forecast-grid.png "View forecast grid")

2.	Select a row or a cell for any level of the hierarchy for which you want to see the underlying records. 

    In this example, we're selecting **Alyce Durham** and as a manager, all the underlying opportunities that are contributing to her team’s forecast are listed.
    
    By default, the view is opened in a table experience.

    > [!div class="mx-imgBorder"]
    > ![View forecast underlying opportunities](media/forecast-view-underlying-opportunities.png "View forecast underlying opportunities")

    Also, you can identify whether the selected opportunities are for a team, an individual, a single cell value, or a full row by looking at the table heading. The format of the heading is described in the following table:

    | Heading format | Description |
    |----------------|-------------|
    | Username (Group) – All opportunities | You're looking at all the opportunities across different forecast categories that the selected user and user’s team own. |
    | Username - All opportunities | You're looking at all the opportunities across different forecast categories that the selected user owns. |
    | Username (Group) – Column name | You're looking at the opportunities that the selected user and user’s team own for that selected forecast category. |
    | Username – Column name | You're looking at all the opportunities that the selected user owns for the selected forecast category. |.

    You can change the view of the opportunities through the view selector. By default, the view that is selected during the forecast configuration is displayed.

3.	Select **Show as Kanban**. 

    The table view changes into a Kanban view. All the underlying opportunities are displayed as cards in their respective forecast categories. Each card displays attributes that you can edit. In this example, the opportunity name, **Owner**, **Est. Revenue**, and **Est. Close Date** are displayed.

    > [!div class="mx-imgBorder"]
    > ![View forecast underlying opportunities in kanban](media/forecast-view-underlying-opportunities-kanban.png "View forecast underlying opportunities in kanban")

    > [!NOTE]
    > The opportunities in columns **Won** and **Lost** are locked. You cannot edit the attribute values in these columns since there are multiple attribute values that you have to enter to set an opportunity as **Won** or **Lost**. However, you can select the name of the opportunity and the opportunity opens on a new page. Edit the opportunity here and then save and close.

4.	To edit the opportunity, you can directly change the values for the attributes displayed on the card and drag and drop the cards from one forecast category to another.
    
    The changes are saved, and the opportunity is updated in Dynamics 365. Also, the changes are automatically applied in the forecast grid.

    > [!NOTE]
    > To edit more attributes for the opportunity, select the name of the opportunity and the opportunity opens on a new page. Edit the attributes as required.


### See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)

[View a forecast](view-forecasts.md)
