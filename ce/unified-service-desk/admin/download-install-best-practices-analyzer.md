---
title: "Download and Install Best Practices Analyzer | MicrosoftDocs"
description: "Learn about downloading and installing the Best Practices Analyzer."
ms.custom: ""
ms.date: 04/24/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: "B96D2870-9475-475B-B37B-221C3EC55D45"
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Download and Install Best Practices Analyzer

## [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] support matrix and download location

The table provides where you can download [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] for various versions of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

| Scenario | Description | [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] | Download Location |
|-----------------|------------------|----------------|-----------|
| Available through sample application package |[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] is part of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] – Microsoft Dynamics 365 Web Client and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] – Microsoft Dynamics 365 Unified Client | [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)] | [Download](https://go.microsoft.com/fwlink/?linkid=872261) |
|Available through [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] package|[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] is available as a download package.| [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)] <br> [!INCLUDE[pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)] <br> [!INCLUDE[pn-unified-service-desk-3-0](../../includes/pn-unified-service-desk-3-0.md)] <br> [!INCLUDE[pn-unified-service-desk-2-2](../../includes/pn-unified-service-desk-2-2.md)] | [Download](https://go.microsoft.com/fwlink/?linkid=872089) |
 

## Install [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)]

Before you can install and deploy [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)], you must download [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] package specific to your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Download Best Practices Analyzer](#download-best-practices-analyzer)

### Best Practices Analyzer for Unified Service Desk 3.3

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] for [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)] is available in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Web Client sample package.

You can deploy a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] sample package using Package Deployer. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Deploy sample Unified Service Desk applications using Package Deployer](../admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)

### Best Practices Analyzer for Unified Service Desk 3.2 or lower version

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] for [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)] or lower versions is available as a separate download package.

Download the sample zip package for [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)] or lower versions and extract the package. After extracting the zip package, you can see the following:

-  **BestPracticesAnalyzerPackage** folder
- `Microsoft.Crm.UnifiedServiceDesk.Packages.BestPracticesAnalyzerPackage.dll` file

Copy the folder and .dll file, and paste in your **PkgConfig** folder. After copying the folder and .dll file, deploy the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] sample package using Package Deployer.

After deploying the sample package using Package Deployer, perform the walkthrough to configure the [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] in your agent application. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Walkthrough: Configure Best Practices Analyzer](../admin/walkthrough-configure-best-practices-analyzer.md)

> [!Note]
> The [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] support is available until [!INCLUDE[pn-unified-service-desk-2-2](../../includes/pn-unified-service-desk-2-2.md)]

## See also

[Analyze best practices in Unified Service Desk](../admin/analyze-best-practices-unified-service-desk.md)

[Walkthrough: Configure Best Practices Analyzer](../admin/walkthrough-configure-best-practices-analyzer.md)

[Read Best Practices Analyzer report](../admin/read-best-practices-analyzer-report.md)

[Best practice rule categories and parameters](../admin/compliance-categories-parameters-bpa.md)

[System configurations](../admin/system-configurations-bpa.md)

[Internet Explorer settings](../admin/internet-explorer-settings-bpa.md)

[Unified Service Desk configurations](../admin/unified-service-desk-configurations-bpa.md)