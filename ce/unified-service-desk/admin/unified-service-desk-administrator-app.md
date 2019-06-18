---
title: "Use Unified Service Desk Administrator app to administer and manage Unified Service Desk client | MicrosoftDocs"
description: "Learn how to use the Unified Service Desk Administrator app to administer Unified Service Desk client."
keywords: 
ms.date: 04/10/2019
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-USD, dyn365-admin
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement (on-premises) apps
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: 6190932E-FE9C-4167-B33D-C360A4E5D8F4
author: kabala123
ms.author: kabala
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
monikerRange: ">=dynamics-usd-4"
---

::: moniker range="dynamics-usd-4"
# Preview feature: Administer and manage Unified Service Desk using the Administrator app
::: moniker-end

::: moniker range="dynamics-usd-4.1"
# Administer and manage Unified Service Desk using the Administrator app
::: moniker-end

## Overview

You can use the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator App built on the Unified Interface framework to administer and manage the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app is built on the Unified Interface framework, which has a new user experience - **Unified Interface** - which uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation. 

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app brings rich experience to administer and manage your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

The Administrator app, which is built based on the Unified Interface framework, has the same configurational capabilities as the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrator in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Web Client.

## Supportability matrix for Unified Service Desk Administrator app

The matrix explains the support of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app with versions of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.

### Fresh installation of Dynamics 365 for Customer Engagement apps and Unified Service Desk

| Dynamics 365 for Customer Engagement apps Version | Unified Service Desk Version | Unified Service Desk Administrator App  |
|:--------------------:|:----------------------------:|:---------------------------------------:|
| V 9.x                | 4.X                          | Yes                                     |

### Upgrade installation of Dynamics 365 for Customer Engagement apps and Unified Service Desk

When you are upgrading Dynamics 365 for Customer Engagement apps version and Unified Service Desk you need to import the solution to use Unified Service Desk Administrator app. The matrix explains the import scenario. 

| Dynamics 365 for Customer Engagement apps version | Unified Service Desk version |Import solution to get Unified Service Desk Administrator App  | 
|:--------------------:|:----------------------------:|:---------------------------------------:|
| **V 8.x** to **V 9.x**       | 4.X                       | Yes                                     | 
| **V 7.x** to **V 9.x**       | 4.X                          | Yes                                     | 
| **V 6.x** to **V 9.x**       | 4.X                          | Yes                                     |

## Download and install Unified Service Desk Administrator app

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app is made available through the **USDUnifiedInterfaceCustomization_1_0_managed** solution. The solution is present in the following packages under the folder `<Unified Service Desk download directory>\USDPackageDeployer\`:

- **NewEnvironment**
- **UpdatePackage**
- **UnifiedClientDemoPackage**

### Install the Unified Service Desk Administrator app solution

1. Download [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and Package Deployer and save them on your computer. See [Download Unified Service Desk](../download-unified-service-desk.md).

2. Run the downloaded file to extract the Dynamics 365 for Customer Engagement Package deployer into a folder.

3. After the files are extracted, if the Package Deployer tool starts automatically, close it.

4. Open the **USDPackageDeployer** > **NewEnvironment** folder and locate the **USDUnifiedInterfaceCustomization_1_0_managed** solution.

5. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.

6. Go to **Settings** > **Solutions**.

7. On the **Actions** toolbar, choose **Import**.

8. In the **Import Solution** window, browse for the **USDUnifiedInterfaceCustomization_1_0_managed** solution in the  appropriate folder as listed in the step 4, and choose **Next**. <br> After few moments the import completes successfully and you can view the results.

9. Choose **Close**.

### Use package deployer to deploy the Unified Service Desk Administrator app

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app is available through the **Unified Service Desk - Unified Interface** and **New Environment** sample package. To deploy the sample package, see [Deploy a sample Unified Service Desk package using Package Deployer](../admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md#deploy-a-sample-unified-service-desk-package-using-package-deployer).

> [!IMPORTANT]
> - The sample applications are not supported for production use.  
>   - Only one [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package can be deployed in a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance to avoid any loss or overlap of functionality. If you want to install another [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package, remove the existing one, and then install the other package. For information about removing an existing [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package, see [Remove a sample Unified Service Desk package](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md#Remove).  
>   - Before deploying a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package on a Production instance, ensure that you test the package on a pre-Production instance, preferably a mirror image of the Production instance. Also, be sure to back up the Production instance before deploying the package.  
>   - You can also use [!INCLUDE[pn_PowerShell_short](../../includes/pn-powershell-short.md)] cmdlets for [!INCLUDE[pn_package_deployer_short](../../includes/pn-package-deployer-short.md)] to deploy packages. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Deploy packages using CRM Package Deployer and Windows PowerShell](/dynamics365/customer-engagement/admin/deploy-packages-using-package-deployer-windows-powershell)

## How to find the Unified Service Desk Administrator app

If you deploy the sample package or import the solution, in either way you can find the Administrator app by following these steps:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.

2. Select the drop-down arrow next the **Dynamics 365 for Customer Engagement** and select **Unified Service Desk Administrator** app.

> [!NOTE]
> Alternatively, there are two other ways to go to the app. 
> - Use the `https://<orgURL>.dynamics.com/apps` to navigate to the **Unified Service Desk Administrator** app.
> - Go to Settings > **My Apps** > **Unified Service Desk Administrator**.<br><br>
> If you use any of the above mentioned steps, you can select the app. <br>![Unified Service Desk Administrator app](../media/usd-crm-admin-app.PNG "Unified Service Desk Administrator app")

## Unified Service Desk Administrator app Layout

When you navigate to the Unified Service Desk Administrator app, layout by default opens the configuration element - **Hosted Controls**. 

![Unified Service Desk Administrator app Layout](../media/usd-crm-unified-interface-admin-app-layout.PNG "Unified Service Desk Administrator app Layout")

### 1. Quick-access Configuration Toolbar

The quick-access toolbar is same as **Basic Settings** under the **Site Map** and contains the following configurational elements:
- Hosted Controls
- Action Calls
- Events
- Window Navigation Rules
- Toolbars
- Agent Scripts
- Entity Searches
- Scriptlets
- Forms
- Session Lines

### 2. Site Map

Site Map contains the complete configuration elements required to administer and manage your Unified Service Desk client application.

![Site Map](../media/usd-crm-admin-app-site-map-callouts.PNG "Site Map")

1. **Favorites and Recent** - You can find all the recently used configurational elements using the **Favorites and Recent** tab. Also, you pin and unpin your favorites.

2. **Unified Service Desk Admin** - All the configuration elements that are required to administrate and manage your Unified Service Desk are present under two categories - **Basic Settings** and **Advanced Settings**.

3. **Basic Settings** - The Basic Settings consists of the following configuration elements:
   - Hosted Controls
   - Action Calls
   - Events
   - Window Navigation Rules
   - Toolbars
   - Agents Scripts
   - Entity Searches
   - Scriplets
   - Forms
   - Session Lines

4. **Advanced Settings** - The Advanced Settings consists of the following configuration elements:
   - Global Options
   - User Settings
   - Customization and Files
   - Audit & Diagnostics
   - Unified Interface Settings
   - Configuration
 
### 3. Configuration Layout

The configuration Layout defines the behavior of the element that you open to perform the operations. The layout defines certain common options:
- New
- Delete
- Refresh
- Email a Link
- Export to Excel
- Import from Excel
- List of the configuration element that you are operating

### 4. Navigation toolbar icons

The navigation toolbar icon contains the following:

1. **Search** - Search for records across multiple entities sorted by relevance.
2. **Task Flow** - Start a task-based flow.
3. **Relationship Assistant** - Get a collection of action cards to discover an actional insights. 
4. **New** - You can create a record using this option.
5. **Settings** - This option lets you to personalize your views with Time Zone, Calendar, and Records/List View.
6. **Help** - This option lets you find the technical documentation required for your support.

![Navigation toolbar buttons](../media/usd-crm-navigation-toolbar-buttons.PNG "Navigation toolbar buttons")

### 5. User information 

User information lets you identify the currently signed-in user with the first name and last name.

## See also  
 [Hosted control types, action, and event reference](../../unified-service-desk/hosted-control-types-action-event-reference.md)  
 
[Overview of configuring agent application](../../unified-service-desk/configure-agent-application-unified-service-desk.md)  
  
[Extend Unified Service Desk](../../unified-service-desk/extend-unified-service-desk.md)
