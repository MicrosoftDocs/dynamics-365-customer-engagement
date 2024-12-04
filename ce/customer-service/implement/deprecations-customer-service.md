---
title: Deprecations in Dynamics 365 Customer Service
description: Use this article to get information about features that are deprecated in Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: conceptual
ms.date: 10/29/2024
ms.custom: bap-template
ms.collection:
---

# Deprecations in Customer Service

The features that are deprecated in Customer Service are listed in this article.

Administrators and IT professionals can use this information to prepare for future releases.

> [!IMPORTANT]
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability will continue to work and will be fully supported until it's officially removed. This deprecation notification might span a few years. After removal, the feature or capability won't work. We're notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.

## Provisioning of Omnichannel for Customer Service in Power Platform admin center is deprecated

Starting October 2024, the legacy provisioning of Omnichannel for Customer Service in Power Platform admin center is deprecated and will no longer be accessible. This deprecation is being done in phases. To provision channels, use the new [provisioning experience](/dynamics365/contact-center/implement/provision-channels) in Contact Center admin center or Customer Service admin center.

## Customer Service Hub app to be removed for new organizations with Enterprise licenses in February 2025

Effective February 2025, the Customer Service Hub app will no longer be available for all new organizations with Enterprise licenses. We'll continue to support the application for all existing organizations and new customers with license types other than Enterprise (for example, Customer Service Professional licenses). We recommend that existing customers migrate to Customer Service workspace. More information: [Migrate to Customer Service workspace from removed or deprecated apps](../administer/migrate-to-csw.md)

## Diagnostics in unified routing is deprecated

The [diagnostics](../administer/unified-routing-diagnostics.md) feature in unified routing is deprecated as of May 09, 2024. We recommend that you use [Conversation diagnostics in Azure Application Insights](/power-platform/admin/conversation-diagnostics-application-insights) to get diagnostics information. You can delete your routing diagnostics-related data from Dataverse using the steps in [Manage routing diagnostics data](../administer/manage-routing-diagnostics-data.md). Contact Microsoft Support if you need help.

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

With the release of the Customer Service admin center app that consolidates admin experiences across the Customer Service suite, the following admin experiences are deprecated and no longer supported as of April 2023.

- Service Management area in the Customer Service Hub app
- Omnichannel admin center
- **App profile manager**: Removed as of April 2023.

Also, as of October 2022, the Omnichannel admin center and the service management area in Customer Service Hub are hidden by default in newly created organizations and environments. You can bring them back, but we recommend that you start using the Customer Service admin center app to perform tasks like manage cases, and configure unified routing, channels, and agent experience profiles. More information: [Get started with Customer Service admin center](cs-admin-center.md)

## Omnichannel Administration app is deprecated and removed as of July 2023

Support for the Omnichannel Administration app ended on April 30, 2022, and the app was removed in July 2023. We recommend that you use the Customer Service admin center app to configure the latest features, such as unified routing and voice channel. More information: [Get started with Customer Service admin center](cs-admin-center.md)

## Omnichannel for Customer Service agent-facing app is deprecated and removed as of June 2024

Effective April 2023, the Omnichannel for Customer Service agent-facing app is deprecated. Support is available until June 2024. We recommend that you migrate your omnichannel configuration to Customer Service workspace. More information: [Migrate to Customer Service workspace from deprecated or removed apps](../administer/migrate-to-csw.md)

## setContextProvider method for authenticated chat is deprecated

The setContextProvider method for authenticated chat is deprecated and no longer supported as of October 1, 2021. We recommend that you use the JWT token for authenticated chat. More information: [Send authentication tokens](../develop/send-auth-token-starting-chat.md)

## Support for some knowledge management entities is deprecated <a name="deprecatedkmentities"></a>

The KbArticle, KbArticleComment, and KbArticleTemplate knowledge management entities that were deprecated earlier aren't supported as of October 1, 2021. We recommend that you use the newer KnowledgeArticle entity (introduced in CRM Online 2016 Update and Dynamics 365) for knowledge management in Dynamics 365. For more information, go to [Work with knowledge articles](../administer/work-knowledge-articles.md)

## Internet Explorer 11 support for Dynamics 365 and Microsoft Power Platform is deprecated
 
Effective October 31, 2022, Dynamics 365 Customer Service and Power Platform are blocked in Internet Explorer. As of early October 2022, users are redirected to Microsoft Edge if it's installed on their device. Otherwise, they receive a non-dismissible message informing them why they're blocked and to use Customer Service on [Microsoft Edge](https://www.microsoft.com/edge). More information: [Support end for Internet Explorer](/power-platform/admin/support-end-internet-explorer) <br>

For any questions, contact your Microsoft Customer Service representative or Microsoft Partner.

## Automatic record creation rules in web client are deprecated

Effective October 01, 2020, the automatic record creation and update rules are deprecated in the web client. We recommend that you migrate your automatic record creation rules that were created in the web client to the new Unified Interface experience. For information on how to migrate the rules, go to [Migrate automatic record creation rules and service-level agreements](../administer/migrate-automatic-record-creation-and-sla-agreements.md). You can also refer to the migration playbook, which includes all the information you need to work on the migration. More information: [Dynamics 365 SLA and ARC Migration Playbook](https://www.d365implementationguide.com/books/aiij/).

> [!NOTE]
> The deprecation isn't applicable to the features in Dynamics 365 Customer Engagement (on-premises).

## SLAs in web client are deprecated

Effective October 1, 2020, the service-level agreements (SLAs) are deprecated in the web client. We recommend that you migrate your SLAs that were created in the web client to the new Unified Interface experience. For information on how to migrate the items, go to [Migrate automatic record creation rules and service-level agreements](../administer/migrate-automatic-record-creation-and-sla-agreements.md). You can also refer to the migration playbook, which includes all the information you need to work on the migration. Learn more in the [Dynamics 365 SLA and ARC Migration Playbook](https://www.d365implementationguide.com/books/aiij/).

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

Standard service-level agreements (SLA Type field is set to Standard) are deprecated and will be removed in a future major release. Standard SLAs are replaced by enhanced SLAs. For more information, go to [Enhanced service level agreements](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn887187(v=crm.8)).

## Customer Service Insights standalone app is deprecated

The Customer Service Insights standalone app is deprecated. We recommend that you migrate to the [embedded experience](introduction-customer-service-analytics.md) within the core Dynamics 365 Customer Service applications.

## Customer Service workspace legacy layout is deprecated

The Customer Service workspace legacy layout is deprecated as of April 2023, and is no longer supported as of October 2023. For more information, go to [Deprecated Customer Service workspace layout](csw-overview.md#deprecated-customer-service-workspace-layout).

## ResponsibleContactId lookup attribute is deprecated

The incident entity **ResponsibleContactId** lookup attribute is deprecated. Consider the **PrimaryContactId** lookup attribute that was introduced with Service Pack 1 for Microsoft Dynamics CRM 2013 as the primary system lookup attribute to associate incidents with a contact record.

There are no plans to remove the **ResponsibleContactId** lookup attribute. Use the **PrimaryContactId** for new customizations or if you're migrating existing customizations that currently use **ResponsibleContactId**.

### Related information

[Automatically create or update records in Customer Service Hub](../administer/automatically-create-update-records.md)  
[Define service-level agreements](../administer/define-service-level-agreements.md)  
[Important changes (deprecations) coming in Power Apps, Power Automate](/power-platform/important-changes-coming)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
