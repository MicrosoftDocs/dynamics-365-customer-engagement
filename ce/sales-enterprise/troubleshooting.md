---
title: "Dynamics 365 Sales troubleshooting guide for sales people | MicrosoftDocs"
description: "Follow the instructions in this topic to troubleshoot the issues you may face while working on Dynamics 365 Sales."
ms.date: 10/01/2019
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Dynamics 365 Sales troubleshooting guide for sales people

Use the following list of troubleshooting topics to quickly find information to solve your issue.

## Lead qualification issues and resolution

### How do I convert or qualify my leads?

When you determine that the lead you’ve nurtured has a potential to turn into business, you qualify a lead. When you qualify a lead, it becomes an opportunity.
To qualify a lead, select **Qualify** on the command bar of the lead record.

> [!div class="mx-imgBorder"]  
> ![Qualify button on the Lead form](media/qualify-button-lead-form.png "Qualify button on the Lead form")

You can also qualify a lead from the list of leads. Go to **Sales** > **Leads**. Select the lead you want to qualify and on the command bar, select **Qualify**.

### Why am I not able to qualify a lead?
There could be multiple errors you may get while you qualify a lead. 
1.  [Duplicate warning - There might already be a match for this account or contact. If so, please select it](troubleshooting.md#duplicate)
2.  [To move to the next stage, complete the required steps](troubleshooting.md#CompleteSteps)
3.  [Active stage is not on 'lead' entity](troubleshooting.md#NoActiveStage)
4.  [Access denied or Insufficient permissions](troubleshooting.md#AccessDenied)

The following sections describe each of these errors and how you can resolve them.

<a name="duplicate"> </a>
#### 1. Duplicate warning - There might already be a match for this account or contact. If so, please select it.

> [!div class="mx-imgBorder"]  
> ![Duplicate warning while qualifying lead](media/duplicate-warning.png "Duplicate warning while qualifying lead")


**Reason:**

When the lead is qualified to an opportunity, it automatically creates a corresponding account and/or contact and there may already be a match for this account or contact.

**Resolution:**

On the **Duplicate warning** dialog box, select the existing account or contact to avoid creating duplicates. To create a new record instead, click **Continue**.

> [!NOTE]
> When you qualify a lead through the Leads grid, the system creates an account or contact even though a duplicate record exists. By design, the rule that detects the duplicate records gets disabled. However, when you qualify a lead through the lead record form, the duplicate detection rule works. The rule prompts you with a warning to resolve the conflict if any duplicate records for account or contact are found.

<a name="CompleteSteps"> </a>
#### 2. To move to the next stage, complete the required steps

**Reason:** 

You have not filled in data in all the business-required fields in the current stage of the process stage.

**Resolution:**

Fill in data in all the mandatory fields in the current stage, save the record, and then try qualifying the lead again.

<a name="NoActiveStage"> </a>
#### 3. Active stage is not on 'lead' entity

**Reason:**

The lead that you are trying to qualify isn’t in the Active state. This may happen when an already-qualified lead has been reactivated.

**Resolution:**

1.	Open the lead record.
2.	On the process stage, select the Set **Active** button.

    > [!div class="mx-imgBorder"]  
    > ![Set Active button in the Qualify stage of lead form](media/set-active-button-qualify-stage.png "Set Active button in the Qualify stage of lead form")

<a name="AccessDenied"> </a> 
#### 4. Access denied or Insufficient permissions

**Reason:**

You do not have sufficient permissions on the lead record. 

**Resolution:**

Ask your system administrator to grant you the necessary permissions.


If there’s no error, and you are still not able to qualify a lead, please contact the technical support here.


## Opportunity issues and resolution

### How do I close an opportunity?
      
Whether your customer has accepted or rejected your proposal, it is a good practice to close the opportunity as won or lost. 
When you close an opportunity, the opportunity is marked as complete, and can’t be changed. If you want to make further changes to an opportunity, you can reopen it. At the time of closing the opportunity, enter the Actual Revenue and Actual Close Date. The Actual Revenue is used for reporting purposes in charts and reports in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)].

To close an opportunity, open the opportunity record, and on the command bar, select **Close as Won** or **Close as Lost**.

> [!div class="mx-imgBorder"]  
> ![Close opportunity as Won or Lost](media/close-opportunity.png "Close opportunity as Won or Lost")

### Why am I not able to close an opportunity?

Here are some errors that you may see when you close an opportunity. 
1.  [The opportunity cannot be closed](troubleshooting.md#CannotBeClosed)
2.  [Access denied or Insufficient permissions](troubleshooting.md#AccessDeniedOpportunity)
3.  [The opportunity has already been closed](troubleshooting.md#AlreadyClosed)

The following sections describe each of these errors and how you can resolve them.

<a name="CannotBeClosed"> </a> 
#### 1. The opportunity cannot be closed

**Reason:**

There may be active or draft quotes associated with the opportunity.

**Resolution:**

1.	In the Opportunity record, go to the **Quotes** tab (or **Quotes line item** tab).
2.	Make sure none of the quotes are in the Draft or Active status.

    > [!div class="mx-imgBorder"]  
    > ![Quotes in the Draft status](media/quotes-in-draft-state.png "Quotes in the Draft status")


<a name="AccessDeniedOpportunity"> </a> 
#### 2. Access denied or Insufficient permissions.

**Reason:**

You do not have sufficient permissions to the opportunity you are trying to close.

**Resolution:**

Ask your system administrator to grant you the necessary permissions.

<a name="AlreadyClosed"> </a>
#### 3. The opportunity has already been closed.

**Reason:**

The opportunity that you are trying to close is already marked as Won or Lost. 

**Resolution:**

If you want to make changes to the already-closed opportunity, reopen the opportunity, make changes, and close it again.

### Why am I not able to edit an opportunity?

If you have already closed an opportunity as Won or Lost, it becomes read-only and you can no more change it. If you want to make any changes to the opportunity, reopen the opportunity. 

To reopen, open the opportunity, and on the command bar, select **Reopen Opportunity**.

> [!div class="mx-imgBorder"]
> ![Reopen opportunity](media/reopen-opportunity.png "Reopen opportunity")

### Why am I not able to add products to opportunity? 

Here are some errors that you may see while you add products to an opportunity. 
1.  [You must select a price list before attempting to add a product](troubleshooting.md#SelectPriceList)
2.  [You must provide a value for product description](troubleshooting.md#ProductName)
3.  [You can only add active products](troubleshooting.md#ActiveProducts)

<a name="SelectPriceList"></a>
#### 1. You must select a price list before attempting to add a product.

**Reason**: 

You've not selected a price list for the opportunity. Selecting a price list is required to be able to add products to an opportunity. 

**Resolution:**

1.  In the Opportunity record, go to the **Product Line Item** tab.
2.  In the **Price List** field, select a price list for the opportunity.  

<a name="ProductName"></a>
#### 2. You must provide a value for product description.

**Reason**: 

While creating a write-in product, you've not entered the product name.  

**Resolution:**

Enter the product name.   

<a name="ActiveProducts"></a>
#### 3. You can only add active products.

**Reason**: 

While adding an existing product, you selected a product in the **Draft** status.  

**Resolution:**

Make sure the product you want to add is in the Active state, and then add the product.   


## Forecast definition issues and resolution

### Why am I unable to publish forecast definition? 

**Reason**

There might be several reasons pertaining to publishing failure. The following are some examples that might have caused the failure: 
- Some users under the selected hierarchy may not be assigned the forecast manager or forecast user role. 
- Some users are disabled under the selected hierarchy when you publish the forecast definition.  

**Resolution**

1. Go to **Settings** > **System Jobs**.

    > [!div class="mx-imgBorder"]
    > ![Open settings page](media/troubleshooting-forecast-settings.png  "Open settings page")
    
    The system jobs page opens.

2. Identify the forecast definition publishing job that is failed. It is difficult for you to identify the job in the list of system jobs, so we recommend you to use the **Regarding** column to identify the failed job with forecast definition's title. In this example, the failed forecast definition title is **Bert FY'19**.

    > [!div class="mx-imgBorder"]
    > ![System jobs page](media/troubleshooting-forecast-system-jobs.png "System jobs page")
    
3. Select the System Job Name to view the error details. In this example, we have selected the system job name that is corresponding to **Bert FY'19**.

    > [!div class="mx-imgBorder"]
    > ![Select failed system job](media/troubleshooting-forecast-system-job-select.png "Select failed system job")

4. In the information page, you can see the error message highlighted in **Yellow** with the reason why the forecast definition publishing is failed. Select **Details** section to further drill-down in to the error details. In this example, you can see that the error has occurred due to insufficient user privileges in Bart's hierarchy. 

    > [!div class="mx-imgBorder"]
    > ![Failed reason in information page](media/troubleshooting-forecast-system-job-failed-reason.png "Failed reason in information page")

5. Take the necessary actions to resolve the error and republish the forecast definition. 
    
    In this example to resolve the error, assign Forecast manager or Forecast user roles to all the user under Bart's hierarchy as required and republish the forecast definition.

### Why am I unable to recalculate forecast?

**Reason**

There might be several reasons pertaining to the failure of recalculation of the forecast. The following are some examples that might have caused the failure: 
- User roles (forecast manager or forecast user) might have been removed under the selected hierarchy after the forecast was created. 
- In the **Forecast metric** value, for **Revenue** field, the **Rollup Fields** value is changed.

**Resolution**

1. Go to **Change area** and select **Sales** > **Forecasts**. 

    > [!div class="mx-imgBorder"]
    > ![Select forecasts](media/troubleshooting-forecast-changearea-sales-forecasts.png "Select forecasts")

    A list of published forecasts are displayed.

2. In **Last recalculated on** column displays a error icon corresponding to recalculation failed forecast. Place cursor over the icon and a message/reason for the error is displayed.
 
    > [!div class="mx-imgBorder"]
    > ![View recalculation failed icon](media/troubleshooting-forecast-recalculation-failed-error-message.png "View recalculation failed icon")

4. Take necessary actions to resolve the error and recalculate forecast. 


### See Also

[Dynamics 365 Sales troubleshooting guide for administrators](troubleshooting-admin.md)
