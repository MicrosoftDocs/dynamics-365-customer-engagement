---
title: "Marketing Approvals feature(Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Sample approvals feature which utilizes Dynamics 365 for Marketing extensibility endpoints"
ms.custom: 
  - dyn365-developer
  - dyn365-marketing
ms.date: 08/01/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - marketing
ms.topic: conceptual
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: cfaee020-a29d-4297-8f73-e8fb378843dc
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Approvals

Dynamics 365 for Marketing released new extensibility features to extend entities covered by a lifecycle to give users the possibility to override or use the default logic. Following are some of the functions:

- **MsDynCrmMkt.ExtensibilityCallback.liveEditablePreAction**: this function is used to introduce the code that executes before an entity enters the **live editable** state.
- **MsDynCrmMkt.ExtensibilityCallback.customUpdateFormControls**: this function is triggered when the main form of the entity executes. This gives the possibility to unlock all the controls of the page and make them editable.
- **MsDynCrmMkt.ExtensibilityCallback.canGoLive**: this function gives the ability to completely override the logic to show or hide the **Go live** ribbon.
- **MsDynCrmMkt.ExtensibilityCallback.preventSave**: this function allows to control the save behavior of the entity.
- **MsDynCrmMkt.ExtensibilitySupplier.entityValidator**: this function is returning a validator factory. Once correctly initialized can be used to verify that the configuration of the specific entity is valid. 

Another flexibility introduced for entities with complex lifecycle stage (marketing email, customer journey, content settings, marketing page, marketing form, and segment) is the possibility to configure the lifecycle of an entity. The user can add new states and can change the flow for existing entities. The only limitations are: 

1. New states between transient state (going live and stopping) and fix stage is ignored.
2. If you try to enter directly to live stage without passing through going live, you have to make sure that the entity value are not changed (otherwise what you will see in the UI it will be different of what is running in in the backend).
3. Don't remove any of the existing states. This approach should be adopt for any customizations.
4. Once an entity enters into an inactive state, it cannot be activated.

## Sample approvals

This sample shows how to implement the above mentioned functions by implementing a simple approval scenario for the customer journey. This sample approval example covers the following scenario where a user creates a customer journey record (i.e., in Draft state) and asks for the approval from the manager to publish the record. The manager rejects the approval request and asks for some changes. In this case, the entity goes back to the **Draft** state, and the changes made by the users are kept. 

The user can continue to work on this entity to implement the requested changes and submits a new approval request. This time manager accepts the approval request, and the customer journey record is pushed to **Live** state. 

Again the user makes some changes to the **Live** record and asks for approval. However, manager rejects the request, and the changes made by the user will be reverted as the entities can enter into **Live** state either from *8Going live** state or if they don't have any changes.

## Implementation

### Step 1: Create a new solution

- Create a new [solution](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/customize/create-solution) and name it as **Sample Approval**.
- Add customer journey entity to the solution.
- Add the following new states to the **Statuscode** attribute:
   - Approved
   - Need approval
- Create the following two new fields:
   - msdyncrm_serializedentity of data type **Single line of text**- This field is used to store the serialized entity.
   - msdyncrm_restorestatuscode of data type **Integer** - This field is used to store the previous state information.

### Step 2: Create ribbon buttons

In this step, we will create three ribbon buttons **Approve**, **Reject**, and **Ask approval**. 

### Step 3: Create a web resource


## Integrate with Microsoft Flow

Microsoft Flow has a connector for approvals that we can reuse. To do so, we create a new flow inside the **Sample approval** solution (in this way, we can export and reuse the solution). To achieve the scenario above, we need to follow the steps below: 

1. Trigger the new flow when a customer journey is updated, in particular when the **statuscode=need approval**. 
2. If the status code is equal to need approval, then we want to go ahead with our flow
3. To configure in a more generic way the next steps, create two new fields inside the customer journey.
   - **msdyncrm_organizationurl** that contains the URL of the organization.
   - **msdyncrm_approvers** that contains the email address of the manager.
4. Create a plugin that fills these new fields on the retrieve of the entity.
5. We can use the default approval connector to notify the approvers that a new customer journey needs, to be checked. Based on the response, we can change the **statuscode** value of the entity (restore the initial value or go to the approved stage).

