---
title: Overview of the form editor user interface in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs
description: Know the form editor user interface to edit forms in Power Apps
keywords: Forms; Main form;  Unified interface apps; Dynamics 365 Customer Engagement (on-premises)
ms.date: 12/04/2018
author: Mattp123
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.service: crm-online
ms.author: matp
manager: kvivek
ms.assetid: 146f8035-4fcd-4572-8e71-4270cd150495
search.audienceType: 
  - customizer

---
# Overview of the form editor user interface

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Overview of the model-driven form designer](/powerapps/maker/model-driven-apps/form-designer-overview)

The form editor displays commands in three tabs: **File**, **Home**, and **Insert**. More information: 

- [File tab](#file-tab)
- [Home tab](#home-tab)
- [Insert tab](#insert-tab)

The form editor is divided into three areas: **Navigation**, **Body**, and **Explorer**.  

![Form editor user interface](media/form-user-interface.png)

**Navigation**  
Located on the left side, use the navigation area to control access to related entities or to add links to URLs to be displayed in the main pane of the form. To edit navigation, you must first select the **Navigation** command in the **Select** group of the **Home** tab.

Main forms provide navigation options through the navigation bar, but use the same data in the navigation area to control what navigation options are available. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit Navigation](../customize/use-the-form-editor-legacy.md)  


**Body** <br>
Located in the center, use the body area to control the layout of the form. You can select and drag form elements to position them. Double-clicking on an element will open the properties for the element. 

By default, for the Case, Contact, and Account Main forms, the first section under the **Summary** tab shows the account or contact card form of type **Quick View**. For custom entities, this section is not available by default. You can insert a new section and a quick view form in it. The card form shows a maximum of five fields. Other than fields, it isn’t possible to show other controls in the Blue tile even if the quick view form contains it. 

>[!NOTE] 
> To preserve the card format (as shown in the following image), we recommend that you do not move the quick view form to any other section on the form.

![Card format](media/card-format.png)

 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)  

-   To add a field, select it from the **Field Explorer** and drag it into a section.  

    -   To add an element that is not a field, select where you want to place it and use the appropriate command from the **Insert** tab add it.  

    -   To remove an element, select it and use the **Remove** command in the **Edit** group of the **Home** tab.  

    -   To edit the **Header** or **Footer** for the form you must first select the corresponding command in the **Select** group of the **Home** tab.  

**Explorer**  
Located on the right side, the content of the explorer area depends on the context.  

When you select **Body**, **Header**, or **Footer** in the **Select** group of the **Home** tab, you’ll see the **Field Explorer**. Use the **Field Explorer** to drag fields you want to display into a section in the form or within the header or footer. You can include the same field multiple times in a form. Use the **New Field** button as a shortcut to create a new field.  

When you select **Navigation** in the **Select** group of the **Home** tab you’ll see the **Relationship Explorer**. Drag any of the relationships into one of the groups within the navigation area. You cannot add the same relationship twice. Relationships are available based on how they are configured. If you configure a relationship to not display, it won’t display in the **Relationship Explorer**. For information about how to configure default display options for relationships, see [Navigation pane item for primary entity](create-and-edit-1n-relationships.md#navigation-pane-item-for-primary-entity).

You can use the **New 1:N** and **New N:N buttons** as a shortcut to add new entity relationships.  

## File tab

Select the **File** tab to add/view the following options:

- **New Activity** Add a new activity
- **New Record** Add a new record
- **Tools** Utilize options like Import data, Duplicate detection, and Bulk delete wizard
- **Options** Change the default display settings to personalize Microsoft Dynamics 365 Customer Engagement (on-premises), and manage your email templates
    - General
    - Synchronization
    - Activities
    - Formats
    - Email Templates
    - Email Signatures
    - Email
    - Privacy
    - Languages
- Help
- Close


## Home tab  
 The **Home** tab displays the commands listed in the following table:

![Home tab](media/home-tab.png)


|    Group    |          Command          |                                                                                                                                                                                                                                                                                                         Description                                                                                                                                                                                                                                                                                                          |
|-------------|---------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  **Save**   |  **Save**  **(Ctrl+S)**   |                                                                                                                                                                                                                                                                                                        Save the form.                                                                                                                                                                                                                                                                                                        |
|             |        **Save As**        |                                                                                                                                                                                                                                                                                      Create a copy of this form with a different name.                                                                                                                                                                                                                                                                                       |
|             |    **Save and Close**     |                                                                                                                                                                                                                                                                                           Save the form and close the form editor.                                                                                                                                                                                                                                                                                           |
|             |        **Publish**        |                                                                                                                                                                                                                                                                                Publish the form. More information: Publishing customizations                                                                                                                                                                                                                                                                                 |
|  **Edit**   |   **Change properties**   | Change properties of the selected item in the body.<br /><br /> See the following sections depending on the selected item:<br /><br /> -   [Tab Properties](../customize/tab-properties-legacy.md)<br />-   [Section properties](../customize/section-properties-legacy.md)<br />-   [Common Field properties](../customize/common-field-properties-legacy.md)<br />-   [Special field properties](../customize/special-field-properties-legacy.md)<br />-  [Sub-grid properties](../customize/sub-grid-properties-legacy.md)<br />-   [Quick view control properties](../customize/quick-view-control-properties-legacy.md) |
|             |        **Remove**         |                                                                                                                                                                                                                                                                                                  Remove the selected item.                                                                                                                                                                                                                                                                                                   |
|             |   **Undo** **(Ctrl+Z)**   |                                                                                                                                                                                                                                                                                                  Undo the previous action.                                                                                                                                                                                                                                                                                                   |
|             |   **Redo** **(Ctrl+Y)**   |                                                                                                                                                                                                                                                                                                  Redo the previous action.                                                                                                                                                                                                                                                                                                   |
| **Select**  |         **Body**          |                                                                                                                                                                                                                                                                                               Edit the main body of the form.                                                                                                                                                                                                                                                                                                |
|             |        **Header**         |                                                                                                                                                                                                                                                                                                    Edit the form header.                                                                                                                                                                                                                                                                                                     |
|             |        **Footer**         |                                                                                                                                                                                                                                                                                                    Edit the form footer.                                                                                                                                                                                                                                                                                                     |
|             |      **Navigation**       |                                                                                                                                                                                                                         Edit the form navigation.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit Navigation](../customize/use-the-form-editor-legacy.md)                                                                                                                                                                                                                          |
|  **Form**   |    **Business Rules**     |                                                                                                                             View, edit, or create new business rules with the Business Rules explorer. **Note:**  For the interactive forms, only the “Entity” and “All Forms” scope is supported.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit business rules](../customize/create-business-rules-recommendations-apply-logic-form.md)                                                                                                                              |
|             |    **Form Properties**    |                                                                                                                                                                                                                                              [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Form Properties](../customize/form-properties-legacy.md)                                                                                                                                                                                                                                               |
|             |        **Preview**        |                                                                                                                                                                                                                                                   Use this to see how form looks after it is published. You can also preview to test scripts associated with from events.                                                                                                                                                                                                                                                    |
|             | **Enable Security Roles** |                                                                                    Use this to set which security roles will have access to the forms. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]  [Control access to forms](../customize/control-access-forms.md) **Important:**  If you create a new form, only the System Administrator and System Customizer security roles will have access to the form. You must assign access to other security roles before people in your organization can use it.                                                                                     |
|             |   **Show Dependencies**   |                                                                                                                                                                                             See which solution components depend on this form and which solution components are required by this form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Solution dependencies](../customize/overview.md)                                                                                                                                                                                             |
|             |  **Managed Properties**   |                                                                            Managed properties command has two properties **Customizable** and **Can be Deleted**. Setting these properties to false means the form won’t be customizable and cannot be deleted after you included it in a solution, export that solution as a managed solution, and import that managed solution into a different organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]  [Managed properties](../customize/managed-properties.md)                                                                            |
| **Upgrade** |      **Merge forms**      |                                                                                                                                                                                                                                                         If applicable, this option lets you merge this form with a form from a previous version of Dynamics 365 Customer Engagement (on-premises) form                                                                                                                                                                                                                                                         |

## Insert tab  
![Insert tab](media/insert-tab.png)

The Insert tab displays the commands in the following table:


|    Group    |          Command           |                                                                                                                                                                                                                                                    Description                                                                                                                                                                                                                                                    |
|-------------|----------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|             |        **Section**         | Add a section to a selected tab. You can include a section with one to four columns.<br /><br /> You can also insert a Reference panel in the interactive forms. Reference panel is also added as a section to the Main - Interactive experience form. By default the Reference panel section is added to the Case, Account, Contact and custom entity forms.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Section properties](../customize/section-properties-legacy.md) |
| **3 Tabs**  |     **Three Columns**      |                                                                                                                                                             Insert a three-column tab with equal widths.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tab Properties](../customize/tab-properties-legacy.md)                                                                                                                                                              |
|             |     **Three Columns**      |                                                                                                                                                                                                                               Insert a three-column tab with a wider middle column.                                                                                                                                                                                                                               |
| **2 Tabs**  |      **Two Columns**       |                                                                                                                                                                                                                                Insert a two-column tab with a wider right column.                                                                                                                                                                                                                                 |
|             |      **Two Columns**       |                                                                                                                                                                                                                                 Insert a two-column tab with a wider left column.                                                                                                                                                                                                                                 |
|             |      **Two Columns**       |                                                                                                                                                                                                                                 Insert a two-column tab with equal width columns.                                                                                                                                                                                                                                 |
|  **1 Tab**  |       **One Column**       |                                                                                                                                                                                                                                             Insert a one-column tab.                                                                                                                                                                                                                                              |
| **Control** |        **Sub-Grid**        |                                                                                                                                                       Format a sub-grid and insert it into the form.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Sub-grid properties](../customize/sub-grid-properties-legacy.md)                                                                                                                                                        |
|             |         **Spacer**         |                                                                                                                                                                                                                                              Insert an empty space.                                                                                                                                                                                                                                               |
|             |    **Quick View Form**     |                                                                                                                                                        Insert a Quick View Form.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Quick view control properties](../customize/quick-view-control-properties-legacy.md)                                                                                                                                                        |
|             |      **Web Resource**      |                                                                                                                                      Insert a web resource to embed content from other locations in one page.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Web Resource properties](../customize/web-resource-properties-legacy.md)                                                                                                                                       |
|             |         **IFRAME**         |                                                                                                                                                                                                               You can add IFRAME to a form to integrate content from another website within a form.                                                                                                                                                                                                               |
|             |        **Timeline**        |                                                                                                                                                                                               Insert a timeline control in the form. This control shows the timeline of activities related to the entity on a form.                                                                                                                                                                                               |
|             |    **Navigation Link**     |                                                                                                                                                                                                                         Using this option, you can insert a link into a form navigation.                                                                                                                                                                                                                          |
|             |         **Timer**          |                                                                                                                                  Insert a timer control to an entity form to track time against an SLA. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a timer control](../../../customer-service/add-timer-control-case-form-track-time-against-sla.md)                                                                                                                                  |
|             | **Knowledge Base Search**  |                                                                                                                                 Insert a search control that users can use to search knowledge articles. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]  [Knowledge Base Search control](../../../customer-service/add-knowledge-base-search-control-forms.md)                                                                                                                                 |
|             | **Relationship Assistant** |                                                                                                                                                                                                                  Using this option, you can insert a relationship assistant control in the form.                                                                                                                                                                                                                  |

>[!Note] 
>The following components aren’t supported in the Main forms:<br> <ul> <li>Bing maps <br><li>Yammer <br><li>Activity Feeds <br> </li> </ul>



## See also

[Use the Main form and its components](../customize/use-main-form-and-components.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]