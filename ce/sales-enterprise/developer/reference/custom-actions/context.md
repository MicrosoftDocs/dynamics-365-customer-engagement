---
title: "context custom action (Dynamics 365 Sales) | MicrosoftDocs"
description: 
ms.date: 09/23/2020
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: get-started-article
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: susikka
---
# context custom action

This custom action passes the forecasting context object to the event handlers. 

> [!NOTE]
> This context object is forecasting context though API structure looks similar.

## context.getFormContext method

Returns a reference to a record on the forecasting editable grid.

## context.getFormContext().data.entity method

### context.getFormContext().data.entity.getentityName

Returns a string representing the logical name of the entity for the record.

### context.getFormContext().data.entity.getId

Returns a string representing the GUID value for the record.

### context.getFormContext().data.entity.attributes

Returns attributes list related to the view and entity that is loaded as part of forecasting editable grid.

Given below are some sample ways to get Attribute object.

- context.getFormContext().data.entity.attributes.forEach
- context.getFormContext().data.entity.attributes.getByName(arg)
- context.getFormContext().data.entity.attributes.get(index)

## context.getWebApiContext method


