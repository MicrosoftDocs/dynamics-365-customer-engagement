---
title: "Auditing overview (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Overview of the audit capabilities, supported on all custom and most customizable entities and attributes, but not supported on metadata changes, retrieve operations, export operations, or during authentication."
ms.custom: audit
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: c3e00bf9-d973-4cf6-9527-1c12cef8a949
caps.latest.revision: 36
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Auditing overview

Organizations often need to be in compliance with various regulations to ensure availability of customer interaction history, audit logs, access reports, and security incident tracking reports. Organizations may want to track changes in Dynamics 365 Customer Engagement (on-premises) data for security and analytical purpose.  
  
 Dynamics 365 Customer Engagement (on-premises) support an auditing capability where entity and attribute data changes within an organization can be recorded over time for use in analysis and reporting purposes. Auditing is supported on all custom and most customizable entities and attributes. Auditing is not supported on metadata changes, retrieve operations, export operations, or during authentication. For information on how to configure auditing, see [Configure Entities and Attributes for Auditing](configure-entities-attributes-auditing.md).  
  
## Supported for auditing  
 The following lists auditing capabilities for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]:  
<!-- TODO: Jim, I don't think this is online only. Please correct the tokens here. -->
  
* Audit of customizable entities
* Audit of custom entities
* Configure entities for audit
* Configure attributes for audit
* Privilege-based audit trail viewing
* Privilege-based audit summary viewing
* Audit log deletion for a partitioned SQL database  
* Audit log deletion for a non-partitioned SQL database 
* Audit of record create, update, and delete operations
* Audit of relationships (1:N, N:N) 
* Audit of audit events
* Audit of user access
* Adherence to regulatory standards
* Auditing APIs for developers
  
## Not supported for auditing  
 The following lists what cannot be audited for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]:  
  
* Audit of read operations
* Audit of metadata changes 
  
## Key concepts  
 The following bullets identify some key auditing concepts:  
  
- You can enable or disable auditing at the organization, entity, and attribute levels. If auditing is not enabled at the organization level, auditing of entities and attributes, even if it is enabled, does not occur. By default, auditing is enabled on all auditable entity attributes, but is disabled at the entity and organization level.  
  
- For [!INCLUDE[pn-crmop-edition](../includes/pn-crm-onprem.md)] servers that use [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] Enterprise editions, auditing data is recorded over time (quarterly) in *partitions*. A partition is called an *audit log* in the Dynamics 365 Customer Engagement (on-premises) web application. Partitions are not supported, and therefore, not used, on a [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] server that is running [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)], Standard edition.  
  
- The ability to retrieve and display the audit history is restricted to users who have certain security privileges: View Audit History, and View Audit Summary. There are also privileges specific to partitions: View Audit Partitions, and Delete Audit Partitions. See the specific message request documentation for information about the required privileges for each message.  
  
- Audited data changes are stored in records of the **audit** entity.  
  
## Data that can be audited  
 The following list identifies the data and operations that can be audited:  
  
- Create, update, and delete operations on records.  
  
- Changes to the shared privileges of a record.  
  
- N:N association or disassociation of records.  
  
- Changes to security roles.  
  
- Audit changes at the entity, attribute, and organization level. For example, enabling audit on an entity.  
  
- Deletion of audit logs.  
  
- When (date/time) a user accesses Dynamics 365 Customer Engagement (on-premises) data, for how long, and from what client.  
  
  Enabling or disabling of field level security by setting the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.IsSecured> attribute cannot be audited.  
  
### See also
 [Data Management in Dynamics 365 Customer Engagement (on-premises)](manage-data.md)   
 [Audit entity data changes](audit-entity-data-changes.md)   
 [Configure entities and attributes for auditing](configure-entities-attributes-auditing.md)       
 [Blog: Recover your deleted CRM data and recreate them using CRM API](https://blogs.msdn.com/b/crm/archive/2011/05/23/recover-your-deleted-crm-data-and-recreate-them-using-crm-api.aspx)
