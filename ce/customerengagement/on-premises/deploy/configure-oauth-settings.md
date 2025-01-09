---
title: "Configure OAuth settings to change the client session timeout | Microsoft Docs"
description: Learn how to configure OAuth settings to change the session timeout in Dynamics 365 Customer Engagement (on-premises)
ms.custom: ""

ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.author: matp
author: Mattp123
---
# Configure OAuth settings to change the client session timeout

By default, the session lifetime is 24 hours for all Dynamics 365 Customer Engagement (on-premises) clients. You can change the session lifetime by setting the SessionSecurityTokenLifetimeInHours setting to a different value. 

## Requirements  
 - To set up the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] cmdlets, see [Get started using the Dynamics 365 Customer Engagement Management (on-premises) PowerShell cmdlets](/powershell/dynamics365/customer-engagement/overview?view=dynamics365ce-ps&branch=master&preserve-view=true#get-started-using-the-dynamics-365-customer-engagement-management-on-premises-powershell-cmdlets).  
- To change the session lifetime the deployment must be enabled for claims-based authentication. 
  
## Demonstrates
You can use the following script to increase the session lifetime timeout to 48 hours. 

## Example  
  
```powershell  
$RemoveSnapInWhenDone = $False  
  
if (-not (Get-PSSnapin -Name Microsoft.Crm.PowerShell -ErrorAction SilentlyContinue))  
{  
    Add-PSSnapin Microsoft.Crm.PowerShell  
    $RemoveSnapInWhenDone = $True  
}  

$OathClaimsSettings = Get-CrmSetting -SettingType OAuthClaimsSettings

#display current setting
$OathClaimsSettings

$OathClaimsSettings.SessionSecurityTokenLifetimeInHours = 48
Set-CrmSetting $OathClaimsSettings

#display new setting
$OathClaimsSettings

if($RemoveSnapInWhenDone)  
{  
    Remove-PSSnapin Microsoft.Crm.PowerShell  
}  

```  

> [!IMPORTANT]
> - After you run the script run IISRESET on the Dynamics 365 Server running the Web Application server role. Additionally, clients must sign out and then sign in for the new setting to take effect. 



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
