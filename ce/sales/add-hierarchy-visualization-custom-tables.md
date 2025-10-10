---
title: Adding hierarchy support to tables
description: Learn how to enable hierarchy visualization for custom and other tables in your organization.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: 
ms.date: 10/10/2025
ms.custom: bap-template 
---

# Adding hierarchy support to tables

Users typically view a hierarchy by selecting the **View hierarchy** button on the command bar when viewing a record on a form or a grid. While the **View hierarchy** button is enabled by default on the Contact, Opportunity, Lead, and Account forms and grids, as an administrator, you can add the **View hierarchy** button to all other tables.

## Add the table to the application  

You have to add the table to the application in order to customize the behavior of forms and grids associated with the table. Follow these steps:

1. Sign in to [the Power Apps maker portal](https://make.powerapps.com/).  
1. Go to **Apps** and select your app.  
    > [!NOTE]
    > Ensure that the correct environment is selected in the top-right corner of the page.  
1. Go to **Navigation** > **Customers** and select an existing table under which you want to add a new table.  
1. On the command bar, select the drop-down chevron and select **Dataverse** table.  
1. Search and add the **Hierarchy Configurations** table.  
    > [!NOTE]
    > If you don't want the table shown under the **Customers** section, deselect the **Show in navigation** option. The table is added to the **All other pages** section in the left navigation.  
1. Save and publish.  
    The table is added to the application.

## Add button to command bar of a form or a grid

To add the **View hierarchy** button to a form or a grid command bar, follow these steps:

1. You must have administrator privileges.  
1. Sign in to [the Power Apps maker portal](https://make.powerapps.com/).  
1. Go to **Apps** and select your app.  
    > [!NOTE]
    > Ensure that the correct environment is selected in the top-right corner of the page.  
1. On the app home page, select *table* > more options (...) > **Edit command bar**.
    > [!NOTE]
    > If you don't see the table, add the table to your app. More information: [App navigation in model-driven apps](/power-apps/maker/model-driven-apps/app-navigation).  
1. On the edit command bar dialog, choose **Main grid** or **Main form** depending on where you want to add the command.  
1. Select the existing command bar button after which to add the new button, then select **+ New** > **Command**.  
    New command option is available next to the selected command. The following screen is an example **Main form**:  
    :::image type="content" source="media/hv-new-command-option.png" alt-text="Screen shot of adding a new command to the command bar.":::  
1. On the new command bar pane, enter the following information depending on whether you're adding the button to a form or a grid.  

    - For **Main form**:  

        | Field name | Description |
        |------------|-------------|
        | Label | Enter a label for the command. For example, **View hierarchy**. |
        | Icon | From the list, select **Use web resource** and then select **Add web resource**. In the **Add image web resource** dialog box, search and add **HierarchyViewerIcon.svg**. |
        | Action | Select **Run JavaScript** as the action type. |
        | Library | Select **LinkedInExtensions/HierarchyViewer/msdyn_HierarchyViewer.js** from the list of available JavaScript libraries. If the library isn't available, select **Add library** and then add the library to the list. |
        | Function name | Enter **HierarchyViewer.RibbonRules.formShowHierarchyViewer**.<br>Select **Add Parameters** and then add the following parameters: <br>- For **Parameter1**, from the dropdown list, select `PrimaryControl`.<br>- For **Parameter2**, from the dropdown list, select `PrimaryEntityTypeName`.<br> For **Parameter3**, from the dropdown list, select `FirstPrimaryItemId`. |
        | Visibility | Select **Show**.<br>If you want to use a formula to control button visibility, select **Show on condition from formula**, open the formula bar, and add a function. For example, to allow navigation to the hierarchy only after the item is saved, enter `Not(Self.Selected.Unsaved) && Self.Selected.State = 0`. |

    - For **Main grid**:  

        | Field name | Description |
        |------------|-------------|
        | Label | Enter a label for the command. For example, **View hierarchy**. |
        | Icon | From the list, select **Use web resource** and then select **Add web resource**. In the **Add image web resource** dialog box, search and add **HierarchyViewerIcon.svg**. |
        | Action | Select **Run JavaScript** as the action type. |
        | Library | Select **LinkedInExtensions/HierarchyViewer/msdyn_HierarchyViewer.js** from the list of available JavaScript libraries. If the library isn't available, select **Add library** and then add the library to the list. |
        | Function name | Enter **HierarchyViewer.RibbonRules.formShowHierarchyViewer**.<br>Select **Add Parameters** and then add the following parameters: <br>- For **Parameter1**, from the dropdown list, select `SelectedControl`.<br>- For **Parameter2**, from the dropdown list, select `SelectedEntityTypeName`.<br> For **Parameter3**, from the dropdown list, select `FirstSelectedItemId`. |
        | Visibility | Select **Show**.<br>If you want to use a formula to control button visibility, select **Show condition from formula** and then add the formula. For example, to only allow navigating to the hierarchy when a row is selected, enter `CountRows(Self.Selected.AllItems) = 1`. |  

1. Save and publish.  
    View hierarchy option is added to the command bar for the selected table.  
1. To verify, open the app, go to the table where you added the button, and then select a record. You should see the **View hierarchy** option in the command bar.  

## Related information

- [Overview of hierarchy visualization](hierarchy-visualization.md)  
- [Create and publish a hierarchy visualization](create-activate-hierarchy-visualizations.md)
