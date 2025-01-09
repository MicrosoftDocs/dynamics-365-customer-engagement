---
title: "Set managed property for a view in Dynamics 365 Customer Engagement (on-premises)"
description: "By default, most views have the Customizable managed property set to true. However, you can follow these steps within System Views if you need to turn it off."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: a9014576-8fb2-4f28-b8bb-5d2d49d76e12
caps.latest.revision: 25
ms.author: matp
search.audienceType: 
  - customizer

---
# Set the customizable managed property for a view

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Managed properties in the Power Platform](/power-platform/alm/managed-properties-alm)

<a name="BKMK_ManagedProperties"></a>   
 
 If you create a custom public view that you want to include in a managed solution that you will distribute, you have the option to limit the ability of anyone who is installing your solution from customizing the view.  
  
 By default, most views have their **Customizable** managed property set to true so that people can customize them. Unless you have a very good reason to change this, we recommend you allow people to customize views in your app.  
  
### Set managed property for a view  
  
1.  Navigate to **System Views** as described in [Access view definitions](../customize/accessing-view-definitions.md).  
  
2.  Select a custom public view.  
  
3.  On the menu bar, click **More Actions** > **Managed properties**.  
  
4.  Set the **Customizable** option to **True** or **False**.  
  
> [!NOTE]
> This setting does not take effect until you export a solution that contains the view as a managed solution and install it in a different environment.  

### See also
[Create or edit a view](create-edit-views.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
