---
title: "Overview of the form editor user interface (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "jimholtz"
ms.assetid: 146f8035-4fcd-4572-8e71-4270cd150495
caps.latest.revision: 63
ms.author: "rdubois"
manager: "brycho"
---
# Overview of the form editor user interface

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

 The form editor displays commands in two ribbon tabs: **Home** and **Insert**. For details about the commands available there, see [Home tab](../customize/form-editor-user-interface-legacy.md#BKMK_HOMETab) and [Insert tab](../customize/form-editor-user-interface-legacy.md#BKMK_INSERTTab).  
  
 ![Form editor](../customize/media/crm-itpro-cust-formeditor.PNG "Form editor")  
  
 The body of the form editor is divided into three areas: **Navigation**, **Body**, and **Explorer**.  
  
 **Navigation area**  
 Located on the left side, use the navigation area to control access to related entities or to add links to web resources or URLs to be displayed in the main pane of the form. To edit navigation you must first select the **Navigation** command in the **Select** group of the **Home** tab.  
  
 Forms for [Classic forms](main-form-presentations.md#classic-forms) provide a navigation experience that is visually similar to what you see in the navigation area. Forms for [Updated entities and classic entities](create-design-forms.md#updated-versus-classic-entities) provide navigation options through the navigation bar, but use the same data to control what navigation options are available. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit navigation](../customize/use-the-form-editor-legacy.md)  
  
 **Body area** 
 Located in the center, use the body area to control the layout of the form. You can select and drag form elements to position them. Double-clicking on an element will open the properties for the element.  
  
-   To add a field, select it from the **Field Explorer** and drag it into a section.  
  
-   To add an element that is not a field, select where you want to place it and use the appropriate command from the **Insert** tab add it.  
  
-   To remove an element, select it and use the **Remove** command in the **Edit** group of the **Home** tab.  
  
-   To edit the **Header** or **Footer** for the form you must first select the corresponding command in the **Select** group of the **Home** tab.  
  
 **Explorer area**  
 Located on the right side, the content of the explorer area depends on the context.  
  
 When you select **Body**, **Header**, or **Footer** in the **Select** group of the **Home** tab, you’ll see the **Field Explorer**. Use the **Field Explorer** to drag fields you want to display into a section in the form or within the header or footer. You can include the same field multiple times in a form. Use the **New Field** button as a shortcut to create a new field.  
  
 When you select **Navigation** in the **Select** group of the **Home** tab you’ll see the **Relationship Explorer**. Drag any of the relationships into one of the groups within the navigation area. You cannot add the same relationship twice. Relationships are available based on how they are configured. If you configure a relationship to not display, it won’t display in the **Relationship Explorer**. For information about how to configure default display options for relationships, see [Navigation pane item for primary entity](create-and-edit-1n-relationships.md#navigation-pane-item-for-primary-entity).
  
 You can use the **New 1:N** and **New N:N buttons** as a shortcut to add new entity relationships.  
  
<a name="BKMK_HOMETab"></a>   

## Home tab  
 The **Home** tab displays the commands in the following table.  
  
|Group|Command|Description|  
|-----------|-------------|-----------------|  
|**Save**|**Save** **(Ctrl+S)**|Save the form.|  
||**Save As**|Create a copy of this form with a different name.|  
||**Save and Close**|Save the form and close the form editor.|  
||**Publish**|Publish the form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publishing customizations](getting-started-customization.md#BKMK_PublishingCustomizations)|  
|**Edit**|**Change properties**|Change properties of the selected item in the body.<br /><br /> See the following sections depending on the selected item:<br /><br /> -   [Tab Properties](../customize/tab-properties-legacy.md)<br />-   [Section properties](../customize/section-properties-legacy.md)<br />-   [Common field properties](../customize/common-field-properties-legacy.md)<br />-   [Special field properties](../customize/special-field-properties-legacy.md)<br />-   [Sub-grid properties](../customize/sub-grid-properties-legacy.md)<br />-   [Quick view control properties](../customize/quick-view-control-properties-legacy.md)<br />-   [Web resource properties](../customize/web-resource-properties-legacy.md)<br />-   [iFrame properties](../customize/iframe-properties-legacy.md)<br />-   [Notes control](../customize/notes-control-legacy.md)<br />-   [Configure Bing maps](../customize/configure-bing-maps-legacy.md)|  
||**Remove**|Remove the selected item.|  
||**Undo** **(Ctrl+Z)**|Undo the previous action.|  
||**Redo** **(Ctrl+Y)**|Redo the previous action.|  
|**Select**|**Body**|Edit the main body of the form.|  
||**Header**|Edit the form header.|  
||**Footer**|Edit the form footer.|  
||**Navigation**|Edit the form navigation.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit navigation](../customize/use-the-form-editor-legacy.md)|  
|**Form**|**Business Rules**|View, Edit, or Create new Business Rules with the Business Rules explorer.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create business rules and recommendations](create-business-rules-recommendations-apply-logic-form.md)|  
||**Form Properties**|[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Form Properties](../customize/form-properties-legacy.md)|  
||**Preview**|Preview how the form will look after it is published.<br /><br /> The options are:<br /><br /> **Desktop Client**<br /><br /> - **Create Form**: How the form will appear before a record is saved.<br />- **Update Form**: How a form for an existing record will appear.<br />- **Read-Only Form**: How the form will appear for people who have only read access to a record.<br /><br /> Scripts in the form can be tested but certain scenarios, like checking data values in the `OnLoad` event, can’t be tested because the preview form doesn’t contain data.<br /><br /> **Mobile Client**<br /><br /> These options appear if the form is available on mobile.<br /><br /> - **Tablet (1024 x 768 4:3)**: How the form will appear on tablets.<br /><br /> - **Phone (360 x 640 9:16)**: How the form will appear on phones.<br /><br />**Note:** If you see unexpected results while previewing the mobile form, try clearing the browser cache. Mobile form preview doesn’t work in a browser’s In Private mode. <br /><br /> Mobile preview forms contain data, but the form is blocked for editing. It will always display the first record (oldest) that the current user has access to. If no record is available, it’s possible to create a new one through a command in the preview window.|  
||**Enable Security Roles**|Use this to set which security roles will have access to the forms. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Control access to forms](control-access-forms.md)<br /><br /**Important:** If you create a new form only the System Administrator and System Customizer security roles will have access to the form. You must assign access to other security roles before people in your organization can use it.|  
||**Show Dependencies**|See which solution components depend on this form and which solution components are required by this form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Solution dependencies](solutions-overview.md#BKMK_Dependencies)|  
||**Managed Properties**|The only managed property is **Customizable**. Setting this to false means the form won’t be customizable after you included it in a solution, export that solution as a managed solution, and import that managed solution into a different organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Managed properties](solutions-overview.md#BKMK_ManagedProperties)|  
|**Upgrade**|**Merge Forms**|Use this setting to merge a form from a previous version after you upgrade. This will facilitate adopting new form layouts introduced in this version. The form you bring in will be appended to the bottom of the current form. Use this to combine forms while preserving event handers for form scripts.|  
  
<a name="BKMK_INSERTTab"></a>   

## Insert tab  
 ![Screenshot of insert tab for the form editor](../customize/media/crm-itpro-cust-formeditorinserttab.PNG "Screenshot of insert tab for the form editor")  
  
 The **Insert** tab displays the commands in the following table:  
  
|Group|Command|Description|  
|-----------|-------------|-----------------|  
||**Section**|Add a section to a selected tab. You can choose to include a section with one to four columns.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Section properties](../customize/section-properties-legacy.md)|  
|**3 Tabs**|**Three Columns**|Insert a three-column tab with equal widths.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tab properties](../customize/tab-properties-legacy.md)|  
||**Three Columns**|Insert a three-column tab with a wider middle column.|  
|**2 Tabs**|**Two Columns**|Insert a two-column tab with a wider right column.|  
||**Two Columns**|Insert a two-column tab with a wider left column.|  
||**Two Columns**|Insert a two-column tab with equal width columns.|  
|**1 Tab**|**One Column**|Insert a one-column tab.|  
|**Control**|**Sub-Grid**|Format a sub-grid and insert it into the form.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Sub-grid properties](../customize/sub-grid-properties-legacy.md)|  
||**Spacer**|Insert an empty space.|  
||**Quick View Form**|Insert a Quick View Form.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Quick view control properties](../customize/quick-view-control-properties-legacy.md)|  
||**Web Resource**|Insert a web resource.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Web resource properties](../customize/web-resource-properties-legacy.md)|  
||**iFrame**|Insert an iFrame.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [iFrame properties](../customize/iframe-properties-legacy.md)|  
||**Notes**|Insert a control to view activities, posts, and notes. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Notes control](../customize/notes-control-legacy.md)|  
||**Bing Maps**|Insert a control to show maps in the form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]  [Configure Bing maps](../customize/configure-bing-maps-legacy.md)|  
||**Navigation Link**|Insert a navigation link into the navigation area. This command is disabled unless you select the **Navigation** command in the **Select** group of the **Home** tab. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Navigation link properties](../customize/use-the-form-editor-legacy.md#BKMK_NavigationLinkProperties)|  
||**Timer**|Insert a timer control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Timer control](../customize/timer-control-legacy.md)|  
  
