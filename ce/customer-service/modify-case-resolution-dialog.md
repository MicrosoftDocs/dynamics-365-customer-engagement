---
title: "Modify case resolution dialog in Customer Service Hub | MicrosoftDocs"
description: "Learn to customize the case resolution dialog in Customer Service Hub to support varied business needs."
ms.date: 07/16/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
searchScope:
- D365-App-customerservice
- D365-Entity-incident
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Modify the case resolution dialog

As an administrator, you can customize the case resolution dialog so that your organization can cater the case resolution process to suit your business needs. You can modify the case resolution dialog to add fields like **Resolution type** or remove fields like **Billable Time**, if they don't apply to your business scenarios. You can introduce new client-side business validations or remove existing ones. You can also customize the case resolution entity.

> [!Note]
> The option to customize the case resolution dialog is also available in Dynamics 365 Customer Engagement (on-premises) 9.1.
> More information: [New features in Dynamics 365 Customer Engagement (on-premises)](../customerengagement/on-premises/whats-new.md#configurable-case-resolution-page)

## Check permissions

Make sure that the Customer Service Manager and Customer Service Representative security roles have the following permissions set for **Environment Variable Definition**:

- **Customer Service Manager**: Create, Read, and Write
- **Customer Service Representative**: Read

> [!Note]
> If you've created your own security roles, you'll need to update your roles before you can use the modified case resolution dialog.

## Enable customizable dialogs

You must enable the Customizable dialog option to ensure that the changes you make are reflected on the **Resolve case dialog**, when you select the **Resolve case** button.

> [!Note]
> **Standard dialog** is the default option which you can change with the following procedure.

**To enable customizable dialogs**

1. In Customer Service Hub, go to **Service Management**.

2. In the site map under **Service Terms**, select **Service Configuration Settings**.

3. In the **Resolve case dialog** section, select **Customizable dialog** from the dropdown list.

4. Select **Save**. The Customizable dialog option is now enabled, and any changes you make to your form are now displayed at runtime.

## Create and add custom status values

After you enable the Customizable dialog option, you can create status values in your form. Add the custom status values in the following two locations:

- **Case entity** (**statuscode** in our example)
- **Case Resolution entity** (**resolutiontypecode** in our example)

> [!Important]
> If you change the value in the **Case entity**, be sure to update the value in the **Case Resolution entity** so they match. If the values don't match, an error might be thrown. If the values don't match in the customizable dialog, the option that you specified won't show up.

### Update case entity

You can use case resolution to resolve situations where you receive duplicate cases. As an example, let's see how to set the resolution type to display cases with duplicate status.  

**To set the case entity for duplicate cases**

1. In Customer Service Hub, go to **Advanced Settings**, select **Customizations**, and then select **Customize the System**.
   If using [Power Apps](https://make.powerapps.com/), go to **Settings**, and under **Power Apps**, select  **Advanced Settings**, then select **Customizations** and **Customize the System**.

2. In the site map of the page that appears, under **Components**, expand **Entities**, select **Case**, and then select **Fields**.

3. On the page that appears, select the field you want to update. For this example, let's select **statuscode** in the **Name** column.

4. Double-click to select the **statuscode** field. The **General** tab of **Status Reason of Case** is displayed.

5. In the **Status** dropdown list in the **Type** section, select a status. For this example, let's select **Resolved** and then select **Add**.
    The **Add List Value** dialog box is displayed.

6. In the **Label** field, enter **Duplicate** and note down the value listed in the **Value** field.  

7. Select **OK**. You've successfully added a duplicate status to the case entity&mdash;**statuscode**.  

### Update the case resolution entity

After you've added the duplicate status to the case entity, add the same to the case resolution entity.

**To update the case resolution entity for the changed value of the case entity**

1. In the solution explorer under **Components**, expand **Entities**, select **Case Resolution**, and then select **Fields**.

2. On the page that appears, select the field that you want to update. For this example, let's select **resolutiontypecode** in the **Name** column.

3. Double-click to select the **resolutiontypecode** field. The **General** tab of **Resolution Type of Case Resolution** is displayed.

4. In the **Options** section, select the plus sign to automatically populate the **Label** and **Value** fields.

5. In the **Label** field, enter a value name. For this example, enter **Duplicate**.
   Check whether the value listed for this field matches the value in the case entity.  

6. Select **Save and Close**.

## Modify case resolution form
As an example, let's see how to remove the **Billable Time** field from the **Information** form.

1. In the solution explorer under **Components**, expand **Entities**, select **Case Resolution**, and then select **Forms**.

2. Open the form you want to edit. For this example, let's select the **Information** form.
    The form opens in the form designer.

3. In the form designer, do the following:
    1. Select **Billable Time**.

    2. On the command bar, select **Remove** to remove the field.

4. Select **Save**, and then select **Publish**.
    Now, when the customer service reps try to resolve a case, the case resolution dialog won't display the field you removed.

## Check for resolved cases

As an example, let's see how to check if a case has been resolved by using its status reason, like **Duplicate**. 

1. In the solution explorer under **Components**, expand **Entities**, select **Case Resolution**, and then select **Forms**.

2. Open the form you want to edit. For this example, let's select the **Case** form.
    The form opens in the form designer.

3. In the **Resolution Type** dropdown list, select **Duplicate**.
    You'll know if a case has been successfully resolved by checking the status bar at the top of the form.

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
