---
title: "Modify case resolution dialog in Customer Service Hub | MicrosoftDocs"
description: "Learn to customize the case resolution dialog in Customer Service Hub to support varied business needs."
ms.date: 06/12/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
searchScope: 
  - D365-App-customerservicehub
  - D365-Entity-incident
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Customer Service
---

# Modify the case resolution dialog

You can customize the case resolution dialog to suit your business needs. You can modify the dialog to add fields like **Resolution type** or remove fields like **Billable Time**, if they don't apply to your business scenarios. You can also create case resolution rules by adding custom status values.
The following sections discuss the permissions you'll need to modify the case resolution dialog and how to enable the option to customize dialogs in Customer Service Hub. You'll also learn to customize the case resolution dialog and add custom case resolution rules using examples.

> [!Note]
> The option to customize the case resolution dialog is also available in Dynamics 365 Customer Engagement (on-premises) 9.1.
> More information: [New features in Dynamics 365 Customer Engagement (on-premises)](/dynamics365/customerengagement/on-premises/whats-new#configurable-case-resolution-page)

## Prerequisites

Make sure that the CSR Manager and Customer Service Representative security roles have the following permissions set for **Environment Variable Definition**:

- **Customer Service Manager**: Create, Read, and Write
- **Customer Service Representative**: Read

If you've created custom security roles, you'll need to update the roles to use the modified case resolution dialog.

## Customize dialogs

By default, the style of the **Resolve case** dialog is set to standard dialog. You can, however, change the style to **Customizable dialog** so that you can add custom fields and values.

**To enable the Customizable dialog option**

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    
    1. In the site map, select **Case Settings** in **Customer Support**. The **Case Settings** page appears.
     
    1. Select **Manage** for **Other Settings**.

   ### [Customer Service Hub](#tab/customerservicehub)
   
     - In the **Service Management** site map, select **Service Configuration Settings** in **Service Terms**.

1. On the **Service Configuration Settings** page, scroll to the **Resolve case dialog** section, and then select **Customizable dialog** from the dropdown list.

1. Select **Save**.

## Add or remove fields from the case resolution dialog

You can modify the case resolution dialog to add and remove a field.

As an example, let's see how to add the **Billable Time** field.

> [!NOTE]
> - Ensure that the **Total Time** field is  added to the case resolution dialog, for the **Billable Time** field to display the amount of time an agent worked on a case automatically. 
> - Case resolution isn't supported if **Regarding** is added to **Case resolution dialog**.

1. In [Power Apps](https://make.powerapps.com/), select your environment.
1. Select **Tables**> **Forms** > **Case Resolution**.
1. [Add the **Billable Time**](/power-apps/maker/model-driven-apps/add-move-or-delete-fields-on-form#add-columns-to-a-form) field to the form.
1. Select **Save and publish**

To remove the field, perform the steps in the [delete columns on a form](add-move-or-delete-fields-on-form#delete-columns-on-a-form).

When the customer service representatives try to resolve a case, the case resolution dialog won't display the field that you've removed.

## Add custom values to the case resolution dialog

You can add a custom value to the case resolution dialog. For example, you can add a custom value to the **Resolution Type** field to mark a case as a duplicate. You must perform the following steps to add a custom value to the case resolution dialog:

 1. Update the Case table to add a custom value to the table column.
 1. Update the the Case Resolution table with the same custom value.

> [!Important] 
> If you change the value in **Case**, be sure to update the value in **Case Resolution** so they match. If the values don't match, an error might occur. If the values don't match in the customizable dialog, the values that you specified won't be displayed.

### Update the case table

1. In [Power Apps](https://make.powerapps.com/), select your environment.
1. Select **Tables**> **Forms** > **Case**.
1. In **Table Columns**, select the required column. For example, select **Status Reason**.
1. On the **Properties** pane for **Status Reason**, select **Edit table column**.
1. For the required status add a new choice. For this example, let's select **Resolved** and then specify **Duplicate** in the choice. Copy the value in the **Value** field. 
1. Select **Save** and then publish the changes.

### Update the case resolution table

1. In [Power Apps](https://make.powerapps.com/), select your environment.
1. Select **Tables**> **Forms** > **Case Resolution**.
1. In **Table Columns**, select the required column. For example, select **Resolution Type**.
1. On the **Properties** pane for **Resolution Type**, select **Edit table column**.
1. In **Choices** add a new choice. In this example, let's specify **Duplicate** as the label and paste the copied value from the section above to the **Value** field. 
1. Select **Save** and then publish the changes.

For the example in the sections above, when the customer service representatives try to resolve a case, the case resolution dialog displays the **Duplicate** value in the **Resolution Type** field and the case is then marked as a duplicate.

### See also

[Work with cases](../use/customer-service-hub-user-guide-create-a-case.md)  
[Create a case](../use/customer-service-hub-user-guide-create-a-case.md)  
[Merge cases](../use/customer-service-hub-user-guide-merge-cases.md)  
[Resolve, cancel, and reassign cases](../use/customer-service-hub-user-guide-resolve-cancel-reassign-a-case.md)  
[Create and manage parent and child cases](../use/customer-service-hub-user-guide-create-and-manage-parent-and-child-cases.md)  
[Case queues and routing](../use/customer-service-hub-user-guide-case-queues-and-routing.md)  
[Convert case to knowledge article](../use/customer-service-hub-user-guide-convert-case-to-knowledge-article.md)  
[Case SLAs](../use/customer-service-hub-user-guide-case-sla.md)  
[Learn the basics of the Customer Service Hub](../implement/customer-service-hub-user-guide-basics.md)  
[Use the main form and its components](../../customerengagement/on-premises/customize/use-main-form-and-components.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
