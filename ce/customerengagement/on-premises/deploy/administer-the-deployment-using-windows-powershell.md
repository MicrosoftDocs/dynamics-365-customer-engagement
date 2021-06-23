---
title: "Administer the deployment using Windows PowerShell | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: f5f906a0-24ad-4888-bb10-6a783cc56473
caps.latest.revision: 35
ms.author: matp
author: Mattp123
manager: kvivek
---
# Administer the deployment using Windows PowerShell



With [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] you can easily run deployment commands to change the configuration of your deployment, like tasks that can be performed from the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] user interface.  You can also use the methods described in the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)] to perform these tasks. The [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] cmdlets are installed on the computer when you install a Full Server role or when you install the [!INCLUDE[pn_Deployment_Tools](../includes/pn-deployment-tools.md)] server role, if you’re installing individual server roles. To execute commands, you must first register the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] commands with [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)]. This topic describes how to do this plus additional tasks to help you use  [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)].  
  
 Find help about the [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] cmdlets for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] at [Microsoft Dynamics 365 PowerShell Reference](/powershell/dynamics365/customer-engagement/overview?view=dynamics365ce-ps).  
  
 For more information about using [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)], see [PowerShell](/powershell/scripting/powershell-scripting?view=powershell-6).  
  
 For more information about the programmatic use of the [!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)], see [MSDN: Administer the deployment using the deployment web service](/previous-versions/dynamicscrm-2016/developers-guide/gg327886(v=crm.8)).  

<!--   
<a name="configure"></a>   
## Get started using the Dynamics 365 PowerShell cmdlets  
  
#### Register the cmdlets  
  
1.  Sign in to the administrator account on your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server.  
  
2.  Open a [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] command prompt.  
  
3.  Enter the following command.  
  
    ```powershell  
    Add-PSSnapin Microsoft.Crm.PowerShell  
    ```  
  
     This command adds the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)][!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] snap-in to the current session. The snap-in is registered during installation and setup of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server.  
  
> [!IMPORTANT]
>  -   For information about registering the XRM tooling connector cmdlets, Get-CrmConnection and Get-CrmOrganizations, see [MSDN: Use PowerShell cmdlets for XRM tooling to connect to CRM](/previous-versions/dynamicscrm-2016/developers-guide/dn689040(v=crm.8)).  
> -   For information about registering the Package Deployer cmdlets, see [Deploy packages using CRM Package Deployer and Windows PowerShell](../admin/deploy-packages-using-package-deployer-windows-powershell.md).  
> -   You must register the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)][!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] commands; otherwise you’ll receive the following message when you try to run a cmdlet.  
>   
>      The term ‘*Microsoft Dynamics 365 Windows PowerShell command*' is not recognized as the name of a cmdlet, function, script file, or operable program. Check the spelling of the name, or if a path was included, verify that the path is correct and try again.  
  
#### Get a list of the Dynamics 365 cmdlets  
  
-   At the [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] prompt, type the following.  
  
    ```powershell  
    Get-Help *Crm*  
    ```  
  
#### Get help for a cmdlet  
  
-   At the [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] prompt, type the following, replacing *CrmCmdletName* with the name of a command.  
  
    ```powershell  
    Get-Help CrmCmdletName  
    ```  
  
 For detailed help for a specific cmdlet, use Get-Help*CRMCmdlet*–full, such as the `Import-CRMOrganization` cmdlet.  
  
```powershell  
Get-Help Import-CRMOrganization -full  
```  
  
<a name="usecmds"></a>   
## Use the PowerShell cmdlets  
 When you have registered the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)][!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] commands, you can use them to perform tasks.  
  
 Use the following command to output the list of deployment administrators.  
  
```powershell  
PS C:\Users\Administrator> Get-CrmDeploymentAdministrator  
```  
  
 This command results in the following output.  
  
||||  
|-|-|-|  
|`Id`|`Name`|`ExtensionData`|  
|`--`|`----`|`-------------`|  
|`4f431656-90f8-e211-831c-00155da83c4f`|`myDomainName\Administrator`||  
  
<a name="setproperties"></a>   
## Set properties using PowerShell cmdlets  
 When you have registered the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)][!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] commands, you can use them to perform tasks, such as set deployment-wide properties or set some organization properties.  
  
 For example, to add a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment administrator, run the following command where *domain\adminName* is the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain and user name of the administrator you want to add.  
  
```powershell  
New-CrmDeploymentAdministrator domain\adminName  
```  
  
<a name="list"></a>   
## Get Dynamics 365 PowerShell cmdlet Help topics  
 For  a complete list of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)][!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] cmdlets with links to Help topics, see the [Microsoft Dynamics CRM PowerShell Reference](/previous-versions/dynamicscrm-2015/deployment-administrators-guide/dn833081(v=crm.7)).  
  
<a name="BKMK_deploy"></a>   
## Update deployment configuration settings using PowerShell  
 Use [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] to update deployment-wide settings, such as claims-based authentication, Internet-facing deployment (IFD), and web addresses. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Update deployment configuration settings](update-deployment-configuration-settings.md)  -->
  
## See Also  
[Microsoft.Crm.PowerShell](/powershell/module/microsoft.crm.powershell/?view=dynamics365ce-ps)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]