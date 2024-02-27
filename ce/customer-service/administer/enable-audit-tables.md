---
title: Search Customer Service admin logs in Microsoft Purview
description: View and search audited events in the Microsoft Purview audit log to track admin activity in your organization.
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 02/27/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:12/20/2023
---

# Search Customer Service admin logs in Microsoft Purview

View administrative logs for Customer Service using auditing solutions in Microsoft Purview compliance portal.

## Prerequisites

- You are an administrator.
- To view audit results, you have access to the Purview tool. More information: [Permissions in the Microsoft Purview portal (preview)](/purview/purview-permissions)

## Enable auditing

There are three levels where auditing can be configured: an environment, table, and column.

1. For table auditing to take place, auditing must be first enabled at the environment level. To enable auditing at the environment level, go to [Configure auditing for an environment](/power-platform/admin/manage-dataverse-auditing#configure-auditing-for-an-environment).
2. To enable auditing at the table level, go to [Configure auditing for one or more tables and columns in Power Apps](/power-platform/admin/manage-dataverse-auditing#configure-auditing-for-one-or-more-tables-and-columns-in-power-apps).

## Activities that can be audited

| Activity scope (object) | Description |
| --------- | -------------- |
| queue | Create queues to distribute work to agents. |
| routingrule | Create rules to route work items to agents. |
| msdyn_liveworkstream | Set up a channel with rules to distribute work. |
| msdyn_ocphonenumber | Add phone numbers to create voice channels. |
| msdyn_liveworkstream, msdyn_livechatconfig, msdyn_ocvoicechannelsetting | Add channels to provide service to customers. |
| msdyn_contactcenterstate | Add a simple contact center using defaults. |
| msdyn_csadminconfig | Create guided channels with queues and routing. | 
| bot | Add a bot to workstream for agent transfers. |
| bot | Connect a bot to workstream for agent transfers. | 
| entitlement | Specify terms based on hours or cases. |
| slaitem, slakpiinstance, sla | Track agreements and ensure support per terms. |
| subject | Categorize cases for quick service to customers. |
| convertrule | Automatically create or update records. |
| incident | Track multiple issues for customers. |
| advancedsimilarityrule | View similar cases in Customer Service Hub. |
| SaveSettingValue | Simplify case experience for productivity. |
| msdyn_integratedsearchprovider | Ingest knowledge search data into an organization. | 
| msdyn_kmfederatedsearchconfig | Find and share knowledge from multiple resources. |
| msdyn_knowledgearticletemplate | Simplify creating knowledge articles. |
| Organization | Configure search control for knowledge searches. |
| knowledge management settings | Enable record types for knowledge management. |
| Organization | Configure record types for agents and authors. |
| Categories | Categorize knowledge articles. |
| Organization,  msdyn_knowledgesearchfilter | Set up standard and custom filters. |
| Organization | Share knowledge articles as URLs. |
| Organization, msdyn_UpdatePaneTabConfigForTeam | Manage agent chat experience. |
| msdyn_csadminconfig |Manage swarming settings. |
| msdyn_datainsightsandanalyticsfeature | Help managers understand teams' metrics. |
| msdyn_datainsightsandanalyticsfeature, msdyn_ocvoicechannelsetting | Get insights on customer service performance. |
| msdyn_datainsightsandanalyticsfeature, msdyn_dataanalyticsreport_ksinsight | Help authors understand content. |
| msdyn_omnichannelconfiguration | Manage supervisor settings for conversations. |
| msdyn_datainsightsandanalyticsfeature, msdyn_agentresourceforecasting | Get forecasts of case volume. |
| msdyn_datainsightsandanalyticsfeature, msdyn_occhannelconfiguration, msdyn_agentresourceforecasting | Forecast agents needed for conversations. |
| msdyn_datainsightsandanalyticsfeature, msdyn_dataanalyticsworkspace | Add new metrics for historical business needs. |
| msdyn_datainsightsandanalyticsfeature, msdyn_dataanalyticsworkspace | Add new metrics for real-time business needs. |
| msdyn_datainsightsandanalyticsfeature, msdyn_ocvoicechannelsetting, msdyn_dataanalyticsreport_oc_rt | Get real-time analytics for agent productivity. |
| msdyn_agentcopilotsetting | Use AI to find answers for customers. |
| msdyn_copilotsummarizationsetting | Review cases with AI-generated summaries. |
| msdyn_casetopicsetting | Manage AI topics from cases. |
| msdyn_conversationtopicsetting | Manage AI topics from conversations. |
| msdyn_datainsightsandanalyticsfeature | Manage AI summaries from conversations. |
| msdyn_suggestionssetting | Help agents solve cases through AI suggestions. |
| msdyn_kbkeywordsdescsuggestionsetting, msdyn_datainsightsandanalyticsfeature | Help authors add metadata through AI suggestions. |
| msdyn_omnichannelconfiguration | Set up real-time translation for agents. |
| msdyn_sentimentanalysise | Track real-time customer sentiment with AI. |
| msdyn_ocskillidentmlmodel | Manage  models that identify skills. |
| msdyn_omnichannelconfiguration | Manage skill-based routing settings. |
| msdyn_iermlmodel | Create models that use AI to measure effort. |
| msdyn_sentimentanalysis | Set up machine learning to predict sentiment. |
| msdyn_panetoolconfiguration | Help agents resolve issues quickly. |
| msdyn_omnichannelconfiguration | Enable transcript. |
| msdyn_ocvoicechannelsetting,msdyn_liveworkstream, msdyn_ocprovisioningstate | Create configurations for agents to make or receive calls. |
| msdyn_omnichannelconfiguration | Send and receive formatted messages. |
| msdyn_cannedmessage, msdyn_octag | Enable agents to create quick replies. |
| msdyn_ocrichobject, msdyn_octag | Create rich messaging experience for customers.
| msdyn_ocsystemmessage | Create reusable messages for customers. |
| msdyn_productivityagentscript | Create scripts for agents. |
| workflow, msdyn_productivitymacrosolutionconfiguration | Create automated actions for efficiency. |
| msdyn_presence | Set presences to auto update for agents. |
| msdyn_omnichannelconfiguration | Create rules to mask sensitive data. |
| template, msfp_emailtemplate | Create reusable email content. |
| emailsignature | Create email signatures for outgoing emails. |
| msdyn_appconfiguration | Create targeted app experiences for agents. |
| msdyn_sessiontemplate | Choose which templates open for new sessions. |
| msdyn_applicationtabtemplate | Choose which tabs open for new sessions. |
| msdyn_omnichannelconfiguration | Choose information to show for notifications. |
| msdyn_channelprovider | Set up a third-party voice channel. |
| SaveSettingValue | Customize conversation forms for agents. |
| msdyn_appconfiguration, msdyn_appprofilerolemapping | Enable productivity tools in custom model apps. |
| msdyn_occarrier, msdyn_ocphonenumber, msdyn_ocprovisioningstate | Define types and amount of work for agents. |
| msdyn_capacityprofile, systemuser | Create and assign skills to agents. |
| characteristic | Map roles to personas for multiple services. |
| msdyn_personasecurityrolemapping, role | Manage key attributes for users in bulk. |
| msdyn_ocautoblockrule, msdyn_ocflaggedspam | Review and manage blocked numbers. |
| msdyn_authenticationsettings | Validate signed-in customers from a domain. |
| msdyn_ocapplepay, msdyn_ocpaymentprofile | Set up payment profiles to support commerce. |
| msdyn_oc_geolocationprovider | Detect customer location via coordinates. |
| msdyn_ocphonemusic | Manage music files for hold or wait music. |
| msdyn_omnichannelconfiguration | View previous customer actions. |
| msdyn_ocoutboundconfiguration | Send messages to targeted customers. |
| msdyn_oclocalizationdata | Customize messages for agents in sessions. |
| msdyn_iotsettings | Setup settings for IoT. |
| msdyn_operatinghour | Define the hours agents interact with customers. |
| calendar | Create a holiday schedule for your calendar. |
| calendar | Define availability for customer support. |
| msdyn_organizationalunit | Create organizational units that reflect your business. |
| equipment | Create sites to define locations for customer service. |
| bookableresource | Schedule anything termed as a resource. |
| service | Define specifics of services for customers. |
| msdyn_businessclosure | Prevent scheduling resources on holidays. |
| msdyn_timegroup | Customize how to show assistant results. 
| bookableresourcecategory | Group bookable resources by type. |
| organization | Provision Omnichannel in an organization. | 
| organization | Upgrade Omnichannel solutions in an organization. |
| organization | Disable Omnichannel in an organization. |
| organization | Enable Omnichannel in a trial organization. |

## Search audited events

When the audit log search is turned on in the [Microsoft Purview compliance portal](/power-platform/admin/logging-powerapps), the Microsoft Purview audit log records the admin activity in your organization.

For more information on methods to search events in Microsoft Purview, see [View activities in Microsoft Purview](/power-platform/admin/admin-activity-logging).

For more information about the Microsoft Purview audit log, data retention policies, and capabilities, see [Auditing solutions in Microsoft Purview](/purview/audit-solutions-overview).

## See also

- [Microsoft Purview compliance portal](/purview/microsoft-365-compliance-center)
- [Set up Microsoft Purview auditing solutions](/purview/audit-solutions-overview#set-up-microsoft-purview-auditing-solutions)
- [Audit New Search](/purview/audit-new-search)
