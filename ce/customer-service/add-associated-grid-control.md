---
title: Configure components to display case associations | MicrosoftDocs 
description: Learn about adding Customer360 and Recent Records cards to forms
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 03/01/2023 
ms.custom: bap-template 
---

# Add and configure Associated Grid Control component on a form

The **Associated Grid Control** component helps you display the related details of a table record as subgrids. If you add this control to a form, you can configure up to four subgrids to display the relevant details.

If you've added  **Associated Grid Control** to a form, here's what the user sees when the form loads:

 :::image type="content" source="media/associated-grid-control-img-mini.png" alt-text="Image of card during runtime" lightbox="media/associated-grid-control-img.png":::

## Add the component and configure the subgrid

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select a table, and then select the **Forms** area.
1. Open the form where you want to add the **Associated Grid Control**.
1. In the form designer, select **Components** from the left navigation, and then select **Associated Grid Control**.
1. Drag it to the form.
1. On the **Properties** panel, you can specify the following details to populate the records that's displayed on the first subgrid. 
    - Specify **Label** and **Name**.
    - Add  **Table** and **Default view** from which the records must be displayed.
    - **Customizer control**: Specify the customizer control name for the entity. For example, if you're adding a case, you need to specify **MscrmControls.CustomCellControl.CustomCellControl**. More information: [Enable the grid control for the Case entity](enable-case-grids.md#enable-the-grid-control-for-the-case-entity)
     - **Customized title**: Specify the display name that appears as the subgrid's name when the card loads. The original view name is displayed by default if you don't specify a value for this field.
    - Select **Show related records** if you'd like to display only the records related to the current records that are displayed on the form and not all the available records. If you select this checkbox, the form displays only the related records from the table and view configured in **Subgrid 1**.

    :::image type="content" source="media/assoc-case-grid-mini.png" alt-text="Image of the component on Powerapps" lightbox="media/assoc-case-grid.png":::
     
## Configure related records for multiple subgrids

The **Associated Grid Control** also displays related records from the tables configured in **Subgrid 2** to **Subgrid 4** if you specify the corresponding table relationships in **Relationship name**. Table relationships allow for queries to retrieve related data efficiently. More information: [Table relationships overview](/power-apps/maker/data-platform/relationships-overview). 

 To find the relationship between tables, do the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the **Table** that contains the form you've added the **Associated Grid Control** to.
1. Select **Relationships** from **Schema**.
1. On the page that appears, find the table you've added to the subgrid in **Associated Grid Control**.
1. Copy the **Name** that's against the table.
1. Open the form where you've added the **Associated Grid Control**.
1. Specify the name as the **Relationship Name** in **Edit Associated Grid Control**.

## Add an alternate grid control

Out-of-the-box, **Associated Grid Control** uses the Power Apps grid control that supports the latest Microsoft accessibility standards and is built to be performant, extensible for the future, and aligns with the latest guidance for fonts, sizing, and styling. However, you can choose to add an alternate grid control.

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
2. Select **Solutions**, and then select the required solution.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Grid type for Associated grid control** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Grid type for Associated grid control** option to your solution.
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Grid type for Associated grid control** option. The **Edit Grid type for Associated grid control** pane appears. The **Default value** is set to **Microsoft.PowerApps.PowerAppsOneGrid**.
1. Select **Add existing value** in **Setting environment value**. Specify **MscrmControls.Grid.PCFGridControl** to replace the default values for all the apps in your environment.
1. Optionally, select **New app value** for the app. For a specified app, the tab set at the application level overrides the environment level setting.
1. Select **Publish All Customizations**.

   :::image type="content" source="media/edit-grid-type-assoc.png" alt-text="Add an alternate grid control" lightbox="media/edit-grid-type-assoc.png":::

## See also

[Overview of the model-driven form designer](/power-apps/maker/model-driven-apps/form-designer-overview)  
