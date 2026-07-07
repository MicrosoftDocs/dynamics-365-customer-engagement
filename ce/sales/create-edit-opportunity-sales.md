---
title: Create or edit opportunities
description: An opportunity is a deal you're ready to win. Create an opportunity record for a lead who's ready to buy.
ms.date: 07/07/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-opportunity
  - D365-Entity-lead
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Create or edit opportunities

Create an opportunity when your lead is almost ready to buy. With an opportunity, you can forecast sales revenue, set a potential close date, and factor in a probability for the sale to occur.

## How to create an opportunity

Use one of the following methods to create an opportunity:

- [Convert a lead to an opportunity](qualify-lead-convert-opportunity-sales.md), if the opportunity originated from a lead. In this case,
  - Information from the lead record is copied to the opportunity.
  - The lead and opportunity records are linked. All the activities and notes in the lead record also becomes available in the corresponding opportunity record.
- [Create an opportunity](#create-a-new-opportunity) from scratch if it didn't originate from a lead.

## Create a new opportunity

Create an opportunity with the details you have. You can update the opportunity as you progress through the different stages of the opportunity - Qualify, Develop, Propose, and Close.

**To create an opportunity:**

<a name="create-sales-hub"></a>

1. In the Sales Hub site map, select **Opportunities**.

2. On the command bar, select **New**.

3. In the **Summary** tab, capture important details about the opportunity. The following list describes fields that require explanation:
   - **Topic**: Specify a brief summary of the opportunity. Include details such as the product, quantity, and customer name. A well-written topic helps your stakeholders spot the opportunity by just glancing through the opportunity list. **Example:** 125 CRM licenses for Contoso inc.
   - **Currency**: Select the currency to use for calculating money values in the opportunity.
     > [!NOTE]
     > - Your base record and all its line items must use the same currency. For example, if your opportunity has the currency set to US Dollars, you must use the same currency for the price list items that you add to the opportunity. You can't change the currency of the base record (in this case, an opportunity), unless you remove all the list items associated with the record.
     > - Similarly, all the records created from an opportunity, such as a quote, order or invoice must use the same currency as the opportunity.

4. If you're not yet ready to add products to the opportunity, you can specify the estimated revenue. Select the pull-down menu after the **Owner** name at the top-right corner of the opportunity and update the estimated revenue and estimated close date as shown in the following screenshot:
:::image type="content" source="media/opportunities-est-details.png" alt-text="Screenshot of the estimated revenue and close date update menu.":::

    > [!NOTE]
    > When you're ready to add products, you can choose to auto-calculate the revenue based on the products added, price list, discounts and so on.

5. Select **Save**.

## Copy an opportunity (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

You can copy an opportunity to quickly create repeat deals by duplicating existing opportunities. This method saves time on data entry, ensures consistency across related deals, and lets you review and modify key details before saving. For example, if you close a deal with a customer and want to create a follow-up opportunity with similar terms, you can copy the original opportunity, update the relevant fields (like dates and amounts), and create a new deal in seconds instead of manually re-entering all the information.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

1. Open an existing opportunity, or go to the opportunity grid view and select a single opportunity.

1. On the command bar, select **Copy opportunity**.

   > [!NOTE]
   > The **Copy opportunity** button appears only when:
   > - You have **Create** permission on the **Opportunity** entity.
   > - Your system administrator didn't [disable the copy opportunity feature](disable-copy-opportunity.md).

1. Review the new opportunity.

   The following table shows what gets copied initially, what gets copied after save, what gets reset, and what's not copied:

   | Category | Details |
   |----------|---------|
   | **Copied initially** | - Account, primary contact, and currency<br>- Estimated value, budget, description, purchase timeframe, and ratings |
   | **Copied after save** | - Every product line item (quantity, pricing; inactive products skipped)<br>- Every stakeholder connection, role, and description<br>- All custom fields (including hidden and off-form fields) |
   | **Reset to default values** | - Status -> **Open**<br>- Sales process stage -> first stage<br>- Owner -> user initiating the copy<br>- Created and modified timestamp -> current date and time<br>- Actual close date -> blank<br>- Actual revenue -> blank<br>- Competitor -> blank (when copying lost deal) |
   | **Not copied** | - Activities<br>- Notes and attachments<br>- Quotes<br>- Orders<br>- Invoices<br>- Timeline |

1. Save the opportunity and verify that all items are copied as shown in the preceding table.

1. Review the **Timeline** section to know which fields are copied, which fields are reset, and which products are skipped.

## Typical next steps

:::image type="icon" source="media/orange-right-arrow-button.png" border="false"::: [Find and add multiple products to an opportunity](add-products-enhanced-experience.md)  
:::image type="icon" source="media/orange-right-arrow-button.png" border="false"::: [Add stakeholders, sales team, and competitors for the opportunity](add-stakeholder.md)  
:::image type="icon" source="media/orange-right-arrow-button.png" border="false"::: [Move the opportunity through different stages](move-opportunity-stages.md)  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Import opportunity records](/powerapps/user/import-data)
- [Learn about the sales process, nurturing sales from lead to order](nurture-sales-from-lead-order-sales.md)
- [View relationship insights for the opportunity](relationship-analytics.md)
- [Add products to an opportunity](add-products-opportunity.md)
- [Add products to an opportunity using the enhanced experience](add-products-enhanced-experience.md)
- [Recalculate an opportunity](recalculate-opportunity.md)
- [Close an opportunity](close-opportunity-won-lost-sales.md)
- [Work with opportunities in the Kanban view](opportunity-kanban-view.md)
- [Troubleshooting the Opportunity entity](ts-opportunities.md)
- [Boost sales with Versium Predict](../versium-predict/versium-predict.md)
- [Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)
- [Print quote, invoice, or other records](print-records.md)
- [Troubleshoot issues with opportunities](/troubleshoot/dynamics-365/sales/troubleshoot-opportunities-issues#opportunity-issues-and-resolution-for-salespeople)

[!INCLUDE[footer-include](../includes/footer-banner.md)]