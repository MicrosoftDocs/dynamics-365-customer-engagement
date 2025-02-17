---
title: Qualify and convert a lead to opportunity
description: Learn how to qualify leads in the Sales app to create corresponding accounts and opportunities, and how to disqualify leads that don't turn into an opportunity.
ms.date: 10/14/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - ai-gen-docs-bap
  - ai-gen-desc
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-lead
  - D365-Entity-lead
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Qualify and convert a lead to opportunity

After you identify the time frame, budget, and purchase process for a lead, qualify the lead to create the corresponding account, contact, and opportunity records. If a lead isn't likely to turn into an opportunity, disqualify it to keep a record of the sales process.

[!INCLUDE [trial-cta-note](../includes/trial-cta-note.md)]

## Qualify a lead

1. From the site map, select **Leads**.
1. In the list of leads, open the lead that you want to qualify. You can also [qualify multiple leads at the same time](#qualify-leads-in-bulk).
1. (Optional) In the **Qualify** section of the process bar, specify the following information:

    - If the lead is from an existing account or contact, select the account in the **Existing Account** field and the account in the **Existing Contact** field. This step is optional because you can create a new account and contact in the next step, or use an existing account and contact, depending on how your administrator configured the lead qualification experience.
    - Specify other details, such as the purchase time frame and estimated budget.

1. On the command bar, select **Qualify**.

    Depending on the lead qualification experience that your admin configured, you experience one of the following flows:

    - [New experience](#new-experience)
    - [Legacy experience](#legacy-experience)

    The lead is moved to the next stage of the business process. The lead is also removed from the **My Open Leads** view and added to the **Closed Leads** view.

    > [!NOTE]
    > If no opportunity is created when you qualify a lead, the business process flow doesn't progress to the next stage, although the lead's status becomes *Qualified*.

### New experience

As part of the [new lead qualification experience](define-lead-qualification-experience.md#difference-between-new-lead-qualification-experience-and-legacy-experience), your admin can customize several aspects of the lead qualification process.

#### Record creation

- If your admin turned on the new experience and also turned on automatic creation of account, contact, and opportunity records, the records are automatically created. While the records are being created, a "Processing" message is shown. After the records are created, the opportunity record is opened.
- If your admin turned off automatic creation for all records, the **Qualify lead** side pane for creating contact, account, and opportunity records appears. For contact and account records, you can create a new record, use an existing record, or skip record creation.

    > [!NOTE]
    > For the account record, the **Create new** option is available only when the **Company name** field is set in the lead record.

- If your admin turned on automatic creation for some records and manual creation for others, the **Qualify lead** side pane is displayed. It shows records that will be created automatically and records that you must create manually. For example, the account and contact records might be set for automatic creation, whereas the opportunity record is set for manual creation. The following screenshot shows an example of the side pane displays for this scenario:

    :::image type="content" source="media/qualify-lead-dialog-box-mix.png" alt-text="Screenshot of the Qualify lead side pane when record creation is set to automatic for the contact and account records, but set to manual for the opportunity record.":::

    In this example, the account and contact records aren't editable. If you must change the account or contact details, close the side pane, edit the details in the **Lead** form, and then select **Qualify**.

Learn how the fields in the lead record are mapped to other records in [Field mappings to other entities](define-lead-qualification-experience.md#field-mappings-to-other-entities). If a similar account or contact already exists, the duplicate detection dialog appears. You can then either create a new record or use the existing record. Learn more in [What happens when duplicates are found while qualifying leads?](faq-lead.md#what-happens-when-duplicates-are-found-while-qualifying-leads)

#### Multiple opportunity creation

If your admin turned on multiple opportunity creation, you can create up to five opportunities for each lead. A default opportunity record is added to the **Qualify lead** side pane. To create additional opportunities, follow these steps:

1. In the **Qualify lead** side pane, select **+&nbsp;New Opportunity**. If the **+&nbsp;New Opportunity** button is unavailable, learn why in [Why can't I edit or create multiple opportunities for a lead in the new lead qualification experience?](faq-lead.md#why-cant-i-edit-or-create-multiple-opportunities-for-a-lead-in-the-new-lead-qualification-experience)
1. In the **Quick create** form for adding opportunities, enter the details of the opportunity. If you want the opportunity form to include different fields, talk to your admin about [customizing the opportunity form](define-lead-qualification-experience.md#customize-opportunity-creation-experience-for-qualified-leads).
1. Save the opportunity record.

    The records aren't created until you select **Qualify**. If you close the **Qualify lead** side pane without qualifying the lead, no records are created.

#### Lead summary

If your admin [turned on lead summarization](define-lead-qualification-experience.md#summarize-the-lead-after-its-qualified), an AI-generated summary of the lead is shown after the lead is qualified. The summary includes key details from the lead record and is added to the timeline of the primary opportunity record and the lead record.

![Screenshot of the Lead qualified page that appears after the lead is qualified.](media/lead-qualify-finish-page.png "Screenshot of the Lead qualified page that appears after the lead is qualified.")

Select **Finish** to open the primary opportunity record, and select **X** at the top of the pane to return to the lead record.

### Legacy experience

- If your admin turned on automatic creation, account, contact, and opportunity records are automatically created when the lead is qualified.
- If your admin turned off automatic creation, you're prompted to select which records should be created when the lead is qualified (account, contact, or opportunity).

    ![Screenshot that shows account and contact records selected for creation in the Qualify lead dialog.](media/qualify-lead-dialog-box.png "Screenshot that shows account and contact records selected for creation in the Qualify lead dialog")

Learn more:

- [What happens when a lead is qualified?](faq-lead.md#what-happens-when-a-lead-is-qualified)
- [What happens when duplicates are found while qualifying leads?](faq-lead.md#what-happens-when-duplicates-are-found-while-qualifying-leads)
- [How do I handle lead qualification errors?](faq-lead.md#how-do-i-handle-lead-qualification-errors)

## Qualify leads in bulk

You can qualify multiple leads at the same time. To qualify multiple leads, open the **Leads** page in a read-only grid view, and select the leads that you want to qualify. Then, on the command bar, select **Qualify**.

If your admin turned automatic creation in the legacy experience, the records are automatically created. If your admin turned off automatic creation or turned on the new experience, a dialog appears, where you can select which records should be created when the lead is qualified.

## Disqualify a lead

If you know that a lead won't turn into an opportunity, you can disqualify it and still have an audit trail for your sales process. If the lead contacts you in the future, you can reactivate the record, including any attachments and notes, without having to reenter all the data. If you delete the record, any attachments and notes are also removed.

> [!NOTE]
> You can disqualify a lead only if no opportunity is associated with it.

To disqualify a lead, select the lead, and then, on the command bar, select **Disqualify**.

## Troubleshoot issues and get answers to frequently asked questions about lead qualification

- Learn how to fix the common errors that you might encounter while you qualify a lead in the [troubleshooting guide](troubleshooting.md).
- Get answers to frequently asked questions about lead qualification in [Lead management FAQs](faq-lead.md).

## Typical next steps

![Right arrow button](media/orange-right-arrow-button.png "Right arrow button") [Create or edit an opportunity](create-edit-opportunity-sales.md)

![Home button](media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](nurture-sales-from-lead-order-sales.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Customize the lead qualification experience](define-lead-qualification-experience.md)  
[Print quote, invoice, or other records](print-records.md)   
[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  
[Prioritize leads through scores](work-predictive-lead-scoring.md)  
[Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)  
[FAQs about lead qualification experience](faq-lead.md#faqs-about-lead-qualification-experience)  
[Troubleshoot issues with lead qualification issues for salespeople](/troubleshoot/dynamics-365/sales/troubleshoot-lead-qualification-issues-for-salespeople)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
