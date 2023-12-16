---
title: Enable admin activity auditing
description: Enable admin activity auditing in Dynamics 365 Customer Service. 
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection:
ms.date: 12/15/2023
ms.custom: bap-template
---

# Enable admin activity auditing

You can enable admin activity auditing. Do the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables** > **Properties**.
1. On the **Edit table** pane, select the checkbox for **Audit changes to its data**.
1. Select **Save**.

## Activities an admin can audit

The following table shows the activities that an admin can audit.

| Actitvity scope (object) | Description |
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
| advancedsimilarityrule | View similar cases in customer service hub. |
| SaveSettingValue | Simplified case experience for productivity. |
| msdyn_integratedsearchprovider | Ingest knowledge search data into an organization. | 
| msdyn_kmfederatedsearchconfig | Find and share knowledge from multiple resources. |
| msdyn_knowledgearticletemplate | Simplify creating knowledge articles. |
| Organization | Configure search control for knowledge searches. |
| TThe entity with knowledge management enabled | Enable record types for knowledge management. |
| Organization | Configure record types for agents and authors. |
| Category | Categorize knowledge articles. |
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
| msdyn_datainsightsandanalyticsfeature, msdyn_ocvoicechannelsetting, msdyn_dataanalyticsreport_oc_rt | Get real-time anaytics for agent productivity. |
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
| msdyn_ocvoicechannelsetting,msdyn_liveworkstream, msdyn_ocprovisioningstate | Create configurations for agents to make/receive calls. |
| msdyn_omnichannelconfiguration | Try sending and receiving formatted messages. |
| msdyn_cannedmessage, msdyn_octag | Enable agents to create quick replies. | 

msdyn_ocrichobject, msdyn_octag 

Create rich messaging experience for customers 

msdyn_ocsystemmessage 

Create reusable messages for customers 

msdyn_productivityagentscript 

Create scripts for agents 

workflow, msdyn_productivitymacrosolutionconfiguration 

Create automated actions for efficiency 

msdyn_presence 

Set presences to auto update for agents 

msdyn_omnichannelconfiguration 

create rules to mask sensitive data 

template, msfp_emailtemplate 

Create resuable email content 

emailsignature 

Create email signatures for outgoing emails 

msdyn_appconfiguration 

Create targeted app exeperiences for agents 

msdyn_sessiontemplate 

Choose which templates open for new sessions 

msdyn_applicationtabtemplate 

Choose which tabs open for new sessions 

msdyn_omnichannelconfiguration 

Choose information to show for notifications 

msdyn_channelprovider 

Setup a third party voice channel 

SaveSettingValue 

Customize conversation forms for agents 

msdyn_appconfiguration, msdyn_appprofilerolemapping 

Enable productivity tools in custom model apps 

msdyn_occarrier, msdyn_ocphonenumber, msdyn_ocprovisioningstate 

Define types and amount of work for agents 

msdyn_capacityprofile, systemuser 

Create and assign skills to agents 

characteristic 

Map roles to personas for multiple services 

msdyn_personasecurityrolemapping, role 

Manage key attributes for users in bulk 

msdyn_ocautoblockrule, msdyn_ocflaggedspam 

Review and manage blocked numbers 

msdyn_authenticationsettings 

Validate signed-in customers from a domain 

msdyn_ocapplepay, msdyn_ocpaymentprofile 

Setup payment profiles to support commerce 

msdyn_oc_geolocationprovider 

Detect customer location via coordinates 

msdyn_ocphonemusic 

Manage music files for hold or wait music 

msdyn_omnichannelconfiguration 

View previous customer actions 

msdyn_ocoutboundconfiguration 

Send messages to targeted customers 

msdyn_oclocalizationdata 

Customize messages for agents in sessions 

msdyn_iotsettings 

Setup settings for IoT 

msdyn_operatinghour 

Define hours agents interact with customers 

calendar 

Create a holiday schedule for your calendar 

calendar 

Define availability for customer support 

msdyn_organizationalunit 

Create org units that reflect your business 

equipment 

Create sites to define locations for customer service 

bookableresource 

Schedule anything termed a resource 

service 

Define specifics of services for customers 

msdyn_businessclosure 

Prevent scheduling resources on holidays 

msdyn_timegroup 

Customize how to show assistant results 

bookableresourcecategory 

Group bookable resources by type 

Organization 

Provision Omnichannel on an organization 

Organization 

Upgrade Omnichannel Solutions in an org 

Organization 

Disable Omnichannel on an org 

Organization 

Enable Omnichannel on a trial org 

 
