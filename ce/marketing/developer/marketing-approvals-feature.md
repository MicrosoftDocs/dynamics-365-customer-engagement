---
title: "Build an approvals feature(Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Build an approvals feature which utilizes Dynamics 365 for Marketing extensibility endpoints"
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
ms.assetid: 488e6a2f-81c8-41da-ad4d-bf349abcc468
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Build an approvals feature

Dynamics 365 for Marketing offers extensibility features that make it possible for developers to build on its functionality.

Approvals are an often-requested feature that enables organizations to implement an approval workflow in which most users can't go live right away with some types of important entities (such as emails, customer journeys, or segments). Instead, an approver user must inspect each record and decide whether to allow it to go live, or whether more work is needed first. The approver user is typically an administrator or manager who is specifically identified as an approver in the system.

> [!IMPORTANT]
> The approval feature described here is intended to support a collaborative workflow among colleagues, and will help prevent accidentally going live with an entity that is not yet ready. It provides greatly improved control over what gets published but doesn't provide bulletproof security. Expert users of Dynamics 365 for Customer Engagement with suitable permissions may be able to work around the approval workflow by accessing the system-customization features directly, so admins must take care when granting advanced permissions to users. 

## Prerequisites

1. Download the [code]() for sample webresource and ribbon customizations.
2. Sign up or install [Dynamics 365 for Marketing](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/trial-signup) app. Make sure you are installing the latest version of the app
3. License for [Microsoft Flow](https://flow.microsoft.com/en-us/) to create sample approvals feature


## Approval process

The customizations outlined in this topic will help you design and implement an approval workflow that works something like this:

1. Standard users (non-approvers that we will call Marketer) no longer see a Go live button on entity forms where approvals are enabled. Instead, this is replaced by a Request approval button on the command bar. These entities use a custom collection of Status reason values, which are used to track the approval status of each record. Records requiring approval begin with a Status reason of Approval required.
1. When a standard user has finished creating a new record (such as an email design), they select the Send for approval button. This triggers the following changes:
   - The Status reason for this record changes to Approval requested.
   - The record is locked to further changes.
	 - An email message is automatically sent to the approver user configured in the system. This message tells the approver that his or her approval is required. It also includes buttons for approving or rejecting right from the message, plus a link to view the relevant record in the Marketing app (where approve and reject buttons are also provided).
   - For standard users, the Request approval button is replaced with a Cancel approval button. If a user selects Cancel approval, the record returns to the Approval required status and becomes unlocked for editing again.
   - For the approver user, Approve and Reject buttons are now provided on the command bar. 
1. The approver responds by doing one of the following:
   - Approve: The record changes its Status reason to Approved. The Go live button is also made available to all users for this record. Any user can now go live with the record provided no edits are made. If a user edits and approved record, the Go live button is once again replaced with a Request approval button and the Status reason is changed to Approval required.
   - Reject: The record changes its Status reason to Rejected. The Request approval button is added once again to the command bar. The user can now make changes and then send for approval again.
1. This process is repeated until the record is approved and live.

## Extensibility functions to support approvals

The following functions are added inside Marketing solution (from August release) and can be used to override or use the default logic for entities with complex lifecycle (marketing email, customer journey, content settings, marketing page, marketing form, and segment):

|Name|Description|
|----|-------|
|MsDynCrmMkt.ExtensibilityCallback.liveEditablePreAction| This function is used to introduce the code that executes before an entity enters the **live editable** state.|
|MsDynCrmMkt.ExtensibilityCallback.customUpdateFormControls| This function is triggered when the main form of the entity executes. This gives the possibility to unlock all the controls of the page and make them editable.|
|MsDynCrmMkt.ExtensibilityCallback.canGoLive| This function gives the ability to completely override the logic to show or hide the **Go live** ribbon.|
|MsDynCrmMkt.ExtensibilityCallback.preventSave| This function allows to control the save behavior of the entity.|
|MsDynCrmMkt.ExtensibilitySupplier.entityValidator| This function is returning a validator factory. Once correctly initialized can be used to verify that the configuration of the specific entity is valid.| 

The only limitations that are remaining to  customize  the Marketing solution are:

1. New states between transient state (Going live and Stopping) and fix stage is ignored.
2. If you want to go directly into **Live** state, without passing through **Going live** state, make sure that the entity values are not changed.
3. Do not remove any of the existing states.
4. When an entity enters into an inactive state, it cannot be activated.

## Implementation

### Step 1: Create a new solution

- Create a new [solution](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/customize/create-solution) and name it as **Sample Approval**.
- Add customer journey entity to the solution.
- Navigate to **Solutions** > **SAmple Approval** > **Entities** > **Customer Journey** > **Fields**.
- Select the **Statuscode** attribute and add the following new states to the **Statuscode** attribute:
   - Approved
   - Approval requested

      > [!NOTE]
      > Copy the values of the new states created for further use. You need  these values while creating custom ribbon buttons.

  - Click on **Edit Status Reason Transitions**  and click on **...** next to the options available and add the status reasons as shown below and click **Ok**.

    ![Status Reason Transition](../media/marketing-status-reason-transition.png "Status Reason Transition")

- Create a new field **msdyncrm_restorestatuscode** of data type **Whole number**, which stores the previous state information.
- Inside the solution create a new entity that can be named for example approvals. We will use this entity to decide whether the user logged in the system is an approver or a marketer. 


### Step 2: Create ribbon buttons

To make our solution to work, we need to create three custom ribbon buttons as explained below. To create custom ribbon buttons, see [Ribbon customizations](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/customize-dev/customize-commands-ribbon) or use any of the tools available in the Microsoft community. 

|Ribbon|Enable rules|Action|
|-----|-------|------|
|Approve|- Be an Approver <br/> - Be in Approval required state| Move the entity to **Approved** state|
|Reject| - Be an Approver <br/> - Be in Approval required state| Move the entity back to the previous state (use the `msdyncrm_rstorestatuscode` field to retireve)|
|Ask approval| - Be a Marketer <br/> - Be in draft, error or stop state| Store the actual state of the entity in `msdyncrm_restorestatuscode` field and move the entity to Approval requested state|

We will also need to remove the possibility for the marketer to enter in **live editable** state. The main idea is that if a request for approval is coming from a draft, error or stopped state and the approver decide to reject the changes, these are kept and is up to the marketer to make new ones. This logic cannot be applied to live editable stage, in fact if the approver would reject an entity that was in live editable, the entity will switch to live. Now if we would keep the changes the user could be confused since what he will see in the form will be different of what is saved in our services. To prevent this problem, we should revert the changes proposed by the marketer. If the entity is not strongly customized, we suggest achieving this introducing an extra field inside the entity and use this field to serialize the entity when a user access live editable stage. For this scope we introduce a new extensibility point: MsDynCrmMkt.ExtensibilityCallback.liveEditablePreAction. If we create an event on load of the form named as above this code will be called when the entity will enter in live editable state. The deserialization can be done both inside the action of the Reject ribbon or inside a plugin. We strongly suggest the second approach since gives a better control of the typing and is compatible with Microsoft Flow integration. 

### Step 3: Leverage extensibility points

For our example we will need to use 2 of the extensibility points mention above, both should be added as event on load on the main form of the customer journey inside the new solution created before:
•	MsDynCrmMkt.ExtensibilityCallback.canGoLive: this function, if defined, is used to decide when show go live button so, for our example we will need to check that the entity is in draft, error, stop state and the logged user is a marketer or we are in approved state 
•	MsDynCrmMkt.ExtensibilityCallback.customUpdateFormControls: this function, if defined, is execute after the form is full loaded. In our specific case we can use it to unlock the fields that we want to make editable for the marketers

### Step 4: Create two system views

To easily identify the entities that are in **Approval required** and **Approve** state, we suggest to create two system views in the customer journey entity to display all the entities that need an approval and all the entities that are already approved and waiting to **Go live**.  More information: [Create system views](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/customize/create-and-edit-views)

