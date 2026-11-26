---
title: Configure conversation diagnostics
description: Learn about how to query and retrieve diagnostics for conversations in Dynamics 365 Contact Center from Application Insights.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection:
ms.date: 10/20/2026
ms.custom: bap-template
---

# Configure conversation diagnostics

Conversation diagnostics logs each conversation lifecycle event, providing greater visibility into the operational insights and analytics of your organization's conversations. Your support team can proactively monitor the system and developers can easily identify, diagnose, and fix problematic conversations, or seek swift support.

Connect your Dynamics 365 Customer Service environment to an Azure Application Insights instance to collect and store conversation logs. You can learn about Application Insights features and how they can be used to monitor your telemetry and diagnose failures in [Application Insights Overview dashboard](/azure/azure-monitor/app/overview-dashboard) and [Diagnose failures using the Azure portal](/azure/azure-monitor/app/asp-net-exceptions#diagnose-failures-using-the-azure-portal).

You can then use the conversation lifecycle events data in Application Insights to monitor system health, export, and combine it with other data sets to build custom dashboards for your business needs.

> [!NOTE]
> You can't export Power Automate and Dynamics 365 Customer Service data in sovereign clouds, such as Government Community Cloud (GCC), Government Community Cloud - High (GCC High), and Department of Defense (DoD).

## Prerequisites

- The user must have access level Contributor or a higher-level permission on Azure Services to set up.

- At least "Read" access to query data in Application Insights.
- The user must be a Power Platform administrator or System Administrator to do tasks like export data.
- Your environment must be a Managed environment.

## Pricing

The conversation diagnostics data is stored in Azure Application Insights database. Azure Application Insights is an extension of Azure Monitor and charges for data ingested. The two log ingestion plans are Basic and Analytic logs. Learn more about the pricing for your business requirements in [Azure Monitor pricing](https://azure.microsoft.com/pricing/details/monitor/#pricing).

The following table lists the analysis of the average data consumption in Application Insights
 
| Data Consumption                                                                 | Size in kilobytes (KB)  (average<sup>**1**</sup>) |
|----------------------------------------------------------------------------------|------------------------------|
| Per routed work item (Call/Conversation/Record) with one classification, one route-to-queue ruleset, and one assignment ruleset | 7  |
| Per ruleset with a single rule in it                                             | 2                            |
| Per new rule in a ruleset                                                        | 1                            |

<sup>**1**</sup> The average values can vary based on factors, such as the number of rules, conditions defined within a ruleset, and size of the conditions (number of characters).

Let's take an example in which each routing stage has a single ruleset with a couple of rules and moderately complex rule conditions. If you route 500 work items per day, it consumes approximately 4.88 MB of data. A breakup is as follows:

7 KB for one work item routed with one ruleset each for classification, route-to-queue, and assignment plus 3 KB for one extra rule at each of the classification, route-to-queue, and assignment rulesets that equals to 10 KB.

10 KB x 500 work items = 5000 KB, which translates to 4.88 MB.

Learn about routing stages in [Understand routing stages](unified-routing-diagnostics.md#understand-routing-stages-and-diagnostics).

## Set up a connection with Azure Application Insights

Use the guided setup in Copilot Service admin center to connect an Azure Application Insights resource to your environment. Complete the following steps: 

1. Select **Insights** under **Operations**.
1. Under **Observability settings**, for **Conversation lifecycle diagnostics**, select **Manage**. The **Conversation lifecycle diagnostics** page appears.
1. In **Provision Application Insights in Azure**, select the **I've provisioned Application Insights and have the connection string ready** check box if you have provisioned an Application Insights resource. If you don't have an Application Insights resource, select **Open documentation**, and then follow the instructions to create the resource in Azure. Then complete the following steps:
   1. In the [Azure portal](https://ms.portal.azure.com/), open the Application Insights resource overview.
   1. Select **JSON View**, and then copy the value of **App ID**.
   1. Return to the **Conversation lifecycle diagnostics** page, and select **I've provisioned Application Insights and have the connection string ready**.

1. In Copilot Service admin center, in the **Connect Application Insights with your org** section of the guided setup, ensure that the Application Insights resource is connected to your Dynamics 365 environment and select the **Application Insights is connected to my organization** check box. 

1. In **Provide Application Insights ID and provision resources**, complete the following steps:

   1. In **Application Insights ID**, enter the App ID that you copied.
   1. Select **Provision**.
   1. After provisioning is complete, copy the 3P Application Name displayed on the page.

   The guided setup creates the required app and federated identity credential, sets the environment variable, and validates the connection. Review the permissions for the newly created third-party app. Complete the following steps:
     1. In the [Azure portal](https://ms.portal.azure.com/), search for and select the 3P Application Name you copied from the previous step.
     1. Select **API permissions** and verify that the Application Insights Read permission **Status** is **Granted**.
     1. If **Status** is **Not granted**, select the **Grant admin consent**.
     
        :::image type="content" source="../media/app-insights-config.png" alt-text="API permissions in Azure.":::

1. In Copilot Service admin center, in the **Assign the Monitor Reader role** section of the guided setup, select the **I've assigned the Monitor Reader role to the 3P app provisioned in step 3** check box after you've complete the following steps.

   1. In the Azure portal, open the configured Application Insights resource.
   1. Select **Access Control (IAM)**.
   1. Assign the **Monitoring Reader** role to the app that uses the 3P App Client ID you copied. Learn more in [Assign Azure roles using the Azure portal](/azure/role-based-access-control/role-assignments-portal).
   1. Return to the **Conversation lifecycle diagnostics** page, .

1. In **Test the connection**, select **Test connection**.

   If the test succeeds, a confirmation message indicates that the service can read telemetry from Application Insights. If the test fails, review the displayed message, correct the configuration, and test the connection again.

After the connection test succeeds, conversation lifecycle diagnostics is connected to the selected Application Insights resource.

   :::image type="content" source="../media/enable-conversation-diagnostics.png" alt-text="screenshot of enabling conversation diagnostics.":::

### View conversation diagnostics

View conversation diagnostics in Copilot Service workspace. The diagnostics experience displays the events associated with the selected conversation and uses data from Application Insights.

1. In Copilot Service workspace, go to **Conversations** and then select the conversation that you want to diagnose.
1. On the command bar, select **Diagnose**. The diagnostic experience opens in a new tab. It displays the channel, queue, distribution mode, and events associated with the conversation.
1. Select an event to view its details.

For example, for a conversation, select a **Classification** or **Route to queue** event to view the conditions associated with the routing event, including the applied condition, condition that wasn't evaluated, and the final output. You can also view assignment details for the conversation.

   :::image type="content" source="../media/csw-conversation-diagnostics.png" alt-text="screenshot of conversation diagnostics.":::


### View case diagnostics

Use **Diagnose** to review the routing events and details associated with a case.

1. In Copilot Service workspace, go to **Cases**.
1. Select the case that you want to diagnose.
1. On the command bar, select **Diagnose**.
1. Review the routing attempts for the case. 

You can route a case multiple times, and each routing attempt creates a corresponding conversation. Select a routing attempt to review the intake rules for the attempt and details of the corresponding conversation.

   :::image type="content" source="../media/routing-history-case.png" alt-text="screenshot of case diagnostics." lightbox="../media/routing-history-case.png":::



### Related information

[Subscenarios in conversation diagnostics](conversation-diagnostics-subscenarios.md)  
[Sample queries and dashboard](/dynamics365/guidance/resources/conversation-diagnostics-sample-queries)  
[Enable Diagnose dashboard](/dynamics365/contact-center/administer/enable-diagnose-dashboard)  
[Diagnose contact center health using Application Insights dashboard](/dynamics365/contact-center/use/diagnose-dashboard)  

