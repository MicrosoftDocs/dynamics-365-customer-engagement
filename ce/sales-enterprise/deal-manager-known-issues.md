---
title: "Known issues in deal manager - Sales Enterprise | MicrosoftDocs"
description: "This page includes known issues in deal manager and possible workarounds if any"
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Known issues in deal manager

This page includes known issues in this release of deal manager. We're actively working on these issues and we should have an update soon.  

## Filters

### Related entities are not supported

Though you can add a related entity to the filter condition using the **More filters** option, the condition displays an error state. 

**Workaround:**
Create a deal manager view and add the filter condition with the related entity.  

## Charts

### Segment list is limited to two fields

When you customize the bubble chart, you have the option to change the Segment by option, which indicates the color of the bubble. Currently, this option only supports  Opportunity Grade and Pipeline Phase fields. 

### Funnel chart can't be customized

Though you can customize the bubble chart, the Sales funnel chart cannot be customized. You can only enable or disable the chart and change the name of the chart.

### Smart fields are not supported in tooltips
  
In the chart tooltip, you can only select the basic fields; smart fields are not yet supported.

## Personalization

### Client-side personalization can't be saved to the view

Any personalization that you do in the deal manager workspace directly can't be saved to a view. For example, if you modify the metrics, edit columns, or add filters in the workspace, they will not be saved to a view. However, the changes will be available until you logout. 

If you want to save the personalization, [create a view](personalize-deal-manager.md#create-a-view) and make those changes. 

### Views can't be edited

Currently, editing the view from the deal manager workspace is not supported. However, you can edit the view in Power Apps.