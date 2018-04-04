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

In the context of Best Practices Analyzer and Unified Service Desk
Client application, System configurations are categorized as the
hardware and software requirements for the computer and Unified Service
Desk.

### Memory (RAM)

Best Practices Analyzer checks memory on your computer and displays the
error or warning when the value is less than 4GB. Unified Service Desk
works best when Memory (RAM) is 4GB or more.

|              | Error         | Warning       |
|--------------|---------------|---------------|
| Memory (RAM) | Less than 2GB | Less than 4GB |

#### Mitigation

Upgrade the Memory (RAM) of your computer to 4GB or more.

### Available Memory (RAM)

Available Memory is the remaining Memory (RAM) on your computer after
the memory consumed by the existing processes.

Best Practices Analyzer checks Available Memory (RAM) on your computer
and displays the warning when the value is less than 1GB. Unified
Service Desk works best when Available Memory (RAM) is 4GB or more.

|              | Warning       |
|--------------|---------------|
| Memory (RAM) | Less than 1GB |

#### Mitigation

Close other processes to ensure Available Memory (RAM) is 1GB or more.

### Operating System version

Best Practices Analyzer checks the windows operating system version on
your computer. If you use any version below windows 7, the Best
Practices analyzer displays a warning.

The supported operating system version is Windows 10, Windows 8.1,
Windows 8, or Windows 7. However, the recommended operating system is
Windows 10.

Unified Service Desk works best with latest version of operating system.

#### Mitigation

Upgrade your computer to latest operating system version.

### Hard Disk Space

Best Practices Analyzer checks the free hard disk space on your computer
and displays a warning when the value is less than 12GB. Unified Service
Desk works best when Hard Disk Space is 12GB or more.

#### Mitigation

Delete old or unnecessary files to free space for Unified Service Desk.

### Unified Service Desk version

Best Practices Analyzer checks for the version of the Unified Service
Desk and recommends upgrading to latest version of Unified Service Desk
to experience performance, reliability, and stability.

#### Mitigation

Download and Upgrade to latest version of Unified Service Desk. More
information: [Download Unified Service
Desk](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/download-unified-service-desk)
and [Upgrade the Unified Service
Desk](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/install-upgrade-unified-service-desk-client)

### Unified Service Desk Up time

Best Practices Analyzer checks the active operational time of Unified
Service Desk and displays a warning when Unified Service Desk is active
for more than 8 hours.

Unified Service Desk works best when the you restart the client
application after an active operational time of 8 hours.

#### Mitigation

It is recommended you restart Unified Service Desk after an active time
of 8 hours to experience uninterrupted performance.

### Memory by Unified Service Desk process

Best Practices Analyzer checks for memory consumption by Unified Service
Desk processes and displays a warning when the value is more than 500MB.

The memory consumption of Unified Service Desk process increases when
you host browser hosted controls in internal WPF mode. Hosting browser
hosted control in IE process significantly reduces the memory footprint
of Unified Service Desk process.

Hence, Unified Service Desk works best when you use Internet Explorer
process for hosting browser hosted controls.

#### Mitigation

Review and move any browser hosted controls in Internal WPF mode or
Hybrid mode (IE and Internal WPF) to Internet Explorer mode.

### Windows KB Updates

Best Practices Analyzer checks for the Windows KB3092627 update if you
operating system is Windows 7 and displays a warning when the KB3092627
is not installed on your computer.

Unified Service Desk works best when Windows KB3092627 update is
installed on your computer.

#### Mitigation

Install Windows KB3092627 update on your computer. More information:
[KB3092627](https://support.microsoft.com/en-us/help/3092627/september-2015-update-to-fix-windows-or-application-freezes-after-you)  

### Round-Trip Time

Best Practices Analyzes the network strength to analyze the Round-Trip
Time (RTT). This is the time taken to connect from Unified Service Desk
client application to Dynamics 365 CRM server and back to Unified
Service Desk client application.

#### Mitigation

It is recommended that you contact your network administrator to improve
the network strength.

