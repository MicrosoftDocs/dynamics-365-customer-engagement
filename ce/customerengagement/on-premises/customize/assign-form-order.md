---
title: "Set a form order in Dynamics 365 Customer Engagement (on-premises)"
description: "When you have multiple forms for an entity, follow these steps to assign a form order to determine which of the available forms will be shown by default."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 914c5694-9c80-4424-be89-9f63256b4811
caps.latest.revision: 33
ms.author: matp
tags: 
search.audienceType: 
  - customizer

---
# Assign a form order

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Set the form order](/powerapps/maker/model-driven-apps/control-access-forms#set-the-form-order)

 When you have multiple main, quick create, quick view, or card forms for an entity, you can assign a form order. The form order determines which of the available forms will be shown by default. The available main forms can be further controlled by assigning security roles to forms. See [Control access to forms](control-access-forms.md) for more information.  
  
 You cannot assign security roles to quick create, quick view, or card forms, so the only form that will be used by everyone is the one at the top of the form order.  
  
## To assign a form order  
  
1.  In the solutions explorer, expand the entity that you want and select **Forms**.  
  
2.  In the form list toolbar select **Form Order**.  
  
3.  Choose either **Main Form Set**, **Quick Create Form Set**, or **Card Form Set** depending on the type of forms you want to work with.  
  
4.  The **Form Order** dialog is a simple list where you can move a selected form up or down in the form order.  
  
5.  After you have set the order you want, click **OK** to close the dialog.  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
