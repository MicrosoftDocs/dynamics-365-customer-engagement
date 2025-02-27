---
title: Configure conversation diagnostics (preview)
description: Learn about how to query and retrieve conversation diagnostics from Application Insights.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection:
ms.date: 02/28/2025
ms.custom: bap-template
---

# Configure conversation diagnostics (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Conversation diagnostics logs each of the conversation lifecycle events, giving you a greater visibility into conversations-based operational telemetry of your organization.  This helps your support team to proactively monitor the system and allows developers to easily identify, diagnose, and fix problematic conversations, or seek swift support.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Connect your Dynamics 365 Customer Service environment to an Azure Application Insights instance to collect and store conversation logs. For more information about Application Insights features and how they can be used to monitor your telemetry and diagnose failures, see [Application Insights Overview dashboard](/azure/azure-monitor/app/overview-dashboard) and [Diagnose failures using the Azure portal](/azure/azure-monitor/app/asp-net-exceptions#diagnose-failures-using-the-azure-portal).

You can then use the conversation lifecycle events data from Customer Service in Application Insights to monitor system health, export, and combine it with additional data sets to build custom dashboards for your business needs.

> [!NOTE]
> - Export of Power Automate and Dynamics 365 Customer Service data is not available in sovereign clouds, such as Government Community Cloud (GCC), Government Community Cloud - High (GCC High), and Department of Defense (DoD).
> - The feature is available in managed environments only.

## Prerequisites

- The user must have access level Contributor or a higher-level permission on Azure Services to set up, and minimum read access to query data in Application Insights.

- The user must be a Power Platform administrator or System Administrator.
- The environment is a managed environment.

## Pricing

The conversation diagnostics data is stored in Azure Application Insights database. Azure Application Insights is an extension of Azure Monitor and charges for data ingested. The two log ingestion plans are Basic and Analytic logs. Learn more about the pricing for your business requirements at [Azure Monitor pricing](https://azure.microsoft.com/pricing/details/monitor/#pricing).

The following table lists the analysis of the average data consumption in Application Insights
 
| Data Consumption                                                                 | Size in kilobytes (average<sup>**1**</sup>) |
|----------------------------------------------------------------------------------|------------------------------|
| Per routed work item (Call/Conversation/Record) with one classification, one route-to-queue (RTQ) ruleset and one assignment ruleset| 7  |
| Per ruleset with a single rule in it                                             | 2                            |
| Per new rule in a ruleset                                                        | 1                            |
 
<sup>**1**</sup> The average values can vary based on factors, like the number of rules, conditions defined within a ruleset, and size of the conditions (number of characters).
 
Let's take an example in which each routing stage has a single ruleset with a couple of rules and moderately complex rule conditions. If you route 500 work items per day, it consumes approximately 4.88 MB of data. Learn about routing stages in [Understand routing stages](unified-routing-diagnostics.md#understand-routing-stages-and-diagnostics).

## Set up a connection with Azure Application Insights

Before you perform a data export, create a connection between your Customer Service instance and Azure Application Insights in Power Platform admin center. You can create only one data export configuration from Customer Service to Application Insights per environment. Learn more in [How to enable data export](/power-platform/admin/conversation-diagnostics-application-insights#set-up-a-connection-with-azure-application-insights).

## Access and use the conversation information in Application Insights

After you've configured the data export setup, conversation lifecycle information for live chat, digital messaging, voice, and custom channel conversations is available in the Application Insights **Traces** table.

To view the logs for a conversation, as a user with minimum reader level, perform the following steps:
1.	Sign into [Azure portal](https://ms.portal.azure.com/) and access your Application Insights instance. Make sure that it's the same instance that you used to set up data export.
1.	Select **Logs** in **Monitoring**.
1.	Use the following sample query in the editor.

```sql
    Traces  
    | extend customDim = parse_json(customDimensions)  
    | extend workItem = tostring(customDim["powerplatform.analytics.resource.id"])  
    | extend subscenario = tostring(customDim["powerplatform.analytics.subscenario"])  
    | where workItem == "Insert conversation ID of work item"  
    // | where subscenario contains "Classification"  
    | project timestamp, workItem, subscenario, customDim  
```

  The **Results** tab displays the query results. 

### Related information

[Subscenarios in conversation diagnostics](conversation-diagnostics-subscenarios.md)  
[Sample queries and dashboard](conversation-diagnostics-sample-queries.md)  


