---
title: Micorsoft Dataverse tables used in historical and real-time analytics 
description: Learn about the Dataverse tables used in historical and real-time analytics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: reference
ms.collection: 
ms.date: 03/13/2026
ms.custom: bap-template
---

# Dataverse tables used in historical and real-time analytics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

> [!Note]
> Case information is applicable to Customer Service only.

The article lists the Dataverse tables used in historical and real-time analytics.

## Tables used in historical analytics

- appmodule
- bot
- email
- incident
- incidentresolution
- msdyn_agentgroup
- msdyn_agentstatushistory
- msdyn_botsession
- msdyn_conversationdispositioncodemap
- msdyn_conversationinsight
- msdyn_conversationmessageblock
- msdyn_copilotevent
- msdyn_copilotinteraction
- msdyn_customerfeedbacksurveyresponse
- msdyn_intent
- msdyn_livechatengagementctx
- msdyn_liveworkstream
- msdyn_oclanguage
- msdyn_ocliveworkitem
- msdyn_ocliveworkitemcontextitem
- msdyn_ocliveworkitemcontextitemelastic
- msdyn_ocliveworkitemsentiment
- msdyn_ocphonecallengagementctx
- msdyn_ocphonenumber
- msdyn_ocsession
- msdyn_ocsessionparticipantevent
- msdyn_ocsessionsentiment
- msdyn_sessionextension
- msdyn_ocvoicemail
- msdyn_personasecurityrolemapping
- msdyn_presence
- msdyn_proactive_delivery
- msdyn_proactive_engagement_config
- msdyn_sessionparticipant
- msdyn_transcript
- msfp_question
- msfp_questionresponse
- msfp_surveyresponse
- organization
- queue
- queueitem
- queuemembership
- businessunit
- systemuser
- systemuserroles


## Tables used in historical bot analytics

- conversationtranscript
- bot
- msdyn_botsession
- msdyn_ocliveworkitemcontextitem
- msdyn_ocliveworkitemcontextitemelastic
- msdyn_oclanguage
- msdyn_ocphonecallengagementctx
- msdyn_sessionextension
- systemuser
- msdyn_liveworkstream
- msdyn_ocliveworkitem
- msdyn_ocsession
  queue
- queuemembership


## Tables used in real-time analytics

- queuemembership
- queue
- msdyn_agentcapacityprofileunit
- msdyn_capacityprofile
- msdyn_presence
- msdyn_agentstatus
- systemuser
- msdyn_liveworkstream
- msdyn_ocliveworkitem
- msdyn_statuschangereason
- msdyn_statuschangereasonname
- msdyn_agentstatushistory
- msdyn_ocsession
- msdyn_sessionparticipant
- msdyn_conversationmessageblock
- ratingvalue
- characteristic
- bookableresource
- bookableresourcecharacteristic
- msdyn_ocliveworkitemcharacteristic
- choiceLabel (entity for option set in real-time)
- businessunit
- choicelabels
- incident
- msdyn_agentgroup
- msdyn_agentgroupmembership
- msdyn_liveworkstreamcapacityprofile
- msdyn_ocphonecallengagementctx
- msdyn_ocphonenumber
- msdyn_sessionextension

## Tables used in real-time bot analytics

- conversationtranscript
- bot
- msdyn_botsession
- msdyn_ocliveworkitemcontextitem
- msdyn_ocliveworkitemcontextitemelastic
- msdyn_oclanguage
- msdyn_ocphonecallengagementctx
- msdyn_sessionextension
- systemuser
- msdyn_liveworkstream
- msdyn_ocliveworkitem
- msdyn_ocsession
- queue
- qeuemembership

## Tables used in knowledge analytics

- msdyn_knowledgesearchinsight
- msdyn_knowledgeinteractioninsight
- appmodule
- knowledgearticle
- feedback
- knowledgearticleincident
- knowledgearticleviews
- msdyn_copilotknowledgeinteraction

## Tables used in agent insights

### Conversation tables

- msdyn_ocliveworkitem 
- msdyn_ocsession
- msdyn_sessionparticipant
- msdyn_evaluation
- msdyn_copilotevent
- msdyn_intententity 
- msdyn_intent
- msdyn_intentfamily
- msdyn_channel
- owner
- systemuser
- msdyn_historicalcaseharvestrun 
- msdyn_knowledgeharvestjobrecord 
- knowledgearticle 

### Case tables

- incident
- Incidentresolution
- msdyn_aiagentstatus 
- msdyn_evaluation
- msdyn_copilotevent 
- msdyn_intententity 
- msdyn_intent
- msdyn_intentfamily
- systemuser
- owner 
- msdyn_historicalcaseharvestrun 
- msdyn_knowledgeharvestjobrecord 
- knowledgearticle
- msdyn_datainsightsandanalyticsfeature

### Shared tables in conversation and case

- msdyn_evaluation
- msdyn_copilotevent
- msdyn_intententity
- msdyn_intent
- msdyn_intentfamily
- systemuser
- owner
- msdyn_historicalcaseharvestrun
- msdyn_knowledgeharvestjobrecord
- knowledgearticle 

## Related information

[Use the out-of-the-box data model in your custom reports](use-datamodel.md#use-the-out-of-the-box-data-model-in-your-custom-reports)  
[Customize data models of historical and real-time analytics reports](../administer/model-customize-reports.md#customize-data-models-of-historical-and-real-time-analytics-reports)
