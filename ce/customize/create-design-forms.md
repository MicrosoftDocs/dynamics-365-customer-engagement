---
title: "Create and design forms in Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 99c795e0-9165-4112-85b1-6b5e1a4aa5ec
caps.latest.revision: 33
ms.author: "rdubois"
manager: "brycho"
---
# Create and design forms
In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], forms provide the user interface that people use to interact with the data they need to do their work. It's important that the forms people use are designed to allow them to find or enter the information they need efficiently.  
  
 This topic introduces how forms vary by groups of entities, the different types of forms available, and how you can control access to forms. For information about the elements and properties of forms, see [Use the Form Editor](../customize/use-the-form-editor.md).  
  
<a name="BKMK_FormDifferencesByEntity"></a>   
## Form differences by entity  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] provides many options for designing forms. The forms for the [updated entities](../customize/create-design-forms.md#BKMK_UpdatedEntities) and custom entities provide the most options. We selected a group of entities that are used by most people and gave them an updated user experience that includes many capabilities, including support for the [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] client, business process flows, and business rules. One of the key requirements in providing these experiences is that a form customizer can design once and deploy to all clients.  
  
 There are still a number of entities that retain the appearance and capabilities from the previous version. [Entities using classic forms](../customize/create-design-forms.md#BKMK_ClassicFormEntities) weren’t updated because they aren't used as frequently.
  
 Most of your customization work will probably involve the updated entities and custom entities. If some capability applies only to forms for updated entities this document will note that.  
  
<a name="BKMK_UpdatedEntities"></a>   
### Updated entities  
 Updated entities are listed in the following table:  
  
||||  
|-|-|-|  
|Account|Appointment|Campaign|  
|Campaign Activity|Campaign Response|Case|  
|Competitor|Contact|Contract|  
|Contract Line|Email|Fax|  
|Invoice|Invoice Product|Lead|  
|Letter|Marketing List|Opportunity|  
|Opportunity Product|Order|Order Product|  
|Phone Call|Price List Item|Product|  
|Quick Campaign|Quote|Quote Product|  
|Recurring Appointment|Sales Literature|Team|  
|Task|User||  
  
<a name="BKMK_ClassicFormEntities"></a>   
### Entities using classic forms  
 Entities that use classic form presentation are listed in the following table:  
  
||||||  
|-|-|-|-|-|  
|Address|Article|Article Comment|Bulk Delete Operation|Connection|  
|Discount|Discount List|Document Location|Email Attachment|Follow|  
|Goal|Goal Metric|Import Source File|Invoice Product|Order Product|  
|Price List|Queue Item|Quote Product|Rollup Field|Rollup Query|  
|Saved View|Service|Service Activity|SharePoint Site|Site|  
|Territory|Unit|Unit Group|||  
  
<a name="BKMK_TypesOfForms"></a>   
## Types of forms  
 The following table describes the types of forms in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]:  
  
|Form Type|Description|  
|---------------|-----------------|  
|**Main**|Used in the web application, [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].<br /><br /> These forms provide the main user interface for interacting with entity data. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit main forms](../customize/design-considerations-main-forms.md)|  
|**Mobile**|Used for the [!INCLUDE[pn_Microsoft_Dynamics_CRM_Mobile](../includes/pn-microsoft-dynamics-crm-mobile.md)] pages. This simplified form is designed to be used for mobile devices.<br /><br /> The mobile forms for updated entities are not changed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit mobile forms](../customize/create-edit-mobile-forms-phones-express.md)|  
|**Quick Create**|Used in the web application, [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].<br /><br /> For updated entities, these forms provide a basic form optimized for creating new records. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick create forms](../customize/create-edit-quick-create-forms.md)|  
|**Quick View**|Used in the web application, [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].<br /><br /> For updated entities, these forms appear within the main form to display additional data for a record that is referenced by a lookup field in the form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)|  
  
<a name="BKMK_FormOrder"></a>   
## Assign form order  
 When you have multiple main, quick create, or mobile forms for an entity, you can assign a form order. The form order determines which of the available forms will be shown by default. The available main or mobile forms can be further controlled by assigning security roles to forms. See [Control access to forms](../customize/create-design-forms.md#BKMK_ControlAccessToForms) for more information.  
  
 You cannot assign security roles to quick create forms, so the only form that will be used by everyone is the one at the top of the form order.  
  
#### To assign a form order  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Choose **Customizations**, then choose **Customize the System**.  
  
3.  In the solutions explorer, expand the entity that you want and select **Forms**.  
  
4.  In the form list toolbar select **Form Order**.  
  
5.  Choose either **Main Form Set**, **Quick Create Form Set**, or **Mobile Form Set** depending on the type of forms you want to work with.  
  
6.  The **Form Order** dialog is a simple list where you can move a selected form up or down in the form order.  
  
7.  After you have set the order you want, click **OK** to close the dialog.  
  
<a name="BKMK_ControlAccessToForms"></a>   
## Control access to forms  
 There are two ways you can control access to main forms:  
  
- **Make a main form inactive**  
  
     The capability to set an active or inactive state to main forms is new in this release. This was included primarily to manage new forms included when organizations upgrade but you can use it to prevent people from being able to use any main form. See [Merge forms to use new layout](../customize/update-forms.md) for more information.  
  
- **Assign security roles to the main form**  
  
     Use this to make a main form available to specific groups.  
  
 Different people in your organization may interact with the same data in different ways. Managers may depend on being able to quickly scan information in a record and service people may require a form that streamlines data entry. You can accommodate different requirements by assigning forms to the security roles that different groups of people belong to.  
  
 For step-by-step procedures, see [Assign security roles to forms](http://go.microsoft.com/fwlink/p/?LinkID=317649).  
  
 When you have more than one main or mobile form defined for an entity, you can select which forms users will be able to use based on their security roles. Because each entity must be able to display a form for any user, at least one form must be designated as a ”fallback” form – a form visible to users whose security roles do not have any forms explicitly assigned to them.  
  
> [!NOTE]
>  Quick Create and Quick View forms cannot be assigned to security roles.  
  
 Within the Form editor or from the Forms grid you can assign security roles to a form. However, if there is only one form for the entity, you will not be able to clear the **Enabled for fallback** option in the **Assign Security Roles** dialog box. In this case, even though you have assigned security roles to the form, anyone associated with a security role you did not include will still be able to view the form because it is enabled for fallback.  
  
 After you create a second main or mobile form for the entity, you will be able to clear the **Enabled for fallback** option for one of them. The system will always make sure that at least one form is enabled for fallback.  
  
 When you have more than one main form, you can specify a form order that will control which of the forms a person is allowed to see will be the one they see by default. If there is more than one form they can use, they can change forms and the form they choose will be their default form until they choose a different one. This preference is stored in their browser. If they use a different computer or browser they will see the original default form.  
  
### Strategies to manage the fallback form  
 Strategies to manage the fallback form include the following:  
  
<a name="BKMK_DoNotUseMultipleForms"></a>   
#### All users view the same form  
 If you do not require multiple forms for an entity you do not need a fallback form.  
  
<a name="BKMK_Contingecyform"></a>   
#### Create a contingency form  
 If you are using role-based forms because you want to restrict the information people might view or edit, consider creating a form that has a minimum of information displayed. Then, in the **Assign Security Roles** dialog box, select **Display only to these selected security roles**, but do not select any roles except System Administrator, and select **Enabled for fallback**. The result is that this form will never be seen by anyone except the System Administrator and anyone whose security roles have not been associated with a specific form. You could include a HTML web resource in the form with information about why little information is visible in the form and a link to information about how to request being added to a security role that is associated with a from or to include a new security role for a form.  
  
> [!NOTE]
>  You can’t include a web resource in a form header or footer.  
  
<a name="BKMK_CreateGenericForm"></a>   
### Create a generic form  
 If you use role-based forms to provide a customized user experience based on a person’s role in the organization, you can set your least specialized form as the fallback form and configure it to display for everyone. Then, create customized forms for specific security roles and configure those forms to only display for security roles that require them. Do not enable these forms for fallback. Finally, in the **Forms** list use the **Form Order** dialog to specify which forms to display ranking them from most exclusive to least exclusive. Your fallback form will be at the bottom of the list. This strategy will cause people seeing the form that has been customized for their role as the default form, yet they can still use the form selector to select the most common form if they want. Whatever form they select will remain their default form until they select a different form.  
  
<a name="BKMK_UseFormScripting"></a>   
### Use form scripting  
 Finally, in the web application it is possible, but not recommended, for a developer to use scripts in the form Onload event to use the [Xrm.Page.ui.formSelector.items collection](http://go.microsoft.com/fwlink/p/?LinkID=513300) to query available forms and use the navigate method to direct users to a specific form. Remember that the [navigate method](http://go.microsoft.com/fwlink/p/?LinkID=513301) will cause the form to load again (and the Onload event to occur again). Your logic in the event handler should always check some condition before you use the navigate method to avoid an endless loop or unnecessarily restrict users options to navigate between forms.  
  
 This approach will not work for [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] because multiple forms are not available for selection.  
  
### See also  
 [Customize your Dynamics 365 system](../customize/customize-your-system.md)   
 [Entities and metadata overview](../customize/create-edit-metadata.md)   
 [Create and edit views](../customize/create-edit-views.md)
