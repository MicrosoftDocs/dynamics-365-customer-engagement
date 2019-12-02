---
title: "Update Unified Service Desk  solution | MicrosoftDocs"
description: "Learn how to update Unified Service Desk ."
ms.custom: 
  - dyn365-USD
  - dyn365-admin
ms.date: 08/23/2017
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---

# Updating the solution
Read this topic only if you have an existing installation of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] from the previous release of the Common Data Service platform, and want to update to the latest release.  
  
 If you’re installing [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for the first time, you can skip this topic.  
  
<a name="check"></a>   
## Check if you need to update the Unified Service Desk solution  
 If you’re unsure whether you need to update your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] installation, check the following versions to be sure.  
  
### Check the Unified Service Desk solution version  
 In your Common Data Service platform instance, navigate to the Common Data Service platform, then select **Settings** > **Solutions**. If the version numbers of the solutions match those in the table, you have the latest version of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], and don’t need to update.  
  
|Solution name|Version|  
|-------------------|-------------|  
|UiiForMicrosoftDynamicsCRM2011|4.0.0.xxx|  
|DynamicsUnifiedServiceDesk|4.0.0.xxx|
  
<a name="UpdateSolutions"></a>   
## Update Unified Service Desk solutions  
 Before you update your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] solutions, ensure that the version of your Customer Engagement (on-premises) organization is [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)], [!INCLUDE[pn_crm_2015_shortest](../../includes/pn-crm-2015-shortest.md)], or [!INCLUDE[pn_crm_2013_sp_shortest](../../includes/pn-crm-2013-sp-shortest.md)].  
  
1. [Download the Unified Service Desk package file](http://go.microsoft.com/fwlink/p/?LinkID=2007340) (CRM2016-8.x.x-USD-PackageDeployer.exe), and save it on your computer.  
  
2. Run the downloaded file to extract the contents into a folder.  
  
3. After the files are extracted, if the [!INCLUDE[pn_package_deployer_tool](../../includes/pn-package-deployer-tool.md)] starts automatically, close it.  
  
4. In the extracted folder, locate the following two solution files in the USDPackageDeployer\\*\<PackageName>* folder, where *\<PackageName>* is the name of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package you currently have installed in your Common Data Service platform instance:  
  
   - UiiForMicrosoftDynamicsCRM_3_0_managed.zip  
  
   - DynamicsUnifiedServiceDesk_1_0_managed.zip 

   - UnifiedInterfaceDemoCustomization_1_0_managed.zip 
  
     For example, if you currently have Base package installed, you must navigate to the USDPackageDeployer\BasePackage folder to find the solution files for updating.  
  
5. Sign in to the Common Data Service platform.  
  
6. Go to **Settings** > **Solutions**.   
  
7. On the **Actions** toolbar, click **Import**.  
  
8. Browse to the UiiForMicrosoftDynamicsCRM_3_0_managed.zip file in the appropriate folder as explained in step 4, and select to import it to update the existing solution in your Common Data Service platform instance.  
  
9. The next page will display a yellow bar saying **This solution package contains an update for a solution that is already installed**. Review the information about the solution, and click **Next**.  
  
10. On the next page, select the **Maintain customizations (recommended)** option and ensure that the **Enable any SDK message processing steps included in the solution** check box is selected. Click **Next**.  
  
     After the solution import completes successfully, the **UiiForMicrosoftDynamicsCRM** solution is updated.  
  
11. Repeat steps 7-10 for the DynamicsUnifiedServiceDesk_1_0_managed.zip and UnifiedInterfaceDemoCustomization_1_0_managed.zip file to update the **DynamicsUnifiedServiceDesk** and 
  solution in your Common Data Service platform instance.  
  
     For detailed information about updating solutions in the Common Data Service platform, see [Import, update, and export solutions](/dynamics365/customer-engagement/customize/import-update-export-solutions).  
  
12. In the Common Data Service platform, verify the version numbers of the updated solutions with those listed in the table shown earlier to ensure they’re the latest versions.  
  
13. Close the browser instance, and sign in again to the Common Data Service platform to see the new features in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [What's new in Unified Service Desk for administrators](../../unified-service-desk/admin/whats-new-unified-service-desk-administrators.md).  
  
## See also  
 [Connect to the Common Data Service platform instance using the Unified Service Desk client](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md)   
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)   
