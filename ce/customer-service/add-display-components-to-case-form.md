---
title: Configure components to display customer details and recent records | MicrosoftDocs 
description: Learn about adding the Associated grid control component to forms
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 02/03/2023 
ms.custom: bap-template 
---

# Configure components to display customer details and recent records

Use the **Customer 360** and **Recent records** components to display the customer details and related records for a case.

## Add the Customer 360 component to a case form

After you add the **Customer 360** control to a case form, when an agent selects a customer in the Customer field, the customer details are displayed as follows:
 
 :::image type="content" source="media/customer360-control.png" alt-text="sample image of the customized card" lightbox="media/customer360-control.png":::

 Do the following tasks to add the control. You can use these steps to display customer records on any entity where the Customer lookup is available.

1. Add the **Customer 360** component to forms in the **Account** and **Contact** tables.
2. On the **Case** form, add the **Account** and **Contact** forms on which the component was added. More information: [Edit related table records directly from another table’s main form](/power-apps/maker/model-driven-apps/form-component-control)

### Add the Customer 360 component to Contact and Account forms

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1.  Select **Tables**, select **Account**, and then select the **Forms** area.
1. Create a new form or use an existing form. More information: [Create, edit, or configure forms using the model-driven form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms).
   > [!NOTE]
   > You must hide all the elements that are already available on the form.
1. In the form designer, select **Components** from the left navigation, and then select **Customer 360**.
1. Drag it to the form.
1. On the **Properties** panel, do the following actions:
    - Select the attributes from the table that must be displayed as fields on the form to the user. You can select up to seven simple and three composite attributes.
    - Specify if the users can edit the fields in the card in the **Enable Editing** drop down. This field is set to **Yes** by default.
    - The control header displays the contact name or account name when a contact or account is selected from the customer lookup on the form. If you want the control header to display a static header, specify **Static Value** and set **Show Static Header** to **Yes**. 
    
      :::image type="content" source="media/powerapps-360-static-mini.png" alt-text="Static value and header" lightbox="media/powerapps-360-static-mini.png":::
      
    - Save and publish the form.
1. Repeat steps 3 to 6 for the **Contact** table.

   :::image type="content" source="media/powerapps-customer360.png" alt-text="Customer details" lightbox="media/powerapps-customer360.png":::

### Add the form controls to the Case form

1. In the same environment, select **Case** from **Tables**, and then select the **Forms** area.
1. Select the required form.
1. In the form designer, select **Table columns** from the left navigation, clear the **Show only unused table columns** checkbox.
1. Select **Customer**, and then drag it on the form.
1. In the **Properties** section of the **Customer** lookup, do the following:
    1. Select **Components**, and then select **Add Component**.
    1. Select **Form**.
    1. On **Add Form**, select **Related form**. The **Add related form** flyout appears. Specify the following:
         - **Related table**: Account
         - **Related form**: The form with the **Customer 360** component.
    1. Do the steps above to add the **Contact** table and the new form with the **Customer 360** component.
    1. Save and publish the changes.

## Add the Recent records component

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select the required table, and then select the **Forms** area.
1. Select the required entity.
1. In the form designer, select **Components** from the left navigation, and then select **Recent records**.
1. Drag it onto the form.
1. On the **Properties** panel, do the following:
    - Specify the **Table** from which the records must be displayed.
    - Select the **Default view** and **Default chart**. The views and charts available in the table are displayed.
    - Specify the maximum number of rows the card must display when it loads. The default number of rows displayed is four.

     :::image type="content" source="media/powerapps-recent-records.png" alt-text="Default minimal resolve case" lightbox="media/powerapps-recent-records.png":::
1. Save and publish the changes.
 
 The Recent records control displays the related records as follows, if you select **Case** in the **Table** field.

   :::image type="content" source="media/recent-record-control.png" alt-text="sample image of the recent cases card" lightbox="media/recent-record-control.png":::

### See also

[Create, edit, or configure forms using the model-driven form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms)  

[Edit related table records directly from another table’s main form](/power-apps/maker/model-driven-apps/form-component-control)  
