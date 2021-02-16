---
title: "System configurations | MicrosoftDocs"
description: "Learn about the system configurations that best practices outlines and against which Best Practices Analyzer performs analysis."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 04/24/2018
ms.topic: article
ms.service: dynamics-365-customerservice
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---
# System configurations

In the context of [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application, system configurations are categorized as the hardware and software requirements for the computer and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

## Memory (RAM)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks memory on your computer and displays an error or warning when the value is less than 4 GB. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when memory (RAM) is 4 GB or more.

|              | Error         | Warning       |
|--------------|---------------|---------------|
| Memory (RAM) | Less than 2 GB | Less than 4 GB |

### Mitigation

Upgrade the memory (RAM) of your computer to 4 GB or more.

## Available Memory (RAM)

**Available Memory** is the remaining memory (RAM) on your computer after memory consumed by the existing processes.

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks available memory (RAM) on your computer and displays the warning when the value is less than 1 GB. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when **Available Memory (RAM)** is 4 GB or more.

|              | Warning       |
|--------------|---------------|
| Memory (RAM) | Less than 1 GB |

### Mitigation

Close other processes to help ensure that **Available Memory (RAM)** is 1 GB or more.

## Operating system version

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks the [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] operating system version on your computer. If you use any version earlier than [!include[pn-windows-7](../../includes/pn-windows-7.md)], the [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays a warning.

The supported operating system version is [!include[pn-windows-10](../../includes/pn-windows-10.md)], [!include[pn-windows-8-1](../../includes/pn-windows-8-1.md)], [!include[pn-windows8](../../includes/pn-windows8.md)], or [!include[pn-windows-7](../../includes/pn-windows-7.md)]. However, the recommended operating system is [!include[pn-windows-10](../../includes/pn-windows-10.md)].

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best with latest version of operating system.

### Mitigation

Upgrade your computer to latest operating system version.

## Hard Disk Space

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks the free hard disk space on your computer and displays a warning when the value is less than 12 GB. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when hard disk space is 12 GB or more.

### Mitigation

Delete old or unnecessary files to free space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

## [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the version of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and recommends upgrading to the latest version of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to experience performance, reliability, and stability.

### Mitigation

Download and upgrade to the latest version of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Download Unified Service Desk](../download-unified-service-desk.md)
and [Upgrade the Unified Service Desk](../admin/install-upgrade-unified-service-desk-client.md)

## [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Up time

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks the active operational time of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and displays a warning when [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is active
for more than eight hours.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the you restart the client application after an active operational time of eight hours.

### Mitigation

To experience uninterrupted performance, we recommended that you restart [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] after an active time of eight hours.

## Memory by [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] process

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for memory consumption by [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] processes and displays a warning when the value is more than 500 MB.
<!--Editing: In the following paragraph, I spelled out IE, but it should probabaly be a token.-->
The memory consumption of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] process increases when you host browser hosted controls in **Internal WPF** mode. Hosting browser hosted controls in **IE process** significantly reduces the memory footprint of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] process.

Therefore, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when you use an **IE process** for hosting browser hosted controls.

### Mitigation
<!--Editing: Below, if "IE" isn't used in the UI in this case, please spell it out. Also, if "Internal" isn't part of the mode name, please lowercase that. -->
Review and move any browser hosted controls in **Internal WPF** mode or hybrid mode (IE process and Internal WPF) to **IE process** mode.

## [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] KB updates

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] KB3092627 update if your operating system is [!include[pn-windows-7](../../includes/pn-windows-7.md)] and displays a warning when the KB3092627 is not installed on your computer.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] KB3092627 update is installed on your [!include[pn-windows-7](../../includes/pn-windows-7.md)].

### Mitigation

Install the [!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)] KB3092627 update on your computer. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)]
[KB3092627](https://support.microsoft.com/help/3092627/september-2015-update-to-fix-windows-or-application-freezes-after-you)

## See also

[Analyze best practices in Unified Service Desk](../admin/analyze-best-practices-unified-service-desk.md)

[Download and install Best Practices Analyzer](../admin/download-install-best-practices-analyzer.md)

[Read Best Practices Analyzer report](../admin/read-best-practices-analyzer-report.md)

[List of rule categories and parameters](../admin/compliance-categories-parameters-bpa.md)

[Internet Explorer settings](../admin/internet-explorer-settings-bpa.md)

[Unified Service Desk configurations](../admin/unified-service-desk-configurations-bpa.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]