---
title: Predictive Matching Policy APIs (Hub)
description: Enables predictive matching of profile and interaction instances within a hub.
keywords: Customer Insights; Hub API; Predictive Matching; conflation
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/12/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 5c6ac718-9758-43e8-b5f7-d8c21bbb1000
---

Predictive Matching Policy APIs
==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

_Predictive matching_ (sometimes called _conflation_ is the process of identifying, matching, and optionally combining information about the same entity across multiple data sources (in the absence of a shared, unique identifier). Customer Insights offers optional conflation processing that initially supports Profile entity instances over the following _contexts_ and match characteristics. These conflation contexts are applied to the associated properties of two entities in separate data sources to determine the match strength. 

|**Context**|**Match Characteristics (defined hints)**|
| ------------------ | ----------------------------- |
| Name | ● Match between two full-names <br> ● Match between two sets of first-name + middle-name + last-name <br> ● Match between a first + middle + last and a full-name  <br> ●	Abbreviations and Nicknames will be supported for English|
| Address | ● Common abbreviations for "Street", "Avenue", etc. <br> ● Matches between full or partial street addresses and locations (City/State/Country) |
| Email | ●	Case sensitivity match between email addresses <br>  ● User name portion match across domains |
| Phone | ●	Different formats  and representations of phone numbers <br> Explicit inclusion or inference of country codes |
| Organization Name | ●	Supports for different forms of suffices such as "Incorporated", "Inc", "Inc.", etc. <br> ●	Supports common abbreviations <br> ● Infers divisional relationships|
| Web Domain | ● Matches between primary domain names with variants such as microsoft.com and www.microsoft.com | 
| Title | ●	Matches between common title variations |
| Default | No built-in hints applied |
| | |

This process is controlled by an associated _conflation policy_, which contains of the following portions:
* A ranked list of contexts (from the table above), each applied to the associated property of the pair of entities under comparison. For example, the Individual Name context can be applied to compare the **Contact.FirstName + Contact.LastName** properties in one entity to the **SocialProfile.PersonName** property in another entity. 
* A _match threshold_ that indicates the minimum matching strength required for acceptance. The valid values range from 80 to 100 in increments of 1.
* A _Top-N matches_ value that specifies the number of accepted matches that should be stored for each profile. 

<!-- TODO: Spec also talks about profile-to-profile RelationshipType and RelationshipThreshold properties. Are these implemented in Potassium? -->

Each subscription of Customer Insights contains a Predictive Matching Service that runs periodically (at least once per day) to find matches on newly ingested data. Recurring predictive matches are evaluated with every invocation of this service, whereas non-recurring matches are only run once after policy creation. The service will suppress evaluation of recurring matches if the data source has not been significantly modified since the previous run.


## Querying the Results of Predictive Matching 

After a custom [Predictive Match Policy ](../types/predictivematchpolicy.md) type has been evaluated, you can retrieve the matched [Profile](../types/profile.md) or [Interaction](../types/interaction.md) instances through an associated GET operation.

### Profile-to-Profile Matches

Match results are stored as instances of the relationship associated with policy creation. These matched relationships can be retrieved and filtered through an operation such as (assuming a policy has been evaluated on the custom Contact entity type):

`GET <hub-endpoint>/data/profiles/contact('<contactId>')/relationships?$filter='relationshipName=conflation'`

<!-- TODO: Do I need a new topic, for more information, see "List relationships associated with a Profile"? -->


### Profile-to-Interaction Matches

Match results are stored as instances of the interaction associated with policy creation. These matched interactions can be retrieved by using the flag **includePredictiveMatchResults**. The retrieval operation has the following form (assuming a policy has been evaluated on the custom Contact entity type):

`GET <hub-endpoint>/data/contacts('<contactId>')/interactions?includePredictiveMatchResults=true&$filter='InteractionType=<policyName>'`

Or alternately:

`GET <hub-endpoint>/data/contacts('<contactId>')/interactions?includePredictiveMatchResults=true&$filter='type=conflation'`

The conflated interactions contain a confidence number and a conflation policy GUID. For more information, see [List Interactions associated with a Profile Type](../hubdata/interactionlistviaprofile.md).


