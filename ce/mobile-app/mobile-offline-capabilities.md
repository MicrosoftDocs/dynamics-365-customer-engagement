---
title: "Mobile offline capabilities and limitations (Dynamics 365 apps)| MicrosoftDocs"
description: Mobile offline capabilities and limitations for Dynamics 365 phones and tablets app and Power Apps mobile
ms.custom: 
ms.date: 8/28/2020
ms.reviewer: kvivek
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 6828238b-1645-4710-a192-0014acb03196
caps.latest.revision: 1
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Sales
---

# Mobile offline capabilities and limitations

Before you set-up the mobile app in offline mode be sure to read through the following capabilities, tips,  and limitations. 

These entities and corresponding commands are available in offline mode.


|Entities |Commands|  
|-------------|---------|  
|Account|	Create, Read, Update, Delete|
|Activity Pointer|Read, Delete|
|Appointment|	Create, Read, Update, Delete, Convert Activity Case|
|Attachment	|Read only|
|Case|Create, Read, Update, Delete|
|Competitor|Create, Read, Update, Delete	|
|Competitor Address |Create, Read, Update, Delete	|
|Connection|Read only|
|Connection Role|Read only|
|Contact|Create, Read, Update, Delete	|
|Custom Entity|Create, Read, Update, Delete	|
|Email|Read only	|
|Lead|Create, Read, Update, Delete, Qualify/Disqualify	|
|Opportunity|Create, Read, Update, Delete|
|Opportunity Product|Create, Read, Update, Delete	|
|Phone Call|Create, Read, Update, Delete	|
|Position|Create, Read, Update, Delete	|
|Product|Read|
|Task |Create, Read, Update, Delete|
|Team |Read only	|
|User |Read only	|

## Supported  capabilities 
- **Business rules**: Business rules are supported in mobile offline. For more information, see Create business rules and recommendations to apply logic in a model-driven app form.

- **Business Process Flows**You can use business process flows in offline mode if the following conditions are met:

    - The business process flow is used in a app that that you can run on Power Apps mobile.
    - The Power Apps mobile app is enabled for offline use.
    - The business process flow has a single entity.
    
    There are three commands that are available for a business process flow when you run an app in offline mode on the Power Apps mobille app.
    - Next stage
    - Previous stage
    - Set Active stage

For more information, see [Run business process flows offline](https://docs.microsoft.com/power-automate/business-process-flows-overview#run-business-process-flows-offline).

- **Lookup support**: Lookups are supported for the entities that are mobile offline-enabled. All the entities participating in the lookup should also be offline-enabled.

- **Supported view**: Only System views and Quick view are supported in mobile offline. Personal views are not supported.

- **Offline search**: Available only for offline entities. User can only search one entity at a time. Only categorized search is supported in offline mode and not relevant search.

- **Notes on the Timeline control**: Notes on the Timeline control is available in offline mode. You can take pictures, read notes, and add/remove attachments in offline mode.
  > [!NOTE]
  > The **Date** field is not available for mobile offline search.
  
- **Custom entities**: These commands are available on edit the form, **Mark Complete**, **Refresh**, **Convert To- Opportunity**, and **Delete**.


## Limitations 

- **Business Process Flows**: Business process flows are not supported for mobile offline. When you are offline, business process flows grids and views will not be available and business process flows will not be rendered on records that are opened in offline mode. If a record containing a business process flow was loaded prior to going offline, business process flow functions, such as move next or move previous will not work. Business process flows support the ability to branch to a different set of stages, based on conditions defined on fields of the record. In offline mode, these conditions to determine the next set of stages in the business process flows will not be evaluated.

- **Qualify a lead**: When a lead created in mobile offline is qualified and when the user goes online, the business process stage will still show the  qualify stage. The user will have to manually click **Next stage** to move to the next stage.

- **Views** are not supported for the following entities in offline mode: 

     - Email

     - Task

     - Fax

     - Letter

     - Serviceappointment

     - Campaignresponse

     - Campaignactivity

     - Recurringappointmentmaster

     - Socialactivity

    Any views that have linked entities (related entity) that are not available offline are also not supported.

- **Add Existing on subgrids**: **Add Existing** is not supported for mobile offline for certain types of relationships. When you are offline, certain relationships such as relationships that are N:N are read only, and the **Add Existing** command will be hidden on subgrids for those relationships. Even if the button is unhidden via customization, the command will not work in offline.


## Tips

### Mobile offline synchronization
  
- Mobile offline synchronization with mobile devices occurs periodically. A synchronization cycle could last for several minutes, depending on Azure network latency, the volume of data that’s set for synchronization, and mobile network speed. Users can still use the mobile apps during synchronization.  
  
- The time for initial metadata download is determined by the number of total entities in offline-enabled app modules. Make sure to enable only those entities and app modules for offline that are necessary to optimize the experience for end users. 
  
- Ensure that any view that you want to work in offline doesn’t reference the entities that are not offline enabled. For example, assuming Account is in the offline profile, then an Account view that references the primary contact when Contact is not in the profile will not be available.

- Changes to a user’s security privileges are updated during the next synchronization cycle. Until that time, users can continue to access data according to their previous security privileges, but any changes they make will be validated during the synchronization to the server. If they no longer have privileges to make changes for a record, they will receive an error and the record won’t be created, updated, or deleted.

- Any changes to a user’s privilege to view a record won’t take effect on the mobile device until the next synchronization cycle.

- Mobile offline honors the mobile apps security model. It also supports the hierarchical security model. Field level security and attribute sharing are not supported for offline mode.
  

### Organization data filter 
It is recommended that you have at least one rule defined for all mobile offline enabled entity for org filters, if you are using the entities across profiles. By default, this value is set to last 10 days for most of the offline-enabled entities.

 > [!div class="mx-imgBorder"]
 >![Edit org data filter](media/datafilter_1.png "Edit org data filter")


### Profile filters 

**Profile limitations**

|Profile details |Limitation|  
|-------------|---------|  
|Relationship defined for each entity|Maximum of 10 relationships. And maximum of one many to many (M:M) or one to many (1:M) relationships within those 10 relationships. If any custom entities demand this scenario, then revisit the data model. No circular references or self-references are supported.|


### Profile filter rules recommendation 

Ensure that you have configured at least one of the Profile rules for each entity to download its data. 
  
|Customization |Recommendation|  
|-------------|---------|  
|All Records|	If you are selecting this filter, you cannot define any other filter rule.|
|Download Related Data only|If you are selecting this filter, you cannot define any other filter rule. Ensure that the entity has been defined as a Profile Item Association entity also.|
|Other Data Filter - if selected, then select at least one of these options: **Download my Records**, **Download my team records**, or **Download my business unit**  |	If you want to define this filter you have to pick at least one of the given options. It is highly recommended to not have Business Unit level filter for an entity unless there is a strong justification. It is recommended for a master data scenario with a small data set like Country codes. |
|Custom Data Filter |<=3 filters can be defined in the custom data filter. |




