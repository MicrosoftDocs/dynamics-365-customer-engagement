---
title: "Build an approvals feature (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Build an approvals feature that utilizes Dynamics 365 Marketing extensibility endpoints."
ms.date: 08/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Build an approvals feature

Dynamics 365 Marketing provides an infrastructure with extensibility features that offer new possibilities for developers, and one way to take advantage of this new extensibility is to create an approvals feature, possibly including integration with Power Automate.

This topic outlines one way that you could develop an approvals feature for Marketing. The feature described here would enable organizations to implement an approval workflow in which most users can't make some types of important entities (such as emails, customer journeys, or segments) **Go live** right away. Instead, an approver must inspect each record and decide whether to allow it to **Go live**, or whether more work is needed. The approver is typically an administrator or manager who is identified as an approver in the system.

> [!IMPORTANT]
> The approval feature described here is intended to support a collaborative workflow among colleagues and helps prevent accidentally going live with an entity that is not yet ready. We recommend that you also develop plug-ins that prevent users from going live from any state that isn't approved and also prevent users from editing fields on the records that are in the approval-required, approved, or live state.

<!--## Prerequisites-->

<!--1. Download the [code]() for sample web resources and ribbon customizations.
2. Sign up for or install the [Dynamics 365 Marketing](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/trial-signup) app. Make sure you are installing the latest version of the app.
3. Obtain a license for [Power Automate](https://flow.microsoft.com/) to create a sample approvals feature.-->

## The approval process

The customizations outlined in this topic will help you design and implement an approval workflow that works as described below:

1. Standard users (non-approvers who we will call Marketers) no longer see a **Go live** button on entity forms where approvals are enabled. Instead, this is replaced by a **Request approval** button on the command bar. These entities use a custom collection of Status reason values, which are used to track the approval status of each record. Records requiring approval begin with a Status reason of **Approval required**.

1. When the marketer has finished creating a new record (such as an email design), they select **Send for approval**, which checks that the entity is valid and triggers the following changes:
   - The Status reason for this record changes to **Approval requested**.
   - The record is locked to further changes.
   - An email message gets automatically sent to the approver configured in the system, telling them their approval is required. The message includes buttons to approve or reject. It has a link to view the relevant record in the Dynamics 365 Marketing (where the approve and reject buttons are present).
   - For the approver, **Approve** and **Reject** buttons are now provided on the command bar. 
1. The approver responds by doing one of the following:
   - Approve: The record changes its Status reason to Approved. The **Go live** button is also made available to all users for this record. Any user can now go live with the record, provided no edits are made. If a user edits an approved record, the **Go live** button is again replaced with a **Request approval** button, and the Status reason is changed to **Approval required**.
   - Reject: The record changes its Status reason to Rejected. The **Request approval** button is added again to the command bar. The user can now make changes and then resend for approval.
1. This process is repeated until the record is approved and live.

## Extensibility functions to support approvals

The following functions are added inside the Marketing solution (from the August release) and can be used to override or use the default logic for entities with a complex lifecycle (marketing email, customer journey, content settings, marketing page, marketing form, and segment).

|Function name|Description|
|----|-------|
|MsDynCrmMkt.ExtensibilityCallback.liveEditablePreAction| Used to introduce the code that executes before an entity enters the **live editable** state.|
|MsDynCrmMkt.ExtensibilityCallback.customUpdateFormControls| Triggered when the main form of the entity executes. This gives the possibility to unlock all the controls of the page and make them editable.|
|MsDynCrmMkt.ExtensibilityCallback.canGoLive| Gives the ability to completely override the logic to show or hide the **Go live** ribbon.|
|MsDynCrmMkt.ExtensibilityCallback.preventSave| Allows to control the save behavior of the entity.|
|MsDynCrmMkt.ExtensibilitySupplier.entityValidator| Returns a validator factory. Once correctly initialized, can be used to verify that the configuration of the specific entity is valid.| 

The only limitations that remain to customize the Marketing solution are:

1. New states between transient state (Going live and Stopping) and fix stage are ignored.
2. If you want to go directly into **Live** state, without passing through **Going live** state, make sure the entity values are not changed.
3. Do not remove any of the existing states.
4. When an entity enters into an inactive state, it cannot be reactivated.

## Implementation

### Step 1: Create a new solution

1. Create a new [solution](/powerapps/maker/common-data-service/create-solution) and name it **Sample Approval**.
2. Add customer journey entity to the solution.
3. Navigate to **Solutions** > **Sample Approval** > **Entities** > **Customer Journey** > **Fields**.
4. Select the **Statuscode** attribute and add the following new states:
   - Approved
   - Approval requested

      > [!NOTE]
      > Copy the values of the new states created for further use. You need these values while creating custom ribbon buttons.

 5. Select **Edit Status Reason Transitions**, select the **ellipsis** (...) next to the options available, add the status reasons as shown below, and then select **OK**.

    ![Status Reason Transitions](../media/marketing-status-reason-transition.png "Status Reason Transitions")

6. Create a new field **msdyncrm_restorestatuscode** of data type **Whole number**, which stores the previous state information.
7. Inside the solution, create a new entity that can be named, for example, approvals. We use this entity to decide whether the user logged in the system is an approver or a marketer. 
8. Create two new users: approver and marketer. The approver has write access to the above created entity, while the marketer has no system administrator or system customizer privileges. 


### Step 2: Create ribbon buttons

To make our solution to work, we need to create three custom ribbon buttons, as explained below. To create custom ribbon buttons, see [Customize commands and the ribbon](https://docs.microsoft.com/dynamics365/customer-engagement/developer/customize-dev/customize-commands-ribbon) or use any of the tools available in the Microsoft community. 

|Ribbon|Enable rules|Action|
|-----|-------|------|
|Approve|- Be an Approver <br/> - Be in Approval-required state| Move the entity to the **Approved** state.|
|Reject| - Be an Approver <br/> - Be in Approval-required state| Move the entity back to the previous state (use the `msdyncrm_rstorestatuscode` field to retrieve).|
|Ask approval| - Be a Marketer <br/> - Be in draft, error, or stopped state| Store the actual state of the entity in the `msdyncrm_restorestatuscode` field, run a validation check on the entity, and if the entity is valid move the entity to the **Approval requested** state.|

We must remove the possibility for the marketer to enter the **live editable** state. This is important because when a request for approval comes from a draft, error, or stopped state, and the approver decides to reject the changes, the changes are kept and it's up to the marketer to make new ones. This logic can't be applied to the live-editable state because if the approver rejects a live-editable record, it will revert back to live. If we were to keep the changes, the user could be confused because what they see in the form will be different from what is saved in our services. 

To prevent this problem, we should revert the changes proposed by the marketer. If the entity isn't strongly customized, we suggest achieving this by introducing an extra field inside the entity and use this field to serialize the entity when a record enters the live-editable state. 

For this scope, we introduce a new extensibility point **MsDynCrmMkt.ExtensibilityCallback.liveEditablePreAction**. If we create an event on load of the form, named as above, this code will be called when the record enters a live-editable state. The deserialization can be done both inside the action of the Reject ribbon or inside a plug-in. We strongly suggest the second approach because it gives better control of the typing and is compatible with Power Automate integration.

### Step 3: Leverage extensibility points

For our example, we will need to use two of the extensibility points mentioned above. Both should be added as an event on load on the main form of the customer journey inside the new solution created before.

- **MsDynCrmMkt.ExtensibilityCallback.canGoLive**: This function, if defined, is used to decide when to show the **Go live** button. For our example, we will need to check that the entity is in draft, error, stop state and the logged-in user is a marketer, or we are in the approved state. 
- **MsDynCrmMkt.ExtensibilityCallback.customUpdateFormControls**: This function, if defined, is executed after the form is fully loaded. In our specific case, we can use it to unlock the fields we want to make editable for the marketers.

### Step 4: Create two system views

To easily identify the entities that are in the **Approval required** and **Approve** states, we suggest creating two system views in the customer journey entity to display all the entities that need approval, and all the entities that are already approved and waiting to **Go live**.  More information: [Create or edit a view](https://docs.microsoft.com/dynamics365/customer-engagement/customize/create-and-edit-views)

## See also
[Build approvals feature using Power Automate](build-approval-feature-using-flow.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]