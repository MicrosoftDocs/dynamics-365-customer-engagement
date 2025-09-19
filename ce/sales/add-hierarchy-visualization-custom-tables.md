---
title: Add hierarchy visualization to custom tables
description: Learn how to enable hierarchy visualization for custom and other tables in your organization.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: 
ms.date: 09/22/2025
ms.custom: bap-template 
---

# Add hierarchy visualization to custom tables

Users typically view a hierarchy by selecting the **View hierarchy** button on the command bar when viewing a record on a form. The View hierarchy button is enabled by default on the Contact, Opportunity, Lead and Account forms. This topic explains how to add the View hierarchy button to form for other tables. Follow these steps:  

1. You must have administrator privileges.  
1. Sign in to [the Power Apps maker portal](https://make.powerapps.com/).  
1. Go to **Apps** and select your app.  
    > [!NOTE]
    > Ensure that the correct environment is selected in the top-right corner of the page.  
1. On the app home page, select *table* > more options (...) > **Edit command bar**.
    > [!NOTE]
    > If you don't see the table, add the table to your app. More information: [App navigation in model-driven apps](/power-apps/maker/model-driven-apps/app-navigation).  
1. On the edit command bar dialog, choose a command bar to edit.  
    In this procedure, we are editing the **Main form** command bar.  
1. Select the existing command bar button after which to add the new button, then select **+ New** > **Command**.  
    New command option is available next to the selected command.  

    :::image type="content" source="media/hv-new-command-option.png" alt-text="Screen shot of adding a new command to the command bar.":::

1. On the new command bar pane, enter the following information:  

    - **Label**: Enter a label for the command. For example, **View hierarchy**.  
    - **Icon**: From the list, select **Use web resource** and then select **Add web resource**. In the **Add image web resource** dialog box, search and add **HierarchyViewerIcon.svg**.
    - **Action**: Select **Run JavaScript** as the action type.  
    - **Library**: Select **LinkedInExtensions/HierarchyViewer/msdyn_HierarchyViewer.js** from the list of available JavaScript libraries. If the library is not available, select **Add library** and then add the library to the list.
    - **Function name**: Enter **HierarchyViewer.RibbonRules.formShowHierarchyViewer**.  
    - Select **Add Parameters** and then add the following parameters:  
        - **Parameter1** as **PrimaryControl**.  
        - **Parameter2** as **PrimaryEntityTypeName**.  
    - **Visibility**: Select **Show**.
1. Save and publish.  
    View hierarchy option is added to the command bar for the selected table.  
1. To verify, open the app, go to the table where you added the command, and then select a record. You should see the **View hierarchy** option in the command bar.  

## Related information

- [Overview of hierarchy visualization](hierarchy-visualization.md)  
- [Create and publish a hierarchy visualization](create-activate-hierarchy-visualizations.md)