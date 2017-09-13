---
title: "Create and edit views in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 826fb059-a552-4db5-bf40-6a80cfa0fc0e
caps.latest.revision: 25
ms.author: "rdubois"
manager: "brycho"
---
# Create and edit views (lists)
In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], use views to define how a list of records for a specific entity is displayed in the application. A view defines:  
  
-   The columns to display  
  
-   How wide each column should be  
  
-   How the list of records should be sorted by default  
  
-   What default filters should be applied to restrict which records will appear in the list  
  
 A drop-down list of views is frequently displayed in the application so that people have options for different views of entity data.  
  
 The records that are visible in individual views are displayed in a list, sometimes called a grid, which frequently provides options so that people can change the default sorting, column widths, and filters to more easily see the data that’s important to them. Views also define the data source for charts that are used in the application.  
  
<a name="BKMK_TypesOfViews"></a>   
## Types of views  
 There are three types of views, *personal*, *system*, and *public* views.  
  
<a name="BKMK_PersonalViews"></a>   
### Personal views  
 You and anyone else who has at least User level access to actions for the Saved View entity can also create personal views. As system administrator, you can modify the access level for each action in the security role to control the depth to which people can create, read, write, delete, assign, or share personal views.  
  
 Personal views are owned by individuals and, because of their default User level access, they are visible only to that person or anyone else they choose to share their personal views with. You can create personal views by saving a query that you define by using Advanced Find or by using the **Save Filters as New Views** and **Save Filters to Current View** options in the list of views. These views are typically included at the bottom in lists of system or public views that are available in the application. While you can create a new personal view based on a system or public view, you cannot create a system or public view based on a personal view.  
  
 This topic is about how system administrators and system customizers work with system and public views. For more information about personal views, see [Create, edit, or save an Advanced Find search](http://go.microsoft.com/fwlink/p/?LinkId=513227).  
  
<a name="BKMK_SystemViews"></a>   
### System views  
 As a system administrator or system customizer, you can edit system views. System views are special views the application depends on, which  exist for system entities or are automatically created when you create custom entities. These views have specific purposes and some additional capabilities.    
  
|System Views|Description|  
|------------------|-----------------|  
|**Quick Find**|The default view used when searches are performed using **Quick Find**. This view also defines which fields are searched when using search capabilities of **Quick Find** and **Lookup** views.|  
|**Advanced Find**|The default view used to display results when using **Advanced Find**. This view also defines the columns used by default when new custom public views or personal views are created without defining a view to use as a template.|  
|**Associated**|The default view that lists the related entities for a record.|  
|**Lookup**|The view you see when you select a record to set for a lookup field.|  
  
 These views are not shown in the view selector and you can’t use them in sublists in a form or as a list in a dashboard. You cannot delete or deactivate these views. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Remove views](../customize/create-edit-views.md#BKMK_RemoveViews)  
  
 System views are owned by the organization so that everyone can see them. For example, everyone has organization-level access to read records for the View (savedquery) entity. These views are associated with specific entities and are visible within the solution explorer. You can include these views in solutions because they are associated with the entity.  
  
<a name="BKMK_PublicViews"></a>   
### Public views  
 Public views are general purpose views that you can customize as you see fit. These views are available in the view selector and you can use them in sub-grids in a form or as a list in a dashboard. Some public views exist by default for system entities and for any custom entity. For example, when you create a new custom entity, it will have the following combination of public and system views.  
  
|Name|Type|  
|----------|----------|  
|**Active** *\<entity plural name>*|Public|  
|**Inactive** *\<entity plural name>*|Public|  
|**Quick Find Active** *\<entity plural name>*|Quick Find|  
|*\<entity name>* **Advanced Find View**|Advanced Find|  
|*\<entity name>* **Associated View**|Associated|  
|*\<entity name>* **Lookup View**|Lookup|  
  
 You can create custom public views. You can delete any custom public views you create in an unmanaged solution. You cannot delete any system-defined public views. Custom public views added by importing a managed solution may have managed properties set that can prevent them from being deleted, except by uninstalling the managed solution.  
  
<a name="BKMK_AccessingViewDefinitions"></a>   
## Accessing view definitions  
 There are several ways you can access view definitions if you are a system administrator or customizer. On any list view for an entity, in the command bar you will find the following commands after you click or tap the ellipsis (![More Commands button in Appointment Activity](../customize/media/more-commands.gif "More Commands button in Appointment Activity")) button:  
  
- **View**: Opens the definition of the current view in the default solution.  
  
- **New System View**: Opens a new window to create a new view for the current entity in the default solution.  
  
- **Customize Entity**: Takes you to the definition of the current entity in the default solution where you can then select **Views**.  
  
- **System Views**: Opens the same window as **Customize Entity**, except with **Views** selected.  
  
 Alternatively, you can navigate to the view definitions in the default solution by using the following steps:  
  
#### Open a view  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Click **Customize the System**.  
  
3.  Under **Components**, expand **Entities**, and then expand the entity you want.  
  
4.  Click **Views**.  
  
5.  Double-click the view you want to open.  
  
 This list of views has four filters you can use to find the views you want more easily:  
  
- **All Active Views**  
  
- **Active Public Views**  
  
- **Inactive Public Views**  
  
- **Active System-Defined Views**  
  
 If the entity that the view is associated with is part of an unmanaged solution, you can still create or edit views for that entity in the default solution. System views are associated with an entity and are not available as separate solution components. Unlike fields, views do not use a customization prefix in a unique name that should be consistent in a solution, so you do not need to create views in the context of a solution.  
  
<a name="BKMK_SetDefaultView"></a>   
## Specify default views  
 Unless someone has ‘pinned’ a different view as their personal default, they will see the default view that you specify. You can set any of the public views as the default view for an entity.  
  
#### Set the default view for an entity  
  
1.  Navigate to **Views** as described in [Accessing view definitions](../customize/create-edit-views.md#BKMK_AccessingViewDefinitions).  
  
2.  Select a Public view.  
  
3.  On the menu bar, click **More Actions** > **Set Default**.  
  
4.  Click **Publish All Customizations**.  
  
<a name="BKMK_CreatingAndEditingViews"></a>   
## Create and edit views  
 You can create custom public views by editing existing views and saving them with a different name or by creating a new view.  
  
 Also see [Create or edit a public view for an entity](http://go.microsoft.com/fwlink/p/?LinkId=513228).  
  
#### Create a new view  
  
1.  As described in [Accessing view definitions](../customize/create-edit-views.md#BKMK_AccessingViewDefinitions), from a list view for the entity, on the command bar, select **New System View**.  
  
2.  In the **View Properties** dialog box, provide a **Name** and optionally a **Description** for the view.  
  
3.  After you close the properties dialog you can do the following:  
  
    -   [Choose and configure columns](../customize/create-edit-views.md#BKMK_ChooseAndConfigureColumns)  
  
    -   [Edit filter criteria](../customize/create-edit-views.md#BKMK_EditFilterCriteria)  
  
    -   [Configure sorting](../customize/create-edit-views.md#BKMK_ConfigureSorting)  
  
4.  When you are finished, click **Save and Close**.  
  
5.  Click **Publish All Customizations**.  
  
#### Edit a view  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Click **Customize the System**.  
  
3.  Under **Components**, expand **Entities**, and then expand the entity you want.  
  
4.  Click **Views**.  
  
5.  Double-click the view you want to edit.  
  
6.  To change the **Name** or the **Description** for the view, click **View Properties**.  
  
7.  Do the following:  
  
    -   [Choose and configure columns](../customize/create-edit-views.md#BKMK_ChooseAndConfigureColumns)  
  
    -   [Edit filter criteria](../customize/create-edit-views.md#BKMK_EditFilterCriteria)  
  
    -   [Configure sorting](../customize/create-edit-views.md#BKMK_ConfigureSorting)  
  
8.  When you are finished, click **Save and Close**.  
  
9. Click **Publish All Customizations**.  
  
### Create a new view from an existing view  
 Follow the procedure to edit a view, except instead of choosing **Save and Close**, click**Save As** and enter a new **Name** and **Description** for the view.  
  
<a name="BKMK_ChooseAndConfigureColumns"></a>   
## Choose and configure columns  
 Along with the filter criteria, the columns visible in a view are very important to the value provided by the view. When you [create and edit views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews) you can perform the following tasks with columns:  
  
-   [Add columns](../customize/create-edit-views.md#BKMK_AddColumns)  
  
-   [Remove columns](../customize/create-edit-views.md#BKMK_RemoveColumns)  
  
-   [Change column width](../customize/create-edit-views.md#BKMK_ChangeColumnWidth)  
  
-   [Move a column](../customize/create-edit-views.md#BKMK_MoveAColumns)  
  
-   [Enable or disable presence for a column](../customize/create-edit-views.md#BKMK_EnableOrDisablePresence)  
  
-   [Add find columns](../customize/create-edit-views.md#BKMK_AddFindColumns)  
  
<a name="BKMK_AddColumns"></a>   
### Add columns  
 You can include columns from the current entity or any of the related entities that have a 1:N entity relationship with the current entity.  
  
 For example, perhaps you want to display the owner of a user-owned entity in a column. You can choose the **Owner** field of the current entity to display the name of the owner. This will appear as a link to open the **User** record for the person who is the owner. In this case, you also have the option to [Enable or disable presence for a column](../customize/create-edit-views.md#BKMK_EnableOrDisablePresence).  
  
 If you want to display the phone number for the owner of the record, you must select **Owning User (User)** from the **Record type** drop-down and then select the **Main Phone** field.  
  
##### Add columns to views  
  
1.  While [creating and editing views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews) click **Add Columns** and the **Add Columns** dialog box appears.  
  
2.  Select the **Record type** if you want to include fields from related entities.  
  
3.  You can select multiple fields, even from related entities.  
  
4.  When you have selected the fields you want, click **OK** to close the **Add Columns** dialog box.  
  
 As you add columns, you will increase the width of the view. If the width of the view exceeds the space available to show it in the page, horizontal scrollbars will allow people to scroll and see the hidden columns.  
  
> [!TIP]
>  If your view filters on data for a certain field so that only records with a certain value are shown, don’t include that column in the view. For example, if you are only showing active records, don’t include the status column in the view. Instead, name the view to indicate that all the records shown in the view are active.  
  
> [!NOTE]
>  When you add columns to Lookup views for updated entities, only the first three columns will be displayed.  
  
<a name="BKMK_RemoveColumns"></a>   
### Remove columns  
  
1.  While [creating and editing views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews), choose the column you want to remove.  
  
2.  In the **Common Tasks** area, click **Remove**.  
  
3.  In the confirmation message, click **OK**.  
  
<a name="BKMK_ChangeColumnWidth"></a>   
### Change column width  
  
1.  While [creating and editing views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews), choose the column you want to change.  
  
2.  In the **Common Tasks** area, click **Change Properties**.  
  
3.  In the **Change Column Properties** dialog box, choose an option to set the column width, and then click **OK**.  
  
<a name="BKMK_MoveAColumns"></a>   
### Move a column  
  
1.  While [creating and editing views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews), choose the column you want to move.  
  
2.  In the **Common Tasks** area, use the arrows to move the column left or right.  
  
<a name="BKMK_EnableOrDisablePresence"></a>   
### Enable or disable presence for a column  
 When the following conditions are true, people can a see a [!INCLUDE[pn_Microsoft_Lync](../includes/pn-microsoft-lync.md)] online presence control in lists that shows if the person is available and allows people to interact with them by IM:  
  
-   People use [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)].  
  
-   People have the [!INCLUDE[pn_Lync_Short](../includes/pn-lync-short.md)] application installed.  
  
-   People have [!INCLUDE[pn_ms_ActiveX_long](../includes/pn-ms-activex-long.md)] enabled in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)].  
  
-   Your organization has enabled presence for the system in the system settings.  
  
> [!IMPORTANT]
> [!INCLUDE[cc_lync_rebranded_skype_for_business](../includes/cc-lync-rebranded-skype-for-business.md)]  
  
 The presence control and the setting to enable it are available only for columns that display primary fields for email-enabled entities (users, contacts, opportunities, leads, or custom entities).  
  
##### Enable or disable Lync presence for a column  
  
1.  While [creating and editing views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews), choose the column you want to change.  
  
2.  In the **Common Tasks** area, click **Change Properties**.  
  
3.  In the **Change Column Properties** dialog box, select or deselect **Enable presence for this column**, and then click **OK**.  
  
<a name="BKMK_AddFindColumns"></a>   
### Add find columns  
 Find columns are the columns searched by the application when people use the **search for records** text box displayed for lists or whenever there is the ability to search for records for an entity in the application, such as when people are searching for a record for a lookup field.  
  
1.  Open a **Quick Find** view as described in [Create and edit views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews).  
  
2.  Click **Add Find Columns** to open the dialog box.  
  
3.  Select the fields that contain the data that you want to search for.  
  
4.  Click **OK** to close the **Add Find Columns** dialog box.  
  
<a name="GridIcons"></a>   
## Display custom icons instead of values in list views  
 Some Relationship Insights features display list views that show  icons rather than text or numerical values in some columns. Though this capability was created to support specific Relationship Insights features, administrators and customizers can also add new  graphics and establish the logic used to select them based on a column values using JavaScript.  
  
> [!NOTE]
>  Grid icons are only shown in the Web interface. They are not shown in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] or the mobile app.  
  
### Add custom graphics and JavaScript as web resources in Dynamics 365  
  
1.  Create the new graphic files needed for your customization. We recommend an icon size of 16x16 pixels (larger images will be scaled down).  
  
2.  Write one or more JavaScript functions that establish which icons to show for which values (you'll typically need one function for each column you want to customize). Each function must accept a row data object and a language (LCID) code as input and return an array containing an image name and tooltip text. For an example function, see [Sample JavaScript function](#SampleJavascript), later in this topic.  
  
3.  Sign into [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] as an administrator and go and go to **Settings** > **Customizations** > **Customize the System**.  
  
4.  The **Default Solution** pop-up window opens. Navigate to **Components** > **Web Resources** here.  
  
5.  Now, you'll upload your custom graphics, one at a time, as web resources. Click the **New** button in the toolbar to create a new web resource. Another pop-up window opens to help you create the resource. Do the following:  
  
    1.  Give the new resource a meaningful **Name**. The is the name that you'll use to refer to each graphic from your JavaScript code.  
  
    2.  Set the **Type** to the graphic format you've used to save your graphic file (PNG, JPEG, or GIF).  
  
    3.  Click on the **Choose File** button to open a file browser window. Use it to find and select your graphic file  
  
    4.  Add a **Display Name** and/or **Description** if you wish.  
  
    5.  Click on **Save** and then close the **Web Resource** window.  
  
6.  Repeat the previous step for each graphic file that you have.  
  
7.  Now, you'll add your JavaScript as the final web resource. Click the **New** button in the toolbar to create a new web resource. Another pop-up window opens to help you create the resource. Do the following:  
  
    1.  Give the new resource a meaningful **Name**.  
  
    2.  Set the **Type** to **Script (JScript)**.  
  
    3.  Click on **Text Editor** (next to the **Type** setting) to open a text-editor window. Paste your Javascript code here and click **OK** to save it.  
  
    4.  Add a **Display Name** and/or **Description** if you wish.  
  
    5.  Click on **Save** and then close the **Web Resource** window.  
  
8.  With the **Default Solution** pop-up window still open, expand the **Components** > **Entities** tree and locate the entity that you want to customize.  
  
9. Expand your entity and select its **Views** icon.  
  
10. You now see a list of views for your selected entity. Click on a view from the list to select it. Then open the **More Actions** drop-down list in the toolbar and choose **Edit**.  
  
11. A new pop-up window opens with controls for editing your selected view. It shows each column that is part of the view. Click to select the target column and then click the **Change Properties** button in the **Common Tasks** box. The **Change Column Properties** dialog opens; make the following settings here:  
  
    - **Web Resource**: specify the name of the web resource that you created to hold your Javascript functions (click the browse button to choose from a list).  
  
    - **Function Name**: type the name of the function that you wrote to modify the selected column and view.  
  
12. Click **OK** to close the **Change Column Properties** dialog.  
  
13. Click **Save and Close** to save your view.  
  
14. Repeat these steps for each entity, view, and column as needed.  
  
15. When you are ready, click **Publish All Customizations** to publish  your changes. Then you can close the **Default Solution** pop-up window.  
  
<a name="SampleJavascript"></a>   
### Sample JavaScript function  
 The JavaScript function for displaying custom icons and tooltips expects the following two arguments: the entire row object specified in layoutxml and the calling user’s Locale ID (LCID). The LCID parameter enables you to specify tooltip text in multiple languages. For more information about the languages supported by CRM, see [Enable languages](https://technet.microsoft.com/library/dn832148.aspx) and [Install or upgrade language packs for  Dynamics 365](https://technet.microsoft.com/library/hh699674.aspx). For a list of locale ID (LCID) values that you can use in your code, see [Locale IDs assigned by Microsoft](https://go.microsoft.com/fwlink/?linkid=829588) .  
  
 Assuming you will be adding custom icons for an option-set type of attribute, which has a limited set of predefined options, make sure you use the integer value of the options instead of label to avoid localization issues.  
  
 The following sample code displays icons and tooltips based on one of three values (1: Hot, 2: Warm, 3: Cold) in the opportunityratingcode (Rating) attribute. The sample code also shows how to display localized tooltip text. For this sample to work, you must create three image web resources with 16x16 images in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance with the following names: new_Hot, new_Warm, and new_Cold.  
  
```  
function displayIconTooltip(rowData, userLCID) {      
    var str = JSON.parse(rowData);  
    var coldata = str.opportunityratingcode_Value;  
    var imgName = "";  
    var tooltip = "";  
    switch (coldata) {  
        case 1:  
            imgName = "new_Hot";  
            switch (userLCID) {  
                case 1036:  
                    tooltip = "French: Opportunity is Hot";  
                    break;  
                default:  
                    tooltip = "Opportunity is Hot";  
                    break;  
            }  
            break;  
        case 2:  
            imgName = "new_Warm";  
            switch (userLCID) {  
                case 1036:  
                    tooltip = "French: Opportunity is Warm";  
                    break;  
                default:  
                    tooltip = "Opportunity is Warm";  
                    break;  
            }  
            break;  
        case 3:  
            imgName = "new_Cold";  
            switch (userLCID) {  
                case 1036:  
                    tooltip = "French: Opportunity is Cold";  
                    break;  
                default:  
                    tooltip = "Opportunity is Cold";  
                    break;  
            }  
            break;  
        default:  
            imgName = "";  
            tooltip = "";  
            break;  
    }  
    var resultarray = [imgName, tooltip];  
    return resultarray;  
}  
```  
  
 This results in displaying icons with tooltips in the **Rating** column that depend on the value in each row. The result could look like this:  
  
 ![Custom column graphics example](../customize/media/custom-column-graphics-example.png "Custom column graphics example")  
  
<a name="BKMK_EditFilterCriteria"></a>   
## Edit filter criteria  
 Along with the columns displayed in the view, the filter criteria that are applied to a view are a critical part of the value provided by the view.  
  
1.  While [creating and editing views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews), click **Edit Filter Criteria**.  
  
2.  The dialog shows a user interface similar to **Advanced Find**. You can use **AND** and **OR** clauses to specify and group criteria.  
  
3.  Click **OK** to close the **Edit Filter Criteria** dialog box.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create, edit, or save an Advanced Find search](http://go.microsoft.com/fwlink/p/?LinkID=513227)  
  
<a name="BKMK_ConfigureSorting"></a>   
## Configure sorting  
  
1.  While [creating and editing views](../customize/create-edit-views.md#BKMK_CreatingAndEditingViews), click **Configure Sorting**.  
  
2.  In the **Configure Sort Order** dialog box, in the **Sort By** list, select the column you want to sort, then click **Ascending Order** or **Descending Order**.  
  
3.  Click **OK** to close the **Configure Sort Order** dialog box.  
  
<a name="BKMK_RemoveViews"></a>   
## Remove views  
 Sometimes you have a view that you don’t want people to see. Depending on the type of view, you can either delete it or deactivate it.  
  
### Delete a view  
 You can delete any custom public view. Use the steps in [Accessing view definitions](../customize/create-edit-views.md#BKMK_AccessingViewDefinitions) to find the view you want to delete and use the ![Delete button](../customize/media/delete.gif "Delete button")**Delete** command. Once you verify that you really want to delete it, the view will be permanently deleted.  
  
 If you don’t want to delete the view permanently, you can deactivate it instead.  
  
### Deactivate or activate views  
 You cannot delete or deactivate any [System views](../customize/create-edit-views.md#BKMK_SystemViews), including public views the system created. You can deactivate any public view, including public views the system created.  
  
##### Deactivate or activate a public view  
  
1.  Navigate to **System Views** as described in [Accessing view definitions](../customize/create-edit-views.md#BKMK_AccessingViewDefinitions).  
  
2.  Select a public view. To see inactive views, use the **Inactive Public Views** view.  
  
3.  On the menu bar, click **More Actions**, and then click either **Deactivate** or **Activate**.  
  
4.  Click **Publish All Customizations**.  
  
<a name="BKMK_Dependencies"></a>   
## Dependencies  
 Views are dependent on the fields that they display. The fields are required components for a view.  If you have a custom field that is included in a view, you will not be able to delete that field while it is included in the definition of a view. Because views are usually presented as a list, other solution components are usually not dependent on a specific view. A chart may use a view as a data source, but it can use any of the views for an entity.  
  
#### View the solution components with dependencies on views  
  
1.  Navigate to **System Views** as described in [Accessing view definitions](../customize/create-edit-views.md#BKMK_AccessingViewDefinitions).  
  
2.  Select a view.  
  
3.  On the menu bar, click **More Actions** > **Show Dependencies**.  
  
 The **Dependencies** dialog box will list any dependent or required solution components for the view.  
  
<a name="BKMK_ManagedProperties"></a>   
## Managed properties  
 If you create a custom public view that you want to include in a managed solution that you will distribute, you have the option to limit the ability of anyone who is installing your solution from customizing the view.  
  
 By default, most views have their **Customizable** managed property set to true so that people can customize them. Unless you have a very good reason to change this, we recommend you allow people to customize views you create.  
  
#### Set managed properties for a view  
  
1.  Navigate to **System Views** as described in [Accessing view definitions](../customize/create-edit-views.md#BKMK_AccessingViewDefinitions).  
  
2.  Select a custom public view.  
  
3.  On the menu bar, click **More Actions** > **Managed properties**.  
  
4.  Set the **Customizable** option to **True** or **False**.  
  
> [!NOTE]
>  This setting does not take effect until you export a solution that contains the view as a managed solution and install it in a different organization.  
  
### See also  
 [Customize your Dynamics 365 system](../customize/customize-your-system.md)   
 [Getting started with customization](../customize/getting-started-customization.md)   
 [Customization overview](Customization%20overview-%20delete.md)   
 [Entities and metadata overview](../customize/create-edit-metadata.md)   
 [Create and design forms](../customize/create-design-forms.md)   
 [Customize Dynamics 365 for phones and tablets](../mobile-app/customize-phones-tablets.md)   
 [Create a business process flow](../customize/create-business-process-flow.md)   
 [Create or edit business rules and recommendations](../customize/create-business-rules-recommendations-apply-logic-form.md)   
 [Create or edit a public view for an entity](http://go.microsoft.com/fwlink/p/?LinkID=513228)   
 [Create, edit, or save an Advanced Find search](http://go.microsoft.com/fwlink/p/?LinkID=513227)
