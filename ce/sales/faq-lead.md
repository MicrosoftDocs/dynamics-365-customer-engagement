---
title: Lead management FAQs
description: Get answers to frequently asked questions about various aspects of Lead management such as lead qualification, duplicate detection, and scoring. 
ms.date: 07/04/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Lead management FAQs

This article answers frequently asked questions about Lead management in Dynamics 365 Sales, Sales premium, and Sales professional.

## What's the difference between the duplicate detection capability in Power Platform and Dynamics 365 Sales?

Power Platform detects duplicates by comparing the matchcode that is created for each record. For more information, go to [Detect duplicate data so you can fix or remove it](/power-platform/admin/detect-duplicate-data).

Dynamics 365 Sales detects duplicates with an AI model that compares leads using fuzzy logic and the matchcode that is generated for each lead.

The following table shows an example of the two methods for detecting duplicates.

| Rule type | Applied for |
|-----------|------------|
| Fuzzy logic | - Similar lead name and company name<br>- Similar lead name and the same email domain |
| Matchcode | - Email address<br>- Phone number |

For more information, go to [Enable duplicate lead detection](enable-duplicate-lead-detection.md).

<a name="scoring-minimum-requirement"></a>
## How do I verify whether I have the required number of leads or opportunities to create a scoring model?

Before you create a lead or opportunity scoring model, you need to ensure that you have a minimum of 40 qualified and 40 disqualified leads or 40 won and 40 lost opportunities to train the model. You can select a time frame between 3 months to 2 years to train the model.

Let's understand the minimum requirement with an example scenario:

You want to build a lead scoring model and train it with leads created and closed in the last 6 months. You want to include only those leads that are using the **Lead to opportunity Sales Process** business process flow. Use the following steps to verify whether you have the required number of leads. You can follow similar steps to verify the minimum requirement for opportunity scoring. If you plan to use the [per stage model](configure-predictive-opportunity-scoring.md#what-is-a-per-stage-model) in your opportunity scoring, see this [section](faq-opportunity.md#opportunity-per-stage-scoring).

1. On the **Leads** page, select **All leads** from the view selector.

1. Select **Edit Filters**.
1. Select **Add** and set the following filters:
   - **Created On** = **Last 6 months**.
   - **Status** = **Qualified**.
1. Select **Add** > **Add related entity** and set the following filters:
   - **Related entity** = **Lead to opportunity Sales Process** 
   - **Operator** = **Contains data**
   - **Field** = **Status Reason**
   - **Operator** = **Does not equal**
   - **Value** = **Aborted**

   The following screenshot shows the filters that you need to set:
   :::image type="content" source="media/scoring-minimum-data.svg" alt-text="Screenshot of the Edit filters page with filters to verify minimum requirement for scoring.":::

   :::image type="content" source="media/scoring-minimum-data.png" alt-text="Screenshot of the Edit filters page with filters to verify minimum requirement for predictive scoring.":::

1. Verify the number of leads that meet the criteria. If the number of leads is less than 40, you can increase the time frame to include more leads. To verify the number of disqualified leads, change the **Status** filter to **Disqualified**.

## What do I need in order to use lead scoring?​

Install [!INCLUDE[pn_dynamics_sales_insights](../includes/pn-dynamics-sales-insights.md)] and use the standard lead entity or the standard opportunity entity.​ A minimum number of leads or opportunities is required to build a scoring model:

To build a lead scoring model, you need to have a minimum of 40 qualified and 40 disqualified leads.  
To build an opportunity scoring model, you need to have a minimum of 40 won and 40 lost opportunities.  
The leads and opportunities must have been created on or after January 1, in the previous year.

<a name=leads-not-scored>
## Why aren't my leads or opportunities scored?

If a lead or opportunity is not scored or the score is not updated, ensure that the following conditions are met:

- The scoring model is published.

- The record is in the Open state.
- The record meets all the conditions that are defined in the scoring model.
- The record is using the same business process flow that is configured in the scoring model.
- The record was created within the last 2 years from the current date. The model checks the date every time it scores a record. If a record was scored earlier but goes outside the 2-year window in the next scoring cycle, the score won't be updated.


## How frequently are the predictive lead scores updated?

For new leads, the scoring happens in near real-time. The score will be displayed within five minutes of saving a new lead. For updated leads, the scores are refreshed after every 24 hours.

## Why aren't my leads scored in real-time?

Real-time scoring is supported only for new leads. If you don't see the score even after 15 minutes of saving or importing the new lead, contact your administrator. Your administrator can verify whether the model that's scoring the new lead was created or edited, and published after the real-time scoring feature was rolled out. For more information, see [Real-time scoring](work-predictive-lead-scoring.md#real-time-scoring).

## Can I customize the model?

Yes, you are able to modify which attributes are selected to train the model. That said, the out-of-the-box model automatically selects the attributes it determines are most relevant for your business.

## Can I create multiple models for leads?​

Yes, you can add and publish multiple models that are specific to each line of business in your organization.

## What is the difference between score and grade?​

The score is generated by the machine learning model. <br>
The grade is just grouping scores in four buckets that the admin can configure.

##  What happens when a lead is qualified?

Your system administrator defines what happens to a lead when it's qualified:

-  If your system administrator has set **Create Account, Contact, and Opportunity records by default upon qualifying a lead** to **No**, you'll be prompted to choose what records to create when the lead is qualified (account, contact, or opportunity). 

-  If they've set **Create Account, Contact, and Opportunity records by default upon qualifying a lead** to **Yes**, an account, contact, and opportunity records are automatically created when the lead is qualified.

##  Where can I find the qualified and disqualified leads?

Select **Leads** in the sitemap, and then select the **Closed Leads** view to find your qualified and disqualified leads. You can reactivate the leads if you want to qualify them again. 

##  What happens when duplicates are found while qualifying leads?

When qualifying a lead, if a duplicate account or contact is detected while creating new records, a duplicate warning is shown to you. Depending on whether your system administrator has enabled the improved duplicate detection and merge experience, you'll see the options to resolve duplicates.

For information on enabling the improved duplicate detection and merge experience, see [Enable the improved duplicate detection and merge experience](/power-platform/admin/enable-improved-duplicate-detection).

##  How do I handle lead qualification errors?

While qualifying a lead, one of the following errors occur due to duplicate leads:

- Lead record was not created or updated because a duplicate of the current record already exists. 
- Opportunity record was not created or updated because a duplicate of the current record already exists.

If the [duplicate detection rules](/power-platform/admin/set-up-duplicate-detection-rules-keep-data-clean) feature is enabled in your organization, the application won't allow qualification of leads if duplicates of that lead exist. To mitigate the issue, try the following resolutions:

- Remove the duplicates for the lead and qualify again. More information: [Merge duplicate rows](/power-apps/user/merge-duplicate-records) 
- Go to the leads grid view, select the lead and qualify.
- Unpublish the rule that is causing the error and qualify the lead again. Contact your administrator to unpublish the rules using the following steps.
    1. Go to **Advanced settings** > **Settings** > **System** > **Data Management** > **Duplicate Detection Rules**.
    1. Select the rule and then select **Unpublish**.
- If a rule is required only to create or update the lead, but not required for qualification, ensure that duplicate detection rules don’t run on qualified leads. Enable the **Exclude inactive matching records** option and qualify the lead. Contact your administrator to enable the option using the following steps. 
    1. Go to **Advanced settings** > **Settings** > **System** > **Data Management** > **Duplicate Detection Rules**.
    1. Open and unpublish the rule.
    1. Select the **Exclude inactive matching records** option.  
        
        :::image type="content" source="./media/duplicate-records-enable-exclude-inactive-matching-records.png" alt-text="A screenshot of enabling the Exclude inactive matching records option."::: 

    1. Publish the rule.

## What happens when the improved duplicate detection and merge experience is disabled

When the improved duplicate detection experience is disabled, you'll see the **Duplicate warning** dialog box.

> [!div class="mx-imgBorder"] 
> ![Screenshot of the Duplicate warning dialog box.](media/duplicate-records-warning.png "Duplicate warning while qualifying a lead")

In the **Account** and **Contact** fields, select the matching account and contact record and select **Continue**. To ignore the duplicate warning and create new records, leave the Account and Contact fields blank, and select **Continue**.

The **Account** and **Contact** lookup fields are filtered with matched results and shown along with additional information to precisely identify the record to which the lead should be linked. For example, when you select the **Contact** lookup search icon, you'll see only matched contact records.

## What happens when the improved duplicate detection and merge experience is enabled

When the improved duplicate detection and merge experience is enabled, you'll see the **Account or Contact may already exist** dialog box.

> [!div class="mx-imgBorder"] 
> ![Screenshot of dialog box showing records might already exist.](media/duplicate-records-already-exists.png "Records may already exist")

The **Matched accounts** and **Matched contacts** sections will show all the matching records (based on the duplicate detection rules) along with additional information to precisely identify the record to which the lead should be linked.

To associate the lead record to an existing matching record, select the record, and select **Continue**. To create a new account or contact record, select **Ignore and save** without selecting a matching record.

The lead is qualified. 

##  What happens to notes and attachments when leads are qualified?

When salespeople work on a lead, they use notes to store key information on the things they've researched about the lead. This could be information like new contacts at the site, current value of the contract, vendor information and so on. When a lead is qualified, these notes are displayed in the Opportunity record so that the information isn't lost.

