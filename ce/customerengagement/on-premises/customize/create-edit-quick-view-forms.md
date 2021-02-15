---
title: "Create or edit quick view forms in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to create or edit a quick view form"
ms.custom: 
ms.date: 11/09/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 9b101734-cc11-4d05-bd45-eb611eae9931
caps.latest.revision: 14
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---

# Create or edit a quick view form to view information about a related entity

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create a model-driven app quick view form to view information about a related entity](/powerapps/maker/model-driven-apps/create-edit-quick-view-forms)

A quick view form can be added to another form as a quick view control. It provides a template to view information about a related entity record within a form for another entity record. This means your app users do not need to navigate to a different record to see the information needed to do their work.  
  
 Quick view controls are associated with a lookup field that is included in a form. If the lookup field value is not set, the quick view control will not be visible. Data in quick view controls cannot be edited and quick view forms do not support form scripts.  
  
 Because quick view forms are viewed using a quick view control in a form, they do not include header, footer, or navigation areas. Security roles cannot be assigned to quick view forms and they cannot be activated or deactivated.  
  
<a name="BKMK_CreateQFV"></a>   
## Create a quick view form  
 You create quick view forms using the form editor in a manner similar to the way you create other forms. Quick view forms are read-only. Use them to create forms that are for reading purposes only.  
  
1.  In the solution explorer, expand the **Entities** node and select the entity you want to create a new quick view form for.  
  
2.  Expand the entity and select the **Forms** node.  
  
3.  Choose **New** and select **Quick View Form**. This will open the form editor.  
  
4.  In the form editor, choose **Form Properties** in the **Form** group of the **Home** tab.  
  
5.  In the **Form Properties** dialog box, enter a **Form Name** and **Description** to differentiate this quick view form from any others and close the **Form Properties** dialog box.  
  
6.  Edit the form to add the fields you want. 
  
    > [!IMPORTANT]
    >  If you add a field and choose **Field Requirement** > **Business Required** and then save it, you will not be able to delete the field.  
  
7.  To save the form and close the form editor, on the **Home** tab, **Save** group, choose **Save and Close**.  
  
<a name="BKMK_EditQVF"></a>   
## Edit a quick view form  
 Quick view forms have a simplified layout because they are designed to be viewed within a form section. Only one single column tab is available. You can add only additional single column sections, fields, subgrids, and spacers.   
  
> [!NOTE]
>  You cannot delete a field that is **Business Required**. You will receive this message if you try to delete the field: “The field you are trying to remove is required by the system or business.” If you do not want the field in the form you have to delete the entire form and then recreate it.  
  
 When you edit a quick view form, you must publish your changes before they will be visible in the application.  
  
<a name="BKMK_AddQVF"></a>   
## Add a quick view control to a main form  
 Quick view forms can only be added to a main form where a lookup field exists that targets the entity of the quick view form.  
  
1. In an entity main form, choose **Quick View Form** in the **Control** group of the **Insert** tab.  
  
2. In the **Quick View Control Properties** dialog box, set the properties described in [Quick view control properties](quick-view-control-properties-legacy.md).  
  
3. Choose **OK** to close the **Quick View Control Properties** dialog box.  
  
   You must save and publish the main form before the quick view control changes will be visible.  

> [!NOTE]
> Quick view forms will not show in your solutions or apps until you add them using the App Designer. Make sure you open your solution or app in App Designer, add your quick view form, select save, and then publish.

### See also   
 [Create and design forms](../customize/create-design-forms.md)   
 [Create or edit quick create forms](../customize/create-edit-quick-create-forms.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]