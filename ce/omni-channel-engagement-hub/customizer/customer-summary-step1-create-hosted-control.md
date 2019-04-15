---
title: "Steps or procedure to configure customer summary page for agents | MicrosoftDocs"
description: "Learn how to set up the customer summary hosted control for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 2EBF6673-A36B-49C1-AD8A-38E87D5E4538
ms.custom: 
---

# Step 1: Create customer summary hosted control

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic demonstrates how to create a customer summary hosted control in Unified Service Desk for a Dynamics 365 for Customer Engagement instance.

## Prerequisites 

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-security-roles)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Create hosted control

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Hosted Controls** and then select **+ New**.

5. On the page for new hosted control, specify the following.

    | Tab                   | Field                                         | Value                           |
    |-----------------------|-----------------------------------------------|---------------------------------|
    | General | Name                                | Customer Summary |
    | General | Sort Order | 30 |
    | General | Display Name | \[\[$Resources.SessionOverviewHCDisplayName\]\] |
    | General | Unified Service Desk Component Type | Unified Interface Page |
    | General | Hosting Type | Chrome Process |
    | General | Pre-Fetch | Select the check box |
    | General | Allow Multiple Page | No |    
    | General | Display Group              | MainPanel |
    | General | Adapter              | Use No Adapter |
    | General | Application is Dynamics               | yes |

6.  Save the hosted control.

> [!div class="nextstepaction"]
> [Next topic: Step 2: Create customer summary-related action calls](customer-summary-step2-create-action-calls.md)

## See also

- [Step 3: Attach customer summary-related action calls to events](customer-summary-step3-attach-action-calls-events.md)
- [Step 4: Add the hosted control, action calls, and events to configurations](customer-summary-step4-add-hosted-control-action-calls-events-configurations.md)
