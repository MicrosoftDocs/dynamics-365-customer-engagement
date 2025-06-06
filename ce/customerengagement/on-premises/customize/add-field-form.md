---
title: "Add field to a form in Dynamics 365 Customer Engagement (on-premises)"
description: "If a form in Customer Engagement (on-premises) doesn’t meet your business requirements, customize the form by changing existing fields or adding new ones."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: how-to
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 29499887-6e7b-44a1-86a7-eaad33f3075d
caps.latest.revision: 30
ms.author: matp
search.audienceType: 
  - customizer

---
# Add a field to a form or edit an existing field

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Add a field to a model-driven app form](/powerapps/maker/model-driven-apps/add-field-form)

If a Dynamics 365 Customer Engagement (on-premises) form doesn’t meet your organization’s business requirements, you can customize the form by changing existing fields or by adding new fields. While it might be simpler to edit the existing fields on a form, sometimes it’s better to add a field to address a specific business scenario.  
  
1. Open solution explorer.
  
2.  Under **Components**, expand **Entities**, expand the entity you want to customize, and then click **Forms**.  
3.  In the list, find an entry with the form type of Main, and then double-click or tap to edit it.  
  
4.  In the form, click the section you want to add a field to, and then in the **Field Explorer** pane, double-click the field you want added to the form.  
  
    > [!TIP]
    >  When you add an option set field on the form, the drop-down list that contains the option set values can only display two values. Users must scroll to see more values in the list. If you want to show more than two values without users having to scroll, add one or more **Spacer** controls below the option set field on the form. Each **Spacer** control provides a space for one additional option set value. For example, if you want to display four values in the drop-down list without scrolling, add two **Spacer** controls below the option set field on the form.  
  
5.  To preview how the form appears and how events function:  
  
    1.  On the **Home** tab, click **Preview**, and then select **Create Form**, **Update Form**, or **Read-Only Form**.  
  
    2.  To close the preview form, click **Close**.  
  
    3.  To publish customizations for the form that you’re editing, with the form open, click **Publish**.  
  
6.  When you’re done editing the form, click **Save and Close**.  
  
7. To publish customizations for all unpublished components at one time, click **File**, and then click **Publish All Customizations**.  
  
> [!NOTE]
>  Publishing customizations can interfere with normal system operation. We recommend that you publish when it’s least disruptive to users.  
  
### See Also  
 
 [Create and design forms](../customize/create-design-forms.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
