---
title: "Troubleshooting guide for administrators for Dynamics 365 Sales | MicrosoftDocs"
description: "Follow the instructions in this topic to troubleshoot the issues your users may face while working on Dynamics 365 Sales."
ms.date: 10/01/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Dynamics 365 Sales troubleshooting guide for administrators

Use the following list of troubleshooting topics to quickly find information to solve your users' issues.

## Lead qualification issues and resolution

### Insufficient permissions or Access denied error when a user is trying to qualify a lead

How you resolve this error depends on the following ownership scenarios for the lead records. 
-  [The lead is owned by the user trying to qualify it](troubleshooting-admin.md#OwnedByUser)
-  [The lead that the user is trying to qualify is in their business unit](troubleshooting-admin.md#BusinessUnit)
-  [The lead that the user is trying to qualify is in their organization](troubleshooting-admin.md#Organization)

<a name="OwnedByUser"> </a>
**Scenario:** 
The lead is owned by the user trying to qualify it.

**Resolution:** 
1.	Go to **Settings** > **Security Role**.
2.	Open the security role of the user.
3.	On the **Core Records** tab, assign **Create**, **Read**, **Append**, and **Append To** permissions to the Security Role at User level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 

    ![Security role with access at User level](media/security-role-sales-person.png "Security role with access at User level")

4.	On the **Custom Entities** tab, assign Read access to any custom entity.
5.	On the **Customizations** tab, assign **Read** access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**.

<a name="BusinessUnit"> </a>
**Scenario:**
The lead that the user is trying to qualify is in their business unit.

**Resolution:**
1.	Go to **Settings** > **Security Role**.
2.	Open the security role of the user.
3.	Assign **Create**, **Read**, **Append**, and **Append To** permissions to the user’s Security Role at Business Unit level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 

    ![Security role with access at Business Unit level](media/security-role-sales-person-bu-access.png "Security role with access at Business Unit level")

4.	Assign **Read** access to any custom entity.
5.	Assign **Read** access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**

<a name="Organization"> </a>
**Scenario:**
The lead that the user is trying to qualify is in their organization.

**Resolution:**
1.	Go to **Settings** > **Security Role**.
2.	Open the security role of the user.
3.	Assign **Create**, **Read**, **Append**, and **Append To** permissions to the user’s Security Role at Organization level on the following entities:
    -  Account 
    -  Lead
    -  Contact
    -  Opportunity 
 
    ![Security role with access at Organization level](media/security-role-sales-person-org-access.png "Security role with access at Organization level")

4.	Assign Read access to any custom entity.
5.	Assign Read access to **Attribute Map**, **Customizations**, **Entity** and **Entity Map**.

## Opportunity Close issues and resolution

### Insufficient permissions or Access denied error when a user is trying to close an opportunity

**Reason:**
The user trying to close the opportunity doesn’t have sufficient permissions on the opportunity they’re working on.

**Resolution:**
1.	Go to **Settings** > **Security Role**.
2.	Open the security role of the user.
3.	Assign **Read**, **Create**, **Append**, **Append To** permissions to the user’s Security Role at User level on the Opportunity entity and custom entity.


## Error or unexpected behavior while working on entities 

While working on entities (such as opportunities, quote, order, invoice, quote product, and order product), you observe unexpected behavior or an error in [!INCLUDE[pn_sales_business_doc_name](../includes/pn-sales-business-doc-name.md)]. The following are some of the errors that you might encounter while working on opportunities and this might be same for other entities:

- "Extended Amount is wrong after revising quote"- this error might have occurred due to Custom Plugin.
- "Error while saving the opportunity" - this error might have occurred due to Custom JavaScript.
- "Error while close opportunity" - this error might have occurred due to Custom Workflow.

These issues might occur due to improper customization of the application. You must verify these customization and resolve them. Perform the following verification methods to identify which customization is causing the issue and then resolve:

- [Deactivate custom plug-in](#deactivate-custom-plug-in)
- [Disable custom JavaScript](#disable-custom-javascript)
- [Deactivate custom workflow process](#deactivate-custom-process)

### Deactivate custom plug-in

1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select **Sdk Message Processing Steps**. 

   A list of available Sdk message processing steps is displayed.
3. Select the **Filter** icon, select the column **Primary Object Type Code (Sdk Message Filter)**, and then select the entity for which the error is occurring.
    
    > [!div class="mx-imgBorder"]
    > ![Go to custom plug-in list](media/troubleshooting-goto-custom-plugin-list.png "Go to custom plug-in list")

4. Select the **SDK Message Processing Steps** that are coming from the solutions owned by you. 

    > [!NOTE]
    > To view your custom SDK Message Processing Steps:<br>
    > a. Go to **Settings** > **Solutions** and then open the solution. <br>
    > b. Select **SDKMessage Processing Steps**. Verify the values are selected as:  **Component Type** to **SDK Message Processing Step** and **View** to **All**.

5. Select **Deactivate**.
6. Publish the customizations.
 
    > [!div class="mx-imgBorder"]
    > ![Choose and deactivate unmanaged custom plug-ins](media/troubleshooting-deactivate-unmanaged-custom-plugin.png "Choose and deactivate unmanaged custom plug-ins")

7. Verify the issue and if it doesn't occur, then the issue is with the custom SDK Message Processing Steps. Resolve the issue.

> [!NOTE]
> If the issue occurs, activate the **SDK Message Processing Steps** that you deactivated now and try to [Disable custom JavaScript](#disable-custom-javascript) or [Deactivate custom workflow process](#deactivate-custom-process).

### Disable custom JavaScript

1. Open the form editor of the entity in which the error is occurring. In this example, we are selecting the entity as Opportunities and the default solution form.

    > [!div class="mx-imgBorder"]
    > ![Open form editor](media/troubleshooting-javascript-form-editor.png "Open form editor")

2. Select **Form Properties** on the form editor.

    > [!div class="mx-imgBorder"]
    > ![Edit form page](media/troubleshooting-javascript-form-editor-edit-properties.png "Edit form page")

    The **Form Properties** dialog opens.

3. On the **Events** tab, select the control **OnLoad** from the **Events** drop-down list. 

   > [!div class="mx-imgBorder"]
   > ![Event control selection](media/troubleshooting-javascript-form-properties-event-control-selection.png "Event control selection")

4. Choose the custom **JavaScript** files that are coming from the solution owned by you.

   > [!NOTE]
   > To view your custom JavaScript: <br>
   > a. Go to **Settings** > **Solutions** and then open the solution. <br>
   > b. Select **WebResources**. Verify the values are selected as:  **Component Type** to **WebResources** and **View** to **All**.<br>
   > c. Select **Filter** icon to enable filter options for columns. Select **Type** and set the filter as **Script (JScript)**.<br>
   >> [!div class="mx-imgBorder"]
   >> ![Select type filter as script](media/troubleshooting-javascript-view-javascript-filter.png "Select type filter as script")

5. Select **Edit**. In this example, we have selected the custom JavaScript file **eg_opportunity** to edit.
   
    > [!div class="mx-imgBorder"]
    > ![Handler properties dialog](media/troubleshooting-javascript-handler-properties-dialog.png "Handler properties dialog") 

6. Clear the **Enabled** option and select **OK**.
 
    > [!div class="mx-imgBorder"]
    > ![Clear enabled option](media/troubleshooting-javascript-handler-properties-uncheck-enabled.png "Clear enabled option") 
 
7. Publish the customizations.

8. Verify the issue and if it doesn't occur, then the issue is with the custom JavaScript. Resolve the issue.

> [!NOTE]
> If the issue occurs, enable the JavaScripts that you disabled now and try to [Deactivate custom plug-in](#deactivate-custom-plug-in) or [Deactivate custom workflow process](#deactivate-custom-process).

### Deactivate custom process

1. Go to **Settings** > **Customizations** > **Customize the System**.
1. Select **Processes**. These process include Workflow, Business Process Flow, and Business Rule.
   A list of available processes is displayed.
3. Select the **Filter** icon, select the column **Primary Entity**, and then select the entity for which the error is occurring.
    
    > [!div class="mx-imgBorder"]
    > ![Go to custom process workflow list](media/troubleshooting-goto-custom-process-workflow-list.png "Go to custom process workflow list")

4. Choose the processes that are coming from the solutions owned by you.

    > [!NOTE]
    > To view your custom Processes:<br>
    > a. Go to **Settings** > **Solutions** and then open the solution.<br> 
    > b. Select **Processes**. Verify the values are selected as:  **Component Type** to **Processes** and **View** to **All**.

5. Select **Deactivate**.
6. Publish the customizations.
 
    > [!div class="mx-imgBorder"]
    > ![Choose and deactivate unmanaged process workflows](media/troubleshooting-goto-deactivate-unmanaged-custom-process-workflow.png "Choose and deactivate unmanaged custom process workflows") 

7. Verify the issue and if it doesn't occur, then the issue is with the custom processes. Resolve the issue.

> [!NOTE]
> If the issue occurs, activate the **Processes** that you deactivated now and try to [Deactivate custom plug-in](#deactivate-custom-plug-in) or [Disable custom JavaScript](#disable-custom-javascript).

## Unable to see data in certain columns in entity views

**Reason:**
This error is occurring due to mismatch of column names between the `layoutxml` and `fetchxml` in the view ODATA file (*OrgUrl*/api/data/*Dynamics 365 version*/savedqueries(*ViewId*)). 

**Resolution:**
To resolve this issue, you must remove and add back the column that is causing this error. This will ensure that the column names in `layoutxml` and `fetchxml` are matched.

> [!NOTE]
> Before you start resolving the issue, take note of the view for which this error is occurring.

1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select the entity > **Views** and select the view that has this error. In this example, we are selecting the entity **Account** and view as **Accounts Being Followed**.

    > [!div class="mx-imgBorder"]
    > ![Choose a view from the entity](media/troubleshooting-column-entity-view-selection.png "Choose a view from the entity")

3. Select **More Actions** > **Edit**. 

    The view edit page opens.

    > [!div class="mx-imgBorder"]
    > ![Edit a view](media/troubleshooting-column-edit-view.png "Edit a view")

4. Select the column that is causing the issue and select **Remove**. In this example, we select the column **Email (Primary Contact)** to remove.

    > [!div class="mx-imgBorder"]
    > ![Remove column from view](media/troubleshooting-column-remove-column-view.png "Remove column from view")

    The column is removed from the view.

5. Add back the column that you have deleted. Select **Add Columns** and re-add the column that you removed. In this example, we are adding  the column **Email (Primary Contact)** that was removed.

    > [!div class="mx-imgBorder"]
    > ![Adding back the removed column](media/troubleshooting-column-add-back-column-view.png "Adding back the removed column")
   
    The data in the columns is displayed properly.

## Unable to see some records in the entity views

**Reason:**
This error is occurring due to the filtering of data on a view. 

**Resolution:**
To resolve this issue, you must edit or remove filters for the view. This will ensure that filters are applied properly for the view.

> [!NOTE]
> Before you start resolving the issue, take note of the view for which this error is occurring.

1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select the entity > **Views** and select the view that has this error. In this example, we are selecting the entity **Account** and view as **Accounts I Follow**.

    > [!div class="mx-imgBorder"]
    > ![Choose a view from the entity](media/troubleshooting-record-entity-view-selection.png "Choose a view from the entity")

3. Select **More Actions** > **Edit**. 

    The view edit page opens.

    > [!div class="mx-imgBorder"]
    > ![Edit a view](media/troubleshooting-record-edit-view.png "Edit a view")

4. Select **Edit Filter Criteria** and recheck the filter condition either by updating or deleting.

    > [!div class="mx-imgBorder"]
    > ![Update or clear the filter criteria](media/troubleshooting-record-update-filter.png "Update or clear the filter criteria")
   
    The records in the views are displayed properly.


### See also

[Frequently asked questions](faqs-sales.md) </br>
[Troubleshooting guide for sales people](troubleshooting.md)
