---
title: "Pool Internet Explorer process instance in unified Service Desk | MicrosoftDocs"
description: "Learn about Internet Explorer Pooling feature that creates a dynamic pool of Internet Explorer process instance. The hosted control that you are opening uses an Internet Explorer instance from the pool and inline navigation is performed."
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
ms.assetid: FA8D5702-C698-42B0-89BF-CD444BF3FB73
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Internet Explorer pooling overview
With this release of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], you can experience enhanced performance of CRM entity type navigation in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

The `IE Process` browser control hosts your controls in individual Internet Explorer process instances and displays them in tabs in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.  

Whenever you are opening a hosted control of CRM entity type in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application, the Internet Explorer Pooling feature creates a dynamic pool of Internet Explorer process instance. The hosted control that you are opening uses an Internet Explorer instance from the pool and inline navigation is performed. If you are opening another hosted control, instead of creating a new Internet Explorer instance, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] opens the hosted control using an Internet Explorer instance from the pool and performs the inline navigation.
When you close a hosted control, the Internet explorer pooling feature recycles the Internet Explorer instance and adds it back to the pool. 
  
Unified Service Desk always maintains a pool of Internet Explorer instances for the hosted controls to use. This way of opening a hosted control using an Internet Explorer instance with pool enhances the performance of the Unified Service Desk.

> [!Note]
> The Internet Explorer pool feature supports only CRM entity type navigation.

## Enable Internet Explorer pooling

By default, the Internet Explorer pooling is disabled. To enable the option, System Administrator must configure the option on the **Active UII Options** page and set it to **true**.

To enable the Internet Explorer pooling option, perform the following steps:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]

3. Choose **Options**.  

4. On the **Active UII Options** page, click **New**.

5. Choose **Others** for the **Global Option** field.

6. Type **InternetExplorerPooling** for the **Name** field.

7. Set **true** for the **Value** field.

8. Click **Save**.


## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)
 