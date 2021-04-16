---
title: Use the main form and its components | Microsoft Docs
description: Know how to use the main form and its components in the unified Interface based apps
keywords: Main forms; Customer service; Customer Service Hub; Dynamics 365 Customer Engagement (on-premises)
author: Mattp123
ms.author: matp
manager: kvivek
ms.date: 02/09/2019
ms.service: crm-online
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.assetid: 43bfface-4dc2-411d-99a1-83e934646989
search.audienceType: 
  - customizer

---
# Use the main form and its components


 
Forms in the Unified Interface based apps provide improved user experience for optimum agent productivity and help maintain context while working on related records. You can see the forms enlisted in the solution explorer. The form type of the new forms is **Main**.

This topic explains how to edit a main form, and add or change various elements of the form.

## Open the form editor

To edit a form or to add or change elements, use the form editor. The form editor lets you edit forms for all the Unified Interface based apps.

Follow the procedures given below to access the form editor: 

> [!NOTE]
> If you create any new solution components in the process of editing the form, the names of the components will use the solution publisher customization prefix for the default solution and these components will only be included in the default solution. If you want any new solution components to be included in a specific unmanaged solution, open the form editor through that unmanaged solution.


### Access the form editor through App designer in Dynamics 365 Customer Engagement (on-premises)

1. Go to **Settings > My Apps**.
2. Select **...** on an app and select **Open in App designer**.
3. Select the down arrow ![Down arrow for app designer](media/down-arrow-app-designer.png)  to expand the tile and see a list of forms. 
4. Select the site map designer button ![sitemap designer](media/site-map-designer.png)corresponding to the form to edit the form in the Form designer.

   ![Form editor in app designer](media/app-designer-forms.png)
 
5. Select **Save** to save the changes and select **Publish** to publish them for use in the app. 

> [!NOTE]
> If you have made any changes to the app, publish them using the app level publish option. See [Publish an app using the app designer](../customize/publish-an-app.md) for more information.

> [!NOTE]
> The webclient Main form is also compatible with the Customer Service Hub and is available to be edited using the App designer.


### Access the form editor through the default solution

1. Open solution explorer.
2. Under **Components**, expand **Entities**, expand the entity you want, and then select **Forms**.
3. In the list of forms, open the form of type **Main**.

### Access the form editor for an unmanaged solution

1. Open solution explorer.
2. Double-click the unmanaged solution you want to work with.
3. Locate the entity with the form you want to edit. If the entity isn’t there, you’ll need to add it.

#### Add an entity to an unmanaged solution

1. Select the **Entities** node and, in the toolbar above the list, select **Add Existing**.
2. In the **Select Solution Components** dialog box, with the **Component Type** selector set to **Entity**, select the entity you want to add and select **OK**.
3. If the **Missing Required Components** dialog box appears, you can select **No, do not include required components** if you don’t intend to export this unmanaged solution to another organization. If you don’t want to include missing required components at this time, you can add them later. You’ll receive notification again if you export this solution in the future.
5. In the solution explorer expand the entity with the form you want to edit and select **Forms**.
6. In the list of forms, open the form of type **Main**.

#### Publish the changes for use in the app

Certain customizations that make changes to the user interface require that they be published before people can use them in the application. To publish your customization, in the solution explorer, select **Publish All Customizations**.

## Form editor user interface

Understand in detail about the form editor user interface, see [Overview of the form editor user interface](../customize/form-editor-user-interface-legacy.md).

## Form properties

To know in detail about the form properties, see [Form properties](../customize/form-properties-legacy.md).

## Visibility options  
 Several types of form elements have the option to be shown or hidden by default. Tabs, sections, and fields all provide this option. Using form scripts or business rules, the visibility of these elements can be controlled to create a dynamic form to provide a user interface that adapts to conditions in the form.  
  
> [!NOTE]
>  Hiding form elements is not a recommended way to enforce security. There are several ways people can view all the elements and data in the form when elements are hidden.  
  
 Rather than designing forms that depend on scripts to control visibility of options, consider whether a business process flow, a dialog, or switching to a different form may be better suited to meet your requirements. If you do use scripts, make sure that any element that might be hidden is hidden by default. Only show it with scripts when your logic calls for it. This way it isn’t displayed in presentations that don’t support scripts.
 > [!NOTE]
> When you use setVisible with the Client API, if a control spans more than one column in a section in the Unified Interface, the control will be hidden but whitespace will not be removed.
  
## Tab properties  

To know in detail about the tab properties, see [Tab properties](../customize/tab-properties-legacy.md).


## Section properties  
 
To know in detail about the section properties, see [Section properties](../customize/section-properties-legacy.md).
  
## Timeline  
 The Timeline shows related activities for a specific entity.  
  
 The following types of activities are supported: Task, appointment, phone call, email, social activity, custom activity.  
  
 The Timeline also shows notes and, system and user posts. It shows those activities that have **Regarding** field set to the entity you’re viewing. For notes, the **Regarding** field isn’t shown to the user; It is implicit when created from the Timeline.  
  
 Each activity that’s shown in the Timeline, will have the same quick actions that are available on the activity’s command bar.  

## Common field properties  

To know in detail about the common field properties, see [Common field properties](../customize/common-field-properties-legacy.md). 
  
## Special field properties  
 All fields have the properties listed in [Common field properties](../customize/common-field-properties-legacy.md), but certain fields have additional properties.  

To know more, see [Special Field Properties](../customize/special-field-properties-legacy.md).

  
## Sub-grid properties  

To know in detail about the sub-grid properties, see [Sub-grid properties](../customize/sub-grid-properties-legacy.md).

## Quick view control properties  

To explore the Quick view control properties, see [Quick view control properties](../customize/quick-view-control-properties-legacy.md).
  
## Web resource properties  

Know in detail about the Web resource properties. Go to [Web resource properties](../customize/web-resource-properties-legacy.md). 
  
## IFRAME properties  

To know more about the IFRAME properties, see [IFRAME properties](../customize/iframe-properties-legacy.md). 
  
## Edit Navigation  
 Navigation within the form allows people to view lists of related records. Each entity relationship has properties to control whether it should be shown. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Navigation Pane Item for Primary Entity ](../customize/create-and-edit-1n-relationships.md#navigation-pane-item-for-primary-entity)
  
 Any entity relationships that are configured to be displayed can be overridden within the form editor.  
  
 For step-by-step instructions, see [Add form navigation for related entities](../customize/add-edit-form-navigation-related-entities.md).
  
 To enable editing navigation you must first select **Navigation** from the **Select** group on the **Home** tab.  
  
 In the **Relationship Explorer** you can filter by 1:N (one-to-many) or N:N (many-to-many) relationships, or view all available relationships. The **Only show unused relationships checkbox** is disabled and selected. So you can only add each relationship one time.  
  
 To add a relationship from the **Relationship Explorer** just double-click it and it will be added below the currently selected relationship in the navigation area. Double-click a relationship in the navigation area and you can change the label on the **Display** tab. On the **Name** tab, you can see information about the relationship. Use the **Edit** button to open the definition of the entity.  
  
 There are five groups in the navigation area. You can drag them to reposition them and double-click them to change the label, but you can’t remove them. These groups are displayed only when there is something in them. If you don’t want a group to appear, just don’t add anything to it.  
  
## Configure event handlers  

To know more about configuring event handlers, see [Configure event handlers](../customize/configure-event-handlers-legacy.md). 
  
## See Also  
 [Create and design forms](../customize/create-design-forms.md)   
 [Create and edit quick create forms](../customize/create-edit-quick-view-forms.md)   
 [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]