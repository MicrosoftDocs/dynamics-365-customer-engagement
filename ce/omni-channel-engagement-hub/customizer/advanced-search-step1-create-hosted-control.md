---
title: "Create Omni-channel Advanced Search hosted control for agents | MicrosoftDocs"
description: "Learn how to Omni-channel Advanced Search hosted control for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 491DB915-C0FB-4AD4-A969-159F7CA9CB65
ms.custom: 
---

# Step 1: Create Omni-channel Advanced Search hosted control

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic describes how to create an Advanced Search hosted control in Unified Service Desk for a Dynamics 365 for Customer Engagement instance.

## Prerequisites 

- You must have the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Step 1.  Create hosted control

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Hosted Controls** and select **+ New**.

5. On the page for a new hosted control, specify the following:

    | Field                           | Value                       |
    |-------------------------------------|---------------------------------|
    | Name                                | Omni-channel Advanced Search |
    | Sort | 10 |
    | Display Name | Omni-channel Advanced Search |
    | Unified Service Desk Component Type | Unified Interface Page |
    | Hosting Type | Chrome Process |
    | Pre-Fetch Data               | Select the check box  |
    | Display Group              | MainPanel |
    | Adapter | Use No Adapter |
    | Application is Dynamic  | yes |
    | User Can Close | Select the check box |

6. Save the hosted control.

> [!div class="nextstepaction"]
> [Next topic: Step 2: Create advanced search-related action calls](advanced-search-step2-create-action-calls.md)

## See also

- [Step 3: Attach advanced search-related action call to events](advanced-search-step3-attach-action-calls-events.md)
- [Step 4: Add hosted control, action calls, and events to configurations](advanced-search-step4-add-hosted-control-action-calls-events-configurations.md)
