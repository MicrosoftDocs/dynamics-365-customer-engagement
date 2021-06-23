---
title: "Security considerations for Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: ""
ms.date: 04/08/2020
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: cc75c4fc-ec07-4bc6-b56d-37ec2edbd2af
caps.latest.revision: 45
ms.author: matp
author: Mattp123
manager: kvivek
---
# Security considerations for Dynamics 365 Customer Engagement (on-premises) 

[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is designed in a way that helps make your deployment more secure. This section provides information and best practices for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Overview of security for Microsoft Dynamics 365](../admin/security-concepts.md)  
  
<a name="BKMK_kindofservice"></a>   
## What kind of service account should I choose?  
 When you specify an identity to run a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service, you can choose either a domain user account or the Network Service account.  
  
 If the service interacts with network services, accesses domain resources like file shares or if it uses linked server connections to other computers, you can use a minimally-privileged domain account. Many server-to-server activities can be performed only with a domain user account and can provide the most secure option. This account should be pre-created by domain administrator in your environment.  
  
> [!NOTE]
>  When you configure a service to use a domain account, you can isolate the privileges for the application, but must manually manage passwords or create a custom solution for managing these passwords. Many server applications use this strategy to enhance security, but this strategy requires additional administration and complexity. In these deployments, service administrators spend a considerable amount of time on maintenance tasks such as managing service passwords and service principal names (SPNs), which are required for Kerberos authentication. In addition, these maintenance tasks can disrupt service.  
  
 The Network Service account is a built-in account that has more access to resources and objects than members of the Domain Users group. Services that run as the Network Service account access network resources by using the credentials of the computer account in the format <domain_name>\\<computer_name>$. The actual name of the account is NT AUTHORITY\NETWORK SERVICE.  
  
<a name="BKMK_MinimumPermissions"></a>   
## Minimum permissions required for Microsoft Dynamics 365 Setup and services  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is designed so that its features can run under separate identities. By specifying a domain user account that is granted only the permissions necessary to enable a particular feature to function, you help secure the system and reduce the likelihood of exploitation.  
  
 This topic describes the minimum permissions that are required by the user account for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] services and features.  
  
### Microsoft Dynamics CRM Server Setup  
 The user account used to run Dynamics 365 Server [!INCLUDE[pn_Setup](../includes/pn-setup.md)] that includes the creation of databases requires the following minimum permissions:  
  
-   Be a member of the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] Domain Users group. By default, [!INCLUDE[pn_Active_Directory_Users_Computers](../includes/pn-active-directory-users-computers.md)] adds new users to the Domain Users group.  
  
-   Be a member of the Administrators group on the local computer where Setup is running.  
  
-   Have Local Program Files folder read and write permission.  
  
-   Be a member of the Administrators group on the local computer where the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is located that will be used to store the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases.  
  
-   Have sysadmin membership on the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that will be used to store the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases.  
  
-   Have organizational unit and security group creation and add membership permission to those groups in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. Alternatively, you can use a Setup XML configuration file to install Dynamics 365 Server when security groups have already been created. For more information, see [Use the Command Prompt to Install Microsoft Dynamics 365](use-command-prompt-install-dynamics-365-server.md).  
  
-   If [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] is installed on a different server, you must add the Content Manager role at the root level for the installing user account. You must also add the [!INCLUDE[pn_System_Administrator_Role](../includes/pn-system-administrator-role.md)] at the site-wide level for the installing user account.  
  
### Microsoft Dynamics 365 services and IIS application pool identity permissions  
 This section lists the minimum permissions that domain user accounts require for the services and the [!INCLUDE[pn_iis](../includes/pn-iis.md)] application pools that [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] uses.  
  
> [!IMPORTANT]
>  -   [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] services and application pool ([!INCLUDE[ui_CRMAppPool](../includes/ui-crmapppool.md)]) identity accounts must not be configured as a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user. Doing so can cause authentication issues and unexpected behavior in the application for all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users.  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Problems in CRM when the CRMAppPool user account is a CRM user](https://go.microsoft.com/fwlink/p/?LinkId=246303)  
> -   Managed service accounts (group-managed service accounts (gMSA) or single-managed service accounts) and virtual accounts (NT SERVICE\\,\<SERVICENAME>) aren't supported for running [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] services.  
  
 The following subsections describe the domain user account permissions required for each service or application pool identity:  
  
 [Microsoft Dynamics 365 Sandbox Processing Service](security-considerations-for-microsoft-dynamics-365.md#BKMK_sandbox_perm)  
  
 [Microsoft Dynamics 365 Asynchronous Processing Service and Microsoft Dynamics 365 Asynchronous Processing Service (maintenance) services](security-considerations-for-microsoft-dynamics-365.md#BKMK_AsyncPerms)  
  
 [Microsoft Dynamics 365 Monitoring Service](security-considerations-for-microsoft-dynamics-365.md#BKMK_MonitorPerm)  
  
 [Microsoft Dynamics 365 VSS Writer service](security-considerations-for-microsoft-dynamics-365.md#BKMK_VSSP)  
  
 [Deployment Web Service (CRMDeploymentServiceAppPool Application Pool identity)](security-considerations-for-microsoft-dynamics-365.md#BKMK_D)  
  
 [Application Service (CRMAppPool IIS Application Pool identity)](security-considerations-for-microsoft-dynamics-365.md#BKMK_APP)  
  
<a name="BKMK_sandbox_perm"></a>   
#### Microsoft Dynamics 365 Sandbox Processing Service  
  
-   Domain Users membership.  
  
-   That account must be granted the **Logon as service** permission in the Local Security Policy.  
  
-   Folder read and write permission on the **Trace**, by default located under \Program Files\Microsoft Dynamics 365\Trace, and user account **%AppData%** folders on the local computer.  
  
-   Read permission to the **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM** subkey in the [!INCLUDE[pn_Windows_registry](../includes/pn-windows-registry.md)].  
  
-   [!INCLUDE[cc_The_service_account_may_need_a_SPN](../includes/cc-the-service-account-may-need-a-spn.md)] To set the SPN for the [!INCLUDE[pn_Sandbox_Processing_Service](../includes/pn-sandbox-processing-service.md)] account, run the following command at a command prompt on the computer where the service is running.  
  
     `SETSPN –a MSCRMSandboxService/<ComputerName> <service account>`  
  
<a name="BKMK_AsyncPerms"></a>   
#### Microsoft Dynamics 365 Asynchronous Processing Service and Microsoft Dynamics 365 Asynchronous Processing Service (maintenance) services  
  
-   Domain Users membership.  
  
-   PrivUserGroup and SQLAccessGroup membership. By default, these groups are created and appropriate membership is granted during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)].  
  
-   Built-in local group Performance Log Users membership.  
  
-   That account must be granted the **Logon as service** permission in the Local Security Policy.  
  
-   Read and write permission on the following folders.  
  
    -   The `Trace` folder. By default located under \Program Files\Microsoft Dynamics CRM\\, and user account `%AppData%` folder on the local computer.  
  
    -   The `CustomizationImport` folder. By default located under \Program Files\Microsoft Dynamics CRM\\. This may be required for solution import when you use the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)].  
  
-   All access permissions except Full Control and Write DAC to the `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM` and `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\MSCRMSandboxService` subkeys in the [!INCLUDE[pn_Windows_registry](../includes/pn-windows-registry.md)].  
  
-   [!INCLUDE[cc_The_service_account_may_need_a_SPN](../includes/cc-the-service-account-may-need-a-spn.md)] To set the SPN for the [!INCLUDE[pn_Asynchronous_Service](../includes/pn-asynchronous-service.md)] account, run the following command at a command prompt on the computer where the service is running.  
  
     `SETSPN –a MSCRMAsyncService/<ComputerName> <service account>`  
  
<a name="BKMK_MonitorPerm"></a>   
#### Microsoft Dynamics 365 Monitoring Service  
  
-   Domain Users membership.  
  
-   That account must be granted the `Logon as service` permission in the Local Security Policy.  
  
-   If the Microsoft Dynamics 365 Monitoring Service is installed with a [!INCLUDE[Front_End_Server](../includes/front-end-server.md)] server role, local administrator group membership on the computer where the service is running is required to monitor the web site and application pools. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Available individual server roles](microsoft-dynamics-365-server-roles.md#BKMK_AvailableIndividual)  
  
-   Read permission to the `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM`  
  
-   SQLAccessGroup membership. By default, this group is created and appropriate membership is granted during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)].  
  
-   [!INCLUDE[cc_The_service_account_may_need_a_SPN](../includes/cc-the-service-account-may-need-a-spn.md)]  
  
<a name="BKMK_VSSP"></a>   
#### Microsoft Dynamics 365 VSS Writer service  
  
-   Domain Users membership.  
  
-   That account must be granted the `Logon as service` permission in the Local Security Policy.  

-   That account must be granted membership of `Backup Operators` group on the server hosting this service. 
  
-   Read permission to the `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM`  
  
-   PrivUserGroup and SQLAccessGroup membership. By default, these groups are created and appropriate membership is granted during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)].  
  
<a name="BKMK_D"></a>   
#### Deployment Web Service (CRMDeploymentServiceAppPool Application Pool identity)  
  
-   Domain Users membership.  
  
-   That account must be granted the `Logon as service` permission in the Local Security Policy.  
  
-   Local administrator group membership on the computer where [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running is required to perform organization database operations (such as create new or import organization).  
  
-   Local administrator group membership on the computer where the [!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)] is running.  
  
-   Sysadmin permission on the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] to be used for the configuration and organization databases.  
  
-   Folder read and write permission on the `Trace` and `CRMWeb` folders, by default located under \Program Files\Microsoft Dynamics CRM\\, and user account `%AppData%` folder on the local computer.  
  
-   All access permissions except Full Control and Write DAC to the `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM` and `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\MSCRMSandboxService` subkeys in the [!INCLUDE[pn_Windows_registry](../includes/pn-windows-registry.md)].  
  
-   PrivUserGroup and SQLAccessGroup membership. By default, these groups are created and appropriate membership is granted during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)].  
  
-   CRM_WPG group membership. This group is used for [!INCLUDE[pn_iis](../includes/pn-iis.md)] worker processes. The group is created and the membership is added during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)].  
  
-   [!INCLUDE[cc_The_service_account_may_need_a_SPN](../includes/cc-the-service-account-may-need-a-spn.md)]  
  
<a name="BKMK_APP"></a>   
#### Application Service (CRMAppPool IIS Application Pool identity)  
  
-   Domain Users group membership.  
  
-   Built-in local group Performance Log Users membership.  
  
-   Folder read and write permission on the `Trace` and `CRMWeb` folders, by default located under \Program Files\Microsoft Dynamics CRM\\, and user account `%AppData%` folder on the local computer.  
  
-   All access permissions except Full Control and Write DAC to the `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSCRM` and `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\MSCRMSandboxService` subkeys in the [!INCLUDE[pn_Windows_registry](../includes/pn-windows-registry.md)].  
  
-   CRM_WPG group membership. This group is used for IIS worker processes. The group is created and the membership is added during [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)].  
  
-   [!INCLUDE[cc_The_service_account_may_need_a_SPN](../includes/cc-the-service-account-may-need-a-spn.md)]  
  
<a name="BKMK_APPID"></a>   
#### IIS Application Pool identities running under Kernel-Mode authentication and SPNs  
 By default, [!INCLUDE[pn_iis](../includes/pn-iis.md)] websites are configured to use Kernel-Mode authentication. When you run the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website by using Kernel-Mode authentication, you might not need to configure additional service principal names (SPNs) for the [!INCLUDE[ui_CRMAppPool](../includes/ui-crmapppool.md)] identities.  
  
For more information about viewing, deleting, and registering SPNs using SetSPN.exe, see [Service Principal Names (SPNs) SetSPN Syntax](https://social.technet.microsoft.com/wiki/contents/articles/717.service-principal-names-spns-setspn-syntax-setspn-exe.aspx).
  
<a name="BKMK_CRMInstallationFiles"></a>   
## Microsoft Dynamics 365 installation files  
 If you plan to install Dynamics 365 from a location on the network, such as a network share, you must make sure that the correct permissions are applied to the folder, preferably on an NTFS volume, where the installation files are located. For example, you may want to allow only members of the Domain Admins group permissions for the folder. This practice can help to reduce the risk of attacks on the installation files that may compromise or alter them. For more information about how to set permissions on files and folders on the Windows operating system, see Windows Help.  
  
## See Also  
 [Planning Your Deployment of Microsoft Dynamics 365](planning-your-deployment-of-microsoft-dynamics-365.md)   </br>
 [Microsoft Dynamics 365 security best practices](security-best-practices-for-microsoft-dynamics-365.md)   </br>




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]