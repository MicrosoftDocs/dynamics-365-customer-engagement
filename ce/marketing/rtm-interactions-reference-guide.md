---
title: "A reference guide for Real-time marketing interactions (Dynamics 365 Marketing) | Microsoft Docs"
description: "This article lists the managed lake data schema for real-time marketing interactions in Dynamics 365 Marketing."
ms.date: 10/26/2022
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---
# Real-time marketing interactions reference guide

The table below is sorted by real-time marketing channels (email, text message, push) and includes the data tables and columns real-time marketing interactions can be found in. The table also includes a description of the type of interaction data stored. For example, the description column shows that the msdynmkt_emailaddress field lists customers' email address. You can use this schema to plug the interaction data into your own reporting tools such as Microsoft Power BI.

#### Channel: *Common Column* |	Email:	*[<u>Source</u>](https://dev.azure.com/dynamicscrm/CXPlatform/_git/CXP-Main?path=%2Fsrc%2FSolutions%2FEmailChannel%2FSolution%2Funmanaged%2FAssets%2Fcatalogassignments.xml&_a=contents&version=GBmaster)*


| **Table**                | **Column**                 | **Description**                                                                                         |   |   |   |   |
|--------------------------|----------------------------|---------------------------------------------------------------------------------------------------------|---|---|---|---|
| ALL   (Email, SMS, Push) | msdynmkt_journeyid         | The field indicates the Id of the Journey definition.                                                    |   |   |   |   |
|                          | msdynmkt_journeyrunid      | The field indicates the Id of journey instance.                                                         |   |   |   |   |
|                          | msynmkt_messagetemplateid  | The field indicates the id of the message template, for example email template id, sms template id etc. |   |   |   |   |
|                          | msdynmkt_profileid         | The field indicates the profile id of the C2 user.                                                      |   |   |   |   |
|                          | msdynmkt_targetentity      | The field indicates the target entity type, for example contact, lead.                                  |   |   |   |   |
|                          | Msdynmkt_actionid          | The field indicates the id of the action in the journey definition.                                     |   |   |   |   |
|                          | Msdynmkt_businessunitid    | The field indicates the business unit id.                                                               |   |   |   |   |
|                          | Singal.Ingestion.Timestamp | The field indicates the time stamp of the event ingested into the CDPA system.                          |   |   |   |   |
|                          | msdynmkt_originaltimestamp | This field indicates the time stamp of the event when channel has emitted it.                           |   |   |   |   |