---
title: "Create, install, and update a managed solution (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
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
  - creating managed solutions
  - updating managed solutions
  - managed solutions, creating; installing; and updating
  - creating; installing; and updating managed solutions, installing managed solutions
  - creating; installing; and updating managed solutions, updating managed solutions
  - installing managed solutions
  - solutions, creating; installing; and updating managed solutions
  - creating; installing; and updating managed solutions, creating managed solutions
ms.assetid: 78ec9f71-7845-46c7-be6d-7ac5ade85e28
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Create, install, and update a managed solution

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create, install, and update a managed solution](/powerapps/developer/common-data-service/create-install-update-managed-solution).

You create a managed solution by exporting an unmanaged solution as a managed solution. The organizations that use your managed solution will install it and any updates that you create for it.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use solutions for your customizations](../customize/use-solutions-for-your-customizations.md).  
  
<a name="BKMK_CreateManagedSolution"></a>   
## Create a managed solution  
 Before you can create a managed solution you must first create an unmanaged solution. For more information about how to create an unmanaged solution, see [Create an unmanaged solution](create-export-import-unmanaged-solution.md#BKMK_CreateUnmanagedSolution).  
  
 You create a managed solution by selecting the **Managed** option in the **Package Type** dialog box when exporting the solution.  
  
 A managed solution only includes any customizable solution components that have been customized. Not only does this prevent unintentionally changing existing solution components on the system where the solution is installed, it also keeps the size of the managed solution smaller.  
  
 Before the final step of creating a managed solution, you must decide whether there are any customization capabilities that you do not want to allow people who install your managed solution to perform. Each solution component contains a set of managed properties that control which customization capabilities you want to allow. The default settings allow all customization capabilities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Using Managed Properties](use-managed-properties.md)  
  
 You can create a managed solution programmatically by using the <xref:Microsoft.Crm.Sdk.Messages.ExportSolutionRequest> message. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Export or Package a Solution](work-solutions.md#BKMK_ExportPackageSolution)  
  
> [!IMPORTANT]
>  You should not import a managed solution back into the organization you used to create it.  
  
<a name="BKMK_InstallManagedSolution"></a>   
## Install a managed solution  
 You install a managed solution in the same way you import an unmanaged solution. The difference is in how the solution has been packaged.  
  
> [!IMPORTANT]
>  Installing a solution or publishing customizations can interfere with normal system operation. We recommend that you schedule solution imports when it's least disruptive to users.  
  
 If the solution did not import successfully, you can click **Download Log** in the dialog box to download a report that will provide information about errors that occurred that prevented successful import of the managed solution. This file is an XML document configured to be opened by using [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)].  
  
 You can import or update a managed solution programmatically by using the <xref:Microsoft.Crm.Sdk.Messages.ImportSolutionRequest> message. When using this message, you can request a reference to an `ImportJob`  entity record that will include details about the success of the import. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install or Upgrade a Solution](work-solutions.md#BKMK_InstallUpgradeSolution)  
  
 The <xref:Microsoft.Crm.Sdk.Messages.ImportSolutionRequest> can be called using the <xref:Microsoft.Xrm.Sdk.Messages.ExecuteAsyncRequest>. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use ExecuteAsync to execute messages asynchronously](/powerapps/developer/common-data-service/org-service/use-executeasync)  
  
 There are limits to the size of a solution you can install. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Maximum size of solution to import](create-export-import-unmanaged-solution.md#BKMK_MaxSizeOfSolution)  
  
<a name="BKMK_UpdateManagedSolution"></a>   
### Update a managed solution  
 When you install a managed solution that already exists in the organization, the import solution dialog will provide the following options:  
  
 **Maintain customizations (recommended)**  
 This option maintains any unmanaged customizations performed on components, but also implies that some of the updates included in this solution will not take effect.  
  
 **Overwrite customizations**  
 This option overwrites any unmanaged customizations previously performed on components included in this solution. All updates included in this solution will take effect.  
  
> [!NOTE]
>  You may want to direct people who install your managed solution to use the **Overwrite customizations** option when investigating issues where the customizations conflict with the behavior of your solutions. They should always export their unmanaged solutions first so that they can re-apply them if they need to.  
  
### See also  
 [Package and Distribute Extensions with Dynamics 365 Customer Engagement (on-premises) Solution](package-distribute-extensions-use-solutions.md)   
 [Introduction to Solutions](introduction-solutions.md)   
 [Planning for Solution Development](plan-solution-development.md)   
 [Solution Components and Dependency Tracking](dependency-tracking-solution-components.md)   
 [Create, Export, or Import an Unmanaged Solution](create-export-import-unmanaged-solution.md)   
 [Uninstall or Delete a solution](uninstall-delete-solution.md)   
 [Customization Solutions File Schema](customize-dev/customization-solutions-file-schema.md)
 

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]