---
title: "Dynamics 365 Customer Engagement (on-premises) language support | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 4d5a67ea-55ab-4bdc-b905-3ba75d3889d3
caps.latest.revision: 20
ms.author: matp
author: Mattp123
manager: kvivek
---
# Microsoft Dynamics 365 Customer Engagement (on-premises) language support



This section describes the supported configurations for different language versions of a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] system. It doesn’t include information about [!INCLUDE[pn_Microsoft_Dynamics_CRM_Language_Pack](../includes/pn-microsoft-dynamics-crm-language-pack.md)] support, but instead explains the supported configurations for the base-language versions. For more information about [!INCLUDE[pn_Microsoft_Dynamics_CRM_Language_Pack](../includes/pn-microsoft-dynamics-crm-language-pack.md)], see [Install and deploy a Language Pack](install-and-enable-a-language-pack.md).  
  
<a name="BKMK_SrvrLangReq"></a>   
## Microsoft Dynamics 365 Server language requirements  
 The following requirements must be met when you run  [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] with applications such as [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. Note that all available [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] languages are supported.  
  
|[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] product|Requirement|  
|-----------------------------------------------------------------------------|-----------------|  
|[!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]|The base language of [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)], [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], [!INCLUDE[pn_Microsoft_.Net_Framework](../includes/pn-microsoft-net-framework.md)], [!INCLUDE[pn_MDAC_short](../includes/pn-mdac-short.md)], and [!INCLUDE[pn_MSXML](../includes/pn-msxml.md)] must be either the same language as [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] or English. If an application isn’t available in a certain language, the English version can be used.|  
|[!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]|The base language of [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)], [!INCLUDE[pn_MS_SQL_Express](../includes/pn-ms-sql-express.md)], [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], [!INCLUDE[pn_MS_Office](../includes/pn-ms-office.md)], [!INCLUDE[pn_Microsoft_.Net_Framework](../includes/pn-microsoft-net-framework.md)], [!INCLUDE[pn_MDAC_short](../includes/pn-mdac-short.md)], and [!INCLUDE[pn_MSXML](../includes/pn-msxml.md)] don’t have to be the same language as [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].<br /><br /> Each client stack in a single deployment can be in a different language.|  
|[!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and  [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)]|The base language version of  [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] must match that of [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].<br /><br /> For example, there can’t be some users who run the German version of [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] while other users run the English version. For this scenario, we recommend provisioning the appropriate [!INCLUDE[pn_Microsoft_Dynamics_CRM_Language_Pack](../includes/pn-microsoft-dynamics-crm-language-pack.md)].|  
  
 For example, you could have the following configuration with German as the base language for all programs:  
  
-   [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]  
  
-   [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)]  
  
-   [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]  
  
-   [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)]  
  
-   [!INCLUDE[pn_MSXML](../includes/pn-msxml.md)]  
  
-   [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)]  
  
 As another example, you could have [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] with Swedish as its base language, and it could be configured with the following applications that have English as their base language:  
  
-   [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)]  
  
-   [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]  
  
-   [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)]  
  
-   [!INCLUDE[pn_MSXML](../includes/pn-msxml.md)]  
  
-   [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)]  
  
## See also     
 [Microsoft Dynamics 365 Customer Engagement (on-premises) system requirements and required technologies](system-requirements-required-technologies.md)   </br>
 [User Guide (Dynamics 365 for phones and tablets)](../../../mobile-app/dynamics-365-phones-tablets-users-guide.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]