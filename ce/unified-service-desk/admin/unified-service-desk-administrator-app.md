---
title: "Use Unified Service Desk Administrator app to administrate and manage Unified Service Desk client | MicrosoftDocs"
description: "Learn how to use Unified Service Desk Administrator app to administrate Unified Service Desk client."
keywords: ""
ms.date: 08/03/2018
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - "dyn365-USD, dyn365-admin"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 6190932E-FE9C-4167-B33D-C360A4E5D8F4
author: kabala123
ms.author: kabala
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Preview feature: Administer and manage Unified Service Desk using the Administrator app

## Overview

With [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] 4.0, you can use [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator App built on the Unified Interface framework to administer and manage the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app is built on the Unified Interface framework, which has a new user experience - **Unified Interface** - which uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation. 

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app brings rich experience to administrate and manage your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

## Supportability matrix for Unified Service Desk Administrator app

The matrix explains the support of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app with versions of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.

### Fresh Installation of Dynamics 365 and Unified Service Desk

| Dynamics 365 Version | Unified Service Desk Version | Unified Service Desk Administrator App  |
|:--------------------:|:----------------------------:|:---------------------------------------:|
| V 9.X                | 4.0                          | Yes                                     |
| V 8.X                | 4.0                          | No                                      |
| V 7.X                | 4.0                          | No                                      |

### Upgrade Installation of Dynamics 365 and Unified Service Desk

When you are upgrading Dynamics 365 version and Unified Service Desk you need to import the solution to use Unified Service Desk Administrator app. The matrix explains the import scenario. 

| Dynamics 365 Version | Unified Service Desk Version |Import solution to get Unified Service Desk Administrator App  | 
|:--------------------:|:----------------------------:|:---------------------------------------:|
| V 8.X to V 9.X       | 4.0                          | Yes                                     | 
| V 7.X to V 9.X       | 4.0                          | Yes                                     | 
| V 6.X to V 9.X       | 4.0                          | Yes                                     |

## Download and install Unified Service Desk Administrator app

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app is made available through the **USDUnifiedInterfaceCustomization_1_0_managed** solution. The solution is present in the following packages under the folder `<Unified Service Desk download directory>\USDPackageDeployer\`:

- **NewEnvironment**
- **UpdatePackage**
- **UnifiedClientDemoPackage**

### Install the Unified Service Desk Administrator app solution

1. Download [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] 4.0 and Package Deployer and save it on your computer. See [Download Unified Service Desk](../download-unified-service-desk.md).

2. Run the downloaded file to extract the Dynamics 365 Package Deployer into a folder.

3. After the files are extracted, if the Package Deployer tool starts automatically, close it.

4. Open the **USDPackageDeployer** > **NewEnvironment** folder and locate the **USDUnifiedInterfaceCustomization_1_0_managed** solution.

5. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]

6. Go to **Settings** > **Solutions**.

7. On the **Actions** toolbar, choose **Import**.

8. In the **Import Solution** window, browse for the **USDUnifiedInterfaceCustomization_1_0_managed** solution in the  appropriate folder as mentioned in the step 4, and choose **Next**. <br> After few moments the import completes successfully and you can view the results.

9. Choose **Close**.

### Use package deployer to deploy the Unified Service Desk Administrator app

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app is available through the the **Unified Service Desk - Unified Interface** and **New Environment** sample package. To deploy the sample package, see [Deploy a sample Unified Service Desk package using Package Deployer](../admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md#deploy-a-sample-unified-service-desk-package-using-package-deployer)

> [!IMPORTANT]
> - The sample applications are not supported for production use.  
>   - Only one [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package can be deployed in a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance to avoid any loss or overlap of functionality. If you want to install another [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package, remove the existing one, and then install the other package. For information about removing an existing [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package, see [Remove a sample Unified Service Desk package](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md#Remove).  
>   - Before deploying a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package on a production instance, ensure that you test the package on a pre-production instance, preferably a mirror image of the production instance. Also, be sure to back up the production instance before deploying the package.  
>   - You can also use [!INCLUDE[pn_PowerShell_short](../../includes/pn-powershell-short.md)] cmdlets for [!INCLUDE[pn_package_deployer_short](../../includes/pn-package-deployer-short.md)] to deploy packages. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Deploy packages using CRM Package Deployer and Windows PowerShell](../../admin/deploy-packages-using-package-deployer-windows-powershell.md)
  

## How to find the Unified Service Desk Administrator app

If you deploy the sample package or import the solution, in either way you can find the Administrator app by performing the following:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd-admin-app.md)] </br>
![Navigate to Unified Service Desk Admin app via settings, My Apps](../media/usd-crm-admin-app-navigate.PNG "Navigate to Unified Service Desk Admin app via settings, My Apps")
</br></br>
![Unified Service Desk Administrator app](../media/usd-crm-admin-app.PNG "Unified Service Desk Administrator app")
 
## See also  
 [Hosted control types, action, and event reference](../../unified-service-desk/hosted-control-types-action-event-reference.md)  
 
[Configure your agent application using Unified Service Desk](../../unified-service-desk/configure-agent-application-unified-service-desk.md)  
  
[Extend Unified Service Desk](../../unified-service-desk/extend-unified-service-desk.md)
