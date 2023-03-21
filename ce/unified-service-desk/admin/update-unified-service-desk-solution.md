---
title: "Update Unified Service Desk solution | MicrosoftDocs"
description: "Learn how to check the current version and update your existing installation of Unified Service Desk to the latest version, if required."
ms.date: 06/21/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---

# Update Unified Service Desk solution

Read this article only if you have an existing installation of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] from the previous release of Microsoft Dataverse, and want to update to the latest release.  
  
If you’re installing [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for the first time, you can skip this article.  
  
<a name="check"></a>

## Check your Unified Service Desk solution version number

To determine whether you need to update your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] installation, you must check your solution version number to see if it's the latest.
  
In your Dataverse instance, navigate to Dataverse, then select **Settings** > **Solutions**. If the version numbers of the **UiiForMicrosoftDynamicsCRM2011** and **DynamicsUnifiedServiceDesk** solutions match those that are mentioned in the following table, then you have the latest version of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  

|Unified Service Desk version|Solution version number |  
|----------------------------|-----------------------|  
|Unified Service Desk 4.2    |  4.2.0.51    |  
|Unified Service Desk 4.1    |  4.1.1.1433    |
|Unified Service Desk 4.0    |  4.0.0.993    |
|||
  
<a name="UpdateSolutions"></a>

## Update Unified Service Desk solutions  

 Before you update your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] solutions, ensure that the version of your Customer Engagement (on-premises) organization is [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)], [!INCLUDE[pn_crm_2015_shortest](../../includes/pn-crm-2015-shortest.md)], or [!INCLUDE[pn_crm_2013_sp_shortest](../../includes/pn-crm-2013-sp-shortest.md)].  
  
1. [Download the Unified Service Desk package file](https://go.microsoft.com/fwlink/p/?LinkID=2159819) (Dynamics365-USD-4.2.0.51-PackageDeployer.exe) and extract the contents to a folder on your computer.
2. Run the **PackageDeployer** executable file. For more information about how to deploy the package, see [Deploy a Unified Service Desk package using Package Deployer](/admin/deploy-sample-unified-service-desk-applications-using-package-deployer?view=dynamics-usd-4.2#deploy-a-sample-unified-service-desk-package-using-package-deployer&preserve-view=true.).

3. When prompted, select the **Unified Service Desk - Upgrade** package. Then the latest solutions will get imported.

### See also

[Connect to Dataverse instance using the Unified Service Desk client](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md)  
[Install and deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)  
[Upgrade Unified Service Desk](upgrade-unified-service-desk-solution.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
