---
title: "Dynamics 365 for Sales troubleshooting guide for sales people | MicrosoftDocs"
description: "Follow the instructions in this topic to troubleshoot the issues you may face while working on Dynamics 365 for Sales."
keywords: "Dynamics 365 for Sales, troubleshoot, FAQ, issue, resolution"
ms.date: 07/18/2018
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6a381b64-497c-476a-8d4c-98bf5da742b5
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Drafting
---

# Dynamics 365 for Sales troubleshooting guide for sales people

Use the following list of troubleshooting topics to quickly find information to solve your issue.

## Lead qualification issues and resolution

### How do I convert or qualify my leads?

When you determine that the lead you’ve nurtured has a potential to turn into business, you qualify a lead. When you qualify a lead, it becomes an opportunity.
To qualify a lead, select **Qualify** on the command bar of the lead record.

![Qualify button on the Lead form](media/qualify-button-lead-form.png "Qualify button on the Lead form")
 
### Why am I not able to qualify a lead?
There could be multiple errors you may get while you qualify a lead. 
-  [A record was not created or updated because a duplicate of the current record already exists](troubleshooting.md#duplicate)
-  [To move to the next stage, complete the required steps](troubleshooting.md#CompleteSteps)
-  [Active stage is not on 'lead' entity](troubleshooting.md#NoActiveStage)
-  [Access denied or Insufficient permissions](troubleshooting.md#AccessDenied)
-  [Duplicate Warning](troubleshooting.md#DuplicateWarning)

The following sections talk about each of these errors and how you can resolve them.

<a name="duplicate"> </a>
#### A record was not created or updated because a duplicate of the current record already exists

**Reason:**
The lead has already been qualified to an Opportunity.

**Resolution:**
Make sure that an opportunity is already present. 
In the **Search** box, search for the opportunity with the same name as the lead you’re trying to qualify.

<a name="CompleteSteps"> </a>
#### To move to the next stage, complete the required steps

**Reason:** 
You have not filled in data in all the business-required fields in the current stage of the process stage.

**Resolution:**
Fill in data in all the mandatory fields in the current stage, save the record, and then try qualifying the lead again.

<a name="NoActiveStage"> </a>
#### Active stage is not on 'lead' entity

**Reason:**
The lead that you are trying to qualify isn’t in the Active state. This may happen when an already-qualified lead has been reactivated.

**Resolution:**
1.	Open the lead record.
2.	On the process stage, select the Set **Active** button.

    ![Set Active button in the Qualify stage of lead form](media/set-active-button-qualify-stage.png "Set Active button in the Qualify stage of lead form")

<a name="AccessDenied"> </a> 
#### I get a message "Access denied or Insufficient permissions"

**Reason:**
You do not have sufficient permissions on the lead record. 

**Resolution:**
Ask your system administrator to grant you the necessary permissions.

<a name="DuplicateWarning"> </a> 
#### Duplicate Warning dialog box appears

**Reason:**
You have duplicate records in Dynamics 365 for Sales

**Resolution:**
Resolve the duplicates as identified in dialog box or select **Continue** to create a duplicate record and qualify the lead.

![Duplicate warning while qualifying lead](media/duplicate-warning.png "Duplicate warning while qualifying lead")


If there’s no error, and you are still not able to qualify a lead, please contact the technical support here.


## Opportunity issues and resolution

### How do I close an opportunity?
      
Whether your customer has accepted or rejected your proposal, it is a good practice to close the opportunity as won or lost. 
When you close an opportunity, the opportunity is marked as complete, and can’t be changed. If you want to make further changes to an opportunity, you can reopen it. At the time of closing the opportunity, enter the Actual Revenue and Actual Close Date. The Actual Revenue is used for reporting purposes in charts and reports in Dynamics 365 for Sales.

To close an opportunity, open the opportunity record, and on the command bar, select **Close as Won** or **Close as Lost**.


![Close opportunity as Won or Lost](media/close-opportunity.png "Close opportunity as Won or Lost")

### Why am I not able to closing an opportunity?

Here are some errors that you may see while you close an opportunity. 
-  [The opportunity cannot be closed](troubleshooting.md#CannotBeClosed)
-  [Access denied or Insufficient permissions](troubleshooting.md#AccessDeniedOpportunity)

The following sections talk about each of these errors and how you can resolve them.

<a name="CannotBeClosed"> </a> 
#### The opportunity cannot be closed

**Reason:**
There may be active or draft quotes associated with the opportunity.

**Resolution:**
1.	In the Opportunity record, go to the Quotes tab (or Quotes line item tab).
2.	Make sure none of the quotes are in the Draft or Active status.

    ![Quotes in the Draft status](media/quotes-in-draft-state.png "Quotes in the Draft status")


<a name="AccessDeniedOpportunity"> </a> 
#### Access denied or Insufficient permissions.

**Reason:**
You do not have sufficient permissions to the opportunity you are trying to close.

**Resolution:**
Ask your system administrator to grant you the necessary permissions.

### I am unable to edit an opportunity?

If you have already closed an opportunity as Won or Lost, it becomes read-only and you can no more change it. If you want to make any changes to the opportunity, reopen the opportunity. 

To reopen, open the opportunity, and on the command bar, select **Reopen Opportunity**.
 
![Reopen opportunity](media/reopen-opportunity.png "Reopen opportunity")

### I am unable to add products to opportunity? 

Here are some errors that you may see while you add products to an opportunity. 
-  [You must select a price list before attempting to add a product](troubleshooting.md#SelectPriceList)
-  [You must provide a value for product description](troubleshooting.md#ProductName)
-  [You can only add active products](troubleshooting.md#ActiveProducts)

<a name="SelectPriceList"></a>
#### You must select a price list before attempting to add a product.

**Reason**: 
You've not selected a price list for the opportunity. Selecting a price list is required to be able to add products to an opportunity. 

**Resolution:**
1.  In the Opportunity record, go to the **Product Line Item** tab.
2.  In the Price List field, select a price list for the opportunity.  

<a name="ProductName"></a>
#### You must provide a value for product description.

**Reason**: 
While creating a write-in product, you've not entered the product name.  

**Resolution:**
Enter the product name.   

<a name="ActiveProducts"></a>
### You can only add active products.

**Reason**: 
While adding an existing product, you selected a product in the **Draft** status.  

**Resolution:**
Make sure the product you want to add is in the Active state, and then add the product.   


### See Also

[Dynamics 365 for Sales troubleshooting guide for administrators](troubleshooting-admin.md)
