---
title: "Migrate Dynamics 365 Web Client configurations to Dynamics 365 Unified Interface App | MicrosoftDocs"
description: "Learn how to migrate your Unified Service Desk configurations from Dynamics 365 Web Client to Unified Interface App"
keywords: ""
ms.date: 07/30/2018
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
ms.assetid: 785880FF-00C7-489F-BC2D-2C45ECBFF3C9
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---

# Migration of Unified Service Desk configurations from Dynamics 365 Web Client to Dynamics 365 Unified Interface App

## Overview
  
[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] supports Unified Interface apps. This lets you to upgrade to the latest version of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to deliver intelligent and personalized experience to the rising expectations of your customers.

If you are using [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Web Client with all the configurations needed for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], you will want to know how to use all the configurations in the Unified Interface App. To tackle the issue of configuring in the Unified Interface App, we have introduced a tool, **[!INCLUDE[pn-web-client-unified-interface-configuration-migration-assistant](../../includes/pn-web-client-unified-interface-configuration-migration-assistant.md)]**, for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

**[!INCLUDE[pn-web-client-unified-interface-configuration-migration-assistant](../../includes/pn-web-client-unified-interface-configuration-migration-assistant.md)]** for Unified Service Desk, a tool that helps you to seamlessly migrate your existing [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations from [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Web Client to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Unified Interface App.

## How Web Client - Unified Interface Migration Assistant helps

The migration assistant helps with the migration of:

- **CRM Page** hosted controls to **Unified Interface Page** hosted controls.
- **RunXRM** commands as web resources that you can import as a solution and deploy on Unified Interface App.
- Events and actions that are only supported in Web Client to the corresponding events and actions in Unified Interface App.
- Actions, action calls, events, and window navigation rules associated with the hosted control to Unified Interface App.
- Dashboards and Search hosted controls.
- **KM Control** to **Unified Interface KM Control**.
- Configurations from Web Client to Unified Interface App.

> [!div class="nextstepaction"]
> [Download the migration assistant](download-migration-assistant.md)

## See also

[Download the Web Client - Unified Interface Migration Assistant](download-migration-assistant.md)

[Migration steps of the configurations from Dynamics 365 Web Client to Unified Interface App](migration-steps-web-client-unified-interface-configuration.md)

[Download the tools from NuGet](/dynamics365/customer-engagement/developer/download-tools-nuget)

[Import configuration data](/dynamics365/customer-engagement/admin/import-configuration-data)
