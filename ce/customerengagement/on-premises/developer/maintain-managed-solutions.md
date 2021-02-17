---
title: "Maintain managed solutions (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 04/02/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 25aab712-8e0e-465e-8295-b0f0664c1d0b
caps.latest.revision: 40
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Maintain managed solutions

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Maintain managed solutions](/powerapps/developer/common-data-service/maintain-managed-solutions).

Before you release your managed solution you should consider how you will maintain it. Uninstalling and reinstalling a managed solution is practically never an option when the solution contains entities or attributes. This is because data is lost when entities are deleted. Fortunately, solutions provide a way to update your managed solution while maintaining the data. Exactly how you update your solutions will depend on the characteristics of the solution and the requirements of the change.  

<a name="BKMK_VersionCompatibilty"></a>   
## Version compatibility  
 Any solution exported from a newer version of Dynamics 365 Customer Engagement (on-premises) cannot be imported into an older version of Dynamics 365 Customer Engagement (on-premises). This includes major and minor versions. Solutions exported from an earlier version of Dynamics 365 Customer Engagement (on-premises) can be imported into later versions as shown in the following chart.  
  
![Solution version compatiblity](media/crm_v9.0_solution_compatibility_chart.png)


> [!NOTE]
> For information about solutions created before [!INCLUDE [pn-crm-2015](../includes/pn-crm-2015.md)] see [Dynamics CRM 2016 Maintain managed solutions > Version compatiblity](https://msdn.microsoft.com/library/gg328109.aspx#BKMK_VersionCompatibilty)
  
 As additional update rollups or service updates are applied to [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], solutions exported from organizations with those updates cannot be imported into organizations which do not have those updates. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Introduction to Solutions: Version compatibility](introduction-solutions.md#BKMK_VersionCompat).  
  
 The `<ImportExportXml>` root element uses a `SolutionPackageVersion` attribute to set the value for the version that the solution is compatible with. You should not manually edit this value.  
  
<a name="BKMK_CreateManagedSolutionUpdates"></a>   
## Create managed solution updates  
 There are two basic approaches to updating solutions:  
  
-   Release a new version of your managed solution  
  
-   Release an update for your managed solution  
  
<a name="BKMK_ReleaseANewVersion"></a>   
### Release a new version of your managed solution  
 The preferred method is to release a new version of your managed solution. Using your original unmanaged source solution, you can make necessary changes and increase the version number of the solution before packaging it as a managed solution. When the organizations that use your solution install the new version, their capabilities will be upgraded to include your changes. If you want to go back to the behavior in a previous version, simply re-install the previous version. This overwrites any solution components with the definitions from the previous version but does not remove solution components added in the newer version. Those newer solution components remain in the system but have no effect because the older solution component definitions will not use them.  
  
 During the installation of a previous version of a solution Dynamics 365 Customer Engagement (on-premises) will confirm that the person installing the previous version wants to proceed.  
  
<a name="BKMK_ReleaseAnUpdate"></a>   
### Release an update for your managed solution  
 When only a small subset of solution components urgently requires a change you can release an update to address the issue. To release an update, create a new unmanaged solution and add any components from the original unmanaged source solution that you want to update. You must associate the new unmanaged solution with the same publisher record as was used for the original solution. After you finish with your changes, package the new solution as a managed solution.  
  
 When the update solution is installed in an organization where the original solution was installed the changes included in the update will be applied to the organization. If an organization needs to 'roll back' to the original version they can simply uninstall the update.  
  
 Any customizations applied to the solution components in the update will be overridden. When you uninstall the update they will return.  
  
### See also  
 [Plan For Solution Development](plan-solution-development.md)   
 [Publish your app on AppSource](publish-app-appsource.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]