---
title: SessionParticipant
description: Learn about FactSessionParticipant metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/13/2023
ms.custom: bap-template
---

# Session Participant

## External participant channel 
An external agent can be involved in helping customer request by calling them directly on their phone number or via Microsoft teams PSTN call. This metric helps identify the channel through which external agents were engaged.  

## External participant channel type 
This metric represents the details of the external agent like phone number  

## Is handled by external participant 
A customer request could be handled by more than one agent – including a combination of internal contact center agents and external agents. This metric can be used to identify the portion of a customer request that was handled by agents outside of Dynamics 365 Customer Service. External agents could be engaged by your contact center through transfers to an external phone number, Microsoft Teams voice call etc.

## Session participant count

This is a measure of total number of agents involved in assisting customer. This includes the primary agent assigned to working on the session, and SMEs who may have been consulted. This metric can be sliced by the dimension session participation type to get a breakdown. 

## See Also

[Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model)  
[Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service)
