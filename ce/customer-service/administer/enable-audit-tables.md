---
title: Search Customer Service admin logs in Microsoft Purview
description: Learn how to view and search audited events in the Microsoft Purview audit log to track admin activity in your organization.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.collection:
ms.date: 02/24/2025
ms.custom: bap-template
ai.usage: ai-assisted
---

# Search Customer Service admin logs in Microsoft Purview

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


To track the activities of admins in your organization, view a log of audited Customer Service events in the [Microsoft Purview compliance portal](/power-platform/admin/logging-powerapps). Auditing can be set on an entire environment, a table, and even on individual columns.

## Prerequisites

- You're an administrator.
- [You have access to the Microsoft Purview portal (preview)](/purview/purview-permissions).

## Turn on auditing

You can set auditing for an environment, a table, and a column.

- [Configure auditing for an environment](/power-platform/admin/manage-dataverse-auditing#configure-auditing-for-an-environment).

- [Configure auditing for tables and columns in Power Apps](/power-platform/admin/manage-dataverse-auditing#configure-auditing-for-one-or-more-tables-and-columns-in-power-apps).

## Activities available for audit

The following table lists the activities that can appear in Customer Service audit logs.

| Activity scope (object) | Description |
| --------- | -------------- |
| queue | Create queues to distribute work to customer service representatives (service representatives or representatives). |
| routingrule | Create rules to route work items to service representatives. |
| msdyn_liveworkstream | Set up a channel with rules to distribute work. |
| msdyn_ocphonenumber | Add phone numbers to create voice channels. |
| msdyn_liveworkstream, msdyn_livechatconfig, msdyn_ocvoicechannelsetting | Add channels to provide service to customers. |
| msdyn_contactcenterstate | Add a simple contact center using defaults. |
| msdyn_csadminconfig | Create guided channels with queues and routing. |
| bot | Add an AI agent (agent) to a workstream for representative transfers. |
| bot | Connect a agent to a workstream for representative transfers. |
| entitlement | Specify terms based on hours or cases. |
| slaitem, slakpiinstance, sla | Track agreements and ensure support according to the terms of service-level agreements (SLAs). |
| subject | Categorize cases for quick service to customers. |
| convertrule | Automatically create or update records. |
| incident | Track multiple issues for customers. |
| advancedsimilarityrule | View similar cases in the Customer Service admin center. |
| SaveSettingValue | Simplify case experience for productivity. |
| msdyn_integratedsearchprovider | Ingest knowledge search data into an organization. |
| msdyn_kmfederatedsearchconfig | Find and share knowledge from multiple sources. |
| msdyn_knowledgearticletemplate | Simplify knowledge article creation. |
| Organization | Set up a search control for knowledge searches. |
| knowledge management settings | Set up record types for knowledge management. |
| Organization | Set up record types for representatives and authors. |
| Categories | Categorize knowledge articles. |
| Organization,  msdyn_knowledgesearchfilter | Set up standard and custom filters. |
| Organization | Share knowledge articles as URLs. |
| Organization, msdyn_UpdatePaneTabConfigForTeam | Manage the representative chat experience. |
| msdyn_csadminconfig | Manage swarming settings. |
| msdyn_datainsightsandanalyticsfeature | Help managers understand team metrics. |
| msdyn_datainsightsandanalyticsfeature, msdyn_ocvoicechannelsetting | Get insights on customer service performance. |
| msdyn_datainsightsandanalyticsfeature, msdyn_dataanalyticsreport_ksinsight | Help authors understand content. |
| msdyn_omnichannelconfiguration | Manage supervisor settings for conversations. |
| msdyn_datainsightsandanalyticsfeature, msdyn_agentresourceforecasting | Get case volume forecasts. |
| msdyn_datainsightsandanalyticsfeature, msdyn_occhannelconfiguration, msdyn_agentresourceforecasting | Forecast the number and skills of representatives who are needed for conversations. |
| msdyn_datainsightsandanalyticsfeature, msdyn_dataanalyticsworkspace | Add new metrics for historical business needs. |
| msdyn_datainsightsandanalyticsfeature, msdyn_dataanalyticsworkspace | Add new metrics for real-time business needs. |
| msdyn_datainsightsandanalyticsfeature, msdyn_ocvoicechannelsetting, msdyn_dataanalyticsreport_oc_rt | Get real-time analytics on representative productivity. |
| msdyn_agentcopilotsetting | Use AI to find answers for customers. |
| msdyn_copilotsummarizationsetting | Review cases with AI-generated summaries. |
| msdyn_casetopicsetting | Manage AI topics from cases. |
| msdyn_conversationtopicsetting | Manage AI topics from conversations. |
| msdyn_datainsightsandanalyticsfeature | Manage AI summaries from conversations. |
| msdyn_suggestionssetting | Help representatives solve cases with AI suggestions. |
| msdyn_kbkeywordsdescsuggestionsetting, msdyn_datainsightsandanalyticsfeature | Help authors add metadata with AI suggestions. |
| msdyn_omnichannelconfiguration | Set up real-time translation for representatives. |
| msdyn_sentimentanalysise | Track real-time customer sentiment with AI. |
| msdyn_ocskillidentmlmodel | Manage models that identify skills. |
| msdyn_omnichannelconfiguration | Manage skill-based routing settings. |
| msdyn_iermlmodel | Create models that use AI to measure effort. |
| msdyn_sentimentanalysis | Set up machine learning to predict sentiment. |
| msdyn_panetoolconfiguration | Help representatives resolve issues quickly. |
| msdyn_omnichannelconfiguration | Turn on transcription. |
| msdyn_ocvoicechannelsetting,msdyn_liveworkstream, msdyn_ocprovisioningstate | Create configurations for representatives to make or receive calls. |
| msdyn_omnichannelconfiguration | Send and receive formatted messages. |
| msdyn_cannedmessage, msdyn_octag | Allow representatives to create quick replies. |
| msdyn_ocrichobject, msdyn_octag | Create a rich messaging experience for customers. |
| msdyn_ocsystemmessage | Create reusable messages for customers. |
| msdyn_productivityagentscript | Create scripts for representatives. |
| workflow, msdyn_productivitymacrosolutionconfiguration | Create automated actions for efficiency. |
| msdyn_presence | Set presences to auto update for representatives. |
| msdyn_omnichannelconfiguration | Create rules to mask sensitive data. |
| template, msfp_emailtemplate | Create reusable email content. |
| emailsignature | Create email signatures for outgoing emails. |
| msdyn_appconfiguration | Create targeted app experiences for representatives. |
| msdyn_sessiontemplate | Choose which templates open for new sessions. |
| msdyn_applicationtabtemplate | Choose which tabs open for new sessions. |
| msdyn_omnichannelconfiguration | Choose the information to show for notifications. |
| msdyn_channelprovider | Set up a third-party voice channel. |
| SaveSettingValue | Customize conversation forms for representatives. |
| msdyn_appconfiguration, msdyn_appprofilerolemapping | Turn on productivity tools in custom model-driven apps. |
| msdyn_occarrier, msdyn_ocphonenumber, msdyn_ocprovisioningstate | Define the types and amount of work for representatives. |
| msdyn_capacityprofile, systemuser | Create and assign skills to representatives. |
| characteristic | Map roles to personas for multiple services. |
| msdyn_personasecurityrolemapping, role | Manage key attributes for users in bulk. |
| msdyn_ocautoblockrule, msdyn_ocflaggedspam | Review and manage blocked numbers. |
| msdyn_authenticationsettings | Validate signed-in customers from a domain. |
| msdyn_ocapplepay, msdyn_ocpaymentprofile | Set up payment profiles to support commerce. |
| msdyn_oc_geolocationprovider | Detect customer location using coordinates. |
| msdyn_ocphonemusic | Manage music files for hold or wait music. |
| msdyn_omnichannelconfiguration | View previous customer actions. |
| msdyn_ocoutboundconfiguration | Send messages to targeted customers. |
| msdyn_oclocalizationdata | Customize messages for representatives in sessions. |
| msdyn_iotsettings | Change Internet of Things (IoT) settings. |
| msdyn_operatinghour | Define the hours when representatives interact with customers. |
| calendar | Create a holiday schedule for your calendar. |
| calendar | Define availability for customer support. |
| msdyn_organizationalunit | Create organizational units that reflect your business. |
| equipment | Create sites to define locations for customer service. |
| bookableresource | Schedule anything termed as a resource. |
| service | Define specifics of services for customers. |
| msdyn_businessclosure | Prevent scheduling resources on holidays. |
| msdyn_timegroup | Customize how to show assistant results. |
| bookableresourcecategory | Group bookable resources by type. |
| organization | Set up Omnichannel for Customer Service in an organization. |
| organization | Upgrade omnichannel solutions in an organization. |
| organization | Turn off Omnichannel for Customer Service in an organization. |
| organization | Turn on Omnichannel for Customer Service in a trial organization. |

## Search audited events

[Learn how to search the audit log in Microsoft Purview](/power-platform/admin/admin-activity-logging).

[Learn more about the Microsoft Purview audit log, data retention policies, and capabilities](/purview/audit-solutions-overview).

### Related information

[Audit New Search](/purview/audit-new-search)
