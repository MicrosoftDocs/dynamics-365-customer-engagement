---
title: Quick view control properties for Main forms (Dynamics 365 Customer Engagement) | MicrosoftDocs
description: Understand the Quick view control properties for Main forms in Dynamics 365 for Customer Engagement
Keywords: Quick view control properties; Dynamics 365; Main forms
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 03/09/2018
ms.service: crm-online
ms.topic: article
ms.assetid: 68f68d5b-6c71-4b95-bb46-d48c59d9008e
---
# Quick view control properties

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[This topic is under revision and is subject to change]

A quick view control on a Dynamics 365 Customer Engagement form displays data from a record that is selected in a lookup on the form. The data displayed in the control is defined using a quick view form. The data displayed is not editable, but when the primary field is included in the quick view form, it becomes a link to open the related record. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick view forms](create-edit-quick-view-forms.md)  

You can access **Quick view control properties** by selecting **Settings** > **Customizations** > **Customize the System**. Under **Components**, expand **Entities**, expand the entity you want, and then select **Forms**. In the list of forms, open the form of type **Main**. Then on the **Insert** tab, select Quick view form to view Quick view control properties.

![quick-view-control](media/quick-view-control.png)
  
|Property|Description|  
|--------------|-----------------|  
|**Name**|**Required**: The unique name for the quick view form that is used when referencing it in scripts.|  
|**Label**|**Required**: A label to display for the quick view form.|  
|**Display label on the Form**|Displays the label on the form.|  
|**Lookup Field**|Choose one of the lookup fields included in the form.|  
|**Related entity**|This value depends on the **Lookup Field** you choose. It is usually the primary entity for the 1:N entity relationship for the lookup.<br /><br /> If the entity includes a **Potential Customer** lookup that can accept either an account or contact, in the **Quick View Form** field you can choose a quick view form for both account and contact by changing this value and then choosing another quick view form.|  
|**Quick View Form**|If the **Related entity** has any quick view forms you can select them here. Otherwise, click **New** to create one.<br /><br /> Click **Edit** to change the selected quick view form.|  
|**Additional Properties**|You can specify the default rendering style by clicking the check box.|

## See also

[Use the Main form and its components](../customize/use-main-form-and-components.md)
 
