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

# Configure components to display case associations

The **Associated Grid Control** component helps you display details related to a record as subgrids. You can configure up to four subgrids using this component.

The following screenshot is an example of how you can display knowledge articles, similar, merged, and child cases related to a case using **Associated Grid Control** :

   :::image type="content" source="media/associated-grid-control-img-mini.png" alt-text="Image of card during runtime" lightbox="media/associated-grid-control-img.png":::

## Add the component and configure the subgrid

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select a table, and then select the **Forms** area.
1. Open the form to which you want to add **Associated Grid Control**.
1. In the form designer, select **Components** from the left navigation, and then select **Associated Grid Control**.
1. Drag it to the form.
1. On the **Properties** panel, specify the following details to populate the records to be displayed on the first subgrid.
    - Add  **Table** and **Default view** from which the records must be displayed.
    - Select **Show related records** if you'd like to display only records that are related to the current record on the form and not all the available records. If you select this checkbox, the form displays only the related records in **Subgrid 1**.
 1. To customize the subgrid further, select **Associated Grid Control** in **Components**. Specify the following values in the **Edit Associated Grid Control** pane that appears:
    - **Customizer control**: Specify the customizer control name for the entity. For example, you've configured a subgrid to display child cases. For the subgrid to display color-coded priority icons, you'll need to set the value of this field to  **MscrmControls.CustomCellControl.CustomCellControl**. More information: [Enable the grid control for the Case entity](enable-case-grids.md#enable-the-grid-control-for-the-case-entity)
     - **Customized title**: Specify the display name that appears as the subgrid's name when the card loads. The original view name is displayed by default if you don't specify a value for this field.  
1. To configure subgrids 2 to 4, specify the values for **Table**, **Default View**, **Customizer control**, and **Customizer control** for the corresponding subgrids in the **Edit Associated Grid Control** pane.
1. You'll also have to specify the table relationship in [**Relationship Name**](add-associated-grid-control.md#configure-related-records-for-multiple-subgrids) to display the related records in **Subgrid 2** to **Subrgid 4**. 

    :::image type="content" source="media/assoc-case-grid-mini.png" alt-text="associated grid control" lightbox="media/assoc-case-grid.png":::

     
## Configure related records for multiple subgrids

You can select **Show related records** check box to display the related records for only **Subgrid 1** in **Associated Grid Control**. To display related records in **Subgrid 2** to **Subgrid 4** you need to specify the corresponding table relationships in **Relationship name**. Table relationships allow for queries to retrieve related data efficiently. More information: [Table relationships overview](/power-apps/maker/data-platform/relationships-overview). 

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

   :::image type="content" source="media/edit-grid-type-assoc-mini.png" alt-text="Add an alternate grid control" lightbox="media/edit-grid-type-assoc.png":::

## See also

[Overview of the model-driven form designer](/power-apps/maker/model-driven-apps/form-designer-overview)  
