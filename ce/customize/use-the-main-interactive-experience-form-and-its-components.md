---
title: "Use the Main - Interactive experience forms in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 40d1dd00-651c-4256-83fb-0f790d98526d
caps.latest.revision: 33
ms.author: "anjgup"
manager: "sakudes"
---
# Use the Main - Interactive experience forms and components
Interactive forms reduces users clicks and helps them maintain context while working on related records. You can see the interactive forms listed in the list of other forms in the solution explorer in the Customization area. The form type of interactive forms is *Main - Interactive experience*.  
  
 This topic explains how to edit a Main - Interactive experience form, and add or change various elements of the form.  
  
<a name="BKMK_FormEditor"></a>   
## Open the form editor  
 To edit a form or to add or change elements, use the form editor.  
  
 If you create any new solution components in the process of editing the form, the names of the components will use the solution publisher customization prefix for the default solution and these components will only be included in the default solution. If you want any new solution components to be included in a specific unmanaged solution, open the form editor through that unmanaged solution.  
  
#### Access the form editor through the default solution  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Click **Customize the System** to open the default solution.  
  
3.  Under **Components**, expand **Entities**, expand the entity you want, and then select **Forms**.  
  
4.  In the list of forms, open the form of type **Main  - Interactive experience**.  
  
#### Access the form editor for an unmanaged solution  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Click **Solutions**.  
  
3.  Double-click the unmanaged solution you want to work with.  
  
4.  Locate the entity with the form you want to edit. If the entity isn’t there, you’ll need to add it.  
  
    ###### Add an entity to an unmanaged solution  
  
    1.  Select the **Entities** node and, in the toolbar above the list, click **Add Existing**.  
  
    2.  In the **Select Solution Components** dialog box, with the **Component Type** selector set to **Entity**, select the entity you want to add and click **OK**.  
  
    3.  If the **Missing Required Components** dialog box appears, you can click **No, do not include required components** if you don’t intend to export this unmanaged solution to another organization. If you don’t want to include missing required components at this time, you can add them later. You’ll receive notification again if you export this solution in the future.  
  
5.  In the solution explorer expand the entity with the form you want to edit and select **Forms**.  
  
6.  In the list of forms, open the form of type **Main - Interactive experience**.  
  
<a name="bkmk_Publish"></a>   
## Publish the changes for use in the Customer Service hub or Interactive Service hub  
 Certain customizations that make changes to the user interface require that they be published before people can use them in the application. To publish your customization, in the solution explorer, click **Publish All Customizations**.  
  
 With [!INCLUDE[pn_crm_8_0_1_op](../includes/pn-crm-8-0-1-op.md)] or later, you can improve performance for that first user by clicking the **Prepare Client Customizations** button after publishing your customizations. This prompts [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to prepare the metadata package right then instead of waiting for the first user to start the interactive service hub. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Customization concepts](Customization%20concepts.md)  
  
> [!IMPORTANT]
>  Preparing client customizations may take some time. If you see a message that the browser page has become unresponsive, wait for the page to become responsive, and don't kill it.  
  
<a name="BKMK_FormEditorUI"></a>   
## Form editor user interface  
 The form editor displays commands in two tabs: **Home** and **Insert**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Home tab](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_HOMETab), [Insert tab](../customize/use-the-main-interactive-experience-form-and-its-components.md#bkmk_InsertTab)  
  
 ![Components of interactive forms](../customize/media/crm-itpro-cust-v8-interactive-form-editor.png "Components of interactive forms")  
  
 The form editor is divided into three areas: **Navigation**, **Body**, and **Explorer**.  
  
 **Navigation**  
 Located on the left side, use the navigation area to control access to related entities or to add links to URLs to be displayed in the main pane of the form. To edit navigation you must first select the **Navigation** command in the **Select** group of the **Home** tab.  
  
 Interactive forms provide navigation options through the navigation bar, but use the same data in the navigation area to control what navigation options are available. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit Navigation](../customize/use-the-form-editor.md#BKMK_Navigation)  
  
 **Body**  
 Located in the center, use the body area to control the layout of the form. You can select and drag form elements to position them. Double-clicking on an element will open the properties for the element.  
  
-   By default, for the Case, Contact, and Account interactive forms, the first section under the **Summary** tab shows the account or contact card form of type **Quick View**. For custom entities that are enabled for interactive experience, this section is not available by default. You can insert a new section and a quick view form in it. The card form shows a maximum of five fields. Other than fields, it isn’t possible to show other controls in the Blue tile even if the quick view form contains it.  
  
    > [!NOTE]
    >  To preserve the card format (as shown in the following image), we recommend that you do not move the quick view form to any other section on the form.  
  
 ![Customer card on interactive service hub case form](../customize/media/crm-ua-v8-case-form-customer-card.png "Customer card on interactive service hub case form")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick view forms](Create%20and%20edit%20quick%20view%20forms.md)  
  
-   To add a field, select it from the **Field Explorer** and drag it into a section.  
  
-   To add an element that’s not a field, select where you want to place it and use the appropriate command from the **Insert** tab add it.  
  
-   To remove an element, select it and use the **Remove** command in the **Edit** group of the **Home** tab.  
  
-   To edit the **Header** or **Footer** for the form you must first select the corresponding command in the **Select** group of the **Home** tab. The fields in the header and footer are shown below the customer card (the Blue tile) in the runtime.  
  
 **Explorer**  
 Located on the right side, the content of the explorer area depends on the context.  
  
 When you select **Body**, **Header**, or **Footer** in the **Select** group of the **Home** tab, you’ll see the **Field Explorer**. Use the **Field Explorer** to drag fields you want to display into a section in the form or within the header or footer. You can include the same field multiple times in a form. Use the **New Field** button as a shortcut to create a new field.  
  
 When you select **Navigation** in the **Select** group of the **Home** tab you’ll see the **Relationship Explorer**. Drag any of the relationships into one of the groups within the navigation area. You cannot add the same relationship twice. Relationships are available based on how they are configured. If you configure a relationship to not display, it won’t display in the **Relationship Explorer**. For information about how to configure default display options for relationships, see [Navigation Pane Item for Primary Entity](Create%20and%20edit%20entity%20relationships.md#BKMK_NavigationPaneOptions).  
  
 You can use the **New 1:N** and **New N:N buttons** as a shortcut to add new entity relationships.  
  
<a name="BKMK_HOMETab"></a>   
### Home tab  
 The **Home** tab displays the commands listed in the following table.  
  
|Group|Command|Description|  
|-----------|-------------|-----------------|  
|**Save**|**Save** **(Ctrl+S)**|Save the form.|  
||**Save As**|Create a copy of this form with a different name.|  
||**Save and Close**|Save the form and close the form editor.|  
||**Publish**|Publish the form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publishing customizations](Customization%20concepts.md#BKMK_PublishingCustomizations)|  
|**Edit**|**Change properties**|Change properties of the selected item in the body.<br /><br /> See the following sections depending on the selected item:<br /><br /> -   [Tab Properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_TabProperties)<br />-   [Section properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_SectionProperties)<br />-   [common Field properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_FieldProperties)<br />-   [Special field properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_SpecialFieldProperties)<br />-   [Sub-grid properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_SubGridProperties)<br />-   [Quick view control properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_QuickViewFormProperties)|  
||**Remove**|Remove the selected item.|  
||**Undo** **(Ctrl+Z)**|Undo the previous action.|  
||**Redo** **(Ctrl+Y)**|Redo the previous action.|  
|**Select**|**Body**|Edit the main body of the form.|  
||**Header**|Edit the form header.|  
||**Footer**|Edit the form footer.|  
||**Navigation**|Edit the form navigation.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit navigation](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_Navigation)|  
|**Form**|**Business Rules**|View, edit, or create new business rules with the Business Rules explorer. **Note:**  For the interactive forms, only the “Entity” and “All Forms” scope is supported. <br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit business rules](Create%20and%20edit%20business%20rules.md)|  
||**Form Properties**|[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Form properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_FormProperties)|  
||**Enable Security Roles**|Use this to set which security roles will have access to the forms. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Control access to forms](Create%20and%20design%20forms.md#BKMK_ControlAccessToForms)<br /><br />**Important:**  If you create a new form, only the System Administrator and System Customizer security roles will have access to the form. You must assign access to other security roles before people in your organization can use it.|  
||**Show Dependencies**|See which solution components depend on this form and which solution components are required by this form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Solution dependencies](Customization%20concepts.md#BKMK_Dependencies)|  
||**Managed Properties**|The only managed property is **Customizable**. Setting this to false means the form won’t be customizable after you included it in a solution, export that solution as a managed solution, and import that managed solution into a different organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Managed properties](Customization%20concepts.md#BKMK_ManagedProperties)|  
  
<a name="bkmk_InsertTab"></a>   
### Insert tab  
 ![Screenshot of insert tab for the form editor](../customize/media/crm-itpro-cust-formeditorinserttab.PNG "Screenshot of insert tab for the form editor")  
  
 The **Insert** tab displays the commands in the following table:  
  
|Group|Command|Description|  
|-----------|-------------|-----------------|  
||**Section**|Add a section to a selected tab. You can include a section with one to four columns.<br /><br /> You can also insert a Reference panel in the interactive forms. Reference panel is also added as a section to the Main - Interactive experience form. By default the Reference panel section is added to the Case, Account, Contact and custom entity forms.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Section properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_SectionProperties)|  
|**3 Tabs**|**Three Columns**|Insert a three-column tab with equal widths.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tab properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_TabProperties)|  
||**Three Columns**|Insert a three-column tab with a wider middle column.|  
|**2 Tabs**|**Two Columns**|Insert a two-column tab with a wider right column.|  
||**Two Columns**|Insert a two-column tab with a wider left column.|  
||**Two Columns**|Insert a two-column tab with equal width columns.|  
|**1 Tab**|**One Column**|Insert a one-column tab.|  
|**Control**|**Sub-Grid**|Format a sub-grid and insert it into the form.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Sub-grid properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_SubGridProperties)|  
||**Spacer**|Insert an empty space.|  
||**Quick View Form**|Insert a Quick View Form.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Quick view control properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_QuickViewFormProperties)|  
||**Web Resource**|Insert a web resource to embed content from other locations in one page.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Web Resource properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_QuickViewFormProperties)|  
||**Interaction Wall**|Insert an interaction wall control (timeline) in the form. This control shows the timeline of activities related to the entity on a form.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Interaction wall control properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_InteractionWall)|  
||**Knowledge Base Search**|Insert a search control that users can use to search knowledge articles. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Knowledge Article Search control](Add%20the%20Knowledge%20Base%20Search%20control%20to%20Microsoft%20Dynamics%20365%20forms.md)|  
||||  
  
> [!NOTE]
>  The following components aren’t supported in the interactive forms:  
>   
> - [!INCLUDE[pn_bing_maps](../includes/pn-bing-maps.md)]  
> - [!INCLUDE[pn_yammer](../includes/pn-yammer.md)]  
> - Activity Feeds  
  
<a name="BKMK_FormProperties"></a>   
## Form properties  
 The properties of the form are listed in the following table.  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**Events**|**Form Libraries**|Manage which [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources are available in the form and the order in which they will be loaded.|  
||**Event Handers**|Configure which [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] functions from the Form Libraries will run for the `OnLoad` and `OnSave` form events and the order in which they’ll be run.|  
|**Display**|**Form Name**|Enter a name that will be meaningful to people. This name will be shown to people when they use the form. If they can use multiple forms configured for the entity they will use this name to differentiate between available forms.|  
||**Description**|Enter a description that explains how this form is different from other main forms. This description is only shown in the list of forms for an entity in the solution explorer.|  
|**Parameters**|**Parameters**|Each form can be opened with code using a URL. The URL may also contain data that can be passed to the form using a query string that is appended to the URL. Query strings look like this example:<br />`?p_firstName=Jim&p_lastName=Daly`<br /><br /> As a security measure, forms don’t accept any unknown query string parameters. Use this parameters list to specify parameters this form should accept to support code that will pass data to the forms using a query string.<br /><br /> The name and type of data will be checked and the form won’t open if invalid query string parameters are passed to it. For more information see the topic [Open forms, views, dialogs and reports with a URL](http://go.microsoft.com/fwlink/p/?LinkId=317690) in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)].|  
|**Non-Event Dependencies**|**Dependent Fields**|Each event handler has a similar **Dependent Fields** property so that any fields that are needed by the script can be registered. Anyone who tries to remove the dependent fields will not be able to.<br /><br /> Some scripts operate on the form but aren’t configured in an event handler. Scripts that are initiated from the command bar don’t have a place where dependent fields can be registered. This form property provides a place for dependent fields for those scripts to be registered.|  
  
<a name="BKMK_VisibilityOptions"></a>   
## Visibility options  
 Several types of form elements have the option to be shown or hidden by default. Tabs, sections, and fields all provide this option. Using form scripts or business rules, the visibility of these elements can be controlled to create a dynamic form to provide a user interface that adapts to conditions in the form.  
  
> [!NOTE]
>  Hiding form elements is not a recommended way to enforce security. There are several ways people can view all the elements and data in the form when elements are hidden.  
  
 Rather than designing forms that depend on scripts to control visibility of options, consider whether a business process flow, a dialog, or switching to a different form may be better suited to meet your requirements. If you do use scripts, make sure that any element that might be hidden is hidden by default. Only show it with scripts when your logic calls for it. This way it isn’t displayed in presentations that don’t support scripts.  
  
<a name="BKMK_TabProperties"></a>   
## Tab properties  
 In the body of the form tabs provide a way to organize fields. Each tab that you create appears horizontally at the top of an entity form in the interactive service hub. In the runtime, additional tabs open as a flyout.  
  
 ![Case form tabs in the interactive service hub](../customize/media/crm-ua-v8-case-form-tabs.png "Case form tabs in the interactive service hub")  
  
 Tabs have a label that can be displayed. If the label is displayed tabs can be expanded or collapsed to show or hide their content by choosing the label.  
  
 Tabs contain up to three columns and the width of each column can be set to a percentage of the total with. When you create a new tab, each column is pre-populated with a section.  
  
 The following table shows properties that may be set for tabs in the form.  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**Display**|**Name**|**Required**: The unique name for the tab that is used when referencing it in scripts. The name can contain only alphanumeric characters and underscores.|  
||**Label**|**Required**: The localizable label for the tab visible to users.|  
||**Visibility**|Specify whether the tab should be visible by default in the runtime.|  
|**Formatting**|**Layout**|Tabs may have up to three columns. Use these options to set the number of tabs and what percentage of the total width they should fill.|  
  
<a name="BKMK_SectionProperties"></a>   
## Section properties  
 A section occupies the space available in a tab column. Sections have a label that can be displayed.  
  
 Sections can have up to four columns and includes options for displaying how labels for fields in the section are displayed.  
  
 A new type of section called “reference panel” can also be added. A reference panel is a single column section. You can insert sub grids, quick view control, or a Knowledge Base Search control inside a reference panel section. Each control that you added in the reference panel appears as a vertical tab within the reference panel at the runtime. You can drag and drop the various controls within the reference panel section. The default tab at the runtime is the first control added in the reference panel. The other tabs appear in the order in which they are added in the form editor. To delete a tab, use the Delete key on your keyboard.  
  
 When you insert a reference panel, by default it’s added as a last section in the tab. You can add only one reference panel per form.  
  
> [!IMPORTANT]
>  By default, the reference panel section is locked in the out-of-the-box forms: Case, Account, and Contact. To remove it or change it, you must unlock it.  
  
 Headers and footers are similar to sections but can’t be removed. If they don’t contain anything they aren’t shown.  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**Display**|**Name**|**Required**: The unique name for the section that is used when referencing it in scripts. The name can contain only alphanumeric characters and underscores.|  
||**Label**|**Required**: The localizable label for the section visible to users.|  
||**Show the label of this section on the form**|Sections are frequently used without labels to control formatting of the fields within them.|  
||**Visibility**|Showing the section is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility Options](../customize/use-the-form-editor.md#BKMK_VisibilityOptions)|  
||**Lock the section on the form**|This will prevent the section from accidentally being removed and prevents people from removing the contents.<br /><br /> Removing a section will not only remove the section, but also any fields within it.<br /><br /> Someone wanting to remove this section would need to change this setting before removing it.|  
|**Formatting**|**Layout Height**|Set the layout height in terms of number of rows.|  
  
<a name="BKMK_InteractionWall"></a>   
## Interaction Wall  
 The interaction wall (or timeline) shows related activities for a specific entity.  
  
 The following types of activities are supported: Task, appointment, phone call, email, social activity, custom activity.  
  
 The interaction wall also shows notes and system posts. It shows those activities that have their **Regarding** field set to the entity you’re viewing. For notes, the **Regarding** field isn’t shown to the user; It is implicit when created from the interaction wall.  
  
 Each activity that’s shown in the interaction wall will have the same quick actions that are available on the activity’s command bar.  
  
> [!NOTE]
>  It is not possible to create a new custom activity by using the ![Add button](../customize/media/add-button-dynamics-crm-for-outlook.gif "Add button") action on the interaction wall.  
  
<a name="BKMK_FieldProperties"></a>   
## Common field properties  
 Fields display controls people use to view or edit data in an entity record. Fields can be formatted to occupy up to four columns within a section.  
  
 The following table describes properties that all fields have. Certain types of fields have special properties. These are described in [Special field properties](../customize/use-the-form-editor.md#BKMK_SpecialFieldProperties).  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**Display**|**Label**|**Required**: By default the label will match the display name of the field. You can override that name for the form by entering a different label here.|  
||**Display label on the form**|You can choose not to display the label at all.|  
||**Field is read-only**|You can specify that the field is not editable. Using form scripts, you can change this to enable or disable editing based on criteria evaluated in the script.|  
||**Lock the field on the form**|This prevents the field from being removed from the form accidentally. This also prevents any configuration you have applied to the field, such as event handlers, from being cleared if the field is removed. To remove this field, a customizer would need to clear this setting first.|  
||**Visible by default**|Showing the field is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility Options](../customize/use-the-form-editor.md#BKMK_VisibilityOptions)|  
|**Formatting**|**Select the number of columns the control occupies**|When the section containing the fields has more than one column you can set the field to occupy up to the number of columns that the section has.|  
|**Details**|**Display Name**, **Name**, and **Description**|These read-only fields are for reference. Click the **Edit** button for convenient access to the field definition if you want to edit it.<br /><br /> Each instance of a field in the form has a name property so that they can be referenced in form scripts, but this name is managed by the application. The first instance of the field is the name of the field specified when it was created. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Creating and editing fields](Create%20and%20edit%20fields.md#BKMK_CreatingAndEditngFields)<br /><br /> For each additional time that a field is included in a form, the name appends a number starting with 1 to the end. So if the field name is “new_cost,” the first instance is “new_cost,” the second is “new_cost1,” and so on for each instance of the field in the form.<br /><br />**Note:** The field **Description** value provides tooltip text for the field when people place their cursor over it.|  
|**Events**|**Form Libraries**|Specify any [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources that will be used in the field `OnChange` event handler.<br /><br /> See the SDK [Form Events Reference : Field OnChange Event](http://go.microsoft.com/fwlink/p/?LinkId=317936)|  
||**Event Handlers**|Configure the functions from the form libraries that should be called for the field `OnChange` event. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Event Handlers](../customize/use-the-form-editor.md#BKMK_EventHandlers)|  
|**Business Rules**|**Business Rules**|View and manage any business rules that reference this field. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit business rules](Create%20and%20edit%20business%20rules.md)|  
  
<a name="BKMK_SpecialFieldProperties"></a>   
## Special field properties  
 All fields have the properties listed in [Common field properties](../customize/use-the-form-editor.md#BKMK_FieldProperties), but certain fields have additional properties.  
  
<a name="BKMK_LookupFieldProperties"></a>   
### Lookup field properties  
 Two sections on the Display tab have relevant for lookup fields.  
  
 ![Set properties for lookup field](../customize/media/crm-ua-v8-1-lookup-properties.png "Set properties for lookup field")  
  
> [!NOTE]
>  The options described in the table below are available only for single-entity lookup fields.  
  
|Section|Property|Description|  
|-------------|--------------|-----------------|  
|**Related Records Filtering**|**Only show records where**|When this is enabled, the records that display when users search for a record will have additional filtering applied. This helps provide more relevant searches when setting the value of the lookup.<br /><br /> By default, this is turned off.<br /><br /> The relationship combinations that are possible when you filter related records are listed in the Possible Relationship Combinations table listed below.<br /><br /> The first list is populated with all the potential relationships you can use to filter this lookup. Click one.<br /><br /> The second list is then populated with all relationships that connect the related entity (selected in first list) to the target entity. Click one.<br /><br /> Select the **Allow users to turn off filter** check box to give users the option to turn off the filter you define here.<br /><br /> When users click the **Look Up More Records** option while setting the value for a lookup, they see this dialog box.<br /><br /> ![Look Up Records dialog box](../customize/media/crm-ua-v-8-1-look-up-more-records.png "Look Up Records dialog box")<br /><br /> If you’ve selected the **Allow users to turn off filter** option while configuring the lookup field, users will see the check box to turn off the filter.  This makes it possible for them to see a wider range of records. If you want to make sure that users only see a limited range of records defined by this filter, clear the **Allow users to turn off filter** check box.|  
|**Additional Properties**|**Display Search Box in lookup dialog**|You can choose not to display the search box in the lookup dialog.|  
||**Default View**|This view iis used to filter the results of the inline search and set the default view shown in the lookup dialog when users click the **Look Up More Records** option.<br /><br /> The default view also controls which fields are included in the inline lookup.<br /><br /> ![Inline lookup in the interactive service hub](../customize/media/crm-ua-v-8-1-inline-lookup-in-interactive-service-hub.png "Inline lookup in the interactive service hub")<br /><br /> For lookups that only allow selection of a single entity type, the fields displayed in the inline lookup are set to be the first two fields included in the default view. In this example, **Main Phone** and **Email** are the first two columns in the default view configured for an account lookup.<br /><br /> For system lookups that allow for multiple entity types, the first two columns of the entity lookup view are shown.|  
||**View Selector**|You can choose from three options:<br /><br /> - **Off**: Don’t allow users to choose a different view.<br />- **Show All Views**: All views are available.<br />- **Show Selected Views**: When you choose this option you can use the Ctrl key and your cursor to choose which views to show. The Lookup view for the entity can’t be de-selected.|  
  
 **Possible Relationship Combinations**  
  
|First list relationship|Second list relationship|Available?|  
|-----------------------------|------------------------------|----------------|  
|N:1|1:N|Yes|  
|N:1|N:1|Yes|  
|N:1|N:N|Yes|  
|1:N|1:N|Yes|  
|1:N|N:1|No|  
|1:N|N:N|No|  
|N:N|1:N|Yes|  
|N:N|N:1|No|  
|N:N|N:N|No|  
  
<a name="BKMK_TwoOptionProperties"></a>   
### Two option field properties  
 On the formatting tab, two option fields have the following formatting options  
  
- **Two radio buttons**: Two labeled controls with labels. Only one may be selected.  
  
- **Checkbox**: A single check box to set the true value, otherwise false.  
  
- **List**: A drop-down list containing both values.  
  
<a name="BKMK_MultipleLinesOfTextProperties"></a>   
### Multiple lines of text field properties  
 Multiple lines of text and single line of text fields that use the `Text Area` format have a **Row Layout** property. With this property you can specify a value for **Number of Rows** or select **Automatically expand to use available space**. This property is available in the **Formatting** tab.  
  
<a name="BKMK_SubGridProperties"></a>   
## Sub-grid properties  
 You can configure a sub-grid to display a list of records or a chart. Select **Show Chart Only** on the **Display** tab to show a chart instead of a list.  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**Display**|**Tab Icon**|Click an icon that will be used for the tab. The icons are added as web resources in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. This option is only available when you’re adding a sub-grid to a reference panel.|  
||**Name**|**Required**: The unique name for the sub-grid that is used when referencing it in scripts. The name can contain only alphanumeric characters and underscores.|  
||**Label**|**Required**: The localizable label for the sub-grid visible to users.|  
||**Display label on the Form**|Whether the label should be displayed on the form. This is required if you enable **Display Search Box**.|  
||**Records**|Click from two options:<br /><br /> - **Only Related Records**: The sub-grid displays only records related to the current record.<br />- **All Record Types**: Sub-grid will display records filtered only by the default view or, if the view selector is enabled, any views the user clicks.<br /><br /> The option you click affects the behavior of the show list control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Show list behavior](../customize/use-the-form-editor.md#BKMK_ShowListControlBehavior)|  
||**Entity**|Depending on the option you click for **Records**, this list displays either:<br /><br /> - **Only Related Records**: A list of entities that are related to this entity with the name of the lookup field on that entity which defines the relationship in parentheses.<br />- **All Record Types**: A list of all entities.|  
||**Default View**|Click the view that will be applied by default. If you don’t enable any other views using the **View Selector** property. This will be the only view.<br /><br /> Use the **Edit** button to open the default view for editing. Use the **New** button to create a new view to use for this sub-grid.|  
||**Display Search Box**|Display the search box. When this option is chosen the **Display Label on the Form** option is required.|  
||**View Selector**|You have three options:<br /><br /> - **Off**: Only the default view can be used.<br />- **Show All Views**: Allow people to click any view.<br />- **Show Selected Views**: Use the Ctrl key with your cursor to select which of the available views to show.|  
|**Formatting**|**Layout**|**Select the number of columns the control occupies**.<br /><br /> When the section containing the sub-grid has more than one column you can set the field to occupy up to the number of columns that the section has.|  
||**Row Layout**|**Number of Rows** will determine how many records are shown on a page of a sub-grid.<br /><br /> If **Automatically expand to use available space** is chosen the form will allow space for two records and will expand the space as the number of records increases. If the number exceeds the **Number of Rows**, people can navigate to additional pages to view the records.<br /><br /> If **Automatically expand to use available space** is not chosen, the form will provide space for the number of records defined by **Number of Rows** and people can navigate to additional pages to view any additional records.|  
  
<a name="BKMK_ShowListControlBehavior"></a>   
### Show list behavior  
 When displaying a list in forms, each sub-grid displays the **Open View** button ![Open view button](../customize/media/crm-itpro-cust-openview.PNG "Open view button") in the top right corner when the entity is also displayed as one of the entities included in the navigation area of the form editor. Click this button to open the view. The behavior changes depending on the option chosen for the **Records** property.  
  
 When you select **Only Related Records**, the view opens using one of the associated views in the same window. To return to the form, use the back button or click the current record primary name value in the navigation bar.  
  
 When you select **All Record Types**, the view opens in a new window.  
  
<a name="BKMK_AddRecordBehavior"></a>   
### Add record behavior  
 When displaying a list in forms, each sub-grid displays the **Add record** button ![Add button](../customize/media/crm-itpro-cust-subgridadd.PNG "Add button") in the top right side of the sub-grid. Click this button to add a record. This behavior changes depending on the option chosen for the **Records** property and if the lookup is for activity records.  
  
 When you select **Only Related Records**, the default behavior is the behavior to add existing records. People see an in-line lookup to search for an existing record first. This helps prevent creating duplicate records.  If they can’t find an existing record, they can click the **New** option. When a new record is created, any of the field mappings defined in the relationship are applied. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Mapping entity fields](Create%20and%20edit%20entity%20relationships.md#BKMK_mappingEntityFields)  
  
 When you select **All Record Types** the default behavior is to add a new record. The quick create form is shown if the target entity has one. If not, the default entity main form is shown.  
  
 If the sub-grid displays activities, people will first need to click the type of activity and then they will see the “add new record” behavior.  
  
<a name="BKMK_SubgridDeleteRecord"></a>   
### Delete record behavior  
 When you select a record in a sub-grid, the **Delete** button ![Sublist delete icon](../customize/media/crm-itpro-cust-subgriddelete.PNG "Sublist delete icon") appears on the right side of the row. The behavior of this delete action is different depending on the type of relationship with the current entity.  
  
 When the sub-grid uses a 1:N (one-to-many) relationship, the normal record delete behavior is to show a confirmation dialog before deleting the record.  
  
 When the sub-grid uses a N:N (many-to-many) relationship, the record in the relationship (or intersect) entity relating to two records is deleted without a confirmation and the record will no longer be displayed in the sub-grid. But the record that was displayed is not deleted.  
  
<a name="BKMK_QuickViewFormProperties"></a>   
## Quick view control properties  
 A quick view control displays data from a record that is selected in a lookup on the form. The data displayed in the control is defined using a quick view form. The data displayed is not editable, but when the primary field is included in the quick view form, it becomes a link to open the related record. The out-of-the-box quick view forms specifically created for the reference panel are also used to show records of related entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick view forms](Create%20and%20edit%20quick%20view%20forms.md)  
  
|Property|Description|  
|--------------|-----------------|  
|**Tab icon**|Select an icon to use for the vertical tabs. You can use images as web resources. This option is available only when you’re inserting a quick view control to a Reference Panel section.|  
|**Name**|**Required**: The unique name for the quick view form that is used when referencing it in scripts.|  
|**Label**|**Required**: A label to display for the quick view form.|  
|**Display label on the Form**|Displays the label on the form.|  
|**Lookup Field**|Click one of the lookup fields included in the form.|  
|**Related entity**|This value depends on the **Lookup Field** you click. It is usually the primary entity for the 1:N entity relationship for the lookup.<br /><br /> If the entity includes a **Potential Customer** lookup that can accept either an account or contact, in the **Quick View Form** field you can click a quick view form for both account and contact by changing this value and then choosing another quick view form.|  
|**Quick View Form**|If the **Related entity** has any quick view forms you can select them here. Otherwise, click **New** to create one.<br /><br /> Click **Edit** to change the selected quick view form.|  
  
<a name="BKMK_WebResourceProperties"></a>   
## Web resource properties  
 You can add or edit web resources on a form to make it more appealing or useful to users.  
  
> [!NOTE]
> - You can only add web resources of type HTML to a form of type Main - Interactive experience. [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources can be added by using the **Form Properties** button in the **Form** group on  the **Home** tab. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Form Properties](../customize/use-the-main-interactive-experience-form-and-its-components.md#BKMK_FormProperties)  
> - You can't add a web resource in a form header or footer.  
  
 For step-by-step instructions, see [Add or edit a form web resource](http://go.microsoft.com/fwlink/p/?LinkId=317724).  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**General**|**web resource**|**Required**: The HTML web resource that you want.|  
||**Name**|**Required**: A unique name for the field. The name can contain only alphanumeric characters and underscores.|  
||**Label**|**Required**: A label to display for the web resource.|  
||**Visible by default**|Showing the web resource is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility Options](../customize/use-the-form-editor.md#BKMK_VisibilityOptions)|  
||**Custom Parameter**|A custom value to pass as the `data` query string parameter. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Pass parameters to web resources](../customize/use-the-form-editor.md#BKMK_PassingParametersToWebResource)|  
||**Restrict cross-frame scripting, where supported**.|When pages exist on different domains you may want to prevent them from accessing the content of your form pages. Web resources are always in the same domain, so this should not be an issue with web resources.|  
||**Pass record object-type code and unique identifiers as parameters**|Data about the organization, user, and the record can be passed to the web resource so it can adapt to organization settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]  [Pass parameters to web resources](../customize/use-the-form-editor.md#BKMK_PassingParametersToWebResource)|  
|**Formatting**|**Select the number of columns the control occupies**|When the section containing the web resource has more than one column you can set the field to occupy up to the number of columns that the section has.|  
||**Select the number of rows the control occupies**|You can control the height of the web resource by specifying a number of rows.|  
||**Automatically expand to use available space**|You can allow the web resource height to expand to available space.|  
||**Select the scrolling type for the IFRAME**|An HTML web resource is added to the form using an IFRAME.<br /><br /> - **As Necessary**: Show scrollbars when the size of the web resource is larger than the available.<br />- **Always**: Always show scrollbars.<br />- **Never**:  Never show scrollbars.|  
||**Display border**|Display a border around the web resource.|  
|**Dependencies**|**Dependent fields**|A web resource may interact with fields in the form using script. If a field is removed from the form the script in the web resource may break. Add any fields referenced by scripts in the web resource to the **Dependent fields** so that they cannot be removed accidentally.|  
  
<a name="BKMK_PassingParametersToWebResource"></a>   
### Pass parameters to web resources  
 An HTML web resource can accept parameters to be passed as query string parameters.  
  
 Information about the record can be passed by enabling the **Pass record object-type code and unique identifiers as parameters** option. If information is typed into the **Custom Parameter(data)** field it will be passed using the data parameter. The values passed are:  
  
|Parameter|Description|  
|---------------|-----------------|  
|`data`|This parameter is only passed when text is provided for **Custom Parameter(data)**.|  
|`orglcid`|The Organization default language LCID.|  
|`orgname`|The name of the organization.|  
|`userlcid`|The user’s preferred language LCID|  
|`type`|The entity type code. This value can be different for custom entities in different organizations. Use entity type name instead.|  
|`typename`|The entity type name.|  
|`id`|The id value of the record. This parameter has no value until the entity record is saved.|  
  
 Any other parameters are not allowed and the web resource will not open if other parameters are used. If you need to pass multiple values, the data parameter can be overloaded to include more parameters within it. See the SDK [Sample: Pass multiple values to a web resource through the data parameter](http://go.microsoft.com/fwlink/p/?LinkId=317727)  
  
<a name="BKMK_IFRAMEProperties"></a>   
## IFRAME properties  
 You can add IFRAMEs to a form to integrate content from another website within a form.  
  
> [!NOTE]
> - You can't add an IFRAME in a form header or footer.  
> - [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] forms are not designed to be displayed within IFRAMEs.  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**General**|**Name**|**Required**: A unique name for the IFRAME. The name can contain only alphanumeric characters and underscores.|  
||**URL**|**Required**: The URL for the page to display in the IFRAME.<br /><br />**Important:** <ul><li>For [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], use a URL with HTTPS protocol.</li><li>For [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on-premises, if [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] domain is HTTPS, use a URL with HTTPS protocol.     If [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] domain is HTTP, use a URL with  HTTP protocol.</li></ul>|  
||**Pass record object-type code and unique identifiers as parameters**|Data about the organization, user, and the record can be passed to the IFRAME. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Pass parameters to IFRAMES](../customize/use-the-form-editor.md#BKMK_PassParametersToIFRAMEs)|  
||**Label**|**Required**: A label to display for the IFRAME.|  
||**Display label on the Form**|Whether the label should be displayed.|  
||**Restrict cross-frame scripting, where supported**|It is considered a security risk to allow pages from a different web site to interact with the Microsoft Dynamics 365 application using scripts. Use this option to restrict cross frame scripting for pages you do not have control over.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Select whether to restrict cross-frame scripting](http://go.microsoft.com/fwlink/p/?LinkId=317731)|  
||**Visible by default**|Showing the IFRAME is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility Options](../customize/use-the-form-editor.md#BKMK_VisibilityOptions)|  
|**Formatting**|**Select the number of columns the control occupies**|When the section containing the IFRAME has more than one column you can set the field to occupy up to the number of columns that the section has.|  
||**Select the number of rows the control occupies**|You can control the height of the IFRAME by specifying a number of rows the control occupies.|  
||**Automatically expand to use available space**|Instead of setting the height by a number of rows, you can allow the IFRAME height to expand to available space.|  
||**Select the scrolling type for the IFRAME**|You have three options:<br /><br /> - **As Necessary**: Show scrollbars when the size of the IFRAME is larger than the available space.<br />- **Always**: Always show scrollbars.<br />- **Never**:  Never show scrollbars.|  
||**Display border**|Display a border around the IFRAME.|  
|**Dependencies**|**Dependent fields**|An IFRAME may interact with fields in the form using script. If a field is removed from the form the script in the IFRAME may break. Add any fields referenced by scripts in the IFRAMES to the **Dependent fields** so that they cannot be removed accidentally.|  
  
<a name="BKMK_PassParametersToIFRAMEs"></a>   
### Pass parameters to IFRAMES  
 Information about the record can be passed by enabling the **Pass record object-type code and unique identifiers as parameters** option. The values passed are:  
  
|Parameter|Description|  
|---------------|-----------------|  
|`orglcid`|The Organization default language LCID.|  
|`orgname`|The name of the organization.|  
|`userlcid`|The user’s preferred language LCID|  
|`type`|The entity type code. This value can be different for custom entities in different organizations. Use `typename` instead.|  
|`typename`|The entity type name.|  
|`id`|The id value of the record. this parameter has no value until the entity record is saved.|  
  
<a name="BKMK_Navigation"></a>   
## Edit Navigation  
 Navigation within the form allows people to view lists of related records. Each entity relationship has properties to control whether it should be shown. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Navigation pane item for primary entity](Create%20and%20edit%20entity%20relationships.md#BKMK_NavigationPaneOptions)  
  
 Any entity relationships that are configured to be displayed can be overridden within the form editor.  
  
 For step-by-step instructions, see [Add or edit form navigation for related entities](http://go.microsoft.com/fwlink/p/?LinkId=317998)  
  
 To enable editing navigation you must first select **Navigation** from the **Select** group on the **Home** tab.  
  
 In the **Relationship Explorer** you can filter by 1:N (one-to-many) or N:N (many-to-many) relationships, or view all available relationships. The **Only show unused relationships checkbox** is disabled and selected. So you can only add each relationship one time.  
  
 To add a relationship from the **Relationship Explorer** just double-click it and it will be added below the currently selected relationship in the navigation area. Double-click a relationship in the navigation area and you can change the label on the **Display** tab. On the **Name** tab, you can see information about the relationship. Use the **Edit** button to open the definition of the entity.  
  
 There are five groups in the navigation area. You can drag them to reposition them and double-click them to change the label, but you can’t remove them. These groups are displayed only when there is something in them. If you don’t want a group to appear, just don’t add anything to it.  
  
<a name="BKMK_EventHandlers"></a>   
## Configure event handlers  
 Form event handlers can be configured for the following areas in a form.  
  
|Element|Event|Description|  
|-------------|-----------|-----------------|  
|Form|`OnLoad`|Occurs when the form loads.|  
||`OnSave`|Occurs when data is saved.|  
|Tab|`TabStateChange`|Occurs when the tab is expanded or collapsed.|  
|Field|`OnChange`|Occurs when data in the field changes and the control loses focus.|  
  
 An event handler consists of a reference to a [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resource and a function defined within that web resource that will execute when the event occurs. Each element can have up to 50 separate event handlers configured.  
  
> [!IMPORTANT]
>  Configuring an event handler incorrectly can result in script errors that may cause the form to fail to load or function correctly. If you are not the developer of the script, make sure you understand exactly what configuration options the script requires.  
>   
>  Be sure to only configure a script event handler using a library that comes from a source you trust. Scripts can be used to perform any action a user might perform and a poorly written script can significantly damage the performance of a form.  
>   
>  After you configure an event handler, always test it to verify it’s working correctly.  
  
#### To configure an event handler  
  
1.  In the form editor, select the element with the event you want to configure a handler for.  
  
2.  On the [Home tab](../customize/use-the-form-editor.md#BKMK_HOMETab), in the **Edit** group, click **Change Properties** or simply double-click the element.  
  
3.  In the element properties dialog box, select the **Events** tab.  
  
4.  Expand the **Form Libraries** area. If the library containing the function you want to set as the event handler isn’t already listed, add the library. To add a form library to an event handler: 
    
    1.  In the **Form Libraries** section of the **Event List**, click **Add**.  
  
    2.  Locate the [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resource in the list of available web resources. Select it and click **Add**.  
  
         If the [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resource you need doesn’t exist, click **New** to create a new web resource form. To create a JavaScript web resource:  
    
        1.  In the web resource form, set the properties as listed in the following table.  
  
            |Property|Value|  
            |--------------|-----------|  
            |Name|**Required**. Type the name of the web resource.|  
            |Display Name|**Required**. Type the name to be displayed in the list of web resources.|  
            |Description|Optional. Type a description of the web resource.|  
            |Type|**Required**. Select **Script (JScript)**.|  
            |Language|Optional. Click one of the languages available for your organization.|  
  
        2.  If you have been provided with a script, we highly recommend that you use the **Browse** button to locate the file and upload it.  
  
             Alternatively, you can click the **Text Editor** button and paste or type the contents of the script in the **Edit Content** dialog box.  
  
            > [!NOTE]
            >  Because this simple text editor doesn’t provide any features to check the correctness of the script, we recommend that you use a separate application like [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] to edit scripts and then upload them.  
  
        3.  Click **Save** and close the web resource dialog box. The web resource you created is now selected in the **Look Up Record** dialog box.  
  
        4.  Click **Add** to close the dialog box.  
5.  In the **Event Handlers** section, select the event you want to set an event handler for.  
  
6.  Click **Add** to open the **Handler Properties** dialog box.  
  
7. On the **Details** tab, click the appropriate library and type the name of the function that should be executed for the event.  
  
8. By default, the event handler is enabled. Clear the **Enabled** check box if you don’t want to enable this event.  
  
     Some functions require an execution context to be passed to the function. If this is required, select **Pass execution context as the first parameter**.  
  
     Some functions can accept a set of parameters to control the behavior of a function. If these are required, enter them in the **Comma separated list of parameters that will be passed to the function**.  
  
9. On the **Dependencies** tab, add any fields that the script depends on into the **Dependent Fields** area.  
  
10. Click **OK** to close the **Handler Properties** dialog.  
  
11. When the event handler is entered you may adjust the order in which the function will be executed relative to any other functions by using the green arrows to move it up or down.  
  
12. Click **OK** to close the element properties dialog.  
  
13. Click **Save** to save your changes. Click **Publish** to publish the form.  
  
> [!NOTE]
>  While the user interface (UI) lets you adjust the order in which the scripts are loaded by using the up and down green arrows, the scripts are actually not loaded sequentially. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][MSDN: Manage library dependencies](https://msdn.microsoft.com/library/gg328261.aspx)  
  
## See Also  
 [Create and design interactive forms](Create%20and%20design%20interactive%20forms%20for%20the%20interactive%20service%20hub.md)   
 [Create and edit quick create forms](Create%20and%20edit%20quick%20create%20forms.md)   
 [Create and edit quick view forms](Create%20and%20edit%20quick%20view%20forms.md)
