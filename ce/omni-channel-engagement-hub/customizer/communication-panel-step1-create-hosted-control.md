---
title: "Steps or procedure to configure communication panel for agents | MicrosoftDocs"
description: "Learn how to set up the communication panel hosted control for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 4396B2D0-20DE-4B88-A87C-DC197F14F6CF
ms.custom: 
---

# Step 1: Create communication panel hosted control

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic describes how to create a communication panel hosted control in Unified Service Desk for a Dynamics 365 for Customer Engagement instance.

## Prerequisites 

- You must have the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-security-roles)


<!--note that the above link opens a page titled "Use security roles to manage access"-->


- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)


<!--Because the following is the only step on this page, you don't need to label it as Step 1.-->


## Step 1.  Create hosted control

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Hosted Controls** and select **+ New**.

5. On the page for new hosted control, specify the following:

    | Tab     | Field                           | Value                       |
    |------------------|-------------------------------------|---------------------------------|
    | General | Name                                | Communication Panel |
    | General | Unified Service Desk Component Type | USD Hosted Control |
    | General | Application is Global               | Select the check box  |
    | General | Display Group              | LeftPanelFill |
    | General | Application is Dynamics               | yes |
    | Hosting | Assembly URI               | `USDConfiguration.ChatControl` |
    | Hosting | Assembly Type             | `USDConfiguration.ChatControl.OmniChannelHost` |

6.  Save the hosted control.

> [!div class="nextstepaction"]
> [Next topic: Step 2:  Create action calls related to communication panel](communication-panel-step2-create-action-calls.md)

## See also


<!--The first link below is to this topic. Please delete.-->


- [Step 1: Create communication panel hosted control](communication-panel-step1-create-hosted-control.md)
- [Step 3: Attach communication panel-related action calls to events](communication-panel-step3-attach-action-calls-events.md)
- [Step 4: Add hosted control, action calls, and events to configurations](communication-panel-step4-add-hosted-control-action-calls-events-configurations.md)
