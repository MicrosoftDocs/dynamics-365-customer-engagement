---
title: "Dynamics 365 Customer Engagement (on-premises) supported configurations | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 61c14cce-71e0-4f18-b02b-7caaa932ab6f
caps.latest.revision: 28
ms.author: matp
author: Mattp123
manager: kvivek
---
# Dynamics 365 Customer Engagement (on-premises) supported configurations



The deployment architecture you will use depends on your business needs. Examples are provided here for planning a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment on four representative computer system architectures: a single-computer server deployment, a two-server deployment, a five-server deployment, and a multiple-server deployment involving a minimum of six servers. These deployments are discussed in detail in [Microsoft Dynamics CRM 2011 supported configurations](microsoft-dynamics-365-supported-configurations.md).  
  
 Additionally, this section describes the supported network, domain, and server configurations for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], which supports multiple forest and domain topologies.  
  
## Active Directory requirements  
 The [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] requirements are as follows:  
  
-   The computers that run [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] roles and the computer that runs [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases are located, must be in the same [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain.  
  
-   The [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain where a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] role is located must run in one of the domain modes listed in the [Active Directory modes](software-requirements-for-microsoft-dynamics-365-server.md#Active_directory_modes) topic.  
  
-   The user account that is used to run a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service must be in the same domain as the computer that is running the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] role.  
  
-   The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] security groups (PrivUserGroup, SQLAccessGroup, ReportingGroup, and PrivReportingGroup) must be in the same domain as the computer that is running [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. These security groups can be located in the same organizational unit (OU) or in different OUs. To use security groups that are located in different OUs, you must install [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] by using an XML configuration file and specify the correct distinguished name for each pre-existing security group within the **\<Groups>** element.  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Sample server XML configuration file for installing with pre-created groups](sample-server-xml-config-file-pre-created-groups.md)  
  
    > [!WARNING]
    >  [!INCLUDE[cc_privusergroup_nesting](../includes/cc-privusergroup-nesting.md)]  
  
-   For users who access [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] from another domain and are not using claims-based authentication, a one-way trust must exist in which the domain where the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is located trusts the domain where the users are located.  
  
    > [!IMPORTANT]
    >  To add users to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that are not authenticated by using claims-based authentication, a two-way forest trust is required.  
  
## Single-server deployment  
 For small user bases, a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] can be deployed in a single-server configuration, with [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], and optionally [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] installed and running on the same computer.  
  
 Single-server deployments are not recommended for best experience in application performance and disaster recovery.  
  
 There is one limitation to single-server deployments: the server where [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is installed cannot also function as a domain controller. If the computer is a member server (not functioning as a domain controller), you can deploy the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Full Server role on a single [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] that is also running the additional required products.  
  
> [!IMPORTANT]
>  Running [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] in a production environment on an [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain controller is not supported.  
  
> [!TIP]
>  To reduce IT administration overhead, consider running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] in the cloud. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Microsoft Dynamics](https://go.microsoft.com/fwlink/p/?LinkId=513167)  
  

## See Also  
 [Planning Your Deployment of Microsoft Dynamics CRM 2015](planning-your-deployment-of-microsoft-dynamics-365.md)   
 [Multiple-server deployment](microsoft-dynamics-365-multiple-server-deployment.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]