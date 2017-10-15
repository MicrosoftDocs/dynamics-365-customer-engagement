---
title: "Create or edit an opportunity (Dynamics 365 for Sales) | MicrosoftDocs"
description: "An opportunity is a deal you're ready to win. Create an opportunity record for a lead that's ready to buy."
keywords: "opportunity, deal, develop, propose, nurture sales"
ms.date: 09/22/2017
ms.service: crm-online
ms.custom: 
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 692b7303-d9e1-4323-9e81-ab0dee4cfd2d
author: shubhadaj
ms.author: shujoshi
manager: amyla
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 58
topic-status: Drafting
---

# Create or edit an opportunity (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

An opportunity is a lead who is now almost ready to buy—in other words, it's a deal that you're ready to win.  
  
 At this point in the sales process, you're most likely in either the **Develop** or **Propose** stage. More information: [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
  
<a name="bkmk1"></a>   
## Create an opportunity (Sales Hub)

If you're following the sales process from start to finish, you qualify a lead to turn it into an opportunity. [!INCLUDEproc-more-information]  Qualify a lead and convert it to an opportunity
1. Select the **Site Map** icon ![Site Map icon](media/site-map-icon.png "Icon for Site Map"), and then select **Opportunities**.

2. If you've qualified a lead to an opportunity, open the opportunity from the list.

  -OR-

  To create a new opportunity, on the command bar, select **+ New**.
3. In the opportunity form, make sure that your potential customer's important details are captured. If you've qualified a lead to an opportunity, most of the fields are automatically populated from the lead record.
 
  - **Topic**. Interest of the opportunity, such as specific product details.
 
  - **Contact**. The contact associated with this opportunity.
 
  - **Account**. The account associated with this opportunity.
 
  - **Purchase timeframe**. The timeframe by when the account or contact is likely to purchase.
 
  - **Budget Amount**. 
 
  - **Purchase Process**. Indicates whether the purchase process involves and individual or a committee.
 
  - **Est. Close Date**. An estimated date by which the opportunity is expected to close. 
 
  - **Est. Revenue**. Opportunities with products added to them have their estimated revenue value calculated based on the base price, volume discounts, manual discounts, taxes, and other pricing modifications. When opportunities are saved, [!INCLUDEpn-ms-dyn-365-for-sales] recalculates the estimated revenue value based on any changes to the products or product quantities associated with the opportunity.
4.	Select **Save** to enable other sections on the form.

5.	In the **Stakeholders** section, select **+ New Connection**  to add a stakeholder (key contact at the account). A stakeholder is a person at the account who will be involved in decision-making.

  In the box that appears, type a name, or select the Lookup icon to see a list of suggestions. When you have entered the desired name, press the Enter key. To create a new contact, select **+ New**.

6.	In the **Sales Team** section, select **+ New Connection** to add a member of the sales team (from your organization).

7.	In the **Competitors** section, select **Add Existing Competitor** to add a competitor who's competing your organization for this opportunity.

8.	To save your changes, on the command bar, **Save**.

9.	Add products to your opportunity. For more information, see [Add products to an opportunity](#add-products-to-an-opportunity-sales-hub). 

10.	Follow the process bar to move the opportunity to the next stage. In the **Develop** stage, enter data for these fields:
    
    - **Customer Need**. Enter what interests the opportunity, such as specific product requirements.
    
    - **Proposed Solution**. Enter the plan for what your organization can offer the account, such as product details.
    
    - **Identify Stakeholders**. Select the check box to indicate that you've included information about who will be involved in pursuing the opportunity.
    
    - **Identify Competitors**. Select the check box to indicate that you've included information about competitors.

11.	 In the **Propose** stage, select the Mark Complete check box for each of the following steps that you've completed:
    
    - **Identify Sales Team**
    
    - **Develop Proposal**. Select the check box to indicate you've included notes on how the account will be approached (optional).
    
    - **Complete Internal Review**
    
    - **Present Proposal**

The next step is to create and send a quote to your customer. More information. Create and send a quote to your customer.

<a name="bkmk2"></a>   
## Add products to an opportunity (Sales Hub)

1. To add products to the opportunity, select the **Product Line Items** tab.

2. In the list of opportunities, open the opportunity to which you want to add products.

3. Go to the **Product Line Items** tab.

4. Select a Price List.

5. If you want the pricing of the products to be automatically calculated based on the products and quantities added, toggle the **Revenue** field to **System Calculated**. If not, toggle it to **User Provided**.

6. In the **Product Line Items** grid, select **Add New Opportunity Product**.

7. In the **New Opportunity Product** form, do the following, and on the command bar, select **Save**:

  1. **Select Product**. Toggle the field to indicate whether you want to add an existing product or create a new one.
       
    To use an existing product, select the Lookup button to search for and add a product.
  
    To create a write-in product, select **Write-In**, and then type the name of the product.
    
  2. **Pricing**. Select the pricing option. By default, this uses the price that is listed in the product catalog. To override the price, select **Override Price**. When you override the price, you can specify a price that you want to charge for each unit of the product.
    
  3. **Quantity**. Enter the quantity of the product or service that will be included.

  4. **Manual Discount**. If you want, you can enter a discount to the product.
    
  5. **Tax**. If required, enter the appropriate tax amount.

8. Select **Save**.

<a name="bkmk3"></a>   
## Recalculate an opportunity (Sales Hub)

To change the estimated revenue value of an opportunity based on any changes to the associated products or product quantities, recalculate the opportunity.

1.	In the list of opportunities, open the opportunity for which you want to recalculate the estimated revenue.

2.	Go to the **Product Line Items** tab, and verify that the **Revenue** field is set to **System Calculated**.

3.	In the grid, modify the list of products associated with the opportunity.

4.	Select **Save**.

5.	On the command bar, select **Recalculate Opportunity**.


<a name="bkmk4"></a>   
## Create an opportunity  (Sales app)
 If you're following the sales process from start to finish, you qualify a lead to turn it into an opportunity. More information: [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
  
 If you want to create an opportunity without first creating a lead, do the following:  
  
1. [!INCLUDE[proc_sales_opportunities](../includes/proc-sales-opportunities.md)]  
  
2.  Select **New**.  
  
3.  In the **Summary** area of the **Opportunity** screen, type your opportunity's company and contact information.  
  
4.  In the **Details** area of the **Opportunity** screen, type information about your opportunity's industry and preferred contact method.  
  
5.  Add any notes and activities (for example, phone calls or emails) related to this opportunity. More information: [Keep track of notes, tasks, calls, or email with activities](../basics/work-with-activities.md)  
  
6.  To add stakeholders, in the **Stakeholders** area, select **+**.  
  
7.  To add sales team members, in the **Sales Team** area, select **+**.  
  
8.  To add competitors, in the **Competitors** area, select **+**.  
  
9. To add products, in the **Products** area, select **+**.  
  
10. To add a quote, in the **Quotes** area, select **+**. More information: [Create or edit a quote](../sales-enterprise/create-edit-quote-sales.md)  
  
11. Select the **Save** button on the bottom right of the screen.  
  
  
<a name="bkmk5"></a>   
## Additional considerations  
  
-   A way that might help you increase your sales is to add all products that your customer might need. You can add product bundles or product families to make it easier for you to choose products for upsell and cross-sell.  
  
-   If other people in your organization are working on this sale, be sure to add them as sales team members.  
  
-   Nurture your opportunities through a marketing campaign. More information: [Get started with in-app marketing](../sales-enterprise/get-started-with-app-marketing-sales.md)  (Applies only to Sales app)
  
<a name="bkmk6"></a>   
## Tips and tricks  
 Need a faster way to enter opportunities? Try one of these:  
  
-   [Quick create--Enter new contacts (or other data)--fast!](../basics/quick-create-enter-data-fast.md)  
  
-   [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)  
  
<a name="bkmk7"></a>   
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Create or edit a quote](../sales-enterprise/create-edit-quote-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)—learn about the sales process  
  
### See also  
 [Run a report](../basics/run-report.md)   
 [Assign a record to a user or team](../basics/assign-record-user-team.md)      
 [Stay up-to-date with customer news with the activity feed](../basics/stay-up-date-with-customer-news-with-activity-feed.md)   
 [Print leads, quotes, and other records](../basics/print-leads-quotes-other-records.md)   
 [Boost sales with Versium Predict](../versium-predict/versium-predict.md)   
 [Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)   
