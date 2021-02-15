---
title: "Disable or enable a server | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 15b52516-5f58-4cfc-b597-6f8209bb4a6b
caps.latest.revision: 14
author: Mattp123
ms.author: matp
manager: kvivek
---
# Disable or enable a server



You can use the **Servers** area to disable or enable a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
> [!WARNING]
>  When you disable a server, users can’t access the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application through the server. If the deployment contains only a single server that is running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], users can’t access the application.  
  
 Depending on the server roles that are installed, disabling a server stops the following services or server roles:  
  
-   [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)]  
  
-   [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)]  
  
-   Help Server  
  
-   [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)]  
  
-   [!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)]  
  
-   Asynchronous Processing Service  
  
-   Asynchronous Processing Service (maintenance)  
  
-   [!INCLUDE[pn_Sandbox_Processing_Service](../includes/pn-sandbox-processing-service.md)]  
  
-   [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] VSS Writer service  
  
 Enabling a server that was disabled starts the server role service.  
  
> [!IMPORTANT]
>  You can’t disable the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] and [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] server roles by using the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] disable feature.  
  
> [!TIP]
>  You can implement the procedure described here by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see the [Disable-CrmServer](/powershell/module/microsoft.crm.powershell/disable-crmserver?view=dynamics365ce-ps) and [Enable-CrmServer](/powershell/module/microsoft.crm.powershell/enable-crmserver?view=dynamics365ce-ps) commands.  
  
### Disable or enable a server  
  
1.  In the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] console tree, select **Servers** to view the list of servers.  
  
2.  In the details pane, right-click the server, and then select **Disable** or **Enable**.  
  
## See also  
 [Manage servers](manage-servers.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]