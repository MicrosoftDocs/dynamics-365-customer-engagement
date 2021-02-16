---
title: "Using Windows PowerShell to perform Deployment Manager tasks | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 54cc820e-ddb6-4c0f-803f-eed5093359c7
caps.latest.revision: 14
author: Mattp123
ms.author: matp
manager: kvivek
---
# Using Windows PowerShell to perform Deployment Manager tasks



You can use [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlets to perform many of the tasks that can be performed by using the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] user interface.  
  
 For more information about the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlets, see [Overview of Dynamics 365 Customer Engagement (on-premises) PowerShell](/powershell/dynamics365/customer-engagement/overview?view=dynamics365ce-ps).  
  
### Register the Microsoft Dynamics 365 Customer Engagement (on-premises)  cmdlet  
  
1.  Sign in to the administrator account on your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server.  
  
2.  Open a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] prompt.  
  
3.  Add the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] snap-in.  
  
```  
PS > Add-PSSnapin Microsoft.Crm.PowerShell   
```  
  
 This command adds the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] snap-in to the current session. The snap-in is registered during installation and setup of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server.  
  
 Here’s how to get a list of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] cmdlets.  
  
```  
Get-Help *Crm*  
```  
  
 For detailed help for a specific a cmdlet, use Get-Help *CRMCmdlet* –full, such as the `Import-CRMOrganization` cmdlet.  
  
```  
Get-Help Import-CRMOrganization  
```  
  
## See also  
 [Use Deployment Manager to manage the deployment](use-deployment-manager-to-manage-the-deployment.md)   




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]