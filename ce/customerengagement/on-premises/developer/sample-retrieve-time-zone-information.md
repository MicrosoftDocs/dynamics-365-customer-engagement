---
title: "Sample: Retrieve time zone information (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to retrieve time zone information."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - retrieving time zone information, time zone entities
  - time zone entities, retrieving time zone information
ms.assetid: 3df3e8c5-ff20-40c7-8ea8-e91001daebd1
caps.latest.revision: 14
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Retrieve time zone information

This sample shows how to retrieve time zone information. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/RetrieveTimeZone).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `RetrieveAllTimeZonesForLocale` method is intended to be used in a scenario where it uses the current locale id to retrieve all the time zones.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `RetrieveCurrentUSerSettings` method retrieves the current users timezone code and locale id.
2. The `RetrieveAllTimeZonesForLocale` method uses the current locale id and retrieves all the time zones.
3. The `GetTimeZoneCodeByLocaleAndName` method retrieves the timezone by name and locale id.
4. The `RetrieveTimeZoneById` method retrieves the timezone by id.
5. The `RetrieveTimeZonesLessThan50` method retrieves time zones less than 50.
6. The `RetrieveLocalTimeFromUTCTime` method retrieves the local time from UTC time.
7. The `RetrieveUTCTimeFromLocalTime` method retrieves the UTC time from the locale time.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]