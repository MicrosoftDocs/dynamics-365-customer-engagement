---
title: "Modify case resolution dialog box in Customer Service Hub | MicrosoftDocs"
description: "Learn to customize the case resolution dialog box to expand the case resolution entity to support varied business needs."
ms.date: 06/30/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Modify case resolution dialog box

As an administrator, you can customize the case resolution form to edit the dialog box and support case resolution entities. By customizing the case resolution dialog box, you can help managers identify recurring issues and proven resolution patterns to inform other incident responses. 
You can customize the dialog box to add fields such as resolution type or other fields to suit your business needs. You can introduce new client-side business validations or remove existing ones. You can also customize the case resolution entity.

> [!Note]
> The option to customize the case resolution dialog box is also available in Dynamics 365 Customer Engagement (on-premises) 9.1. 
> More information: [New features in Dynamics 365 Customer Engagement (on-premises)](../customerengagement/on-premises/whats-new.md#configurable-case-resolution-page)

<!--
Use the following steps to get started:

- **Step 1:** Set permissions (required)
- **Step 2:** Enable customizable dialog (required)
- **Step 3:** Create status values
  - Case entity (status code)
  - Case Resolution entity (resolution type code)
- **Step 4:** Edit form
-->
## Prerequisites

If you've created your own security roles, you'll need to update your roles before you can use the modified case resolution dialog.

Make sure that the Customer Service Manager security role has the following permissions:
- **Environment Variable Definition**: Read
- **Environment Variable Value**: Create, Read, and Write

## Enable customizable dialog

You must enable the Customizable dialog option to be able to make changes to your form. **Standard dialog** is the default option.

To enable customizable dialog:  

1. In Customer Service Hub, go to **Service Management**.

2. In the site map, under **Service Terms**, select **Service Management**.

3. On the Service Configuration Settings page that appears, go to the **Resolve case dialog** option, and select **Customizable dialog** from the dropdown list.

4. Select **Save**.
   The Customizable dialog option is now enabled, and any changes you make to your form are now displayed at runtime. 


## Status values

After you enable customizable dialog, you can create status values in your form. You should add the custom status values in the following two locations. Also, if you change the value in the **Case entity**, you must update the value in the **Case Resolution entity** so they match.

- **Case entity** (**statuscode** in our example)
- **Case Resolution entity** (**resolution statuscode** in our example)


<!-- content appears redundant
## Customize Case entity and Case Resolution entity

To go to the **Customization** page:

1. On the navigation bar, select the **Settings** icon.

   > [!div class=mx-imgBorder]
   > ![Status Values - select Settings](media/status-values-step-1.PNG "Status Values - select Settings")


2. In the Power Platform admin center **Settings** page, select **All legacy settings**.
    

   > [!div class=mx-imgBorder]
   > ![Status Values - select All legacy settings](media/status-values-step-2.PNG "Status Values - select All legacy settings")

3. Select **Customize the System**.
    
   > [!div class=mx-imgBorder]
   > ![Status Values - Customize the System](media/status-values-step-3.PNG "Status Values - Customize the System")

-->
### Case entity

You can use case resolution to resolve situations where you receive duplicate cases. As an example, let's see how to set the resolution type to display cases that have the duplicate status.  

To set the case entity for duplicate case:

1. In Customer Service Hub, go to **Advanced Settings**, select **Customizations**, and then select **Customize the System**.

2. On the site map of the page that appears, under **Components**, expand **Entities**, select **Case**, and then select **Fields**.

3. On the page that appears, select the field you want to update. For this example, let's select **statuscode** in the **Name** column.

4. Double-click the **statuscode** field. The **General** tab of **Status Reason of Case** is displayed.

5. In the **Status** dropdown list in the **Type** section, select a status. For this example, let's select **Resolved** and then select **Add**.
   The **Add List Value** dialog box is displayed. 

6. In the **Label** field, enter **Duplicate** and select **OK**.

You've successfully added a duplicate status to the case entity&mdash;statuscode.  

### Case resolution entity

After you've added the duplicate status to the case entity, you must add the same to the case resolution entity.

To update the case resolution entity for the changed value of case entity:

1. In the Solution Explorer, under **Components**, expand **Entities**, select **Case Resolution**, and then select **Fields**.

2. On the page that appears, select the field you want to update. For this example, let's select **resolutiontypecode** in the **Name** column.

3. Double-click the **resolutiontypecode** field. The **General** tab of **Resolution Type of Case Resolution** is displayed.

<!--
  > [!div class=mx-imgBorder]
  > ![Open Resolution Type Code field of Case Resolution entity](media/enable-customizable-dialog-1.png "Open Resolution Type Code field of Case Resolution entity")
  -->
4. In the **Options** section, select the plus icon to automatically populate the **Label** and **Value** fields.

5. In the **Label** field, enter a value name. For this example, enter **Duplicate**.

6. In the **Value** field, confirm that the variable listed matches the value in the case entity.  

7. Select **Save and Close**.
<!--
  > [!div class=mx-imgBorder]
  > ![Add values to Resolution Type field](media/enable-customizable-dialog-2.png "Add values to Resolution Type field")
-->
Now, the Case Resolution entity appears in the dialog box as an option that you can select. 

## Edit forms

The case resolution form lets you add or remove fields based on your business needs. For example, your business model may not require a **Billable Time** field because your case resolutions do not track billable hours, and so you can choose to remove the corresponding field from the form.  

As an example, to remove the **Billable Time** field from the form:

1. In the **Solution Explorer**, under **Components**, expand **Entities**, select **Case Resolution**, and then select **Forms**.

  > [!div class=mx-imgBorder]
  > ![Select Forms](media/case_resolution_8.png "Select Forms")

2. Open the form you want to edit. For this example, let's select the **Information** form.

  > [!div class=mx-imgBorder]
  > ![Select the name of the form you want to edit](media/case_resolution_9.png "Select the name of the form you want to edit")

    The form opens in the form designer.

3. On the form designer, do the following: 
    1. Select **Billable Time**.

    2. On the command bar, select **Remove**. The **Billable Time** field is removed.

    > [!div class=mx-imgBorder]
    > ![Billable Time field](media/case_resolution_10.png "Billable Time field")

4. Select **Save** and then select **Publish**.

  > [!div class=mx-imgBorder]
  > ![Save and publish](media/case_resolution_13a.PNG "Save and publish")

Now, when the customer service reps try to resolve a case, the case resolution dialog box does not display the removed field.

5. In the **Resolution Type** dropdown list, select **Duplicate**.

  > [!div class=mx-imgBorder]
  > ![Resolution Type field on the Case Resolution dialog box](media/case_resolution_14a.PNG "Resolution Type field on the Case Resolution dialog box")

You'll know if a case has been successfully resolved per the status bar at the top of the form.

  > [!div class=mx-imgBorder]
  > ![Status bar](media/case_resolution_15.png "Status bar")

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
