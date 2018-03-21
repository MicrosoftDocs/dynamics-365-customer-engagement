---
title: "Delete or deactivate a view (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "rdubois-msft"
ms.assetid: 60865f78-7482-42da-8960-adbd3c155028
caps.latest.revision: 25
ms.author: "rdubois"
manager: "brycho"
---
# Delete or deactivate a view 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]
  
<a name="BKMK_RemoveViews"></a>   

 You may have a Dynamics 365 Customer Engagement view that you don’t want people to see. Depending on the type of view, you can either delete it or deactivate it.  
  
### Delete a view  
 You can delete any custom public view. Use the steps in [Access view definitions](../customize/accessing-view-definitions.md) to find the view you want to delete and use the ![Delete button](../customize/media/delete.gif "Delete button")**Delete** command. Once you verify that you really want to delete it, the view will be permanently deleted.  
  
 If you don’t want to delete the view permanently, you can deactivate it instead.  
  
### Deactivate or activate views  
 You cannot delete or deactivate any [system views](../customize/types-of-views.md#BKMK_SystemViews), including public views the system created. You can deactivate any public view, including public views the system created.  
  
#### Deactivate or activate a public view  
  
1.  Navigate to **System Views** as described in [Access view definitions](../customize/accessing-view-definitions.md).  
  
2.  Select a public view. To see inactive views, use the **Inactive Public Views** view.  
  
3.  On the menu bar, click **More Actions**, and then click either **Deactivate** or **Activate**.  
  
4.  Click **Publish All Customizations**. 

### See also
[Create or edit a view](create-edit-views.md)
