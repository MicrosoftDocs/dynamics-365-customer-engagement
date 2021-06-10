---
title: Quick view control properties for main forms with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs
description: Understand the quick view control properties for main forms
Keywords: Quick view control properties; Dynamics 365 for Customer Engagement; Main forms
author: Mattp123
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.author: matp
manager: kvivek
ms.date: 10/29/2019
ms.service: crm-online
ms.topic: article
ms.assetid: 68f68d5b-6c71-4b95-bb46-d48c59d9008e
search.audienceType: 
  - customizer

---
# Quick view control properties

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Configure a quick view component](/powerapps/maker/model-driven-apps/sub-grid-properties-legacy)

A quick view control on a custom business app form displays data from a record that is selected in a lookup on the form. The data displayed in the control is defined using a quick view form. The data displayed is not editable, but when the primary field is included in the quick view form, it becomes a link in the legacy web client app to open the related record. It is not an actionable link in a Unified Interface app. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick view forms](create-edit-quick-view-forms.md)  

![Contact quick view form on the account form](../customize/media/quick-view-form-contact.png "Contact quick view form on the account form")  

You can access **Quick view control properties** in solution explorer. Under **Components**, expand **Entities**, expand the entity you want, and then select **Forms**. In the list of forms, open the form of type **Main**. Then on the **Insert** tab, select **Quick View Form** to view the **Quick View Control Properties** page.

![Quick view control example for a primary contact record](media/quick-view-control.png)
  
|Property|Description|  
|--------------|-----------------|  
|**Name**|**Required**: The unique name for the quick view form that is used when referencing it in scripts.|  
|**Label**|**Required**: A label to display for the quick view form.|  
|**Display label on the Form**|Displays the label on the form.|  
|**Lookup Field**|Choose one of the lookup fields included in the form.|  
|**Related entity**|This value depends on the **Lookup Field** you choose. It is usually the primary entity for the 1:N entity relationship for the lookup.<br /><br /> If the entity includes a **Potential Customer** lookup that can accept either an account or contact, in the **Quick View Form** field you can choose a quick view form for both account and contact by changing this value and then choosing another quick view form.|  
|**Quick View Form**|If the **Related entity** has any quick view forms you can select them here. Otherwise, select **New** to create one.<br /><br /> Select **Edit** to change the selected quick view form.|  
|**Additional Properties**|You can specify the default rendering style by selecting the check box.  You can set this to display the quick view form as a card.|

## See also

[Use the Main form and its components](../customize/use-main-form-and-components.md)
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]