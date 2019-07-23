---
title: "Approvals| Microsoft Docs" 
description: 
ms.custom:
ms.date: 07/30/2019
ms.reviewer: ""
ms.service: "D365CE"
ms.topic: "article"
author: "nkrb" # GitHub ID
ms.author: "nabuthuk" # MSFT alias of Microsoft employees only
manager: "kvivek" # MSFT alias of manager or PM counterpart
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---

# Approvals

Dynamics 365 for Marketing app introduces some extensibility points in the entities covered by a lifecycle to give the users, the possibility to override the default logic and implement their custom logic. Following are the some of the functions:

- **MsDynCrmMkt.ExtensibilityCallback.liveEditablePreAction**: this function can be used to introduce code that will be execute before an entity enters the live editable stage.
- **MsDynCrmMkt.ExtensibilityCallback.customUpdateFormControls**: this function is executed once the main form of the entity is executed. This gives the possibility to unlock all the controls of the page and make them editable.
- **MsDynCrmMkt.ExtensibilityCallback.canGoLive**: this function permits to completely override the logic to show/hide the “go live” ribbon.
- **MsDynCrmMkt.ExtensibilityCallback.preventSave**: this function allows to control the save behavior of the entity.
- **MsDynCrmMkt.ExtensibilitySupplier.entityValidator**: this function is returning a validator factory. Once correctly initialized can be used to verify that the configuration of the specific entity is valid. 

You can configure the lifecycle of an entity with complex lifecycle (marketing email, customer journey, content settings, marketing page, marketing form and segments). You can add new stages and can also change the flow for the existing entities.The only limitations are: 

1. New stages between transient state (going live and stopping) and fix stage will be ignored
2. If you try to enter directly to live stage without passing through going live, you have to make sure that the entity value are not changed otherwise what you will see in the UI it will be different of what is running in in the backend.
3. We also ask to not remove any of the existing stages but to add new one and to hide the one that are not need it. This approach should be adopted for any kind of customization
4. Once an entity enters into inactive state it cannot be activated.

## Example

This example shows how to implement a simple approvals scenario using the above mentioned functions. In this example, we will check that no customer journey record is moved to **Go live** state without the approval. 

Suppose that Bob (Marketer) asks for the approval for publishing a new customer journey (i.e., from **Draft** state) and that Alice (Approver) rejects this request because she is not satisfied with the  marketing campaign and asks for some changes. In this case, the entity goes back to **Draft** state and the changes made by the marketer stays as is. Marketer can continue to work on this entity to implement the requested changes and can submit a new request for approval. This time Alice accepts the approval and the campaign can start.

After the campaign has started (i.e. is in **Live** state), marketer decides to make some changes to it and asks for approval, however approver decides to keep the customer journey as is and rejects the request. In this case marketer changes will be reverted since entities can enter in **live** state either from **Going Live** (for which an approval is needed) or if they don’t have any changes with respect to the original stage. 

### Implementation

Since in Dynamics 365 for Marketing app, different roles are based on the security privileges, create a custom entity **msdyncrm_approval**, and defined **approvers** all the system users with write privilege on this entity. We will define **marketers** all the system users that are not approver.
To have a list of all the approver of the system we can customize **SystemUser** entity and add a new saved query as follow:

In our example we want to introduce 2 new stages: 

- Need approval: the entity is ready to be reviewed. The marketer cannot edit this entity.
- Approved: the entity is approved, so both approver and marketer can start the campaign.
 
To achieve this, we suggest to create a new solution, that in our example we will call Sample Approval, and add the customer journey entity to it. At this point we will be able to edit **statuscode** field and add the new stages. We also need to remember to edit the stage mapping as well. 

We want also to add 2 extra fields to the entity: 

- msdyncrm_serializedentity of type ntext:  this field will be used to store the serialized entity 
- msdyncrm_restorestatuscode of type int: this field will be used to remember the previous stage so, for example if we move from “draft” to “need approval” we will have statuscode = “need approval” and restorestatuscode = “draft”
To simplify Alice life we want to add 2 new system view in customer journey to show all the entities that need an approvals and all the entities that are already approved and are waiting to go live

We want also to introduce 3 new ribbons to approve, reject and ask approval. The Command of these ribbon can be implemented as in the picture below. 
We can define 5 new enable rule:
•	Need Approve: it will check that the entity is in draft/error/stop or live editable stage
•	Can approve/can reject: it will check that the entity is in need approval or approved stage
•	I am not admin: check that the current user is not an approver
•	I am admin: check that the current user is an approver


Now that we add the new stages, we want to utilize the function mention above to change customer journey behavior. As first think we will add 4 new events on load of the entity named as the hook mention above.
Now we are going to analyze in more details these new functions:
•	MsDynCrmMkt.ExtensibilityCallback.liveEditablePreAction: we want to use this function to store the serialized customer journey in msdyncrm_serializedentity field. We need to perform this action only if we are in “live editable” stage since the only scenario that we need to support is the reject from a request of change start from live editable stage.
 
The serializer will just retrieve all the attribute of the entity and serialized them. Of course we don’t want to serialize the serializer again and the status code.

•	MsDynCrmMkt.ExtensibilityCallback.customUpdateFormControls: we want to use this function to introduce our own logic to enable or disable the fields. For example, we can initialize a new field controller that will look like as in the example below

•	MsDynCrmMkt.ExtensibilityCallback.canGoLive: we will use this function to hide “go live” ribbon for the marketer. Since this function, if defined, will completely override the base logic we will also need to assure to show the ribbon just in particular stages for the approvers
•	MsDynCrmMkt.ExtensibilityCallback.preventSave: every time a customer journey is save in live editable stage the entity get republish or come back to live stage if there are no changes. Since it is always possible to save an entity using the save button in the right-bottom corner we can use this function to prevent the marketer to save the entity. This measure will not guarantee the security of the solution (see security section for more details).

In our web resources we want also to implement the logic to control ribbon actions. 
•	askApprovals: this function should move the entity in “needs approval” stage and store the previous stage in msdyncrm_restorestatuscode field
•	restoreStatusCode: it will set the status code with the value stored in msdyncrm_restorestatuscode field
•	approve: will move the entity in “approved” stage
Plugins changes
We decide to implement the only missing part of our solution at plugin level to simplify the integration with Microsoft flow. We want to create a plugin that restore the entity value in case the entity gets rejected and msdyncrm_restorestatuscode field was “live editable”. The concept is really simple, but we need to put particular attention to the data typing. The type of the data can be determined retrieving the metadata of the entity as in the sample below. 

Security
The flow described above is based on trust. Every marketer, utilizing the inspector, can easily skip the validation steps introduced above. To enforce the validation, we suggest to introduce a plugin.
 This plugin must assure that:
•	No transition, performed by a marketer, can enter in “go live” stage if the status code of the preimage is different of “approved”
•	The only operation that a marketer can perform in approve stage is the change of status. 

Integration with Microsoft Flow
Microsoft Flow is providing a connector for approvals that we can reuse. To do so we need to create a new flow inside our “Sample approval” solution (in this way we would be able to export and reuse). 

Once we create a new flow, we can cover a simple scenario as in the example below. 
1.	We want to trigger our flow when a customer journey is updated, in particular when the statuscode is equal to need approval 
2.	If the status code is equal to need approval, then we want to go ahead with our flow
3.	To configure in a more generic way the next steps, we can create 2 new compound field inside our customer journey: msdyncrm_organizationurl that we will contain the URL of our organization and msdyncrm_approvers that will contain all the email address of our  approvers. 
We will also need to create a plugin that will fill these new fields on the retrieve of the entity.
4.	We can use the default approval connector to notify the approvers that a new customer journey needs, to be checked
5.	Based on the response, we can now change the status code of the entity (restore the initial value or go to approved stage)

