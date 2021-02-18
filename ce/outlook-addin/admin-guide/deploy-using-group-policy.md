---
title: "Deploy Microsoft Dynamics 365 for Outlook by using Group Policy | MicrosoftDocs"
ms.custom: 
ms.date: 11/28/2016
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 9e0b3f19-c041-4cab-a620-339f0d1d8674
caps.latest.revision: 35
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Deploy Microsoft Dynamics 365 for Outlook by using Group Policy
Group Policy provides an infrastructure for centralized configuration management of the operating system and applications, such as [!INCLUDE[pn_crm_for_outlook_full](../../includes/pn-crm-for-outlook-full.md)], that run on the operating system. The Group Policy settings you create are contained in a Group Policy Object (GPO). To create and edit a GPO, use the Group Policy Management Console (GPMC). By using the GPMC to link a GPO to selected [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] sites, domains, and organizational units (OUs), you apply the policy settings in the GPO to the users and computers in those [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] objects. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Group Policy Overview](https://technet.microsoft.com/library/hh831791.aspx)  
  
 Using Group Policy, you can deploy [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. This topic shows you how to perform a Group Policy-based software deployment that publishes [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] making it available for users to install from [!INCLUDE[pn_Control_Panel](../../includes/pn-control-panel.md)]. When you publish software for users, you give them the opportunity to decide if and when they want to install it.  
  
> [!IMPORTANT]
>  You must run the [!INCLUDE[pn_Microsoft_Dynamics_CRM_for_Outlook_Setup](../../includes/pn-microsoft-dynamics-crm-for-outlook-setup.md)] program (SetupClient.exe) by using the administrative installation option (/A) to create a Windows Installer package (CRMClient_*bitversion*.msi) for Group Policy deployment. You cannot use the Windows Installer package (Client.msi) that is included with the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installation files to deploy by using Group Policy. For more information about how to perform an administrative installation, see [Install Microsoft Dynamics 365 for Outlook](install-using-command-prompt.md).  
> 
>  To complete this procedure, you must be a member of the Domain Administrators security group, the Enterprise Administrators security group, or the Group Policy Creator Owners security group.  
  
<a name="BKMK_PreparingGroupPolicy"></a>   
## Preparing Dynamics 365 for Outlook for a Group Policy deployment  
 Use this procedure to create the CRMClient_*bitversion*.msi file that is required for a [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] Group Policy deployment.  
  
### Create the CRMClient_*bitversion*.msi file  
  
1. Before you build the CRMClient_*bitversion*.msi file, you can edit the Default-Client_Config.xml file that is included with the installation files. This file is used by the [!INCLUDE[pn_Outlook_Config_Wiz_long](../../includes/pn-outlook-config-wiz-long.md)] to establish settings, such as the organization URL, after [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is installed on the user’s computer. Although this step is optional, it can simplify [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] configuration for Dynamics 365 users. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Step 2: Configure Microsoft Dynamics 365 for Outlook by using an XML configuration file](install-using-command-prompt.md#BKMK_Step2Configure)  
  
2. Determine the distribution share, and then run [!INCLUDE[pn_Microsoft_Dynamics_CRM_for_Outlook_Setup](../../includes/pn-microsoft-dynamics-crm-for-outlook-setup.md)] to build the administrative installation files.  
  
   > [!IMPORTANT]
   >  The CRMClient_*bitversion*.msi file is used as the package for Group Policy software installation. After you follow this procedure, users can select [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] in [!INCLUDE[pn_Control_Panel](../../includes/pn-control-panel.md)] for on-demand installation. You can’t use the CRMClient_*bitversion*.msi file directly to install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
  
   1. Create a network share that all [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] users will have access to. This share will be the distribution location for the GPO.  
  
   2. Run SetupClient.exe at the command prompt by using the /A and /targetdir parameters. The /A parameter specifies an administrative installation, and /targetdir parameter specifies the distribution share that you created in the previous step. For more information about  [!INCLUDE[pn_Microsoft_Dynamics_CRM_for_Outlook_Setup](../../includes/pn-microsoft-dynamics-crm-for-outlook-setup.md)] command prompt parameters, see [Step 1: Install files](install-using-command-prompt.md#BKMK_Step1Install).  
  
       Example:  
  
      ```  
      setupclient.exe /a /q /targetdir \\FileShare\CRMforOutlook  
  
      ```  
  
   3. Consider using Microsoft Distributed File System (DFS) to help improve the security and availability of your distribution points. For more information about DFS, see [DFS Namespaces and DFS Replication Overview](https://technet.microsoft.com/library/jj127250.aspx). We recommend that you understand the DFS features before you configure your distribution point servers.  
  
3. Create the Group Policy Object (GPO) and target the application to Dynamics 365 users. To do this, follow these steps:  
  
   1. On a domain controller in the domain where Dynamics 365 is installed, start Group Policy Management.  
  
   2. In Group Policy Management, expand **Forest**, **Domains** right-click the domain, and then click **Create a GPO in this domain, and Link it here**.  
  
   3. In the **New GPO** dialog, type a name for the GPO, such as *Microsoft Dynamics 365 apps Users*, and then click **OK**.  
  
       Creating a GPO at the domain level configures the GPO with domain-wide scope.  
  
   4. In the group policy pane, right-click the GPO that you created in the previous step, and then click **Edit**.  
  
       The Group Policy Management Editor opens.  
  
   5. In **Group Policy Management Editor**, under **User Configuration**, expand **Policies**, and then expand **Software Settings**.  
  
   6. Right-click **Software Installation**, point to **New**, and then click **Package**.  
  
   7. Type the full path or locate the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] Windows Installer package (CRMClient_64.msi or CRMClient_32.msi) that was created by the administrative installation, and then click **Open**. For more information about how to create an administrative install package for [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], see the /A parameter in [Install Microsoft Dynamics 365 for Outlook using a Command Prompt](install-using-command-prompt.md).  
  
      > [!IMPORTANT]
      >  The [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] administrative installation folders must be on a network share that can be read-accessed by Dynamics 365 users in the domain.  
      > 
      > [!TIP]
      >  By default, the package name is *Microsoft Dynamics 365 apps \<version> for Outlook* for both 32-bit and 64-bit packages. Consider renaming the package to [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] \<version> 64-(bit) or [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] \<version> (32-bit). This name appears in [!INCLUDE[pn_Control_Panel](../../includes/pn-control-panel.md)] in the list of programs to install from the network.  
  
   8. In the Deploy Software dialog, select **Publish** to publish the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] application, and then click **OK**.  
  
   9. By default, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is available in [!INCLUDE[pn_Control_Panel](../../includes/pn-control-panel.md)] for all authenticated users the next time that they log on to the domain. To limit the scope to a specific organizational unit (OU), group, or individual user, in Group Policy Management, expand **Group Policy Objects**, and click the GPO named *Microsoft Dynamics 365 apps Users*, and then add or remove the security objects that you want, such as a group, in the **Security Filtering** area of the publication on the **Scope** tab.  
  
<a name="BKMK_PublishAssign"></a>   
## Publish versus Assign  
 When you publish an application by using GPO deployment, it is made available for users to install by using Program and Features (or in previous versions of Windows, Add or Remove Programs) in [!INCLUDE[pn_Control_Panel](../../includes/pn-control-panel.md)]. Assigned applications are installed when a user logs on to the domain.  
  
> [!NOTE]
>  [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] doesn’t support application assignment through GPO installation. For more information about publishing versus assigning software, see the Group Policy deployment documentation for your operating system.  
  
### See Also  
 [Install Microsoft Dynamics CRM 2015 for Outlook with roaming user profiles using Windows Server Remote Desktop Services](install-desktop-virtualization.md)   
 [Install or upgrade Language Packs for Microsoft Dynamics 365 apps](https://technet.microsoft.com/library/hh699674.aspx)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]