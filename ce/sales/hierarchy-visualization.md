---
title: Overview of hierarchy visualization
description: Learn about the hierarchy visualization feature and its benefits.
ms.topic: overview
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: get-started
ms.date: 08/22/2025
ms.custom: bap-template 
---

# Overview of hierarchy visualization

Hierarchy visualization helps you visually represent data that has parent-child relationships, allowing users to instantly see connections such as Parent-Child, Manager-Employee, or Owner-Asset. Instead of viewing data as a flat list, hierarchy visualization displays it in a tree-like or network structure, making complex relationships clear and actionable&mdash;empowering better decisions and more efficient workflows in your enterprise.  
The following table summarizes the different hierarchies available in Dynamics 365 Sales:  

| Hierarchy type | Description | Example |
|----------------|-------------|---------|
| Self-referential (simple) | Within the same table, each row can reference its parent row. | An account record with parent-child relationship will show CEO &rarr; VP of Sales &rarr; Regional Sales Manager &rarr; Sales Representative. |
| Cross-table (complex) | Relationships between records in different tables with parent-child relationships. | An account record can have related contacts, opportunities, and orders shows Account &rarr; Contacts &rarr; Opportunities &rarr; Orders. |  

Here is an example of how a simple hierarchy visualization with single looks:

:::image type="content" source="media/hierarchy-visualization-example.png" alt-text="Screenshot of a hierarchy visualization.":::

## Key capabilities of hierarchy visualization  

The hierarchy visualization feature includes the following key capabilities:

- **Hierarchical view**: Visualize data in a tree-like structure, making it easier to understand relationships and dependencies.
- **Cross-table support**: Visualize relationships between records in different tables, enabling a more comprehensive view of your data landscape.
- **Drill down**: Navigate through different levels of hierarchical data. You can expand and collapse branches, zoom in and out, and switch between vertical and horizontal layouts to get a clear view of the data structure.
- **Customize tiles**: Customize hierarchy tiles to meet your needs. This includes the ability to choose what fields to display on a tile, if descriptive labels are shown, if a picture should be shown, and the size and color of tiles.  
- **Fully editable details pane**: Select a tile to display a details side pane that provides full capability to view and edit details for the record. Easily expand the side pane to full screen if desired.  
- **Quick actions**: Use the quick actions on a tile to add new record or associate an existing record, or jump to the full screen details.  

## How to use hierarchy visualization

Depending on your role, you can use hierarchy visualization to understand and manage complex data structures.  

| User role | Reference |
|-----------|-----------|
| Administrator | [Create and publish a hierarchy visualization](create-activate-hierarchy-visualizations.md)<br>[Manage hierarchy visualization](manage-hierarchy-visualizations.md)<br>[Add hierarchy visualization to custom tables](add-hierarchy-visualization-custom-tables.md) |
| Seller | [View and understand hierarchy visualization](view-hierarchy-visualizations.md) |

## Example of a complex hierarchy with Account, Lead, and Opportunity

**Scenario**: A sales team wants to visualize the relationships between accounts, leads, and opportunities to identify potential sales opportunities and manage customer relationships effectively. Let's explore this in detail.
An account can have multiple leads and opportunities associated with it. Each lead represents a potential customer or contact interested in the account's products or services, while each opportunity represents a potential deal or sale associated with the account. The hierarchy visualization will show how these entities are connected, allowing the sales team to see the full picture of their sales pipeline.  

**Hierarchy Structure**: Account (root node) &rarr; Leads (child nodes) &rarr; Opportunities (child nodes)

- **Leads (child nodes)**: Each lead represents a potential customer or contact interested in the account’s products/services and might originate from different campaigns or sources.  
- **Opportunities (child nodes)**: Each opportunity is a potential deal or sale associated with the account and might be linked directly to the account or to specific leads (if a lead is qualified and converted). Opportunities have their own sub-relationships, such as associated products, quotes, or activities.

The following table explains the sample data fields used in the hierarchy visualization:

| Account Name | Lead Name   | Opportunity Name | Opportunity Stage | Value    |
|--------------|-------------|------------------|-------------------|----------|
| Contoso Ltd. | Alice Brown | Web Form         | Q1 Expansion      | $50,000  |
| Contoso Ltd. | Bob Smith   | Event            | Renewal 2025      | $80,000  |
| Contoso Ltd. | Carol White | Referral         | New Product Intro | $30,000  |

When admin configures the hierarchy visualization for this scenario for the account **Contoso Ltd.**, the sales team can see the following structure as shown in the image:  

:::image type="content" source="media/complex-hierarchy-visualization-example.png" alt-text="Screenshot of a complex hierarchy visualization with Account, Lead, and Opportunity.":::

