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

Events occur in forecasting editable grid whenever a grid loads, data is changed, or saved. You execute your JavaScript code by associating it with an event so that it is executed when the event occurs. The following events are supported in forecasting:
- [OnRowLoad](#onrowload-event)
- [OnSave](#onsave-event)
- [OnChange](#onchange-event)

## OnRowLoad event

The `OnRowLoad` event is triggered when a row (record) of the forecasting editable grid is loaded.

## OnSave event

The `OnSave` event occurs when a field is changed in forecasting editable grid and triggers save operation. This event will not trigger if notifications are added using the `OnChange` handler.

## OnChange event

The `OnChange` event occurs when a value is changed in a cell in the editable grid and the cell loses focus.

> [!NOTE]
> The function names in JavaScript file should match these event names and must accept context object parameter. More information: [Context object for event handlers in editable grid](../custom-actions/context.md). 

### See also

[Context object for event handlers in editable grid](../custom-actions/context.md)
