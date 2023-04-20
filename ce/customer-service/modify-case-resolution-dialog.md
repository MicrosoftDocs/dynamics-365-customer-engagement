---
title: "Modify case resolution dialog in Customer Service Hub | MicrosoftDocs"
description: "Learn to customize the case resolution dialog in Customer Service Hub to support varied business needs."
ms.date: 05/18/2022
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

## Check permissions

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

You can modify the case resolution dialog and remove a field so that it no longer appears at runtime for the user.

As an example, let's see how to remove the **Billable Time** field from the **Information** form.

> [!NOTE]
> Ensure that the **Total Time** field is  added to the case resolution dialog, for the **Billable Time** field to display the amount of time an agent worked on a case automatically. 

1. In the solution explorer under **Components**, expand **Entities**, select **Case Resolution**, and then select **Forms**.

2. Open the form you want to edit. For this example, let's select the **Information** form.
    The form opens in the form designer.

3. In the form designer, do the following actions:
    1. Select **Billable Time**.

    2. On the command bar, select **Remove**.

4. Select **Save**, and then select **Publish**.

When the customer service representatives try to resolve a case, the case resolution dialog won't display the field that you removed.

## Add custom values to the case resolution dialog

Let's understand how to add custom status values to the case resolution dialog with an example. Say, for example, you receive many similar business cases and you want to improve agent productivity and reduce case resolution time. You can add a case resolution rule where any case that's similar to a previously resolved case can be resolved by marking it as a "duplicate case".
 1. Update the Case entity to add a new **Resolved** status type and assign a **Duplicate** custom value to it.
 1. Update the resolution type of the Case Resolution entity with the same custom value to ensure that all duplicate cases are assigned the same resolution type.

> [!Important]
> If you change the value in **Case entity**, be sure to update the value in **Case Resolution entity** so they match. If the values don't match, an error might occur. If the values don't match in the customizable dialog, the values that you specified won't be displayed.

### Update the case entity

1. In Dynamics 365, go to **Advanced Settings**, select **Customizations**, and then select **Customize the System**.
   
   If using [Power Apps](https://make.powerapps.com/), go to **Settings**, and under **Power Apps**, select  **Advanced Settings**, then select **Customizations** and **Customize the System**.

2. In the site map of the page that appears, under **Components**, expand **Entities**, select **Case**, and then select **Fields**.

3. On the page that appears, select the field you want to update. For this example, let's select **statuscode** in the **Name** column.

4. Double-click to select the **statuscode** field. The **General** tab of **Status Reason of Case** is displayed.

5. In the **Status** dropdown list in the **Type** section, select a status. For this example, let's select **Resolved** and then select **Add**.
   The **Add List Value** dialog is displayed.

6. In the **Label** field, enter **Duplicate** and note down the value listed in the **Value** field. 

8. Select **OK**.

9. If you've preconfigured status reason transitions, select **Edit Status Reason Transitions** to set up new status reasons.
For more information, see: [Define status reason transitions](/power-apps/maker/data-platform/define-status-reason-transitions).

1.  Select **Save and Close**. You've successfully added a custom status type and status value to the case entity.  

### Update the case resolution entity

1. In the solution explorer under **Components**, expand **Entities**, select **Case Resolution**, and then select **Fields**.

2. On the page that appears, select the field that you want to update. For this example, let's select **resolutiontypecode** in the **Name** column.

3. Double-click to select the **resolutiontypecode** field. The **General** tab of **Resolution Type of Case Resolution** is displayed.

4. In the **Options** section, select the plus sign to add a new item to the **Label** and **Value** fields.

5. In the **Label** field, enter a value name; **Duplicate** in our example. In the **Value** field, enter the corresponding value you noted earlier in the case entity **statuscode** field.

6. Select **Save and Close**.

Continuing with the same example, let's now see how to use the **Duplicate** custom status value in case resolution, so that duplicate cases are automatically marked as resolved.

### Automatically resolve duplicate cases

Now, let's see how to use the **Duplicate** custom status value in case resolution, so that duplicate cases are automatically marked as resolved.

1. In Customer Service workspace, open a case that you recognize as similar or duplicate of a previously resolved case. The **Summary** page with the case details opens. If you're using Customer Service Hub, in the site map, go to **Service**, select **Cases**, and select a case.

2. To resolve the case, select **Resolve Case** on the command bar.

3. In the **New Case Resolution** dialog that opens, do the following:
   1. In the **Resolution Type** dropdown list, select **Duplicate**.
   2. In the **Resolution** field, add case resolution notes.

4. Select **Save and Close**.

The case is automatically marked as resolved and you'll see the resolved status for the case displayed on top of the case title.

### See also

[Work with cases](customer-service-hub-user-guide-create-a-case.md)  
[Create a case](customer-service-hub-user-guide-create-a-case.md)  
[Merge cases](customer-service-hub-user-guide-merge-cases.md)  
[Resolve, cancel, and reassign cases](customer-service-hub-user-guide-resolve-cancel-reassign-a-case.md)  
[Create and manage parent and child cases](customer-service-hub-user-guide-create-and-manage-parent-and-child-cases.md)  
[Case queues and routing](customer-service-hub-user-guide-case-queues-and-routing.md)  
[Convert case to knowledge article](customer-service-hub-user-guide-convert-case-to-knowledge-article.md)  
[Case SLAs](customer-service-hub-user-guide-case-sla.md)  
[Learn the basics of the Customer Service Hub](customer-service-hub-user-guide-basics.md)  
[Use the main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
