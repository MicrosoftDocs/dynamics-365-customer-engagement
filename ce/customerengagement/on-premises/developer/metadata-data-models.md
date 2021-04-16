---
title: "Metadata and data models (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Dynamics 365 Customer Engagement (on-premises) uses a metadata driven architecture to provide the flexibility to create custom entities and additional system entity attributes. This structure also makes upgrades and the transportation of customizations easier. The data structure can change without requiring any change to code in the Dynamics 365 Server or client applications."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 89780be5-e5f7-4fa8-9565-3442eda5708d
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---

# Metadata and data models

Dynamics 365 Customer Engagement (on-premises) uses a metadata driven architecture to provide the flexibility to create custom entities and additional system entity attributes. This structure also makes upgrades and the transportation of customizations easier. The data structure can change without requiring any change to code in the Dynamics 365 Server or client applications.  

 All the information necessary for Dynamics 365 Server to operate is stored in the Dynamics 365 Customer Engagement (on-premises) metadata. This includes information about entities, attributes, relationships, and option sets.  

 The Dynamics 365 Customer Engagement (on-premises) Web services contain the messages that you use to read or write the definitions for all the entities each organization. It can also be used to build a client-side metadata cache, which is useful for applications that access the metadata frequently. For example, you may want to create a custom search solution that supports all entities, even those created after the solution has been installed.  

 A very important role of the metadata is to provide the framework to deliver a fully metadata driven user interface. The entity metadata controls the grid and form layout, and how navigation options are presented.  

 When you create a custom entity, the information in the attributes and relationships are used to create the appropriate user interface for that entity. In addition, this supports multiple languages in the user interface so that one user may see labels and other text in a different language from another user. These languages and the associated labels are stored in the metadata. The language edition of Dynamics 365 Server that is installed for an organization is considered its base language. You then install Multilingual User Interface (MUI) language packs for additional languages as they are needed.  

 To read more about metadata and how to find metadata reports, see [Entity Metadata](introduction-entities.md#bkmk_EntityMetadata).  

 The following table lists the objects described by the metadata.  


| Metadata object |                                                                                                                                                                           Description                                                                                                                                                                            |
|-----------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|     Entity      | An entity is a container for data, similar to a table in a traditional database. Each entity contains a set of attributes. For Dynamics 365 Customer Engagement (on-premises), there are a set of entities that exist when you first install. Some of these are customizable. In addition, you can create custom entities to contain business data. |
|    Attribute    |                                                                                              An attribute is a container for a piece of data in an entity. Dynamics 365 Customer Engagement (on-premises) supports a wide variety of attribute types.                                                                                               |
|  Relationship   |                                                                                                                    A relationship defines an association between two entities: one-to-many, many-to-one, many-to-many, and self-referential.                                                                                                                     |
|   Option Set    |                                                                       An option set defines a set of options provided for a picklist. Several picklist attributes may use a global option set so that the options they provide are always the same and can be maintained in one location.                                                                        |
|     Option      |                                                                                                  An option is one of the values available in an option set. Each option in an option set has a unique integer value and an associated set of localized labels.                                                                                                   |

### See also  
 [Extend Dynamics 365 Customer Engagement (on-premises)](extend-dynamics-365-server.md)   
 [Supported Extensions for Dynamics 365 Customer Engagement (on-premises)](supported-extensions.md)   
 [Browse the Metadata for Your Organization](browse-your-metadata.md)  
 [Customize entity attribute metadata](customize-entity-attribute-metadata.md)  
 [Create auto-number attributes](create-auto-number-attributes.md)  
 [Customize entity relationship metadata](customize-entity-relationship-metadata.md)  
 [Use the Web API with metadata](webapi/use-web-api-metadata.md)   
 [Use the Organization service with Dynamics 365 Customer Engagement (on-premises) metadata](org-service/use-organization-service-metadata.md)   
 [Extend Dynamics 365 Customer Engagement (on-premises) on the server](extend-dynamics-365-server.md)   
 [Extend Dynamics 365 Customer Engagement (on-premises) on the client](extend-client.md)   
 [Customize Dynamics 365 Customer Engagement applications](customize-dev/customize-applications.md)   
 [Package and distribute extensions using solutions](package-distribute-extensions-use-solutions.md)   
 [Extend Dynamics 365 for Outlook](extend-customer-engagement-outlook.md)   
 [Integrate Dynamics 365 Customer Engagement (on-premises) with SharePoint](integrate-sharepoint.md)   
 [Integrate Dynamics 365 Customer Engagement (on-premises) with OneNote](integration-dev/integrate-onenote.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]