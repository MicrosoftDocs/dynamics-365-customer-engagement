---
title: "Configure Microsoft Dynamics 365 for Outlook to use claims-based authentication | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: ffd43c4a-2ba1-4ab5-b86c-ed3bcf29cd5d
caps.latest.revision: 24
ms.author: matp
author: Mattp123
manager: kvivek
---
# Configure Microsoft Dynamics 365 for Outlook to use claims-based authentication



In an environment that supports claims-based authentication, a client (such as [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]) can use federated [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] to connect to the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. The client obtains credentials through federated [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] and uses these credentials to be authenticated on the same or a different [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain to connect to the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
 You can connect [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] on one [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain to a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server in a different [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain. You can do this when the credentials that [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] uses on its own domain are authenticated by a server on the other domain. To make this work, use [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)].  
  
 After federation is established, the client can use either its current domain credentials or different domain credentials when attempting to connect to the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. You specify which domain and which [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] to use through the home realm - an identity provider that authenticates the user.  
  
> [!NOTE]
>  For external claims-based authentication deployments, use the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] website's external address (for example: https://orgname.contoso.com) for the **Server URL** connection setting.  
  
## Set up a client for claims-based authentication  
 In the following procedure, you create a registry key on a single client computer. You may also want to consider using group policy so that you can make this registry change on multiple client computers.  
  
1.  Make sure that a web browser on the client can reach the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] URL with no certificate errors. If you use a self-signed certificate, you will need to import it to avoid certificate errors. After you import any needed certificates, you should be able to connect to the organization by using non-federated credentials.  
  
2.  To use federated credentials, specify HomeRealmUrl in the Windows registry, as shown here:  
  
    > [!NOTE]
    >  This registry key is only needed if the claims provider server is different from the claims provider server used by [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]; for example, the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] client authenticates across realms to a different domain.  
  
    1.  With Administrator privileges, open the Registry Editor.  
  
    2.  Open the registry key **HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\MSCRMClient**.  
  
    3.  Create the registry string **HomeRealmUrl**.  
  
    4.  Enter the value data of the federated [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)]. This URL will end in /adfs/services/trust/mex.  For example, https://adfs.contoso.com/adfs/services/trust/mex.  
  
    5.  Close the Registry Editor.  
  
    6.  Configure [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up Dynamics 365 for Outlook](../../../outlook-addin/user-guide/set-up.md) 
  
 You should now be able to connect [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] to [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] by using claims-based authentication.  
  
## Use an administrative template (.adm) file  
 Modify the following sample data to create an .adm file to use group policy to publish the HomeRealmUrl registry setting.  
  
```  
CLASS MACHINECATEGORY "Microsoft CRM"    KEYNAME "Software\Policies\Microsoft\MSCRMClient"   POLICY "Home Realm URL"      EXPLAIN "Allow Administrator to specify the Home Realm URL for federated domains."      PART "Specify Home Realm URL (example: https://adfs.contoso.com/adfs/services/trust/mex" EDITTEXT REQUIREDVALUENAME "HomeRealmUrl"      END PART   END POLICYEND CATEGORY  
```  
  
 For more information, see [Administrative Template File Format](/previous-versions/windows/desktop/Policy/administrative-template-file-format).  
  
## See Also  
 [Install Dynamics 365 for Outlook](../../../outlook-addin/admin-guide/install.md)   </br>
 [Configure IFD for Microsoft Dynamics 365](configure-ifd-for-dynamics-365.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]