---
title: Overview of visual hierarchies
description: Learn about the visual hierarchy feature and its benefits.
ms.topic: overview
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: get-started
ms.date: 12/05/2025
ms.custom: bap-template 
---

# Overview of visual hierarchies

Your organization can now see and work with customers data in a visual hierarchical layout, providing instant visibility across related data. Visual hierarchies can visually display standard and custom tables of data, and a wide array of data relationships.  

- Admins design and publish hierarchies for the organization in the hierarchy designer.
- Users can view and edit records without having to leave the hierarchy, allowing the hierarchy to be used as a primary workspace.  
- Users can easily navigate and change the hierarchy layout to suit their preferences.  

Watch this video for a quick overview of visual hierarchy:  

> [!VIDEO https://go.microsoft.com/fwlink/?linkid=2345010]

## Types of hierarchies

Visual hierarchies are flexible, allowing you to display data from a single table, multiple tables, or a mix of both.  

### Single table

Hierarchies are created from data in a single table with a **self-referential** relationship that allows each row in the table to reference its parent row. For example, accounts can point at their parent account, allowing a hierarchy of accounts to be defined.  

The following screenshots show an example of a single table hierarchy of accounts in the designer and how it appears to users.  

- In designer view, admins design a single table hierarchy by selecting **Expand all levels** for the table in the designer.  
    :::image type="content" source="media/hierarchy-visualization-example.png" alt-text="Screenshot of a visual hierarchy.":::  
- Users view the hierarchy of a selected account and its related children.  
    :::image type="content" source="media/hierarchy-visualization-example-user-view.png" alt-text="Screenshot of a visual hierarchy in user view.":::  

### Multi-table

Hierarchies can also visually include data from different tables. For example, you might want to provide your sellers an Account view that shows related opportunities and contacts as illustrated below.  

- In designer view, admins design a multi-table hierarchy by adding child nodes for related table.  
    :::image type="content" source="media/cross-table-hierarchy-visualization-example.png" alt-text="Screenshot of a multi-table hierarchy visualization in the designer with Account, Contact, and Opportunity.":::

- In the user view, the hierarchy shows the account and its related contacts, open opportunities, and closed opportunities.  
    :::image type="content" source="media/cross-table-hierarchy-visualization-example-user-view.png" alt-text="Screenshot of a multi-table hierarchy visualization in user view with Account, Contact, and Opportunity.":::

### Hybrid  

In a multi-table hierarchy, any table with self-referential data can be configured to show all levels. This allows for interesting scenarios such as a showing contacts with child contacts in the above example.  

## Key capabilities of visual hierarchy  

The visual hierarchy feature includes the following key capabilities:

- **Customize tiles**: Admins customize hierarchy tiles choosing what fields to display on a tile, if descriptive labels are shown, if a picture should be shown, and the size and color of tiles.  
- **Drill down**: Navigate through different levels of hierarchical data. You can expand and collapse branches, zoom in and out, and switch between vertical and horizontal layouts to get a clear view of the data structure.
- **Quick actions**: Users can take quick actions on a tile to add a record or associate an existing record, or jump to the full screen details.  
- **Fully editable details pane**: Select a tile to display the side pane that provides full capability to view and edit details for the record. Easily expand the side pane to full screen. The following screenshot shows an example of the details pane for a contact record.  
    :::image type="content" source="media/hierarchy-visualization-details-pane.png" alt-text="Screenshot of the details pane for an account record in visual hierarchy.":::

## Getting started with visual hierarchy

To get started with visual hierarchy, follow these steps:  

1. Admin [designs a hierarchy](create-activate-hierarchy-visualizations.md).  
1. Admin [grants access to hierarchies](create-activate-hierarchy-visualizations.md#grant-access-to-hierarchies).  
1. Admin [adds a View hierarchy entry point](add-hierarchy-visualization-custom-tables.md) to the desired entity.  
1. Admin [publishes the hierarchy to the organization](create-activate-hierarchy-visualizations.md#preview-and-publish-hierarchy).  
1. Users [view data in a hierarchy](view-hierarchy-visualizations.md).  
