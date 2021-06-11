---
title: "Sample server XML configuration file for installing with pre-created groups | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 1d79f2c1-6e09-48d1-830e-f68e98de7efb
caps.latest.revision: 13
ms.author: matp
author: Mattp123
manager: kvivek
---
# Sample server XML configuration file for installing with pre-created groups

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

By default, Setup creates four [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] security groups that are used by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. You can create these groups in advance and then provide the information for the groups in the Setup configuration file.  
  
 To use the pre-created [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service security groups, create an XML configuration file that uses the LDAP distinguished name syntax that is similar to the following example. Modify the variables as appropriate.  
  
 For example, the following sample would be used when the Organizational unit (OU) where the pre-created groups (PrivUserGroup, SQLAccessGroup, ReportingGroup, and PrivReportingGroup) are located is named *CRM* and the full domain name where the OU is located is *sales.contoso.com*.  
  
> [!IMPORTANT]
>  The user who runs [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] must have **Add User or Group** permission to these [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] groups. For more information about how to assign user rights to a group in [!INCLUDE[pn_Active_Directory_Domain_Services](../includes/pn-active-directory-domain-services.md)], see the [!INCLUDE[pn_Active_Directory_Users_Computers](../includes/pn-active-directory-users-computers.md)] Help.  
>   
>  Because the organizational unit will be specified when you use the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] groups \<GROUPS> element, you cannot specify the organizational unit again using the \<OU> element.  
>   
>  The \<Groups> element must be inside the \<Server> and \<CRMSetup> elements. For syntax structure, see [Microsoft Dynamics 365 Server XML configuration file](microsoft-dynamics-365-server-xml-configuration-file.md).  
  
```  
<Groups AutoGroupManagementOff="false">  
    <PrivUserGroup>CN=PrivUserGroup,OU=CRM,DC=sales,DC=contoso,DC=com</PrivUserGroup>  
    <SQLAccessGroup>CN=SQLAccessGroup,OU=CRM,DC=sales,DC=contoso,DC=com</SQLAccessGroup>  
    <ReportingGroup>CN=ReportingGroup,OU=CRM,DC=sales,DC=contoso,DC=com</ReportingGroup>  
    <PrivReportingGroup>CN=PrivReportingGroup,OU= CRM,DC=sales,DC=contoso,DC=com</PrivReportingGroup>  
</Groups>  
  
```  
  
## See Also  
 [Microsoft Dynamics 365 Server XML configuration file](microsoft-dynamics-365-server-xml-configuration-file.md)   </br>
 [Install Microsoft Dynamics 365 Server roles using the command prompt](install-using-command-prompt.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]