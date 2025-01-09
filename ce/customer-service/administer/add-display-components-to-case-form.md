---
title: Configure components to display customer details and recent records | MicrosoftDocs 
description: Learn about adding the Associated grid control component to forms
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 05/14/2024
ms.custom: bap-template 
---

# Configure components to display customer details and recent records

Use the **Customer 360** and **Recent records** components to display the customer details and related records for a case.

## Add the Customer 360 component to a case form

After you add the **Customer 360** control to a case form, when a customer service representative (service representative or representative) selects a customer in the Customer field, the customer details are displayed as follows:
 
 :::image type="content" source="../media/customer360-control.png" alt-text="sample image of the customized card" lightbox="../media/customer360-control.png":::

 Do the following tasks to add the control. You can use these steps to display customer records on any entity where the Customer lookup is available.

Step 1: Add the **Customer 360** component to forms in the **Account** and **Contact** tables. By default, the component is available in the **Account form for Customer card** and **Contact form for Customer card** forms. <br>
Step 2: On the **Case** form, add the **Account** and **Contact** forms on which the component was added. More information: [Edit related table records directly from another table’s main form](/power-apps/maker/model-driven-apps/form-component-control).

You can add the **Customer 360** card to a custom form in Customer Service workspace and Omnichannel for Customer Service. Perform the steps in [View the customer details in an app side pane on a custom form](#view-the-customer-details-in-an-app-side-pane-on-a-custom-form) section to add the Customer 360 card to a customized form. 

### Step 1: Add the Customer 360 component to Contact and Account forms

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
    - Set the **Enable Rich Text Editor for Multiline Text Fields** to **Yes** for the rich text editor control to be enabled for multi-line text columns. 
    > [!NOTE]
    > If the multi-line text field is defined as rich-text on other forms, you can enable the rich text editor for this field on Customer 360 component. If you don't enable this, users might see html tags in the field if the field has formatted content.

    - If you'd like to add advanced configuration for the rich text editor control, specify the **Custom Rich Text Editor Configuration URL**. More information: [Create and use advanced configuration for the rich text editor control](/power-apps/maker/model-driven-apps/rich-text-editor-control#create-and-use-advanced-configuration-for-the-rich-text-editor-control)
    
      :::image type="content" source="../media/powerapps-360-static-mini.png" alt-text="Static value and header" lightbox="../media/powerapps-360-static-mini.png":::
      
    - Save and publish the form.
1. Repeat steps 3 to 6 for the **Contact** table.

   :::image type="content" source="../media/powerapps-customer360.png" alt-text="Customer details" lightbox="../media/powerapps-customer360.png":::

### Step 2: Add the Customer or Account form with the Customer 360 component to the Case form

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

### View the customer details in an app side pane on a custom form 

Perform the following steps to view the customer details in an app side pane, when the representative changes the customer or account name.

1. In Power Apps, you must add the event handler function for the On Change event of the **Customer** or **Account**. More information: [Add or remove event handler function to event using UI](/power-apps/developer/model-driven-apps/clientapi/events-forms-grids?tabs=add-event-handlers-unified-interface#add-or-remove-event-handler-function-to-event-using-ui). 
1. Specify the following details in **Configure Event**:
    1. **Event Type**: **On Change**
    1. **Library**: **ModernCaseManagement/Incident/msdyn_ModernCaseManagement**. If this value isn't available in the Library dropdown, select **Add Library** and add the option.
    1. **Function**: **ModernCaseManagement.ModernCaseManagementLibrary.onCustomerChange**
    1. Select **Enabled** and **Pass execution context as first parameter**.
1. Save and publish the changes.

#### Display customer details when an existing record is opened

If representatives should see the customer details in an app side pane when they open an existing record with the customer or account name populated, add the following function to your customer script for the On Load event: `ModernCaseManagement.ModernCaseManagementLibrary.onCustomerChange(executionContext);`.

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

     :::image type="content" source="../media/powerapps-recent-records.png" alt-text="Default minimal resolve case" lightbox="../media/powerapps-recent-records.png":::
1. Save and publish the changes.
 
 The Recent records control displays the related records as follows, if you select **Case** in the **Table** field.

   :::image type="content" source="../media/recent-record-control.png" alt-text="sample image of the recent cases card":::

### Related information

[Create, edit, or configure forms using the model-driven form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms)  

[Edit related table records directly from another table’s main form](/power-apps/maker/model-driven-apps/form-component-control)  
