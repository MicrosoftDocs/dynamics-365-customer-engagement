---
title: "Types of entities | MicrosoftDocs"
description: "Understand the different types of entities"
ms.custom: 
ms.date: 01/10/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 2f3f6053-0b9e-41e7-bd94-2239351e9f4b
caps.latest.revision: 41
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Types of entities

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Types of tables](/powerapps/maker/data-platform/types-of-entities)

<a name="BKMK_TypesOfEntities"></a>   

 Before creating or editing entities, you should understand that there are different types of entities. Once a custom entity is created, these types cannot be changed. The two major divisions are based on entity ownership and whether the entities are activity entities.  
  
<a name="BKMK_EntityOwnership"></a>   
## Entity ownership  
 There are four different types of entity ownership. When you create a custom entity the only options are **user or team owned** or **organization-owned**, but you should be aware that other entities have different ownership types.  
  
|Ownership|Description|  
|---------------|-----------------|  
|**Business-owned**|There are several business-owned system entities. These include Business Unit, Calendar, Team, Security Role, and User.|  
|**None**|There are many system entities that don’t have an owner, but most of these aren’t visible in the solution explorer. These mostly consist of intersect entities created to support Many-to-Many relationships or where access to the record is controlled by a parent record. For example, Opportunity Product records must be accessed through a user or team owned Opportunity record.|  
|**Organization-owned**|There are organization-owned system entities. These include Article, Article Template, Competitor, Currency, and Web Resource.|  
|**User or Team Owned**|There are user or team owned system entities. Because these records are owned by a user or team, they’re connected to a business unit and specific security roles for the business unit. Therefore, these entities participate in role-based security.|  
  
 The custom entities that you create, and most customizable system entities, are either **organization-owned** or **user or team owned**.  
  
> [!IMPORTANT]
>  After an entity is created, you can’t change the ownership. Before you create an entity, make sure that you choose the correct type of ownership. If you later determine that your custom entity must be of a different type, you have to delete it and create a new one. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Delete custom entities](../customize/delete-custom-entities.md)  
  
<a name="BKMK_ActivityEntities"></a>   
## Activity entities  
 An activity can be thought of as any action for which an entry can be made on a calendar. An activity has time dimensions (start time, stop time, due date, and duration) that help determine when the action occurred or will occur. Activities also contain data that helps determine what action the activity represents, for example, subject and description. An activity can be opened, canceled, or completed. The completed status of an activity will have several sub-status values associated with it to clarify the way that the activity was completed.  
  
 Activity entities can only be owned by a user or team, they can’t be owned by an organization.  
  
 There are several system entities that represent activities as shown in the following table.  
  
|Name|Description|Display in activity menus|  
|----------|-----------------|-------------------------------|  
|**Appointment**|Commitment representing a time interval with start/end times and duration.|Yes|  
|**Campaign Response**|Response from an existing or a potential new customer for a campaign.|Yes|  
|**Email**|Activity that is delivered using email protocols.|Yes|  
|**Fax**|Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.|Yes|  
|**Letter**|Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.|Yes|  
|**Phone Call**|Activity to track a telephone call.|Yes|  
|**Recurring Appointment**|The master appointment of a recurring appointment series.|Yes|  
|**Service Activity**|Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.|Yes|  
|**Task**|Generic activity representing work needed to be done.|Yes|  
|**Campaign Activity**|Task performed, or to be performed, by a user for planning or running a campaign.|No|  
|**Case Resolution**|Special type of activity that includes description of the resolution, billing status, and the duration of the case.|No|  
|**Opportunity Close**|Activity created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.|No|  
|**Order Close**|Activity generated automatically when an order is closed.|No|  
|**Quick Campaign**|System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.|No|  
|**Quote Close**|Activity generated when a quote is closed.|No|  
  
 You can create new custom activity entities. For example you might create a custom activity entity to record instant message communications. Creating an activity entity is different from creating a non-activity entity because you don’t specify a primary field. All activity entities have a **Primary Field** set to **Subject** and other common fields that are defined by the Activity entity. This allows all types of activities to be shown in a view where just the common fields are displayed.  
  
 To create a custom activity entity, select **Define as an activity entity**. After you select this, you’ll see that **Display in Activity Menus** is selected. This setting allows people to create this type of activity in the activity menus. This isn’t selected for activities that are typically associated with specific events and created behind using code or by a workflow. After you save the entity, you can’t change these settings.  

### See also
[Create or edit entities](create-edit-entities.md)
