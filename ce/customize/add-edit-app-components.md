---
title: "Add or edit app components (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: be93b9d7-f1c2-4ee7-8d7c-0f5c34dfa5f7
ms.author: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 17
topic-status: Drafting
---

# Add or edit app components in the app designer

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

An app is composed of various components. There are two types of components that you can add to an app: artifacts and entity assets. In the context of the app designer, entities, dashboard, and business process flows are all artifacts of an app. All assets of an entity - like forms, views, charts, and dashboards - called entity assets.  
  
 The app designer refers to existing  metadata in the default solution. It also allows you to create components like forms, views, charts, and dashboards.  
  
## App designer layout  
 The app designer has two main areas. On the left side is the canvas where you add app components.  
  
 ![App designer canvas](../customize/media/app-designer-canvas-pane.png "App designer canvas")  
  
 On the right side, you have tabs that you'll use to select components and set component properties.  
  
 ![App designer components](../customize/media/app-designer-canvas-components-tab.png "App designer components")  
  
 On the canvas, you’ll see areas for site map, business process flow, dashboard, and entities. When you select a dashboard or business process flow or configure a site map,  the app designer automatically adds the entities that are used in these components to the canvas. Once you have the entities in place, all you need to do is select each entity, and add the required entity assets like the forms, view, and charts to it.<br/>
 You can also use the **Search Canvas** option to search for the components on the canvas. When you select this option, a new search tab will open on the right side tab area.   
  
 ![Canvas search option](media/app-designer-search-tab.png "Canvas search")

## Add an artifact (entity, dashboard, or business process flow)  
 When you add a dashboard or business process flow to an app, the entities they use are automatically added to the app. When you add an entity, the tiles for its assets are automatically added. There are two ways you can add artifacts to the designer canvas: by using the **Add** button ![Add button on the designer](../customize/media/dynamics365-designer-addbutton.PNG "Add button on the designer") on the command bar or by using the tiles in the **Components** tab.  
  
 Here are the steps for adding a dashboard to the app.  Use the same steps to add a business process flow or entity.  
  
1.  On the app designer canvas, select the **Dashboards** tile.  
  
     On the app designer canvas, the right pane shows you dashboards that are available in the default solution.  
  
    > [!TIP]
    >  Alternatively, you can also do one of the following:  
    >   
    > - Select **Add** button ![Add button on the designer](../customize/media/dynamics365-designer-addbutton.PNG "Add button on the designer"), and select **Dashboards**.  
    > - On the **Components** tab, under **Artifacts**, select **Dashboards**.  
  
2.  In the **search** box, type a few keywords for the dashboard name you're looking for.  
  
     The dashboard list will be filtered to show results that match your keywords.  
  
3.  If you want your users to use only selected dashboards, select the check box for the dashboards you want to add. You can select from the following types of dashboards:
    - **Classic Dashboards:** displays on both web application and unified interface.
    - **Interactive Dashboards:** displays only on unified interface. If you have selected the client type for the app as web application, the interactive dashboards option will not be displayed.

     Those dashboards will be added to the Dashboard tile on the app designer canvas. The dashboard tile also shows a count of the number of dashboards added to the app. If you don't select a dashboard, all dashboards are available to  users when they use the app, and instead of the dashboard count, "All" is shown.  
  
     All entities the dashboard uses are also added to the **Entity View**  area. For example, if you add the Customer Service Manager dashboard, the Case, Entitlement, and Queue Item entities are added to the Entity View area. For each entity, tiles for its assets are also added. You can use these  tiles to add forms, views, and charts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add entity assets (forms, views, or charts)](../customize/add-edit-app-components.md#bkmk_AddEntityAssets)  
  
    ![Add entity to the app designer canvas](../customize/media/add-entity-app-designer-canvas.png "Add entity to the app designer canvas")  
  
4.  If the dashboard you want doesn't exist in the default solution, create a dashboard by selecting **Create New** on the **Components** tab on the right side.  
  
     ![Create New link on the Components tab of app designer](../customize/media/app-designer-components-tab-create-new.png "Create New link on the Components tab of app designer")  
  
     The dashboard designer opens. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit dashboards](../customize/create-edit-dashboards.md)  
  
    > [!NOTE]
    > - When you're adding a business process flow or entity, the **Create New** option opens the corresponding designer. To learn more about creating business process flows or entities, see [Create a business process flow](../customize/create-business-process-flow.md) and [Create and edit entities](../customize/create-edit-entities.md).  
      
  
5.  When you're done adding artifacts, on the command bar, select **Save**.  
  
<a name="bkmk_AddEntityAssets"></a>   
## Add entity assets (forms, views, charts, or dashboards)  
 With the artifacts in place, you can start adding entity assets like forms, views, charts, and dashboards to the app.
 Additionally, if you are using Unified Interface client, you can also add entity dashboard assests to the app.  
  
 This section describes the steps for adding a form to the app. Use the same steps to add a view or chart to the app.  
  
1.  On the app designer canvas, select the **Forms** tile for the entity you want to add a form to.  
  
     On the app designer canvas, the entire row for the  entity is selected.  On the right side, you'll see all existing forms for the selected entity.  
  
    > [!NOTE]
    >  Alternatively, you can also do one of the following:  
    >   
    > - Select **Add** ![Add button on the designer](../customize/media/dynamics365-designer-addbutton.PNG "Add button on the designer") button, and then select **Forms**.  
    > - On the **Components** tab, under **Entity Assets**, select **Forms**.  
  
    > [!TIP]
    >  For all entities selected for the app, a **More Options** button (**...**) appears in the **Select Entities** list of the **Components** tab. To add all assets for the selected entity, select the **More Options** button (**...**), and then select **Add All Assets**.  
  
2.  If you want your app users to use only selected forms, select the check boxes for the forms you want to add. The forms define how users will see and interact with data in the app.  
  
     The form tile of the selected entity will show  the number of forms added.  
  
     ![Form tile for case entity](../customize/media/add-forms-entity.png "Form tile for case entity")  
  
     For example, if you do not select any form for an entity, then all the forms for that entity are displayed to the users while using the app. This behavior is similar for views and charts as well, if no view or chart is selected. This helps users create apps quickly when they need to work with all available components—there's no need to select each component during app design.  

     If no dashboards or businss process flows are selected, all the dashboards and business process flows are available for users while using the app.
  
    > [!NOTE]
    > For the app to run, each entity that you add must have at least one active form. If you've selected multiple forms, the first active form  that appears in the default solution will be used when users run the app.  
  
3.  If you want to add a new form that's not available in the list, select **Create New**.  
  
     In the drop-down, select the type of form you want to create.  
  
    > [!NOTE]
    >  The drop-down is available only when you're adding forms. It isn't available for views and charts.  
  
     The form designer opens. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and design forms](../customize/create-design-forms.md)  
  
     When you're adding a view or a chart, the **Create New** option opens the corresponding designer. To learn more about creating views or charts, see [Create and edit views](../customize/create-edit-views.md) and [Create or edit a system chart](../customize/create-edit-system-chart.md)  
  
    > [!NOTE]
    >  When you're adding a view, you can reference only public views that are listed under the **Views** node in the solution explorer.  
  
4. Select drop down icon ![Drop down icon](../customize/media/drop-down-icon.png "drop down icon") to expand the tile and see a list of forms that have been added.  
  
     ![Form tile expanded in app designer](../customize/media/app-designer-expanded-form-tile.png "Form tile expanded in app designer")  
  
5.  Repeat these steps to add entity views and charts to the app.  
  
6.  Select **Save**.  
  
## Edit or remove artifacts  
  
- To edit a dashboard or a business process flow, select drop down icon ![Drop down icon](../customize/media/drop-down-icon.png "drop down icon") to expand the tile, and then select ![Open Site Map Designer button](../customize/media/dynamics365-open-designer.PNG "Open Site Map Designer button") corresponding to the dashboard or business process flow that you want to edit.  
  
     The designer for the selected artifact opens.  
  
- To remove a dashboard or a business process flow, select drop down icon ![Drop down icon](../customize/media/drop-down-icon.png "drop down icon") to expand the tile, and then select the dashboard or business process flow that you want to remove. On the command bar, select **Remove**.  

    Also, you can remove a dashboard or a business process flow by clearing the corresponding check box from the **Components** tab.
  
-   To edit or remove an entity, select the entity tile, and then on the command bar, select **Edit** or **Remove**. When you edit an entity, the solution explorer opens, where you can make changes to the entity.  
  
     Alternatively, to remove a component, select the dashboard or business process flow, or entity tile. The **Component** tab shows the corresponding dashboards or business process flows or entities that are referenced (added) in the app designer. Clear the check boxes for the artifact you want to remove from the designer.  
  
    > [!NOTE]
    >  When you make any changes to an entity  - like changing an entity display name or description - the changes don't appear in the app designer unless the changes are published in the solution explorer.  
  
## Edit or remove entity assets  

### Edit entity assets
  
1. Select drop down icon ![Drop down icon](../customize/media/drop-down-icon.png "drop down icon") to expand the tile such as forms, views, chars, or dashboardss.  
  
2. Select the form, view, chart, or dashboard that you want to edit.  
  
3. On the command bar, select **Edit**. <br/>
   -OR<br/>
   Select ![Open Site Map Designer button](../customize/media/dynamics365-open-designer.PNG "Open Site Map Designer button") corresponding to the form, view,chart, or dashboard.  

### Remove entity assets  

1. Select drop down icon ![Drop down icon](../customize/media/drop-down-icon.png "drop down icon") to expand the tile such as forms, views, chars, or dashboardss.  
  
2. Select the form, view, chart, or dashboard that you want to edit.

3. On the command bar, select **Remove**.  <br/>
   -OR<br/>
   Select the forms, views, charts, dashboards tile. The **Component** tab shows the corresponding forms, views, charts, or dashboards that are referenced (added) in the app designer. Clear the check boxes for the assets you want to remove from the designer.  
  
### See also  
 [Create a site map for an app](../customize/create-site-map-app.md)   
 [Publish an app](../customize/publish-an-app.md)
