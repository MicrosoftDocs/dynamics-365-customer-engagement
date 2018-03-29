---
title: "Comply Unified Service Desk Data under GDPR | MicrosoftDocs"
description: "Learn about data in Unified Service Desk that comes under General Data Protection Regulation (GDPR)"
ms.custom: ""
ms.date: 04/15/2018
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: FA8D5702-C698-42B0-89BF-CD444BF3FB73
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Comply [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] data under GDPR

With the data definitions and stages outlined in the GDPR, let us look at data contained in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and see how they relate.

- Audit Log Files
- Diagnostic Log Files
- Telemetry Data

## Audit log files

### Standard auditing by using an Audit & Diagnostic record

If you configure standard or custom auditing using an Audit & Diagnostics record, you can write a custom listener to send the log to files. The audit data log files are present in your local computer, or you can configure a path to store the file in your local computer or another computer in the network. 

A custom listener lets you send the log output to files, the event log, or other sources.

To delete audit logging that you configure using Audit & Diagnostic record by writing a standard or custom listener, perform the following:

1. Navigate to the location where you store the audit data log files.
2. Select the files that you want to delete, and press **Delete**.

### Standard auditing by adding an audit flag

If you configure the audit logging using standard auditing by adding an audit flag, the
events and logs are present in the **UII_auditBase** table in the organization database.

To delete audit logging that you configure using standard auditing by adding an audit flag, perform the following:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].
2. Click **Advanced Find** from a productivity area.</br>
  ![Click Advanced Find](../../unified-service-desk/media/advance-find-usd-gdpr-crm-server.PNG "Click Advanced Find")
3. Select **UII Audit** in the **Look for** list.</br>
  ![Click UII Audit option](../../unified-service-desk/media/look-usd-gdpr-crm-server.PNG "Click UII Audit option")
4. Click **Results** to see all audit logging details.</br>
  ![Click on Results option](../../unified-service-desk/media/results-usd-gdpr-crm-server.PNG "Click on Results option")
5. Select the records that you want to delete.</br>
  ![Select records to delete](../../unified-service-desk/media/select-records-usd-gdpr-crm-server.PNG "Select records to delete")
6. Click **Delete UII Audit** option to delete the records.</br>
  ![Click Delete UII Audit option](../../unified-service-desk/media/delete-records-uii-audit-usd-gdpr-crm-server.PNG "Click Delete UII Audit option")

## Diagnostic log files

The diagnostic logging records operational events and errors in the client application. UTF-8 encoded text files that are named UnifiedServiceDesk-<date>.log are maintained at the following location on the client computer:

`c:\Users\<UserName>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<Version>`

To delete diagnostic logging, perform the following:

1. Go to the default or configured folder path where you store the diagnostic log files.
Default folder path – </br>
`c:\Users\<UserName>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<Version>`
2. Select the **UnifiedServiceDesk-<date>.log** file and delete.

## Telemetry data

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application collects telemetry data that is maintained in Microsoft Dynamics 365. In these cases, the natural or legal person, public authority, agency or other body which, alone or jointly with others becomes the controller, and the processor is Microsoft which processes the data on behalf of the controller.

The category of telemetry that are [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] collects are as follows:

- Action call results data
- Start-up performance data
- Error & Exit Code data
- Feedback
- Freeze/Performance data
- Session start and end data

## See also

[Comply with General Data Protection Regulation (GDPR)](comply-gdpr.md)
