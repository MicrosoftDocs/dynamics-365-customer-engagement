---
title: Configure components to display case associations | MicrosoftDocs 
description: Learn about adding Customer360 and Recent Records cards to forms
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 02/03/2023 
ms.custom: bap-template 
---

# Add and configure Associated Grid Control to forms

The **Associated Grid Control** control helps you add information related to tables, such as accounts or contacts on your form. This helps users get a better understanding of their customer interactions, and deliver more personalized service in an efficient and effective manner. Using this control, you can configure up to four subgrids to be displayed on a form.

## Add the component and configure the subgrid

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select a table, and then select the **Forms** area.
1. Open the form where you want to add the **Associated Grid Control**.
1. In the form designer, select **Components** from the left navigation, and then select **Associated Grid Control**.
1. Drag it to the form.
1. On the **Properties** panel of the **New associated grid control**, you can specify the following details to populate the records that's displayed on the first subgrid. 
    - Specify **Label** and **Name**.
    - Add  **Table** and **Default view** from which the records must be displayed.
    - **Customizer control**:  Specify the customizer control name for the entity. For example, if you're adding a case, you'll need to specify **MscrmControls.CustomCellControl.CustomCellControl**. More information: [Enable the grid control for the Case entity](enable-case-grids.md#enable-the-grid-control-for-the-case-entity)
     - **Customized title**: Specify the display name for the view. The view name is displayed by default if you don't specify a value for this field.
    - Select **Show related records** if you'd like to display only the relevant records and not all the available records. If you select this checkbox, the form displays only the related records for the table and view configured in **Subgrid 1**.
     
## Configure related records for multiple subgrids

If the control has to display related records for tables and views configured in **Subgrid 2** to **Subgrid 4**, you must specify the **Relationship name**. Relationships allow for queries to retrieve related data very efficiently. More information: [Table relationships overview](/power-apps/maker/data-platform/relationships-overview). 

 To find the relationship between tables, do the following:

1. In [Power Apps](https://make.powerapps.com/), select the **Table** that contains the form you've added the **Associated Grid Control** to.
1. Select **Relationships** from **Schema**.
1. On the page that appears, find the table you've added to the subgrid in the **Associated Grid Control** control.
1. Copy the **Name** that's displayed against the table.
1. Open the form where you've added the **Associated Grid Control**.
1.  Specify this is as the **Relationship Name** in **Edit Associated Grid Control**.


