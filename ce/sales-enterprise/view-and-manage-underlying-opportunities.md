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

# View and manage underlying opportunities 

To understand which opportunities are affecting forecast values, select one of the following options: 

- Select a row to show all opportunities, regardless of forecast category.

- Select a cell to show only the opportunities that match the roll-up column value.

> [!NOTE]
> Underlying opportunities won't be displayed for **Quota** and simple column types, because no opportunities contribute to calculating their values; you manually upload these values through an Excel workbook.

The opportunities you see in the table depend on the role assigned to you in the hierarchy that was used to configure the forecast.

For example, Alyce Durham is a manager and Nicolas Frizzell reports to her. Nicolas can see only his underlying opportunities, while Alyce can see her own and Nicolas's underlying opportunities.

You can view and edit underlying opportunities in two ways:

- [View and edit in a table view](#view-and-edit-in-a-table-view)

- [View and edit in a kanban view](#view-and-edit-in-a-kanban-view)

## View and edit in a table view

1.	Open a forecast. In this example, we're opening **Kenny's Org FY 2020 Forecast** for current quarter **FY2020 Q1**.

    > [!div class="mx-imgBorder"]
    > ![View forecast grid](media/forecast-view-forecast-grid.png "View forecast grid")

2.	Select a row or a cell for any level of the hierarchy for which you want to see underlying opportunities. 

    In this example, we're selecting **Alyce Durham**. Because she's a manager, all the underlying opportunities that are contributing to her team's forecast are listed. This view is opened as a table, by default.

    > [!div class="mx-imgBorder"]
    > ![View forecast grid](media/forecast-view-underlying-opportunities.png "View forecast grid")

    You can identify whether the selected opportunities belong to a team, an individual, a single cell value, or a full row by looking at the table heading. The format of the heading is described in the following table.

    | Heading format | Description |
    |----------------|-------------|
    | Username (Group) – All opportunities |All the opportunities across different forecast categories that the selected user and that user's team own. |
    | Username - All opportunities | All the opportunities across different forecast categories that the selected user owns. |
    | Username (Group) – Column name | The opportunities that the selected user and that user's team own for the selected forecast category. |
    | Username – Column name | All the opportunities that the selected user owns for the selected forecast category. |.

    You can change the view of these opportunities by using the view selector. By default, the view that was selected when the forecast was configured is displayed.

3.	To edit an opportunity, select the attribute that you want to edit, such as **Topic**, **Est. Revenue**, **Actual Revenue**, or **Forecast category**.

4.	After you edit the opportunity, press **Tab** or click outside the field. The modifications are saved, the opportunity is updated in Dynamics 365 Sales, and the forecast amounts instantly reflect the change.

    > [!NOTE]
    > You can open an opportunity by double-clicking in the non-editable space of the row. The opportunity opens in a new page, where you can edit and save the opportunity.


## View and edit in a kanban view

1.	Open a forecast. In this example, we're opening **Kenny's Org FY 2020 Forecast** for current quarter **FY2020 Q1**.

    > [!div class="mx-imgBorder"]
    > ![View forecast grid](media/forecast-view-forecast-grid.png "View forecast grid")

2.	Select a row or a cell for any level of the hierarchy for which you want to see underlying opportunities. 

    In this example, we're selecting **Alyce Durham**. Because she's a manager, all the underlying opportunities that are contributing to her team's forecast are listed. This view is opened in a table, by default.

    > [!div class="mx-imgBorder"]
    > ![View forecast underlying opportunities](media/forecast-view-underlying-opportunities.png "View forecast underlying opportunities")

    You can identify whether the selected opportunities belong to a team, an individual, a single cell value, or a full row by looking at the table heading. The format of the heading is described in the following table:

    | Heading format | Description |
    |----------------|-------------|
    | Username (Group) – All opportunities | All the opportunities across different forecast categories that the selected user and that user's team own. |
    | Username - All opportunities | All the opportunities across different forecast categories that the selected user owns. |
    | Username (Group) – Column name | The opportunities that the selected user and that user's team own for the selected forecast category. |
    | Username – Column name | All the opportunities that the selected user owns for the selected forecast category. |.

    You can change the view of these opportunities by using the view selector. By default, the view that was selected when the forecast was configured is displayed.

3.	Select **Show as Kanban**. 

    The table view changes into a kanban view. All the underlying opportunities are displayed as cards in their respective forecast categories. Each card displays attributes that you can edit. In this example, the opportunity name, **Owner**, **Est. Revenue**, and **Est. Close Date** are displayed.

    > [!div class="mx-imgBorder"]
    > ![View forecast underlying opportunities in kanban](media/forecast-view-underlying-opportunities-kanban.png "View forecast underlying opportunities in a kanban view")

    > [!NOTE]
    > The opportunities in columns **Won** and **Lost** are locked. You can't edit these values directly, because multiple attribute values must be set to enter an opportunity as **Won** or **Lost**. However, you can select the name of the opportunity, and the opportunity will open in a new page where you can edit the opportunity, and then save and close it.

4.	To edit the opportunity, you can directly change the values for the attributes displayed on the card, and drag the cards from one forecast category to another.
    
    The changes are saved, and the opportunity is updated in Dynamics 365 Sales. The changes are also automatically applied in the forecast grid.

    > [!NOTE]
    > To edit more attributes for the opportunity, select the name of the opportunity. The opportunity will open in a new page, where you can edit it as required, and then save and close it.

### See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)<br>
[View a forecast](view-forecasts.md)
