---
title: "System Configurations | MicrosoftDocs"
description: "Learn about the system configurations that best practices outlines and against which Best Practices Analyzer performs analysis."
ms.custom: ""
ms.date: 04/15/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: "2ED0C60D-0C69-45C7-828A-8BB7D05A9180"
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# System Configurations

In the context of [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Client application, System configurations are categorized as the hardware and software requirements for the computer and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

## Memory (RAM)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks memory on your computer and displays the error or warning when the value is less than 4GB. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Memory (RAM) is 4GB or more.

|              | Error         | Warning       |
|--------------|---------------|---------------|
| Memory (RAM) | Less than 2GB | Less than 4GB |

### Mitigation

Upgrade the Memory (RAM) of your computer to 4GB or more.

## Available Memory (RAM)

Available Memory is the remaining Memory (RAM) on your computer after the memory consumed by the existing processes.

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks Available Memory (RAM) on your computer and displays the warning when the value is less than 1GB. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Available Memory (RAM) is 4GB or more.

|              | Warning       |
|--------------|---------------|
| Memory (RAM) | Less than 1GB |

### Mitigation

Close other processes to ensure Available Memory (RAM) is 1GB or more.

## Operating System version

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks the [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] operating system version on your computer. If you use any version below [!include[pn-windows-7](../../includes/pn-windows-7.md)], the [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays a warning.

The supported operating system version is [!include[pn-windows-10](../../includes/pn-windows-10.md)], [!include[pn-windows-8-1](../../includes/pn-windows-8-1.md)], [!include[pn-windows8](../../includes/pn-windows8.md)], or [!include[pn-windows-7](../../includes/pn-windows-7.md)]. However, the recommended operating system is [!include[pn-windows-10](../../includes/pn-windows-10.md)].

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best with latest version of operating system.

### Mitigation

Upgrade your computer to latest operating system version.

## Hard Disk Space

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks the free hard disk space on your computer and displays a warning when the value is less than 12GB. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Hard Disk Space is 12GB or more.

### Mitigation

Delete old or unnecessary files to free space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

## [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the version of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and recommends upgrading to latest version of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to experience performance, reliability, and stability.

### Mitigation

Download and Upgrade to latest version of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Download Unified Service Desk](../download-unified-service-desk.md)
and [Upgrade the Unified Service Desk](../admin/install-upgrade-unified-service-desk-client.md)

## [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Up time

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks the active operational time of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and displays a warning when [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is active
for more than 8 hours.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the you restart the client application after an active operational time of 8 hours.

### Mitigation

It is recommended you restart [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] after an active time of 8 hours to experience uninterrupted performance.

## Memory by [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] process

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for memory consumption by [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] processes and displays a warning when the value is more than 500MB.

The memory consumption of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] process increases when you host browser hosted controls in internal WPF mode. Hosting browser
hosted control in IE process significantly reduces the memory footprint of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] process.

Hence, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when you use Internet Explorer process for hosting browser hosted controls.

### Mitigation

Review and move any browser hosted controls in Internal WPF mode or Hybrid mode (IE and Internal WPF) to Internet Explorer mode.

## [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] KB Updates

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] KB3092627 update if you operating system is [!include[pn-windows-7](../../includes/pn-windows-7.md)] and displays a warning when the KB3092627 is not installed on your computer.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] KB3092627 update is installed on your [!include[pn-windows-7](../../includes/pn-windows-7.md)].

### Mitigation

Install [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] KB3092627 update on your computer. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)]
[KB3092627](https://support.microsoft.com/en-us/help/3092627/september-2015-update-to-fix-windows-or-application-freezes-after-you)  

## Round-Trip Time

Best Practices Analyzes the network strength to analyze the Round-Trip Time (RTT). This is the time taken to connect from [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]
client application to Dynamics 365 CRM server and back to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

### Mitigation

It is recommended that you contact your network administrator to improve the network strength.