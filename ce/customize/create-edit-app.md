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
ms.assetid: 2a44229e-44f0-4c4e-ba21-a476210d0a12
ms.author: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 19
topic-status: Drafting
---

# Create or edit an app using the app module designer

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Create single or multi-entity apps quickly  by using the tile-based app designer.  
  
 Open the app designer from the **My Apps** page or from the **Apps** area in the Solutions window.

## Prerequisites
Verify the following prerequisites before you start creating the app:
[!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] Specifically, any user with the following privileges can also create  apps:  
-   Create, Read, and Write privileges for the App entity  
-   Read and Write privileges for the Customizations entity  
-   Read privileges for the Solution entity
  
<a name="createApp"></a>   
## Create an app  
  
1.  Go to **Settings** > **My Apps**, and then select **Create New App**. The app designer opens in a new browser tab.  

    ![Open app designer](../customize/media/app-designer-settings-apps.png "Open app designer")
  
     -OR-  
  
     Go to **Settings** > **Customizations** > **Customize the System**. On the solutions window select **Apps**, and then select **New** on the **Action** toolbar.  

     ![Create an app through sloutions window](../customize/media/app-designer-customize-system-settings.png "Create an app through sloutions window")
  
2. In the **Create a New App** page, enter the following details:  
  
    - **Name**. Enter a unique name for the app.  
  
    - **Unique Name**. The unique name is automatically populated based on the app name that you specify.  It is prefixed with a publisher prefix. You can change the part of the unique name that’s editable. The unique name can only have English characters and numbers.  
  
        > [!NOTE]
        >  The publisher prefix is the text that is added to any entity or field created for a solution that has this publisher.   
  
    - **Description**. Type a short description of what the app is or does.  
  
    - **Icon**. By default, the **Use Default App** thumbnail check box is selected. To select a different web resource as an icon for the app, clear the check box, and then select an icon from the drop-down list. This icon is displayed on the preview tile of the app.  
  
    - Select the client type that the app will be used for.  
  
        - **Web**. This is the classic Dynamics 365 web browser client.  
  
        - **Unified Interface**. This is the new Dynamics 365 web browser client that has a similar interface across PC and mobile devices.  
  
    - **App URL Suffix**. The app URL is automatically populated based on the app name that you specify. You'll see a preview of how the complete URL looks. The app URL  must be unique.  
  
         For on-premises: http://\<server>/\<org name>/Apps/\<App URL> 
  
         For online organizations: https://\<server>. crm#.dynamics.com/Apps/\<App URL>  
  
     > [!NOTE]
     >  If you clear the App URL Suffix field and then save, the app URL is automatically generated with the app ID.  
  
    - **Use existing solution to create the App**. Select this option to create the app from a list of installed solutions. When you select this option, **Done** button toggles to **Next** on the header. Select **Next** and you are navigated to **Creat app from existing solution** page. From the **Select Solution** drop down list, select a solution from which you want to create the app. If any sitemap is availabe for the selected solution, **Select Sitemap** drop down list will be displayed. Select the sitemap and then select **Done**.

     > [!NOTE]
     > By selecting the **Default Solution**, when you add a sitemap, the components that are associated with that sitemap are automatically added to the app.  

    ![Use existing solution to create the app page](../customize/media/use-existing-solution-to-create-the-app.png "Use existing solution to create the app page") 

    - **Choose a welcome page**. This option allows you to select from the web resources available in your organization. The welcome pages you create can contain useful information to users such as links to videos, upgrade instructions, or getting started information. The welcome page displays when an app is opened. Users may select **Do not show this Welcome Screen next time** on the welcome page to disable the page so it doesn’t appear the next time the app starts. For more information about how to create a web resource, such as an HTML file that you can use as a welcome page, see [Create and edit web resources to extend the web application](create-edit-web-resources.md).  
      
    To edit app properties later, go to the **Properties** tab in the app designer. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage app properties](../customize/manage-app-properties.md)  
  
     > [!NOTE]
     >  You can't change the unique name and app URL suffix in the **Properties** tab.  
  
3. Select **Done** or, if you selected **Use an existing solution to create the App**, select **Next** to select from the available solutions that were imported in the organization.  
  
    A new app is created and shows Draft status. You'll see the app designer canvas for the new app.  
  
4. Add or edit components to the app, as required. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add or edit app components](../customize/add-edit-app-components.md)  
  
<a name="editApp"></a>   
## Edit an app  
  
1. Go to **Settings** > **My Apps**.  

-OR-
  
  Go to **Settings** > **Customizations** > **Customize the System**. On the solutions window select **Apps**, and then double-click the app you want to edit.  
  
2. From the My Apps page you can search or filter to easily find an app.  
  
    -   To search on the app name type the name in the **search my apps** box.  
  
    -   To filter apps by client type, select **Filter**, and then select the client type that you want from the **Filter** pane.  
  
    ![My Apps search and filter](../customize/media/app-designer-myapps.png "My Apps search and filter")  
  
3. To edit a published app, in the **Published Apps** view in the lower right corner of the app tile you want to edit, select the **More options** button (**...**), and then select **Open in App Designer**  
  
     -OR-  
  
     To edit a draft app, in the **Apps Being Edited** view,  select the app tile to open the app in the app designer.  
  
     The app designer opens in a new browser tab.  
  
    > [!NOTE]
    >  Alternatively, go to **Settings** > **Customizations** > **Customize the System**. On the solutions window select **Apps**, and then double-click the app you want to edit.  
  
4.  Add or edit components to the app, as required. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add or edit app components](../customize/add-edit-app-components.md)  
 
<a name="LaunchApp"></a>   
## Run an app
To start an app, users go to **My Apps** and then select the app they want. If there are several apps available, search for the app by typing in the search box.

From within an app, the following features include filtering by record type:
- Categorized search and Relevance search results.
- Quick Create forms.
- Recent records grids.

  
### See also  
 [Add or edit app components](../customize/add-edit-app-components.md)   
 [Design custom business apps by using the app designer](design-custom-business-apps-using-app-designer.md)
