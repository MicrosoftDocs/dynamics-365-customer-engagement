---
title: "Connection entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Connection entities help you enable, create, and query connections."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - creating graphs and charts to visually represent connections
  - connection entities, using to create connections
  - connecting two records
  - creating multiple connections and roles for records
  - querying connections for data
  - connections, definition
  - enabling connections, connection entities
  - creating connection roles between records
  - associating entity records, connection entities
ms.assetid: 98700871-a986-4982-900e-5fd5f6ee5a26
caps.latest.revision: 37
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Connection entities

The *connections* provide a flexible way to connect and describe the relationships between any two entity records [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. It helps you to promote teamwork, collaboration, and effective management of business and sales processes. Connections enable you to easily associate users, contacts, quotes, sales orders, and many other entity records with each other. The records in the association can be assigned particular roles that help define the purpose of the relationship.  
  
 Connections provide the following capabilities:  
  
- An easy and flexible way to make a connection between two records of most [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] entity types. All customizable business and custom entities can be enabled for connections.  
  
- An option to add useful information, such as a description of the connection and the duration.  
  
- The ability to create connection roles that describe the relationship between two records, such as a relationship between a doctor and a patient, or a manager and an employee.  
  
- A quick way to create multiple connections and roles for a particular record. For example, a contact may have many relationships with other contacts, accounts, or contracts. In each relationship a contact may play a different role.  
  
- Information for building queries and creating graphs. You can search for all connections and connection roles for a particular record and create graphs and charts for visual representation of the connections.  
  
- Support for workflows and auditing for automating and improving business processes.  
  
## Enabling and creating connections  
 You can enable any custom or customizable entity for connection by updating the entity metadata. Use the <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest> message to set the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsConnectionsEnabled> property to `true`.  
  
 To create a connection between two records, use the `Connection` entity. You must specify a record from which you create a connection (source) and a record to which you connect (target). Use the `Connection.Record1Id` attribute to specify the source entity record and the `Connection.Record2Id` attribute to specify the target entity record. Optionally, you can specify the duration of the connection and the description. To describe the relationship between the participants in the connection, use the connection roles. To specify the connection roles, use the `Connection.Record1RoleId` attribute and the `Connection.Record2RoleId` attribute.  
  
## Querying connections  
 Querying connections gives you valuable data that you can use to create reports, graphs, or charts. You can query connections by an entity record, by an entity type (Entity Type Code), by a particular role, or other criteria. The following are examples of how you can query connections:  
  
 By an entity record:  
  
- Show all connections for account A.  
  
- Show all roles for account A.  
  
  By an entity type (using Entity Type Codes):  
  
- Show all roles for the competitor entity.  
  
- Find the total number of roles for the account entity.  
  
  By a role:  
  
- Find all connections where account A is a “Vendor”.  
  
- Find all open opportunities over $20,000, where contact B is a “Salesperson”.  
  
- Find all matching roles for a “Doctor” role, such as “Patient”, “Nurse”, or “Medical Assistant”.  
  
- Find all contacts that have the role “Friend”.  
  
> [!IMPORTANT]
>  When you create a connection entity record, two records are created in the database. The first record represents a source to target connection and the second record represents a target to source connection. This guarantees that a query will find all connections that the record participates in, regardless whether the record is a source record or a target record in the connection.  
  
### See also  
 [Describe a Relationship Between Entities with Connection Roles](describe-relationship-entities-connection-roles.md)   
 [Connection Entity](entities/connection.md)   
 [ConnectionRole Entity](entities/connectionrole.md)   
 [Sample Code for Connection Entities](sample-code-connection-entities.md)   
 [Business Management Entities](business-management-entities.md)   
 [View and Analyze Data with Visualizations and Dashboards in Dynamics 365 Customer Engagement (on-premises)](customize-dev/customize-visualizations-dashboards.md)   
 [Fiscal Calendar and Territory Entities](fiscal-calendar-and-territory-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]