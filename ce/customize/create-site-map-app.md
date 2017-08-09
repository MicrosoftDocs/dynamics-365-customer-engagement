---
title: "Create a site map for an app in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
ms.assetid: 2461bd71-6cb4-46b7-8d1f-6a0aa3dca809
caps.latest.revision: 18
ms.author: "shujoshi"
---
# Create a site map for an app using the site map designer
Site maps define the navigation for your app. Create a site map for your app with ease by using the tile-based site map designer. The new designer lets you drag and drop components into the designer, preview your work, and instantly publish the site map. Administrators and any user with the required privileges can quickly create site maps for apps.  
  
 The site map designer also lets you define the area, subarea, or group titles in the languages supported by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 By default, a site map for the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] - custom app is already available. You can edit this site map or configure site maps for new apps by using the site map designer.  The site map designer is integrated with the app designer.  
  
## Create a site map for a custom app  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
     Specifically, any user with the following privileges can also access the apps:  
  
    -   Create, Read, and Write privileges on the App entity  
  
    -   Create and Read privileges on the Customizations entity  
  
    -   Read and Write  privileges on the Solution entity  
  
2.  On the app designer canvas, in the **Site Map** area, click the **Open the Site Map Designer** button ![Open Site Map Designer button](../customize/media/dynamics365-open-designer.PNG "Open Site Map Designer button").  
  
     The site map designer opens a canvas that is pre-populated with one area, one group, and one subarea.  Click the area, group, or subarea tile to change its properties.  
  
    > [!NOTE]
    >  Clicking the **Open the Site Map Designer** button ![Open Site Map Designer button](../customize/media/dynamics365-open-designer.PNG "Open Site Map Designer button") from the app designer canvas automatically creates a new site map (if there's no existing site map) with the same name as the app name and with same unique name as the app unique name.  
  
3.  [Add an area to the site map](../customize/create-site-map-app.md#bkmk_AddArea)  
  
4.  [Add a group to the site map](../customize/create-site-map-app.md#bkmk_AddGroup)  
  
5.  [Add a subarea to a group in the site map](../customize/create-site-map-app.md#bkmk_AddSubarea)  
  
6.  Click **Save**.  
  
    > [!NOTE]
    >  The new site map is associated with the app when you go back to the app designer and click **Save**. When a site  map is configured, the site map tile shows "Configured." Otherwise it shows "Not Configured."  If you open the site map designer from the app designer and configure a new site map,  but close the browser before associating the site map to the app, the site map will be automatically associated with the app the next time you open the app designer, based on the app unique name.  
  
7.  Click **Publish**.  
  
## Edit the default site map (Dynamics 365 - custom app)  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] comes with a default site map for the Dynamics 365 - custom app. This site map is supported for both the web application and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
2.  In the Dynamics 365 - custom app, go to **Settings** > **Customization**.  
  
3.  Click **Customize the System**.  
  
4.  In the Solution Explorer, under Components, click **Clients Extensions**.  
  
5.  Double-click the site map that has the display name "Site Map" and state "Managed." You can also select the site map, and then on the Action toolbar, click **Edit**.  
  
     The site map opens in the site map designer.  
  
6.  [Add an area to the site map](../customize/create-site-map-app.md#bkmk_AddArea)  
  
7.  [Add a group to the site map](../customize/create-site-map-app.md#bkmk_AddGroup)  
  
8.  [Add a subarea to a group in the site map](../customize/create-site-map-app.md#bkmk_AddSubarea)  
  
9. Click **Save**.  
  
10. Click **Publish**.  
  
<a name="bkmk_AddArea"></a>   
## Add an area to the site map  
  
1.  Click the **Add** button ![Add button on the designer](../customize/media/dynamics365-designer-addbutton.PNG "Add button on the designer") on the site map designer canvas, and then click **Area**.  
  
     -OR-  
  
     On the **Components** tab, drag and drop the Area tile to the empty box on the canvas. You'll see the empty box when you move the tile to the correct place on the canvas.  
  
2.  Click the area you just added. You will see the **Properties** tab highlighted in the right pane.  
  
3.  Add or edit the area properties:  
  
     Under **General**:  
  
    - **Title**. Enter the title for the area in the base language of the organization.  
  
    - **Icon**. A default application icon is selected. Select a different icon for the area from the list of web resources available in the solution.  
  
    - **ID**. A unique ID is automatically generated, but you can enter a different one if you want. We recommend that you use the provided ID because if the ID you enter is not unique, users may get an error when they are using the app or you may get  an error when you are importing a solution that contains this site map.  
  
    - **Show Groups**. Select this check box to show groups of subareas in the navigation pane.  
  
     Under **Advanced**:  
  
    - **More Titles**. If your organization uses multiple languages, select a language (Locale) for the title, enter the title, and then click the **Add** button ![Add button in the site map designer](../customize/media/add-icon-sitemap-designer.png "Add button in the site map designer"). You can create, edit, or delete titles for as many languages as your organization uses. However, you can have only one title per language.  
  
    - **More Description**. If your organization uses multiple languages, select a language for the description, enter the description, and then click the **Add** button ![Add button in the site map designer](../customize/media/add-icon-sitemap-designer.png "Add button in the site map designer"). You can create, edit, or delete descriptions for as many languages as your organization uses.  However, you can have only one description per language.  
  
    - **URL**.   Enter the URL to render for the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] folder that represents the area.  
  
<a name="bkmk_AddGroup"></a>   
## Add a group to the site map  
  
1.  On the site map designer canvas, click the area you want to add the group to.  
  
2.  Click the **Add** button ![Add button on the designer](../customize/media/dynamics365-designer-addbutton.PNG "Add button on the designer"), and then click **Group**.  
  
     -OR-  
  
     On the **Components** tab, drag and drop the Group tile to an empty box under the Area in the canvas. You'll see the empty box when you move the tile to the correct place in the canvas.  
  
3.  Click the group you just added.  
  
4.  On the **Properties** tab, add or edit the group properties:  
  
     Under **General**:  
  
    - **Title**. Enter the title for the group in the base language of the organization.  
  
    - **ID**. A unique ID is automatically generated. Enter a different one if required. We recommend using the automatic ID because if the ID you enter is not unique, you may get an error when you are importing a solution containing this site map.  
  
     Under **Advanced**:  
  
    - **More Titles**. If your organization uses multiple languages, select a language (Locale) for the title, enter the title for the group, and then click the **Add** button ![Add button in the site map designer](../customize/media/add-icon-sitemap-designer.png "Add button in the site map designer"). You can create, edit, or delete titles for as many languages as your organization uses.  However, you can have only one title per language.  
  
    - **More Descriptions**. If your organization uses multiple languages, select a language for the description, enter the description for the group, and then click the **Add** button ![Add button in the site map designer](../customize/media/add-icon-sitemap-designer.png "Add button in the site map designer"). You can create, edit, or delete descriptions for as many languages as your organization uses.  However, you can have only one description per language.  
  
    - **URL**.   Enter the URL to render for the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] folder that represents the group.  
  
    - **Set as Profile**. Select this check box to indicate whether this group represents a user-selectable Profile for the Workplace. The group set as a user-selectable profile is made available as options in your personal options. This only applies for groups within the Workplace area.  
  
<a name="bkmk_AddSubarea"></a>   
## Add a subarea to a group in the site map  
  
1.  Click the **Add** button ![Add button on the designer](../customize/media/dynamics365-designer-addbutton.PNG "Add button on the designer") on the site map designer canvas, and then click **Subarea**.  
  
     -OR-  
  
     On the **Components** tab, drag and drop the Subarea tile to an empty box under the Group section in the canvas. You'll see the empty box when you move the tile to the correct place in the canvas.  
  
2.  Click the subarea  you just added.  
  
3.  On the **Properties** tab, add or edit the subarea properties:  
  
     Under **General**:  
  
    - **Type**. Select whether the subarea you are adding is a dashboard, entity, web resource, or a URL.  
  
    - **Entity**. Select the entity that the subarea is for.  This field is disabled if the subarea  type is other than **Entity** in  the **Type** drop-down list.  
  
    - **URL**.   Specify a URL for the main page of the application to show when this subarea is clicked. This field is disabled if you've selected **Entity** in  the **Type** drop-down list.  
  
    - **Default Dashboard**. Select the default dashboard to be displayed for this subarea. This field is disabled if you haven't selected **Dashboard**  in the **Type** drop-down list.  
  
    - **Title**. Enter the title for the subarea in the base language of the organization.  
  
    - **Icon**. A default application icon is selected. Select a different icon for the subarea from the list of web resources available in the solution.  
  
    - **ID**. A unique ID is automatically generated. Enter a different unique ID if required.  
  
    - **Parameter Passing**. Select this check box to pass information about the organization and language context to the URL. This check box is enabled only when the subarea type is a web resource or a URL-based subarea.  
  
     Under **Advanced**:  
  
    - **Privileges**. This defines whether a subarea is displayed based on privileges available in any security roles that are assigned to the user. Select  the name of the entity to check privileges for. Then select the check boxes to assign privileges.  
  
    - **More Titles**. If your organization uses multiple languages, select a language for the title, enter the title for the subarea, and then click **Add**. You can create, edit, or delete titles for as many languages as your organization uses.  However, you can have only one title per language.  
  
    - **More Descriptions**. If your organization uses multiple languages, select a language for the description, enter the description for the subarea, and then click **Add**. You can create, edit, or delete descriptions for as many languages as your organization uses.  However, you can have only one description per language.  
  
    - **SKUs**. Select the versions of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] that display this subarea.  
  
    - **Client**. Select the type of client that displays this subarea.  
  
    - **Outlook Shortcut**. Select the icon to display in [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
    - **Offline Availability**. Select this check box to make this subarea available to users when they are offline in [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
## Organize areas, groups, and subareas  
 You can organize your areas, groups, and subareas by dragging and dropping them in new positions. A container box appears where you can drop the tiles. Here are some things you can do:  
  
-   Move a subarea to a new position within the same group or a different group under the same area.  
  
-   Move a subarea to a new position within a group under a different area.  
  
-   Move a group to a new position within the same area.  
  
-   Move a group to a new position in a different area.  
  
-   Move an area to a new position.  
  
## Clone a component in a site map  
 To make a copy of an existing component, click the component, and then on the Action toolbar, click **Clone**.  All details of the cloned component are same as the base component except the ID and Title. The ID is generated randomly.  
  
 When you clone an area, the cloned area is added to the right of the currently selected area.   When you clone a group, the cloned group is added to the right of the currently selected group.   When you clone a subarea, the cloned subarea is added below the currently selected subarea.  
  
## Delete an area, group, or subarea from a site map  
 To delete a site map component, click the component tile, and then on the Action bar, click **Delete**. When you delete an area, all groups and subareas in the area are also deleted. Similarly, when you delete a group, the group and subareas in it are deleted.  
  
## Clients supported  
 The following table explains the clients supported for different site maps.  
  
|Site Maps|supported Clients|  
|---------------|-----------------------|  
|Site map for the Dynamics 365 - custom app|[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]|  
|Default business apps (Sales, Customer Service, Field Service, Project Service Automation)|[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application|  
|New apps|[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application|  
  
### See also  
 [Create or edit an app](../customize/create-edit-app.md)   
 [Add or edit app components](../customize/add-edit-app-components.md)
