---
title: Dataverse entities used in historical and real-time analytics 
description: Learn about the Dataverse entities used in historical and real-time analytics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection: 
ms.date: 10/29/2024
ms.custom: bap-template
---

# Dataverse entities used in historical and real-time analytics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

> [!Note]
> Case information is applicable to Customer Service only.

The article describes the Dataverse entities used in historical and real-time analytics.

## Entities used in historical analytics

- msfp_question
- msfp_questionresponse
- msfp_surveyresponse
- organization
- appmodule
- systemuser
- queue msdyn_conversationtopic
- msdyn_conversationtopic_conversation
- msdyn_ocliveworkitem
- msdyn_ocliveworkitemsentiment
- msdyn_statuschangereason
- msdyn_statuschangereasonname
- msdyn_ocsession
- msdyn_ocsessionsentiment
- msdyn_sessionparticipant
- msdyn_transcript
- systemuserroles
- msdyn_agentstatushistory
- annotation
- queuemembership
- msdyn_personasecurityrolemapping
- role
- msdyn_presence
- msdyn_liveworkstream
- msdyn_conversationtopicsetting
- account
- msdyn_conversationinsight
- msdyn_ocsessionparticipantevent
- incident
- subject
- incidentresolution
- msdyn_casetopic
- msdyn_casetopic_incident
- msdyn_casetopicsetting
- queueitem
- bot
- msdyn_botsession
- msdyn_ocvoicemail
- queueitem
- msdyn_copilotinteraction
- email

## Entities used in real-time analytics

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
- choiceLabel (new entity for option set in real-time)

## Next steps

[Use the out-of-the-box data model in your custom reports](use-datamodel.md#use-the-out-of-the-box-data-model-in-your-custom-reports)  
[Customize data models of historical and real-time analytics reports](../administer/model-customize-reports.md#customize-data-models-of-historical-and-real-time-analytics-reports)