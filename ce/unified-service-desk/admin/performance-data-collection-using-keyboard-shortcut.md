---
title: "Performance data collection using keyboard shortcut | MicrosoftDocs"
description: "Learn about Unified Service Desk performance data collection that enables you to collect data about the operational events, errors, and performance in the client application to log files, using keyboard shortcuts"
ms.custom: ""
ms.date: 01/25/2018
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: E838A9E7-4ED6-44DF-B2E9-0A3E3A82EA4B
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Performance data collection
[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] performance data collection enables you to collect data about the operational events, errors, and performance in the client application to log files, which is used to identify and troubleshoot performance issues or errors. If you encounter technical issues that relates to performance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], Customer Support Service personnel may request you send the log file to help troubleshoot the issue.
When you enable the performance data collection, the log files are maintained with a unique performance session Id (GUID) on the client computer. Example of performance session Id (GUID): **cv0ab1gg-1df3-7bd9-b5dt-1221d65r93w8**.

The path where the log files are maintained on the client computer:

```%APPDATA%\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<version>\USDPerformanceData_<TimeStamp>_<YYYY-MM-DD>```

> [!Note]
> Each time you start and stop the collection of performance data, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] creates a new file with a performance session Id and maintains on the client computer.

<a name="BKMK_Configure_performance_data_collection_keyboard_shortcut"></a>
## Configure performance data collection keyboard shortcut

Agent working on the client computer can start and stop collecting the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] performance data using the keyboard shortcuts. By default, the keyboard shortcut to start performance data collection is **Ctrl+Alt+Q** and to stop the performance data collection is **Ctrl+Alt+P**.

To change the default keyboard shortcut, System Administrator need to configure the new keyboard shortcuts to start and stop the collection of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] performance data.

To configure a new performance data collection keyboard shortcut, perform the following:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]
 
3. Open the existing Audit & Diagnostics Setting record in the **Audit & Diagnostics Settings** section.
    > [!Note]
    > If there is no existing record, create a new Audit & Diagnostics Setting record.  [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create an Audit & Diagnostics record to use for diagnostics](..\admin\configure-auditing-diagnostics-unified-service-desk.md#Diagnostics).

4. Expand the **Diagnostics Settings** area to see **Performance Data Collection**.

5. Type the keyboard shortcut in the format _key1+key2+key3_ for the **On-Demand Begin Shortcut** field.
Use.

6. Type the keyboard shortcut in the format _key1+key2+key3_ for the **On-Demand End Shortcut** field.

7. Click **Save & Close**.

## See also
  
 