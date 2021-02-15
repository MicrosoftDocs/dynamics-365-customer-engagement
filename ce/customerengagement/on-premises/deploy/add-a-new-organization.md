---
title: "Add a new organization | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0370ff17-bcb8-41d4-ba58-5dda590d8949
caps.latest.revision: 18
author: Mattp123
ms.author: matp
manager: kvivek
---
# Add a new organization



You can add a new organization in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment in the Organizations node of [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
> [!NOTE]
> To add an organization, you must be a member of the domain where [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is installed. You cannot add an organization as a member of a child or a trusted domain.  
<!-- >  -   Not all versions of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] allow you to add multiple organizations.  -->
  
> [!TIP]
>  The procedure described here can be implemented by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see the [New-CrmOrganization](/powershell/module/microsoft.crm.powershell/new-crmorganization?view=dynamics365ce-ps) command.  
  
1.  In the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] console tree, right-click **Organizations**, and then select **New Organization** to open the New Organization Wizard.  
  
2.  On the **Specify the Organization Settings** page, enter the following information:  
  
    -   In the **Display Name** box, type the name of your organization.  
  
    -   In the **Name** box, keep the name that is automatically generated or type a unique name. The name is limited to 30 characters. Spaces and extended characters are not allowed.  
  
    -   Under **ISO currency code**, select **Browse**, select the ISO currency code for the base currency for the organization, and then select **OK**. You can change the currency's symbol, name, or precision.  
  
    -   In the **Base Language** list, select the base language for the organization. In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], only the base language of the first organization is tied to the language of the server installation. All other organizations can have different base languages, but you must first install [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Language Packs for the other language. For instructions about how to install a Language Pack, see [Install and enable a Language Pack](install-and-enable-a-language-pack.md).  
  
    -   In the **SQL collation** list, keep the default selection or select a different collation that the organization database will use to sort and compare data characters.  
  
    -   The default SQL collation changes based on the base language selection. For more information, see [Collation and Unicode Support](/sql/relational-databases/collations/collation-and-unicode-support?view=sql-server-2017).  
  
3.  Select **Next**.  
  
    > [!IMPORTANT]
    >  After the New Organization Wizard is finished, you cannot change the organization name, base ISO currency code, or [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] database collation.  
  
4.  On the **Help Us Improve the Customer Experience** page, select whether you want users in the new organization to be able to participate in the [!INCLUDE[pn_Customer_Experience_Program](../includes/pn-customer-experience-program.md)], and then select **Next**.    
  
5.  On the **Select SQL Server** page, type or select the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that will be used for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database, and then select **Next**.  
  
6.  On the **Specify Reporting Services Server** page, type the report server URL. (Make sure you use the Microsoft SQL Report Server URL, not the Report Manager URL.) Then, select **Next**.  
  
7.  The **System Checks** page validates your organization.  
  
     Failed tests must be corrected before a new organization can be added. If necessary, cancel the New Organization Wizard, fix the problem, resolve all errors, and then start the New Organization Wizard again.  
  
     If no errors, or only warnings, appear, select **Next**.  
  
8.  Review the **Ready to Create** page, and then select **Create**.  
  
9. On the **New Organization** page, select **Finish**.  
  
## See also  
 [Manage organizations](manage-organizations.md)   
 [Import an organization](import-an-organization.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]