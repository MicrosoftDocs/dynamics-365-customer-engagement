---
title: "Uninstall or delete a solution (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This doc describes how uninstall and delete actions work for managed and unmanaged solution in Dynamics 365 Customer Engagement"
ms.custom: 
ms.date: 04/02/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - uninstalling or deleting solutions, deleting unmanaged solutions
  - uninstalling or deleting solutions, results of deleting managed vs. unmanaged solutions
  - uninstalling or deleting solutions, how to
  - deleting managed vs. unmanaged solutions, results of
  - uninstalling or deleting solutions, deleting (uninstalling) managed solutions
  - deleting (uninstalling) managed solutions
  - deleting unmanaged solutions
ms.assetid: 0201e06a-2102-4ea1-a348-93714226e175
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Uninstall or delete a solution

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Uninstall or delete a solution](/powerapps/developer/common-data-service/uninstall-delete-solution).

You delete managed and unmanaged solutions in the same way, but the resulting actions are very different. Deleting a managed solution will uninstall the managed solution.  
  
<a name="BKMK_DeleteSolution"></a>   
## Delete a solution  
 Depending on the type of solution that you want to delete, you'll see one of the following **Confirm Deletion** messages:  
  
 **Managed solution**  
 "You are deleting a managed solution. The solution and all its components will be deleted. This action cannot be undone. This solution might take several minutes to uninstall. You cannot cancel the uninstallation after it starts. Do you want to continue?"  
  
 **Unmanaged solution**  
 "You are deleting an unmanaged solution. The solution will be deleted but components that are contained in this solution will not be deleted. This action cannot be undone. Do you want to continue?"  
  
 To delete a solution programmatically use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*> method. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Delete a Solution](work-solutions.md#BKMK_DeleteSolution)  
  
<a name="BKMK_UinstallAManagedSolution"></a>   
### Uninstall a managed solution  
 Deleting a managed solution will uninstall the solution. All the solution components defined in it are deleted.  
  
> [!IMPORTANT]
>  When you uninstall a managed solution, the following data is lost: data stored in custom entities that are part of the solution and data stored in custom attributes on system entities that are part of the solution.  
  
<a name="BKMK_DeleteUnmanagedSolution"></a>   
### Delete an unmanaged solution  
 An unmanaged solution is a group of solution components. Deleting the solution deletes a single solution record in the database. Solution components are not affected by the solution being deleted, they remain in the system.  
  
<a name="BKMK_AccessSolutionsGridWithUrl"></a>   
## Access the solutions list with a URL  
 If you need to navigate directly to the solutions list you can use the following URL:  
  
```
<organization root url>/tools/Solution/home_solution.aspx?etn=solution  
```  
  
### See also  
 [Package and Distribute Extensions with Dynamics 365 Customer Engagement Solutions](package-distribute-extensions-use-solutions.md)   
 [Delete a Solution](work-solutions.md#BKMK_DeleteSolution)   
 [Introduction to Solutions](introduction-solutions.md)   
 [Planning for Solution Development](plan-solution-development.md)   
 [Solution Components and Dependency Tracking](dependency-tracking-solution-components.md)   
 [Create a Managed Solution](create-install-update-managed-solution.md#BKMK_CreateManagedSolution)   
 [Export an unmanaged solution](create-export-import-unmanaged-solution.md#BKMK_UnmanagedSolution)   
 [Import an unmanaged solution](create-export-import-unmanaged-solution.md#BKMK_ImportUnmanagedSolution)   
 [Create a Managed Solution](create-install-update-managed-solution.md#BKMK_CreateManagedSolution)   
 [Create Solutions that Support Multiple Languages](create-solutions-support-multiple-languages.md)   
 [Install a Managed Solution](create-install-update-managed-solution.md#BKMK_InstallManagedSolution)
 

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]