---
title: "Release notes of Unified Service Desk 3.3 (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about the known issues in Unified Service Desk."
ms.custom: ""
ms.date: 05/8/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: FCB9B5AA-62A9-4CFA-9F84-E63735B879DF
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---

# Release notes of Unified Service Desk 3.3

This section describes the known issues and limitations in [!INCLUDE[pn-unified-service-desk-3-3](../includes/pn-unified-service-desk-3-3.md)]

## Known issues in Unified Service Desk

### Best Practices Analyzer

**Warning for HelpImproveUSD parameter in Dynamics 365 (on-premises)**

Help Improve [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is enabled/disabled only for [!INCLUDE[pn-crm-online](../includes/pn-crm-online.md)]. If you are using [!INCLUDE[pn-crm-onprem](../includes/pn-crm-onprem.md)], you can see a warning for the Help Improve [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] (HelpImproveUSD) parameter in the report.

**Error for Enable Enhanced Protected mode in Windows 7 operating system**

If you are using [!include[pn-windows-7](../includes/pn-windows-7.md)] operating system, the **Enable Enhanced Protected Mode** option is not available in Internet Explorer options. Hence, you can see an error message for the **Enable Enhanced Protected Mode** parameter in the report.

## Limitations in Unified Service Desk

This section describes the limitations in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]

### RunScript

> [!IMPORTANT] 
> This also applies to:
> - [!INCLUDE[pn-unified-service-desk-3-2](../includes/pn-unified-service-desk-3-2.md)]
> - [!INCLUDE[pn-unified-service-desk-3-1](../includes/pn-unified-service-desk-3-1.md)]
> - [!INCLUDE[pn-unified-service-desk-3-0](../includes/pn-unified-service-desk-3-0.md)]
> - [!INCLUDE[pn-unified-service-desk-2-2](../includes/pn-unified-service-desk-2-2.md)]

**RunScript action does not execute if the tab or page is not in focus**

If you execute a RunScript action on a tab or a page that is not in focus, the execution of RunScript action does not execute the script.

**Example:**

Accounts and Contacts tabs are open and focus is on Accounts tab. You execute `window.close()` RunScript command to close the Contacts tab. Since, the focus is on Accounts tab the RunScript execution does not execute and the Contacts tab does not close.

**Workaround:**

If you open several tabs and want to execute a RunScript action on a tab that is not in focus, set the focus on the tab you want to work and then execute the RunScript action.

### Performance enhancement for CRM entity page loads

> [!IMPORTANT] 
> This also applies to:
> - [!INCLUDE[pn-unified-service-desk-3-2](../includes/pn-unified-service-desk-3-2.md)]

**Closing CRM entity page starts loading but never completes loading**

When **InternetExplorerPooling** is enabled, and if you close a CRM entity page hosted in Unified Service Desk using the close (**x**) button (_see Image 1_), the CRM entity page to starts loading but never completes loading (_see Image 2_).

  ![Closing CRM entity page hosted in Unified Service Desk using close button](../unified-service-desk/media/usd-crm-page-hosted-close-button.PNG "Closing CRM entity page hosted in Unified Service Desk using close button")
    
  _Image 1: Closing CRM entity page hosted in Unified Service Desk using close (x) button_
  
  ![CRM entity page start loading but never completes loading](../unified-service-desk/media/usd-crm-page-hosted-never-completes-loading.PNG "CRM entity page start loading but never completes loading")
  
  _Image 2: CRM entity page start loading but never completes loading_

**Workaround**

If you close the CRM entity page, the page starts loading but never completes the loading. In this case, to restore the CRM entity page, right-click on CRM entity page and select **Forward** from the context menu (_see Image 1_).

![Right-click on the CRM entity page and select Forward from the context menu](../unified-service-desk/media/usd-crm-page-right-click-CRM-entity-page-select-forward.PNG "Right-click on the CRM entity page and select Forward from the context menu")

_Image 1: Right-click on the CRM entity page and select Forward from the context menu_

> [!Note]
> The session that you are working is fine and there is no data loss.

## See also

[Analyze best practices in Unified Service Desk](admin/analyze-best-practices-unified-service-desk.md)

[Performance enhancement for CRM entity page loads](admin/performance-enhancement-CRM-entity-page-loads.md)