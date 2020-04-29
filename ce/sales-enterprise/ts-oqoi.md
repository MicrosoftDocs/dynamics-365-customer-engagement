---
title: "Troubleshooting common issues across multiple entities (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with multiple entities such as opportunity, quote, order, or invoice in Dynamics 365 Sales."
ms.date: 03/24/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting common issues across multiple entities 

This article helps you troubleshoot and resolve common issues across multiple entities like opportunity, quote, order, or invoice.

<a name="error_on_entities"> </a>
## Issue: Error or unexpected behavior while working on entities 

While working on entities (such as opportunities, quote, order, invoice, quote product, and order product), you observe unexpected behavior or an error in [!INCLUDE[pn_sales_business_doc_name](../includes/pn-sales-business-doc-name.md)]. The following are some of the errors that you might encounter while working on opportunities, and they might apply to other entities:

- "Extended Amount is wrong after revising quote"- this error might occur due to a custom plug-in.
- "Error while saving the opportunity" - this error might occur due to custom JavaScript.
- "Error while close opportunity" - this error might occur due to a custom workflow.

These issues might occur due to improper customization of the application. You must verify these customizations and resolve them. Perform the following verification methods to identify which customization is causing the issue, and then resolve:

- [Deactivate custom plug-in](#deactivate-custom-plug-in)
- [Disable custom JavaScript](#disable-custom-javascript)
- [Deactivate a custom workflow process](#deactivate-custom-process)

### Deactivate a custom plug-in<a name="deactivate-custom-plug-in"></a>

1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select **Sdk Message Processing Steps**. 

   A list of available SDK message processing steps is displayed.

3. Select the **Filter** icon, select the column **Primary Object Type Code (Sdk Message Filter)**, and then select the entity for which the error is occurring.
    
    > [!div class="mx-imgBorder"]
    > ![Go to the custom plug-in list](media/troubleshooting-goto-custom-plugin-list.png "Go to the custom plug-in list")

4. Select the SDK message processing steps that are coming from the solutions owned by you. 

    > [!NOTE]
    > To view your custom SDK message processing steps:
    > <ol><li>Go to <b>Settings</b> > <b>Solutions</b>, and then open the solution.</li>
    > <li>Select <b>SDK Message Processing Steps</b>. Verify that the values are selected as follows:  <b>Component Type</b> to <b>SDK Message Processing Step</b>, and <b>View</b> to <b>All</b>.</li></ol>

5. Select **Deactivate**.
6. Publish the customizations.
 
    > [!div class="mx-imgBorder"]
    > ![Choose and deactivate unmanaged custom plug-ins](media/troubleshooting-deactivate-unmanaged-custom-plugin.png "Choose and deactivate unmanaged custom plug-ins")

7. Verify the issue and if it doesn't occur, the issue is with the custom SDK message processing steps. Resolve the issue.

> [!NOTE]
> If the issue occurs, activate the **SDK Message Processing Steps** that you deactivated now and try to [disable custom JavaScript](#disable-custom-javascript) or [deactivate a custom workflow process](#deactivate-custom-process).

### Disable custom JavaScript

1. Open the form editor of the entity in which the error is occurring. In this example, we're selecting the entity as Opportunities and the default solution form.

    > [!div class="mx-imgBorder"]
    > ![Open form editor](media/troubleshooting-javascript-form-editor.png "Open form editor")

2. Select **Form Properties** on the form editor.

    > [!div class="mx-imgBorder"]
    > ![Edit form page](media/troubleshooting-javascript-form-editor-edit-properties.png "Edit form page")

    The **Form Properties** dialog box opens.

3. On the **Events** tab, select the control **OnLoad** from the **Events** drop-down list. 

   > [!div class="mx-imgBorder"]
   > ![Event control selection](media/troubleshooting-javascript-form-properties-event-control-selection.png "Event control selection")

4. Choose the custom **JavaScript** files that are coming from the solution owned by you.

   > [!NOTE]
   > To view your custom JavaScript:<br>
   > a. Go to **Settings** > **Solutions**, and then open the solution. <br>
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

8. Verify the issue and if it doesn't occur, the issue is with the custom JavaScript. Resolve the issue.

> [!NOTE]
> If the issue occurs, enable the JavaScript that you disabled now and try to [Deactivate a custom plug-in](#deactivate-custom-plug-in) or [Deactivate a custom workflow process](#deactivate-custom-process).

### Deactivate a custom workflow process<a name="deactivate-custom-process"></a>

1. Go to **Settings** > **Customizations** > **Customize the System**.
1. Select **Processes**. These processes include Workflow, Business Process Flow, and Business Rule.
   A list of available processes is displayed.
3. Select the **Filter** icon, select the column **Primary Entity**, and then select the entity for which the error is occurring.
    
    > [!div class="mx-imgBorder"]
    > ![Go to the custom process workflow list](media/troubleshooting-goto-custom-process-workflow-list.png "Go to the custom process workflow list")

4. Choose the processes that are coming from the solutions owned by you.

    > [!NOTE]
    > To view your custom processes:
    > <ol><li>Go to <b>Settings</b> > <b>Solutions</b>, and then open the solution.</li> 
    > <li>Select <b>Processes</b>. Verify the values are selected as:  <b>Component Type</b> to <b>Processes</b> and <b>View</b> to <b>All</b>.</li></ol>

5. Select **Deactivate**.
6. Publish the customizations.
 
    > [!div class="mx-imgBorder"]
    > ![Choose and deactivate unmanaged process workflows](media/troubleshooting-goto-deactivate-unmanaged-custom-process-workflow.png "Choose and deactivate unmanaged custom process workflows") 

7. Verify the issue and if it doesn't occur, the issue is with the custom processes. Resolve the issue.

> [!NOTE]
> If the issue occurs, activate the **Processes** that you deactivated now and try to [Deactivate a custom plug-in](#deactivate-custom-plug-in) or [Disable custom JavaScript](#disable-custom-javascript).

<a name="missing-records"> </a>
## Issue: I can't see some records in opportunity, quote, order, or invoice subgrids
<!--Edit to the title okay? -->
While working on opportunity, quote, order, or invoice records, you might observe that some records are missing.

**Reason**

-   You might not see some records because of an error that occurred due to customization done to the subgrid.

**Resolution**

To fix the issue of incorrect customization, follow these steps to make sure your subgrid is configured correctly:

1.  In your app, on the nav bar, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]
    > ![Advanced Settings link in the Settings menu](media/advanced-settings-option.png "Advanced Advanced Settings link in the Settings menu")

    The **Business Management** settings page opens in a new browser tab.

2. On the navigation bar, select **Settings**, and then under **Customization**, select **Customizations**. 

3. Select **Customize the System**.

4. Under **Components** in the solution explorer, expand **Entities**, expand **Opportunity**, and then select **Forms**.

5. Open the Opportunity form of type 'Main'.

6. Double-click to select the **Connections** section in the **Product Line Items** section.

    > [!div class="mx-imgBorder"]
    > ![Product Line Items subgrid](media/product-line-items-subgrid.png "Product Line Items subgrid")

    The **Set Properties** dialog box opens.

    > [!div class="mx-imgBorder"]
    > ![Set properties of Opportunity Products grid](media/set-properties-opportunity-products-grid.png "Set properties of Opportunity Products grid")

7. On the **Controls** tab, double-click to select **Editable Grid**.

    > [!div class="mx-imgBorder"]
    > ![Double-click the Editable Grid option](media/editable-grid-option.png "Double-click Editable Grid option")

8. Make sure that all values are set correctly:

    -  Grid View: Opportunity Product Inline Edit View

    -  Nested Grid View: Select the pencil icon and fill in the following details:

        > [!div class="mx-imgBorder"]
        > ![Configure property dialog box](media/configure-property-dialog-box.png "Configure property dialog box")

        -   Entity: Opportunity Products

        -  View: Opportunity Product Inline Edit View: Bundle Products

    -   Nested grid parent ID: parentbundleidref

    -   Group by Column: Enabled (Enum)

    -   Allow filtering: Enabled (Enum)

    -   Hide nested grid column header: Hide Column



### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  