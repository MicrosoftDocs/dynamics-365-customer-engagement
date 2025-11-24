---
title: Deprecations in Dynamics 365 Customer Service
description: Use this article to get information about features that are deprecated in Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: conceptual
ms.date: 11/14/2025
ms.custom: bap-template
ms.collection:
---

# Deprecations in Customer Service

The features that are deprecated in Customer Service are listed in this article.

Administrators and IT professionals can use this information to prepare for future releases.

> [!IMPORTANT]
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability will continue to work and will be fully supported until it's officially removed. This deprecation notification might span a few years. After removal, the feature or capability won't work. We're notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.

## D365 Service MCP Server is deprecated

As on November 24, 2025, the D365 Service MCP Server is deprecated and will be removed in a future release. We recommend that you use the new Dynamics 365 Customer Service MCP Server and remove the deprecated tool. Learn more in [Connect to Dynamics 365 Customer Service MCP Server with Model Context Protocol (preview)](../administer/configure-customer-service-mcp-server.md).

## Historical analytics dashboards for unified routing are deprecated in Customer Service and Dynamics 365 Contact Center

Starting June 30, 2025, [Historical analytics for unified routing in Omnichannel for Customer Service](../use/oc-historical-analytics-unified-routing.md#historical-analytics-for-unified-routing) and [Historical analytics for unified routing in Customer Service](../use/cs-historical-analytics-unified-routing.md#historical-analytics-for-unified-routing-in-customer-service) dashboards are deprecated in Dynamics 365 Customer Service and Dynamics 365 Contact Center. Support ends on August 31, 2025, after which this feature will be removed.

## Legacy version of Case and Conversation Topics in Customer Service and Contact Center is deprecated

Starting June 20, 2025, the legacy AI topic clustering for [Cases](../administer/configure-topics-clustering-cases-cs.md#configure-ai-topic-clustering-for-cases) and [Conversation Topics](../administer/ai-topic-clustering-conversations.md#configure-ai-topic-clustering-for-conversations) in Dynamics 365 Customer Service and Dynamics 365 Contact Center is deprecated and will reach the end of support. After August 31, 2025, this feature will be removed and users won't be able to use it in Dynamics 365 Customer Service and Dynamics 365 Contact Center.

## setClickToAct (JavaScript API Reference) to be deprecated on October 31, 2025

In Dynamics 365 Channel Integration Framework versions 1 and 2, the setClickToAct (JavaScript API Reference) API will be deprecated on October 31, 2025. If you need to change outbound configuration for your channel provider, review [Enable outbound communication (ClickToAct) in Dynamics 365 Channel Integration Framework 2.0](../../channel-integration-framework/v2/administer/enable-outbound-communication-clicktoact.md).

## Omnichannel agent and supervisor dashboard experiences to be deprecated on December 1, 2025

The Omnichannel dashboard experiences in Copilot Service workspace will be deprecated on December 1, 2025. Support will end on December 1, 2026. This upcoming change affects customers who use the agent or supervisor dashboard experiences. We recommend that you transition to the [inbox experience](../use/use-inbox.md) and [Omnichannel real-time analytics report](../use/intro-realtime-analytics-dashboard.md) in the Copilot Service workspace app. 

Copilot Service workspace offers modern customer service experiences, with features like multi-entity support, read and unread configurations, card configuration, and Copilot-suggested actions. The inbox is the recommended solution for customer service representatives to manage their work items. The inbox is continuously being updated with more AI features and enhanced configurations. [Get started with a trial version of Copilot Service workspace](https://www.microsoft.com/dynamics-365/products/customer-service).

## Effort estimation model in unified routing is deprecated

The effort estimation model in unified routing was deprecated on May 02, 2025. The support for the feature ended and the feature was removed on June 02, 2025.

## Auto-summarization of ongoing conversations is deprecated

Starting April 16, 2025, we no longer support the auto-summarization of ongoing conversations in Customer Service apps. We recommend that you use [Copilot-generated conversation summary](/dynamics365/contact-center/use/copilot-summarize-conversations#view-a-conversation-summary).


## Rich text editor classic experience is deprecated

As of April 18, 2025, the classic rich text editor experience is deprecated in Customer Service apps. The new, modernized rich text editor is the default experience, and customers who used the classic experience were upgraded automatically. Learn more in [Modern text editor enhancements](/power-apps/maker/model-driven-apps/rich-text-editor-control#modern-text-editor-enhancements).

## Case and knowledge suggestions in smart assist are deprecated

Starting June 02, 2025, we no longer support [case and knowledge suggestions](../use/oc-view-ai-suggested-cases-articles.md) via smart assist in Customer Service. We recommend that you [make Copilot available to your customer service representatives](../administer/configure-copilot-features.md#make-copilot-available-to-representatives).

## Dynamics 365 Unified Service Desk to be deprecated in April 2026

Beginning April 01, 2026, Unified Service Desk will be deprecated. We recommend that you start using [Copilot Service workspace](../implement/csw-overview.md). Learn more in [Transition from Unified Service Desk to Copilot Service workspace](https://www.microsoft.com/dynamics-365/blog/it-professional/2025/01/22/transition-from-unified-service-desk-to-customer-service-workspace/).

## Provisioning of Omnichannel for Customer Service in Power Platform admin center is deprecated

As of October 2024, the legacy provisioning of Omnichannel for Customer Service in Power Platform admin center is deprecated and is no longer be accessible. This deprecation is being done in phases. To provision channels, use the new [provisioning experience](/dynamics365/contact-center/implement/provision-channels) in Copilot Service admin center.

## Customer Service Hub app is removed for new organizations with Enterprise licenses

Effective February 2025, the Customer Service Hub app is no longer available for all new organizations with Enterprise licenses. We continue to support the application for all existing organizations and new customers with license types other than Enterprise (for example, Customer Service Professional licenses). We recommend that existing customers migrate to Copilot Service workspace. Learn more in [Migrate to Copilot Service workspace from removed or deprecated apps](../administer/migrate-to-csw.md).

## Diagnostics in unified routing is deprecated

The [diagnostics](../administer/unified-routing-diagnostics.md) feature in unified routing is deprecated as of May 09, 2024. The feature will be removed on January 01, 2026. We recommend that you use [Conversation diagnostics in Azure Application Insights](../administer/configure-conversation-diagnostics.md) to get diagnostics information. You can delete your routing diagnostics-related data from Dataverse using the steps in [Manage routing diagnostics data](../administer/manage-routing-diagnostics-data.md). Contact Microsoft Support if you need help.

## Omnichannel for Customer Service on Unified Service Desk is deprecated and will be removed in October 2025

Effective April 4, 2024, Omnichannel for Customer Service on Unified Service Desk is deprecated. Support is available until April 2025. The app will be removed from all environments by October 2025.

## WeChat, SMS (Telesign), Telegram custom messaging, and Kik custom messaging channels are deprecated and removed

The following channels are deprecated and were removed in Omnichannel for Customer Service on October 8, 2024:

- WeChat
- SMS (Telesign)
- Telegram custom messaging
- Kik custom messaging

Alternative channel integration options are available. Contact Microsoft Support if you need help. 

## Google's Business Messages channel is deprecated and removed

The channel for Google's Business Messages in Omnichannel for Customer Service is deprecated and removed. Google previously announced that it would discontinue Business Messages on July 31, 2024.

Alternative channel integration options are available. Contact Microsoft Support if you need help. 

## Microsoft Power BI template reports for Customer Service Analytics and Omnichannel Insights are deprecated

Effective November 6, 2023, Microsoft Power BI template reports for [Customer Service Analytics dashboards](configure-customer-service-analytics-dashboard.md) and [Omnichannel Insights](configure-historical-sentiment-dashboard-supervisor.md) are deprecated. We recommend that you start using the out-of-box [Omnichannel historical analytics](../use/omnichannel-analytics-insights.md) and [Customer Service historical analytics](../use/customer-service-analytics-insights-csh.md) reports.  

The deprecated features are no longer supported and product availability ended on February 28, 2024. Effective April 30, 2024, deprecated features aren't available to download.  

## Intraday insights reports in Omnichannel for Customer Service are deprecated

The [Omnichannel intraday insights reports](intro-intraday-insights-dashboard.md) are deprecated as of May 1, 2023. However, no new functionalities for intraday insights will be released henceforth.

Effective April 30, 2024, Omnichannel intraday insights reports aren't available for existing organizations. Reports aren't available for new organizations or tenants onboarded after May 01, 2023, or for those organizations that haven’t used the reports in the last 30 days.

## Some admin apps are deprecated

With the release of the Copilot Service admin center app that consolidates admin experiences across the Customer Service suite, the following admin experiences are deprecated and no longer supported as of April 2023.

- Service Management area in the Customer Service Hub app
- Omnichannel admin center
- **App profile manager**: Removed as of April 2023.

Also, as of October 2022, the Omnichannel admin center and the service management area in Customer Service Hub are hidden by default in newly created organizations and environments. You can bring them back, but we recommend that you start using the Copilot Service admin center app to perform tasks like manage cases, and configure unified routing, channels, and agent experience profiles. Learn more in [Get started with Copilot Service admin center](cs-admin-center.md).

## Omnichannel Administration app is deprecated and removed as of July 2023

Support for the Omnichannel Administration app ended on April 30, 2022, and the app was removed in July 2023. We recommend that you use the Copilot Service admin center app to configure the latest features, such as unified routing and voice channel. Learn more in [Get started with Copilot Service admin center](cs-admin-center.md).

## Omnichannel for Customer Service agent-facing app is deprecated and removed as of June 2024

Effective April 2023, the Omnichannel for Customer Service agent-facing app is deprecated. Support is available until June 2024. We recommend that you migrate your omnichannel configuration to Copilot Service workspace. Learn more in [Migrate to Copilot Service workspace from deprecated or removed apps](../administer/migrate-to-csw.md).

## setContextProvider method for authenticated chat is deprecated

The setContextProvider method for authenticated chat is deprecated and no longer supported as of October 1, 2021. We recommend that you use the JWT token for authenticated chat. Learn more in [Send authentication tokens](../develop/send-auth-token-starting-chat.md).

## Support for some knowledge management entities is deprecated <a name="deprecatedkmentities"></a>

The KbArticle, KbArticleComment, and KbArticleTemplate knowledge management entities that were deprecated earlier aren't supported as of October 1, 2021. We recommend that you use the newer KnowledgeArticle entity (introduced in CRM Online 2016 Update and Dynamics 365) for knowledge management in Dynamics 365. Learn more in [Work with knowledge articles](../administer/work-knowledge-articles.md).

## Internet Explorer 11 support for Dynamics 365 and Microsoft Power Platform is deprecated
 
Effective October 31, 2022, Dynamics 365 Customer Service and Power Platform are blocked in Internet Explorer. As of early October 2022, users are redirected to Microsoft Edge if it's installed on their device. Otherwise, they receive a non-dismissible message informing them why they're blocked and to use Customer Service on [Microsoft Edge](https://www.microsoft.com/edge). Learn more in [Support end for Internet Explorer](/power-platform/admin/support-end-internet-explorer) <br>.

For any questions, contact your Microsoft Customer Service representative or Microsoft Partner.

## Automatic record creation rules in web client are deprecated

Effective October 01, 2020, the automatic record creation and update rules are deprecated in the web client. We recommend that you migrate your automatic record creation rules that were created in the web client to the new Unified Interface experience. Learn more about migrating rules in [Migrate automatic record creation rules and service-level agreements](../administer/migrate-automatic-record-creation-and-sla-agreements.md).

> [!NOTE]
> The deprecation isn't applicable to the features in Dynamics 365 Customer Engagement (on-premises).

## SLAs in web client are deprecated

Effective October 1, 2020, the service-level agreements (SLAs) are deprecated in the web client. We recommend that you migrate your SLAs that were created in the web client to the new Unified Interface experience. Learn more about migrating items in [Migrate automatic record creation rules and service-level agreements](../administer/migrate-automatic-record-creation-and-sla-agreements.md).

> [!NOTE]
> The deprecation isn't applicable to the features in Dynamics 365 Customer Engagement (on-premises).

## Service scheduling in Dynamics 365 Customer Service is deprecated

The existing service scheduling functionality is deprecated, and is no longer available as of December 1, 2020. The new scheduling experience, built on Universal Resource Scheduling, is available in Unified Interface.

Existing service scheduling users are provided with advanced notice for a time-bound migration to the new scheduling capabilities.

There are two approaches to migrate to the scheduling experience:

To set up the new scheduling experience for an existing Dynamics 365 Customer Service organization, follow the guidance in the [Service Scheduling Guide](../administer/basics-service-service-scheduling.md). 

If your organization requires features that rely on legacy APIs, the product team is offering an incremental migration option and will update your organization to the Unified Interface experience and continue to allow the use of the legacy APIs. This approach is available as of 2020 release wave 2 with Early Access in August 2020.

## Contracts, Contract Line Items, and Contract Templates entities are deprecated

The Contracts, Contract Line Items, and Contract Templates entities are deprecated and aren't supported as of April 1, 2022. This functionality is replaced with [entitlements](../administer/create-entitlement-define-support-terms-customer.md) in Unified Interface. The [web client](/power-platform/important-changes-coming#legacy-web-client-is-deprecated) was removed as on December 1, 2020. We recommend that you migrate your contracts to entitlements by using the [Strategy for migrating from contracts to entitlements](../administer/contract-to-entitlement-migration.md).

## Standard SLAs in Dynamics 365 Customer Service are deprecated

Standard service-level agreements (SLA Type field is set to Standard) are deprecated and will be removed in a future major release. Standard SLAs are replaced by enhanced SLAs. Learn more in [Enhanced service level agreements](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn887187(v=crm.8)).

## Customer Service Insights standalone app is deprecated

The Customer Service Insights standalone app is deprecated. We recommend that you migrate to the [embedded experience](introduction-customer-service-analytics.md) within the core Dynamics 365 Customer Service applications.

## Customer Service workspace legacy layout is deprecated

The Customer Service workspace legacy layout is deprecated as of April 2023, and is no longer supported as of October 2023. Learn more in [Deprecated Customer Service workspace layout](csw-overview.md#deprecated-customer-service-workspace-layout).

## ResponsibleContactId lookup attribute is deprecated

The incident entity **ResponsibleContactId** lookup attribute is deprecated. Consider the **PrimaryContactId** lookup attribute that was introduced with Service Pack 1 for Microsoft Dynamics CRM 2013 as the primary system lookup attribute to associate incidents with a contact record.

There are no plans to remove the **ResponsibleContactId** lookup attribute. Use the **PrimaryContactId** for new customizations or if you're migrating existing customizations that currently use **ResponsibleContactId**.

### Related information

[Automatically create or update records in Customer Service Hub](../administer/automatically-create-update-records.md)  
[Define service-level agreements](../administer/define-service-level-agreements.md)  
[Important changes (deprecations) coming in Power Apps, Power Automate](/power-platform/important-changes-coming)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
