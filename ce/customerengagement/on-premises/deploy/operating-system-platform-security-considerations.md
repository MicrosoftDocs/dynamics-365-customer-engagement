---
title: "Operating system and platform technology security considerations for Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 833034aa-73b6-475a-8fde-0060ebeb7726
caps.latest.revision: 28
ms.author: matp
author: Mattp123
manager: kvivek
---
# Operating system and platform technology security considerations for Dynamics 365 Customer Engagement (on-premises)



In the broadest sense, security involves planning and considering tradeoffs between threats and access. For example, a computer can be locked in a vault and available only to one system administrator. This computer may be secure, but it’s not very usable because it’s not connected to any other computer. If your business users need access to the Internet and your corporate intranet, you must consider how to make the network both secure and usable.  
  
 In this topic you’ll find helpful information and links to many resources you can use to make your computing environment more secure. Because ultimately, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data security largely depends on how well you first secure the operating system and software components.  
  
  
<a name="BKMK_SecuringWindows"></a>   
## Securing Windows Server  
 [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)], the foundation of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], provides sophisticated network security. The Kerberos version 5 authentication protocol that is integrated into [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] and [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] lets you federate [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domains by using claims-based authentication. Both give you powerful standards-based authentication. These authentication standards let users enter a single user name and password sign-in combination for resource access across the network. [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] also includes several features that help make the network even more secure.  
  
 Follow these links to learn more about these features and how to make your [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] deployment more secure:  
 
  -   [Dynamics Access Control: Scenario Overview](/windows-server/identity/solution-guides/dynamic-access-control--scenario-overview)   
  -   [Securing Priviliged Access](/windows-server/identity/securing-privileged-access/securing-privileged-access) 
    
### Windows error reporting  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] requires the Windows Error Reporting (WER) service, which Setup will install if it is missing. The [!INCLUDE[pn_WER_short](../includes/pn-wer-short.md)] service collects information, such as IP addresses. These IP addresses are not used to identify users. The [!INCLUDE[pn_WER_short](../includes/pn-wer-short.md)] service does not intentionally collect names, addresses, email addresses, computer names, or any other form of personally identifiable information (PII). It is possible that such information may be captured in memory or in the data collected from open files, but [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] does not use it to identify users. In addition, some information that is transmitted between the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application and [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] may not be secure. For more information about the type of information that is transmitted, see [Privacy statement for the Microsoft Error Reporting Service](https://go.microsoft.com/fwlink/p/?LinkID=200371).  
  
  
### Update management  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] updates include security, performance, and functional improvements. Making sure your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] applications have the latest updates helps make sure your system runs as efficiently and reliably as it can. You can find more information about how to manage updates here:  
  
-   [Windows Server Semi-Annual Channel overview](/windows-server/get-started/semi-annual-channel-overview)  
  
  
<a name="BKMK_SecuringSQL"></a>   
## Securing SQL Server  
 Because [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] relies on [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], make sure you take the following measures to improve the security of your [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] database:  
  
-   Apply the latest operating system, [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] service packs (SPs), and updates. Check the [Microsoft Security](https://go.microsoft.com/fwlink/p/?linkid=92540) website for the latest details.  
  
-   Install all [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] data and system files on NTFS partitions for file system-level security. You should make the files available only to administrative or system-level users through NTFS permissions. This helps safeguard against users who access those files when the MSSQLSERVER service is not running.  
  
-   Use a low-privilege domain account. Or, specify the Network Service or Local System Account for [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] services. However, we do not recommend that you use these accounts because Domain User accounts can be configured with fewer permissions to run the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] services. Domain User accounts should have minimal rights in the domain, which should help contain (but will not stop) an attack on the server if there is a compromise. In other words, Domain User accounts should have only local user-level permissions in the domain. If [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is installed using a Domain Administrator account to run the services, a compromise of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] will lead to a compromise of the entire domain. If you have to change this setting, use [!INCLUDE[pn_SQL_Server_Management_Studio](../includes/pn-sql-server-management-studio.md)] to make the change, because the access control lists (ACLs) on files, the registry, and user rights will be changed automatically.  
  
-   Because [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] authenticates users who have either [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)] or [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] credentials, we suggest you use [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)] for single sign-on convenience and the most secure authentication.  
  
-   At a minimum, enable auditing of failed sign-ins. By default, [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] system auditing is disabled, and no conditions are audited. This makes intrusion detection difficult and helps attackers cover their tracks.  
  
-   [!INCLUDE[pn_Report_Server](../includes/pn-report-server.md)] administrators should enable RDL Sandboxing to restrict access to the [!INCLUDE[pn_Report_Server](../includes/pn-report-server.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Enabling and Disabling RDL Sandboxing](/sql/reporting-services/report-server-sharepoint/enable-and-disable-rdl-sandboxing?view=sql-server-2017)  
  
-   Configure each SQL logon to use the master database as the default database. Although users shouldn’t have rights to the master database, as a best practice, you should change the default for every SQL logon (except those with the SYSADMIN role) to use *OrganizationName*_MSCRM as the default database. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Securing SQL Server](https://go.microsoft.com/fwlink/p/?LinkID=200479)  
  
<a name="BKMK_SecuringExchange"></a>   
## Securing Exchange Server and Outlook  
 The following considerations are for [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] or [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] in a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] environment:  
  
-   [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] contains a rich series of mechanisms for precise administrative control of its infrastructure. In particular, you can use administrative groups to collect [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] objects like servers, connectors, or policies, and then modify the ACLs on those administrative groups to make sure only certain users can access them. You may, for example, want to give [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] administrators control over servers that directly affect their applications. When you implement administrative groups efficiently, you know you are giving [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] administrators exactly the rights they need to do their jobs.  
  
-   Frequently, you may find it convenient to create a separate organizational unit (OU) for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users, and give [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] administrators limited administrative rights over that OU. Administrators can make changes for any user in that OU, but not for any user outside it.  
  
-   Always be sure you adequately protect against unauthorized email relay. Email relay lets an [!INCLUDE[pn_SMTP](../includes/pn-smtp.md)] client use an [!INCLUDE[pn_SMTP](../includes/pn-smtp.md)] server to forward email messages to a remote domain. By default, [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] is configured to prevent email relay. The settings you configure will depend on your message flow and how your Internet service provider's (ISP) email server is configured. However, the best approach here is to lock down your email relay settings and then gradually open them to let email flow successfully. For more information, see the [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] Help.  
  

<a name="BKMK_securingMobile"></a>   
## Securing mobile devices  
 As organizations move to support an increasingly mobile workforce, strong security remains essential. Here are some resources to help you implement best practices for mobile devices, such as smartphones and tablets:  

-   [Microsoft Intune](https://www.microsoft.com/cloud-platform/microsoft-intune)  
  
-   [iOS in Business](https://www.apple.com/ipad/business/it-center/security.html) (iPad and iPhone)  
  
## See Also  
 [Planning Your Deployment of Microsoft Dynamics 365](planning-your-deployment-of-microsoft-dynamics-365.md)   </br>
 [Setup overview for mobile apps](../../../mobile-app/set-up-dynamics-365-for-phones-and-dynamics-365-for-tablets.md)  </br>




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]