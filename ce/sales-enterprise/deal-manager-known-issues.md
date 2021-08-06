---
title: "Deal manager known issues - Sales Enterprise | MicrosoftDocs"
description: "This page describes known deal manager issues and suggests possible workarounds (if any)"
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Known issues in deal manager

This page includes the known issues in this release of deal manager.  

## Customization

### In Context Form appears in the form selector

The In Context Form is used for displaying the side panel in deal manager, and in the new interface for contacts, opportunities, leads, and accounts.  

However, this form appears in the form selector dropdown of these entities and thus lets users select this form. If this leads to confusion, you can deactivate the **In Context form** as shown in the screenshot below. 

:::image type="content" source="media/deactivate-incontext-form.PNG" alt-text="Screenshot of In Context form with the option to deactivate":::


## Filters

### Related entities aren't supported

Though you can add a related entity to the filter condition by using the **More filters** option, the condition displays an error state. 

**Workaround:**
Create a deal manager view, and add the filter condition with the related entity.  

## Charts

### The segment list is limited to two fields

When you customize the bubble chart, you have the option to change the **Segment by** option, which indicates the color of the bubble. Currently, this option only supports **Opportunity Grade** and **Pipeline Phase** fields. 

### The funnel chart can't be customized


Though you can customize the bubble chart, the Sales funnel chart can't be customized. You can only enable or disable the chart, or change its name.

### Smart fields aren't supported in tooltips
  
In the chart tooltip, you can only select the basic fields; smart fields aren't yet supported.

## Personalization

### Client-side personalization can't be saved to the view

Any personalization that you do in the deal manager workspace directly can't be saved to a view. For example, if you modify the metrics, edit columns, or add filters in the workspace, they won't be saved to a view. However, the changes will be available until you sign out.  


If you want to save the personalization changes, [create a view](personalize-deal-manager.md#create-a-view). 

### Views can't be edited

Editing the view from the deal manager workspace isn't supported in this release.

