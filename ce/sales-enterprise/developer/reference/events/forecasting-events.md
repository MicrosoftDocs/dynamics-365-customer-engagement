---
title: "Events that are related to forecasting (Dynamics 365 Sales) | MicrosoftDocs"
description: Events that are related to forecasting.
ms.date: 10/12/2020
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi

---

# Forecasting related events

Events occur in forecasting grids whenever a grid loads, data is changed, or saved. You execute your JavaScript code by associating it with an events so that it is executed when the event occurs. The following events are supported in forecasting:
- [OnRowLoad](#onrowload-event)
- [OnSave](#onsave-event)
- [OnChange](#onchange-event)

## OnRowLoad event

This event is triggered when a row (record) of the forecasting editable grid is loaded.

## OnSave event

This event is triggered when any field for forecasting editable grid is changed. OnChange of any field, will automatically trigger save for forecasting editable grid.
- There is a change in the record selection.
- The user explicitly triggers a save operation using the editable grid’s save button.
- The user applies a sort, filter, group, pagination, or navigation operation from the editable grid while there are pending changes.

## OnChange event

The OnChange event occurs when a value is changed in a cell in the editable grid and the cell loses focus. This event can also occur when an attribute value is updated using the setValue method

### See also

[Context object for event handlers in editable grid](../sales-enterprise/developer/reference/custom-actions/context.md)
