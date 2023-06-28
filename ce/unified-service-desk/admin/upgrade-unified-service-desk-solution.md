---
title: "Upgrade a Unified Service Desk solution | MicrosoftDocs"
description: "Learn how to upgrade Unified Service Desk sample application package to the latest version using the upgrade procedure."
ms.date: 06/21/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - admin
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---
# Upgrade Unified Service Desk

You can upgrade an existing Unified Service Desk sample application package to the latest Unified Service Desk by importing the Upgrade sample application package. The upgrade won't affect the configuration data associated with the existing solution.  
  
## Upgrade a Unified Service Desk sample application package
  
1. [Download](../download-unified-service-desk.md) the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample application packages and [!INCLUDE[pn_package_deployer_long](../../includes/pn-package-deployer-long.md)] tool.  
  
2. Start [!INCLUDE[pn_package_deployer_long](../../includes/pn-package-deployer-long.md)], that'll be used to import the **Upgrade** sample application package. Alternatively, you can use [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] commands. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Import-CrmPackage](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/dn756301(v=crm.8))  
  
3. In the **Package Deployer** window, select **Continue**.  
  
4. Connect to the organization that you want to upgrade the current [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] solution.  
  
5. On the **Multiple Import Package** page, select **Unified Service Desk – Upgrade**, and then select **Next**.  
  
   ![Select the import package.](../../unified-service-desk/media/usd-select-package.png "Select the import package")  
  
6. On the **Welcome to the Unified Service Desk – Upgrade Setup Tool** page, review the information about the components that'll be upgraded, and then select **Next**.  
  
   ![Unified Service Desk upgrade details.](../../unified-service-desk/media/usd-upgrade-details.png "Unified Service Desk upgrade details")  
  
7. On the **Ready to Install** page, select **Next** to verify the components to upgrade.  
  
8. On the **Reading Unified Service Desk – Upgrade Installer Configuration** page, select **Next** to begin the upgrade.  
  
   ![Upgrade in progress.](../../unified-service-desk/media/usd-upgrade-progress.png "Upgrade in progress")  
  
9. The **Executing Install Actions** page appears. The installation can take several minutes.  
  
10. Select **Finish** to complete the upgrade. 
  
### See also  

[Install, upgrade, and deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)
[Unified Service Desk system requirements](unified-service-desk-system-requirements.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
