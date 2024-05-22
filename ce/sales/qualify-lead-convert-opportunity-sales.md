---
title: Qualify and convert leads to opportunity
description: Qualify leads in the Sales app to create corresponding accounts and opportunities, and disqualify leads when they won't turn into an opportunity.
ms.date: 03/15/2024
ms.topic: article
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
# Qualify and convert leads to opportunity

After you've identified the time frame, budget, and purchase process for a lead, qualify the lead to create the corresponding account, contact, and opportunity. 

[!INCLUDE [trial-cta-note](../includes/trial-cta-note.md)] 

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Qualify a lead

1. In the Sales Hub site map ![Site Map icon.](media/site-map-icon.png "site map icon"), select **Leads**.

2. In the list of leads, open the lead you want to qualify.

3. In the **Qualify** section of the process bar, specify the following information:
    - If the lead is from an existing account or contact, select them in the **Existing Contact** and **Existing Account** fields.
    - Specify the other details such as purchase timeframe and estimated budget.

     > [!TIP]
     > To qualify multiple leads, go back to the leads list page and select the leads that you want to qualify.
4. On the command bar, select **Qualify**.
    Depending on the lead qualification experience chosen by your administrator, you'll either see a prompt for creating the contact, lead, and opportunity records or you'll see a **Processing** message and the records will be automatically created. 
      ![Select which records to create in the Qualify lead dialog box.](media/qualify-lead-dialog-box.png "Select which records to create in the Qualify lead dialog box")
     
    **More information:** 
    - [What happens when a lead is qualified](faq-lead.md#what-happens-when-a-lead-is-qualified)
    - [What happens when duplicates are found while qualifying leads?](faq-lead.md#what-happens-when-duplicates-are-found-while-qualifying-leads)
    - [How do I handle lead qualification errors?](faq-lead.md#how-do-i-handle-lead-qualification-errors)
    
The lead moves to the next stage in the business process. The lead is also removed from the **My Open Leads** view and gets added to the **Closed Leads** view.
  
> [!NOTE]
> If an opportunity isn't created when qualifying a lead, the business process flow doesn't progress to the next stage, although the lead status becomes qualified.

## Qualify leads in bulk

You can qualify multiple leads at once. To qualify multiple leads, open the Leads page in read-only grid vie and select the leads that you want to qualify. On the command bar, select **Qualify**.

:::image type="content" source="media/bulk-qualify.png" alt-text="Screenshot of Qualify Leads dialog.":::

When you qualify leads in bulk, you won't be able to create multiple opportunities or customize the behavior  that are created. 

## Disqualify a lead

When you decide that a lead won't turn into an opportunity, you can disqualify it, and still have an audit trail for your sales process. You can reactivate the record, including any attachments and notes, without having to re-enter all the data if the lead contacts you in the future. Deleting the record also removes any attachments and notes.

> [!NOTE]
> You can disqualify a lead only if there's no opportunity associated with that lead.  

To disqualify, select the lead, and on the command bar, select  **Disqualify**.

## Troubleshoot issues and frequently asked questions with lead qualification

- For information on how to resolve the common errors that you may get while you qualify a lead, see the [troubleshooting guide](troubleshooting.md).  
- For frequently asked questions about lead qualification, see [Lead management FAQs](faq-lead.md).

## Typical next steps  

 ![Right arrow button](media/orange-right-arrow-button.png "Right arrow button") [Create or edit an opportunity](create-edit-opportunity-sales.md)  
  
 ![Home button](media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](nurture-sales-from-lead-order-sales.md) 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
  
### See also  
[Define lead qualification experience](define-lead-qualification-experience.md)  
[Print quote, invoice, or other records](print-records.md)         
[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  
[Boost sales with Versium Predict](../versium-predict/versium-predict.md)  
[Get sales Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)  
[Troubleshoot issues with lead qualification issues](/troubleshoot/dynamics-365/sales/troubleshoot-lead-qualification-issues-for-salespeople)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
