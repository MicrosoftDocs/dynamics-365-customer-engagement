---
title: Customize the case resolution dialog
description: Add custom fields and values to the case resolution dialog to improve case management and organization.
ms.date: 06/21/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
searchScope:
  - D365-App-customerservicehub
  - D365-Entity-incident
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Customer Service
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:12/20/2023
  - ai-gen-desc
---

# Modify the case resolution dialog

You can customize the case resolution dialog to suit your business needs. You can also create case resolution rules by adding custom status values.

## Prerequisites

Make sure that the CSR Manager and customer service representative (service representative or representative) security roles have the following permissions set for **Environment Variable Definition**:

- **CSR Manager**: Create, Read, and Write
- **Customer Service Representative**: Read

If you have custom security roles, you must update the roles to use the modified case resolution dialog.

## Manage case resolution dialog settings

You can set the case resolution dialog that customer service representatives see when they resolve the case. By default, the field is set to **Standard dialog**. Perform the following steps to set the resolve case dialog to a customizable case resolution dialog. This enables you to modify the case resolution dialog to add or remove fields and values.

1. In the site map of Customer Service admin center, select **Case Settings** in **Customer Support**. The **Case Settings** page appears.
     
1. Select **Manage** for **Other Settings**.

1. On the **Service Configuration Settings** page, scroll to the **Resolve case dialog** section, and then select **Customizable dialog** from the dropdown list.

1. Select **Save**.

## Add or remove fields from the custom case resolution dialog

You can modify the custom case resolution dialog to add and remove a field.

For example, you must add the **Billable Time** field to the case resolution dialog.

> [!NOTE]
> - Ensure that the **Total Time** field is  added to the case resolution dialog, for the **Billable Time** field to display the amount of time a representative worked on a case automatically. 
> - Case resolution isn't supported if **Regarding** field is added to **Case resolution dialog**.

1. In [Power Apps](https://make.powerapps.com/), select your environment.
1. Select **Tables** > **Case Resolution** > **Forms** and select the required form.
1. [Add the **Billable Time**](/power-apps/maker/model-driven-apps/add-move-or-delete-fields-on-form#add-columns-to-a-form) field to the form.
1. Select **Save and publish**.

   :::image type="content" source="../media/case-enh-resolution-mini.png" alt-text="Screenshot displaying the customized case resolution dialog" lightbox="../media/case-enh-resolution.png":::


To remove the **Billable Time** field, perform the steps in the [delete columns on a form](/power-apps/maker/model-driven-apps/add-move-or-delete-fields-on-form#delete-columns-on-a-form).

## Add custom values to the custom case resolution dialog

You can add a custom value to the custom case resolution dialog. You must perform the following steps to add a custom value to the case resolution dialog:

 1. Add a custom value to the required field in the **Case** table.
 1. Update the required field in the **Case Resolution** table with the same custom value.

For example, your organization receives similar cases. You can add a case resolution rule for cases that are similar to a previously resolved case. Representatives can then resolve them by marking them as duplicate cases. To add a case resolution rule, perform the steps in the following sections.

### Update the case table

1. In [Power Apps](https://make.powerapps.com/), select your environment.
1. Select **Tables** > **Case** > **Columns** and then select the required column. For our example, select **Status Reason**.
1. Select **Edit**.
1. On the **Edit column** pane for **Status Reason**, select the required status and then add a new choice. For this example, you can select **Resolved** and then specify **Duplicate** in the choice. Copy the value in the **Value** field. 
1. Select **Save** and then publish the changes.

   :::image type="content" source="../media/powerapps-case-add-value.png" alt-text="Screenshot displaying the case status column":::

### Update the case resolution table

1. In [Power Apps](https://make.powerapps.com/), select your environment.
1. Select **Tables** > **Case Resolution** > **Columns** and then select the required column. For example, select **Resolution Type**.
1. Select **Edit**.
1. On the **Edit column** pane for **Resolution Type**, in **Choices** add a new choice. In this example, you can specify **Duplicate** as the label and paste the copied value from the update the case table section to the **Value** field. 
1. Select **Save** and then publish the changes.

   :::image type="content" source="../media/powerapps-case-resol-add-value.png" alt-text="Screenshot displaying the resolution type column":::

> [!Important] 
> If you change the value in **Case**, be sure to update the value in **Case Resolution** so they match. If the values don't match, an error might occur. If the values don't match in the customizable dialog, the values that you've specified won't be displayed.

In our example, once you've added the custom value, representatives see the **Duplicate** option in the **Resolution Type** dropdown of the **New Case Resolution** dialog when they [resolve a case](../use/customer-service-hub-user-guide-resolve-cancel-reassign-a-case.md#resolve-a-case). Representatives can select this value and mark the case as a duplicate.


   :::image type="content" source="../media/case-enh-duplicate.png" alt-text="Screenshot displaying the duplicate custom value":::

### Related information

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
