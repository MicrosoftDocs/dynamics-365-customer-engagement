---
title: "Mobile offline capabilities and limitations (Dynamics 365 apps)| MicrosoftDocs"
ms.custom: 
ms.date: 6/17/2020
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

for the previous organization that you were logged into, then you will need to sign back into that organization and use the **Reconfigure** option to delete all data and metadata from the cache. 


## Capabilities available in offline mode




**Add Existing on subgrids**: **Add Existing** is not supported for mobile offline for certain types of relationships. When you are offline, certain relationships such as relationships that are N:N are read only, and the **Add Existing** command will be hidden on subgrids for those relationships. Even if the button is unhidden via customization, the command will not work in offline.

**Business rules**: Business rules are supported in mobile offline. For more information, see [Create business rules and recommendations to apply logic in a model-driven app form](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-business-rules-recommendations-apply-logic-form).

**Lookup support**: Lookups are supported for the entities that are mobile offline-enabled. All the entities participating in the lookup should also be offline-enabled.

**Offline views**: Only system views are supported in mobile offline. 

**Quick views**: Quick views are available in offline mode.

**Offline search**: Available only for offline entities. User can only search one entity at a time. Only categorized search is supported in offline mode and not relevant search.

**Notes on the Timeline control**: Notes on the Timeline control is available in offline mode. You can take pictures, read notes, and add attachments in offline mode.



> [!NOTE]
> The **Date** field is not available for mobile offline search.
   
**Security modeling**: Mobile offline honors the Dynamics 365 apps security model. It also supports the hierarchical security model.


Field level security and attribute sharing are not supported for offline mode.

If a user was working on a record and lost network connection, any updates made to the record are saved in offline mode and will be synchronized to Dynamics 365 app once the user is back online. When the record is synchronized with the app, it follows the filter rule for availability in offline mode.

> [!NOTE]
> - Actions from offline mode are replayed automatically. The changes are played back in the same sequence as they were created, modified, or deleted. This ensures that the data state is maintained and there are no data mismatches on the Dynamics 365 apps.
> - The org can enhance business functionality available in mobile offline using Xrm.Mobile.offline. For more information, see Xrm.Mobile.offline (client-side reference).

## Known Issues

**Business Process Flows**: Business process flows are not supported for mobile offline. When you are offline, business process flows grids and views will not be available and business process flows will not be rendered on records that are opened in offline mode. If a record containing a business process flow was loaded prior to going offline, business process flow functions, such as move next or move previous will not work. Business process flows support the ability to branch to a different set of stages, based on conditions defined on fields of the record. In offline mode, these conditions to determine the next set of stages in the business process flows will not be evaluated.

**Qualify a lead**: When a lead created in mobile offline is qualified and when the user goes online, the business process stage will still show the  qualify stage. The user will have to manually click **Next stage** to move to the next stage.

**Views** are not supported for the following entities in offline mode: 

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

