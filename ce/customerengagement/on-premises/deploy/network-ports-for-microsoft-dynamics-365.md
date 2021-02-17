---
title: "Network ports for Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: c7c079e0-5193-4f2e-8309-0111eaf31674
caps.latest.revision: 17
ms.author: matp
author: Mattp123
manager: kvivek
---
# Network ports for Dynamics 365 Customer Engagement (on-premises)



This section describes the ports that are used for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. This information is helpful as you configure the network when users connect through a firewall.  
  
<a name="BKMK_NetworkPortsCRM"></a>   
## Network ports for the Microsoft Dynamics 365 web application  
 The following table lists the ports used for a server that is running a Full Server installation of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Moreover, except for the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] role, and the [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] server role, all server roles are installed on the same computer.  
  
|Protocol|Port|Description|Explanation|  
|--------------|----------|-----------------|-----------------|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|80|HTTP|Default web application port. This port may be different as it can be changed during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)]. For new websites, the default port number is 5555.|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|135|MSRPC|RPC endpoint resolution.|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|139|NETBIOS-SSN|NETBIOS session service.|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|443|HTTPS|Default secure HTTP port. The port number may differ from the default port. This secure network transport must be manually configured. Although this port is not required to run [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], we strongly recommend it. For information about how to configure HTTPS for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], see [Make Microsoft Dynamics 365 client-to-server network communications more secure](post-installation-configuration-guidelines-dynamics-365.md#BKMK_MakeMicrosoft).|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|445|Microsoft-DS|[!INCLUDE[cc_AD_required_for_access_and_authentication](../includes/cc-ad-required-for-access-and-authentication.md)]|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|123|NTP|Network Time Protocol.|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|137|NETBIOS-NS|NETBIOS name service.|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|138|NETBIOS-dgm|NETBIOS datagram service.|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|445|Microsoft-DS|[!INCLUDE[cc_AD_required_for_access_and_authentication](../includes/cc-ad-required-for-access-and-authentication.md)]|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|1025|Blackjack|DCOM, used as an RPC listener.|  
  
> [!IMPORTANT]
>  Depending on your domain trust configuration, additional network ports may need to be available for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to work correctly. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Active Directory and Active Directory Domain Services Port Requirements](https://technet.microsoft.com/library/dd772723\(v=ws.10\).aspx)  
  
<a name="BKMK_NetworkPortsAsynch"></a>   
## Network ports for the Asynchronous Service, Web Application Server, and Sandbox Processing Service server roles  
 The following table lists the additional ports that are used for a deployment where the [!INCLUDE[pn_Sandbox_Processing_Service](../includes/pn-sandbox-processing-service.md)] is running on a separate computer.  
  
|Protocol|Port|Description|Explanation|  
|--------------|----------|-----------------|-----------------|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|808|[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] server role communication|By default, communication over port 808 occurs as follows.<br /><br /> -   The [!INCLUDE[pn_Asynchronous_Service](../includes/pn-asynchronous-service.md)] and [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] services communicate to the [!INCLUDE[pn_Sandbox_Processing_Service](../includes/pn-sandbox-processing-service.md)] through this channel.<br />-   The [!INCLUDE[pn_Sandbox_Processing_Service](../includes/pn-sandbox-processing-service.md)] communicates to the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] through this channel.<br /><br /> The default port is 808, but can be changed in the [!INCLUDE[pn_Windows_registry](../includes/pn-windows-registry.md)] by adding the DWORD registry value TcpPort in the key HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM\\.|  
  
<a name="BKMK_Networkports_DeployWeb"></a>   
## Network ports for the [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] server role  
 The following table lists the additional port that is used by the [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] server role.  
  
|Protocol|Port|Description|Explanation|  
|--------------|----------|-----------------|-----------------|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|808|Used for Fetch-based reports|[!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] servers that run Fetch-based reports initiated by Dynamics 365 clients communicate with the [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)] server role (a [!INCLUDE[Front_End_Server](../includes/front-end-server.md)] role) over this port.|  
  
<a name="BKMK_NetworkPortsSQL"></a>   
## Network ports that are used by the SQL Server that runs the SQL Server and Microsoft Dynamics 365 Reporting Extensions server roles  
 The following table lists the ports that are used for a computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] and has only [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] and the [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] (SRS Data Connector) server roles installed.  
  
|Protocol|Port|Description|Explanation|  
|--------------|----------|-----------------|-----------------|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|135|MSRPC|RPC endpoint resolution.|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|139|NETBIOS-SSN|NETBIOS session service.|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|445|Microsoft-DS|[!INCLUDE[cc_AD_required_for_access_and_authentication](../includes/cc-ad-required-for-access-and-authentication.md)]|  
|[!INCLUDE[pn_TCP](../includes/pn-tcp.md)]|1433|ms-sql-s|[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] sockets service. This port is required for access to [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. This number may be different if you have configured your default instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] to use a different port number or you are using a named instance.|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|123|NTP|Network Time Protocol.|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|137|NETBIOS-NS|NETBIOS name service.|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|138|NETBIOS-dgm|NETBIOS datagram service.|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|445|Microsoft-DS|[!INCLUDE[cc_AD_required_for_access_and_authentication](../includes/cc-ad-required-for-access-and-authentication.md)]|  
|[!INCLUDE[pn_UDP](../includes/pn-udp.md)]|1025|Blackjack|DCOM, used as an RPC listener.|  
  
> [!IMPORTANT]
>  In addition to the ports listed previously, [!INCLUDE[pn_UDP](../includes/pn-udp.md)] port 1434 ([!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Browser Service) on the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is required by [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] to return a list of the computers that are running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] during the installation of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. To work around this, specify the *SQLServer\InstanceName* during Setup.  
  
## See Also  
[Security considerations for Microsoft Dynamics 365](security-considerations-for-microsoft-dynamics-365.md) 




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]