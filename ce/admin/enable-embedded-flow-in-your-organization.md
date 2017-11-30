---
title: "Enable embedded Flow in your Dynamics 365 Customer Engagement organization | MicrosoftDocs"
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
ms.assetid: 5d83e4d6-7b2c-432d-8f6a-222793ac9677
caps.latest.revision: 11
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Enable embedded Flow to automate processes

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Flow lets you create automated processes between your favorite apps and services. The ability to run flows from within [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] makes it simple for users to combine a broad spectrum of services that can be initiated from within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], such as messaging, social engagement, and document routing services.  

[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] instances use the default Flow environment. For more information about Flow environments, see [Using environments within Microsoft Flow](https://flow.microsoft.com/documentation/environments-overview-admin/)
  
The embedded Flow feature is not available in the following service or geographic regions.
-  Microsoft Dynamics 365 Government
-  Germany
-  United Kingdom (UK)
-  South America

 Once the embedded Flows feature is enabled, the following privileges are added in the **Miscellaneous** section of the **Customization** tab for security roles.  
  
-   Name: prvFlow  
  
-   Name: prvFlow  
  
## Prerequisites  
  
-   A Flow connection for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] (recommended). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Connectors](https://docs.microsoft.com/connectors/)  
  
-   One or more flows created in the Flow environment to use with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a flow by using Dynamics 365 (online)](https://flow.microsoft.com/documentation/connection-dynamics365/)  
  
## Enable or disable Flow in your Dynamics 365 organization  
 By default, all security roles allow users to run flows on the records that they have access to.  
  
 To enable or disable embedded Microsoft Flows in your organization, follow these steps.  
  
1.  Go to the **Settings** > **Administration** > **System Settings** > **Customization** tab.  
  
2.  Enable or disable Flow in your organization.  
  
    -   To enable, under **Enable Microsoft Flow** click **Yes**.  
    
    -   To disable, under **Enable Microsoft Flow** click **No**.  
  
        ![Enable embedded Flow](../admin/media/embed-flow-enable.png "Enable embedded Flow")  
  
3.  Click **OK** to close System Settings.  
  
### See also  
 [Create and edit web resources](../customize/create-edit-web-resources.md)
