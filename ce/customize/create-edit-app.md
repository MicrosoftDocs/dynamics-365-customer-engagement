---
title: "Create or edit an app using the app designer (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shubhadaj"
ms.assetid: 2a44229e-44f0-4c4e-ba21-a476210d0a12
ms.author: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 19
topic-status: Drafting
---

# Create or edit an app by using the app designer

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Create single-entity or multiple-entity apps quickly by using the tile-based app designer.  
  
Open the app designer from the **My Apps** page or from the **Apps** area in the solution window.

## Prerequisites
Verify the following prerequisites before you start creating an app:
[!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] Specifically, any user with the following privileges can also create  apps:  
-   Create, Read, and Write privileges for the App entity  
-   Read and Write privileges for the Customizations entity  
-   Read privileges for the Solution entity
  
<a name="createApp"></a>   
## Create an app  

1.  Go to **Settings** > **My Apps**, and then select **Create New App**. The app designer opens in a new browser tab.  

    ![Open app designer](../customize/media/app-designer-settings-apps.png "Open the app designer")
  
     or  
  
    Go to **Settings** > **Customizations** > **Customize the System**. In the **Solution** window, select **Apps**, and then select **New** on the toolbar.  

    ![Create an app through sloutions window](../customize/media/app-designer-customize-system-settings.png "Create an app through the solution window")
  
2. On the **Create a New App** page, enter the following details:  
  
    - **Name**: Enter a unique name for the app.  
  
    - **Unique Name**: The unique name is automatically populated based on the app name that you specify. It is prefixed with a publisher prefix. You can change the part of the unique name that's editable. The unique name can only contain English characters and numbers.  
  
        > [!NOTE]
        >  The publisher prefix is the text that's added to any entity or field created for a solution that has this publisher.   
  
    - **Description**: Type a short description of what the app is or does.  
  
    - **Icon**: By default, the **Use Default App** thumbnail check box is checked. To select a different web resource as an icon for the app, clear the check box, and then select an icon from the drop-down list. This icon will be displayed on the preview tile of the app.  
  
    - Select the client type that the app will be used for.  
  
        - **Web**: This is the classic [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web browser client.  
  
        - **Unified Interface**: This is the new [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web browser client that has a similar interface across PC and mobile devices.  
  
    - **App URL Suffix**: The app URL is automatically populated based on the app name that you specify. You'll see a preview of how the complete URL looks. The app URL must be unique.  
  
         For on-premises: http://\<server>/\<org name>/Apps/\<App URL> 
  
         For online organizations: https://\<server>. crm#.dynamics.com/Apps/\<App URL>  
  
      > [!NOTE]
      >  If you clear the **App URL Suffix** field and then save the app, the app URL will be automatically generated with the app ID.  
  
    - **Use existing solution to create the App**: Select this option to create the app from a list of installed solutions. When you select this option, **Done** switches to **Next** on the header. If you select **Next**, the **Create app from existing solution** page opens. From the **Select Solution** drop-down list, select a solution from which you want to create the app. If any site map is available for the selected solution, the **Select Sitemap** drop-down list will appear. Select the site map, and then select **Done**.

      > [!NOTE]
      > By selecting **Default Solution** when you add a site map, the components that are associated with that site map are automatically added to the app.  

      ![Use existing solution to create the app page](../customize/media/use-existing-solution-to-create-the-app.png "Use an existing solution to create the app") 

    - **Choose a welcome page**: This option allows you to select from the web resources available in your organization. The welcome pages you create can contain information that's useful to users, such as links to videos, upgrade instructions, or getting started information. The welcome page is displayed when an app is opened. Users can select **Do not show this Welcome Screen next time** on the welcome page to disable the page so it doesn’t appear the next time the app starts. More information about how to create a web resource, such as an HTML file that you can use as a welcome page: [Create and edit web resources to extend the web application](create-edit-web-resources.md)  
      
    To edit app properties later, go to the **Properties** tab in the app designer. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage app properties](../customize/manage-app-properties.md)  
  
     > [!NOTE]
     >  You can't change the unique name and app URL suffix on the **Properties** tab.  
  
3. Select **Done** or&mdash;if you selected **Use an existing solution to create the App**&mdash;select **Next** to select from the available solutions that were imported in the organization.  
  
    A new app is created and is shown in Draft status. You'll see the app designer canvas for the new app.  
  
4. Add components to the app or edit existing components, as required. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add or edit app components](../customize/add-edit-app-components.md)  
  
<a name="editApp"></a>   
## Edit an app  
  
1. Go to **Settings** > **My Apps**.  

   or
  
   Go to **Settings** > **Customizations** > **Customize the System**. In the solution window, select **Apps**, and then double-click to select the app you want to edit.  
  
2. From the **My Apps** page, you can search or filter to easily find an app.  
  
    -   To search on the app name, enter the name in the **search my apps** box.  
  
    -   To filter apps by client type, select **Filter**, and then select the client type that you want from the **Filter** pane.  
  
    ![My Apps search and filter](../customize/media/app-designer-myapps.png "My Apps search and filter")  
  
3. To edit a published app, in the **Published Apps** view in the lower-right corner of the app tile you want to edit, select **More options** (**...**), and then select **Open in App Designer**  
  
     or  
  
     To edit an app that's in Draft status, in the **Apps Being Edited** view, select the app tile.  
  
     The app designer opens in a new browser tab.  
  
    > [!NOTE]
    >  Alternatively, you can go to **Settings** > **Customizations** > **Customize the System**. In the solution window, select **Apps**, and then double-click to select the app you want to edit.  
  
4.  Add or edit components to the app, as required. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add or edit app components](../customize/add-edit-app-components.md)  
 
<a name="LaunchApp"></a>   
## Run an app

To start an app, users go to **My Apps** and then select the app they want. If there are several apps available, they can search for the app by typing in the search box.

From within an app, the following features include filtering by record type:
- Categorized search and Relevance search results
- Quick Create forms
- Recent records grids

  
### See also  
 [Add or edit app components](../customize/add-edit-app-components.md)   
 [Design custom business apps by using the app designer](design-custom-business-apps-using-app-designer.md)
