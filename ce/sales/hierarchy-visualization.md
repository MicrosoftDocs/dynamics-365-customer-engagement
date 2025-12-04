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

- Admins design and publish hierarchies for the organization quickly, creating complex hierarchies across multiple tables and relationship types in the hierarchy designer.
- Users viewing a hierarchy can select and edit records without having to leave the hierarchy view, allowing the hierarchy view to be used as a primary workspace.  
- Users quickly navigate and change the hierarchy layout to suit their preferences for different data shapes.  

## Types of hierarchies

Visual hierarchies are flexible, allowing you to display related data from within a single table, related data from multiple tables, or a mix of both.  

### Single table

Hierarchies are created from data in a single table with a **self-referential** relationship that allows each row in the table to reference its parent row. For example, accounts can point at their parent account, allowing a hierarchy of accounts to be defined.  

The following screenshots show an example of a single table hierarchy of accounts in the designer and how it appears to users.  

- In designer view, admins design a single table hierarchy by selecting **Expand all levels** for the table in the designer.  
    :::image type="content" source="media/hierarchy-visualization-example.png" alt-text="Screenshot of a hierarchy visualization.":::  
- In the user view, the hierarchy shows the configuration from the designer&mdash;an account and its related children for the account table.
    :::image type="content" source="media/hierarchy-visualization-example-user-view.png" alt-text="Screenshot of a hierarchy visualization in user view.":::  

### Multi-table relationships

Hierarchies can also visually show hierarchies of different types of data using the relationship data between two tables. For example, you might want to provide your sellers an Account view that shows opportunities directly related to the account, contacts, opportunities, or all of the above.  

The following screenshot shows an example of a multi-table hierarchy of accounts, contacts, and opportunities. 

- In designer view, admins design a multi-table hierarchy by adding child nodes for each related table in the designer.  
    :::image type="content" source="media/cross-table-hierarchy-visualization-example.png" alt-text="Screenshot of a multi-table hierarchy visualization in the designer with Account, Contact, and Opportunity.":::

- In the user view, the hierarchy shows the account and its related contacts and opportunities, both open and closed, as configured in the designer.  
    :::image type="content" source="media/cross-table-hierarchy-visualization-example-user-view.png" alt-text="Screenshot of a multi-table hierarchy visualization in user view with Account, Contact, and Opportunity.":::

### Hybrid hierarchies  

Any table in a hierarchy can be configured to show self-referential data, allowing for interesting scenarios such as a self-referential hierarchy of accounts where each account tile shown might have its own contacts and opportunities. You might even have self-referential opportunities, so instead of just showing directly linked opportunities, you might see a tree of opportunities such as when a Deal opportunity must be closed before the Installation opportunity and Service Contract opportunities can be pursued.  

## Key capabilities of visual hierarchy  

The visual hierarchy feature includes the following key capabilities:

- **Drill down**: Navigate through different levels of hierarchical data. You can expand and collapse branches, zoom in and out, and switch between vertical and horizontal layouts to get a clear view of the data structure.
- **Customize tiles**: Customize hierarchy tiles to meet your needs. This includes the ability to choose what fields to display on a tile, if descriptive labels are shown, if a picture should be shown, and the size and color of tiles.  
- **Quick actions**: Use the quick actions on a tile to add new record or associate an existing record, or jump to the full screen details.  
- **Fully editable details pane**: Select a tile to display a details side pane that provides full capability to view and edit details for the record. Easily expand the side pane to full screen if desired. The following screenshot shows an example of the details pane for a contact record.  
    :::image type="content" source="media/hierarchy-visualization-details-pane.png" alt-text="Screenshot of the details pane for an account record in visual hierarchy.":::

## Getting started with visual hierarchy

To get started with visual hierarchy, follow these steps:  

1. Admins [designs the hierarchy](create-activate-hierarchy-visualizations.md).  
1. Admins [grants access to the hierarchy](create-activate-hierarchy-visualizations.md#grant-access-to-hierarchies).  
1. Admins [adds a View hierarchy point](add-hierarchy-visualization-custom-tables.md) to the desired entity.  
1. Admins [publishes the hierarchy to the organization](create-activate-hierarchy-visualizations.md#design-and-publish).  
1. Users [view data in the hierarchy](view-hierarchy-visualizations.md).  
