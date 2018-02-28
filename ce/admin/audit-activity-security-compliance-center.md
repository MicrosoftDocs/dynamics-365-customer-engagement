---
title: "Enable Security Compliance Center auditing (Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: ""
description: Learn xxxxx
ms.date: 03/01/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 817fb922-355a-4d5c-9d93-a320be31c276
caps.latest.revision: 1
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Enable Security Compliance Center auditing

<intro slide 3-5, slide 44-45>
-  companies are required to audit data
-  gdpr
-  dpia
-  uses Azure Auditing <req 1>

No doubt, of highest priority to your business is protecting data, preserving privacy, and complying with regulations such as the [General Data Protection Regulation](https://www.microsoft.com/en-us/TrustCenter/Privacy/gdpr/default.aspx). This topic covers how you can set [!INCLUDE [pn-ms-dyn-365](../includes/pn-ms-dyn-365.md)] to audit activities and use the [Office 365 Security and Compliance Center](https://support.office.com/en-us/article/go-to-the-office-365-security-compliance-center-7e696a40-b86b-4a20-afcc-559218b7b1b8?ui=en-US&rs=en-US&ad=US) to review activity reports.  





## Scenarios to features

Consider the following scenarios you, as the admin, will likely encounter and the features needed to address them.

|Scenario |  |Feature  |
|---------|---------|---------|
|Must be able to record and analyze unauthorized data access   |         | Must be able to clearly identify all the creates and read actions done by the user        |
|Must be able to record and analyze alteration of data     |         |Must be able to clearly identify all the update actions done by the user         |
|Must be able to record and analyze accidental or unlawful destruction of data     |         |Must be able to clearly identify any accidental delete action done by the admin         |
|     |         |Must be able to clearly identify the request origin          |


## Activity across Office and Dynamics

<slide 7 image>

Gopi who is an employee of Contoso performs multiple activities across different Microsoft services to get his daily job done.


## What events are audited
<intro>
### Admin-related events
<table - slide 9>
### User-related events
<table - slide 10>

## What an audit log looks like
<slide 12>

## Enable auditing in Dynamics 365
<slide 17-18, req 5-9>

## Set up auditing in Office 365
<on by default>

## Use reports in Office 365 Security and Compliance Center
<req 56>

## Create reports
<See: https://support.office.com/en-us/article/search-the-audit-log-in-the-office-365-security-compliance-center-0d4d0f35-390b-4518-800e-0c7ec95e946c?ui=en-US&rs=en-US&ad=US#run&PickTab=BYB>



### See also
 [Audit data and user activity for security and compliance](audit-data-user-activity.md)