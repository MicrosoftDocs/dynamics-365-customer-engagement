---
title: Configure components to display customer details and recent records | MicrosoftDocs 
description: Learn about adding Customer360 and Recent Records cards to forms
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 02/03/2023 
ms.custom: bap-template 
---

# Add components to display customer details and recent cases on the Case form 

The **Customer 360** and **Recent records** components, when added to a form, display the customer details and related records on the corresponding application page. 

## Add the Customer 360 component to a case form

When an agent specifies a customer on the case, the application must display the relevant details. For the Customer lookup on the Case form to display records from both the Account and Contact table, perform the following tasks:

1. Add the **Customer 360** component to the **Account** and **Contact** tables.
1. Add the form component control created on the **Account** and **Contact** tables to the **Case** form. More information: [Edit related table records directly from another table’s main form](/power-apps/maker/model-driven-apps/form-component-control)

> [!NOTE]
> You can follow these steps to display customer records on any entity where the Customer lookup is available.

**1. Add the Customer 360 component to Contact and Account forms**

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
1.  Select **Tables**, select **Account**, and then select the **Forms** area.
1. Create a new form or use an existing form. More information: [Create, edit, or configure forms using the model-driven form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms).
   > [!NOTE]
   > You must hide all the elements that are already available on the form.
1. In the form designer, select **Components** from the left navigation, and then select **Customer 360**.
1. Drag and drop it onto the form.
1. On the **Properties** panel, perform the following actions:
    - Select the attributes from the table that must be displayed as fields on the form to the user. You can select up to seven simple and three composite attributes.
    - Specify if the users can edit the fields in the card in the **Enable Editing** drop down. This field is set to **Yes** by default.
    - Save and publish the form.
1. Repeat steps 3 to 6 for the **Contact** table.

 :::image type="content" source="media/powerapps-customer360.png" alt-text="Customer details" lightbox="media/powerapps-customer360.png":::

**2. Add the form controls to the Case form**

1. In the same environment, select **Case** from **Tables**, and then select the **Forms** area.
1. Select the required form.
1. In the form designer, select **Table columns** from the left navigation, clear the **Show only unused table columns** checkbox.
1. Select **Customer**, and then drag and drop it on the form.
1. In the **Properties** section of the **Customer** lookup, perform the following steps:
    1. Select **Components**, and then select **Add Component**.
    1. Select **Form**.
    1. On **Add Form**, select **Related form**. The **Add related form** flyout appears. Specify the following:
         - **Related table**: Account
         - **Related form**: The form with the **Customer 360** component.
    1. Perform the steps above to add the **Contact** table and the new form with the **Customer 360** component.
    1. Save and publish the changes.

 :::image type="content" source="media/powerapps-case-form-control.png" alt-text="Add form controls to case" lightbox="media/powerapps-case-form-control.png":::

## Add the Recent records component

**1. Add the Customer 360 component to Contact and Account forms**

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select the required table, and then select the **Forms** area.
1. Select the required entity.
1. In the form designer, select **Components** from the left navigation, and then select **Recent records**.
1. Drag and drop it onto the form.
1. On the **Properties** panel, perform the following actions:
    - Specify the **Table** from which the records must be displayed.
    - Select the **Default view** and **Default chart**. The views and charts available in the table are displayed.
    - Specify the maximum number of rows the card must display when it loads. The default number of rows displayed is 4.

  :::image type="content" source="media/powerapps-recent-records.png" alt-text="Default minimal resolve case" lightbox="media/powerapps-recent-records.png":::

### See also

[Create, edit, or configure forms using the model-driven form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms)  

[Edit related table records directly from another table’s main form](/power-apps/maker/model-driven-apps/form-component-control)  
