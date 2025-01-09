---
title: "Delete a view from Dynamics 365 Customer Engagement (on-premises)"
description: "You may have a view that you don’t want people to see. Depending on the type of view, you can either delete it or deactivate it."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 60865f78-7482-42da-8960-adbd3c155028
caps.latest.revision: 25
ms.author: matp
search.audienceType: 
  - customizer

---
# Delete or deactivate a view 

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Delete or deactivate a model-driven app view](/powerapps/maker/model-driven-apps/remove-views)
  
<a name="BKMK_RemoveViews"></a>   

 You may have a view that you don’t want people to see. Depending on the type of view, you can either delete it or deactivate it.  
  
### Delete a view  
 You can delete any custom public view. Use the steps in [Access view definitions](../customize/accessing-view-definitions.md) to find the view you want to delete and use the ![Delete button.](../customize/media/delete.gif "Delete button")**Delete** command. Once you verify that you really want to delete it, the view will be permanently deleted.  
  
 If you don’t want to delete the view permanently, you can deactivate it instead.  
  
### Deactivate or activate views  
 You cannot delete or deactivate any [system views](../customize/create-edit-views.md#system-views), including public views the system created. You can deactivate any public view, including public views the system created.  
  
#### Deactivate or activate a public view  
  
1.  Navigate to **System Views** as described in [Access view definitions](../customize/accessing-view-definitions.md).  
  
2.  Select a public view. To see inactive views, use the **Inactive Public Views** view.  
  
3.  On the menu bar, select **More Actions**, and then select either **Deactivate** or **Activate**.  
  
4.  Select **Publish All Customizations**. 

### See also
[Create or edit a view](create-edit-views.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
