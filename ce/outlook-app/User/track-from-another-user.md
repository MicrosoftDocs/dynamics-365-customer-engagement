---
title: "Track appointments from another person in your organization (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: Track appointments from another person in your organization.
ms.date: 04/22/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
caps.latest.revision: 9
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Track appointments from another person in your organization

You can track appointments from another person's Dynamics 365 app using Dynamics 365 App for Outlook. To enable this capability, you need to enable the OrgDBOrgSetting in your organization. Dynamics 365 apps provides the OrgDBOrgSettings tool that gives administrators the ability to implement specific updates that were previously reserved for registry implementations.

1. Follow the instructions [in this article](https://support.microsoft.com/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm) for steps to extract the tool.
2. After extracting the tool, enable the *OrgDBOrgSetting TrackAppointmentsFromNonOrganizer*.

You can also use [this tool](https://github.com/seanmcne/OrgDbOrgSettings/releases/) to edit the *OrgDBOrgSetting TrackAppointmentsFromNonOrganizer*.

After the *OrgDBOrgSetting* is enabled, when you open Dynamics 365 App for Outlook on an appointment created by another user in your organization, you can track the appointment. You will no longer see the banner blocking you from tracking the calendar item.

 ![Track appointments](../media/Trackappointments.png "Track appointments ")

