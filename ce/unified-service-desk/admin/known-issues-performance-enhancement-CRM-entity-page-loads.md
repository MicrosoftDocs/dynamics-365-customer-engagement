---
title: "Known issues of performance enhancement for CRM entity page loads | MicrosoftDocs"
description: "Learn about the known issues of the Internet Explorer pooling feature."
ms.custom: ""
ms.date: 02/15/2018
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
ms.assetid: D552D7B4-61F0-43D3-AB7E-E2E2D0E8321F
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Known issues of performance enhancement for CRM entity page loads

## Closing CRM entity page starts loading but never completes loading

When **InternetExplorerPooling** is enabled, and if you close a CRM entity page hosted in Unified Service Desk using the close (**x**) button (_see Image 1_), the CRM entity page to starts loading but never completes loading (_see Image 2_).

  ![Closing CRM entity page hosted in Unified Service Desk using close button](../../unified-service-desk/media/usd-crm-page-hosted-close-button.PNG "Closing CRM entity page hosted in Unified Service Desk using close button")
    
    _Image 1: Closing CRM entity page hosted in Unified Service Desk using close (x) button_
  
  ![CRM entity page start loading but never completes loading](../../unified-service-desk/media/usd-crm-page-hosted-never-completes-loading.PNG "CRM entity page start loading but never completes loading")
  
  _Image 2: CRM entity page start loading but never completes loading_

#### **Workaround**

If you close the CRM entity page, the page starts loading but never completes the loading. In this case, to restore the CRM entity page, right-click on CRM entity page and select **Forward** from the context menu (_see Image 1_).

![Right-click on the CRM entity page and select Forward from the context menu](../../unified-service-desk/media/usd-crm-page-right-click-CRM-entity-page-select-forward.PNG "Right-click on the CRM entity page and select Forward from the context menu")

_Image 1: Right-click on the CRM entity page and select Forward from the context menu_

> [!Note]
> The session that you are working is fine and there is no data lost.

<!--If you  close the CRM entity page, the page starts loading but never completes loading. In this case, you need to close the CRM entity page and reopen the page to continue working.

It is possible that there is not close button on the CRM page tab, in this case, you can close the session tab and reopen the session and CRM entity page to continue working.

If the session tab does not have the close button, you must close the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application and relaunch the client application, session, and CRM entity page to continue working.-->

## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)
 
[Performance enhancement for CRM entity page loads](../admin/performance-enhancement-CRM-entity-page-loads.md)