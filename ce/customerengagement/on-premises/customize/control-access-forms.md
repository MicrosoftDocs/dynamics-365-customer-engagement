---
title: "Control access to forms in Dynamics 365 Customer Engagement (on-premises)"
description: "There are two ways to control access to main forms. Learn how to make a form inactive or assign security roles to make it available only to certain groups."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 15d123e0-b604-45dd-ab34-0b37787a04bb
caps.latest.revision: 33
ms.author: matp
tags: 
search.audienceType: 
  - customizer

---
# Control access to main forms

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Set security roles for a form](/powerapps/maker/model-driven-apps/control-access-forms#set-security-roles-for-a-form)

 There are two ways you can control access to main forms:  
  
- **Make a main form inactive**  
  
     You can set an active or inactive state to main forms. This feature was included primarily to manage new forms included when organizations upgrade but you can use it to prevent people from being able to use any main form.   
  
- **Assign security roles to the main form**  
  
     Use this to make a main form available to specific groups.  
  
  Different people in your organization may interact with the same data in different ways. Managers may depend on being able to quickly scan information in a record and service people may require a form that streamlines data entry. You can accommodate different requirements by assigning forms to the security roles that different groups of people belong to.  
  
  For step-by-step procedures, see [Assign security roles to forms](../admin/assign-security-roles-form.md).  
  
  When you have more than one main form defined for an entity, you can select which forms users will be able to use based on their security roles. Because each entity must be able to display a form for any user, at least one form must be designated as a ”fallback” form – a form visible to users whose security roles do not have any forms explicitly assigned to them.  
  
> [!NOTE]
>  Quick Create, Quick View, and Card forms can't be assigned to security roles.  
  
 Within the form editor or from the forms grid you can assign security roles to a form. However, if there is only one form for the entity, you will not be able to clear the **Enabled for fallback** option in the **Assign Security Roles** dialog box. In this case, even though you have assigned security roles to the form, anyone associated with a security role you did not include will still be able to view the form because it is enabled for fallback.  
  
 After you create a second main form for the entity, you will be able to clear the **Enabled for fallback** option for one of them. The system will always make sure that at least one form is enabled for fallback.  
  
 When you have more than one main form, you can specify a form order that will control which of the forms a person is allowed to see will be the one they see by default. If there is more than one form they can use, they can change forms and the form they choose will be their default form until they choose a different one. This preference is stored in their browser. If they use a different computer or browser they will see the original default form.  
  
## Strategies to manage the fallback form  
 Strategies to manage the fallback form include the following:  
  
<a name="BKMK_DoNotUseMultipleForms"></a>   
### All users view the same form  
 If you do not require multiple forms for an entity you do not need a fallback form.  
  
<a name="BKMK_Contingecyform"></a>   
### Create a contingency form  
 If you are using role-based forms because you want to restrict the information people might view or edit, consider creating a form that has a minimum of information displayed. Then, in the **Assign Security Roles** dialog box, select **Display only to these selected security roles**, but do not select any roles except System Administrator, and select **Enabled for fallback**. The result is that this form will never be seen by anyone except the System Administrator and anyone whose security roles have not been associated with a specific form. You could include a HTML web resource in the form with information about why little information is visible in the form and a link to information about how to request being added to a security role that is associated with a from or to include a new security role for a form.  
  
> [!NOTE]
>  You can’t include a web resource in a form header or footer.  
  
<a name="BKMK_CreateGenericForm"></a>   
## Create a generic form  
 If you use role-based forms to provide a customized user experience based on a person’s role in the organization, you can set your least specialized form as the fallback form and configure it to display for everyone. Then, create customized forms for specific security roles and configure those forms to only display for security roles that require them. Do not enable these forms for fallback. Finally, in the **Forms** list use the **Form Order** dialog to specify which forms to display ranking them from most exclusive to least exclusive. Your fallback form will be at the bottom of the list. This strategy will cause people seeing the form that has been customized for their role as the default form, yet they can still use the form selector to select the most common form if they want. Whatever form they select will remain their default form until they select a different form.  
  
<a name="BKMK_UseFormScripting"></a>   

## Use form scripting  
The Client API form context (formContext) provides a reference to the form or to an item on the form, such as, a quick view control or a row in an editable grid, against which the current code is executed. More information: [Client API form context](/dynamics365/customer-engagement/developer/clientapi/clientapi-form-context)

> [!IMPORTANT]
> With Dynamics 365 Customer Engagement (on-premises) version 9.0, the Xrm.Page object is [deprecated](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming#some-client-apis-are-deprecated), and you should use the [getFormContext](/dynamics365/customer-engagement/developer/clientapi/reference/executioncontext/getformcontext) method of the passed in execution context object to return reference to the appropriate form or an item on the form.

### See also  
[Assign security roles to forms](../admin/assign-security-roles-form.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
